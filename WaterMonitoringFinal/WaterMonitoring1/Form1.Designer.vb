<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_WaterData = New System.Windows.Forms.DataGridView
        Me.temp_read = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.phlev_read = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.turb_read = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.temp_desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.phlev_desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.turb_desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.date_read = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.is_clean = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dateTime = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DGV_WaterData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_WaterData
        '
        Me.DGV_WaterData.AllowUserToAddRows = False
        Me.DGV_WaterData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_WaterData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_WaterData.BackgroundColor = System.Drawing.Color.White
        Me.DGV_WaterData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_WaterData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_WaterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_WaterData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.temp_read, Me.phlev_read, Me.turb_read, Me.temp_desc, Me.phlev_desc, Me.turb_desc, Me.date_read, Me.is_clean})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_WaterData.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_WaterData.EnableHeadersVisualStyles = False
        Me.DGV_WaterData.Location = New System.Drawing.Point(13, 117)
        Me.DGV_WaterData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_WaterData.Name = "DGV_WaterData"
        Me.DGV_WaterData.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_WaterData.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_WaterData.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_WaterData.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_WaterData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_WaterData.Size = New System.Drawing.Size(1330, 457)
        Me.DGV_WaterData.TabIndex = 1
        '
        'temp_read
        '
        Me.temp_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.temp_read.DataPropertyName = "temp_read"
        Me.temp_read.HeaderText = "TEMPERATURE"
        Me.temp_read.Name = "temp_read"
        Me.temp_read.ReadOnly = True
        Me.temp_read.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.temp_read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'phlev_read
        '
        Me.phlev_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phlev_read.DataPropertyName = "phlev_read"
        Me.phlev_read.HeaderText = "PH LEVEL"
        Me.phlev_read.Name = "phlev_read"
        Me.phlev_read.ReadOnly = True
        Me.phlev_read.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.phlev_read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'turb_read
        '
        Me.turb_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.turb_read.DataPropertyName = "turb_read"
        Me.turb_read.HeaderText = "TURBIDITY"
        Me.turb_read.Name = "turb_read"
        Me.turb_read.ReadOnly = True
        Me.turb_read.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.turb_read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'temp_desc
        '
        Me.temp_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.temp_desc.DataPropertyName = "temp_desc"
        Me.temp_desc.HeaderText = "TEMP DESCRIPTION"
        Me.temp_desc.Name = "temp_desc"
        Me.temp_desc.ReadOnly = True
        Me.temp_desc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.temp_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'phlev_desc
        '
        Me.phlev_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phlev_desc.DataPropertyName = "phlev_desc"
        Me.phlev_desc.HeaderText = "PH DESCRIPTION"
        Me.phlev_desc.Name = "phlev_desc"
        Me.phlev_desc.ReadOnly = True
        Me.phlev_desc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.phlev_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'turb_desc
        '
        Me.turb_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.turb_desc.DataPropertyName = "turb_desc"
        Me.turb_desc.HeaderText = "TURB DESCRIPTION"
        Me.turb_desc.Name = "turb_desc"
        Me.turb_desc.ReadOnly = True
        Me.turb_desc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.turb_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_read
        '
        Me.date_read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.date_read.DataPropertyName = "date_read"
        Me.date_read.HeaderText = "DATE"
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
        '
        'Timer1
        '
        '
        'dateTime
        '
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(13, 581)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(1330, 31)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "PRINT REPORTS"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1322, 100)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "MICRO-CONTROLLED SWIMMING POOL WATER QUALITY MONITORING SYSTEM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DGV_WaterData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DGV_WaterData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_WaterData As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dateTime As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents temp_read As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phlev_read As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turb_read As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents temp_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phlev_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turb_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_read As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents is_clean As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
