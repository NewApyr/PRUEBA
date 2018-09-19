Public Class Form1
    Dim x, y As Integer
    Dim m, n As Integer
    'Matriz A con x Filas   y Columnas 
    'Matriz B m filas y n columunas
    Dim MatrizA(5, 5) As Integer
    Dim MatrizB(5, 5) As Integer
    Dim MatrizC(5, 5) As Integer

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 1 To x Step 1
            For j = 1 To y Step 1
                MatrizA(i, j) = InputBox("Introduzca los valores Matriz A ( " & x & " , " & y & " ) " & "   posicion   " & i & " , " & j)
                ListBox1.Items.Add("Posiciones A: ( " & i & " , " & j & ") =  " & MatrizA(i, j))
            Next
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To m Step 1
            For j = 1 To n Step 1
                MatrizB(i, j) = InputBox("Introduzca los valores Matriz B ( " & m & " , " & n & " )  " & "  posicion   " & i & " , " & j)
                ListBox2.Items.Add("Posiciones B: ( " & i & " , " & j & ") =  " & MatrizB(i, j))
            Next
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 1 To x Step 1
            For j = 1 To n Step 1
                MatrizC(i, j) = 0
            Next
        Next

        For i = 1 To x Step 1
            For j = 1 To n Step 1
                For z = 1 To m Step 1
                    MatrizC(i, j) += MatrizA(i, z) * MatrizB(z, j)
                Next
            Next
        Next

        For i = 1 To x Step 1
            For j = 1 To n Step 1
                ListBox3.Items.Add(MatrizC(i, j) & "  ")
            Next
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Numeric1A.Minimum = 1
        Numeric2A.Minimum = 1

        Numeric1A.Maximum = 5
        Numeric2A.Maximum = 5


        Numeric1B.Minimum = 1
        Numeric2B.Minimum = 1

        Numeric1B.Maximum = 5
        Numeric2B.Maximum = 5

    End Sub

    Private Sub Numeric1A_ValueChanged(sender As Object, e As EventArgs) Handles Numeric1A.ValueChanged
        x = Numeric1A.Value
    End Sub

    Private Sub Numeric2A_ValueChanged(sender As Object, e As EventArgs) Handles Numeric2A.ValueChanged
        y = Numeric2A.Value
    End Sub

    Private Sub Numeric1B_ValueChanged(sender As Object, e As EventArgs) Handles Numeric1B.ValueChanged
        m = Numeric1B.Value

    End Sub

    Private Sub Numeric2B_ValueChanged(sender As Object, e As EventArgs) Handles Numeric2B.ValueChanged
        n = Numeric2B.Value
    End Sub
End Class
