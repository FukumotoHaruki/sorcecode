#引数でgithubのtoken-IDを与える．
touch ~/Desktop/Master/PRresult.csv

while read PRID || [ -n "${PRID}" ]; do
    ID=`echo ${PRID} | cut -d , -f 1`
    result=`echo ${PRID} | cut -d , -f 2`

    echo ${ID}"+++++++++++++++++++++++++++"

    mkdir ~/Desktop/Master/PR-result-check/${ID}

    #commitのデータを取得する（ユーザ名，コミット日時，ハッシュ値）
    curl -H "Authorization: token $1" https://api.github.com/repos/xetorthio/jedis/pulls/${ID}/commits | jq -r '.[] | [.commit.author.name , .commit.author.date , .sha] | @csv' | sed "s/^/commit-date\,/g" | sed "s/\"//g" | sed "s/ //g" >> ~/Desktop/Master/PR-result-check/${ID}/data.csv
    developer=`cut -d , -f 2 ~/Desktop/Master/PR-result-check/${ID}/data.csv | head -n 1`
    #commentのデータを取得する（ユーザ名，コミント日時，ID）
    curl -H "Authorization: token $1" https://api.github.com/repos/xetorthio/jedis/issues/${ID}/comments | jq -r '.[] | [.user.login , .created_at , .id] | @csv' | sed "s/^/comments-date\,/g" | sed "s/\"//g" | sed "s/ //g" >> ~/Desktop/Master/PR-result-check/${ID}/data.csv
    #sleep 8s
    #日付順にソートする
    sort -k 3 -t , ~/Desktop/Master/PR-result-check/${ID}/data.csv > ~/Desktop/Master/PR-result-check/${ID}/Redata.csv

    flag=0
    hash="P0-hash"
    while read data || [ -n "${data}" ]; do
        type=`echo ${data} | cut -d , -f 1`
        user=`echo ${data} | cut -d , -f 2`
        date=`echo ${data} | cut -d , -f 3`

        #検証者からのコメントがあるタイミングを調べる
        if [ ${type} = "comments-date" ] && echo ${user} | grep -iqvF ${developer} ; then
            flag=1
        else
            :
        fi

        #コメントがない間はhash値を更新し続ける（コメントの前のhash値を取得できる）
        if [ ${flag} -eq 0 -a ${type} = "commit-date" ]; then
            hash=`echo ${data} | cut -d , -f 4`
        else
            :
        fi

        #検証者からコメントがあり，その後にコミットがある場合にimprovementと判断し，ループを抜ける
        if [ ${flag} -eq 1 -a ${type} = "commit-date" ]; then
            echo ${ID},"improvement",${hash} >> ~/Desktop/Master/PRresult.csv
            flag=2
            break
        else
            :
        fi
    done < ~/Desktop/Master/PR-result-check/${ID}/Redata.csv

    #improvementと判断されなければ，mergeかcloseを答える．
    if [ ${flag} -eq 2 ]; then
        :
    else
        echo ${ID},${result} >> ~/Desktop/Master/PRresult.csv
    fi

    
done < ~/Desktop/Master/result5.csv