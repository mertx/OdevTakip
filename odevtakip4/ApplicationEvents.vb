Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim Path As String = System.Reflection.Assembly.GetExecutingAssembly.Location
            Path = Path.Substring(0, Path.LastIndexOf("\") + 1) & "files\"
            _databaseloc = Path + "database\"
            _imgloc = Path + "img\"
            _FirstStart()
        End Sub

    End Class

End Namespace

