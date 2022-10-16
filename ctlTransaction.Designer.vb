<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlTransaction
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbPlanned = New System.Windows.Forms.RadioButton()
        Me.rdbCompleted = New System.Windows.Forms.RadioButton()
        Me.cmbFromAccount = New System.Windows.Forms.ComboBox()
        Me.cmbToAccount = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 4
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpMain.Controls.Add(Me.Label4, 3, 0)
        Me.tlpMain.Controls.Add(Me.Label3, 2, 0)
        Me.tlpMain.Controls.Add(Me.Label2, 1, 0)
        Me.tlpMain.Controls.Add(Me.Label1, 0, 0)
        Me.tlpMain.Controls.Add(Me.rdbPlanned, 2, 2)
        Me.tlpMain.Controls.Add(Me.rdbCompleted, 3, 2)
        Me.tlpMain.Controls.Add(Me.cmbFromAccount, 0, 1)
        Me.tlpMain.Controls.Add(Me.cmbToAccount, 1, 1)
        Me.tlpMain.Controls.Add(Me.txtAmount, 2, 1)
        Me.tlpMain.Controls.Add(Me.dtpDate, 3, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(1130, 108)
        Me.tlpMain.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From Account:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(437, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(429, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Account:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(872, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(1002, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date:"
        '
        'rdbPlanned
        '
        Me.rdbPlanned.AutoSize = True
        Me.rdbPlanned.Checked = True
        Me.rdbPlanned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbPlanned.Location = New System.Drawing.Point(872, 74)
        Me.rdbPlanned.Margin = New System.Windows.Forms.Padding(3, 10, 3, 5)
        Me.rdbPlanned.Name = "rdbPlanned"
        Me.rdbPlanned.Size = New System.Drawing.Size(124, 29)
        Me.rdbPlanned.TabIndex = 4
        Me.rdbPlanned.TabStop = True
        Me.rdbPlanned.Text = "Planned"
        Me.rdbPlanned.UseVisualStyleBackColor = True
        '
        'rdbCompleted
        '
        Me.rdbCompleted.AutoSize = True
        Me.rdbCompleted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbCompleted.Location = New System.Drawing.Point(1002, 74)
        Me.rdbCompleted.Margin = New System.Windows.Forms.Padding(3, 10, 3, 5)
        Me.rdbCompleted.Name = "rdbCompleted"
        Me.rdbCompleted.Size = New System.Drawing.Size(125, 29)
        Me.rdbCompleted.TabIndex = 5
        Me.rdbCompleted.Text = "Completed"
        Me.rdbCompleted.UseVisualStyleBackColor = True
        '
        'cmbFromAccount
        '
        Me.cmbFromAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFromAccount.FormattingEnabled = True
        Me.cmbFromAccount.Location = New System.Drawing.Point(3, 33)
        Me.cmbFromAccount.Name = "cmbFromAccount"
        Me.cmbFromAccount.Size = New System.Drawing.Size(428, 28)
        Me.cmbFromAccount.TabIndex = 6
        '
        'cmbToAccount
        '
        Me.cmbToAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbToAccount.FormattingEnabled = True
        Me.cmbToAccount.Location = New System.Drawing.Point(437, 33)
        Me.cmbToAccount.Name = "cmbToAccount"
        Me.cmbToAccount.Size = New System.Drawing.Size(429, 28)
        Me.cmbToAccount.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAmount.Location = New System.Drawing.Point(872, 33)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderText = "$0.00"
        Me.txtAmount.Size = New System.Drawing.Size(124, 27)
        Me.txtAmount.TabIndex = 8
        '
        'dtpDate
        '
        Me.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(1002, 33)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(125, 27)
        Me.dtpDate.TabIndex = 9
        '
        'ctlTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ctlTransaction"
        Me.Size = New System.Drawing.Size(1130, 108)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbPlanned As RadioButton
    Friend WithEvents rdbCompleted As RadioButton
    Friend WithEvents cmbFromAccount As ComboBox
    Friend WithEvents cmbToAccount As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpDate As DateTimePicker
End Class
