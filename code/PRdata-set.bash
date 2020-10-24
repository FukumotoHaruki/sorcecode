#引数でgithubのtoken-IDを与える．
touch ~/Desktop/Master/xetorthio_jedis.csv

while read PRID || [ -n "${PRID}" ]; do
    ID=`echo ${PRID} | cut -d , -f 1`
    result=`echo ${PRID} | cut -d , -f 2`
    hash=`echo ${PRID} | cut -d , -f 3`

    echo ${ID}"+++++++++++++++++++++++++++++++++++"
    
    while read check || [ -n "${check}" ]; do
        checkID=`echo ${check} | cut -d , -f 1`
        len=`echo ${check} | cut -d , -f 4`
        hashm=`echo ${check} | cut -d , -f 7`

        if [ ${ID} = ${checkID} ]; then
            if [ ${result} = "improvement" ]; then
                echo ${ID},${ID},${result},${len},${hash},${hashm},"None","None" >> ~/Desktop/Master/xetorthio_jedis.csv
            else
                echo ${ID},${ID},${result},${len},"None",${hashm},"None","None" >> ~/Desktop/Master/xetorthio_jedis.csv
            fi
        else
            :
        fi

    done < ~/Desktop/Master/xetorthio_jedis01.csv

done < ~/Desktop/Master/PRresult.csv