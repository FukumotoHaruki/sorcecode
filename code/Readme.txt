・a.bash
試したいことを自由に実行する．

・Java-project-get.bash
Javaのプロジェクトのリストからpomを含むか否かを判定する．（Javaプロジェクトを取得することも可能）

・PR-Classification.bash
PRにおけるレビュー結果を判定する．（院の研究）
improvement時のハッシュ値も取得する．

・PRdata-set.bash
PRのデータを取得し，csvファイルを取得する．（院の研究）

・PRID_get.bash
プロジェクト内のCloseとなっているPRのIDを取得する．

・PRdata-fullget.bash
PRのハッシュ値を取得する．（0と1とm）

######
１：PRdata-fullget.bashで学部の研究のPRデータが揃う．
２：PR-Classification.bashで院の研究のPRデータが揃う．
１，２の順番で実行する必要がある．
######