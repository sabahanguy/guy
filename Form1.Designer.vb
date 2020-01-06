<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StateLabel As System.Windows.Forms.Label
        Dim MotorcycleLabel As System.Windows.Forms.Label
        Dim MotorcarLabel As System.Windows.Forms.Label
        Dim BusLabel As System.Windows.Forms.Label
        Dim TaxiLabel As System.Windows.Forms.Label
        Dim Hire___Drive_CarLabel As System.Windows.Forms.Label
        Dim Goods_VehicleLabel As System.Windows.Forms.Label
        Dim OthersLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database_2_hmDataSet = New PROJECT.database_2_hmDataSet()
        Me.Sheet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sheet1TableAdapter = New PROJECT.database_2_hmDataSetTableAdapters.Sheet1TableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorcycleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorcarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HireDriveCarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GoodsVehicleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableAdapterManager = New PROJECT.database_2_hmDataSetTableAdapters.TableAdapterManager()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.MotorcycleTextBox = New System.Windows.Forms.TextBox()
        Me.MotorcarTextBox = New System.Windows.Forms.TextBox()
        Me.BusTextBox = New System.Windows.Forms.TextBox()
        Me.TaxiTextBox = New System.Windows.Forms.TextBox()
        Me.Hire___Drive_CarTextBox = New System.Windows.Forms.TextBox()
        Me.Goods_VehicleTextBox = New System.Windows.Forms.TextBox()
        Me.OthersTextBox = New System.Windows.Forms.TextBox()
        StateLabel = New System.Windows.Forms.Label()
        MotorcycleLabel = New System.Windows.Forms.Label()
        MotorcarLabel = New System.Windows.Forms.Label()
        BusLabel = New System.Windows.Forms.Label()
        TaxiLabel = New System.Windows.Forms.Label()
        Hire___Drive_CarLabel = New System.Windows.Forms.Label()
        Goods_VehicleLabel = New System.Windows.Forms.Label()
        OthersLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_2_hmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(120, 118)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 40)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "HOME"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnDelete.Location = New System.Drawing.Point(140, 73)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 39)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSave.Location = New System.Drawing.Point(179, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 44)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(84, 23)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 44)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnContinue.Location = New System.Drawing.Point(24, 205)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(311, 33)
        Me.btnContinue.TabIndex = 21
        Me.btnContinue.Text = "LOAD GRAPH"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnLast.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.Location = New System.Drawing.Point(260, 162)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 37)
        Me.btnLast.TabIndex = 20
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnNext.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(179, 163)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 37)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnPrevious.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(105, 164)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 37)
        Me.btnPrevious.TabIndex = 18
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnFirst.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(24, 163)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 37)
        Me.btnFirst.TabIndex = 17
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFirst)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnLast)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnContinue)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(578, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 251)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPERATION"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.MotorcycleDataGridViewTextBoxColumn, Me.MotorcarDataGridViewTextBoxColumn, Me.BusDataGridViewTextBoxColumn, Me.TaxiDataGridViewTextBoxColumn, Me.HireDriveCarDataGridViewTextBoxColumn, Me.GoodsVehicleDataGridViewTextBoxColumn, Me.OthersDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Sheet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(907, 166)
        Me.DataGridView1.TabIndex = 28
        '
        'Database_2_hmDataSet
        '
        Me.Database_2_hmDataSet.DataSetName = "database_2_hmDataSet"
        Me.Database_2_hmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sheet1BindingSource
        '
        Me.Sheet1BindingSource.DataMember = "Sheet1"
        Me.Sheet1BindingSource.DataSource = Me.Database_2_hmDataSet
        '
        'Sheet1TableAdapter
        '
        Me.Sheet1TableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'MotorcycleDataGridViewTextBoxColumn
        '
        Me.MotorcycleDataGridViewTextBoxColumn.DataPropertyName = "Motorcycle"
        Me.MotorcycleDataGridViewTextBoxColumn.HeaderText = "Motorcycle"
        Me.MotorcycleDataGridViewTextBoxColumn.Name = "MotorcycleDataGridViewTextBoxColumn"
        '
        'MotorcarDataGridViewTextBoxColumn
        '
        Me.MotorcarDataGridViewTextBoxColumn.DataPropertyName = "Motorcar"
        Me.MotorcarDataGridViewTextBoxColumn.HeaderText = "Motorcar"
        Me.MotorcarDataGridViewTextBoxColumn.Name = "MotorcarDataGridViewTextBoxColumn"
        '
        'BusDataGridViewTextBoxColumn
        '
        Me.BusDataGridViewTextBoxColumn.DataPropertyName = "Bus"
        Me.BusDataGridViewTextBoxColumn.HeaderText = "Bus"
        Me.BusDataGridViewTextBoxColumn.Name = "BusDataGridViewTextBoxColumn"
        '
        'TaxiDataGridViewTextBoxColumn
        '
        Me.TaxiDataGridViewTextBoxColumn.DataPropertyName = "Taxi"
        Me.TaxiDataGridViewTextBoxColumn.HeaderText = "Taxi"
        Me.TaxiDataGridViewTextBoxColumn.Name = "TaxiDataGridViewTextBoxColumn"
        '
        'HireDriveCarDataGridViewTextBoxColumn
        '
        Me.HireDriveCarDataGridViewTextBoxColumn.DataPropertyName = "Hire & Drive Car"
        Me.HireDriveCarDataGridViewTextBoxColumn.HeaderText = "Hire & Drive Car"
        Me.HireDriveCarDataGridViewTextBoxColumn.Name = "HireDriveCarDataGridViewTextBoxColumn"
        '
        'GoodsVehicleDataGridViewTextBoxColumn
        '
        Me.GoodsVehicleDataGridViewTextBoxColumn.DataPropertyName = "Goods Vehicle"
        Me.GoodsVehicleDataGridViewTextBoxColumn.HeaderText = "Goods Vehicle"
        Me.GoodsVehicleDataGridViewTextBoxColumn.Name = "GoodsVehicleDataGridViewTextBoxColumn"
        '
        'OthersDataGridViewTextBoxColumn
        '
        Me.OthersDataGridViewTextBoxColumn.DataPropertyName = "Others"
        Me.OthersDataGridViewTextBoxColumn.HeaderText = "Others"
        Me.OthersDataGridViewTextBoxColumn.Name = "OthersDataGridViewTextBoxColumn"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(OthersLabel)
        Me.GroupBox1.Controls.Add(Me.OthersTextBox)
        Me.GroupBox1.Controls.Add(Goods_VehicleLabel)
        Me.GroupBox1.Controls.Add(Me.Goods_VehicleTextBox)
        Me.GroupBox1.Controls.Add(Hire___Drive_CarLabel)
        Me.GroupBox1.Controls.Add(Me.Hire___Drive_CarTextBox)
        Me.GroupBox1.Controls.Add(TaxiLabel)
        Me.GroupBox1.Controls.Add(Me.TaxiTextBox)
        Me.GroupBox1.Controls.Add(BusLabel)
        Me.GroupBox1.Controls.Add(Me.BusTextBox)
        Me.GroupBox1.Controls.Add(MotorcarLabel)
        Me.GroupBox1.Controls.Add(Me.MotorcarTextBox)
        Me.GroupBox1.Controls.Add(MotorcycleLabel)
        Me.GroupBox1.Controls.Add(Me.MotorcycleTextBox)
        Me.GroupBox1.Controls.Add(StateLabel)
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 251)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA INFORMATION"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Sheet1TableAdapter = Me.Sheet1TableAdapter
        Me.TableAdapterManager.UpdateOrder = PROJECT.database_2_hmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(193, 42)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(57, 21)
        StateLabel.TabIndex = 2
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "State", True))
        Me.StateTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(256, 39)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(179, 28)
        Me.StateTextBox.TabIndex = 3
        '
        'MotorcycleLabel
        '
        MotorcycleLabel.AutoSize = True
        MotorcycleLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotorcycleLabel.Location = New System.Drawing.Point(48, 93)
        MotorcycleLabel.Name = "MotorcycleLabel"
        MotorcycleLabel.Size = New System.Drawing.Size(96, 21)
        MotorcycleLabel.TabIndex = 3
        MotorcycleLabel.Text = "Motorcycle:"
        '
        'MotorcycleTextBox
        '
        Me.MotorcycleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Motorcycle", True))
        Me.MotorcycleTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotorcycleTextBox.Location = New System.Drawing.Point(150, 93)
        Me.MotorcycleTextBox.Name = "MotorcycleTextBox"
        Me.MotorcycleTextBox.Size = New System.Drawing.Size(100, 28)
        Me.MotorcycleTextBox.TabIndex = 4
        '
        'MotorcarLabel
        '
        MotorcarLabel.AutoSize = True
        MotorcarLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotorcarLabel.Location = New System.Drawing.Point(61, 130)
        MotorcarLabel.Name = "MotorcarLabel"
        MotorcarLabel.Size = New System.Drawing.Size(83, 21)
        MotorcarLabel.TabIndex = 4
        MotorcarLabel.Text = "Motorcar:"
        '
        'MotorcarTextBox
        '
        Me.MotorcarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Motorcar", True))
        Me.MotorcarTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotorcarTextBox.Location = New System.Drawing.Point(150, 127)
        Me.MotorcarTextBox.Name = "MotorcarTextBox"
        Me.MotorcarTextBox.Size = New System.Drawing.Size(100, 28)
        Me.MotorcarTextBox.TabIndex = 5
        '
        'BusLabel
        '
        BusLabel.AutoSize = True
        BusLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BusLabel.Location = New System.Drawing.Point(103, 164)
        BusLabel.Name = "BusLabel"
        BusLabel.Size = New System.Drawing.Size(41, 21)
        BusLabel.TabIndex = 6
        BusLabel.Text = "Bus:"
        '
        'BusTextBox
        '
        Me.BusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Bus", True))
        Me.BusTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusTextBox.Location = New System.Drawing.Point(150, 161)
        Me.BusTextBox.Name = "BusTextBox"
        Me.BusTextBox.Size = New System.Drawing.Size(100, 28)
        Me.BusTextBox.TabIndex = 7
        '
        'TaxiLabel
        '
        TaxiLabel.AutoSize = True
        TaxiLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TaxiLabel.Location = New System.Drawing.Point(96, 198)
        TaxiLabel.Name = "TaxiLabel"
        TaxiLabel.Size = New System.Drawing.Size(48, 21)
        TaxiLabel.TabIndex = 8
        TaxiLabel.Text = "Taxi:"
        '
        'TaxiTextBox
        '
        Me.TaxiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Taxi", True))
        Me.TaxiTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxiTextBox.Location = New System.Drawing.Point(150, 195)
        Me.TaxiTextBox.Name = "TaxiTextBox"
        Me.TaxiTextBox.Size = New System.Drawing.Size(100, 28)
        Me.TaxiTextBox.TabIndex = 9
        '
        'Hire___Drive_CarLabel
        '
        Hire___Drive_CarLabel.AutoSize = True
        Hire___Drive_CarLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Hire___Drive_CarLabel.Location = New System.Drawing.Point(305, 96)
        Hire___Drive_CarLabel.Name = "Hire___Drive_CarLabel"
        Hire___Drive_CarLabel.Size = New System.Drawing.Size(130, 21)
        Hire___Drive_CarLabel.TabIndex = 10
        Hire___Drive_CarLabel.Text = "Hire & Drive Car:"
        '
        'Hire___Drive_CarTextBox
        '
        Me.Hire___Drive_CarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Hire & Drive Car", True))
        Me.Hire___Drive_CarTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hire___Drive_CarTextBox.Location = New System.Drawing.Point(441, 93)
        Me.Hire___Drive_CarTextBox.Name = "Hire___Drive_CarTextBox"
        Me.Hire___Drive_CarTextBox.Size = New System.Drawing.Size(100, 28)
        Me.Hire___Drive_CarTextBox.TabIndex = 11
        '
        'Goods_VehicleLabel
        '
        Goods_VehicleLabel.AutoSize = True
        Goods_VehicleLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Goods_VehicleLabel.Location = New System.Drawing.Point(318, 130)
        Goods_VehicleLabel.Name = "Goods_VehicleLabel"
        Goods_VehicleLabel.Size = New System.Drawing.Size(117, 21)
        Goods_VehicleLabel.TabIndex = 12
        Goods_VehicleLabel.Text = "Goods Vehicle:"
        '
        'Goods_VehicleTextBox
        '
        Me.Goods_VehicleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Goods Vehicle", True))
        Me.Goods_VehicleTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Goods_VehicleTextBox.Location = New System.Drawing.Point(441, 127)
        Me.Goods_VehicleTextBox.Name = "Goods_VehicleTextBox"
        Me.Goods_VehicleTextBox.Size = New System.Drawing.Size(100, 28)
        Me.Goods_VehicleTextBox.TabIndex = 13
        '
        'OthersLabel
        '
        OthersLabel.AutoSize = True
        OthersLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OthersLabel.Location = New System.Drawing.Point(368, 164)
        OthersLabel.Name = "OthersLabel"
        OthersLabel.Size = New System.Drawing.Size(67, 21)
        OthersLabel.TabIndex = 14
        OthersLabel.Text = "Others:"
        '
        'OthersTextBox
        '
        Me.OthersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Others", True))
        Me.OthersTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OthersTextBox.Location = New System.Drawing.Point(441, 161)
        Me.OthersTextBox.Name = "OthersTextBox"
        Me.OthersTextBox.Size = New System.Drawing.Size(100, 28)
        Me.OthersTextBox.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1067, 487)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Felix Titling", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "TOTAL MOTOR VEHICLES BY TYPE AND STATE IN 2016"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_2_hmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub NewMethod1()
        NewMethod()        'Database1DataSetBindingSource
    End Sub

    Private Sub NewMethod()
        Dim v = AddHandlerOthersLabel.Click
    End Sub

    Private Function OthersLabel_Click() As Object
        Throw New NotImplementedException()
    End Function
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database_2_hmDataSet As database_2_hmDataSet
    Friend WithEvents Sheet1BindingSource As BindingSource
    Friend WithEvents Sheet1TableAdapter As database_2_hmDataSetTableAdapters.Sheet1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotorcycleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotorcarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HireDriveCarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GoodsVehicleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OthersTextBox As TextBox
    Friend WithEvents Goods_VehicleTextBox As TextBox
    Friend WithEvents Hire___Drive_CarTextBox As TextBox
    Friend WithEvents TaxiTextBox As TextBox
    Friend WithEvents BusTextBox As TextBox
    Friend WithEvents MotorcarTextBox As TextBox
    Friend WithEvents MotorcycleTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents TableAdapterManager As database_2_hmDataSetTableAdapters.TableAdapterManager
    Public Property AddHandlerOthersLabel As Object
End Class
