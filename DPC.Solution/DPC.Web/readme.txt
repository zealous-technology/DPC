use the GET endpoint to get the greeting
curl http://localhost:28292/greeting

use the POST endpoint to create a new greeting
curl -X POST http://localhost:28292/greeting -H "Content-Type: application/json" -d '{ "Message": "Hello Steve" }'  