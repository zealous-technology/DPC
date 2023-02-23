The image can be tested in Play with Docker https://labs.play-with-docker.com/

1. docker pull steveager/dpc
2. docker run -d --rm --name web -p 3000:80 steveager/dpc
3. curl http://localhost:3000/greeting
4. curl -X POST http://localhost:3000/greeting -H "Content-Type: application/json" -d '{ "Message": "Hello Steve" }'  


Created JWT using http://jwtbuilder.jamiekurtz.com/, expires in 1 year 2024-02-23T16:29:13.825Z
Token: eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJPbmxpbmUgSldUIEJ1aWxkZXIiLCJpYXQiOjE2NzcxNzY0MTAsImV4cCI6MTcwODcxMjQxMCwiYXVkIjoid3d3LmV4YW1wbGUuY29tIiwic3ViIjoianJvY2tldEBleGFtcGxlLmNvbSIsIkdpdmVuTmFtZSI6IkpvaG5ueSIsIlN1cm5hbWUiOiJSb2NrZXQiLCJFbWFpbCI6Impyb2NrZXRAZXhhbXBsZS5jb20iLCJyb2xlIjpbIk1hbmFnZXIiLCJQcm9qZWN0IEFkbWluaXN0cmF0b3IiXX0.xv8IHzuyxYki516lTkfRIKlP1nt0V_14LMYYI18qsWY

curl -H "Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJPbmxpbmUgSldUIEJ1aWxkZXIiLCJpYXQiOjE2NzcxNzY0MTAsImV4cCI6MTcwODcxMjQxMCwiYXVkIjoid3d3LmV4YW1wbGUuY29tIiwic3ViIjoianJvY2tldEBleGFtcGxlLmNvbSIsIkdpdmVuTmFtZSI6IkpvaG5ueSIsIlN1cm5hbWUiOiJSb2NrZXQiLCJFbWFpbCI6Impyb2NrZXRAZXhhbXBsZS5jb20iLCJyb2xlIjpbIk1hbmFnZXIiLCJQcm9qZWN0IEFkbWluaXN0cmF0b3IiXX0.xv8IHzuyxYki516lTkfRIKlP1nt0V_14LMYYI18qsWY" \
http://localhost:3000/greeting

