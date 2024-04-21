@echo on
echo %(SolutionDir)\packages
%(SolutionDir)\packages\packages\LibZ.Bootstrap\1.2.0\tools\libz sign-and-fix --include *.dll --include *.exe --key %1FortyOne.AudioSwitcher\fortyone.snk 
%1\packages\LibZ.Bootstrap\1.2.0\tools\libz inject-dll --assembly=AudioSwitcher.exe --include=*.dll --key %1FortyOne.AudioSwitcher\fortyone.snk --move