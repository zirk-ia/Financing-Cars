<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnClear = New Button()
        btnCalculate = New Button()
        cmbCars = New ComboBox()
        dgvPayments = New DataGridView()
        btnExit = New Button()
        lblDisplayCar = New Label()
        pbxCars = New PictureBox()
        CType(dgvPayments, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxCars, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(206), CByte(14), CByte(14))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.Control
        btnClear.Location = New Point(553, 279)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(205, 40)
        btnClear.TabIndex = 19
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(206), CByte(14), CByte(14))
        btnCalculate.FlatAppearance.BorderSize = 0
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.ForeColor = SystemColors.Control
        btnCalculate.Location = New Point(553, 220)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(205, 40)
        btnCalculate.TabIndex = 18
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' cmbCars
        ' 
        cmbCars.ForeColor = SystemColors.MenuText
        cmbCars.FormattingEnabled = True
        cmbCars.Items.AddRange(New Object() {"Toyota Vios", "Honda Civic", "Hyundai Accent", "Mitsubishi Mirage"})
        cmbCars.Location = New Point(248, 220)
        cmbCars.Name = "cmbCars"
        cmbCars.Size = New Size(227, 28)
        cmbCars.TabIndex = 17
        cmbCars.Text = "Please Select"
        ' 
        ' dgvPayments
        ' 
        dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvPayments.DefaultCellStyle = DataGridViewCellStyle1
        dgvPayments.Location = New Point(137, 334)
        dgvPayments.Name = "dgvPayments"
        dgvPayments.RowHeadersWidth = 51
        dgvPayments.Size = New Size(558, 259)
        dgvPayments.TabIndex = 16
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(206), CByte(14), CByte(14))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = SystemColors.Control
        btnExit.Location = New Point(553, 601)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(205, 40)
        btnExit.TabIndex = 20
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblDisplayCar
        ' 
        lblDisplayCar.AutoSize = True
        lblDisplayCar.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDisplayCar.Location = New Point(139, 293)
        lblDisplayCar.Name = "lblDisplayCar"
        lblDisplayCar.Size = New Size(0, 21)
        lblDisplayCar.TabIndex = 21
        ' 
        ' pbxCars
        ' 
        pbxCars.BackColor = Color.Transparent
        pbxCars.BackgroundImageLayout = ImageLayout.Zoom
        pbxCars.ErrorImage = My.Resources.Resources.Honda_Civic
        pbxCars.Location = New Point(523, 32)
        pbxCars.Name = "pbxCars"
        pbxCars.Size = New Size(235, 137)
        pbxCars.TabIndex = 22
        pbxCars.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(832, 653)
        Controls.Add(pbxCars)
        Controls.Add(lblDisplayCar)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(cmbCars)
        Controls.Add(dgvPayments)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(dgvPayments, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxCars, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents cmbCars As ComboBox
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDisplayCar As Label
    Friend WithEvents pbxCars As PictureBox


End Class
