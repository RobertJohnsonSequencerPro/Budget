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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvActualTransactions = New System.Windows.Forms.DataGridView()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvAccountsPlanned = New System.Windows.Forms.DataGridView()
        Me.dgvPlannedTransactions = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEditTransaction = New System.Windows.Forms.Button()
        Me.btnRemoveTransaction = New System.Windows.Forms.Button()
        Me.cmbFilteredTransactions = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRestoreAccountName = New System.Windows.Forms.ComboBox()
        Me.btnRestoreAccount = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rdbCreateTransactionEveryDayCount = New System.Windows.Forms.RadioButton()
        Me.chkRecurring = New System.Windows.Forms.CheckBox()
        Me.rdbCreateTransactionYearly = New System.Windows.Forms.RadioButton()
        Me.rdbPlanned = New System.Windows.Forms.RadioButton()
        Me.rdbActual = New System.Windows.Forms.RadioButton()
        Me.dtpCreateTransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCreateTransactionAmount = New System.Windows.Forms.TextBox()
        Me.cmbCreateTransactionFromAccount = New System.Windows.Forms.ComboBox()
        Me.cmbCreateTransactionToAccount = New System.Windows.Forms.ComboBox()
        Me.cmbCreateTransactionType = New System.Windows.Forms.ComboBox()
        Me.rdbCreateTransactionMonthly = New System.Windows.Forms.RadioButton()
        Me.cmbCreateTransactionRecurrences = New System.Windows.Forms.ComboBox()
        Me.rdbCreateTransactionWeekly = New System.Windows.Forms.RadioButton()
        Me.cmbCreateTransactionDayCount = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCreateTransaction = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbSelectAccount = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpSelectedAccountDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbRemoveAccountName = New System.Windows.Forms.ComboBox()
        Me.btnRemoveAccount = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNewAccountCreate = New System.Windows.Forms.Button()
        Me.dtpNewAccountStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtNewAccountStartingBalance = New System.Windows.Forms.TextBox()
        Me.cmbNewAccountType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewAccountName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbFilterTransactionType = New System.Windows.Forms.ComboBox()
        Me.cmbFilterTransactionFromAccount = New System.Windows.Forms.ComboBox()
        Me.cmbFilterTransactionToAccount = New System.Windows.Forms.ComboBox()
        Me.txtFilterTransactionAmount = New System.Windows.Forms.TextBox()
        Me.dtpFilterTransactionStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFilterTransactionEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnTransactionFilterApply = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvActualTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvAccountsPlanned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPlannedTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(2521, 893)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvActualTransactions)
        Me.TabPage1.Controls.Add(Me.dgvAccounts)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(2513, 865)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Accounts and Transactions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvActualTransactions
        '
        Me.dgvActualTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActualTransactions.Location = New System.Drawing.Point(1106, 3)
        Me.dgvActualTransactions.Name = "dgvActualTransactions"
        Me.dgvActualTransactions.RowTemplate.Height = 25
        Me.dgvActualTransactions.Size = New System.Drawing.Size(1100, 853)
        Me.dgvActualTransactions.TabIndex = 1
        '
        'dgvAccounts
        '
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(3, 3)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.RowTemplate.Height = 25
        Me.dgvAccounts.Size = New System.Drawing.Size(1100, 853)
        Me.dgvAccounts.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvAccountsPlanned)
        Me.TabPage2.Controls.Add(Me.dgvPlannedTransactions)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(2513, 865)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Planning"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvAccountsPlanned
        '
        Me.dgvAccountsPlanned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccountsPlanned.Location = New System.Drawing.Point(3, 3)
        Me.dgvAccountsPlanned.Name = "dgvAccountsPlanned"
        Me.dgvAccountsPlanned.RowTemplate.Height = 25
        Me.dgvAccountsPlanned.Size = New System.Drawing.Size(1245, 853)
        Me.dgvAccountsPlanned.TabIndex = 1
        '
        'dgvPlannedTransactions
        '
        Me.dgvPlannedTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlannedTransactions.Location = New System.Drawing.Point(1251, 3)
        Me.dgvPlannedTransactions.Name = "dgvPlannedTransactions"
        Me.dgvPlannedTransactions.RowTemplate.Height = 25
        Me.dgvPlannedTransactions.Size = New System.Drawing.Size(1049, 853)
        Me.dgvPlannedTransactions.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(2513, 865)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 17
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1530, 365)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.AutoSize = True
        Me.TableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.Controls.Add(Me.btnEditTransaction, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.btnRemoveTransaction, 2, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.cmbFilteredTransactions, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 168)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1517, 44)
        Me.TableLayoutPanel8.TabIndex = 8
        '
        'btnEditTransaction
        '
        Me.btnEditTransaction.Location = New System.Drawing.Point(1308, 18)
        Me.btnEditTransaction.Name = "btnEditTransaction"
        Me.btnEditTransaction.Size = New System.Drawing.Size(100, 23)
        Me.btnEditTransaction.TabIndex = 0
        Me.btnEditTransaction.Text = "Edit"
        Me.btnEditTransaction.UseVisualStyleBackColor = True
        '
        'btnRemoveTransaction
        '
        Me.btnRemoveTransaction.Location = New System.Drawing.Point(1414, 18)
        Me.btnRemoveTransaction.Name = "btnRemoveTransaction"
        Me.btnRemoveTransaction.Size = New System.Drawing.Size(100, 23)
        Me.btnRemoveTransaction.TabIndex = 1
        Me.btnRemoveTransaction.Text = "Remove"
        Me.btnRemoveTransaction.UseVisualStyleBackColor = True
        '
        'cmbFilteredTransactions
        '
        Me.cmbFilteredTransactions.FormattingEnabled = True
        Me.cmbFilteredTransactions.Location = New System.Drawing.Point(3, 18)
        Me.cmbFilteredTransactions.Name = "cmbFilteredTransactions"
        Me.cmbFilteredTransactions.Size = New System.Drawing.Size(1299, 23)
        Me.cmbFilteredTransactions.Sorted = True
        Me.cmbFilteredTransactions.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Matching Transactions"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoSize = True
        Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.cmbRestoreAccountName, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.btnRestoreAccount, 1, 1)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 318)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(312, 44)
        Me.TableLayoutPanel7.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Restore Account"
        '
        'cmbRestoreAccountName
        '
        Me.cmbRestoreAccountName.FormattingEnabled = True
        Me.cmbRestoreAccountName.Location = New System.Drawing.Point(3, 18)
        Me.cmbRestoreAccountName.Name = "cmbRestoreAccountName"
        Me.cmbRestoreAccountName.Size = New System.Drawing.Size(200, 23)
        Me.cmbRestoreAccountName.Sorted = True
        Me.cmbRestoreAccountName.TabIndex = 0
        '
        'btnRestoreAccount
        '
        Me.btnRestoreAccount.Location = New System.Drawing.Point(209, 18)
        Me.btnRestoreAccount.Name = "btnRestoreAccount"
        Me.btnRestoreAccount.Size = New System.Drawing.Size(100, 23)
        Me.btnRestoreAccount.TabIndex = 4
        Me.btnRestoreAccount.Text = "Restore"
        Me.btnRestoreAccount.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 16
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.rdbCreateTransactionEveryDayCount, 12, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.chkRecurring, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rdbCreateTransactionYearly, 11, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rdbPlanned, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rdbActual, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpCreateTransactionDate, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCreateTransactionAmount, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCreateTransactionFromAccount, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCreateTransactionToAccount, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCreateTransactionType, 6, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rdbCreateTransactionMonthly, 10, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCreateTransactionRecurrences, 8, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rdbCreateTransactionWeekly, 9, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCreateTransactionDayCount, 13, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 14, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCreateTransaction, 15, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1524, 44)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'rdbCreateTransactionEveryDayCount
        '
        Me.rdbCreateTransactionEveryDayCount.AutoSize = True
        Me.rdbCreateTransactionEveryDayCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbCreateTransactionEveryDayCount.Enabled = False
        Me.rdbCreateTransactionEveryDayCount.Location = New System.Drawing.Point(1273, 18)
        Me.rdbCreateTransactionEveryDayCount.Name = "rdbCreateTransactionEveryDayCount"
        Me.rdbCreateTransactionEveryDayCount.Size = New System.Drawing.Size(53, 23)
        Me.rdbCreateTransactionEveryDayCount.TabIndex = 5
        Me.rdbCreateTransactionEveryDayCount.Text = "Every"
        Me.rdbCreateTransactionEveryDayCount.UseVisualStyleBackColor = True
        '
        'chkRecurring
        '
        Me.chkRecurring.AutoSize = True
        Me.chkRecurring.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkRecurring.Location = New System.Drawing.Point(932, 18)
        Me.chkRecurring.Name = "chkRecurring"
        Me.chkRecurring.Size = New System.Drawing.Size(77, 23)
        Me.chkRecurring.TabIndex = 6
        Me.chkRecurring.Text = "Recurring"
        Me.chkRecurring.UseVisualStyleBackColor = True
        '
        'rdbCreateTransactionYearly
        '
        Me.rdbCreateTransactionYearly.AutoSize = True
        Me.rdbCreateTransactionYearly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbCreateTransactionYearly.Enabled = False
        Me.rdbCreateTransactionYearly.Location = New System.Drawing.Point(1211, 18)
        Me.rdbCreateTransactionYearly.Name = "rdbCreateTransactionYearly"
        Me.rdbCreateTransactionYearly.Size = New System.Drawing.Size(56, 23)
        Me.rdbCreateTransactionYearly.TabIndex = 5
        Me.rdbCreateTransactionYearly.Text = "Yearly"
        Me.rdbCreateTransactionYearly.UseVisualStyleBackColor = True
        '
        'rdbPlanned
        '
        Me.rdbPlanned.AutoSize = True
        Me.rdbPlanned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbPlanned.Location = New System.Drawing.Point(3, 18)
        Me.rdbPlanned.Name = "rdbPlanned"
        Me.rdbPlanned.Size = New System.Drawing.Size(68, 23)
        Me.rdbPlanned.TabIndex = 5
        Me.rdbPlanned.Text = "Planned"
        Me.rdbPlanned.UseVisualStyleBackColor = True
        '
        'rdbActual
        '
        Me.rdbActual.AutoSize = True
        Me.rdbActual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbActual.Location = New System.Drawing.Point(77, 18)
        Me.rdbActual.Name = "rdbActual"
        Me.rdbActual.Size = New System.Drawing.Size(59, 23)
        Me.rdbActual.TabIndex = 5
        Me.rdbActual.Text = "Actual"
        Me.rdbActual.UseVisualStyleBackColor = True
        '
        'dtpCreateTransactionDate
        '
        Me.dtpCreateTransactionDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpCreateTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCreateTransactionDate.Location = New System.Drawing.Point(142, 18)
        Me.dtpCreateTransactionDate.Name = "dtpCreateTransactionDate"
        Me.dtpCreateTransactionDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpCreateTransactionDate.TabIndex = 2
        '
        'txtCreateTransactionAmount
        '
        Me.txtCreateTransactionAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCreateTransactionAmount.Location = New System.Drawing.Point(248, 18)
        Me.txtCreateTransactionAmount.Name = "txtCreateTransactionAmount"
        Me.txtCreateTransactionAmount.PlaceholderText = "Amount"
        Me.txtCreateTransactionAmount.Size = New System.Drawing.Size(100, 23)
        Me.txtCreateTransactionAmount.TabIndex = 3
        '
        'cmbCreateTransactionFromAccount
        '
        Me.cmbCreateTransactionFromAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCreateTransactionFromAccount.FormattingEnabled = True
        Me.cmbCreateTransactionFromAccount.Location = New System.Drawing.Point(354, 18)
        Me.cmbCreateTransactionFromAccount.Name = "cmbCreateTransactionFromAccount"
        Me.cmbCreateTransactionFromAccount.Size = New System.Drawing.Size(200, 23)
        Me.cmbCreateTransactionFromAccount.Sorted = True
        Me.cmbCreateTransactionFromAccount.TabIndex = 0
        '
        'cmbCreateTransactionToAccount
        '
        Me.cmbCreateTransactionToAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCreateTransactionToAccount.FormattingEnabled = True
        Me.cmbCreateTransactionToAccount.Location = New System.Drawing.Point(560, 18)
        Me.cmbCreateTransactionToAccount.Name = "cmbCreateTransactionToAccount"
        Me.cmbCreateTransactionToAccount.Size = New System.Drawing.Size(200, 23)
        Me.cmbCreateTransactionToAccount.Sorted = True
        Me.cmbCreateTransactionToAccount.TabIndex = 0
        '
        'cmbCreateTransactionType
        '
        Me.cmbCreateTransactionType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCreateTransactionType.FormattingEnabled = True
        Me.cmbCreateTransactionType.Location = New System.Drawing.Point(766, 18)
        Me.cmbCreateTransactionType.Name = "cmbCreateTransactionType"
        Me.cmbCreateTransactionType.Size = New System.Drawing.Size(160, 23)
        Me.cmbCreateTransactionType.TabIndex = 0
        '
        'rdbCreateTransactionMonthly
        '
        Me.rdbCreateTransactionMonthly.AutoSize = True
        Me.rdbCreateTransactionMonthly.Checked = True
        Me.rdbCreateTransactionMonthly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbCreateTransactionMonthly.Enabled = False
        Me.rdbCreateTransactionMonthly.Location = New System.Drawing.Point(1135, 18)
        Me.rdbCreateTransactionMonthly.Name = "rdbCreateTransactionMonthly"
        Me.rdbCreateTransactionMonthly.Size = New System.Drawing.Size(70, 23)
        Me.rdbCreateTransactionMonthly.TabIndex = 5
        Me.rdbCreateTransactionMonthly.TabStop = True
        Me.rdbCreateTransactionMonthly.Text = "Monthly"
        Me.rdbCreateTransactionMonthly.UseVisualStyleBackColor = True
        '
        'cmbCreateTransactionRecurrences
        '
        Me.cmbCreateTransactionRecurrences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCreateTransactionRecurrences.Enabled = False
        Me.cmbCreateTransactionRecurrences.FormattingEnabled = True
        Me.cmbCreateTransactionRecurrences.Items.AddRange(New Object() {"1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30"})
        Me.cmbCreateTransactionRecurrences.Location = New System.Drawing.Point(1015, 18)
        Me.cmbCreateTransactionRecurrences.Name = "cmbCreateTransactionRecurrences"
        Me.cmbCreateTransactionRecurrences.Size = New System.Drawing.Size(45, 23)
        Me.cmbCreateTransactionRecurrences.TabIndex = 0
        '
        'rdbCreateTransactionWeekly
        '
        Me.rdbCreateTransactionWeekly.AutoSize = True
        Me.rdbCreateTransactionWeekly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdbCreateTransactionWeekly.Enabled = False
        Me.rdbCreateTransactionWeekly.Location = New System.Drawing.Point(1066, 18)
        Me.rdbCreateTransactionWeekly.Name = "rdbCreateTransactionWeekly"
        Me.rdbCreateTransactionWeekly.Size = New System.Drawing.Size(63, 23)
        Me.rdbCreateTransactionWeekly.TabIndex = 5
        Me.rdbCreateTransactionWeekly.Text = "Weekly"
        Me.rdbCreateTransactionWeekly.UseVisualStyleBackColor = True
        '
        'cmbCreateTransactionDayCount
        '
        Me.cmbCreateTransactionDayCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCreateTransactionDayCount.Enabled = False
        Me.cmbCreateTransactionDayCount.FormattingEnabled = True
        Me.cmbCreateTransactionDayCount.Items.AddRange(New Object() {"1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30"})
        Me.cmbCreateTransactionDayCount.Location = New System.Drawing.Point(1332, 18)
        Me.cmbCreateTransactionDayCount.Name = "cmbCreateTransactionDayCount"
        Me.cmbCreateTransactionDayCount.Size = New System.Drawing.Size(45, 23)
        Me.cmbCreateTransactionDayCount.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "From Account"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(560, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "To Account"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(766, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Transaction Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Create A Transaction"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(1383, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 29)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Days"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label11, 2)
        Me.Label11.Location = New System.Drawing.Point(1015, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Occurrences"
        '
        'btnCreateTransaction
        '
        Me.btnCreateTransaction.Enabled = False
        Me.btnCreateTransaction.Location = New System.Drawing.Point(1421, 18)
        Me.btnCreateTransaction.Name = "btnCreateTransaction"
        Me.btnCreateTransaction.Size = New System.Drawing.Size(100, 23)
        Me.btnCreateTransaction.TabIndex = 9
        Me.btnCreateTransaction.Text = "Create"
        Me.btnCreateTransaction.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.Label23, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbSelectAccount, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label20, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.dtpSelectedAccountDate, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 1, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1524, 44)
        Me.TableLayoutPanel5.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 15)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Account Name"
        '
        'cmbSelectAccount
        '
        Me.cmbSelectAccount.FormattingEnabled = True
        Me.cmbSelectAccount.Location = New System.Drawing.Point(3, 18)
        Me.cmbSelectAccount.Name = "cmbSelectAccount"
        Me.cmbSelectAccount.Size = New System.Drawing.Size(200, 23)
        Me.cmbSelectAccount.Sorted = True
        Me.cmbSelectAccount.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Balance"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(263, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 15)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "As Of"
        '
        'dtpSelectedAccountDate
        '
        Me.dtpSelectedAccountDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dtpSelectedAccountDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSelectedAccountDate.Location = New System.Drawing.Point(263, 18)
        Me.dtpSelectedAccountDate.Name = "dtpSelectedAccountDate"
        Me.dtpSelectedAccountDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpSelectedAccountDate.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(209, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 29)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "$100.99"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cmbRemoveAccountName, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.btnRemoveAccount, 1, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 268)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(312, 44)
        Me.TableLayoutPanel6.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Remove Account"
        '
        'cmbRemoveAccountName
        '
        Me.cmbRemoveAccountName.FormattingEnabled = True
        Me.cmbRemoveAccountName.Location = New System.Drawing.Point(3, 18)
        Me.cmbRemoveAccountName.Name = "cmbRemoveAccountName"
        Me.cmbRemoveAccountName.Size = New System.Drawing.Size(200, 23)
        Me.cmbRemoveAccountName.Sorted = True
        Me.cmbRemoveAccountName.TabIndex = 0
        '
        'btnRemoveAccount
        '
        Me.btnRemoveAccount.Location = New System.Drawing.Point(209, 18)
        Me.btnRemoveAccount.Name = "btnRemoveAccount"
        Me.btnRemoveAccount.Size = New System.Drawing.Size(100, 23)
        Me.btnRemoveAccount.TabIndex = 4
        Me.btnRemoveAccount.Text = "Remove"
        Me.btnRemoveAccount.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.btnNewAccountCreate, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.dtpNewAccountStartDate, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtNewAccountStartingBalance, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cmbNewAccountType, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtNewAccountName, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 218)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1524, 44)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'btnNewAccountCreate
        '
        Me.btnNewAccountCreate.Location = New System.Drawing.Point(653, 18)
        Me.btnNewAccountCreate.Name = "btnNewAccountCreate"
        Me.btnNewAccountCreate.Size = New System.Drawing.Size(100, 23)
        Me.btnNewAccountCreate.TabIndex = 4
        Me.btnNewAccountCreate.Text = "Create"
        Me.btnNewAccountCreate.UseVisualStyleBackColor = True
        '
        'dtpNewAccountStartDate
        '
        Me.dtpNewAccountStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNewAccountStartDate.Location = New System.Drawing.Point(547, 18)
        Me.dtpNewAccountStartDate.Name = "dtpNewAccountStartDate"
        Me.dtpNewAccountStartDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpNewAccountStartDate.TabIndex = 2
        '
        'txtNewAccountStartingBalance
        '
        Me.txtNewAccountStartingBalance.Location = New System.Drawing.Point(441, 18)
        Me.txtNewAccountStartingBalance.Name = "txtNewAccountStartingBalance"
        Me.txtNewAccountStartingBalance.PlaceholderText = "Starting Balance"
        Me.txtNewAccountStartingBalance.Size = New System.Drawing.Size(100, 23)
        Me.txtNewAccountStartingBalance.TabIndex = 3
        '
        'cmbNewAccountType
        '
        Me.cmbNewAccountType.FormattingEnabled = True
        Me.cmbNewAccountType.Location = New System.Drawing.Point(209, 18)
        Me.cmbNewAccountType.Name = "cmbNewAccountType"
        Me.cmbNewAccountType.Size = New System.Drawing.Size(226, 23)
        Me.cmbNewAccountType.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Create A New Account"
        '
        'txtNewAccountName
        '
        Me.txtNewAccountName.Location = New System.Drawing.Point(3, 18)
        Me.txtNewAccountName.Name = "txtNewAccountName"
        Me.txtNewAccountName.PlaceholderText = "Account Name"
        Me.txtNewAccountName.Size = New System.Drawing.Size(200, 23)
        Me.txtNewAccountName.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(209, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Account Type"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 606.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cmbFilterTransactionType, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbFilterTransactionFromAccount, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbFilterTransactionToAccount, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtFilterTransactionAmount, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpFilterTransactionStartDate, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpFilterTransactionEndDate, 5, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTransactionFilterApply, 6, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 118)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1524, 44)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'cmbFilterTransactionType
        '
        Me.cmbFilterTransactionType.FormattingEnabled = True
        Me.cmbFilterTransactionType.Location = New System.Drawing.Point(3, 18)
        Me.cmbFilterTransactionType.Name = "cmbFilterTransactionType"
        Me.cmbFilterTransactionType.Size = New System.Drawing.Size(160, 23)
        Me.cmbFilterTransactionType.TabIndex = 0
        '
        'cmbFilterTransactionFromAccount
        '
        Me.cmbFilterTransactionFromAccount.FormattingEnabled = True
        Me.cmbFilterTransactionFromAccount.Location = New System.Drawing.Point(169, 18)
        Me.cmbFilterTransactionFromAccount.Name = "cmbFilterTransactionFromAccount"
        Me.cmbFilterTransactionFromAccount.Size = New System.Drawing.Size(211, 23)
        Me.cmbFilterTransactionFromAccount.Sorted = True
        Me.cmbFilterTransactionFromAccount.TabIndex = 0
        '
        'cmbFilterTransactionToAccount
        '
        Me.cmbFilterTransactionToAccount.FormattingEnabled = True
        Me.cmbFilterTransactionToAccount.Location = New System.Drawing.Point(386, 18)
        Me.cmbFilterTransactionToAccount.Name = "cmbFilterTransactionToAccount"
        Me.cmbFilterTransactionToAccount.Size = New System.Drawing.Size(211, 23)
        Me.cmbFilterTransactionToAccount.Sorted = True
        Me.cmbFilterTransactionToAccount.TabIndex = 0
        '
        'txtFilterTransactionAmount
        '
        Me.txtFilterTransactionAmount.Location = New System.Drawing.Point(603, 18)
        Me.txtFilterTransactionAmount.Name = "txtFilterTransactionAmount"
        Me.txtFilterTransactionAmount.PlaceholderText = "Amount"
        Me.txtFilterTransactionAmount.Size = New System.Drawing.Size(100, 23)
        Me.txtFilterTransactionAmount.TabIndex = 3
        '
        'dtpFilterTransactionStartDate
        '
        Me.dtpFilterTransactionStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFilterTransactionStartDate.Location = New System.Drawing.Point(709, 18)
        Me.dtpFilterTransactionStartDate.Name = "dtpFilterTransactionStartDate"
        Me.dtpFilterTransactionStartDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpFilterTransactionStartDate.TabIndex = 2
        '
        'dtpFilterTransactionEndDate
        '
        Me.dtpFilterTransactionEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFilterTransactionEndDate.Location = New System.Drawing.Point(815, 18)
        Me.dtpFilterTransactionEndDate.Name = "dtpFilterTransactionEndDate"
        Me.dtpFilterTransactionEndDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpFilterTransactionEndDate.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Transaction Type"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(169, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 15)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "From Account"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(386, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 15)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "To Account"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label18, 2)
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(709, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(206, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Date Range"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTransactionFilterApply
        '
        Me.btnTransactionFilterApply.Location = New System.Drawing.Point(921, 18)
        Me.btnTransactionFilterApply.Name = "btnTransactionFilterApply"
        Me.btnTransactionFilterApply.Size = New System.Drawing.Size(100, 23)
        Me.btnTransactionFilterApply.TabIndex = 4
        Me.btnTransactionFilterApply.Text = "Filter"
        Me.btnTransactionFilterApply.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(185, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "View Transactions - Choose Filters"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(16, 12)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(168, 42)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2565, 991)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Spending Planner"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvActualTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvAccountsPlanned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPlannedTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents dgvPlannedTransactions As DataGridView
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dgvAccountsPlanned As DataGridView
    Friend WithEvents dgvActualTransactions As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtNewAccountStartingBalance As TextBox
    Friend WithEvents txtNewAccountName As TextBox
    Friend WithEvents dtpNewAccountStartDate As DateTimePicker
    Friend WithEvents dtpSelectedAccountDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbNewAccountType As ComboBox
    Friend WithEvents cmbSelectAccount As ComboBox
    Friend WithEvents btnRestoreAccount As Button
    Friend WithEvents btnRemoveAccount As Button
    Friend WithEvents btnNewAccountCreate As Button
    Friend WithEvents txtCreateTransactionAmount As TextBox
    Friend WithEvents dtpCreateTransactionDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbRestoreAccountName As ComboBox
    Friend WithEvents cmbRemoveAccountName As ComboBox
    Friend WithEvents cmbCreateTransactionType As ComboBox
    Friend WithEvents cmbCreateTransactionToAccount As ComboBox
    Friend WithEvents cmbCreateTransactionFromAccount As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents rdbCreateTransactionEveryDayCount As RadioButton
    Friend WithEvents chkRecurring As CheckBox
    Friend WithEvents rdbCreateTransactionYearly As RadioButton
    Friend WithEvents txtFilterTransactionAmount As TextBox
    Friend WithEvents rdbCreateTransactionMonthly As RadioButton
    Friend WithEvents rdbActual As RadioButton
    Friend WithEvents rdbCreateTransactionWeekly As RadioButton
    Friend WithEvents dtpFilterTransactionEndDate As DateTimePicker
    Friend WithEvents dtpFilterTransactionStartDate As DateTimePicker
    Friend WithEvents rdbPlanned As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbFilterTransactionToAccount As ComboBox
    Friend WithEvents cmbFilterTransactionFromAccount As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbCreateTransactionRecurrences As ComboBox
    Friend WithEvents cmbCreateTransactionDayCount As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbFilterTransactionType As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents btnEditTransaction As Button
    Friend WithEvents btnRemoveTransaction As Button
    Friend WithEvents cmbFilteredTransactions As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCreateTransaction As Button
    Friend WithEvents btnTransactionFilterApply As Button
    Friend WithEvents Label13 As Label
End Class
