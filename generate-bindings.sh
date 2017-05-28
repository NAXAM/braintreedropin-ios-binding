#! /bin/bash

function generate() {
    sharpie bind -sdk iphoneos10.3 -f ./frameworks/$1 -output ./bindings/$1 -namespace $1
}

frameworks=(
    BraintreeDropIn
    BraintreeUIKit
)
for framework in "${frameworks[@]}"
do
generate $framework
done