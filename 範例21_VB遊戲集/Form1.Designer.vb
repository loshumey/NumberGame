<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.猜數字ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終極密碼 = New System.Windows.Forms.ToolStripMenuItem()
        Me.幾A幾BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mylist = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.LabelOut = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.猜數字ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(745, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "猜數字"
        '
        '猜數字ToolStripMenuItem
        '
        Me.猜數字ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.終極密碼, Me.幾A幾BToolStripMenuItem})
        Me.猜數字ToolStripMenuItem.Name = "猜數字ToolStripMenuItem"
        Me.猜數字ToolStripMenuItem.Size = New System.Drawing.Size(104, 29)
        Me.猜數字ToolStripMenuItem.Text = "遊戲選擇"
        '
        '終極密碼
        '
        Me.終極密碼.Name = "終極密碼"
        Me.終極密碼.Size = New System.Drawing.Size(164, 30)
        Me.終極密碼.Text = "終極密碼"
        '
        '幾A幾BToolStripMenuItem
        '
        Me.幾A幾BToolStripMenuItem.Name = "幾A幾BToolStripMenuItem"
        Me.幾A幾BToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.幾A幾BToolStripMenuItem.Text = "幾A幾B"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(64, 29)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        'mylist
        '
        Me.mylist.FormattingEnabled = True
        Me.mylist.ItemHeight = 34
        Me.mylist.Location = New System.Drawing.Point(23, 98)
        Me.mylist.Name = "mylist"
        Me.mylist.Size = New System.Drawing.Size(266, 480)
        Me.mylist.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "遊戲過程與提示"
        '
        'Pic
        '
        Me.Pic.Location = New System.Drawing.Point(372, 112)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(263, 247)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic.TabIndex = 3
        Me.Pic.TabStop = False
        '
        'LabelOut
        '
        Me.LabelOut.AutoSize = True
        Me.LabelOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelOut.Location = New System.Drawing.Point(366, 381)
        Me.LabelOut.Name = "LabelOut"
        Me.LabelOut.Size = New System.Drawing.Size(211, 35)
        Me.LabelOut.TabIndex = 4
        Me.LabelOut.Text = "遊戲過程與提示"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "厲害.jpeg")
        Me.ImageList1.Images.SetKeyName(1, "中等.png")
        Me.ImageList1.Images.SetKeyName(2, "笨.jpg")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 629)
        Me.Controls.Add(Me.LabelOut)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mylist)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 猜數字ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 終極密碼 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 幾A幾BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mylist As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents LabelOut As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
