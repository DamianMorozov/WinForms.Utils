# **WinForms.Utils** - Utils for invoking WinForms conrols from async threads and tasks.

[![NuGet version](https://img.shields.io/nuget/v/WinForms.Utils.svg?style=flat)](https://www.nuget.org/packages/WinForms.Utils/)
[![NuGet downloads](https://img.shields.io/nuget/dt/WinForms.Utils.svg)](https://www.nuget.org/packages/WinForms.Utils/)

# WinForms.Utils
- InvokeControl
- InvokePictureBox
- InvokeProgressBar
- UtilsControl
- UtilsProgressBar

# WinForms.Utils.Tests
- EnumValues
- EnumWinForm
- InvokeControlTests
- InvokePictureBoxTests
- InvokeProgressBarTests
- UtilsControlTests
- UtilsProgressBarTests

## How to use
Example of usage:

```C#
var task = Task.Run(async () =>
{
    await Task.Delay(TimeSpan.FromMilliseconds(_timeout)).ConfigureAwait(true);
    InvokeControl.SetVisible(button, false);
});
```

## Please, if this tool has been useful for you consider to donate
[![Buy me a coffee](Assets/Buy_me_a_coffee.png?raw=true)](https://www.buymeacoffee.com/DamianVM)
