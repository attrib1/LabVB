﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim FinalLabel As System.Windows.Forms.Label
        Dim ProjectLabel As System.Windows.Forms.Label
        Dim LabLabel As System.Windows.Forms.Label
        Dim MidtermLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.StudentDataSet = New Connect_Access.studentDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New Connect_Access.studentDataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New Connect_Access.studentDataSetTableAdapters.TableAdapterManager()
        Me.StudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectTextBox = New System.Windows.Forms.TextBox()
        Me.LabTextBox = New System.Windows.Forms.TextBox()
        Me.MidtermTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        FinalLabel = New System.Windows.Forms.Label()
        ProjectLabel = New System.Windows.Forms.Label()
        LabLabel = New System.Windows.Forms.Label()
        MidtermLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentBindingNavigator.SuspendLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "studentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.StudentDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = Connect_Access.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentBindingNavigator
        '
        Me.StudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentBindingNavigator.BindingSource = Me.StudentBindingSource
        Me.StudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentBindingNavigatorSaveItem})
        Me.StudentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentBindingNavigator.Name = "StudentBindingNavigator"
        Me.StudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentBindingNavigator.Size = New System.Drawing.Size(667, 25)
        Me.StudentBindingNavigator.TabIndex = 0
        Me.StudentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'StudentBindingNavigatorSaveItem
        '
        Me.StudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentBindingNavigatorSaveItem.Name = "StudentBindingNavigatorSaveItem"
        Me.StudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.StudentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(0, 295)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.Size = New System.Drawing.Size(655, 220)
        Me.StudentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Midterm"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Midterm"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Lab"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lab"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Project"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Project"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Final"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Final"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'FinalLabel
        '
        FinalLabel.AutoSize = True
        FinalLabel.Location = New System.Drawing.Point(199, 240)
        FinalLabel.Name = "FinalLabel"
        FinalLabel.Size = New System.Drawing.Size(32, 13)
        FinalLabel.TabIndex = 29
        FinalLabel.Text = "Final:"
        '
        'FinalTextBox
        '
        Me.FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Final", True))
        Me.FinalTextBox.Location = New System.Drawing.Point(252, 237)
        Me.FinalTextBox.Name = "FinalTextBox"
        Me.FinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FinalTextBox.TabIndex = 30
        '
        'ProjectLabel
        '
        ProjectLabel.AutoSize = True
        ProjectLabel.Location = New System.Drawing.Point(199, 200)
        ProjectLabel.Name = "ProjectLabel"
        ProjectLabel.Size = New System.Drawing.Size(43, 13)
        ProjectLabel.TabIndex = 27
        ProjectLabel.Text = "Project:"
        '
        'ProjectTextBox
        '
        Me.ProjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Project", True))
        Me.ProjectTextBox.Location = New System.Drawing.Point(252, 197)
        Me.ProjectTextBox.Name = "ProjectTextBox"
        Me.ProjectTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProjectTextBox.TabIndex = 28
        '
        'LabLabel
        '
        LabLabel.AutoSize = True
        LabLabel.Location = New System.Drawing.Point(199, 158)
        LabLabel.Name = "LabLabel"
        LabLabel.Size = New System.Drawing.Size(28, 13)
        LabLabel.TabIndex = 25
        LabLabel.Text = "Lab:"
        '
        'LabTextBox
        '
        Me.LabTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Lab", True))
        Me.LabTextBox.Location = New System.Drawing.Point(252, 151)
        Me.LabTextBox.Name = "LabTextBox"
        Me.LabTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LabTextBox.TabIndex = 26
        '
        'MidtermLabel
        '
        MidtermLabel.AutoSize = True
        MidtermLabel.Location = New System.Drawing.Point(199, 121)
        MidtermLabel.Name = "MidtermLabel"
        MidtermLabel.Size = New System.Drawing.Size(47, 13)
        MidtermLabel.TabIndex = 23
        MidtermLabel.Text = "Midterm:"
        '
        'MidtermTextBox
        '
        Me.MidtermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Midterm", True))
        Me.MidtermTextBox.Location = New System.Drawing.Point(252, 118)
        Me.MidtermTextBox.Name = "MidtermTextBox"
        Me.MidtermTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MidtermTextBox.TabIndex = 24
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(199, 81)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 21
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(252, 78)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 22
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(199, 38)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(252, 35)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 20
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 512)
        Me.Controls.Add(FinalLabel)
        Me.Controls.Add(Me.FinalTextBox)
        Me.Controls.Add(ProjectLabel)
        Me.Controls.Add(Me.ProjectTextBox)
        Me.Controls.Add(LabLabel)
        Me.Controls.Add(Me.LabTextBox)
        Me.Controls.Add(MidtermLabel)
        Me.Controls.Add(Me.MidtermTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.StudentBindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentBindingNavigator.ResumeLayout(False)
        Me.StudentBindingNavigator.PerformLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentDataSet As Connect_Access.studentDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As Connect_Access.studentDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As Connect_Access.studentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MidtermTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
End Class
