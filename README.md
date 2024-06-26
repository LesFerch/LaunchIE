# LaunchIE

[![image](https://github.com/LesFerch/WinSetView/assets/79026235/0188480f-ca53-45d5-b9ff-daafff32869e)Download the zip file](https://github.com/LesFerch/LaunchIE/releases/download/1.0.0/LaunchIE.zip)

## Launch Internet Explorer on Windows 10 or Windows 11

Internet Explorer is still included with Windows 10 and Windows 11. It has only been "disabled" as a general purpose browser. While it would be unwise for anyone to continue to use IE as a general purpose browser, there are those who still need to use IE with old websites and hardware that only work with IE. In general, such sites should work in Edge IE Mode (because it actually uses IE in the background) but if IE Mode will not work, you can use this little launcher to directly run Internet Explorer 11.

Another reason to use an Internet Explorer launcher, instead of Edge IE Mode, is to avoid the 30 day timeout on IE Mode pages (or avoid applying workarounds, such as [IEModeExpiryFix](https://lesferch.github.io/IEModeExpiryFix/)).

LaunchIE.exe is more convenienent than equivalent VBScript or JScript solutions. The main advantage is that it's easier to use with Windows shortcuts.

## How to Download and Run

1. Download the zip file using the link above.
2. Extract **LaunchIE.exe**.
3. Right-click **LaunchIE.exe**, select Properties, check Unblock, and click OK.
4. Optionally move **LaunchIE.exe** to the folder of your choice.
5. Double-click **LaunchIE.exe** to open Internet Explorer to a blank page.
6. If you skipped step 3, then, in the SmartScreen window, click More info and then Run anyway.
7. Make a shortcut to **LaunchIE.exe** and edit the command line to open Internet Explorer to the website of your choice.

**Note**: Some antivirus software may falsely detect the download as a virus. This can happen any time you download a new executable and may require extra steps to whitelist the file.

## Summary

**LaunchIE** launches Internet Explorer via the Internet Explorer COM object.

## Usage examples

**Example 1**:\
Launch Internet Explorer to a blank page
`LaunchIE`

**Example 2**:\
Launch Internet Explorer to example.com
`LaunchIE example.com`

## Alternatives

Please note that an alternative to using LaunchIE.exe is to use a small VBScript or JScript file to launch IE. In both of the example scripts below, you would replace "example.com" with the URL you want to load with IE.

### LaunchIE.vbs

Set oIE = CreateObject("InternetExplorer.Application")\
oIE.Visible = True\
oIE.Navigate "example.com"

### LaunchIE.js

oIE = new ActiveXObject("InternetExplorer.Application");\
oIE.Visible = true;\
oIE.Navigate("example.com");

\
\
[![image](https://github.com/LesFerch/WinSetView/assets/79026235/63b7acbc-36ef-4578-b96a-d0b7ea0cba3a)](https://github.com/LesFerch/LaunchIE)
