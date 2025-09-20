
Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Public Class Form1

        Dim connectionString As String = "Data Source=MSI;Initial Catalog=qly;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
        Public connection As SqlClient.SqlConnection

        Dim adapter As SqlDataAdapter
        Dim table As DataTable



        Private Sub LoadData()
            Try
                connection = New SqlConnection(connectionString)
                connection.Open()

                adapter = New SqlDataAdapter("SELECT * FROM qly", connection)
                table = New DataTable()
                adapter.Fill(table)


                '  DgvBooks.DataSource = table

                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
            End Try
        End Sub
    End Class


    Public Class Book
        Public Property Title As String
        Public Property Author As String
        Public Property Year As Integer

        Public Sub New(title As String, author As String, year As Integer)
            Me.Title = title
            Me.Author = author
            Me.Year = year
        End Sub
    End Class
    Private bookList As New List(Of Book)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Khởi tạo DataGridView

        DgvBooks.AutoGenerateColumns = True
        DgvBooks.DataSource = bookList

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txttitle.Text = "" Or txtauthor.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.")
            Return
        End If

        Dim title As String = txttitle.Text
        Dim author As String = txtauthor.Text
        Dim year As Integer = Convert.ToInt32(txtyear.Text)

        Dim newBook As New Book(title, author, year)
        bookList.Add(newBook)

        RefreshGrid()
        ClearInputs()
    End Sub

    Private Sub RefreshGrid()
        DgvBooks.DataSource = Nothing
        DgvBooks.DataSource = bookList
    End Sub

    Private Sub ClearInputs()
        txttitle.Clear()
        txtauthor.Clear()
        txtyear.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DgvBooks.CurrentRow IsNot Nothing Then
            Dim book As Book = CType(DgvBooks.CurrentRow.DataBoundItem, Book)
            bookList.Remove(book)
            RefreshGrid()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        ClearInputs()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        RefreshGrid()
    End Sub
End Class

