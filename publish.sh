#!/bin/bash -e

if [[ (${#1} -eq 0) ]] ; then
    echo 
    echo "[ERROR] missing API key"
    exit 1
fi

if [[ (${#2} -eq 0) ]] ; then
    echo 
    echo "[ERROR] missing repo URL"
    exit 1
fi

api_key=$1
repo_url=$2

sdk_version=$(cat access.json | jq -r '.info.version')

# check the SDK builds
dotnet build sdk/Finbourne.Access.Sdk.sln

echo "sdk_version=$sdk_version"

sed -i 's/<Version>.*<\/Version>/<Version>'$sdk_version'<\/Version>/g' sdk/Finbourne.Access.Sdk/Finbourne.Access.Sdk.csproj

dotnet pack -c Release sdk/Finbourne.Access.Sdk/Finbourne.Access.Sdk.csproj

test="$(find sdk/Finbourne.Access.Sdk/bin/Release/Finbourne.Access* -type f -printf "%f")"

dotnet nuget push sdk/Finbourne.Access.Sdk/bin/Release/$test \
    --source $repo_url \
    --api-key $api_key