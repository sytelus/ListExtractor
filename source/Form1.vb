Imports System.Text

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(UrlTextBox.Text)
    End Sub

    Private Sub UrlTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UrlTextBox.KeyPress
        If e.KeyChar = vbCr Then
            Button1_Click(Nothing, Nothing)
        End If
    End Sub

    Dim m_bodyText As String
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If (Not WebBrowser1.Document Is Nothing) Then
            TitleTextBox.Text = WebBrowser1.Document.Title
            m_bodyText = WebBrowser1.Document.Body.OuterText

            If (CalcWordGroupCheckBox.Checked = True) Then
                CreateAndFilterWordCounts()
            End If

            PageText.Text = m_bodyText
            UrlTextBox.Text = WebBrowser1.Url
        End If
    End Sub

    Private Sub CreateAndFilterWordCounts()
        CreateWordCounts(m_bodyText)
        FilterNoiceAndPaint(NoiceLevelControl.Value)
    End Sub

    Private Class NoiceWord
        Public Word As String
        Public NoiceLevel As Integer
        Public Sub New(ByVal paramWord As String, ByVal paramNoiceLevel As Integer)
            Word = paramWord
            NoiceLevel = paramNoiceLevel
        End Sub
    End Class

    Dim m_noiceWords As New Generic.Dictionary(Of String, NoiceWord)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load noise words
        Dim allNoiceWords As String = IO.File.ReadAll("..\noise words.txt")
        Dim prasedAllNoiceWords As String() = allNoiceWords.Split(vbCrLf)
        For index As Integer = 0 To prasedAllNoiceWords.Length - 1
            Dim word As String = prasedAllNoiceWords(index).Trim.ToLower
            m_noiceWords.Add(word, New NoiceWord(word, index))
        Next

        'UrlTextBox.Text = "http://localhost/test2/a1.txt"
        UrlTextBox.Text = "http://directory.google.com/Top/Science/Physics/Relativity/Special_Relativity/"
        Button1_Click(Nothing, Nothing)
    End Sub

    Dim m_wordBreakerRegEx As New RegularExpressions.Regex("(?: \$?[\d\.\,]*\d (?! (?: [\-\@][a-zA-Z0-9]+)+) ) | (?: [a-z0-9A-Z\'\$_][a-z0-9A-Z\'\-\$_]*)", RegularExpressions.RegexOptions.Compiled Or RegularExpressions.RegexOptions.IgnorePatternWhitespace Or RegularExpressions.RegexOptions.Multiline Or RegularExpressions.RegexOptions.IgnoreCase)
    Dim m_wordCountsForLoadedPage As Generic.Dictionary(Of String, String)
    Private Sub CreateWordCounts(ByVal textToAnalyse As String)
        m_wordCountsForLoadedPage = New Generic.Dictionary(Of String, String)

        If Not textToAnalyse Is Nothing Then
            Dim wordMatches As RegularExpressions.MatchCollection = m_wordBreakerRegEx.Matches(textToAnalyse)
            For Each wordMatch As RegularExpressions.Match In wordMatches
                Dim word As String = wordMatch.Value.ToLower
                'Is this word noice?
                If m_wordCountsForLoadedPage.ContainsKey(word) Then
                    m_wordCountsForLoadedPage(word) += 1
                Else
                    m_wordCountsForLoadedPage.Add(word, 1)
                End If
            Next
        Else
            'No need for parsing
        End If
    End Sub

    Private Sub FilterNoiceAndPaint(ByVal noiceLevel As Integer)
        DataGridView1.Rows.Clear()
        Dim totalWords As Integer = 0
        Dim filteredWords As Integer = 0
        DataGridView1.Rows.Add(m_wordCountsForLoadedPage.Count)
        For Each item As Generic.KeyValuePair(Of String, String) In m_wordCountsForLoadedPage
            If (Not m_noiceWords.ContainsKey(item.Key)) OrElse (m_noiceWords.ContainsKey(item.Key) AndAlso (m_noiceWords.Item(item.Key).NoiceLevel > noiceLevel)) Then
                DataGridView1.Rows(totalWords).SetValues(item.Key, item.Value.PadLeft(4))
            Else
                filteredWords += 1
                'This is noice, ignore
            End If
            totalWords += 1
            TotalWordsLabel.Text = "Total words: " + totalWords.ToString + " , filtered out: " + filteredWords.ToString
            DoEvents()
        Next
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated

    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        ToolStripProgressBar1.Maximum = e.MaximumProgress
        If (e.CurrentProgress >= ToolStripProgressBar1.Minimum) And (e.CurrentProgress <= ToolStripProgressBar1.Maximum) Then
            ToolStripProgressBar1.Visible = True
            ToolStripProgressBar1.Value = e.CurrentProgress
        Else
            ToolStripProgressBar1.Visible = False
        End If
    End Sub

    Private Sub WebBrowser1_StatusTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.StatusTextChanged
        StatusStripPanel1.Text = WebBrowser1.StatusText
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        FilterNoiceAndPaint(NoiceLevelControl.Value)
    End Sub

    Private Sub CalcWordGroupCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcWordGroupCheckBox.CheckedChanged
        If (CalcWordGroupCheckBox.Checked = True) Then
            CreateAndFilterWordCounts()
        End If
    End Sub

    Dim WithEvents m_PatternExtractor As New ListExtractor(4)
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is ListPatternsTab Then
            TextPatternsGrid.Rows.Clear()
            m_PatternExtractor.AnalyseTextPatterns(WebBrowser1.Document.Body.InnerHtml)
            StatusStripPanel1.Text = TextPatternsGrid.Rows.Count.ToString + " patterns"
        End If

    End Sub

    Private Sub m_PatternExtractor_Progress(ByVal currentValue As Integer, ByVal maxValue As Integer) Handles m_PatternExtractor.Progress
        ToolStripProgressBar1.Maximum = maxValue
        If (currentValue >= ToolStripProgressBar1.Minimum) And (currentValue <= ToolStripProgressBar1.Maximum) Then
            ToolStripProgressBar1.Visible = True
            ToolStripProgressBar1.Value = currentValue
        Else
            ToolStripProgressBar1.Visible = False
        End If
        DoEvents()
    End Sub

    Private Sub m_PatternExtractor_TokenFound(ByVal tokenInfo As ListExtractor.TextPatternInfo) Handles m_PatternExtractor.TokenFound
        TextPatternsGrid.Rows.Add(New Object() {tokenInfo.Token, tokenInfo.TextSplits.Length, tokenInfo.FirstStartIndex, tokenInfo.FirstEndIndex, tokenInfo.TextSplits})
    End Sub

    Private Sub TextPatternsGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TextPatternsGrid.CellClick
        If e.RowIndex <> -1 Then
            Dim textSplits As String() = DirectCast(TextPatternsGrid.Rows(e.RowIndex).Cells("SplitsArrayColumn").Value, String())
            Dim html As New System.Text.StringBuilder("<html><body><table border=2 bordercolor=red>")
            For i As Integer = 1 To textSplits.Length - 2
                html.Append("<tr><td>" + textSplits(i) + "</td></tr>")
            Next
            html.Append("</table></body></html>")
            WebBrowser2.DocumentText = html.ToString
        End If
    End Sub

    Private Sub TextPatternsGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPatternsGrid.Click

    End Sub
End Class
