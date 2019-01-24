<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModSpouse
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
        Me.PartnerID = New MetroFramework.Controls.MetroComboBox()
        Me.AddSpouseButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.surnameField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.firstNameField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.femaleRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.maleRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.emailField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'PartnerID
        '
        Me.PartnerID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PartnerID.FormattingEnabled = True
        Me.PartnerID.ItemHeight = 23
        Me.PartnerID.Location = New System.Drawing.Point(149, 23)
        Me.PartnerID.Name = "PartnerID"
        Me.PartnerID.Size = New System.Drawing.Size(239, 29)
        Me.PartnerID.Style = MetroFramework.MetroColorStyle.Silver
        Me.PartnerID.TabIndex = 13
        Me.PartnerID.UseSelectable = True
        '
        'AddSpouseButton
        '
        Me.AddSpouseButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddSpouseButton.AutoSize = True
        Me.AddSpouseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddSpouseButton.BackColor = System.Drawing.Color.Green
        Me.AddSpouseButton.Depth = 0
        Me.AddSpouseButton.Location = New System.Drawing.Point(183, 269)
        Me.AddSpouseButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddSpouseButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddSpouseButton.Name = "AddSpouseButton"
        Me.AddSpouseButton.Primary = False
        Me.AddSpouseButton.Size = New System.Drawing.Size(62, 36)
        Me.AddSpouseButton.TabIndex = 17
        Me.AddSpouseButton.Text = "Modify"
        Me.AddSpouseButton.UseVisualStyleBackColor = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(13, 220)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel6.TabIndex = 21
        Me.MaterialLabel6.Text = "Email"
        '
        'surnameField
        '
        Me.surnameField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.surnameField.Depth = 0
        Me.surnameField.Hint = ""
        Me.surnameField.Location = New System.Drawing.Point(149, 81)
        Me.surnameField.MouseState = MaterialSkin.MouseState.HOVER
        Me.surnameField.Name = "surnameField"
        Me.surnameField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.surnameField.SelectedText = ""
        Me.surnameField.SelectionLength = 0
        Me.surnameField.SelectionStart = 0
        Me.surnameField.Size = New System.Drawing.Size(253, 23)
        Me.surnameField.TabIndex = 11
        Me.surnameField.UseSystemPasswordChar = False
        '
        'firstNameField
        '
        Me.firstNameField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.firstNameField.Depth = 0
        Me.firstNameField.Hint = ""
        Me.firstNameField.Location = New System.Drawing.Point(149, 124)
        Me.firstNameField.MouseState = MaterialSkin.MouseState.HOVER
        Me.firstNameField.Name = "firstNameField"
        Me.firstNameField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNameField.SelectedText = ""
        Me.firstNameField.SelectionLength = 0
        Me.firstNameField.SelectionStart = 0
        Me.firstNameField.Size = New System.Drawing.Size(253, 23)
        Me.firstNameField.TabIndex = 12
        Me.firstNameField.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(13, 81)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(68, 19)
        Me.MaterialLabel1.TabIndex = 18
        Me.MaterialLabel1.Text = "Surname"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(13, 124)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel2.TabIndex = 19
        Me.MaterialLabel2.Text = "First Name"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(14, 33)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(57, 19)
        Me.MaterialLabel8.TabIndex = 20
        Me.MaterialLabel8.Text = "Partner"
        '
        'femaleRadio
        '
        Me.femaleRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.femaleRadio.AutoSize = True
        Me.femaleRadio.Depth = 0
        Me.femaleRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.femaleRadio.Location = New System.Drawing.Point(249, 171)
        Me.femaleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.femaleRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.femaleRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.femaleRadio.Name = "femaleRadio"
        Me.femaleRadio.Ripple = True
        Me.femaleRadio.Size = New System.Drawing.Size(74, 30)
        Me.femaleRadio.TabIndex = 15
        Me.femaleRadio.TabStop = True
        Me.femaleRadio.Text = "Female"
        Me.femaleRadio.UseVisualStyleBackColor = True
        '
        'maleRadio
        '
        Me.maleRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.maleRadio.AutoSize = True
        Me.maleRadio.Depth = 0
        Me.maleRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.maleRadio.Location = New System.Drawing.Point(163, 172)
        Me.maleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.maleRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.maleRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.maleRadio.Name = "maleRadio"
        Me.maleRadio.Ripple = True
        Me.maleRadio.Size = New System.Drawing.Size(59, 30)
        Me.maleRadio.TabIndex = 14
        Me.maleRadio.TabStop = True
        Me.maleRadio.Text = "Male"
        Me.maleRadio.UseVisualStyleBackColor = True
        '
        'emailField
        '
        Me.emailField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emailField.Depth = 0
        Me.emailField.Hint = ""
        Me.emailField.Location = New System.Drawing.Point(151, 216)
        Me.emailField.MouseState = MaterialSkin.MouseState.HOVER
        Me.emailField.Name = "emailField"
        Me.emailField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailField.SelectedText = ""
        Me.emailField.SelectionLength = 0
        Me.emailField.SelectionStart = 0
        Me.emailField.Size = New System.Drawing.Size(253, 23)
        Me.emailField.TabIndex = 16
        Me.emailField.UseSystemPasswordChar = False
        '
        'ModSpouse
        '
        Me.AcceptButton = Me.AddSpouseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 332)
        Me.Controls.Add(Me.PartnerID)
        Me.Controls.Add(Me.AddSpouseButton)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.surnameField)
        Me.Controls.Add(Me.firstNameField)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.femaleRadio)
        Me.Controls.Add(Me.maleRadio)
        Me.Controls.Add(Me.emailField)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModSpouse"
        Me.Text = "Modify Spouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PartnerID As MetroFramework.Controls.MetroComboBox
    Friend WithEvents AddSpouseButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents surnameField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents firstNameField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents femaleRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents maleRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents emailField As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
