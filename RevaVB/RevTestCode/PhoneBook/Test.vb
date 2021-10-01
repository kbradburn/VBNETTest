Module Test

    Sub Main()
        ' List of People
        Dim people = GetPeople()
        ' List of People
        DisplayList(people)
        ' ****Paste query & query execution code 
        Console.ReadLine()
    End Sub

    'DisplayList called to see names of people in list.
    'List can be expanded using this method to see other people's priorities.
    Sub DisplayList(ByVal personCol As IEnumerable(Of People))
        For Each st As Person In studentCol
            Console.WriteLine("First Name: " & st.First)
            Console.WriteLine(" Last Name: " & st.Last)
            Console.WriteLine()
        Next
    End Sub

    'Function GetPeople returns a list of People objects.
    Function GetPeople() As IEnumerable(Of Person)
        Return New List(Of Person) From
            {
                New Person("Michael", "Jackson", "Junior", 10)
                New Person("Zephina", "Svetlana", "Senior", 2)
                New Person("Jason", "Tucker", "Sophomore", 7)
                New Person("Johnathan", "Jordan", "Freshman", 53)
                New Person("James", "Brown", "Junior", 16)
            }
    End Function

    ' Each person has a first name , a last name, a class year, and 
    ' a rank that indicates academic ranking in the student body.
    Public Class Person
        Public Property First As String
        Public Property Last As String
        Public Property Year As String
        Public Property Rank As Integer

        Public Sub New()

        End Sub

        Public Sub New(ByVal firstName As String, 
                    ByVal lastName As String, 
                    ByVal studentYear As String,
                    ByVal studentRank As Integer)
            First = firstName
            last = lastName
            Year = studentYear
            Rank = studentRank
        End Sub
    End Class
    
End Module