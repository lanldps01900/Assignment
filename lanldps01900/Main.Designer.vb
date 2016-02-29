<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.QLKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.QLSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripSplitButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(344, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QLKháchHàngToolStripMenuItem})
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel1.Text = "Khách Hàng"
        '
        'QLKháchHàngToolStripMenuItem
        '
        Me.QLKháchHàngToolStripMenuItem.Name = "QLKháchHàngToolStripMenuItem"
        Me.QLKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.QLKháchHàngToolStripMenuItem.Text = "QL Khách hàng"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QLSảnPhẩmToolStripMenuItem})
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel2.Text = "Sản Phẩm"
        '
        'QLSảnPhẩmToolStripMenuItem
        '
        Me.QLSảnPhẩmToolStripMenuItem.Name = "QLSảnPhẩmToolStripMenuItem"
        Me.QLSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.QLSảnPhẩmToolStripMenuItem.Text = "QL Sản Phẩm"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel4.Text = "Liên hệ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.lanldps01900.My.Resources.Resources.galaxy_s3_wallpaper_1920x10801
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 231)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(344, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents QLKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents QLSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
