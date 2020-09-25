: <<'#Preparation'
・Desktopにリポジトリをクローン
・mvn3.1以上 java1.8 
・brew install coreutilsでgsplitをinstall
・~/getにevosuiteのjarを2種類とjunit,hamcrestのjarを入れておく
・source ~.bash (プロジェクト名) (リポジトリ名)で実行
#Preparation
########################################################
# $1：プロジェクト名 ,$2：リポジトリ名

#必要なディレクトリの生成
mkdir ~/Desktop/fukumoto/sub/$1-$2-recode
mkdir ~/Desktop/fukumoto/sub/$1-$2-backup

#プルリクエストを1行ずつ読み込む
while read pullrequID || [ -n "${pullrequID}" ]; do

    #必要なフォルダの作成
    rm -r ~/Desktop/fukumoto/sub/$2
    unzip -q ~/Desktop/fukumoto/sub/$2.zip -d ~/Desktop/fukumoto/sub
    mkdir ~/Desktop/fukumoto/sub/$1-$2-backup/count
    mkdir ~/Desktop/fukumoto/sub/$1-$2-backup/diff
    mkdir ~/Desktop/fukumoto/sub/$1-$2-backup/path
    mkdir ~/Desktop/fukumoto/sub/$1-$2-backup/log

    #必要な情報（１：ID，５：P0のハッシュ値，６：P1のハッシュ値，９：diffのURL）
    column1=`echo ${pullrequID} | cut -d , -f 1`
    column5=`echo ${pullrequID} | cut -d , -f 5`
    column6=`echo ${pullrequID} | cut -d , -f 6`
    column9=`echo ${pullrequID} | cut -d , -f 9`

    #ハッシュ値の読み込み・切り替え(program0)
    cd ~/Desktop/fukumoto/sub/$2
    git checkout ${column5}

    #diffの取得(---,+++の部分)
    column9=${column9%$'\r'}
    curl ${column9} | grep -e "^--- " -e "^+++ " > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff.txt
    #diffの分割(2行ごとに分割，４桁の番号をつける)
    split -l 2 -a 4 -d ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff.txt ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff_
    ls ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff_* | while read i;do mv $i $i.txt ;done
    #変更ファイル数の取得
    cd ~/Desktop/fukumoto/sub/$1-$2-backup/diff
    ls -1 | wc -l ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff_*.txt
    find . -type f -name "diff_*.txt" | wc -l | sed -e "s/ //g" > ~/Desktop/fukumoto/sub/$1-$2-backup/count/count.txt
    cd ~/Desktop/fukumoto/sub/$2
    filenum=$(<~/Desktop/fukumoto/sub/$1-$2-backup/count/count.txt)
    #Javaファイル以外なら除外
    javanum=0
    for ((j=0; j < $filenum; j++));do
        num=$(printf "%04d\n" $j)
        grep -e "\.java" ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff_${num}.txt
        if [ $? = 0 ]; then
            #grep検索にマッチした行があり
            javanum=$(($javanum+1))
        else
            #grep検索にマッチした行はなし
            continue
        fi
    done
    
    #Javaファイル数が一定以上であれば実行しない
    if [ $javanum -gt 5 ]; then
        #javaの数が5より大きい，実行しない
        mkdir ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}
        mv ~/Desktop/fukumoto/sub/$1-$2-backup/* ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}
        continue
    else
        #javaの数が5より小さい，javaファイルの有無をチェック
        grep -e "\.java" ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff.txt
        if [ $? = 0 ]; then
            #javaファイルあり
            :
        else
            #javaファイルなし，実行しない
            mkdir ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}
            mv ~/Desktop/fukumoto/sub/$1-$2-backup/* ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}
            continue
        fi
    fi

    #ファイルパスの取得
    for ((j=0; j < $filenum; j++));do
        num=$(printf "%04d\n" $j)
        #必要なディレクトリを生成
        mkdir ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}
        mkdir ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}
        mkdir ~/Desktop/fukumoto/sub/$1-$2-backup/log/${num}
        #diffを---と+++に分ける
        grep -e "---" ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff_${num}.txt > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt
        grep -e "+++" ~/Desktop/fukumoto/sub/$1-$2-backup/diff/diff_${num}.txt > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}+.txt
        #javaのパス(/区切り)
        grep -o '\/.*$' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt | sed -e "s/^\///" > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-2.txt
        grep -o '\/.*$' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}+.txt | sed -e "s/^\///" > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}+2.txt
        #javaのパス(.区切り)
        grep -o '\/.*$' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt | sed -e "s/^.*src\///" | sed -e 's/\//\./g' > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-3.txt
        grep -o '\/.*$' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}+.txt | sed -e "s/^.*src\///" | sed -e 's/\//\./g' > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}+3.txt
        #pomのあるディレクトリパスを生成
        sed -e "s/src.*//" ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-2.txt > ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt
        #変更されたjavaファイル名を取得
        sed -e "s/\.java\$//" ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-3.txt | sed -e "s/main\.java\.//" > ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testname.txt
        sed -e "s/\.java\$//" ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}+3.txt | sed -e "s/main\.java\.//" > ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testname+.txt
        cat ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt | sed -e "s/.*\///" | sed -e "s/\.java//" > ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/classname.txt
        grep -o '\/.*$' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt | sed -e "s/.*\/src\///" | sed -e "s/$classname\.java//" > ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/classpath.txt
        #変更されたjavaのパス（pomから先のパス）
        sed -e "s/\./\//g" ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testname.txt >  ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testpath.txt

    done

    #program0をコンパイル，依存関係ファイルの取得
    cd ~/Desktop/fukumoto/sub/$2
    mvn compile
    mvn dependency:copy-dependencies


    #依存関係ファイル名をcsvに保存する
    for ((j=0; j < $filenum; j++));do
        cd ~/Desktop/fukumoto/sub/$2/$cdpath
        num=$(printf "%04d\n" $j)
        cdpath=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt)

        if grep -e '\/test\/' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt ; then
            continue
        fi

        ls ~/Desktop/fukumoto/sub/$2/$cdpath/target/dependency | grep -e 'jar' >  ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/all-jar-name.csv
    done

    #Evosuiteの設置とEvosuiteのコンパイル
    for ((j=0; j < $filenum; j++));do
        num=$(printf "%04d\n" $j)
        check=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt)

        if [ $j -ge 1 ]; then
            x=$((j-1))
            Prenum=$(printf "%04d\n" $x)
            check2=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${Prenum}/cdpath.txt)
            
            #同じファイルパスの場所に設置しないようにスキップする
            if [[ $check =~ $check2 ]]; then
                continue
            else
                #必要なものをすべて設置する
                cdpath=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt)
                cp ~/Desktop/fukumoto/sub/get/evosuite-1.0.6.jar ~/Desktop/fukumoto/sub/$2/$cdpath
                cp ~/Desktop/fukumoto/sub/get/evosuite-standalone-runtime-1.0.6.jar ~/Desktop/fukumoto/sub/$2/$cdpath
                cd ~/Desktop/fukumoto/sub/$2/$cdpath
                java -jar evosuite-1.0.6.jar
                export EVOSUITE="java -jar $(pwd)/evosuite-1.0.6.jar"
                $EVOSUITE
            fi
        else
            :
        fi
    done

    #test生成
    for ((j=0; j < $filenum; j++));do
        cd ~/Desktop/fukumoto/sub/$2
        num=$(printf "%04d\n" $j)
        cdpath=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt)
        testname=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testname.txt)
        jar=""

        #testファイルはスキップ
        if grep -e '\/test\/' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt ; then
            continue
        fi

        #依存関係ファイルのパスを生成する
        while read dependencies || [ -n "${dependencies}" ]; do
            x=`echo ${dependencies} | cut -d , -f 1`
            jar="$jar target/dependency/$x"
        done <  ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/all-jar-name.csv


        #ツールの設定＋コンパイル，test生成
        cd ~/Desktop/fukumoto/sub/$2/$cdpath
        java -jar evosuite-1.0.6.jar -setup target/classes $jar
        export EVOSUITE="java -jar $(pwd)/evosuite-1.0.6.jar"
        $EVOSUITE -class $testname -Dassertion_strategy=all -Dminimize=false -Dsearch_budget=3000 -criterion line:branch:weakmutation:output:method > ~/Desktop/fukumoto/sub/$1-$2-backup/log/${num}/maketestlog.txt
    done

    rm -r ~/Desktop/fukumoto/sub/$2/evosuite-report
    #testのコンパイル
    for ((j=0; j < $filenum; j++));do
        cd ~/Desktop/fukumoto/sub/$2
        num=$(printf "%04d\n" $j)
        cdpath=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt)
        testname=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testname.txt)
        testpath=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testpath.txt)
        jar=""
        CLASSPATH=target/classes:evosuite-standalone-runtime-1.0.6.jar:evosuite-tests

        #testファイルならスキップ
        if grep -e '\/test\/' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt ; then
            continue
        fi

        cd ~/Desktop/fukumoto/sub/$2/$cdpath
        #依存関係ファイルにパスを通す
        while read dependencies || [ -n "${dependencies}" ]; do
            line=`echo ${dependencies} | cut -d , -f 1`
            jar="$jar target/dependency/$line"
            export CLASSPATH=$CLASSPATH:~/Desktop/fukumoto/sub/$2/$cdpath/target/dependency/$line
        done <  ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/all-jar-name.csv

        #testファイルのコンパイル
        javac evosuite-tests/$testpath"_ESTest.java"
        javac evosuite-tests/$testpath"_ESTest_scaffolding.java"

        #P0へのtest実行
        jar="target/classes evosuite-tests $jar"
        java -jar evosuite-1.0.6.jar -setup $jar
        export EVOSUITE="java -jar $(pwd)/evosuite-1.0.6.jar"
        $EVOSUITE -measureCoverage -class $testname -Djunit=$testname"_ESTest" -Dsandbox=false -criterion line:branch:weakmutation:output:method -Doutput_variables=TARGET_CLASS,coverage > ~/Desktop/fukumoto/sub/$1-$2-backup/log/${num}/testlog00.txt
    done

    #P0の取得
    for ((j=0; j < $filenum; j++));do
        cd ~/Desktop/fukumoto/sub/$2
        num=$(printf "%04d\n" $j)
        program0=$(<~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-2.txt)
        mkdir ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}_${num}
        mkdir ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}_${num}/program0
        cp ~/Desktop/fukumoto/sub/$2/$program0 ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}_${num}/program0
    done

    #git stash
    #P1のハッシュ値に切り替え
    git fetch origin pull/${column1}/head:${column1}
    git checkout ${column1}
    git checkout ${column6}
    
    #P1の取得
    for ((j=0; j < $filenum; j++));do
        cd ~/Desktop/fukumoto/sub/$2
        num=$(printf "%04d\n" $j)
        program1=$(<~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}+2.txt)
        mkdir ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}_${num}/program1
        cp ~/Desktop/fukumoto/sub/$2/$program1 ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}_${num}/program1
    done
    #コンパイル
    cd ~/Desktop/fukumoto/sub/$2
    mvn compile
    mvn dependency:copy-dependencies


    rm -r ~/Desktop/fukumoto/sub/$2/evosuite-report
    #test実行
    for ((j=0; j < $filenum; j++));do
        cd ~/Desktop/fukumoto/sub/$2
        num=$(printf "%04d\n" $j)
        cdpath=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt)
        testname=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testname.txt)
        testname2=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/testname+.txt)
        jar=""
        CLASSPATH=target/classes:evosuite-standalone-runtime-1.0.6.jar:evosuite-tests

        #testファイルをスキップ
        if grep -e '\/test\/' ~/Desktop/fukumoto/sub/$1-$2-backup/diff/${num}/diff_${num}-.txt ; then
            continue
        fi


        cd ~/Desktop/fukumoto/sub/$2/$cdpath
        #依存関係ファイルにパスを通す
        ls ~/Desktop/fukumoto/sub/$2/$cdpath/target/dependency | grep -e 'jar' >  ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/all-jar-name.csv
        while read dependencies || [ -n "${dependencies}" ]; do
            line=`echo ${dependencies} | cut -d , -f 1`
            jar="$jar target/dependency/$line"
            export CLASSPATH=$CLASSPATH:~/Desktop/fukumoto/sub/$2/$cdpath/target/dependency/$line
        done <  ~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/all-jar-name.csv
        
        #P1へのtest実行
        jar="target/classes evosuite-tests $jar"
        java -jar evosuite-1.0.6.jar -setup $jar
        export EVOSUITE="java -jar $(pwd)/evosuite-1.0.6.jar"
        $EVOSUITE -measureCoverage -class $testname2 -Djunit=$testname"_ESTest" -Dsandbox=false -criterion line:branch:weakmutation:output:method -Doutput_variables=TARGET_CLASS,coverage > ~/Desktop/fukumoto/sub/$1-$2-backup/log/${num}/testlog01.txt
    done
    
    #test結果など必要なものを移動させてリセット
    mkdir ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}
    for ((j=0; j < $filenum; j++)); do
        cd ~/Desktop/fukumoto/sub/$2
        num=$(printf "%04d\n" $j)
        cdpath=$(<~/Desktop/fukumoto/sub/$1-$2-backup/path/${num}/cdpath.txt)
        mkdir ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}/${num}
        mv ~/Desktop/fukumoto/sub/$2/$cdpath/evosuite-tests ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}/${num}
    done
    mv ~/Desktop/fukumoto/sub/$1-$2-backup/* ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}
    mv ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}_* ~/Desktop/fukumoto/sub/$1-$2-recode/$2${column1}
    cd ~/Desktop/fukumoto/sub/$2
    git stash
    #git add -A
    #git commit -m "remove src"
    cd ~
    continue
done < ~/Desktop/fukumoto/sub/$1_$2.csv