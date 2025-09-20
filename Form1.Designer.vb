<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        txtid = New TextBox()
        lblid = New Label()
        txtyear = New TextBox()
        txtauthor = New TextBox()
        lblyear = New Label()
        lblauthor = New Label()
        txttitle = New TextBox()
        lbltitle = New Label()
        btnadd = New Button()
        btndelete = New Button()
        btnclear = New Button()
        btnload = New Button()
        DgvBooks = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtid)
        GroupBox1.Controls.Add(lblid)
        GroupBox1.Controls.Add(txtyear)
        GroupBox1.Controls.Add(txtauthor)
        GroupBox1.Controls.Add(lblyear)
        GroupBox1.Controls.Add(lblauthor)
        GroupBox1.Controls.Add(txttitle)
        GroupBox1.Controls.Add(lbltitle)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(518, 238)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "THÔNG TIN SÁCH"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(133, 47)
        txtid.Name = "txtid"
        txtid.Size = New Size(200, 27)
        txtid.TabIndex = 7
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Location = New Point(23, 47)
        lblid.Name = "lblid"
        lblid.Size = New Size(24, 20)
        lblid.TabIndex = 6
        lblid.Text = "ID"
        ' 
        ' txtyear
        ' 
        txtyear.Location = New Point(133, 195)
        txtyear.Name = "txtyear"
        txtyear.Size = New Size(200, 27)
        txtyear.TabIndex = 5
        ' 
        ' txtauthor
        ' 
        txtauthor.Location = New Point(133, 141)
        txtauthor.Name = "txtauthor"
        txtauthor.Size = New Size(200, 27)
        txtauthor.TabIndex = 4
        ' 
        ' lblyear
        ' 
        lblyear.AutoSize = True
        lblyear.Location = New Point(23, 202)
        lblyear.Name = "lblyear"
        lblyear.Size = New Size(65, 20)
        lblyear.TabIndex = 3
        lblyear.Text = "NĂM XB"
        ' 
        ' lblauthor
        ' 
        lblauthor.AutoSize = True
        lblauthor.Location = New Point(23, 148)
        lblauthor.Name = "lblauthor"
        lblauthor.Size = New Size(63, 20)
        lblauthor.TabIndex = 2
        lblauthor.Text = "TÁC GIẢ"
        ' 
        ' txttitle
        ' 
        txttitle.Location = New Point(133, 99)
        txttitle.Name = "txttitle"
        txttitle.Size = New Size(200, 27)
        txttitle.TabIndex = 1
        ' 
        ' lbltitle
        ' 
        lbltitle.AutoSize = True
        lbltitle.Location = New Point(23, 99)
        lbltitle.Name = "lbltitle"
        lbltitle.Size = New Size(78, 20)
        lbltitle.TabIndex = 0
        lbltitle.Text = "TÊN SÁCH"
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(12, 268)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(94, 29)
        btnadd.TabIndex = 6
        btnadd.Text = "THÊM SÁCH"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(145, 268)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 7
        btndelete.Text = "XÓA SÁCH"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(288, 268)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 29)
        btnclear.TabIndex = 8
        btnclear.Text = "LÀM MỚI"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' btnload
        ' 
        btnload.Location = New Point(436, 268)
        btnload.Name = "btnload"
        btnload.Size = New Size(94, 29)
        btnload.TabIndex = 9
        btnload.Text = "TẢI LẠI"
        btnload.UseVisualStyleBackColor = True
        ' 
        ' DgvBooks
        ' 
        DgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvBooks.Location = New Point(12, 325)
        DgvBooks.Name = "DgvBooks"
        DgvBooks.RowHeadersWidth = 51
        DgvBooks.Size = New Size(865, 204)
        DgvBooks.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(899, 641)
        Controls.Add(DgvBooks)
        Controls.Add(btnload)
        Controls.Add(btnclear)
        Controls.Add(btnadd)
        Controls.Add(btndelete)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "QUAN LY SACH"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttitle As TextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblyear As Label
    Friend WithEvents lblauthor As Label
    Friend WithEvents txtyear As TextBox
    Friend WithEvents txtauthor As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnload As Button
    Friend WithEvents DgvBooks As DataGridView
    Friend WithEvents lblid As Label
    Friend WithEvents txtid As TextBox

End Class
