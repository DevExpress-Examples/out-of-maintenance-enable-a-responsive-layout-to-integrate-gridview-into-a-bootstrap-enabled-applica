Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace GridViewAndBootstrapMvc.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(NorthwindDataProvider.GetProducts())
		End Function
	End Class
End Namespace