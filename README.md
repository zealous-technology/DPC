# DPC
A simple .NET 6 Web API with one endpoint: /greeting GET

CI/CD Pipeline
--------------
The pipeline consists of 2 jobs.

code-analysis
----------------
Integrates with SonarCloud to detect code quality issues and ensure the maintainability, reliability and security of your code

build docker image
------------------
1. check out the repository
2. install .net 6
3. restore the application dependencies
4. build
5. run unit tests
6. install docker env
7. log into docker hub (SECRET username and Docker token)
8. build image and push to docker hub (steveager/dpc)

Image Testing
-------------
The image can be tested in Play with Docker https://labs.play-with-docker.com/
1. docker pull steveager/dpc
2. docker run -d --rm --name web -p 3000:80 steveager/dpc
3. curl localhost:3000/greeting
