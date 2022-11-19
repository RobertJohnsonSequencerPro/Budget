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
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flpAccounts = New System.Windows.Forms.FlowLayoutPanel()
        Me.CtlAccount1 = New Budget.ctlAccount()
        Me.flpTransactions = New System.Windows.Forms.FlowLayoutPanel()
        Me.CtlTransaction1 = New Budget.ctlTransaction()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.btnAddTransaction = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkShowIncomeAccounts = New System.Windows.Forms.CheckBox()
        Me.chkShowCashAccounts = New System.Windows.Forms.CheckBox()
        Me.chkShowSavingsAccounts = New System.Windows.Forms.CheckBox()
        Me.chkShowDebtAccounts = New System.Windows.Forms.CheckBox()
        Me.chkShowExpenseAccounts = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.tabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.flpAccounts.SuspendLayout()
        Me.flpTransactions.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.TabPage1)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(3, 43)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(2218, 945)
        Me.tabMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tlpMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(2210, 917)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Accounts and Transactions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.Label2, 1, 0)
        Me.tlpMain.Controls.Add(Me.flpAccounts, 0, 2)
        Me.tlpMain.Controls.Add(Me.flpTransactions, 1, 2)
        Me.tlpMain.Controls.Add(Me.Label1, 0, 0)
        Me.tlpMain.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.tlpMain.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tlpMain.Location = New System.Drawing.Point(3, 3)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(2204, 911)
        Me.tlpMain.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1105, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1096, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transactions"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpAccounts
        '
        Me.flpAccounts.AutoScroll = True
        Me.flpAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.flpAccounts.Controls.Add(Me.CtlAccount1)
        Me.flpAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpAccounts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAccounts.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.flpAccounts.Location = New System.Drawing.Point(3, 63)
        Me.flpAccounts.Name = "flpAccounts"
        Me.flpAccounts.Size = New System.Drawing.Size(1096, 845)
        Me.flpAccounts.TabIndex = 0
        Me.flpAccounts.WrapContents = False
        '
        'CtlAccount1
        '
        Me.CtlAccount1.AutoSize = True
        Me.CtlAccount1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlAccount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CtlAccount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtlAccount1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlAccount1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CtlAccount1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CtlAccount1.Location = New System.Drawing.Point(3, 3)
        Me.CtlAccount1.MinimumSize = New System.Drawing.Size(1060, 2)
        Me.CtlAccount1.Name = "CtlAccount1"
        Me.CtlAccount1.Size = New System.Drawing.Size(1062, 133)
        Me.CtlAccount1.TabIndex = 0
        '
        'flpTransactions
        '
        Me.flpTransactions.AutoScroll = True
        Me.flpTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.flpTransactions.Controls.Add(Me.CtlTransaction1)
        Me.flpTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpTransactions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpTransactions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.flpTransactions.Location = New System.Drawing.Point(1105, 63)
        Me.flpTransactions.Name = "flpTransactions"
        Me.flpTransactions.Size = New System.Drawing.Size(1096, 845)
        Me.flpTransactions.TabIndex = 1
        Me.flpTransactions.WrapContents = False
        '
        'CtlTransaction1
        '
        Me.CtlTransaction1.AutoSize = True
        Me.CtlTransaction1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlTransaction1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CtlTransaction1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtlTransaction1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CtlTransaction1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CtlTransaction1.Location = New System.Drawing.Point(4, 3)
        Me.CtlTransaction1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CtlTransaction1.Name = "CtlTransaction1"
        Me.CtlTransaction1.Size = New System.Drawing.Size(1062, 94)
        Me.CtlTransaction1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1096, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(3, 3)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(168, 29)
        Me.btnSaveChanges.TabIndex = 1
        Me.btnSaveChanges.Text = "Save / Recalculate"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "GUID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "guid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tabMain, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2224, 991)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSaveChanges)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddAccount)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddTransaction)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(2218, 34)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(177, 3)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(168, 29)
        Me.btnAddAccount.TabIndex = 2
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'btnAddTransaction
        '
        Me.btnAddTransaction.Location = New System.Drawing.Point(351, 3)
        Me.btnAddTransaction.Name = "btnAddTransaction"
        Me.btnAddTransaction.Size = New System.Drawing.Size(168, 29)
        Me.btnAddTransaction.TabIndex = 3
        Me.btnAddTransaction.Text = "Add Transaction"
        Me.btnAddTransaction.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.chkShowIncomeAccounts, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkShowCashAccounts, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkShowSavingsAccounts, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkShowDebtAccounts, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkShowExpenseAccounts, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1096, 29)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'chkShowIncomeAccounts
        '
        Me.chkShowIncomeAccounts.AutoSize = True
        Me.chkShowIncomeAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chkShowIncomeAccounts.Checked = True
        Me.chkShowIncomeAccounts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowIncomeAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkShowIncomeAccounts.Location = New System.Drawing.Point(3, 3)
        Me.chkShowIncomeAccounts.Name = "chkShowIncomeAccounts"
        Me.chkShowIncomeAccounts.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.chkShowIncomeAccounts.Size = New System.Drawing.Size(76, 23)
        Me.chkShowIncomeAccounts.TabIndex = 0
        Me.chkShowIncomeAccounts.Text = "Income"
        Me.chkShowIncomeAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowIncomeAccounts.UseVisualStyleBackColor = False
        '
        'chkShowCashAccounts
        '
        Me.chkShowCashAccounts.AutoSize = True
        Me.chkShowCashAccounts.Checked = True
        Me.chkShowCashAccounts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowCashAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkShowCashAccounts.Location = New System.Drawing.Point(85, 3)
        Me.chkShowCashAccounts.Name = "chkShowCashAccounts"
        Me.chkShowCashAccounts.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.chkShowCashAccounts.Size = New System.Drawing.Size(62, 23)
        Me.chkShowCashAccounts.TabIndex = 1
        Me.chkShowCashAccounts.Text = "Cash"
        Me.chkShowCashAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowCashAccounts.UseVisualStyleBackColor = True
        '
        'chkShowSavingsAccounts
        '
        Me.chkShowSavingsAccounts.AutoSize = True
        Me.chkShowSavingsAccounts.Checked = True
        Me.chkShowSavingsAccounts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowSavingsAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkShowSavingsAccounts.Location = New System.Drawing.Point(153, 3)
        Me.chkShowSavingsAccounts.Name = "chkShowSavingsAccounts"
        Me.chkShowSavingsAccounts.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.chkShowSavingsAccounts.Size = New System.Drawing.Size(76, 23)
        Me.chkShowSavingsAccounts.TabIndex = 2
        Me.chkShowSavingsAccounts.Text = "Savings"
        Me.chkShowSavingsAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowSavingsAccounts.UseVisualStyleBackColor = True
        '
        'chkShowDebtAccounts
        '
        Me.chkShowDebtAccounts.AutoSize = True
        Me.chkShowDebtAccounts.Checked = True
        Me.chkShowDebtAccounts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowDebtAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkShowDebtAccounts.Location = New System.Drawing.Point(235, 3)
        Me.chkShowDebtAccounts.Name = "chkShowDebtAccounts"
        Me.chkShowDebtAccounts.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.chkShowDebtAccounts.Size = New System.Drawing.Size(61, 23)
        Me.chkShowDebtAccounts.TabIndex = 3
        Me.chkShowDebtAccounts.Text = "Debt"
        Me.chkShowDebtAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowDebtAccounts.UseVisualStyleBackColor = True
        '
        'chkShowExpenseAccounts
        '
        Me.chkShowExpenseAccounts.AutoSize = True
        Me.chkShowExpenseAccounts.Checked = True
        Me.chkShowExpenseAccounts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowExpenseAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkShowExpenseAccounts.Location = New System.Drawing.Point(302, 3)
        Me.chkShowExpenseAccounts.Name = "chkShowExpenseAccounts"
        Me.chkShowExpenseAccounts.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.chkShowExpenseAccounts.Size = New System.Drawing.Size(79, 23)
        Me.chkShowExpenseAccounts.TabIndex = 4
        Me.chkShowExpenseAccounts.Text = "Expense"
        Me.chkShowExpenseAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowExpenseAccounts.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DateTimePicker1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DateTimePicker2, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1105, 28)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1096, 29)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Location = New System.Drawing.Point(44, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(250, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "To"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Location = New System.Drawing.Point(275, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(2224, 991)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Spending Planner"
        Me.tabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.flpAccounts.ResumeLayout(False)
        Me.flpAccounts.PerformLayout()
        Me.flpTransactions.ResumeLayout(False)
        Me.flpTransactions.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents flpAccounts As FlowLayoutPanel
    Friend WithEvents flpTransactions As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CtlAccount1 As ctlAccount
    Friend WithEvents CtlTransaction1 As ctlTransaction
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents btnAddTransaction As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents chkShowIncomeAccounts As CheckBox
    Friend WithEvents chkShowCashAccounts As CheckBox
    Friend WithEvents chkShowSavingsAccounts As CheckBox
    Friend WithEvents chkShowDebtAccounts As CheckBox
    Friend WithEvents chkShowExpenseAccounts As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
