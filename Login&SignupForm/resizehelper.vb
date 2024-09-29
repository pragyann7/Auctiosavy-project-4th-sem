Imports System.Drawing
Imports System.Windows.Forms

Public Class resizehelper
    Private formOriginalSize As Size
    Private controlRectangles As Dictionary(Of Control, Rectangle)

    Public Sub New(ByVal form As Form)
        ' Store the original size of the form
        formOriginalSize = form.Size

        ' Initialize dictionary to store control rectangles
        controlRectangles = New Dictionary(Of Control, Rectangle)()
    End Sub

    ' Store the original size and position of controls
    Public Sub AddControl(ByVal control As Control)
        Dim rect As New Rectangle(control.Location, control.Size)
        controlRectangles(control) = rect
    End Sub

    ' Resize all controls when the form is resized
    Public Sub HandleResize(ByVal form As Form)
        Dim xRatio As Single = CSng(form.Width) / CSng(formOriginalSize.Width)
        Dim yRatio As Single = CSng(form.Height) / CSng(formOriginalSize.Height)

        For Each entry In controlRectangles
            Dim control As Control = entry.Key
            Dim originalRect As Rectangle = entry.Value

            Dim newX As Integer = CInt(originalRect.X * xRatio)
            Dim newY As Integer = CInt(originalRect.Y * yRatio)
            Dim newWidth As Integer = CInt(originalRect.Width * xRatio)
            Dim newHeight As Integer = CInt(originalRect.Height * yRatio)

            control.Location = New Point(newX, newY)
            control.Size = New Size(newWidth, newHeight)
        Next
    End Sub
End Class
