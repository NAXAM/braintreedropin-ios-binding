<img src="./art/repo_header.png" alt="BrainTree-DropIn for Xamarin.iOS" width="728" />

# BrainTree-DropIn for Xamarin.iOS

**New version is moved to braintree-ios-binding repo**

A Xamarin.iOS binding library for [BrainTree-DropIn](https://github.com/braintree/braintree-ios-drop-in) library.

## About
This project is maintained by Naxam Co.,Ltd.<br>
We specialize in developing mobile applications using Xamarin and native technology stack.<br>

**Looking for developers for your project?**<br>

<a href="mailto:tuyen@naxam.net"> 
<img src="https://github.com/NAXAM/naxam.github.io/blob/master/assets/img/hire_button.png?raw=true" height="40"></a> <br>

## Installation
```
Install-Package Naxam.BraintreeDropIn.iOS
```

STEPS to Update the binding
=====
1. Download the code for desired release
2. Download the code from BrainTree/BrainTree-iOS with `fat-framewowrk.sh` from corresponding NAXAM repository
3. Run `pod install` for both repos above
4. Build fat-framework for BrainTree-iOS
5. Add BraintreeCore, BraintreeApplePay, BraintreeCard, BraintreeUnionPay to BraintreeDropIn folder
6. Add those frameworks to BrainTreeDropIn project
7. Open XCWORKSPACE file
8. Create a new Aggreate target for BraintreeDropIn project
9. Create a new RUNSCIRPT for the new target with content from `fat-framework.sh`
10. Change configuration to release
11. Run new scheme
12. Copy generated frameworks to frameworks folder
13. Generate C# bindings by executing `generate-bindings.sh` script
14. Update ApiDefintions/Structs accordingly

## License

BrainTree-DropIn binding library for iOS is released under the MIT license.
See [LICENSE](./LICENSE) for details.

# Get our showcases on AppStore/PlayStore
Try our showcases to know more about our capabilities. 

<a href="https://itunes.apple.com/us/developer/tuyen-vu/id1255432728/" > 
<img src="https://github.com/NAXAM/imagepicker-android-binding/raw/master/art/apple_store.png" width="117" height="34"></a>

<a href="https://play.google.com/store/apps/developer?id=NAXAM+CO.,+LTD" > 
<img src="https://github.com/NAXAM/imagepicker-android-binding/raw/master/art/google_store.png" width="117" height="34"></a>

Contact us if interested.

<a href="mailto:tuyen@naxam.net"> 
<img src="https://github.com/NAXAM/naxam.github.io/blob/master/assets/img/hire_button.png" height="34"></a> <br>
<br>

Follow us for the latest updates<br>[![Twitter URL](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/intent/tweet?text=https://github.com/naxam/imagepicker-android-binding)
[![Twitter Follow](https://img.shields.io/twitter/follow/naxamco.svg?style=social)](https://twitter.com/naxamco)
