#PRが存在するページ数分ループさせる
for i in {1..$3} ; do
    #ページに存在するすべてのPRのIDを取得する
    curl https://github.com/$1/$2/pulls?page=${i}\&q=is%3Apr+is%3Aclosed | grep -op 'div id="issue_.*' | sed 's/^div id=\"issue\_//' | sed -e 's/\".*//' >> $1-$2-PRID.csv
done
