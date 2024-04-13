<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        ProcesosToolStripMenuItem = New ToolStripMenuItem()
        SeptimoGradoToolStripMenuItem = New ToolStripMenuItem()
        MatematicasToolStripMenuItem = New ToolStripMenuItem()
        LenguajeToolStripMenuItem = New ToolStripMenuItem()
        CienciasToolStripMenuItem = New ToolStripMenuItem()
        SocialesToolStripMenuItem = New ToolStripMenuItem()
        OctavoGradoToolStripMenuItem = New ToolStripMenuItem()
        NovenoGradoToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        UtilitariosToolStripMenuItem = New ToolStripMenuItem()
        CalculadoraToolStripMenuItem = New ToolStripMenuItem()
        NotepadToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        CerrarProgramaToolStripMenuItem = New ToolStripMenuItem()
        DateTimePicker1 = New DateTimePicker()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProcesosToolStripMenuItem, MantenimientoToolStripMenuItem, UtilitariosToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(62, 18)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(392, 29)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProcesosToolStripMenuItem
        ' 
        ProcesosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SeptimoGradoToolStripMenuItem, OctavoGradoToolStripMenuItem, NovenoGradoToolStripMenuItem})
        ProcesosToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        ProcesosToolStripMenuItem.Size = New Size(89, 25)
        ProcesosToolStripMenuItem.Text = "Procesos"
        ' 
        ' SeptimoGradoToolStripMenuItem
        ' 
        SeptimoGradoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MatematicasToolStripMenuItem, LenguajeToolStripMenuItem, CienciasToolStripMenuItem, SocialesToolStripMenuItem})
        SeptimoGradoToolStripMenuItem.Name = "SeptimoGradoToolStripMenuItem"
        SeptimoGradoToolStripMenuItem.Size = New Size(194, 26)
        SeptimoGradoToolStripMenuItem.Text = "Septimo Grado"
        ' 
        ' MatematicasToolStripMenuItem
        ' 
        MatematicasToolStripMenuItem.Name = "MatematicasToolStripMenuItem"
        MatematicasToolStripMenuItem.Size = New Size(178, 26)
        MatematicasToolStripMenuItem.Text = "Matematicas"
        ' 
        ' LenguajeToolStripMenuItem
        ' 
        LenguajeToolStripMenuItem.Name = "LenguajeToolStripMenuItem"
        LenguajeToolStripMenuItem.Size = New Size(178, 26)
        LenguajeToolStripMenuItem.Text = "Lenguaje"
        ' 
        ' CienciasToolStripMenuItem
        ' 
        CienciasToolStripMenuItem.Name = "CienciasToolStripMenuItem"
        CienciasToolStripMenuItem.Size = New Size(178, 26)
        CienciasToolStripMenuItem.Text = "Ciencias"
        ' 
        ' SocialesToolStripMenuItem
        ' 
        SocialesToolStripMenuItem.Name = "SocialesToolStripMenuItem"
        SocialesToolStripMenuItem.Size = New Size(178, 26)
        SocialesToolStripMenuItem.Text = "Sociales"
        ' 
        ' OctavoGradoToolStripMenuItem
        ' 
        OctavoGradoToolStripMenuItem.Name = "OctavoGradoToolStripMenuItem"
        OctavoGradoToolStripMenuItem.Size = New Size(194, 26)
        OctavoGradoToolStripMenuItem.Text = "Octavo Grado"
        ' 
        ' NovenoGradoToolStripMenuItem
        ' 
        NovenoGradoToolStripMenuItem.Name = "NovenoGradoToolStripMenuItem"
        NovenoGradoToolStripMenuItem.Size = New Size(194, 26)
        NovenoGradoToolStripMenuItem.Text = "Noveno Grado"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(141, 25)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        ' 
        ' UtilitariosToolStripMenuItem
        ' 
        UtilitariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CalculadoraToolStripMenuItem, NotepadToolStripMenuItem})
        UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        UtilitariosToolStripMenuItem.Size = New Size(98, 25)
        UtilitariosToolStripMenuItem.Text = "Utilitarios"
        ' 
        ' CalculadoraToolStripMenuItem
        ' 
        CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        CalculadoraToolStripMenuItem.Size = New Size(180, 26)
        CalculadoraToolStripMenuItem.Text = "Calculadora"
        ' 
        ' NotepadToolStripMenuItem
        ' 
        NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        NotepadToolStripMenuItem.Size = New Size(180, 26)
        NotepadToolStripMenuItem.Text = "Notepad"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CerrarProgramaToolStripMenuItem})
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(56, 25)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' CerrarProgramaToolStripMenuItem
        ' 
        CerrarProgramaToolStripMenuItem.Name = "CerrarProgramaToolStripMenuItem"
        CerrarProgramaToolStripMenuItem.Size = New Size(205, 26)
        CerrarProgramaToolStripMenuItem.Text = "Cerrar Programa"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePicker1.Location = New Point(588, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 1
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DateTimePicker1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Sistema de calculo de notas"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeptimoGradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatematicasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LenguajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CienciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OctavoGradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovenoGradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilitariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
