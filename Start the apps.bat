@ECHO OFF
ECHO Starting SpaceExploreCrewService...
cd SpaceExploreCrewService\bin\Debug\netcoreapp3.1
ECHO InFolder: %CD%
start SpaceExploreCrewService.exe
cd ..\..\..\..
ECHO InFolder: %CD%
ECHO Starting ApiGateWay...
cd ApiGateWay\bin\Debug\netcoreapp3.1
ECHO %CD%
start ApiGateWay.exe
cd ..\..\..\..
ECHO Starting SpaceExplorePlanetService...
cd SpaceExplorePlanetService\bin\Debug\netcoreapp3.1
ECHO %CD%
start SpaceExplorePlanetService.exe
cd ..\..\..\..
ECHO Starting Angular Web Application...
cd SpaceExploreWebApp
npm start
cd ..
