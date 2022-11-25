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
        Me.lblDateHeader = New System.Windows.Forms.Label()
        Me.lblAmountHeader = New System.Windows.Forms.Label()
        Me.lblToAccountHeader = New System.Windows.Forms.Label()
        Me.lblFromAccountHeader = New System.Windows.Forms.Label()
        Me.rdbPlanned = New System.Windows.Forms.RadioButton()
        Me.rdbCompleted = New System.Windows.Forms.RadioButton()
        Me.cmbFromAccount = New System.Windows.Forms.ComboBox()
        Me.cmbToAccount = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbTransactionType = New System.Windows.Forms.ComboBox()
        Me.lblTransactionTypeHeader = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 4
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.Controls.Add(Me.lblDateHeader, 3, 0)
        Me.tlpMain.Controls.Add(Me.lblAmountHeader, 2, 0)
        Me.tlpMain.Controls.Add(Me.lblToAccountHeader, 1, 0)
        Me.tlpMain.Controls.Add(Me.lblFromAccountHeader, 0, 0)
        Me.tlpMain.Controls.Add(Me.rdbPlanned, 2, 2)
        Me.tlpMain.Controls.Add(Me.rdbCompleted, 3, 2)
        Me.tlpMain.Controls.Add(Me.cmbFromAccount, 0, 1)
        Me.tlpMain.Controls.Add(Me.cmbToAccount, 1, 1)
        Me.tlpMain.Controls.Add(Me.txtAmount, 2, 1)
        Me.tlpMain.Controls.Add(Me.dtpDate, 3, 1)
        Me.tlpMain.Controls.Add(Me.cmbTransactionType, 1, 2)
        Me.tlpMain.Controls.Add(Me.lblTransactionTypeHeader, 0, 2)
        Me.tlpMain.Location = New System.Drawing.Point(2, 2)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(831, 87)
        Me.tlpMain.TabIndex = 0
        '
        'lblDateHeader
        '
        Me.lblDateHeader.Location = New System.Drawing.Point(704, 2)
        Me.lblDateHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblDateHeader.Name = "lblDateHeader"
        Me.lblDateHeader.Size = New System.Drawing.Size(125, 25)
        Me.lblDateHeader.TabIndex = 3
        Me.lblDateHeader.Text = "Date:"
        Me.lblDateHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmountHeader
        '
        Me.lblAmountHeader.Location = New System.Drawing.Point(610, 2)
        Me.lblAmountHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblAmountHeader.Name = "lblAmountHeader"
        Me.lblAmountHeader.Size = New System.Drawing.Size(90, 25)
        Me.lblAmountHeader.TabIndex = 2
        Me.lblAmountHeader.Text = "Amount:"
        Me.lblAmountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblToAccountHeader
        '
        Me.lblToAccountHeader.Location = New System.Drawing.Point(306, 2)
        Me.lblToAccountHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblToAccountHeader.Name = "lblToAccountHeader"
        Me.lblToAccountHeader.Size = New System.Drawing.Size(300, 25)
        Me.lblToAccountHeader.TabIndex = 1
        Me.lblToAccountHeader.Text = "To Account:"
        Me.lblToAccountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromAccountHeader
        '
        Me.lblFromAccountHeader.Location = New System.Drawing.Point(2, 2)
        Me.lblFromAccountHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblFromAccountHeader.Name = "lblFromAccountHeader"
        Me.lblFromAccountHeader.Size = New System.Drawing.Size(300, 25)
        Me.lblFromAccountHeader.TabIndex = 0
        Me.lblFromAccountHeader.Text = "From Account:"
        Me.lblFromAccountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbPlanned
        '
        Me.rdbPlanned.Checked = True
        Me.rdbPlanned.Location = New System.Drawing.Point(610, 60)
        Me.rdbPlanned.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbPlanned.Name = "rdbPlanned"
        Me.rdbPlanned.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rdbPlanned.Size = New System.Drawing.Size(90, 25)
        Me.rdbPlanned.TabIndex = 4
        Me.rdbPlanned.TabStop = True
        Me.rdbPlanned.Text = "Planned"
        Me.rdbPlanned.UseVisualStyleBackColor = True
        '
        'rdbCompleted
        '
        Me.rdbCompleted.Location = New System.Drawing.Point(704, 60)
        Me.rdbCompleted.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbCompleted.Name = "rdbCompleted"
        Me.rdbCompleted.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.rdbCompleted.Size = New System.Drawing.Size(125, 25)
        Me.rdbCompleted.TabIndex = 5
        Me.rdbCompleted.Text = "Completed"
        Me.rdbCompleted.UseVisualStyleBackColor = True
        '
        'cmbFromAccount
        '
        Me.cmbFromAccount.FormattingEnabled = True
        Me.cmbFromAccount.Location = New System.Drawing.Point(2, 31)
        Me.cmbFromAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFromAccount.Name = "cmbFromAccount"
        Me.cmbFromAccount.Size = New System.Drawing.Size(300, 25)
        Me.cmbFromAccount.TabIndex = 6
        '
        'cmbToAccount
        '
        Me.cmbToAccount.FormattingEnabled = True
        Me.cmbToAccount.Location = New System.Drawing.Point(306, 31)
        Me.cmbToAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbToAccount.Name = "cmbToAccount"
        Me.cmbToAccount.Size = New System.Drawing.Size(300, 25)
        Me.cmbToAccount.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(610, 31)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderText = "$0.00"
        Me.txtAmount.Size = New System.Drawing.Size(90, 25)
        Me.txtAmount.TabIndex = 8
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(704, 31)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(125, 25)
        Me.dtpDate.TabIndex = 9
        '
        'cmbTransactionType
        '
        Me.cmbTransactionType.FormattingEnabled = True
        Me.cmbTransactionType.Location = New System.Drawing.Point(306, 60)
        Me.cmbTransactionType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTransactionType.Name = "cmbTransactionType"
        Me.cmbTransactionType.Size = New System.Drawing.Size(300, 25)
        Me.cmbTransactionType.TabIndex = 10
        '
        'lblTransactionTypeHeader
        '
        Me.lblTransactionTypeHeader.Location = New System.Drawing.Point(2, 60)
        Me.lblTransactionTypeHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblTransactionTypeHeader.Name = "lblTransactionTypeHeader"
        Me.lblTransactionTypeHeader.Size = New System.Drawing.Size(300, 25)
        Me.lblTransactionTypeHeader.TabIndex = 11
        Me.lblTransactionTypeHeader.Text = "Transaction Type"
        Me.lblTransactionTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Size = New System.Drawing.Size(835, 91)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents lblDateHeader As Label
    Friend WithEvents lblAmountHeader As Label
    Friend WithEvents lblToAccountHeader As Label
    Friend WithEvents lblFromAccountHeader As Label
    Friend WithEvents rdbPlanned As RadioButton
    Friend WithEvents rdbCompleted As RadioButton
    Friend WithEvents cmbFromAccount As ComboBox
    Friend WithEvents cmbToAccount As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbTransactionType As ComboBox
    Friend WithEvents lblTransactionTypeHeader As Label
End Class
