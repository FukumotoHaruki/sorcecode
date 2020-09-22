for i in {1..41} ; do
    curl https://github.com/google/closure-compiler/pulls?page=${i}\&q=is%3Apr+is%3Aclosed | grep -op 'div id="issue_.*' | sed 's/^div id=\"issue\_//' | sed -e 's/\".*//' >> PRID.txt
done