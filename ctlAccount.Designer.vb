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
        Me.lblAccountTypeHeader = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.lblAccountNameHeader = New System.Windows.Forms.Label()
        Me.chkVirtualAccount = New System.Windows.Forms.CheckBox()
        Me.lblParentAccountHeader = New System.Windows.Forms.Label()
        Me.cmbAccountType = New System.Windows.Forms.ComboBox()
        Me.cmbParentAccount = New System.Windows.Forms.ComboBox()
        Me.lblCurrentBalanceHeader = New System.Windows.Forms.Label()
        Me.lblProjectedBalanceHeader = New System.Windows.Forms.Label()
        Me.lblProjectedBalanceDateHeader = New System.Windows.Forms.Label()
        Me.lblStartingBalanceHeader = New System.Windows.Forms.Label()
        Me.lblStartingBalanceDateHeader = New System.Windows.Forms.Label()
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
        Me.tlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tlpMain.ColumnCount = 5
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.Controls.Add(Me.lblAccountTypeHeader, 1, 0)
        Me.tlpMain.Controls.Add(Me.txtAccountName, 0, 1)
        Me.tlpMain.Controls.Add(Me.lblAccountNameHeader, 0, 0)
        Me.tlpMain.Controls.Add(Me.chkVirtualAccount, 2, 1)
        Me.tlpMain.Controls.Add(Me.lblParentAccountHeader, 3, 0)
        Me.tlpMain.Controls.Add(Me.cmbAccountType, 1, 1)
        Me.tlpMain.Controls.Add(Me.cmbParentAccount, 3, 1)
        Me.tlpMain.Controls.Add(Me.lblCurrentBalanceHeader, 0, 2)
        Me.tlpMain.Controls.Add(Me.lblProjectedBalanceHeader, 1, 2)
        Me.tlpMain.Controls.Add(Me.lblProjectedBalanceDateHeader, 2, 2)
        Me.tlpMain.Controls.Add(Me.lblStartingBalanceHeader, 3, 2)
        Me.tlpMain.Controls.Add(Me.lblStartingBalanceDateHeader, 4, 2)
        Me.tlpMain.Controls.Add(Me.dtpProjectedBalanceDate, 2, 3)
        Me.tlpMain.Controls.Add(Me.dtpStartingBalanceDate, 4, 3)
        Me.tlpMain.Controls.Add(Me.lblCurrentBalance, 0, 3)
        Me.tlpMain.Controls.Add(Me.txtStartingBalance, 3, 3)
        Me.tlpMain.Controls.Add(Me.lblProjectedBalance, 1, 3)
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(886, 116)
        Me.tlpMain.TabIndex = 0
        '
        'lblAccountTypeHeader
        '
        Me.lblAccountTypeHeader.Location = New System.Drawing.Point(256, 2)
        Me.lblAccountTypeHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblAccountTypeHeader.Name = "lblAccountTypeHeader"
        Me.lblAccountTypeHeader.Size = New System.Drawing.Size(200, 25)
        Me.lblAccountTypeHeader.TabIndex = 2
        Me.lblAccountTypeHeader.Text = "Account Type:"
        Me.lblAccountTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAccountName
        '
        Me.txtAccountName.Location = New System.Drawing.Point(2, 31)
        Me.txtAccountName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.PlaceholderText = "Account Name"
        Me.txtAccountName.Size = New System.Drawing.Size(250, 25)
        Me.txtAccountName.TabIndex = 0
        '
        'lblAccountNameHeader
        '
        Me.lblAccountNameHeader.Location = New System.Drawing.Point(2, 2)
        Me.lblAccountNameHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblAccountNameHeader.Name = "lblAccountNameHeader"
        Me.lblAccountNameHeader.Size = New System.Drawing.Size(250, 25)
        Me.lblAccountNameHeader.TabIndex = 1
        Me.lblAccountNameHeader.Text = "Account Name:"
        Me.lblAccountNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkVirtualAccount
        '
        Me.chkVirtualAccount.Location = New System.Drawing.Point(460, 31)
        Me.chkVirtualAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.chkVirtualAccount.Name = "chkVirtualAccount"
        Me.chkVirtualAccount.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.chkVirtualAccount.Size = New System.Drawing.Size(150, 25)
        Me.chkVirtualAccount.TabIndex = 8
        Me.chkVirtualAccount.Text = "Virtual Account"
        Me.chkVirtualAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkVirtualAccount.UseVisualStyleBackColor = True
        '
        'lblParentAccountHeader
        '
        Me.tlpMain.SetColumnSpan(Me.lblParentAccountHeader, 2)
        Me.lblParentAccountHeader.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblParentAccountHeader.Location = New System.Drawing.Point(614, 2)
        Me.lblParentAccountHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblParentAccountHeader.Name = "lblParentAccountHeader"
        Me.lblParentAccountHeader.Size = New System.Drawing.Size(268, 25)
        Me.lblParentAccountHeader.TabIndex = 9
        Me.lblParentAccountHeader.Text = "Parent Account:"
        Me.lblParentAccountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAccountType
        '
        Me.cmbAccountType.FormattingEnabled = True
        Me.cmbAccountType.Location = New System.Drawing.Point(256, 31)
        Me.cmbAccountType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(200, 25)
        Me.cmbAccountType.TabIndex = 10
        '
        'cmbParentAccount
        '
        Me.tlpMain.SetColumnSpan(Me.cmbParentAccount, 2)
        Me.cmbParentAccount.Enabled = False
        Me.cmbParentAccount.FormattingEnabled = True
        Me.cmbParentAccount.Location = New System.Drawing.Point(614, 31)
        Me.cmbParentAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbParentAccount.Name = "cmbParentAccount"
        Me.cmbParentAccount.Size = New System.Drawing.Size(268, 25)
        Me.cmbParentAccount.TabIndex = 11
        '
        'lblCurrentBalanceHeader
        '
        Me.lblCurrentBalanceHeader.Location = New System.Drawing.Point(2, 60)
        Me.lblCurrentBalanceHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCurrentBalanceHeader.Name = "lblCurrentBalanceHeader"
        Me.lblCurrentBalanceHeader.Size = New System.Drawing.Size(250, 25)
        Me.lblCurrentBalanceHeader.TabIndex = 3
        Me.lblCurrentBalanceHeader.Text = "Current Balance:"
        Me.lblCurrentBalanceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjectedBalanceHeader
        '
        Me.lblProjectedBalanceHeader.Location = New System.Drawing.Point(256, 60)
        Me.lblProjectedBalanceHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblProjectedBalanceHeader.Name = "lblProjectedBalanceHeader"
        Me.lblProjectedBalanceHeader.Size = New System.Drawing.Size(200, 25)
        Me.lblProjectedBalanceHeader.TabIndex = 4
        Me.lblProjectedBalanceHeader.Text = "Projected Balance:"
        Me.lblProjectedBalanceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjectedBalanceDateHeader
        '
        Me.lblProjectedBalanceDateHeader.Location = New System.Drawing.Point(460, 60)
        Me.lblProjectedBalanceDateHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblProjectedBalanceDateHeader.Name = "lblProjectedBalanceDateHeader"
        Me.lblProjectedBalanceDateHeader.Size = New System.Drawing.Size(150, 25)
        Me.lblProjectedBalanceDateHeader.TabIndex = 5
        Me.lblProjectedBalanceDateHeader.Text = "Projected Balance Date:"
        Me.lblProjectedBalanceDateHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartingBalanceHeader
        '
        Me.lblStartingBalanceHeader.Location = New System.Drawing.Point(614, 60)
        Me.lblStartingBalanceHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblStartingBalanceHeader.Name = "lblStartingBalanceHeader"
        Me.lblStartingBalanceHeader.Size = New System.Drawing.Size(120, 25)
        Me.lblStartingBalanceHeader.TabIndex = 6
        Me.lblStartingBalanceHeader.Text = "Starting Balance:"
        Me.lblStartingBalanceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartingBalanceDateHeader
        '
        Me.lblStartingBalanceDateHeader.Location = New System.Drawing.Point(738, 60)
        Me.lblStartingBalanceDateHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.lblStartingBalanceDateHeader.Name = "lblStartingBalanceDateHeader"
        Me.lblStartingBalanceDateHeader.Size = New System.Drawing.Size(146, 25)
        Me.lblStartingBalanceDateHeader.TabIndex = 7
        Me.lblStartingBalanceDateHeader.Text = "Starting Balance Date:"
        Me.lblStartingBalanceDateHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpProjectedBalanceDate
        '
        Me.dtpProjectedBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProjectedBalanceDate.Location = New System.Drawing.Point(460, 89)
        Me.dtpProjectedBalanceDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpProjectedBalanceDate.Name = "dtpProjectedBalanceDate"
        Me.dtpProjectedBalanceDate.Size = New System.Drawing.Size(150, 25)
        Me.dtpProjectedBalanceDate.TabIndex = 13
        '
        'dtpStartingBalanceDate
        '
        Me.dtpStartingBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartingBalanceDate.Location = New System.Drawing.Point(738, 89)
        Me.dtpStartingBalanceDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpStartingBalanceDate.Name = "dtpStartingBalanceDate"
        Me.dtpStartingBalanceDate.Size = New System.Drawing.Size(146, 25)
        Me.dtpStartingBalanceDate.TabIndex = 18
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentBalance.Location = New System.Drawing.Point(2, 89)
        Me.lblCurrentBalance.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(250, 25)
        Me.lblCurrentBalance.TabIndex = 16
        Me.lblCurrentBalance.Text = "$0.00"
        Me.lblCurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStartingBalance
        '
        Me.txtStartingBalance.Location = New System.Drawing.Point(614, 89)
        Me.txtStartingBalance.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStartingBalance.Name = "txtStartingBalance"
        Me.txtStartingBalance.PlaceholderText = "$0.00"
        Me.txtStartingBalance.Size = New System.Drawing.Size(120, 25)
        Me.txtStartingBalance.TabIndex = 12
        '
        'lblProjectedBalance
        '
        Me.lblProjectedBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectedBalance.Location = New System.Drawing.Point(256, 89)
        Me.lblProjectedBalance.Margin = New System.Windows.Forms.Padding(2)
        Me.lblProjectedBalance.Name = "lblProjectedBalance"
        Me.lblProjectedBalance.Size = New System.Drawing.Size(200, 25)
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
        Me.Name = "ctlAccount"
        Me.Size = New System.Drawing.Size(888, 118)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents lblAccountTypeHeader As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents lblAccountNameHeader As Label
    Friend WithEvents txtStartingBalance As TextBox
    Friend WithEvents chkVirtualAccount As CheckBox
    Friend WithEvents cmbAccountType As ComboBox
    Friend WithEvents cmbParentAccount As ComboBox
    Friend WithEvents lblCurrentBalanceHeader As Label
    Friend WithEvents lblProjectedBalanceHeader As Label
    Friend WithEvents lblProjectedBalanceDateHeader As Label
    Friend WithEvents lblStartingBalanceHeader As Label
    Friend WithEvents lblStartingBalanceDateHeader As Label
    Friend WithEvents dtpProjectedBalanceDate As DateTimePicker
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents lblProjectedBalance As Label
    Friend WithEvents dtpStartingBalanceDate As DateTimePicker
    Friend WithEvents lblParentAccountHeader As Label
End Class
