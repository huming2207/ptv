.NET Portable Class Library for Public Transport Victoria API (Ptv.dll)
=======================================================================

Status: [![Build Status](https://travis-ci.org/huming2207/ptv.svg?branch=master)](https://travis-ci.org/huming2207/ptv)

Ptv is a Portable Class Library which provides .NET-based wrapper around the Public Transport Victoria APIs that have been published at http://data.vic.gov.au.

**Originally written by Readify staff. I've forked from them and add some supports for newest API v2.1.0.**

Usage
-----

Firstly, open **Ptv.sln** (NOT THE ONE CALLED **Ptv-TravisTest.sln**) to compile the PCL library, 
or have a try with the WPF demo app.

Then, in your code add the following:

```C#
var developerID = "12345";
var securityKey = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";

var client = new TimetableClient(
    developerID,
    securityKey,
    (input, key) =>
    {
		// Unfortunately the APIs exposed to .NET PCLs does not include an implementation
		// of the HMACSHA1 algorithm which the PTV API requires to generate signatures, so
		// rather than take a dependency on another library, for now the API defines a
		// delegate (TimetableClientHasher) which takes the key, and a sequence of bytes
		// to be hashed which can then be passed into the underlying platforms APIs.
        var provider = new HMACSHA1(key);
        var hash = provider.ComputeHash(input);
        return hash;
    });

var results = await client.SearchAsync("South Melbourne");
```