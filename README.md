# URL-Shortener
C# Url Shortener

## IaC

## Log in into Azure
## Using a function App
``` bash
az login
```

### Create a resource group

``` bash
az group create --name urlshortener-dev --location westeurope
```
``` bash
az deployment group create --resource-group urlshortener-dev --template-file ./main.bicep
``` 
