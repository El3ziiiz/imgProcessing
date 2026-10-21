Imports System.Text
Imports System.Drawing.Drawing2D

Public Class Form1

    Public load_img As New OpenFileDialog
    Public x As Integer, y As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1. Load Image")
        ComboBox1.Items.Add("2. Show RGB Values (TextBox)")
        ComboBox1.Items.Add("3. Grayscale")
        ComboBox1.Items.Add("4. Red Level")
        ComboBox1.Items.Add("5. Green Level")
        ComboBox1.Items.Add("6. Blue Level")
        ComboBox1.Items.Add("7. Binary Image")
        ComboBox1.Items.Add("8. Zero-Order Hold")
        ComboBox1.Items.Add("9. First-Order Hold")
        ComboBox1.Text = "Choose an Action..."

        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim choice As Integer = ComboBox1.SelectedIndex
        If choice = -1 Then Exit Sub

        If choice = 0 Then
            If load_img.ShowDialog() = DialogResult.OK Then
                PictureBox1.Load(load_img.FileName)
                x = PictureBox1.Image.Width : y = PictureBox1.Image.Height
                Dim oldImage As Image = PictureBox2.Image
                PictureBox2.Image = Nothing
                If oldImage IsNot Nothing Then oldImage.Dispose()
                TextBox1.Clear()
            End If
            Exit Sub
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please load an image first!")
            Exit Sub
        End If

        Using color_pic As New Bitmap(PictureBox1.Image)

            Dim result As Bitmap = Nothing
            Dim pixel As Color
            Dim r, g, b, p As Integer

            Select Case choice

                Case 1
                    Dim count As Integer = 0
                    Dim sb As New StringBuilder()

                    For i As Integer = 0 To x - 1
                        For j As Integer = 0 To y - 1
                            pixel = color_pic.GetPixel(i, j)
                            r = pixel.R : g = pixel.G : b = pixel.B
                            If r > 150 Then count += 1
                            sb.AppendLine("Red=" & r & " Green=" & g & " Blue=" & b)
                        Next
                    Next

                    sb.AppendLine("Red values > 150: " & count)
                    TextBox1.Text = sb.ToString()

                Case 2 To 6
                    result = New Bitmap(x, y)

                    For i As Integer = 0 To x - 1
                        For j As Integer = 0 To y - 1

                            pixel = color_pic.GetPixel(i, j)
                            r = pixel.R : g = pixel.G : b = pixel.B

                            Select Case choice
                                Case 2
                                    p = CInt((r + g + b) / 3)
                                    result.SetPixel(i, j, Color.FromArgb(p, p, p))

                                Case 3
                                    result.SetPixel(i, j, Color.FromArgb(r, 0, 0))

                                Case 4
                                    result.SetPixel(i, j, Color.FromArgb(0, g, 0))

                                Case 5
                                    result.SetPixel(i, j, Color.FromArgb(0, 0, b))

                                Case 6
                                    p = CInt((r + g + b) / 3)
                                    If p > 128 Then
                                        result.SetPixel(i, j, Color.White)
                                    Else
                                        result.SetPixel(i, j, Color.Black)
                                    End If
                            End Select

                        Next
                    Next
                Case 7, 8
                    Dim scale As Integer = 8
                    Dim cropW As Integer = Math.Min(60, x)
                    Dim cropH As Integer = Math.Min(40, y)
                    Dim startX As Integer = (x - cropW) \ 2
                    Dim startY As Integer = (y - cropH) \ 2

                    result = New Bitmap(cropW * scale, cropH * scale)

                    Using gfx As Graphics = Graphics.FromImage(result)

                        If choice = 7 Then
                            gfx.InterpolationMode = InterpolationMode.NearestNeighbor
                        Else
                            gfx.InterpolationMode = InterpolationMode.Bilinear
                        End If

                        gfx.PixelOffsetMode = PixelOffsetMode.Half

                        gfx.DrawImage(color_pic,
                            New Rectangle(0, 0, result.Width, result.Height),
                            New Rectangle(startX, startY, cropW, cropH),
                            GraphicsUnit.Pixel)

                    End Using

            End Select

            If result IsNot Nothing Then
                Dim oldImage As Image = PictureBox2.Image
                PictureBox2.Image = result
                If oldImage IsNot Nothing Then oldImage.Dispose()
            End If

        End Using

    End Sub

End Class