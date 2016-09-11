Public Class MainForm
    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHombre.Click
        btnHombre.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorio.ForeColor = Color.Black



    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.Black
        btnAccesorio.ForeColor = Color.Black
    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorio.ForeColor = Color.Black
    End Sub

    Private Sub btnAccesorio_Click(sender As Object, e As EventArgs) Handles btnAccesorio.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorio.ForeColor = Color.SteelBlue
    End Sub

    Private Sub btncamisa_Click(sender As Object, e As EventArgs) Handles lblcamisa.Click
        lbltallas.Text = "Camisa de Algodon"
        lblprecio.Text = " $ 120 "
        pbcover.Image = ilProductos.Images.Item(0)

    End Sub

    Private Sub lblblazer_Click(sender As Object, e As EventArgs) Handles lblblazer.Click
        lbltallas.Text = "Blazer de Mezcla de lana"
        lblprecio.Text = " $ 240 "
        pbcover.Image = ilProductos.Images.Item(1)
    End Sub

    Private Sub lbljersey_Click(sender As Object, e As EventArgs) Handles lbljersey.Click
        lbltallas.Text = "Jersey Cuello Pico"
        lblprecio.Text = " $ 160 "
        pbcover.Image = ilProductos.Images.Item(2)
    End Sub

    Private Sub lblpolo_Click(sender As Object, e As EventArgs) Handles lblpolo.Click
        lbltallas.Text = "Polo Cuello Redondo"
        lblprecio.Text = " $ 70 "
        pbcover.Image = ilProductos.Images.Item(3)
    End Sub
End Class