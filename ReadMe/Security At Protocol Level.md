# Security At Protocol Level (TLS/Cipher Suite)

#### Understanding Cipher Suite [More Info](https://docs.microsoft.com/en-us/windows/win32/secauthn/cipher-suites-in-schannel)
![TLS Cipher Suite](https://github.com/anandnandagiri/MyPOC/raw/master/ReadMe/Images/tls-cipher-suite.png "TLS Cipher Suite")


#### How to Enable Cipher Suite
From the Group Policy Management Console, Go to Computer Configuration > Administrative Templates > Network > SSL Configuration Settings.
Double-click SSL Cipher Suite Order, and then click the Enabled option

#### Enable TLS 1.2
Run reg file which can [here](https://github.com/anandnandagiri/MyPOC/raw/master/ReadMe/reg/.NET4.0%20TLS.reg)

#### .NET 4.0 Framework Enable TLS 1.2
Run reg file which can [here](https://github.com/anandnandagiri/MyPOC/raw/master/ReadMe/reg/TLS.reg)

#### Below is Cipher Suite
```
TLS_AES_256_GCM_SHA384,TLS_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_DHE_RSA_WITH_AES_256_GCM_SHA384,TLS_DHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,TLS_RSA_WITH_AES_256_GCM_SHA384,TLS_RSA_WITH_AES_128_GCM_SHA256,TLS_RSA_WITH_AES_256_CBC_SHA256,TLS_RSA_WITH_AES_128_CBC_SHA256,TLS_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_AES_128_CBC_SHA,TLS_RSA_WITH_NULL_SHA256,TLS_RSA_WITH_NULL_SHA,TLS_PSK_WITH_AES_256_GCM_SHA384,TLS_PSK_WITH_AES_128_GCM_SHA256,TLS_PSK_WITH_AES_256_CBC_SHA384,TLS_PSK_WITH_AES_128_CBC_SHA256,TLS_PSK_WITH_NULL_SHA384,TLS_PSK_WITH_NULL_SHA256
```
#### Remove TLS_RSA_WITH_3DES_EDE_CBC_SHA Since 64Bit and Sweet32 Attack is possible
