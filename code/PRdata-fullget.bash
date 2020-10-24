#引数でgithubのtoken-IDを与える．
#PRが存在するページ数分ループさせる
for i in {1..$3} ; do
    #ページに存在するすべてのPRのIDを取得する
    curl https://github.com/$1/$2/pulls?page=${i}\&q=is%3Apr+is%3Aclosed | grep -op 'div id="issue_.*' | sed 's/^div id=\"issue\_//' | sed -e 's/\".*//' >> $1-$2-PRID.csv
done

while read PRID || [ -n "${PRID}" ]; do
    ID=`echo ${PRID} | cut -d , -f 1`
    PRdata=`curl -H "Authorization: token $4" https://api.github.com/repos/$1/$2/pulls/${ID} | jq -r '[.merged , .commits , .head.sha] | @csv' | sed "s/\"//g"`
    stats=`echo ${PRdata} | cut -d , -f 1`
    len=`echo ${PRdata} | cut -d , -f 2`
    hash_M=`echo ${PRdata} | cut -d , -f 3`

    if [ ${stats} = false ]; then
        result="close"
    elif [ ${stats} = true ]; then
        result="merge"
    else
        result="error"
    fi

    hash_data=`curl -H "Authorization: token $4" https://api.github.com/repos/$1/$2/pulls/${ID}/commits | jq -r '[.[0].sha , .[0].parents[].sha] | @csv' | sed "s/\"//g"`
    hash_1=`echo ${hash_data} | cut -d , -f 1`
    hash_0=`echo ${hash_data} | cut -d , -f 2`

    echo ${ID},${ID},${result},${len},${hash_0},${hash_1},${hash_M} >> $1_$2.csv
done < $1-$2-PRID.csv