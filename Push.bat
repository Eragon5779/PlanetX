@echo off
set /p comMessage=Enter Commit Message: 
git pull
git add *
git commit -m "%comMessage%"
git push