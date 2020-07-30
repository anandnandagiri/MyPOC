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

