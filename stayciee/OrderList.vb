﻿Imports System.Drawing.Text

Public Class ORDERlist
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Txtdatetime.Text = Date.Now.ToString("ddd dd-MM-yyyy tt")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Txtdatetime.TextChanged

    End Sub

    Private Sub Okay_Click(sender As Object, e As EventArgs) Handles Btnadd.Click

    End Sub

    Private Sub ORDERlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DBtable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBtable.CellContentClick

    End Sub

    Private Sub Txtquantity_TextChanged(sender As Object, e As EventArgs) Handles Txtquantity.TextChanged

    End Sub
End Class