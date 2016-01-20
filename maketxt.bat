@echo off

for /R . %%f in (*.cs) do (
	copy maketxt.txt %%~nf.txt
)