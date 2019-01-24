<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reversal
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
        Me.transactingHospital = New MetroFramework.Controls.MetroComboBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.serviceType = New MetroFramework.Controls.MetroComboBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.ReversalAmount = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.rev_dateD = New MetroFramework.Controls.MetroDateTime()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.funds = New MaterialSkin.Controls.MaterialLabel()
        Me.benefactor = New MetroFramework.Controls.MetroComboBox()
        Me.benefactorType = New MetroFramework.Controls.MetroComboBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.BenfactorID = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'transactingHospital
        '
        Me.transactingHospital.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.transactingHospital.FormattingEnabled = True
        Me.transactingHospital.ItemHeight = 23
        Me.transactingHospital.Location = New System.Drawing.Point(205, 192)
        Me.transactingHospital.MaxDropDownItems = 7
        Me.transactingHospital.Name = "transactingHospital"
        Me.transactingHospital.Size = New System.Drawing.Size(236, 29)
        Me.transactingHospital.Style = MetroFramework.MetroColorStyle.Silver
        Me.transactingHospital.TabIndex = 2
        Me.transactingHospital.UseSelectable = True
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(35, 192)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(149, 19)
        Me.MaterialLabel7.TabIndex = 12
        Me.MaterialLabel7.Text = "Transacting Hospital"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(35, 244)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(162, 19)
        Me.MaterialLabel1.TabIndex = 13
        Me.MaterialLabel1.Text = "Reversal Account Type"
        '
        'serviceType
        '
        Me.serviceType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.serviceType.FormattingEnabled = True
        Me.serviceType.ItemHeight = 23
        Me.serviceType.Location = New System.Drawing.Point(205, 245)
        Me.serviceType.MaxDropDownItems = 7
        Me.serviceType.Name = "serviceType"
        Me.serviceType.Size = New System.Drawing.Size(236, 29)
        Me.serviceType.Style = MetroFramework.MetroColorStyle.Silver
        Me.serviceType.TabIndex = 3
        Me.serviceType.UseSelectable = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(35, 343)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(148, 19)
        Me.MaterialLabel2.TabIndex = 15
        Me.MaterialLabel2.Text = "Reversal Value (Ghc)"
        '
        'ReversalAmount
        '
        Me.ReversalAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReversalAmount.Depth = 0
        Me.ReversalAmount.Hint = ""
        Me.ReversalAmount.Location = New System.Drawing.Point(210, 341)
        Me.ReversalAmount.MouseState = MaterialSkin.MouseState.HOVER
        Me.ReversalAmount.Name = "ReversalAmount"
        Me.ReversalAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ReversalAmount.SelectedText = ""
        Me.ReversalAmount.SelectionLength = 0
        Me.ReversalAmount.SelectionStart = 0
        Me.ReversalAmount.Size = New System.Drawing.Size(232, 23)
        Me.ReversalAmount.TabIndex = 4
        Me.ReversalAmount.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(35, 404)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(101, 19)
        Me.MaterialLabel6.TabIndex = 16
        Me.MaterialLabel6.Text = "Reversal Date"
        '
        'rev_dateD
        '
        Me.rev_dateD.Enabled = False
        Me.rev_dateD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rev_dateD.Location = New System.Drawing.Point(221, 394)
        Me.rev_dateD.MinimumSize = New System.Drawing.Size(0, 29)
        Me.rev_dateD.Name = "rev_dateD"
        Me.rev_dateD.Size = New System.Drawing.Size(240, 29)
        Me.rev_dateD.Style = MetroFramework.MetroColorStyle.Silver
        Me.rev_dateD.TabIndex = 5
        Me.rev_dateD.Value = New Date(2018, 5, 30, 12, 0, 15, 0)
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(205, 477)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(128, 36)
        Me.MaterialFlatButton1.TabIndex = 6
        Me.MaterialFlatButton1.Text = "Update Records"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(35, 296)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(114, 19)
        Me.MaterialLabel4.TabIndex = 14
        Me.MaterialLabel4.Text = "Funds Available"
        '
        'funds
        '
        Me.funds.AutoSize = True
        Me.funds.Depth = 0
        Me.funds.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.funds.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.funds.Location = New System.Drawing.Point(226, 296)
        Me.funds.MouseState = MaterialSkin.MouseState.HOVER
        Me.funds.Name = "funds"
        Me.funds.Size = New System.Drawing.Size(13, 19)
        Me.funds.TabIndex = 8
        Me.funds.Text = " "
        '
        'benefactor
        '
        Me.benefactor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.benefactor.FormattingEnabled = True
        Me.benefactor.ItemHeight = 23
        Me.benefactor.Location = New System.Drawing.Point(207, 89)
        Me.benefactor.MaxDropDownItems = 7
        Me.benefactor.Name = "benefactor"
        Me.benefactor.Size = New System.Drawing.Size(240, 29)
        Me.benefactor.Style = MetroFramework.MetroColorStyle.Silver
        Me.benefactor.TabIndex = 1
        Me.benefactor.UseSelectable = True
        '
        'benefactorType
        '
        Me.benefactorType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.benefactorType.FormattingEnabled = True
        Me.benefactorType.ItemHeight = 23
        Me.benefactorType.Location = New System.Drawing.Point(207, 34)
        Me.benefactorType.MaxDropDownItems = 7
        Me.benefactorType.Name = "benefactorType"
        Me.benefactorType.Size = New System.Drawing.Size(240, 29)
        Me.benefactorType.Style = MetroFramework.MetroColorStyle.Silver
        Me.benefactorType.TabIndex = 0
        Me.benefactorType.UseSelectable = True
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(35, 89)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel5.TabIndex = 10
        Me.MaterialLabel5.Text = "Benefactor"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(35, 34)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(118, 19)
        Me.MaterialLabel3.TabIndex = 9
        Me.MaterialLabel3.Text = "Benefactor Type"
        '
        'BenfactorID
        '
        Me.BenfactorID.AutoSize = True
        Me.BenfactorID.Depth = 0
        Me.BenfactorID.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.BenfactorID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BenfactorID.Location = New System.Drawing.Point(226, 142)
        Me.BenfactorID.MouseState = MaterialSkin.MouseState.HOVER
        Me.BenfactorID.Name = "BenfactorID"
        Me.BenfactorID.Size = New System.Drawing.Size(13, 19)
        Me.BenfactorID.TabIndex = 7
        Me.BenfactorID.Text = " "
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(35, 142)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(100, 19)
        Me.MaterialLabel10.TabIndex = 11
        Me.MaterialLabel10.Text = "Benefactor ID"
        '
        'Reversal
        '
        Me.AcceptButton = Me.MaterialFlatButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 569)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.benefactorType)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.benefactor)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.BenfactorID)
        Me.Controls.Add(Me.transactingHospital)
        Me.Controls.Add(Me.serviceType)
        Me.Controls.Add(Me.ReversalAmount)
        Me.Controls.Add(Me.rev_dateD)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.funds)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Reversal"
        Me.Text = "Reversal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents transactingHospital As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents serviceType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ReversalAmount As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rev_dateD As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents funds As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents benefactor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents benefactorType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BenfactorID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
End Class
