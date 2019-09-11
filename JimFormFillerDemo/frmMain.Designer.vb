<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.btnSelectTemplate = New System.Windows.Forms.Button()
		Me.btnGenerate = New System.Windows.Forms.Button()
		Me.chkFlatten = New System.Windows.Forms.CheckBox()
		Me.OFDMain = New System.Windows.Forms.OpenFileDialog()
		Me.lblSelectedTemplate = New System.Windows.Forms.Label()
		Me.txtTemplateFilePath = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnSelectTemplate
		'
		Me.btnSelectTemplate.Location = New System.Drawing.Point(48, 44)
		Me.btnSelectTemplate.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSelectTemplate.Name = "btnSelectTemplate"
		Me.btnSelectTemplate.Size = New System.Drawing.Size(585, 37)
		Me.btnSelectTemplate.TabIndex = 0
		Me.btnSelectTemplate.Text = "Select Implementation Template"
		Me.btnSelectTemplate.UseVisualStyleBackColor = True
		'
		'btnGenerate
		'
		Me.btnGenerate.Location = New System.Drawing.Point(48, 176)
		Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4)
		Me.btnGenerate.Name = "btnGenerate"
		Me.btnGenerate.Size = New System.Drawing.Size(585, 37)
		Me.btnGenerate.TabIndex = 1
		Me.btnGenerate.Text = "Generate and Open Document"
		Me.btnGenerate.UseVisualStyleBackColor = True
		'
		'chkFlatten
		'
		Me.chkFlatten.AutoSize = True
		Me.chkFlatten.Location = New System.Drawing.Point(48, 148)
		Me.chkFlatten.Name = "chkFlatten"
		Me.chkFlatten.Size = New System.Drawing.Size(91, 21)
		Me.chkFlatten.TabIndex = 2
		Me.chkFlatten.Text = "Flatten ?"
		Me.chkFlatten.UseVisualStyleBackColor = True
		'
		'lblSelectedTemplate
		'
		Me.lblSelectedTemplate.AutoSize = True
		Me.lblSelectedTemplate.Location = New System.Drawing.Point(45, 94)
		Me.lblSelectedTemplate.Name = "lblSelectedTemplate"
		Me.lblSelectedTemplate.Size = New System.Drawing.Size(148, 17)
		Me.lblSelectedTemplate.TabIndex = 3
		Me.lblSelectedTemplate.Text = "Selected Template:"
		'
		'txtTemplateFilePath
		'
		Me.txtTemplateFilePath.Location = New System.Drawing.Point(48, 117)
		Me.txtTemplateFilePath.Name = "txtTemplateFilePath"
		Me.txtTemplateFilePath.ReadOnly = True
		Me.txtTemplateFilePath.Size = New System.Drawing.Size(585, 23)
		Me.txtTemplateFilePath.TabIndex = 4
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(684, 242)
		Me.Controls.Add(Me.txtTemplateFilePath)
		Me.Controls.Add(Me.lblSelectedTemplate)
		Me.Controls.Add(Me.chkFlatten)
		Me.Controls.Add(Me.btnGenerate)
		Me.Controls.Add(Me.btnSelectTemplate)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Sample Form Filler For James K"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnSelectTemplate As System.Windows.Forms.Button
	Friend WithEvents btnGenerate As System.Windows.Forms.Button
	Friend WithEvents chkFlatten As System.Windows.Forms.CheckBox
	Friend WithEvents OFDMain As System.Windows.Forms.OpenFileDialog
	Friend WithEvents lblSelectedTemplate As System.Windows.Forms.Label
	Friend WithEvents txtTemplateFilePath As System.Windows.Forms.TextBox

End Class
