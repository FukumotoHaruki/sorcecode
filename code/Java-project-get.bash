#Javaprojectのurl取得
#pom.xmlがあるかを確認
while read Jproject || [ -n "${Jproject}" ]; do
    #project/repo
    column2=`echo ${Jproject} | cut -d , -f 2`

    #pomが存在するかをチェック
    curl https://github.com/${column2} > ~/Desktop/PRdata-get/curl.txt
    grep -p "/${column2}/blob/master/pom.xml" ~/Desktop/PRdata-get/curl.txt
    if [ $? = 0 ]; then
        echo "include-Pom" >> ~/Desktop/PRdata-get/pom-check.csv
    else
        echo "none" >> ~/Desktop/PRdata-get/pom-check.csv
    fi

    #PR数の取得
    curl https://github.com/${column2}/pulls | grep -e "Closed" | sed -e "s/,//" | sed -e "s/ *//" | sed -e "s/ Closed//" | sed -n 1p >> ~/Desktop/PRdata-get/pulls-num.csv
    #mergeされたPR数の取得
    curl https://github.com/${column2}/pulls?q=is%3Apr+is%3Aclosed++is%3Amerged | grep -e "Total" | sed -e "s/,//" | sed -e "s/ *//" | sed -e "s/ Total//" | sed -n 1p >> ~/Desktop/PRdata-get/merged.csv
    
    #連続でアクセスしないように処理
    sleep 1s
done < ~/Desktop/PRdata-get/javaproject.csv