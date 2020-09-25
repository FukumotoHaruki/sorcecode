#PRが存在するページ数分ループさせる
for i in {1..41} ; do
    #ページに存在するすべてのPRのIDを取得する
    curl https://github.com/google/closure-compiler/pulls?page=${i}\&q=is%3Apr+is%3Aclosed | grep -op 'div id="issue_.*' | sed 's/^div id=\"issue\_//' | sed -e 's/\".*//' >> PRID.txt
done