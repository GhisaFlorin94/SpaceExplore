# SpaceExplore

SpaceExplore app

The solution contains 4 (3 microservices and 1 webApi) apps (all the web api apps are build with .NET Core 3.1).</br></br>
1 - An API GateWay (run at http://localhost:5010/)</br>
2 - An WebApi for Planet (run at http://localhost:5011/)</br>
3 - An WebApi for Crew (run at http://localhost:5012/)</br>
4 -Angular app using "typescript": "~2.5.3" and Angular 5.2
(will run at http://localhost:4200/)</br>
</br></br>
Steps to Run:
1 - Download the app zip and un-zip-ut</br>
2 - Go to SpaceExploreWebApp and from terminal run "npm install"
3 - Open the app in Visual Studio and build the app
4 - Set SpaceExploreCrewService as starting project and from Package Manager Console, put Default project : SpaceExploreCrewService and run "Update-Database"
5 - Repet step 4 with SpaceExplorePlanetService
6 - From Terminal go to the root folder of the app. Run "Start the apps.bat" that will open all the apps. The Web app will be open with "npm start" but it will block. Probably you will have to press some key to unlock it
