# MessageBoxAdv Resize Support in WinForms
The _MessageBoxAdv_ control is an advanced alternative to the standard Windows message box, offering enhanced customization options such as themes, buttons, and icons.

This sample demonstrates how to enable **resizing support for MessageBoxAdv** in WinForms applications using Syncfusion controls. By default, message boxes are fixed in size, but enabling resizing improves usability when displaying large text or dynamic content.

## Why Enable Resizing?
Resizing is useful for:
- Large text or detailed error messages.
- Accessibility and better readability.
- Allowing users flexibility to adjust dialog size.

##  Key Features
- Enable resizing for MessageBoxAdv at runtime.
- Maintain proper layout during resizing.
- Apply minimum and maximum size constraints.
    
## Steps to Enable Resizing
- Create a MessageBoxAdv instance or use the static Show method.
- Set the _MessageBoxAdv.CanResize_ property to true.
- Optionally, apply styles and themes.

## Minimal Code Example
```C#
using Syncfusion.Windows.Forms;
using System;
using System.Windows.Forms;

public partial class Form1 : MetroForm
{
    public Form1()
    {
        InitializeComponent();
        // Enable resizing for MessageBoxAdv
        MessageBoxAdv.CanResize = true;
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro; // Apply Metro style
    }

    private void btn_errormsg_Click(object sender, EventArgs e)
    {
        string errorMessage = "Windows cannot install required files. The file may be corrupt or missing...";
        string details = "You can most likely get the error when reinstalling or updating the OS...";

        MessageBoxAdv.Show(errorMessage, "Install Windows",
            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning, details);
    }
}
```
