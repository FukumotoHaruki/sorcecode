while read pullrequ || [ -n "${pullrequ}" ]; do
    #PRのID
    column1=`echo ${pullrequ} | cut -d , -f 1`
    #P1のhash値
    column9=`echo ${pullrequ} | cut -d , -f 9`
    column9=${column9%$'\r'}

    mkdir ~/Desktop/check/GClosure/diff_count/${column1}
    #diffから変更されたファイル名を取得
    curl ${column9} | grep -e "^--- " -e "^+++ " > ~/Desktop/check/GClosure/diff_count/${column1}/diff.txt
    #diffの分割(2行ごとに分割，４桁の番号をつける)
    gsplit -l 2 -a 4 -d ~/Desktop/check/GClosure/diff_count/${column1}/diff.txt ~/Desktop/check/GClosure/diff_count/${column1}/diff_
    ls ~/Desktop/check/GClosure/diff_count/${column1}/diff_* | while read i;do mv $i $i.txt ;done
    #変更ファイル数の取得
    cd ~/Desktop/check/GClosure/diff_count/${column1}
    ls -1 | wc -l ~/Desktop/check/GClosure/diff_count/${column1}/diff_*.txt
    find . -type f -name "diff_*.txt" | wc -l | sed -e "s/ //g" > ~/Desktop/check/GClosure/diff_count/${column1}/count.txt
    filenum=$(<~/Desktop/check/GClosure/diff_count/${column1}/count.txt)
    
    #Javaファイル以外は除外
    javanum=0
    for ((j=0; j < $filenum; j++));do
        num=$(printf "%04d\n" $j)
        grep -e "\.java" ~/Desktop/check/GClosure/diff_count/${column1}/diff_${num}.txt
        if [ $? = 0 ]; then
        #grep検索にマッチした行があり
            javanum=$(($javanum+1))
        else
            #grep検索にマッチした行はなし
            continue
        fi
    done

    #Javaファイル数を出力
    echo $javanum >> ~/Desktop/check/GClosure/diff_count.csv
done < ~/Desktop/check/GClosure/google_closure-compiler.csv