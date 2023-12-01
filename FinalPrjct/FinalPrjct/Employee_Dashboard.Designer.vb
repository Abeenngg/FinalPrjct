<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Dashboard
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
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button5 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Button8 = New Button()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        dgvPendingDiscount = New DataGridView()
        Button7 = New Button()
        Button6 = New Button()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Panel4 = New Panel()
        Button9 = New Button()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        Panel5 = New Panel()
        Label10 = New Label()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        Panel6 = New Panel()
        Label13 = New Label()
        PictureBox3 = New PictureBox()
        Label14 = New Label()
        Panel7 = New Panel()
        Label11 = New Label()
        Label12 = New Label()
        PictureBox4 = New PictureBox()
        Panel8 = New Panel()
        Label15 = New Label()
        Label16 = New Label()
        PictureBox5 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(dgvPendingDiscount, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(86, 823)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ImageAlign = ContentAlignment.TopLeft
        Label5.Location = New Point(12, 554)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 20)
        Label5.TabIndex = 11
        Label5.Text = "Reports"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(10, 436)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 34)
        Label4.TabIndex = 10
        Label4.Text = "Customer" & vbCrLf & "Ranking"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 317)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 34)
        Label3.TabIndex = 9
        Label3.Text = "Purchase " & vbCrLf & "History" & vbCrLf
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopLeft
        Label2.Location = New Point(3, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 34)
        Label2.TabIndex = 8
        Label2.Text = "Customer" & vbCrLf & "Information"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopLeft
        Label1.Location = New Point(1, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.Transparent
        Button5.Image = My.Resources.Resources.customer_ranking
        Button5.Location = New Point(3, 382)
        Button5.Name = "Button5"
        Button5.Size = New Size(80, 81)
        Button5.TabIndex = 7
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Transparent
        Button3.Image = My.Resources.Resources.reports
        Button3.Location = New Point(3, 493)
        Button3.Name = "Button3"
        Button3.Size = New Size(80, 81)
        Button3.TabIndex = 6
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.Transparent
        Button4.Image = My.Resources.Resources.purchase_history
        Button4.Location = New Point(3, 256)
        Button4.Name = "Button4"
        Button4.Size = New Size(80, 81)
        Button4.TabIndex = 5
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = My.Resources.Resources.customer_info
        Button2.Location = New Point(3, 138)
        Button2.Name = "Button2"
        Button2.Size = New Size(80, 81)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Image = My.Resources.Resources.dashboard1
        Button1.Location = New Point(3, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 81)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1114, 78)
        Panel2.TabIndex = 1
        Panel2.Visible = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.Image = My.Resources.Resources.user_icon
        Button8.Location = New Point(1031, 9)
        Button8.Name = "Button8"
        Button8.Size = New Size(77, 60)
        Button8.TabIndex = 3
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(92, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(421, 60)
        Label6.TabIndex = 2
        Label6.Text = "EMPLOYEE PORTAL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.normilogo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Wheat
        Panel3.Controls.Add(dgvPendingDiscount)
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(Button6)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(103, 99)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(611, 790)
        Panel3.TabIndex = 2
        ' 
        ' dgvPendingDiscount
        ' 
        dgvPendingDiscount.AllowUserToAddRows = False
        dgvPendingDiscount.BackgroundColor = Color.Wheat
        dgvPendingDiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPendingDiscount.Location = New Point(19, 143)
        dgvPendingDiscount.Name = "dgvPendingDiscount"
        dgvPendingDiscount.RowHeadersWidth = 51
        dgvPendingDiscount.RowTemplate.Height = 29
        dgvPendingDiscount.Size = New Size(574, 629)
        dgvPendingDiscount.TabIndex = 5
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(469, 85)
        Button7.Name = "Button7"
        Button7.Size = New Size(125, 34)
        Button7.TabIndex = 4
        Button7.Text = "Unclaimed"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(327, 85)
        Button6.Name = "Button6"
        Button6.Size = New Size(125, 34)
        Button6.TabIndex = 3
        Button6.Text = "Search"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(20, 85)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search Name"
        TextBox1.Size = New Size(272, 34)
        TextBox1.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Orange
        Label7.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(141, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(303, 46)
        Label7.TabIndex = 0
        Label7.Text = "Pending Discount"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Wheat
        Panel4.Controls.Add(Button9)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(DataGridView1)
        Panel4.Location = New Point(722, 99)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(381, 442)
        Panel4.TabIndex = 5
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.ForeColor = Color.White
        Button9.Location = New Point(278, 33)
        Button9.Name = "Button9"
        Button9.Size = New Size(94, 29)
        Button9.TabIndex = 2
        Button9.Text = "See more"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(9, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(222, 23)
        Label8.TabIndex = 1
        Label8.Text = "Monthly Customer Ranking"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Wheat
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(9, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(363, 366)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Thistle
        Panel5.Controls.Add(Label10)
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(PictureBox2)
        Panel5.Location = New Point(722, 547)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(177, 164)
        Panel5.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(20, 136)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 23)
        Label10.TabIndex = 2
        Label10.Text = "Total Customers"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(65, 79)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 28)
        Label9.TabIndex = 1
        Label9.Text = "256"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.persons
        PictureBox2.Location = New Point(62, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 45)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel6.Controls.Add(Label13)
        Panel6.Controls.Add(PictureBox3)
        Panel6.Controls.Add(Label14)
        Panel6.Location = New Point(926, 547)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(177, 164)
        Panel6.TabIndex = 7
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(8, 136)
        Label13.Name = "Label13"
        Label13.Size = New Size(163, 23)
        Label13.TabIndex = 4
        Label13.Text = "Unclaimed Discount"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.layers
        PictureBox3.Location = New Point(71, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 45)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(83, 80)
        Label14.Name = "Label14"
        Label14.Size = New Size(24, 28)
        Label14.TabIndex = 3
        Label14.Text = "3"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.PowderBlue
        Panel7.Controls.Add(Label11)
        Panel7.Controls.Add(Label12)
        Panel7.Controls.Add(PictureBox4)
        Panel7.Location = New Point(722, 725)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(177, 164)
        Panel7.TabIndex = 7
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(26, 114)
        Label11.Name = "Label11"
        Label11.Size = New Size(126, 46)
        Label11.TabIndex = 4
        Label11.Text = "New customer " & vbCrLf & "this month" & vbCrLf
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(73, 70)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 28)
        Label12.TabIndex = 3
        Label12.Text = "5"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.newcustomer
        PictureBox4.Location = New Point(62, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 45)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Panel8.Controls.Add(Label15)
        Panel8.Controls.Add(Label16)
        Panel8.Controls.Add(PictureBox5)
        Panel8.Location = New Point(926, 725)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(177, 164)
        Panel8.TabIndex = 8
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(36, 113)
        Label15.Name = "Label15"
        Label15.Size = New Size(113, 46)
        Label15.TabIndex = 4
        Label15.Text = "Total Claimed" & vbCrLf & "Discounts" & vbCrLf
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(83, 70)
        Label16.Name = "Label16"
        Label16.Size = New Size(24, 28)
        Label16.TabIndex = 3
        Label16.Text = "0"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.claimedDiscount
        PictureBox5.Location = New Point(71, 13)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(50, 45)
        PictureBox5.TabIndex = 2
        PictureBox5.TabStop = False
        ' 
        ' Employee_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1113, 901)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Employee_Dashboard"
        Text = "Employee_Dashboard"
        TransparencyKey = Color.Transparent
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvPendingDiscount, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents dgvPendingDiscount As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
