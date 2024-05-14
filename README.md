# Webcam Studio (BETA)

A Visual Studio extension that embeds the Telerik Radcam control into a Visual Studio tool window, allowing you to embed yourself right inside Visual Studio!

## License

[![License - MIT](https://img.shields.io/github/license/codingwithcalvin/VS-WebcamStudio?style=for-the-badge)](https://img.shields.io/github/license/codingwithcalvin/VS-WebcamStudio?style=for-the-badge)

## Build Status

![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/CodingWithCalvin/VS-WebcamStudio/release_build_and_deploy.yml?style=for-the-badge)

## Marketplace Status

[![Marketplace Installations](https://img.shields.io/visual-studio-marketplace/i/codingwithcalvin.VS-WebcamStudio?style=for-the-badge)](https://img.shields.io/visual-studio-marketplace/i/codingwithcalvin.VS-WebcamStudio?style=for-the-badge) [![Marketplace Downloads](https://img.shields.io/visual-studio-marketplace/d/codingwithcalvin.VS-WebcamStudio?style=for-the-badge)](https://img.shields.io/visual-studio-marketplace/d/codingwithcalvin.VS-WebcamStudio?style=for-the-badge)
[![Marketplace Version](https://img.shields.io/visual-studio-marketplace/v/codingwithcalvin.VS-WebcamStudio?style=for-the-badge)](https://img.shields.io/visual-studio-marketplace/v/codingwithcalvin.VS-WebcamStudio?style=for-the-badge) [![Marketplace Rating](https://img.shields.io/visual-studio-marketplace/r/codingwithcalvin.VS-WebcamStudio?style=for-the-badge)](https://img.shields.io/visual-studio-marketplace/r/codingwithcalvin.VS-WebcamStudio?style=for-the-badge)

## Contribute

Contributions are welcome! Issues, PRs, etc. While it may seem this extension is "done", who knows what the future may hold for it?

For cloning and building this project yourself, make sure to install the [Extensibility Essentials 2022 extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.ExtensibilityEssentials2022) for Visual Studio which enables some features used by this project.

This extension requires the usage of Telerik controls that are NOT available via the GitHub repository. You must provide these libraries yourself.

## NOTICE 

The following files need added to your extension's installation directory AFTER install as they cannot be shipped inside the VSIX (for some reason?)

Locate the extension's installation directory (it is installed per-user, so it will be somewhere in `%USERPROFILE%\AppData\Local\Microsoft\VisualStudio\<version>\Extensions\<weird directory>`).
Create a subfolder here called `assemblies`, and place the following files:

1. MediaFoundation.dll
1. SharpDX.Direct3D9.dll
1. SharpDX.dll
1. Telerik.Windows.Controls.dll
1. Telerik.Windows.Controls.Media.dll
1. Telerik.Windows.MediaFoundation