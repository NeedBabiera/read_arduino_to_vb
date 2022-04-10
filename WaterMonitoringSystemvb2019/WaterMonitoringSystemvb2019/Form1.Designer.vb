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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dateTime = New System.Windows.Forms.Timer(Me.components)
        Me.txtDateTime = New System.Windows.Forms.TextBox()
        Me.DGV_WaterData = New System.Windows.Forms.DataGridView()
        Me.temp_read = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phlev_read = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turb_read = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phlev_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turb_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_read = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_clean = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DGV_WaterData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1339, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'dateTime
        '
        '
        'txtDateTime
        '
        Me.txtDateTime.Location = New System.Drawing.Point(13, 59)
        Me.txtDateTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.Size = New System.Drawing.Size(1339, 26)
        Me.txtDateTime.TabIndex = 2
        '
        'DGV_WaterData
        '
        Me.DGV_WaterData.AllowUserToAddRows = False
        Me.DGV_WaterData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_WaterData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_WaterData.ColumnHeadersHeight = 35
        Me.DGV_WaterData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.temp_read, Me.phlev_read, Me.turb_read, Me.temp_desc, Me.phlev_desc, Me.turb_desc, Me.date_read, Me.is_clean})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_WaterData.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_WaterData.Location = New System.Drawing.Point(13, 95)
        Me.DGV_WaterData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_WaterData.Name = "DGV_WaterData"
        Me.DGV_WaterData.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_WaterData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_WaterData.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_WaterData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_WaterData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_WaterData.RowTemplate.Height = 35
        Me.DGV_WaterData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_WaterData.Size = New System.Drawing.Size(1339, 480)
        Me.DGV_WaterData.TabIndex = 3
        '
        'temp_read
        '
        Me.temp_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.temp_read.DataPropertyName = "temp_read"
        Me.temp_read.HeaderText = "Temperature"
        Me.temp_read.Name = "temp_read"
        Me.temp_read.ReadOnly = True
        Me.temp_read.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.temp_read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'phlev_read
        '
        Me.phlev_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phlev_read.DataPropertyName = "phlev_read"
        Me.phlev_read.HeaderText = "PH Level"
        Me.phlev_read.Name = "phlev_read"
        Me.phlev_read.ReadOnly = True
        Me.phlev_read.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.phlev_read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'turb_read
        '
        Me.turb_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.turb_read.DataPropertyName = "turb_read"
        Me.turb_read.HeaderText = "Turbidity"
        Me.turb_read.Name = "turb_read"
        Me.turb_read.ReadOnly = True
        Me.turb_read.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.turb_read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'temp_desc
        '
        Me.temp_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.temp_desc.DataPropertyName = "temp_desc"
        Me.temp_desc.HeaderText = "Temp Description"
        Me.temp_desc.Name = "temp_desc"
        Me.temp_desc.ReadOnly = True
        Me.temp_desc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.temp_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'phlev_desc
        '
        Me.phlev_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phlev_desc.DataPropertyName = "phlev_desc"
        Me.phlev_desc.HeaderText = "PH Description"
        Me.phlev_desc.Name = "phlev_desc"
        Me.phlev_desc.ReadOnly = True
        Me.phlev_desc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.phlev_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'turb_desc
        '
        Me.turb_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.turb_desc.DataPropertyName = "turb_desc"
        Me.turb_desc.HeaderText = "Turb Description"
        Me.turb_desc.Name = "turb_desc"
        Me.turb_desc.ReadOnly = True
        Me.turb_desc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.turb_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_read
        '
        Me.date_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.date_read.DataPropertyName = "date_read"
        Me.date_read.HeaderText = "Date"
        Me.date_read.Name = "date_read"
        Me.date_read.ReadOnly = True
        Me.date_read.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.date_read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'is_clean
        '
        Me.is_clean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.is_clean.DataPropertyName = "is_clean"
        Me.is_clean.HeaderText = "CLEAN"
        Me.is_clean.Name = "is_clean"
        Me.is_clean.ReadOnly = True
        Me.is_clean.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.DGV_WaterData)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV_WaterData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents dateTime As Windows.Forms.Timer
    Friend WithEvents txtDateTime As Windows.Forms.TextBox
    Friend WithEvents DGV_WaterData As Windows.Forms.DataGridView
    Friend WithEvents temp_read As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phlev_read As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turb_read As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents temp_desc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phlev_desc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turb_desc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_read As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents is_clean As Windows.Forms.DataGridViewCheckBoxColumn
End Class
