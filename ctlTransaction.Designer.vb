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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbPlanned = New System.Windows.Forms.RadioButton()
        Me.rdbCompleted = New System.Windows.Forms.RadioButton()
        Me.cmbFromAccount = New System.Windows.Forms.ComboBox()
        Me.cmbToAccount = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbTransactionType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.ColumnCount = 4
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
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
        Me.tlpMain.Controls.Add(Me.cmbTransactionType, 1, 2)
        Me.tlpMain.Controls.Add(Me.Label5, 0, 2)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.MinimumSize = New System.Drawing.Size(1060, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(1063, 92)
        Me.tlpMain.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(930, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(816, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(409, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Account:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From Account:"
        '
        'rdbPlanned
        '
        Me.rdbPlanned.AutoSize = True
        Me.rdbPlanned.Checked = True
        Me.rdbPlanned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbPlanned.Location = New System.Drawing.Point(816, 64)
        Me.rdbPlanned.Margin = New System.Windows.Forms.Padding(3, 8, 3, 4)
        Me.rdbPlanned.Name = "rdbPlanned"
        Me.rdbPlanned.Size = New System.Drawing.Size(108, 24)
        Me.rdbPlanned.TabIndex = 4
        Me.rdbPlanned.TabStop = True
        Me.rdbPlanned.Text = "Planned"
        Me.rdbPlanned.UseVisualStyleBackColor = True
        '
        'rdbCompleted
        '
        Me.rdbCompleted.AutoSize = True
        Me.rdbCompleted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbCompleted.Location = New System.Drawing.Point(930, 64)
        Me.rdbCompleted.Margin = New System.Windows.Forms.Padding(3, 8, 3, 4)
        Me.rdbCompleted.Name = "rdbCompleted"
        Me.rdbCompleted.Size = New System.Drawing.Size(130, 24)
        Me.rdbCompleted.TabIndex = 5
        Me.rdbCompleted.Text = "Completed"
        Me.rdbCompleted.UseVisualStyleBackColor = True
        '
        'cmbFromAccount
        '
        Me.cmbFromAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFromAccount.FormattingEnabled = True
        Me.cmbFromAccount.Location = New System.Drawing.Point(3, 28)
        Me.cmbFromAccount.Name = "cmbFromAccount"
        Me.cmbFromAccount.Size = New System.Drawing.Size(400, 25)
        Me.cmbFromAccount.TabIndex = 6
        '
        'cmbToAccount
        '
        Me.cmbToAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbToAccount.FormattingEnabled = True
        Me.cmbToAccount.Location = New System.Drawing.Point(409, 28)
        Me.cmbToAccount.Name = "cmbToAccount"
        Me.cmbToAccount.Size = New System.Drawing.Size(401, 25)
        Me.cmbToAccount.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAmount.Location = New System.Drawing.Point(816, 28)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderText = "$0.00"
        Me.txtAmount.Size = New System.Drawing.Size(108, 25)
        Me.txtAmount.TabIndex = 8
        '
        'dtpDate
        '
        Me.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(930, 28)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(130, 25)
        Me.dtpDate.TabIndex = 9
        '
        'cmbTransactionType
        '
        Me.cmbTransactionType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTransactionType.FormattingEnabled = True
        Me.cmbTransactionType.Location = New System.Drawing.Point(409, 64)
        Me.cmbTransactionType.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.cmbTransactionType.Name = "cmbTransactionType"
        Me.cmbTransactionType.Size = New System.Drawing.Size(401, 25)
        Me.cmbTransactionType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 32)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Transaction Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctlTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ctlTransaction"
        Me.Size = New System.Drawing.Size(1063, 92)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cmbTransactionType As ComboBox
    Friend WithEvents Label5 As Label
End Class
