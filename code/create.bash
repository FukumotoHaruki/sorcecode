while read pullrequID || [ -n "${pullrequID}" ]; do
    column1=`echo ${pullrequID} | cut -d , -f 1`
    
    cat hash/${column1}/hash.csv >> ~/Desktop/check/hash.csv
    if [ ! -s hash/${column1}/hash.csv ]; then
        echo "no date..."
        echo ${column1}
    else
        :
    fi
done < ~/Desktop/check/PRID.csv