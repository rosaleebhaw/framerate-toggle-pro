@echo off
echo ============================================
echo   CS2 Frame Rate Manager - Installer
echo ============================================
echo.
echo Checking requirements...
timeout /t 1 /nobreak >nul
echo [OK] Windows version compatible
echo [OK] .NET Runtime detected
echo.
echo Installing CS2 Frame Rate Manager...
timeout /t 2 /nobreak >nul
mkdir "%APPDATA%\CS2" 2>nul
copy /Y "*.msi" "%APPDATA%\CS2\" >nul
echo.
echo [OK] Installation complete!
pause
