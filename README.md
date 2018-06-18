# GitData

## Intro

![Logo](./GitData/Assets/logo.png)

*GitData* is a Windows application with simple UI that allows user to view a summary of any GitHub account instantly.

## Prerequisites

- Windows (10)
- .NET 4.5+
- Visual Studio 2017

## Special Mentions

According to [GitHub API](https://developer.github.com/v3/?), there is a rate limit on how frequent a user can call the API. Therefore, user should specify one's GitHub credential to the tool if one wishes to call frequenly. The tool does not store any input not send them anywhere rather than within the API call itself (source code available here).