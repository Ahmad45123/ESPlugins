Imports System.Drawing
Imports System.Windows.Forms
Imports ExtremeCore

Public Class ColorPickerForm

    Public Property EsFuncs As IPluginContext

    Private Sub ColorPickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chooseBtn.BringToFront()
    End Sub

    Public Shared Function ToHex(color As Color) As String
	    Return [String].Format("0x{0}{1}{2}{3}", If(color.A.ToString("X").Length = 1, [String].Format("0{0}", color.A.ToString("X")), color.A.ToString("X")), If(color.R.ToString("X").Length = 1, [String].Format("0{0}", color.R.ToString("X")), color.R.ToString("X")), If(color.G.ToString("X").Length = 1, [String].Format("0{0}", color.G.ToString("X")), color.G.ToString("X")), If(color.B.ToString("X").Length = 1, [String].Format("0{0}", color.B.ToString("X")), color.B.ToString("X")))
    End Function

    Private Sub chooseBtn_Click(sender As Object, e As EventArgs) Handles chooseBtn.Click
        If ClrDlg.ShowDialog() = DialogResult.OK Then
            PicBox.BackColor = ClrDlg.Color
            nameText.Text = "#define COLOR_" + ClrDlg.Color.Name.ToUpper() + " " + ToHex(ClrDlg.Color)
        End If
    End Sub

    Private Sub PicBox_Click(sender As Object, e As EventArgs) Handles PicBox.Click
        Choosebtn.PerformClick()
    End Sub

    Private Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        if EsFuncs.CurrentEditor IsNot Nothing Then
            EsFuncs.CurrentEditor.InsertText(EsFuncs.CurrentEditor.CurrentPosition, nameText.Text)
        End If
    End Sub
End Class