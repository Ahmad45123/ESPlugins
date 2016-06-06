Imports System.Windows.Forms
Imports ExtremeCore
Imports System.ComponentModel.Composition

<Export(GetType(IExtremePlugin))>
Public Class Main
    Implements IExtremePlugin

    Public Property ExtremeStudioFuncs As IPluginContext Implements IExtremePlugin.ExtremeStudioFuncs

    Public ReadOnly Property PluginName As String Implements IExtremePlugin.PluginName
        Get
            Return "Color Picker"
        End Get
    End Property

    Public Property ToolStripButtons As New List(Of RibbonButton) Implements IExtremePlugin.ToolStripButtons

    Dim WithEvents _btn As New RibbonButton
    Public Sub OnPluginInit() Implements IExtremePlugin.OnPluginInit
        _btn.ToolTip = "Color Picker"
        _btn.Image = My.Resources.ribbon_colorpicker
        ToolStripButtons.Add(_btn)
    End Sub

    Private Sub _btnOnClick(ByVal sender As Object, ByVal e As EventArgs) Handles _btn.Click
        Dim frm As New ColorPickerForm()
        frm.ESFuncs = ExtremeStudioFuncs
        frm.ShowDialog()
    End Sub
End Class
