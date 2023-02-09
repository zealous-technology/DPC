The image can be tested in Play with Docker https://labs.play-with-docker.com/

docker pull steveager/dpc
docker run -d --rm --name web -p 3000:80 steveager/dpc

use the GET endpoint to get the greeting
curl http://localhost:3000/greeting

use the POST endpoint to create a new greeting
curl -X POST http://localhost:3000/greeting -H "Content-Type: application/json" -d '{ "Message": "Hello Steve" }'  