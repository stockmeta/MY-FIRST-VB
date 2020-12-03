﻿Public Class Form1

    Private Sub DATABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DATABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FIRST_DATABASEDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FIRST_DATABASEDataSet.DATA' table. You can move, or remove it, as needed.
        Me.DATATableAdapter.Fill(Me.FIRST_DATABASEDataSet.DATA)

        ComboBox1.Visible = True
        TextBox1.Text = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ADD.Click
        BindingNavigatorAddNewItem.PerformClick()
        ComboBox1.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        Try
            DATABindingNavigatorSaveItem.PerformClick()
            MsgBox("DATA SAVED")
            ComboBox1.Visible = True
            TextBox1.Visible = False
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        Try
            BindingNavigatorDeleteItem.PerformClick()
            MsgBox("DATA DELETED")
            ComboBox1.Visible = True
            TextBox1.Visible = False
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try

    End Sub
End Class
