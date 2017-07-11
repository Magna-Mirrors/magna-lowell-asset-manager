'Imports System.Data.Linq
'Imports System.Data.SqlClient
'Imports System.Threading.Tasks
'Imports MagnaLowell.AssetManager.Models
'Imports NLog

'Namespace Tools
'    Public Interface IDbInterface
'        Function GetItems(Of T As {Class})() As DbResult(Of List(Of T))
'        'Function GetLevelEnums() As DbResult(Of List(Of Security_LevelEnum))
'        'Function GetUserToLines() As DbResult(Of List(Of Security_AssetUser))
'        'Function GetResultEnums() As DbResult(Of List(Of ResultEnum))
'        'Function GetAssets() As DbResult(Of List(Of Security_Asset))
'        'Function GetUsers() As DbResult(Of List(Of Security_UserTable))
'        Function FillList(Of T As {Class})(lst As List(Of T), Optional pred As Func(Of T, Boolean) = Nothing) As DbResult(Of Boolean)
'        Function AddNew(Of T As {Class})(newItems As List(Of T)) As DbResult(Of Boolean)
'        Function AddNew(Of T As {Class})(newItems As T) As DbResult(Of Boolean)
'        Function Remove(Of T As {Class})(items As List(Of T)) As DbResult(Of Boolean)
'        Function Remove(Of T As {Class})(item As T, Optional table As Table(Of T) = Nothing) As DbResult(Of Boolean)
'        Function ItemFound(Of T As {Class})(item As T) As Boolean
'        Function SubmitChanges() As DbResult(Of Boolean)
'        Function RevertChange(Of T As {Class})(item As T) As DbResult(Of Boolean)
'        'Function GetChanges() As ChangeSet
'        Function GetItemState(Of T)(item As T) As ItemState
'        Function GetItemColor(Of T)(item As T, defaultColor As Color) As DbResult(Of Color)
'        Function TestConnection() As DbResult(Of Boolean)
'    End Interface

'    Public Class DbInterface
'        Implements IDbInterface

'        ReadOnly logger As Logger = LogManager.GetCurrentClassLogger()
'        ReadOnly cfgFile As ICfgInterface
'        ReadOnly _context As Magna_LowellEntities
'        'Private Shared Property WorkingConnectionString() As String

'        Public Sub New(c As ICfgInterface)
'            cfgFile = c
'            If _context Is Nothing Then
'                _connStr = String.Format(ConnString, cfgFile.Cfg.ServerInstance, cfgFile.Cfg.DataBase, cfgFile.Cfg.UserName, cfgFile.Cfg.PasswordDecrypted)
'                _context = New Magna_LowellEntities(_connStr)
'            End If
'        End Sub

'        ReadOnly _connStr As String
'        Public Const ConnString = "Server={0};Database={1};User Id={2};Password={3};"

'#Region "Get"
'        Public Function FillList(Of T As {Class})(lst As List(Of T), Optional pred As Func(Of T, Boolean) = Nothing) As DbResult(Of Boolean) Implements IDbInterface.FillList
'            Try
'                Dim tbl = _context.Set(Of T)
'                If pred Is Nothing Then
'                    lst.AddRange(tbl.ToList())
'                Else
'                    lst.AddRange(tbl.Where(pred).ToList())
'                End If
'                Return New DbResult(Of Boolean)(True)
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function
'        'Public Function GetLevelEnums() As DbResult(Of List(Of Security_LevelEnum)) Implements IDbInterface.GetLevelEnums
'        '    Try
'        '        Return New DbResult(Of List(Of Security_LevelEnum))(_context.Security_LevelEnums.ToList())
'        '    Catch ex As Exception
'        '        logger.Error(ex.message)
'        '        Return New DbResult(Of List(Of Security_LevelEnum))(ex)
'        '    End Try
'        'End Function
'        'Public Function GetUserToLines() As DbResult(Of List(Of Security_AssetUser)) Implements IDbInterface.GetUserToLines
'        '    Try
'        '        Return New DbResult(Of List(Of Security_AssetUser))(_context.Security_AssetUsers.Where(Function(x) x.AssetID <> -1).ToList())
'        '    Catch ex As Exception
'        '        logger.Error(ex.message)
'        '        Return New DbResult(Of List(Of Security_AssetUser))(ex)
'        '    End Try
'        'End Function
'        'Public Function GetAssets() As DbResult(Of List(Of Security_Asset)) Implements IDbInterface.GetAssets
'        '    Try
'        '        Return New DbResult(Of List(Of Security_Asset))(_context.Security_Assets.ToList())
'        '    Catch ex As Exception
'        '        logger.Error(ex.message)
'        '        Return New DbResult(Of List(Of Security_Asset))(ex)
'        '    End Try
'        'End Function
'        'Public Function GetUsers() As DbResult(Of List(Of Security_UserTable)) Implements IDbInterface.GetUsers
'        '    Try
'        '        Return New DbResult(Of List(Of Security_UserTable))(_context.Security_UserTables.ToList())
'        '    Catch ex As Exception
'        '        logger.Error(ex.message)
'        '        Return New DbResult(Of List(Of Security_UserTable))(ex)
'        '    End Try
'        'End Function

'        'Public Function GetResultEnums() As DbResult(Of List(Of ResultEnum)) Implements IDbInterface.GetResultEnums
'        '    Try
'        '        Return New DbResult(Of List(Of ResultEnum))(_context.ResultEnums.ToList())
'        '    Catch ex As Exception
'        '        logger.Error(ex.message)
'        '        Return New DbResult(Of List(Of ResultEnum))(ex)
'        '    End Try
'        'End Function
'#End Region

