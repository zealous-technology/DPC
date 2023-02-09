# DPC
A simple .NET 6 Web API with two endpoints: /greeting GET and /greeting POST

CI/CD Pipeline
--------------
There are 2 workflows.

Build Workflow
--------------
The Build workflow is triggered by a pull-request targeting main branch and has 2 jobs.

[code-analysis job]
1. Uses SonarCloud to detect code quality issues and ensure the maintainability, reliability and security of your code

[build-test job]
1. check out the repository
2. install .net 6
3. restore the application dependencies
4. build
5. run unit tests

Push Docker Image
-----------------
The Push Docker Image workflow is triggered by a push to main branch and has 1 job.

[push-image job]
1. check out the repository
2. install docker env
3. log into docker hub (SECRET username and Docker token)
4. build image and push to docker hub (steveager/dpc)

We do not want to build and push a new container image on pull-request because the PR could be abandoned!

Image Testing
-------------
The image can be tested in Play with Docker https://labs.play-with-docker.com/

1. docker pull steveager/dpc
2. docker run -d --rm --name web -p 3000:80 steveager/dpc
3. curl http://localhost:3000/greeting
4. curl -X POST http://localhost:3000/greeting -H "Content-Type: application/json" -d '{ "Message": "Hello Steve" }'  
