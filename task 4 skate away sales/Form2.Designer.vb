<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Quant1 = New NumericUpDown()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        Quant2 = New NumericUpDown()
        Label7 = New Label()
        Button1 = New Button()
        CType(Quant1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Quant2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(273, 9)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 45)
        Label1.TabIndex = 0
        Label1.Text = "Order Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 45)
        Label2.TabIndex = 1
        Label2.Text = "Product"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 45)
        Label3.TabIndex = 2
        Label3.Text = "Description"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(390, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 45)
        Label4.TabIndex = 3
        Label4.Text = "Quantity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(560, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 45)
        Label5.TabIndex = 4
        Label5.Text = "Price"
        ' 
        ' Quant1
        ' 
        Quant1.Location = New Point(375, 177)
        Quant1.Name = "Quant1"
        Quant1.Size = New Size(180, 50)
        Quant1.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Children_Yellow_Penny_Skateboard_PP_Skateboard
        PictureBox1.Location = New Point(12, 152)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(165, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(195, 152)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 128)
        TextBox1.TabIndex = 7
        TextBox1.Text = "A cool skateboard to explore the world"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(576, 177)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 45)
        Label6.TabIndex = 8
        Label6.Text = "$100"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 321)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(165, 128)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(195, 321)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 128)
        TextBox2.TabIndex = 10
        TextBox2.Text = "A sleek, blue skateboard to skate around"
        ' 
        ' Quant2
        ' 
        Quant2.Location = New Point(375, 355)
        Quant2.Name = "Quant2"
        Quant2.Size = New Size(180, 50)
        Quant2.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(576, 355)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 45)
        Label7.TabIndex = 12
        Label7.Text = "$100"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(178, 455)
        Button1.Name = "Button1"
        Button1.Size = New Size(363, 65)
        Button1.TabIndex = 13
        Button1.Text = "Confirm Purchase"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(19F, 45F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(709, 532)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Quant2)
        Controls.Add(TextBox2)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Quant1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(6, 5, 6, 5)
        Name = "Form2"
        Text = "Form2"
        CType(Quant1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Quant2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Quant1 As NumericUpDown
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Quant2 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
