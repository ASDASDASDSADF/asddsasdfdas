Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Tienes que seleccionar a un alumno para continuar.")
        Else
            Dim msj As String
            msj = "¿Estás seguro que deseas continuar con: " & ComboBox1.Text

            Dim result As DialogResult
            result = MessageBox.Show(msj, "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Panel2.Enabled = False
                Panel3.Visible = True
                Panel3.Enabled = True
            Else
            End If


        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "AQUINO MATA, KAREN GISSELA" Then
            TextBox2.Text = "00001"
        End If
        If ComboBox1.SelectedItem = "ARDÓN CUELLAR, BRYAN ALEXIS" Then
            TextBox2.Text = "00002"
        End If
        If ComboBox1.SelectedItem = "ARDÓN CUELLAR, KRISSIA ALEJANDRA" Then
            TextBox2.Text = "00003"
        End If
        If ComboBox1.SelectedItem = "BENITEZ FUNES, GERSON STANLEY" Then
            TextBox2.Text = "00004"
        End If
        If ComboBox1.SelectedItem = "BONILLA MÉNDEZ, ÁNGELA MERCEDES" Then
            TextBox2.Text = "00005"
        End If
        If ComboBox1.SelectedItem = "CARLOS CARDOZA, ESMERALDA ELIZABETH" Then
            TextBox2.Text = "00006"
        End If
        If ComboBox1.SelectedItem = "CORADO HERNÁNDEZ, JOHANA LIZZETTE" Then
            TextBox2.Text = "00007"
        End If
        If ComboBox1.SelectedItem = "CORTEZ PATRIZ, ADA SOFIA" Then
            TextBox2.Text = "00008"
        End If
        If ComboBox1.SelectedItem = "CUADRA GARCÍA, MARYORY LILIBETH" Then
            TextBox2.Text = "00009"
        End If
        If ComboBox1.SelectedItem = "DELGADILLO MARTÍNEZ, ERICK MAURICIO" Then
            TextBox2.Text = "00010"
        End If
        If ComboBox1.SelectedItem = "ESCOBAR GUTIÉRREZ, PAÚL HENDRIX" Then
            TextBox2.Text = "00011"
        End If
        If ComboBox1.SelectedItem = "FLORES ALVARADO, MOISÉS ISAAC" Then
            TextBox2.Text = "00012"
        End If
        If ComboBox1.SelectedItem = "FLORES LÓPEZ, CARLOS EDUARDO" Then
            TextBox2.Text = "000013"
        End If
        If ComboBox1.SelectedItem = "GARCÍA MUSUN, KEILY MICHELLE" Then
            TextBox2.Text = "00014"
        End If
        If ComboBox1.SelectedItem = "GUZMÁN ASCENCIO, KEVIN ENRIQUE" Then
            TextBox2.Text = "00015"
        End If
        If ComboBox1.SelectedItem = "HENRIQUEZ OVIEDO, JAIME JOSÉ" Then
            TextBox2.Text = "00016"
        End If
        If ComboBox1.SelectedItem = "HERNÁNDEZ CARÍAS, ANDERSSON JOMAR" Then
            TextBox2.Text = "00017"
        End If
        If ComboBox1.SelectedItem = "HERRERA DELGADO, GEORGINA JULISSA" Then
            TextBox2.Text = "00018"
        End If
        If ComboBox1.SelectedItem = "JIMÉNEZ ZACAPA, MARITZA ESPERANZA" Then
            TextBox2.Text = "00019"
        End If
        If ComboBox1.SelectedItem = "LENA MUNDO, GERSON ISAAC" Then
            TextBox2.Text = "00020"
        End If
        If ComboBox1.SelectedItem = "LÓPEZ CERÉN, EDUARDO ANTONIO" Then
            TextBox2.Text = "00021"
        End If
        If ComboBox1.SelectedItem = "MÁRQUEZ LIMA, NAOMI ABIGAIL" Then
            TextBox2.Text = "00022"
        End If
        If ComboBox1.SelectedItem = "MARTÍNEZ GRANADOS, FERNANDO GABRIEL" Then
            TextBox2.Text = "00023"
        End If
        If ComboBox1.SelectedItem = "MASIN AGUILAR, FÁTIMA BEATRIZ" Then
            TextBox2.Text = "00024"
        End If
        If ComboBox1.SelectedItem = "MORALES ZACAPA, CRISTIAN OMAR" Then
            TextBox2.Text = "00025"
        End If
        If ComboBox1.SelectedItem = "PÉREZ AGUILAR, DARLIN NATALIA" Then
            TextBox2.Text = "00026"
        End If
        If ComboBox1.SelectedItem = "RAMOS MORALES, MILTON ANTONIO" Then
            TextBox2.Text = "00027"
        End If
        If ComboBox1.SelectedItem = "RIVERA CRUZ, SANDRA ELIZABETH" Then
            TextBox2.Text = "00028"
        End If
        If ComboBox1.SelectedItem = "SÁNCHEZ BELTRÁN, ADRIANA DANIELA" Then
            TextBox2.Text = "00029"
        End If
        If ComboBox1.SelectedItem = "SÁNCHEZ JIMÉNEZ, EVELYN JOHANA" Then
            TextBox2.Text = "00030"
        End If
        If ComboBox1.SelectedItem = "SÁNCHEZ MÉNDEZ, FÁTIMA FIORELLA" Then
            TextBox2.Text = "00031"
        End If
        If ComboBox1.SelectedItem = "SANTOS LÓPEZ, ANGELINE JARITZA" Then
            TextBox2.Text = "00032"
        End If
        If ComboBox1.SelectedItem = "SERMEÑO MOLINA, HENRY ALBERTO" Then
            TextBox2.Text = "00033"
        End If
        If ComboBox1.SelectedItem = "ZALAMA SURIANO, CLARISSA MARIBEL" Then
            TextBox2.Text = "00034"
        End If
        If ComboBox1.SelectedItem = "LENA MUNDO, GERSON ISAAC" Then
            TextBox2.Text = "00035"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(TextBox4.Text) Or String.IsNullOrEmpty(TextBox5.Text) Or String.IsNullOrEmpty(TextBox6.Text) Or String.IsNullOrEmpty(TextBox7.Text) Then
            MsgBox("LLena todas las cajitas de texto con las notas.")
        Else
            Dim act1, act2, act3, tareaex, exf, result
            act1 = Val(TextBox3.Text)
            act2 = Val(TextBox4.Text)
            act3 = Val(TextBox5.Text)
            tareaex = Val(TextBox6.Text)
            exf = Val(TextBox7.Text)
            result = act1 * 0.1 + act1 * 0.1 + act3 * 0.1 + tareaex * 0.2 + exf * 0.5

            Label15.Text = result

            If Label15.Text > 6 Then
                Label16.Text = "Aprobado"
            Else
                Label16.Text = "Reprobado"
            End If
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Panel3.Enabled = False
            Panel4.Enabled = True
            Panel4.Visible = True
            DataGridView1.Visible = True
            Label15.Visible = True
            Label16.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.Add(TextBox2.Text, ComboBox1.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, Label15.Text, Label16.Text)
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel2.Enabled = True
        ComboBox1.SelectedIndex = -1
        Panel3.Enabled = False
        Panel4.Enabled = False
        TextBox2.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox3.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Panel2.Enabled = True
        ComboBox1.SelectedIndex = -1
        Panel3.Enabled = False
        Panel4.Enabled = False
        TextBox2.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox3.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        DataGridView1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim datos, archivo As Object
        datos = CreateObject("Scripting.FileSystemObject")
        archivo = datos.createtextfile("Septimo/Ciencias/Imprimir")
        archivo.writeline("                                                INSTITUTO NACIONAL THOMAS JEFFERSON")
        archivo.writeline("              ASIGNATURA: CIENCIAS                                        SECCIÓN: SEPTIMO GRADO")
        archivo.writeline(String.Format("{0} {1} {2} {3}", "              ESTUDIANTE:", ComboBox1.SelectedItem, "                                                                                              NIE:", TextBox2.Text))
        archivo.writeline(String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} ", "ACTIVIDAD 1:", TextBox3.Text, "                    ACTIVIDAD 2:", TextBox4.Text, "                    ACTIVIDAD 3:", TextBox5.Text, "                    TAREA EXTRA:", TextBox6.Text, "                    EXAMEN FINAL:", TextBox7.Text))
        archivo.writeline(String.Format("{0} {1} {2} {3}", "                       PROMEDIO:", Label15.Text, "                                                                              ESTADO:", Label16.Text))
        Process.Start("notepad.exe", "Septimo/Ciencias/Imprimir")
        archivo.close()
        Button6.Enabled = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class