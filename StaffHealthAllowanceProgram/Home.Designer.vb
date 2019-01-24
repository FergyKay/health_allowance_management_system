<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.VIewRecords = New MaterialSkin.Controls.MaterialFlatButton()
        Me.QueryButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.UpdateRecords = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Settings = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Logout = New MaterialSkin.Controls.MaterialFlatButton()
        Me.DataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.UpdatePanel = New System.Windows.Forms.Panel()
        Me.updateClient = New MetroFramework.Controls.MetroTile()
        Me.AddButton = New MetroFramework.Controls.MetroTile()
        Me.AddOptions = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialFlatButton3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.print = New System.Windows.Forms.PictureBox()
        Me.RadioPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.StaffRadio = New MetroFramework.Controls.MetroRadioButton()
        Me.SpouseRadio = New MetroFramework.Controls.MetroRadioButton()
        Me.WardRadio = New MetroFramework.Controls.MetroRadioButton()
        Me.DepartmentRadio = New MetroFramework.Controls.MetroRadioButton()
        Me.HospitalRadio = New MetroFramework.Controls.MetroRadioButton()
        Me.txns = New MetroFramework.Controls.MetroRadioButton()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdatePanel.SuspendLayout()
        Me.AddOptions.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadioPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.VIewRecords)
        Me.FlowLayoutPanel1.Controls.Add(Me.QueryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdateRecords)
        Me.FlowLayoutPanel1.Controls.Add(Me.Settings)
        Me.FlowLayoutPanel1.Controls.Add(Me.Logout)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(769, 48)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'VIewRecords
        '
        Me.VIewRecords.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VIewRecords.AutoSize = True
        Me.VIewRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.VIewRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VIewRecords.Depth = 0
        Me.VIewRecords.Location = New System.Drawing.Point(4, 6)
        Me.VIewRecords.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.VIewRecords.MouseState = MaterialSkin.MouseState.HOVER
        Me.VIewRecords.Name = "VIewRecords"
        Me.VIewRecords.Primary = False
        Me.VIewRecords.Size = New System.Drawing.Size(112, 36)
        Me.VIewRecords.TabIndex = 1
        Me.VIewRecords.Text = "View  Records"
        Me.VIewRecords.UseVisualStyleBackColor = True
        '
        'QueryButton
        '
        Me.QueryButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QueryButton.AutoSize = True
        Me.QueryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.QueryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QueryButton.Depth = 0
        Me.QueryButton.Location = New System.Drawing.Point(124, 6)
        Me.QueryButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.QueryButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.QueryButton.Name = "QueryButton"
        Me.QueryButton.Primary = False
        Me.QueryButton.Size = New System.Drawing.Size(119, 36)
        Me.QueryButton.TabIndex = 1
        Me.QueryButton.Text = "Query Records"
        Me.QueryButton.UseVisualStyleBackColor = True
        '
        'UpdateRecords
        '
        Me.UpdateRecords.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UpdateRecords.AutoSize = True
        Me.UpdateRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UpdateRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateRecords.Depth = 0
        Me.UpdateRecords.Location = New System.Drawing.Point(251, 6)
        Me.UpdateRecords.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdateRecords.MouseState = MaterialSkin.MouseState.HOVER
        Me.UpdateRecords.Name = "UpdateRecords"
        Me.UpdateRecords.Primary = False
        Me.UpdateRecords.Size = New System.Drawing.Size(128, 36)
        Me.UpdateRecords.TabIndex = 1
        Me.UpdateRecords.Text = "Update Records"
        Me.UpdateRecords.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Settings.AutoSize = True
        Me.Settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settings.Depth = 0
        Me.Settings.Location = New System.Drawing.Point(387, 6)
        Me.Settings.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Settings.MouseState = MaterialSkin.MouseState.HOVER
        Me.Settings.Name = "Settings"
        Me.Settings.Primary = False
        Me.Settings.Size = New System.Drawing.Size(76, 36)
        Me.Settings.TabIndex = 2
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Logout.AutoSize = True
        Me.Logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.Depth = 0
        Me.Logout.Location = New System.Drawing.Point(471, 6)
        Me.Logout.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Logout.MouseState = MaterialSkin.MouseState.HOVER
        Me.Logout.Name = "Logout"
        Me.Logout.Primary = False
        Me.Logout.Size = New System.Drawing.Size(65, 36)
        Me.Logout.TabIndex = 3
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(20, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(769, 336)
        Me.DataGridView1.Style = MetroFramework.MetroColorStyle.Blue
        Me.DataGridView1.TabIndex = 1
        '
        'UpdatePanel
        '
        Me.UpdatePanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UpdatePanel.AutoSize = True
        Me.UpdatePanel.Controls.Add(Me.updateClient)
        Me.UpdatePanel.Controls.Add(Me.AddButton)
        Me.UpdatePanel.Location = New System.Drawing.Point(143, 139)
        Me.UpdatePanel.Name = "UpdatePanel"
        Me.UpdatePanel.Size = New System.Drawing.Size(508, 254)
        Me.UpdatePanel.TabIndex = 3
        '
        'updateClient
        '
        Me.updateClient.ActiveControl = Nothing
        Me.updateClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateClient.Location = New System.Drawing.Point(285, 56)
        Me.updateClient.Name = "updateClient"
        Me.updateClient.Size = New System.Drawing.Size(118, 147)
        Me.updateClient.TabIndex = 0
        Me.updateClient.Text = "Update"
        Me.updateClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.updateClient.TileImage = CType(resources.GetObject("updateClient.TileImage"), System.Drawing.Image)
        Me.updateClient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.updateClient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.updateClient.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.updateClient.UseSelectable = True
        Me.updateClient.UseTileImage = True
        '
        'AddButton
        '
        Me.AddButton.ActiveControl = Nothing
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddButton.Location = New System.Drawing.Point(117, 56)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(118, 147)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddButton.TileImage = CType(resources.GetObject("AddButton.TileImage"), System.Drawing.Image)
        Me.AddButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.AddButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.AddButton.UseSelectable = True
        Me.AddButton.UseTileImage = True
        '
        'AddOptions
        '
        Me.AddOptions.AutoSize = True
        Me.AddOptions.BackColor = System.Drawing.Color.White
        Me.AddOptions.Controls.Add(Me.PictureBox1)
        Me.AddOptions.Controls.Add(Me.MaterialFlatButton3)
        Me.AddOptions.Controls.Add(Me.MaterialFlatButton2)
        Me.AddOptions.Controls.Add(Me.MaterialFlatButton1)
        Me.AddOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddOptions.Location = New System.Drawing.Point(20, 108)
        Me.AddOptions.Name = "AddOptions"
        Me.AddOptions.Size = New System.Drawing.Size(769, 51)
        Me.AddOptions.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(750, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.AutoSize = True
        Me.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton3.Depth = 0
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(127, 9)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Primary = False
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(51, 36)
        Me.MaterialFlatButton3.TabIndex = 2
        Me.MaterialFlatButton3.Text = "Ward"
        Me.MaterialFlatButton3.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(62, 9)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(63, 36)
        Me.MaterialFlatButton2.TabIndex = 1
        Me.MaterialFlatButton2.Text = "Spouse"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(4, 9)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(53, 36)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "Staff"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(754, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(782, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'print
        '
        Me.print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.print.Image = CType(resources.GetObject("print.Image"), System.Drawing.Image)
        Me.print.Location = New System.Drawing.Point(754, 398)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(32, 26)
        Me.print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.print.TabIndex = 4
        Me.print.TabStop = False
        '
        'RadioPanel
        '
        Me.RadioPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RadioPanel.Controls.Add(Me.StaffRadio)
        Me.RadioPanel.Controls.Add(Me.SpouseRadio)
        Me.RadioPanel.Controls.Add(Me.WardRadio)
        Me.RadioPanel.Controls.Add(Me.DepartmentRadio)
        Me.RadioPanel.Controls.Add(Me.HospitalRadio)
        Me.RadioPanel.Controls.Add(Me.txns)
        Me.RadioPanel.Location = New System.Drawing.Point(20, 446)
        Me.RadioPanel.Name = "RadioPanel"
        Me.RadioPanel.Size = New System.Drawing.Size(677, 22)
        Me.RadioPanel.TabIndex = 6
        '
        'StaffRadio
        '
        Me.StaffRadio.AutoSize = True
        Me.StaffRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StaffRadio.Dock = System.Windows.Forms.DockStyle.Left
        Me.StaffRadio.Location = New System.Drawing.Point(3, 3)
        Me.StaffRadio.Name = "StaffRadio"
        Me.StaffRadio.Size = New System.Drawing.Size(47, 15)
        Me.StaffRadio.TabIndex = 8
        Me.StaffRadio.Text = "Staff"
        Me.StaffRadio.UseSelectable = True
        '
        'SpouseRadio
        '
        Me.SpouseRadio.AutoSize = True
        Me.SpouseRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SpouseRadio.Dock = System.Windows.Forms.DockStyle.Left
        Me.SpouseRadio.Location = New System.Drawing.Point(56, 3)
        Me.SpouseRadio.Name = "SpouseRadio"
        Me.SpouseRadio.Size = New System.Drawing.Size(61, 15)
        Me.SpouseRadio.TabIndex = 9
        Me.SpouseRadio.Text = "Spouse"
        Me.SpouseRadio.UseSelectable = True
        '
        'WardRadio
        '
        Me.WardRadio.AutoSize = True
        Me.WardRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WardRadio.Dock = System.Windows.Forms.DockStyle.Left
        Me.WardRadio.Location = New System.Drawing.Point(123, 3)
        Me.WardRadio.Name = "WardRadio"
        Me.WardRadio.Size = New System.Drawing.Size(51, 15)
        Me.WardRadio.TabIndex = 10
        Me.WardRadio.Text = "Ward"
        Me.WardRadio.UseSelectable = True
        '
        'DepartmentRadio
        '
        Me.DepartmentRadio.AutoSize = True
        Me.DepartmentRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DepartmentRadio.Dock = System.Windows.Forms.DockStyle.Left
        Me.DepartmentRadio.Location = New System.Drawing.Point(180, 3)
        Me.DepartmentRadio.Name = "DepartmentRadio"
        Me.DepartmentRadio.Size = New System.Drawing.Size(86, 15)
        Me.DepartmentRadio.TabIndex = 11
        Me.DepartmentRadio.Text = "Department"
        Me.DepartmentRadio.UseSelectable = True
        '
        'HospitalRadio
        '
        Me.HospitalRadio.AutoSize = True
        Me.HospitalRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HospitalRadio.Dock = System.Windows.Forms.DockStyle.Left
        Me.HospitalRadio.Location = New System.Drawing.Point(272, 3)
        Me.HospitalRadio.Name = "HospitalRadio"
        Me.HospitalRadio.Size = New System.Drawing.Size(67, 15)
        Me.HospitalRadio.TabIndex = 12
        Me.HospitalRadio.Text = "Hospital"
        Me.HospitalRadio.UseSelectable = True
        '
        'txns
        '
        Me.txns.AutoSize = True
        Me.txns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txns.Dock = System.Windows.Forms.DockStyle.Left
        Me.txns.Location = New System.Drawing.Point(345, 3)
        Me.txns.Name = "txns"
        Me.txns.Size = New System.Drawing.Size(84, 15)
        Me.txns.TabIndex = 13
        Me.txns.Text = "Transaction"
        Me.txns.UseSelectable = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadioPanel)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.AddOptions)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.UpdatePanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "Home"
        Me.Text = "Home"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdatePanel.ResumeLayout(False)
        Me.AddOptions.ResumeLayout(False)
        Me.AddOptions.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadioPanel.ResumeLayout(False)
        Me.RadioPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents QueryButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents VIewRecords As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Settings As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Logout As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DataGridView1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents UpdatePanel As Panel
    Friend WithEvents updateClient As MetroFramework.Controls.MetroTile
    Friend WithEvents AddButton As MetroFramework.Controls.MetroTile
    Friend WithEvents AddOptions As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialFlatButton3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents UpdateRecords As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents print As PictureBox
    Friend WithEvents RadioPanel As FlowLayoutPanel
    Friend WithEvents StaffRadio As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents SpouseRadio As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents WardRadio As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents DepartmentRadio As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents HospitalRadio As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txns As MetroFramework.Controls.MetroRadioButton
End Class
