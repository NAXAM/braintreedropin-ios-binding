# Xamarin Binding Library - Braintree DropIn Library
https://github.com/braintree/braintree-ios-drop-in

## Braintree DropIn
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
