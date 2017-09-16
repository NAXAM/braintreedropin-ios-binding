#! /bin/bash

function generate() {
    nuget pack $1.nuspec
}

frameworks=(
    braintree-dropin
    braintree-uikit
)
for framework in "${frameworks[@]}"
do
generate $framework
done