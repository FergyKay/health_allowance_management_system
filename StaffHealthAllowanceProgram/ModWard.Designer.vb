<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModWard
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
        Me.emailField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.parentCombo = New MetroFramework.Controls.MetroComboBox()
        Me.AddWardButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.firstNameField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.surnameField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.maleRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.femaleRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.dob = New MetroFramework.Controls.MetroDateTime()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.wardCombo = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'emailField
        '
        Me.emailField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emailField.Depth = 0
        Me.emailField.Hint = ""
        Me.emailField.Location = New System.Drawing.Point(122, 254)
        Me.emailField.MouseState = MaterialSkin.MouseState.HOVER
        Me.emailField.Name = "emailField"
        Me.emailField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailField.SelectedText = ""
        Me.emailField.SelectionLength = 0
        Me.emailField.SelectionStart = 0
        Me.emailField.Size = New System.Drawing.Size(253, 23)
        Me.emailField.TabIndex = 17
        Me.emailField.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(43, 262)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel4.TabIndex = 25
        Me.MaterialLabel4.Text = "Email"
        '
        'parentCombo
        '
        Me.parentCombo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.parentCombo.FormattingEnabled = True
        Me.parentCombo.ItemHeight = 23
        Me.parentCombo.Items.AddRange(New Object() {"Development service", "Finance", "I.T", "Ict", "Internal audit", "Library", "Marine Electrical Electronic", "Management", "Marine engineering", "Maritime safety", "Nautical scicence", "Port and shipping", "Procurement", "Public relations", "Quality management", "Registry-academic", "Registry-adminstration", "Research & innovation", "Sick bay", "Stores", "Students affairs", "Transport"})
        Me.parentCombo.Location = New System.Drawing.Point(119, 13)
        Me.parentCombo.MaxDropDownItems = 7
        Me.parentCombo.Name = "parentCombo"
        Me.parentCombo.Size = New System.Drawing.Size(200, 29)
        Me.parentCombo.TabIndex = 15
        Me.parentCombo.UseSelectable = True
        '
        'AddWardButton
        '
        Me.AddWardButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddWardButton.AutoSize = True
        Me.AddWardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddWardButton.BackColor = System.Drawing.Color.Green
        Me.AddWardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddWardButton.Depth = 0
        Me.AddWardButton.Location = New System.Drawing.Point(185, 353)
        Me.AddWardButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddWardButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddWardButton.Name = "AddWardButton"
        Me.AddWardButton.Primary = False
        Me.AddWardButton.Size = New System.Drawing.Size(62, 36)
        Me.AddWardButton.TabIndex = 20
        Me.AddWardButton.Text = "Modify"
        Me.AddWardButton.UseVisualStyleBackColor = False
        '
        'firstNameField
        '
        Me.firstNameField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.firstNameField.Depth = 0
        Me.firstNameField.Hint = ""
        Me.firstNameField.Location = New System.Drawing.Point(125, 153)
        Me.firstNameField.MouseState = MaterialSkin.MouseState.HOVER
        Me.firstNameField.Name = "firstNameField"
        Me.firstNameField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNameField.SelectedText = ""
        Me.firstNameField.SelectionLength = 0
        Me.firstNameField.SelectionStart = 0
        Me.firstNameField.Size = New System.Drawing.Size(231, 23)
        Me.firstNameField.TabIndex = 14
        Me.firstNameField.UseSystemPasswordChar = False
        '
        'surnameField
        '
        Me.surnameField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.surnameField.Depth = 0
        Me.surnameField.Hint = ""
        Me.surnameField.Location = New System.Drawing.Point(121, 110)
        Me.surnameField.MouseState = MaterialSkin.MouseState.HOVER
        Me.surnameField.Name = "surnameField"
        Me.surnameField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.surnameField.SelectedText = ""
        Me.surnameField.SelectionLength = 0
        Me.surnameField.SelectionStart = 0
        Me.surnameField.Size = New System.Drawing.Size(231, 23)
        Me.surnameField.TabIndex = 13
        Me.surnameField.UseSystemPasswordChar = False
        '
        'maleRadio
        '
        Me.maleRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.maleRadio.AutoSize = True
        Me.maleRadio.Depth = 0
        Me.maleRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.maleRadio.Location = New System.Drawing.Point(145, 306)
        Me.maleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.maleRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.maleRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.maleRadio.Name = "maleRadio"
        Me.maleRadio.Ripple = True
        Me.maleRadio.Size = New System.Drawing.Size(59, 30)
        Me.maleRadio.TabIndex = 18
        Me.maleRadio.TabStop = True
        Me.maleRadio.Text = "Male"
        Me.maleRadio.UseVisualStyleBackColor = True
        '
        'femaleRadio
        '
        Me.femaleRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.femaleRadio.AutoSize = True
        Me.femaleRadio.Depth = 0
        Me.femaleRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.femaleRadio.Location = New System.Drawing.Point(235, 306)
        Me.femaleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.femaleRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.femaleRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.femaleRadio.Name = "femaleRadio"
        Me.femaleRadio.Ripple = True
        Me.femaleRadio.Size = New System.Drawing.Size(74, 30)
        Me.femaleRadio.TabIndex = 19
        Me.femaleRadio.TabStop = True
        Me.femaleRadio.Text = "Female"
        Me.femaleRadio.UseVisualStyleBackColor = True
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(38, 22)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(52, 19)
        Me.MaterialLabel7.TabIndex = 23
        Me.MaterialLabel7.Text = "Parent"
        '
        'dob
        '
        Me.dob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dob.Location = New System.Drawing.Point(126, 201)
        Me.dob.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(200, 29)
        Me.dob.TabIndex = 16
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(33, 114)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(68, 19)
        Me.MaterialLabel1.TabIndex = 21
        Me.MaterialLabel1.Text = "Surname"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(24, 209)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(94, 19)
        Me.MaterialLabel3.TabIndex = 24
        Me.MaterialLabel3.Text = "Date Of Birth"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(29, 160)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel2.TabIndex = 22
        Me.MaterialLabel2.Text = "First Name"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(35, 67)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(61, 19)
        Me.MaterialLabel5.TabIndex = 21
        Me.MaterialLabel5.Text = "Ward ID"
        '
        'wardCombo
        '
        Me.wardCombo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.wardCombo.FormattingEnabled = True
        Me.wardCombo.ItemHeight = 23
        Me.wardCombo.Items.AddRange(New Object() {"Development service", "Finance", "I.T", "Ict", "Internal audit", "Library", "Marine Electrical Electronic", "Management", "Marine engineering", "Maritime safety", "Nautical scicence", "Port and shipping", "Procurement", "Public relations", "Quality management", "Registry-academic", "Registry-adminstration", "Research & innovation", "Sick bay", "Stores", "Students affairs", "Transport"})
        Me.wardCombo.Location = New System.Drawing.Point(119, 63)
        Me.wardCombo.MaxDropDownItems = 7
        Me.wardCombo.Name = "wardCombo"
        Me.wardCombo.Size = New System.Drawing.Size(200, 29)
        Me.wardCombo.TabIndex = 15
        Me.wardCombo.UseSelectable = True
        '
        'ModWard
        '
        Me.AcceptButton = Me.AddWardButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 400)
        Me.Controls.Add(Me.emailField)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.wardCombo)
        Me.Controls.Add(Me.parentCombo)
        Me.Controls.Add(Me.AddWardButton)
        Me.Controls.Add(Me.firstNameField)
        Me.Controls.Add(Me.surnameField)
        Me.Controls.Add(Me.maleRadio)
        Me.Controls.Add(Me.femaleRadio)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.MaximizeBox = False
        Me.Name = "ModWard"
        Me.Text = "Modify Ward"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents emailField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents parentCombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents AddWardButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents firstNameField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents surnameField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents maleRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents femaleRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dob As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents wardCombo As MetroFramework.Controls.MetroComboBox
End Class
