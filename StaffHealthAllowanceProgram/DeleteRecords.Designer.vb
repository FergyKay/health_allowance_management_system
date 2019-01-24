<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteRecords
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteRecords))
        Me.idToBeDeleted = New MetroFramework.Controls.MetroComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Delete = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idToBeDeleted
        '
        Me.idToBeDeleted.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idToBeDeleted.FormattingEnabled = True
        Me.idToBeDeleted.ItemHeight = 23
        Me.idToBeDeleted.Location = New System.Drawing.Point(51, 111)
        Me.idToBeDeleted.Name = "idToBeDeleted"
        Me.idToBeDeleted.Size = New System.Drawing.Size(282, 29)
        Me.idToBeDeleted.TabIndex = 0
        Me.idToBeDeleted.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(359, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Delete
        '
        Me.Delete.AutoSize = True
        Me.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete.Depth = 0
        Me.Delete.Location = New System.Drawing.Point(159, 194)
        Me.Delete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.Delete.Name = "Delete"
        Me.Delete.Primary = False
        Me.Delete.Size = New System.Drawing.Size(60, 36)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'DeleteRecords
        '
        Me.AcceptButton = Me.Delete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.idToBeDeleted)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteRecords"
        Me.Resizable = False
        Me.Text = "Delete Record"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idToBeDeleted As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Delete As MaterialSkin.Controls.MaterialFlatButton
End Class
