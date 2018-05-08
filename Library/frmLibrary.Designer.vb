<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibrary
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
        Me.lstRatings = New System.Windows.Forms.ListBox()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstRatings
        '
        Me.lstRatings.FormattingEnabled = True
        Me.lstRatings.Location = New System.Drawing.Point(35, 59)
        Me.lstRatings.Name = "lstRatings"
        Me.lstRatings.Size = New System.Drawing.Size(205, 446)
        Me.lstRatings.TabIndex = 0
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.Location = New System.Drawing.Point(264, 60)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(487, 446)
        Me.lstBooks.TabIndex = 1
        '
        'frmLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 610)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.lstRatings)
        Me.Name = "frmLibrary"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstRatings As ListBox
    Friend WithEvents lstBooks As ListBox
End Class
