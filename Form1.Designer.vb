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
        DataGridView1 = New DataGridView()
        BtnPersoane = New Button()
        BtnFacultate = New Button()
        BtnJudet = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(776, 384)
        DataGridView1.TabIndex = 0
        ' 
        ' BtnPersoane
        ' 
        BtnPersoane.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnPersoane.Location = New Point(691, 415)
        BtnPersoane.Name = "BtnPersoane"
        BtnPersoane.Size = New Size(75, 23)
        BtnPersoane.TabIndex = 1
        BtnPersoane.Text = "Persoane"
        BtnPersoane.UseVisualStyleBackColor = True
        ' 
        ' BtnFacultate
        ' 
        BtnFacultate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnFacultate.Location = New Point(599, 415)
        BtnFacultate.Name = "BtnFacultate"
        BtnFacultate.Size = New Size(75, 23)
        BtnFacultate.TabIndex = 2
        BtnFacultate.Text = "Facultate"
        BtnFacultate.UseVisualStyleBackColor = True
        ' 
        ' BtnJudet
        ' 
        BtnJudet.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnJudet.Location = New Point(505, 415)
        BtnJudet.Name = "BtnJudet"
        BtnJudet.Size = New Size(75, 23)
        BtnJudet.TabIndex = 3
        BtnJudet.Text = "Judet"
        BtnJudet.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnJudet)
        Controls.Add(BtnFacultate)
        Controls.Add(BtnPersoane)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnPersoane As Button
    Friend WithEvents BtnFacultate As Button
    Friend WithEvents BtnJudet As Button
End Class
