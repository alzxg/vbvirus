<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.b = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'b
        '
        Me.b.BackColor = System.Drawing.Color.Lime
        Me.b.Font = New System.Drawing.Font("MS Reference Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(47, 27)
        Me.b.MaximumSize = New System.Drawing.Size(920, 920)
        Me.b.MinimumSize = New System.Drawing.Size(920, 920)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(920, 920)
        Me.b.TabIndex = 0
        Me.b.Text = "☐☐☐☐?"
        Me.b.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1008, 985)
        Me.Controls.Add(Me.b)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 1024)
        Me.MinimumSize = New System.Drawing.Size(1024, 1024)
        Me.Name = "Form1"
        Me.Text = "no"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents b As Button
End Class
