@echo off
REM Script to commit all changes with backdated timestamp (15 days ago)
REM Commit message: "Lab5 Commit"

echo Starting backdated commit process...

REM Add all changes to staging (including untracked files)
git add -A
echo All files staged for commit...

REM Use PowerShell to calculate date 15 days ago
for /f "delims=" %%i in ('powershell -command "(Get-Date).AddDays(-15).ToString('yyyy-MM-dd HH:mm:ss')"') do set "BackDate=%%i"

echo Committing with date: %BackDate%

REM Set environment variables for git commit date
set GIT_AUTHOR_DATE=%BackDate%
set GIT_COMMITTER_DATE=%BackDate%

REM Commit with backdated author and committer dates
git commit -m "Lab5 Commit"

echo Commit completed successfully!
echo Note: This only affects local repository. Push to remote when ready.
pause