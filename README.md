# Example of API usage for manipulation of NDEF (Nfc Data Exchange Format) records

Software example written for Visual Studio .NET C++.
Example of API usage for manipulation of NDEF (Nfc Data Exchange Format) records. 
Most popular NDEF types implemented : URI, SMS, Phone, vCard, Bluetooth handover. 
Also uses uFR API reader mode, tag emulation mode, combined emulation mode.


## Getting Started

Download project, open source in Visual Studio, compile and run. Optionally you can use precompiled binary at first.
Appropriate ufr-lib dynamic library (ufCoder-...) is mandatory for this project, choose it depending on platform and architecture.

### Prerequisites

uFR series reader, Visual Studio.


### Installing

No installation needed. 


## Usage

Example provides basic NDEF funcionality: 
1. Reading NDEF records on tag
2. Formatting tag for NFC use / Erasing tag to empty-factory settings
3. Writing most popular NDEF types: URI, SMS, Phone, vCard, Bluetooth handover. 
4. NDEF data can be writen in tag or in device's shared RAM, when device can act as NFC tag (emulation mode).
 

## License

This project is licensed under the ..... License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Purpose of this software demo is to provide additional info about usage of uFR Series API specific features.
* It is specific to mentioned hardware ONLY and some other hardware might have different approach, please bear in mind that.  


