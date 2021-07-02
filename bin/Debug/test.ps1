cd "C:\Users\SijiaCui\Desktop\genData\bin\Debug";
Get-Date -Format "yyyy-MM-dd HH:mm:ss" > .\tmp\last_modified;
cd "C:\Program Files\MySQL\MySQL Server 8.0\bin";
./mysqldump.exe -uroot -ptest123 ttt --result-file=C:\Users\SijiaCui\Desktop\genData\bin\Debug\tmp\db\1.mysql ;
cd "C:\Users\SijiaCui\Desktop\genData\bin\Debug";
Get-ChildItem -Path ./tmp -Recurse |  Compress-Archive -Force -DestinationPath test.zip;
Remove-Item -Path ./tmp -Recurse