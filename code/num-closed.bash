while read path || [ -n "${path}}" ]; do
    #repository名
    column1=`echo ${path} | cut -d , -f 1`
    #project名
    column2=`echo ${path} | cut -d , -f 2`

    #GitHubからリポジトリ毎にPRのClose数を取得する．
    curl https://github.com/${column2}/${column1}/pulls | grep -e "Closed" >> ~/Desktop/PRdata-get/Closed-pull.csv

done < ~/Desktop/PRdata-get/Java.csv