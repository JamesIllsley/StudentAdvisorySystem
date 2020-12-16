Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Meeting() As ActionResult
        ViewData("Message") = "Your meeting page."

        Return View()
    End Function
    Function Map() As ActionResult
        ViewData("Message") = "Here you can find your program map."

        Return View()
    End Function
End Class
