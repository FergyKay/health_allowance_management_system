<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStaffForm
    Inherits System.Windows.Forms.Form

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
        Me.surnameField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.firstNameField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.maleRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.femaleRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.dob = New MetroFramework.Controls.MetroDateTime()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.PositionField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.emailField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.AddStaffButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.departmentCombo = New MetroFramework.Controls.MetroComboBox()
        Me.Staff_ID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.SectorField = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'surnameField
        '
        Me.surnameField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.surnameField.Depth = 0
        Me.surnameField.Hint = ""
        Me.surnameField.Location = New System.Drawing.Point(161, 14)
        Me.surnameField.MouseState = MaterialSkin.MouseState.HOVER
        Me.surnameField.Name = "surnameField"
        Me.surnameField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.surnameField.SelectedText = ""
        Me.surnameField.SelectionLength = 0
        Me.surnameField.SelectionStart = 0
        Me.surnameField.Size = New System.Drawing.Size(253, 23)
        Me.surnameField.TabIndex = 0
        Me.surnameField.UseSystemPasswordChar = False
        '
        'firstNameField
        '
        Me.firstNameField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.firstNameField.Depth = 0
        Me.firstNameField.Hint = ""
        Me.firstNameField.Location = New System.Drawing.Point(161, 57)
        Me.firstNameField.MouseState = MaterialSkin.MouseState.HOVER
        Me.firstNameField.Name = "firstNameField"
        Me.firstNameField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNameField.SelectedText = ""
        Me.firstNameField.SelectionLength = 0
        Me.firstNameField.SelectionStart = 0
        Me.firstNameField.Size = New System.Drawing.Size(253, 23)
        Me.firstNameField.TabIndex = 1
        Me.firstNameField.UseSystemPasswordChar = False
        '
        'maleRadio
        '
        Me.maleRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.maleRadio.AutoSize = True
        Me.maleRadio.Depth = 0
        Me.maleRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.maleRadio.Location = New System.Drawing.Point(182, 217)
        Me.maleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.maleRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.maleRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.maleRadio.Name = "maleRadio"
        Me.maleRadio.Ripple = True
        Me.maleRadio.Size = New System.Drawing.Size(59, 30)
        Me.maleRadio.TabIndex = 4
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
        Me.femaleRadio.Location = New System.Drawing.Point(268, 216)
        Me.femaleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.femaleRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.femaleRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.femaleRadio.Name = "femaleRadio"
        Me.femaleRadio.Ripple = True
        Me.femaleRadio.Size = New System.Drawing.Size(74, 30)
        Me.femaleRadio.TabIndex = 5
        Me.femaleRadio.TabStop = True
        Me.femaleRadio.Text = "Female"
        Me.femaleRadio.UseVisualStyleBackColor = True
        '
        'dob
        '
        Me.dob.AllowDrop = True
        Me.dob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dob.CustomFormat = "dd/mm/yyyy"
        Me.dob.DisplayFocus = True
        Me.dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dob.Location = New System.Drawing.Point(161, 161)
        Me.dob.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(200, 29)
        Me.dob.TabIndex = 3
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(25, 14)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(68, 19)
        Me.MaterialLabel1.TabIndex = 11
        Me.MaterialLabel1.Text = "Surname"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(25, 57)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel2.TabIndex = 12
        Me.MaterialLabel2.Text = "First Name"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(25, 167)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(94, 19)
        Me.MaterialLabel3.TabIndex = 14
        Me.MaterialLabel3.Text = "Date Of Birth"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(25, 315)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(53, 19)
        Me.MaterialLabel4.TabIndex = 16
        Me.MaterialLabel4.Text = "Sector"
        '
        'PositionField
        '
        Me.PositionField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PositionField.Depth = 0
        Me.PositionField.Hint = ""
        Me.PositionField.Location = New System.Drawing.Point(161, 352)
        Me.PositionField.MouseState = MaterialSkin.MouseState.HOVER
        Me.PositionField.Name = "PositionField"
        Me.PositionField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PositionField.SelectedText = ""
        Me.PositionField.SelectionLength = 0
        Me.PositionField.SelectionStart = 0
        Me.PositionField.Size = New System.Drawing.Size(253, 23)
        Me.PositionField.TabIndex = 8
        Me.PositionField.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(25, 352)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel5.TabIndex = 17
        Me.MaterialLabel5.Text = "Position"
        '
        'emailField
        '
        Me.emailField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emailField.Depth = 0
        Me.emailField.Hint = ""
        Me.emailField.Location = New System.Drawing.Point(161, 389)
        Me.emailField.MouseState = MaterialSkin.MouseState.HOVER
        Me.emailField.Name = "emailField"
        Me.emailField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailField.SelectedText = ""
        Me.emailField.SelectionLength = 0
        Me.emailField.SelectionStart = 0
        Me.emailField.Size = New System.Drawing.Size(253, 23)
        Me.emailField.TabIndex = 9
        Me.emailField.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(25, 389)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel6.TabIndex = 18
        Me.MaterialLabel6.Text = "Email"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(25, 276)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel7.TabIndex = 15
        Me.MaterialLabel7.Text = "Department"
        '
        'AddStaffButton
        '
        Me.AddStaffButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddStaffButton.AutoSize = True
        Me.AddStaffButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddStaffButton.BackColor = System.Drawing.Color.Green
        Me.AddStaffButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddStaffButton.Depth = 0
        Me.AddStaffButton.Location = New System.Drawing.Point(229, 415)
        Me.AddStaffButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddStaffButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddStaffButton.Name = "AddStaffButton"
        Me.AddStaffButton.Primary = False
        Me.AddStaffButton.Size = New System.Drawing.Size(39, 36)
        Me.AddStaffButton.TabIndex = 10
        Me.AddStaffButton.Text = "Add"
        Me.AddStaffButton.UseVisualStyleBackColor = False
        '
        'departmentCombo
        '
        Me.departmentCombo.FormattingEnabled = True
        Me.departmentCombo.ItemHeight = 23
        Me.departmentCombo.Items.AddRange(New Object() {"Development service", "Finance", "I.T", "I.C.T", "Internal audit", "Library", "Marine Electrical Electronic", "Management", "Marine engineering", "Maritime safety", "Nautical scicence", "Port and shipping", "Procurement", "Public relations", "Quality management", "Registry-academic", "Registry-adminstration", "Research & innovation", "Sick bay", "Stores", "Students affairs", "Transport", "Marketing"})
        Me.departmentCombo.Location = New System.Drawing.Point(162, 268)
        Me.departmentCombo.MaxDropDownItems = 7
        Me.departmentCombo.Name = "departmentCombo"
        Me.departmentCombo.Size = New System.Drawing.Size(252, 29)
        Me.departmentCombo.TabIndex = 6
        Me.departmentCombo.UseSelectable = True
        '
        'Staff_ID
        '
        Me.Staff_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_ID.Depth = 0
        Me.Staff_ID.Hint = ""
        Me.Staff_ID.Location = New System.Drawing.Point(161, 109)
        Me.Staff_ID.MouseState = MaterialSkin.MouseState.HOVER
        Me.Staff_ID.Name = "Staff_ID"
        Me.Staff_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Staff_ID.SelectedText = ""
        Me.Staff_ID.SelectionLength = 0
        Me.Staff_ID.SelectionStart = 0
        Me.Staff_ID.Size = New System.Drawing.Size(253, 23)
        Me.Staff_ID.TabIndex = 2
        Me.Staff_ID.UseSystemPasswordChar = False
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(25, 109)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel8.TabIndex = 13
        Me.MaterialLabel8.Text = "Staff ID"
        '
        'SectorField
        '
        Me.SectorField.FormattingEnabled = True
        Me.SectorField.ItemHeight = 23
        Me.SectorField.Items.AddRange(New Object() {"Administration", "Academics"})
        Me.SectorField.Location = New System.Drawing.Point(161, 315)
        Me.SectorField.MaxDropDownItems = 7
        Me.SectorField.Name = "SectorField"
        Me.SectorField.Size = New System.Drawing.Size(252, 29)
        Me.SectorField.TabIndex = 7
        Me.SectorField.UseSelectable = True
        '
        'AddStaffForm
        '
        Me.AcceptButton = Me.AddStaffButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 468)
        Me.Controls.Add(Me.departmentCombo)
        Me.Controls.Add(Me.AddStaffButton)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.SectorField)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.emailField)
        Me.Controls.Add(Me.femaleRadio)
        Me.Controls.Add(Me.PositionField)
        Me.Controls.Add(Me.maleRadio)
        Me.Controls.Add(Me.Staff_ID)
        Me.Controls.Add(Me.firstNameField)
        Me.Controls.Add(Me.surnameField)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddStaffForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Add New Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents surnameField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents firstNameField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents maleRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents femaleRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents dob As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PositionField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents emailField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AddStaffButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents departmentCombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Staff_ID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SectorField As MetroFramework.Controls.MetroComboBox
End Class
