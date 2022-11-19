<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAccount
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkVirtualAccount = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAccountType = New System.Windows.Forms.ComboBox()
        Me.cmbParentAccount = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpProjectedBalanceDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartingBalanceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.txtStartingBalance = New System.Windows.Forms.TextBox()
        Me.lblProjectedBalance = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 5
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.04979!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9502!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.tlpMain.Controls.Add(Me.Label2, 1, 0)
        Me.tlpMain.Controls.Add(Me.txtAccountName, 0, 1)
        Me.tlpMain.Controls.Add(Me.Label1, 0, 0)
        Me.tlpMain.Controls.Add(Me.chkVirtualAccount, 2, 1)
        Me.tlpMain.Controls.Add(Me.Label8, 3, 0)
        Me.tlpMain.Controls.Add(Me.cmbAccountType, 1, 1)
        Me.tlpMain.Controls.Add(Me.cmbParentAccount, 3, 1)
        Me.tlpMain.Controls.Add(Me.Label3, 0, 2)
        Me.tlpMain.Controls.Add(Me.Label4, 1, 2)
        Me.tlpMain.Controls.Add(Me.Label5, 2, 2)
        Me.tlpMain.Controls.Add(Me.Label6, 3, 2)
        Me.tlpMain.Controls.Add(Me.Label7, 4, 2)
        Me.tlpMain.Controls.Add(Me.dtpProjectedBalanceDate, 2, 3)
        Me.tlpMain.Controls.Add(Me.dtpStartingBalanceDate, 4, 3)
        Me.tlpMain.Controls.Add(Me.lblCurrentBalance, 0, 3)
        Me.tlpMain.Controls.Add(Me.txtStartingBalance, 3, 3)
        Me.tlpMain.Controls.Add(Me.lblProjectedBalance, 1, 3)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(1061, 131)
        Me.tlpMain.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(364, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 13, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account Type:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtAccountName
        '
        Me.txtAccountName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAccountName.Location = New System.Drawing.Point(3, 33)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.PlaceholderText = "Account Name"
        Me.txtAccountName.Size = New System.Drawing.Size(355, 25)
        Me.txtAccountName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 13, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'chkVirtualAccount
        '
        Me.chkVirtualAccount.AutoSize = True
        Me.chkVirtualAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkVirtualAccount.Location = New System.Drawing.Point(597, 33)
        Me.chkVirtualAccount.Margin = New System.Windows.Forms.Padding(24, 3, 13, 3)
        Me.chkVirtualAccount.Name = "chkVirtualAccount"
        Me.chkVirtualAccount.Size = New System.Drawing.Size(121, 25)
        Me.chkVirtualAccount.TabIndex = 8
        Me.chkVirtualAccount.Text = "Virtual Account"
        Me.chkVirtualAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkVirtualAccount.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.tlpMain.SetColumnSpan(Me.Label8, 2)
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(734, 13)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 13, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(324, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Parent Account:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbAccountType
        '
        Me.cmbAccountType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAccountType.FormattingEnabled = True
        Me.cmbAccountType.Location = New System.Drawing.Point(364, 33)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(206, 25)
        Me.cmbAccountType.TabIndex = 10
        '
        'cmbParentAccount
        '
        Me.tlpMain.SetColumnSpan(Me.cmbParentAccount, 2)
        Me.cmbParentAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParentAccount.Enabled = False
        Me.cmbParentAccount.FormattingEnabled = True
        Me.cmbParentAccount.Location = New System.Drawing.Point(734, 33)
        Me.cmbParentAccount.Name = "cmbParentAccount"
        Me.cmbParentAccount.Size = New System.Drawing.Size(324, 25)
        Me.cmbParentAccount.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 21, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Current Balance:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(364, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 21, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Projected Balance:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(576, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 21, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Projected Balance Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(734, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 21, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Starting Balance:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(892, 82)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 21, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Starting Balance Date:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'dtpProjectedBalanceDate
        '
        Me.dtpProjectedBalanceDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpProjectedBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProjectedBalanceDate.Location = New System.Drawing.Point(576, 102)
        Me.dtpProjectedBalanceDate.Margin = New System.Windows.Forms.Padding(3, 3, 3, 4)
        Me.dtpProjectedBalanceDate.Name = "dtpProjectedBalanceDate"
        Me.dtpProjectedBalanceDate.Size = New System.Drawing.Size(152, 25)
        Me.dtpProjectedBalanceDate.TabIndex = 13
        '
        'dtpStartingBalanceDate
        '
        Me.dtpStartingBalanceDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpStartingBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartingBalanceDate.Location = New System.Drawing.Point(892, 102)
        Me.dtpStartingBalanceDate.Margin = New System.Windows.Forms.Padding(3, 3, 3, 4)
        Me.dtpStartingBalanceDate.Name = "dtpStartingBalanceDate"
        Me.dtpStartingBalanceDate.Size = New System.Drawing.Size(166, 25)
        Me.dtpStartingBalanceDate.TabIndex = 18
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.AutoSize = True
        Me.lblCurrentBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrentBalance.Location = New System.Drawing.Point(3, 99)
        Me.lblCurrentBalance.Margin = New System.Windows.Forms.Padding(3, 0, 3, 4)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(355, 28)
        Me.lblCurrentBalance.TabIndex = 16
        Me.lblCurrentBalance.Text = "$0.00"
        Me.lblCurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStartingBalance
        '
        Me.txtStartingBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStartingBalance.Location = New System.Drawing.Point(734, 102)
        Me.txtStartingBalance.Margin = New System.Windows.Forms.Padding(3, 3, 3, 4)
        Me.txtStartingBalance.Name = "txtStartingBalance"
        Me.txtStartingBalance.PlaceholderText = "$0.00"
        Me.txtStartingBalance.Size = New System.Drawing.Size(152, 25)
        Me.txtStartingBalance.TabIndex = 12
        '
        'lblProjectedBalance
        '
        Me.lblProjectedBalance.AutoSize = True
        Me.lblProjectedBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectedBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProjectedBalance.Location = New System.Drawing.Point(364, 99)
        Me.lblProjectedBalance.Margin = New System.Windows.Forms.Padding(3, 0, 3, 4)
        Me.lblProjectedBalance.Name = "lblProjectedBalance"
        Me.lblProjectedBalance.Size = New System.Drawing.Size(206, 28)
        Me.lblProjectedBalance.TabIndex = 17
        Me.lblProjectedBalance.Text = "$0.00"
        Me.lblProjectedBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctlAccount
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
        Me.MinimumSize = New System.Drawing.Size(1060, 2)
        Me.Name = "ctlAccount"
        Me.Size = New System.Drawing.Size(1061, 131)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStartingBalance As TextBox
    Friend WithEvents chkVirtualAccount As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbAccountType As ComboBox
    Friend WithEvents cmbParentAccount As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpProjectedBalanceDate As DateTimePicker
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents lblProjectedBalance As Label
    Friend WithEvents dtpStartingBalanceDate As DateTimePicker
End Class