'#Region "AddNew"
'        Public Function AddNew(Of T As {Class})(newItems As List(Of T)) As DbResult(Of Boolean) Implements IDbInterface.AddNew
'            Try
'                _context.Set(Of T).InsertAllOnSubmit(Of T)(newItems)
'                newItems.Clear()
'                Return New DbResult(Of Boolean)(True)
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function

'        Public Function AddNew(Of T As {Class})(newItems As T) As DbResult(Of Boolean) Implements IDbInterface.AddNew
'            Try
'                _context.Set(Of T).InsertOnSubmit(newItems)
'                Return New DbResult(Of Boolean)(True)
'            Catch ex As Exception
'                logger.Error(ex.Message)

'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function
'#End Region

'#Region "Remove"
'        Public Function Remove(Of T As {Class})(items As List(Of T)) As DbResult(Of Boolean) Implements IDbInterface.Remove
'            Try
'                Dim tbl = _context.Set(Of T)
'                Dim pass = True
'                Dim err As Exception = Nothing
'                For Each item In items
'                    Dim res = Remove(item, tbl)
'                    If Not res.Result Then
'                        pass = False
'                        err = res.Err
'                    End If
'                Next
'                items.Clear()
'                If Not pass Then
'                    Return New DbResult(Of Boolean)(pass)
'                Else
'                    Return New DbResult(Of Boolean)(err)
'                End If
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function
'        Public Function Remove(Of T As {Class})(item As T, Optional table As Table(Of T) = Nothing) As DbResult(Of Boolean) Implements IDbInterface.Remove
'            Try
'                Dim tbl = If(table, _context.Set(Of T))
'                If tbl.Contains(item) Then
'                    tbl.DeleteOnSubmit(item)
'                    Return New DbResult(Of Boolean)(True)
'                Else
'                    tbl.DeleteOnSubmit(item)
'                End If
'                Return New DbResult(Of Boolean)(False)
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function
'#End Region

'#Region "Helpers"
'        Public Function ItemFound(Of T As {Class})(item As T) As Boolean Implements IDbInterface.ItemFound
'            Return _context.Set(Of T).Contains(item)
'        End Function
'        Public Function SubmitChanges() As DbResult(Of Boolean) Implements IDbInterface.SubmitChanges
'            Try
'                _context.SaveChanges()
'                Return New DbResult(Of Boolean)(True)
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function
'        Public Function RevertChange(Of T As {Class})(item As T) As DbResult(Of Boolean) Implements IDbInterface.RevertChange
'            Try
'                If _context.Set(Of T).Contains(item) Then
'                    _context.Refresh(RefreshMode.OverwriteCurrentValues, item)
'                End If
'                Return New DbResult(Of Boolean)(True)
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function
'        Private Function GetChanges() As ChangeSet 'Implements IDbInterface.GetChanges
'            Return _context.GetChangeSet()
'        End Function


'        Public Function GetItemState(Of T)(item As T) As ItemState Implements IDbInterface.GetItemState
'            If (ItemInUpdate(item).Result) Then
'                Return ItemState.Update
'            ElseIf (ItemInInsert(item).Result) Then
'                Return ItemState.Insert
'            ElseIf (ItemInDelete(item).Result) Then
'                Return ItemState.Delete
'            End If
'            Return ItemState.None
'        End Function

'        Public Function GetItemColor(Of T)(item As T, defaultColor As Color) As DbResult(Of Color) Implements IDbInterface.GetItemColor
'            Dim clr = defaultColor
'            Select Case GetItemState(item)
'                Case ItemState.Update
'                    clr = Color.PaleGoldenrod
'                Case ItemState.Insert
'                    clr = Color.PaleGreen
'                Case ItemState.Delete
'                    clr = Color.PaleVioletRed
'                Case ItemState.None
'                    clr = defaultColor
'            End Select
'            Return New DbResult(Of Color)(clr)
'        End Function

'        Public Function TestConnection() As DbResult(Of Boolean) Implements IDbInterface.TestConnection
'            Try
'                Using x As New SqlConnection(_connStr)
'                    x.Open()
'                    x.Close()
'                End Using
'                'WorkingConnectionString = _connStr
'                Return New DbResult(Of Boolean)(True)
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of Boolean)(ex)
'            End Try
'        End Function

'        Private Function ItemInInsert(Of T)(item As T) As DbResult(Of Boolean)
'            Return New DbResult(Of Boolean)(GetChanges().Inserts.Contains(item))
'        End Function
'        Private Function ItemInDelete(Of T)(item As T) As DbResult(Of Boolean)
'            Return New DbResult(Of Boolean)(GetChanges().Deletes.Contains(item))
'        End Function
'        Private Function ItemInUpdate(Of T)(item As T) As DbResult(Of Boolean)
'            Return New DbResult(Of Boolean)(GetChanges().Updates.Contains(item))
'        End Function

'        Public Function GetItems(Of T As Class)() As DbResult(Of List(Of T)) Implements IDbInterface.GetItems
'            Try
'                Dim tbl = _context.Set(Of T)
'                Return New DbResult(Of List(Of T))(tbl.ToList())
'            Catch ex As Exception
'                logger.Error(ex.Message)
'                Return New DbResult(Of List(Of T))(ex)
'            End Try
'        End Function
'#End Region


'    End Class
'    Public Enum ItemState
'        None
'        Insert
'        Update
'        Delete
'    End Enum
'End Namespace