<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        btnExit = New Button()
        Label2 = New Label()
        txtFirst = New TextBox()
        txtLast = New TextBox()
        txtAddress = New TextBox()
        txtTax = New TextBox()
        txtSkate = New TextBox()
        txtTotal = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(228, 9)
        Label1.Margin = New Padding(11, 0, 11, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 45)
        Label1.TabIndex = 1
        Label1.Text = "Order Summary"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(562, 14)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(144, 55)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 38)
        Label2.TabIndex = 3
        Label2.Text = "First Name: "
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(298, 81)
        txtFirst.Multiline = True
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(378, 46)
        txtFirst.TabIndex = 4
        ' 
        ' txtLast
        ' 
        txtLast.Location = New Point(298, 133)
        txtLast.Multiline = True
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(378, 46)
        txtLast.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(298, 185)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(378, 46)
        txtAddress.TabIndex = 6
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(298, 237)
        txtTax.Multiline = True
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(378, 46)
        txtTax.TabIndex = 7
        ' 
        ' txtSkate
        ' 
        txtSkate.Location = New Point(298, 289)
        txtSkate.Multiline = True
        txtSkate.Name = "txtSkate"
        txtSkate.Size = New Size(378, 46)
        txtSkate.TabIndex = 8
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(298, 341)
        txtTotal.Multiline = True
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(378, 46)
        txtTotal.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 38)
        Label3.TabIndex = 10
        Label3.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 38)
        Label4.TabIndex = 11
        Label4.Text = "Address:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 38)
        Label5.TabIndex = 12
        Label5.Text = "Sales Tax:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 297)
        Label6.Name = "Label6"
        Label6.Size = New Size(267, 38)
        Label6.TabIndex = 13
        Label6.Text = "Number of Boards:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 349)
        Label7.Name = "Label7"
        Label7.Size = New Size(205, 38)
        Label7.TabIndex = 14
        Label7.Text = "Total Amount:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(274, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 56)
        Button1.TabIndex = 15
        Button1.Text = "Buy"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(19F, 45F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(727, 461)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtTotal)
        Controls.Add(txtSkate)
        Controls.Add(txtTax)
        Controls.Add(txtAddress)
        Controls.Add(txtLast)
        Controls.Add(txtFirst)
        Controls.Add(Label2)
        Controls.Add(btnExit)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(6, 5, 6, 5)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtSkate As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
