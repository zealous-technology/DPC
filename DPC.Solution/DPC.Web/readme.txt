The image can be tested in Play with Docker https://labs.play-with-docker.com/

1. docker pull steveager/dpc
2. docker run -d --rm --name web -p 3000:80 steveager/dpc
3. curl http://localhost:3000/greeting
4. curl -X POST http://localhost:3000/greeting -H "Content-Type: application/json" -d '{ "Message": "Hello Steve" }'  