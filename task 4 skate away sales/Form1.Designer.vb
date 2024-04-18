<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        txtFirst = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtLast = New TextBox()
        txtAddress = New TextBox()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(224, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 54)
        Label1.TabIndex = 0
        Label1.Text = "Skate Away Sales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(2, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 38)
        Label2.TabIndex = 1
        Label2.Text = "First Name: "
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(224, 87)
        txtFirst.Multiline = True
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(491, 46)
        txtFirst.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(2, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 38)
        Label3.TabIndex = 3
        Label3.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(2, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 38)
        Label4.TabIndex = 4
        Label4.Text = "Address:"
        ' 
        ' txtLast
        ' 
        txtLast.Location = New Point(224, 146)
        txtLast.Multiline = True
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(491, 46)
        txtLast.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(224, 198)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(491, 46)
        txtAddress.TabIndex = 6
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(177, 404)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(355, 34)
        btnNext.TabIndex = 7
        btnNext.Text = "Confirm Customer Purchase"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(727, 450)
        Controls.Add(btnNext)
        Controls.Add(txtAddress)
        Controls.Add(txtLast)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtFirst)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnNext As Button

End Class
