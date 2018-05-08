Public Class frmLibrary
    Dim lbr As Library
    Dim rdr As Readerslist


    Structure Readers
        Dim name As String
        Dim arrratings() As String

        Function getrstring() As String
            getrstring = name + " " + arrratings(86)
        End Function
    End Structure

    Structure Readerslist
        Dim arrreaders() As Readers



        Sub getreaders()
            Dim path As String
            Dim i As Integer
            Dim strline As String
            ReDim arrreaders(86)
            Dim rc As Integer


            path = "D:\Locker\Files\Projects\CP II\VB.NET\Library\BookResources\readerratings.txt"

            FileOpen(1, path, OpenMode.Input)

            Do While Not EOF(1)
                strline = Trim(LineInput(1))
                For i = 1 To Len(strline)
                    arrreaders(rc).name = LineInput(1)
                    arrreaders(rc).arrratings(86) = LineInput(1)
                    frmLibrary.lstRatings.Items.Add(arrreaders(rc).getrstring)
                    rc = rc = 1
                Next
            Loop

        End Sub
    End Structure
    Structure Book
        Dim author As String
        Dim title As String

        Function getbstr() As String
            getbstr = author + " " + title
        End Function
    End Structure
    Structure Library
        Dim arrbooks() As Book

        Sub getbooks()
            Dim path As String
            Dim i As Integer
            Dim strline As String
            ReDim arrbooks(55)
            Dim bc As Integer

            path = "D:\Locker\Files\Projects\CP II\VB.NET\Library\BookResources\books.txt"
            FileOpen(1, path, OpenMode.Input)

            Do While Not EOF(1)
                strline = Trim(LineInput(1))
                For i = 1 To Len(strline)
                    If Mid(strline, i, 1) = "," Then
                        arrbooks(bc).author = Mid(strline, 1, i - 1)
                        arrbooks(bc).title = Mid(strline, i + 1, Len(strline))
                        frmLibrary.lstBooks.Items.Add(arrbooks(bc).getbstr)
                        bc = bc + 1
                    End If
                Next

            Loop
            FileClose(1)
        End Sub
    End Structure
    Sub fill() 'display readers and books
        lbr.getbooks()
        rdr.getreaders()

    End Sub
    Private Sub frmLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill()
    End Sub

    Private Sub cmdFill_Click(sender As Object, e As EventArgs)

    End Sub
End Class
