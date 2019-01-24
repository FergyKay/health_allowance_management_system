<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FInd
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.searchText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FindButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'searchText
        '
        Me.searchText.Depth = 0
        Me.searchText.Hint = ""
        Me.searchText.Location = New System.Drawing.Point(23, 80)
        Me.searchText.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchText.Name = "searchText"
        Me.searchText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchText.SelectedText = ""
        Me.searchText.SelectionLength = 0
        Me.searchText.SelectionStart = 0
        Me.searchText.Size = New System.Drawing.Size(254, 23)
        Me.searchText.TabIndex = 0
        Me.searchText.UseSystemPasswordChar = False
        '
        'FindButton
        '
        Me.FindButton.AutoSize = True
        Me.FindButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FindButton.Depth = 0
        Me.FindButton.Location = New System.Drawing.Point(124, 125)
        Me.FindButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.FindButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Primary = False
        Me.FindButton.Size = New System.Drawing.Size(42, 36)
        Me.FindButton.TabIndex = 1
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'FInd
        '
        Me.AcceptButton = Me.FindButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 177)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.searchText)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FInd"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Enter Last Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FindButton As MaterialSkin.Controls.MaterialFlatButton
End Class
