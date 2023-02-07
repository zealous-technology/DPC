# DPC
A simple .NET 6 Web API with one endpoint: /greeting GET

CI/CD Pipeline
--------------
1. checks out the repository
2. installs .net 6
3. restores the application dependencies
4. builds the application
5. runs the unit tests
6. installs docker build env
7. logs into docker hub
8. builds the image and pushes it to docker hub (steveager/dpc)

Image Testing
-------------
The image can be tested in Play with Docker https://labs.play-with-docker.com/
1. docker pull steveager/dpc
2. docker run -d --rm --name web -p 3000:80 steveager/dpc
3. curl localhost:3000/greeting

