[![Build Status](https://barradas.visualstudio.com/Contributions/_apis/build/status/NugetPackage/PagarMe%20SDK?branchName=develop)](https://barradas.visualstudio.com/Contributions/_build/latest?definitionId=21&branchName=develop)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=ThiagoBarradas_pagarme-dotnet&metric=alert_status)](https://sonarcloud.io/dashboard?id=ThiagoBarradas_pagarme-dotnet)
[![NuGet Downloads](https://img.shields.io/nuget/dt/PagarMe.svg)](https://www.nuget.org/packages/PagarMe/)
[![NuGet Version](https://img.shields.io/nuget/v/PagarMe.svg)](https://www.nuget.org/packages/PagarMe/)
<!-- [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=ThiagoBarradas_pagarme-dotnet&metric=coverage)](https://sonarcloud.io/dashboard?id=ThiagoBarradas_pagarme-dotnet) -->

# PagarMe Client for Dotnet Applications

This is a unofficial api client to integrate with pagarme api. Please, keep in your mind you cannot get pagarme support for this SDK, you can only get some help creating a issue here. Thanks and feel free to contribute with this repository. :)

Basic Sample

```

IPagarMeApiClient client = new PagarMeApiClient(secretKey: "sk_xxxx", timeout: 30000);

var request = new CreateOrderRequest();

var result = client.Order.CreateOrder(request);

```

## Install via NuGet

```
PM> Install-Package PagarMe
```

## How can I contribute?
Please, refer to [CONTRIBUTING](.github/CONTRIBUTING.md)

## Found something strange or need a new feature?
Open a new Issue following our issue template [ISSUE_TEMPLATE](.github/ISSUE_TEMPLATE.md)

## Changelog
See in [nuget version history](https://www.nuget.org/packages/PagarMe)

## Did you like it? Please, make a donate :)

if you liked this project, please make a contribution and help to keep this and other initiatives, send me some Satochis.

BTC Wallet: `1G535x1rYdMo9CNdTGK3eG6XJddBHdaqfX`

![1G535x1rYdMo9CNdTGK3eG6XJddBHdaqfX](https://i.imgur.com/mN7ueoE.png)
