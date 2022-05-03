# Jonimoes-api
- a .NET 6 webapi to handle requests from jonimoes-react

## Getting started
- add DB_CONNECTION to .env file
### Build Docker Image 
`docker build --pull -t jonimosapi:v1 .`

### Run Docker Image
`docker run --env-file ./.env -it -p 8000:80 jonimosapi:v1`
## [Arch](docs/architecture.png)

## [Deployment](/docs/jonimoes-deployment.png)

