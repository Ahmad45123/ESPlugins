<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPickerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chooseBtn = New System.Windows.Forms.Button()
        Me.ClrDlg = New System.Windows.Forms.ColorDialog()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.InsertBtn = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        CType(Me.PicBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'chooseBtn
        '
        Me.chooseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chooseBtn.Location = New System.Drawing.Point(205, 12)
        Me.chooseBtn.Name = "chooseBtn"
        Me.chooseBtn.Size = New System.Drawing.Size(67, 26)
        Me.chooseBtn.TabIndex = 1
        Me.chooseBtn.Text = "Choose"
        Me.chooseBtn.UseVisualStyleBackColor = true
        '
        'ClrDlg
        '
        Me.ClrDlg.Color = System.Drawing.Color.White
        Me.ClrDlg.FullOpen = true
        '
        'nameText
        '
        Me.nameText.Location = New System.Drawing.Point(12, 120)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(260, 20)
        Me.nameText.TabIndex = 1
        '
        'InsertBtn
        '
        Me.InsertBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.InsertBtn.Location = New System.Drawing.Point(12, 146)
        Me.InsertBtn.Name = "InsertBtn"
        Me.InsertBtn.Size = New System.Drawing.Size(260, 23)
        Me.InsertBtn.TabIndex = 0
        Me.InsertBtn.Text = "Insert"
        Me.InsertBtn.UseVisualStyleBackColor = true
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.White
        Me.PicBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PicBox.Location = New System.Drawing.Point(12, 12)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(260, 102)
        Me.PicBox.TabIndex = 2
        Me.PicBox.TabStop = false
        '
        'ColorPickerForm
        '
        Me.AcceptButton = Me.InsertBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 184)
        Me.Controls.Add(Me.InsertBtn)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.chooseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.Name = "ColorPickerForm"
        Me.Text = "Color Picker"
        CType(Me.PicBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents chooseBtn As System.Windows.Forms.Button
    Friend WithEvents ClrDlg As System.Windows.Forms.ColorDialog
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents nameText As System.Windows.Forms.TextBox
    Friend WithEvents InsertBtn As System.Windows.Forms.Button
End Class
