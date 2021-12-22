Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace handle_customizemergefields_event

    Public Partial Class [Default]
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then
                RE.ActiveTabIndex = 5
            End If
        End Sub

        Protected Sub RE_CustomizeMergeFields(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.CustomizeMergeFieldsEventArgs)
            For Each field In e.MergeFieldsNames
                If Equals(field.Name, "ProductID") Then
                    field.DisplayName = "ID of Product"
                ElseIf Equals(field.Name, "ProductName") Then
                    field.DisplayName = "Name of Product"
                End If
            Next
        End Sub
    End Class
End Namespace
