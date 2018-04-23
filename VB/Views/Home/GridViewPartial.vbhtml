@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "ProductID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.HideDataCells
            settings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = True
    
            settings.CommandColumn.Visible = True

            settings.Columns.Add( _
                Sub(column)
                        column.FieldName = "ProductID"
                        column.ReadOnly = True
                        column.EditFormSettings.Visible = DefaultBoolean.False
                End Sub)

            settings.Columns.Add("ProductName")
            settings.Columns.Add("UnitPrice")
            settings.Columns.Add("UnitsOnOrder")
    End Sub).Bind(Model).GetHtml()
