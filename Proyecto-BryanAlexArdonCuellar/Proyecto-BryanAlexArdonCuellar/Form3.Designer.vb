<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel4 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        TX = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(773, 123)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(604, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 105)
        Label2.TabIndex = 1
        Label2.Text = "Act 1 = 25%" & vbCrLf & "Act 2 = 25%" & vbCrLf & "Act 3 = 15%" & vbCrLf & "TareaExtra = 5%" & vbCrLf & "ExamenFinal = 30%"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(390, 32)
        Label1.TabIndex = 0
        Label1.Text = "Calculo de notas de Matematicas"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(4, 132)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(773, 115)
        Panel2.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"AQUINO MATA, KAREN GISSELA", "ARDÓN CUELLAR, BRYAN ALEXIS", "ARDÓN CUELLAR, KRISSIA ALEJANDRA", "BENITEZ FUNES, GERSON STANLEY", "BONILLA MÉNDEZ, ÁNGELA MERCEDES", "CARLOS CARDOZA, ESMERALDA ELIZABETH", "CORADO HERNÁNDEZ, JOHANA LIZZETTE", "CORTEZ PATRIZ, ADA SOFIA", "CUADRA GARCÍA, MARYORY LILIBETH", "DELGADILLO MARTÍNEZ, ERICK MAURICIO", "ESCOBAR GUTIÉRREZ, PAÚL HENDRIX", "FLORES ALVARADO, MOISÉS ISAAC", "FLORES LÓPEZ, CARLOS EDUARDO", "GARCÍA MUSUN, KEILY MICHELLE", "GUZMÁN ASCENCIO, KEVIN ENRIQUE", "HENRIQUEZ OVIEDO, JAIME JOSÉ", "HERNÁNDEZ CARÍAS, ANDERSSON JOMAR", "HERRERA DELGADO, GEORGINA JULISSA", "JIMÉNEZ ZACAPA, MARITZA ESPERANZA", "LENA MUNDO, GERSON ISAAC", "LÓPEZ CERÉN, EDUARDO ANTONIO", "MÁRQUEZ LIMA, NAOMI ABIGAIL", "MARTÍNEZ GRANADOS, FERNANDO GABRIEL", "MASIN AGUILAR, FÁTIMA BEATRIZ", "MORALES ZACAPA, CRISTIAN OMAR", "PERALTA BARILLAS, CRISTIAN OMAR", "PÉREZ AGUILAR, DARLIN NATALIA", "RAMOS MORALES, MILTON ANTONIO", "RIVERA CRUZ, SANDRA ELIZABETH", "SÁNCHEZ BELTRÁN, ADRIANA DANIELA", "SÁNCHEZ JIMÉNEZ, EVELYN JOHANA", "SÁNCHEZ MÉNDEZ, FÁTIMA FIORELLA", "SANTOS LÓPEZ, ANGELINE JARITZA", "SERMEÑO MOLINA, HENRY ALBERTO", "ZALAMA SURIANO, CLARISSA MARIBEL"})
        ComboBox1.Location = New Point(100, 57)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(296, 33)
        ComboBox1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(629, 39)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 36)
        Button1.TabIndex = 6
        Button1.Text = "Continuar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(456, 57)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(136, 33)
        TextBox2.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(402, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 25)
        Label6.TabIndex = 3
        Label6.Text = "NIE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(421, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(201, 25)
        Label5.TabIndex = 2
        Label5.Text = "Materia: Matematicas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 25)
        Label4.TabIndex = 1
        Label4.Text = "Alumno:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(100, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 25)
        Label3.TabIndex = 0
        Label3.Text = "Seccion: Septimo Grado"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel3.Location = New Point(5, 253)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(442, 163)
        Panel3.TabIndex = 2
        Panel3.Visible = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(330, 121)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 35)
        Button3.TabIndex = 16
        Button3.Text = "Limpiar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(218, 121)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 35)
        Button2.TabIndex = 15
        Button2.Text = "Calcular"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(277, 76)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 33)
        TextBox7.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(277, 37)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 33)
        TextBox6.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(85, 115)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 33)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(85, 76)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 33)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(85, 40)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 33)
        TextBox3.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(191, 84)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 25)
        Label12.TabIndex = 9
        Label12.Text = "ExFinal"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(191, 43)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 25)
        Label11.TabIndex = 8
        Label11.Text = "TareaEx"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 118)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 25)
        Label10.TabIndex = 7
        Label10.Text = "Act3"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(9, 80)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 25)
        Label9.TabIndex = 6
        Label9.Text = "Act2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(9, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 25)
        Label8.TabIndex = 5
        Label8.Text = "Act1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(127, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(160, 25)
        Label7.TabIndex = 4
        Label7.Text = "Ingrese las notas"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label13)
        Panel4.Enabled = False
        Panel4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel4.Location = New Point(453, 253)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(324, 163)
        Panel4.TabIndex = 3
        Panel4.Visible = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(180, 74)
        Button6.Name = "Button6"
        Button6.Size = New Size(125, 37)
        Button6.TabIndex = 6
        Button6.Text = "Imprimir"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(80, 118)
        Button5.Name = "Button5"
        Button5.Size = New Size(164, 35)
        Button5.TabIndex = 5
        Button5.Text = "Otro Registro"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(7, 74)
        Button4.Name = "Button4"
        Button4.Size = New Size(125, 37)
        Button4.TabIndex = 4
        Button4.Text = "Agregar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(92, 37)
        Label16.Name = "Label16"
        Label16.Size = New Size(81, 25)
        Label16.TabIndex = 3
        Label16.Text = "Label16"
        Label16.Visible = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(129, 3)
        Label15.Name = "Label15"
        Label15.Size = New Size(81, 25)
        Label15.TabIndex = 2
        Label15.Text = "Label15"
        Label15.Visible = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(7, 37)
        Label14.Name = "Label14"
        Label14.Size = New Size(76, 25)
        Label14.TabIndex = 1
        Label14.Text = "Estado:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(7, 3)
        Label13.Name = "Label13"
        Label13.Size = New Size(105, 25)
        Label13.TabIndex = 0
        Label13.Text = "Promedio:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, TX, Column6, Column7, Column8})
        DataGridView1.Location = New Point(4, 422)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(773, 153)
        DataGridView1.TabIndex = 4
        DataGridView1.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NIE"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Alumno"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Act1"
        Column3.Name = "Column3"
        Column3.Width = 50
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Act2"
        Column4.Name = "Column4"
        Column4.Width = 50
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Act3"
        Column5.Name = "Column5"
        Column5.Width = 50
        ' 
        ' TX
        ' 
        TX.HeaderText = "TareaEx"
        TX.Name = "TX"
        TX.Width = 60
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "ExFinal"
        Column6.Name = "Column6"
        Column6.Width = 60
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Promedio"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Estado"
        Column8.Name = "Column8"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(779, 514)
        Controls.Add(DataGridView1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.Manual
        Text = "Calculo de Matematicas"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TX As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
