#!/usr/bin/env bash

rm -rf veracode veracode.zip bin obj
docker run --rm -it -v "$(pwd):/app" --workdir /app mcr.microsoft.com/dotnet/sdk:7.0 dotnet pack