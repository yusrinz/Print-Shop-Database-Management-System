﻿Public Class frm_orderOptions_a188634
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        frm_makeorder_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        frm_viewOrder_a188634.Show()
        Me.Hide()
    End Sub
End Class