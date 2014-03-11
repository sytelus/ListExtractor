Imports System.Text
Imports System.Text.RegularExpressions

Public Class ListExtractor
    Public Event Progress(ByVal currentValue As Integer, ByVal maxValue As Integer)
    Public Event TokenFound(ByVal tokenInfo As TextPatternInfo)

    Private m_MinAllowedTokenLegth As Integer = 1
    Public Property MinAllowedTokenLegth() As Integer
        Get
            Return m_MinAllowedTokenLegth
        End Get
        Set(ByVal value As Integer)
            m_MinAllowedTokenLegth = value
        End Set
    End Property
    Private m_MaxAllowedTokenLegth As Integer = 512
    Public Property MaxAllowedTokenLegth() As Integer
        Get
            Return m_MaxAllowedTokenLegth
        End Get
        Set(ByVal value As Integer)
            m_MaxAllowedTokenLegth = value
        End Set
    End Property
    Private m_MinExpectedMatchCount As Integer = 3
    Public Property MinExpectedMatchCount() As Integer
        Get
            Return m_MinExpectedMatchCount
        End Get
        Set(ByVal value As Integer)
            m_MinExpectedMatchCount = value
        End Set
    End Property
    Private m_MaxExpectedMatchCount As Integer = 4000
    Public Property MaxExpectedMatchCount() As Integer
        Get
            Return m_MaxExpectedMatchCount
        End Get
        Set(ByVal value As Integer)
            m_MaxExpectedMatchCount = value
        End Set
    End Property

    Private m_PatternRejectRule As String = "(?: \s*[a-zA-Z0-9\(\)]+\s*)+"
    Private m_PatternAcceptRule As String = "(?: (?: \s+\S+\s*) | (?: \s*\S+\s+))"
    Private m_PatternAcceptRegEx As New Regex(m_PatternAcceptRule, RegexOptions.Compiled Or RegexOptions.IgnorePatternWhitespace)
    Private m_PatternRejectRegEx As New Regex(m_PatternRejectRule, RegexOptions.Compiled Or RegexOptions.IgnorePatternWhitespace)
    Public Property PatternAcceptRule() As String
        Get
            Return m_PatternAcceptRule
        End Get
        Set(ByVal value As String)
            m_PatternAcceptRule = value
            m_PatternAcceptRegEx = New Regex(value, RegexOptions.Compiled Or RegexOptions.IgnorePatternWhitespace)
        End Set
    End Property
    Public Property PatternRejectRule() As String
        Get
            Return m_PatternRejectRule
        End Get
        Set(ByVal value As String)
            m_PatternRejectRule = value
            m_PatternRejectRegEx = New Regex(value, RegexOptions.Compiled)
        End Set
    End Property

    Public Function AnalyseTextPatterns(ByVal textToAnalyse As String) As Generic.Dictionary(Of String, TextPatternInfo)
        m_PreviouslyRejectedPatterns.Clear()
        Dim foundTextPatterns As New Generic.Dictionary(Of String, TextPatternInfo)
        If textToAnalyse.Length > 0 Then
            Dim tokenStartIndex As Integer = 0
            Dim tokenEndIndex As Integer = tokenStartIndex
            Dim token As New StringBuilder(m_MaxAllowedTokenLegth)
            RaiseEvent Progress(tokenStartIndex, textToAnalyse.Length)

            Dim lastTokenSplits As String() = Nothing
            Do
                token.Append(textToAnalyse(tokenEndIndex))
                Dim tokenSplits As String() = Regex.Split(textToAnalyse, Regex.Escape(token.ToString), RegexOptions.Multiline)

                If (tokenSplits.Length >= m_MinExpectedMatchCount + 1) And (tokenSplits.Length <= m_MaxExpectedMatchCount + 1) Then
                    'See if this toekn is continuation of last token
                    If (Not (lastTokenSplits Is Nothing)) AndAlso (lastTokenSplits.Length <> tokenSplits.Length) Then
                        'It not continuation of last token
                        'Declare that we have a token
                        CheckAndAddNewFoundToken(foundTextPatterns, token.ToString(0, token.Length - 1), tokenStartIndex, tokenEndIndex - 1, lastTokenSplits)
                    Else
                        'its a continuation of last token
                    End If
                    lastTokenSplits = tokenSplits
                    tokenEndIndex += 1
                Else
                    'Not enough matches
                    'Do we have last token?
                    If Not (lastTokenSplits Is Nothing) Then
                        'We have arrived at the end of last found token
                        CheckAndAddNewFoundToken(foundTextPatterns, token.ToString(0, token.Length - 1), tokenStartIndex, tokenEndIndex - 1, lastTokenSplits)
                    Else
                        'There was no last token
                    End If
                    tokenStartIndex += 1
                    If tokenEndIndex < tokenStartIndex Then
                        tokenEndIndex = tokenStartIndex
                    End If
                    token.Length = 0
                    lastTokenSplits = Nothing
                    RaiseEvent Progress(tokenStartIndex, textToAnalyse.Length)
                End If
            Loop While tokenEndIndex < textToAnalyse.Length
        Else
            'No text
        End If
        Return foundTextPatterns
    End Function

    Private m_PreviouslyRejectedPatterns As New Generic.Dictionary(Of String, Object)
    Private Sub CheckAndAddNewFoundToken(ByVal patternCollection As Generic.Dictionary(Of String, TextPatternInfo), ByVal token As String, ByVal firstStartIndex As Integer, ByVal firstEndIndex As Integer, ByVal textSplits As String())
        If (Not patternCollection.ContainsKey(token)) AndAlso (Not m_PreviouslyRejectedPatterns.ContainsKey(token)) Then
            Dim escapedToken As String = Regex.Escape(token)
            If (m_PatternRejectRegEx.Match(token).Value <> token) AndAlso m_PatternAcceptRegEx.IsMatch(escapedToken) Then
                Dim tokenInfo As New TextPatternInfo(token, firstStartIndex, firstEndIndex, textSplits)
                patternCollection.Add(token, tokenInfo)
                RaiseEvent TokenFound(tokenInfo)
            Else
                m_PreviouslyRejectedPatterns.Add(token, Nothing)
            End If
        End If
    End Sub

    Public Structure TextPatternInfo
        Public ReadOnly Token As String
        Public ReadOnly FirstStartIndex As Integer
        Public ReadOnly FirstEndIndex As Integer
        Public ReadOnly TextSplits As String()
        Public Sub New(ByVal paramToken As String, ByVal paramFirstStartIndex As Integer, ByVal paramFirstEndIndex As Integer, ByVal paramTextSplits As String())
            Token = paramToken
            FirstStartIndex = paramFirstStartIndex
            FirstEndIndex = paramFirstEndIndex
            TextSplits = paramTextSplits
        End Sub
    End Structure

    Public Sub New()

    End Sub
    Public Sub New(ByVal paramMinExpectedMatchCount As Integer)
        Me.MinExpectedMatchCount = paramMinExpectedMatchCount
    End Sub
End Class
