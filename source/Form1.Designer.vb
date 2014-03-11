Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.UrlTextBox = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.PageText = New System.Windows.Forms.TextBox
        Me.ListPatternsTab = New System.Windows.Forms.TabPage
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.TextPatternsGrid = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.NoiceLevelControl = New System.Windows.Forms.NumericUpDown
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.TotalWordsLabel = New System.Windows.Forms.Label
        Me.CalcWordGroupCheckBox = New System.Windows.Forms.CheckBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StatusStripPanel1 = New System.Windows.Forms.StatusStripPanel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ListPatternsTab.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.TextPatternsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.NoiceLevelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UrlTextBox)
        '
        'Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(567, 440)
        Me.SplitContainer1.SplitterDistance = 43
        Me.SplitContainer1.TabIndex = 3
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Go"
        '
        'UrlTextBox
        '
        Me.UrlTextBox.AutoSize = False
        Me.UrlTextBox.Location = New System.Drawing.Point(13, 13)
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.Size = New System.Drawing.Size(444, 21)
        Me.UrlTextBox.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        '
        'Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(567, 393)
        Me.SplitContainer2.SplitterDistance = 330
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.Text = "SplitContainer2"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.ListPatternsTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(330, 393)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(322, 367)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Browser View"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(316, 361)
        Me.WebBrowser1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TitleTextBox)
        Me.TabPage2.Controls.Add(Me.PageText)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(322, 367)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Text View"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleTextBox.Location = New System.Drawing.Point(3, 3)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(316, 18)
        Me.TitleTextBox.TabIndex = 1
        '
        'PageText
        '
        Me.PageText.AcceptsReturn = True
        Me.PageText.AcceptsTab = True
        Me.PageText.AutoSize = False
        Me.PageText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageText.Location = New System.Drawing.Point(3, 3)
        Me.PageText.Multiline = True
        Me.PageText.Name = "PageText"
        Me.PageText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PageText.Size = New System.Drawing.Size(316, 361)
        Me.PageText.TabIndex = 0
        '
        'ListPatternsTab
        '
        Me.ListPatternsTab.Controls.Add(Me.SplitContainer3)
        Me.ListPatternsTab.Location = New System.Drawing.Point(4, 22)
        Me.ListPatternsTab.Name = "ListPatternsTab"
        Me.ListPatternsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ListPatternsTab.Size = New System.Drawing.Size(322, 367)
        Me.ListPatternsTab.TabIndex = 2
        Me.ListPatternsTab.Text = "List Patterns"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextPatternsGrid)
        '
        'Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.WebBrowser2)
        Me.SplitContainer3.Size = New System.Drawing.Size(316, 361)
        Me.SplitContainer3.SplitterDistance = 106
        Me.SplitContainer3.TabIndex = 1
        Me.SplitContainer3.Text = "SplitContainer3"
        '
        'TextPatternsGrid
        '
        Me.TextPatternsGrid.AllowUserToAddRows = False
        Me.TextPatternsGrid.AllowUserToDeleteRows = False
        Me.TextPatternsGrid.AllowUserToOrderColumns = True
        Me.TextPatternsGrid.BackgroundColor = System.Drawing.Color.Tan
        Me.TextPatternsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.TextPatternsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TextPatternsGrid.Columns.Add(Me.DataGridViewTextBoxColumn3)
        Me.TextPatternsGrid.Columns.Add(Me.DataGridViewTextBoxColumn4)
        Me.TextPatternsGrid.Columns.Add(Me.DataGridViewTextBoxColumn5)
        Me.TextPatternsGrid.Columns.Add(Me.DataGridViewTextBoxColumn6)
        Me.TextPatternsGrid.Columns.Add(Me.DataGridViewTextBoxColumn7)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.OldLace
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TextPatternsGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.TextPatternsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextPatternsGrid.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TextPatternsGrid.GridColor = System.Drawing.Color.Tan
        Me.TextPatternsGrid.Location = New System.Drawing.Point(0, 0)
        Me.TextPatternsGrid.Name = "TextPatternsGrid"
        Me.TextPatternsGrid.ReadOnly = True
        Me.TextPatternsGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TextPatternsGrid.RowHeadersVisible = False
        Me.TextPatternsGrid.Size = New System.Drawing.Size(106, 361)
        Me.TextPatternsGrid.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Token"
        Me.DataGridViewTextBoxColumn3.Name = "Token"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Splits"
        Me.DataGridViewTextBoxColumn4.Name = "SplitsCoulmn"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Starts At"
        Me.DataGridViewTextBoxColumn5.Name = "FirstStartIndexColumn"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ends At"
        Me.DataGridViewTextBoxColumn6.Name = "FirstEndIndexColumn"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "--"
        Me.DataGridViewTextBoxColumn7.Name = "SplitsArrayColumn"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(206, 361)
        Me.WebBrowser2.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.NoiceLevelControl)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.TotalWordsLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CalcWordGroupCheckBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 341)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(233, 52)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Noice Level:"
        '
        'NoiceLevelControl
        '
        Me.NoiceLevelControl.Location = New System.Drawing.Point(76, 3)
        Me.NoiceLevelControl.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.NoiceLevelControl.Name = "NoiceLevelControl"
        Me.NoiceLevelControl.Size = New System.Drawing.Size(47, 20)
        Me.NoiceLevelControl.TabIndex = 5
        Me.NoiceLevelControl.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(129, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(49, 21)
        Me.RefreshButton.TabIndex = 6
        Me.RefreshButton.Text = "&Refresh"
        '
        'TotalWordsLabel
        '
        Me.TotalWordsLabel.AutoSize = True
        Me.TotalWordsLabel.Location = New System.Drawing.Point(184, 3)
        Me.TotalWordsLabel.Name = "TotalWordsLabel"
        Me.TotalWordsLabel.Size = New System.Drawing.Size(0, 0)
        Me.TotalWordsLabel.TabIndex = 7
        '
        'CalcWordGroupCheckBox
        '
        Me.CalcWordGroupCheckBox.AutoSize = True
        Me.CalcWordGroupCheckBox.Location = New System.Drawing.Point(3, 30)
        Me.CalcWordGroupCheckBox.Name = "CalcWordGroupCheckBox"
        Me.CalcWordGroupCheckBox.Size = New System.Drawing.Size(132, 17)
        Me.CalcWordGroupCheckBox.TabIndex = 8
        Me.CalcWordGroupCheckBox.Text = "Calculate Word Groups"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoRelocate = True
        Me.DataGridView1.AutoSize = True
        Me.DataGridView1.AutoSizeColumnHeadersEnabled = True
        Me.DataGridView1.AutoSizeRowHeadersMode = System.Windows.Forms.DataGridViewAutoSizeRowHeadersMode.AllRows
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.HeaderAndColumnsAllRows
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lavender
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeight = 22
        Me.DataGridView1.Columns.Add(Me.DataGridViewTextBoxColumn1)
        Me.DataGridView1.Columns.Add(Me.DataGridViewTextBoxColumn2)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridView1.GridColor = System.Drawing.Color.RoyalBlue
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 46
        Me.DataGridView1.Size = New System.Drawing.Size(233, 371)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeCriteria = System.Windows.Forms.DataGridViewAutoSizeColumnCriteria.HeaderAndDisplayedRows
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Word"
        Me.DataGridViewTextBoxColumn1.Name = "Word"
        Me.DataGridViewTextBoxColumn1.Width = 53
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeCriteria = System.Windows.Forms.DataGridViewAutoSizeColumnCriteria.HeaderAndRows
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Count"
        Me.DataGridViewTextBoxColumn2.Name = "Count"
        Me.DataGridViewTextBoxColumn2.Width = 56
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripPanel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 440)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.StatusStrip1.Raft = System.Windows.Forms.RaftingSides.None
        Me.StatusStrip1.TabIndex = 4
        '
        'StatusStripPanel1
        '
        Me.StatusStripPanel1.Name = "StatusStripPanel1"
        Me.StatusStripPanel1.SettingsKey = "Form1.StatusStripPanel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.SettingsKey = "Form1.ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 15)
        Me.ToolStripProgressBar1.Text = "ToolStripProgressBar1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(567, 459)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ListPatternsTab.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.TextPatternsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.NoiceLevelControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UrlTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PageText As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NoiceLevelControl As System.Windows.Forms.NumericUpDown
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents TotalWordsLabel As System.Windows.Forms.Label
    Friend WithEvents CalcWordGroupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ListPatternsTab As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusStripPanel1 As System.Windows.Forms.StatusStripPanel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextPatternsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser

End Class
