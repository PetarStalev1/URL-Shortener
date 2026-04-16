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
### Create user for github actions

``` bash
az ad sp create-for-rbac --name "GitHub-Actions-SP" \
                         --role contributor \
                         --scopes /subscriptions/dfb90ac6-2481-41bd-bc67-a09ec24e7206 \
                         --sdk-auth
```
#### Configure a federated identity credential on an app

https://learn.microsoft.com/en-gb/entra/workload-id/workload-identity-federation-create-trust?pivots=identity-wif-apps-methods-azp#configure-a-federated-identity-credential-on-an-app