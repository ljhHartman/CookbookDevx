Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports System
Imports DevExpress.Data.Helpers
Imports DevExpress.Data.Filtering
Imports System.Reflection
Imports DevExpress.XtraGrid.Columns

<ToolboxItem(True)>
Public Class sslDataGrid
    Inherits GridControl

    Protected Overrides Function CreateDefaultView() As BaseView
        Return CreateView("sslGridView")
    End Function

    Protected Overrides Sub RegisterAvailableViewsCore(collection As InfoCollection)
        MyBase.RegisterAvailableViewsCore(collection)
        collection.Add(New sslGridViewInfoRegistrator())
    End Sub
End Class

Public Class sslGridViewInfoRegistrator
    Inherits GridInfoRegistrator

    Public Overrides ReadOnly Property ViewName As String
        Get
            Return "sslGridView"
        End Get
    End Property

    Public Overrides Function CreateView(grid As GridControl) As BaseView
        Return New sslGridView(TryCast(grid, GridControl))
    End Function

    Public Overrides Function CreateViewInfo(view As BaseView) As BaseViewInfo
        Return New sslGridViewInfo(TryCast(view, sslGridView))
    End Function

    Public Overrides Function CreateHandler(view As BaseView) As BaseViewHandler
        Return New sslGridViewHandler(TryCast(view, sslGridView))
    End Function

    Public Overrides Function CreatePainter(view As BaseView) As BaseViewPainter
        Return New sslGridViewPainter(TryCast(view, sslGridView))
    End Function
End Class

Public Class sslGridView
    Inherits Views.Grid.GridView
    Private _simpleSearch As Boolean
    Private _autoFilterCondition As AutoFilterCondition

    Public Sub New()

    End Sub

    Public Property SimpleSearch() As Boolean
        Get
            Return _simpleSearch
        End Get
        Set(ByVal value As Boolean)
            _simpleSearch = value
        End Set
    End Property
    Public Property AutoFilterCondition() As AutoFilterCondition
        Get
            Return _autoFilterCondition
        End Get
        Set(ByVal value As AutoFilterCondition)
            _autoFilterCondition = value
        End Set
    End Property

    Public Sub New(grid As GridControl)
        MyBase.New(grid)

    End Sub

    Protected Overrides ReadOnly Property ViewName As String
        Get
            Return "sslGridView"
        End Get
    End Property

    Protected Overrides Function ConvertGridFilterToDataFilter(ByVal criteria As CriteriaOperator) As CriteriaOperator
        Dim originalFindFilterText As String = Convert.ToString(GetType(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.GetField, Nothing, Me, New Object() {}))
        If SimpleSearch Then
            If Not (String.IsNullOrEmpty(originalFindFilterText)) Then
                GetType(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.SetField, Nothing, Me, New Object() {String.Concat("""", originalFindFilterText, """")})
            End If
            Dim findCriteria As CriteriaOperator = Nothing

            Dim _lastParserResults As FindSearchParserResults = Nothing
            If Not (String.IsNullOrEmpty(FindFilterText)) Then
                _lastParserResults = (New FindSearchParser()).Parse(FindFilterText, GetFindToColumnsCollection())
                GetType(ColumnView).GetField("lastParserResults", BindingFlags.NonPublic Or BindingFlags.Instance).SetValue(Me, _lastParserResults)
                If (Not IsServerMode) Then
                    _lastParserResults.AppendColumnFieldPrefixes()
                End If
                If AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like Then
                    findCriteria = DxFtsContainsHelperAlt.Create(_lastParserResults, FilterCondition.StartsWith, IsServerMode)
                Else
                    findCriteria = DxFtsContainsHelperAlt.Create(_lastParserResults, FilterCondition.Contains, IsServerMode)
                End If
            End If
            GetType(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.SetField, Nothing, Me, New Object() {originalFindFilterText})
            Return criteria And findCriteria
        End If
        Return MyBase.ConvertGridFilterToDataFilter(criteria)
    End Function
End Class

Public Class sslGridViewInfo
    Inherits Views.Grid.ViewInfo.GridViewInfo

    Public Sub New(view As Views.Grid.GridView)
        MyBase.New(view)

    End Sub
End Class

Public Class sslGridViewHandler
    Inherits Views.Grid.Handler.GridHandler

    Public Sub New(view As Views.Grid.GridView)
        MyBase.New(view)

    End Sub
End Class

Public Class sslGridViewPainter
    Inherits Views.Grid.Drawing.GridPainter

    Public Sub New(view As Views.Grid.GridView)
        MyBase.New(view)

    End Sub
End Class
