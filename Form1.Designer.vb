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
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        ComboBox1 = New ComboBox()
        PictureBox3 = New PictureBox()
        txtK = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(112, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(387, 23)
        TextBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(36, 111)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(270, 200)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(370, 111)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(270, 200)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(615, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(677, 111)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(270, 200)
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' txtK
        ' 
        txtK.Location = New Point(615, 388)
        txtK.Name = "txtK"
        txtK.Size = New Size(100, 23)
        txtK.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(976, 530)
        Controls.Add(txtK)
        Controls.Add(PictureBox3)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "s"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtK As TextBox

End Class
