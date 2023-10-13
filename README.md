# SET09102 Testing Practical Project Fixed

This repository contains the testing practical project for the module SET09102.

The original repository has some issues, which includes the .NET MAUI project not be configured correctly which means it only runs of Windows and no other operating system. This version of the project has been fixed to run on all operating systems.

Everything is the same besides I removed a snippet of code related to setting the window width/height within `CreateWindow` function in `App.xaml.cs` as it doesn't seem to work nor does it affect the functionality of the application.

```csharp
const int newWidth = 800;
const int newHeight = 900;

window.Width = newWidth;
window.Height = newHeight;
```

The above snippet of code has been removed.