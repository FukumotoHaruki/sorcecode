while read path; do
    column1=`echo ${path} | cut -d , -f 1`
    column2=`echo ${path} | cut -d , -f 2`

    curl https://github.com/${column2}/${column1}/pulls | grep -e "Closed" >> ~/Desktop/PRdata-get/Closed-pull.csv

done < ~/Desktop/PRdata-get/Java.csv