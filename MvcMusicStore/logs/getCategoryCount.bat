@echo off
LOGPARSER "SELECT COUNT(Text) FROM '*.log' WHERE Text LIKE '%1'" -i:TEXTLINE -q:Off
LOGPARSER "SELECT Text FROM '*.log' WHERE Text LIKE '%1'" -i:TEXTLINE -q:Off
pause