Public Class Form1
	Dim ButtonClickCount = 0
	Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
		ButtonClickCount += 1

		If ButtonClickCount = 1 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.Red
			Shape5.BackColor = Color.Red
			Shape6.BackColor = Color.Red
			Shape7.BackColor = Color.White
			RB0.Checked = True
		End If

		If ButtonClickCount = 2 Then
			Shape1.BackColor = Color.White
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.White
			Shape6.BackColor = Color.White
			Shape5.BackColor = Color.White
			Shape7.BackColor = Color.White
			RB1.Checked = True
		End If

		If ButtonClickCount = 3 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.White
			Shape4.BackColor = Color.Red
			Shape5.BackColor = Color.Red
			Shape6.BackColor = Color.White
			Shape7.BackColor = Color.Red
			RB2.Checked = True
		End If

		If ButtonClickCount = 4 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.Red
			Shape5.BackColor = Color.White
			Shape6.BackColor = Color.White
			Shape7.BackColor = Color.Red
			RB3.Checked = True
		End If

		If ButtonClickCount = 5 Then
			Shape1.BackColor = Color.White
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.White
			Shape5.BackColor = Color.White
			Shape6.BackColor = Color.Red
			Shape7.BackColor = Color.Red
			RB4.Checked = True
		End If

		If ButtonClickCount = 6 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.White
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.Red
			Shape5.BackColor = Color.White
			Shape6.BackColor = Color.Red
			Shape7.BackColor = Color.Red
			RB5.Checked = True
		End If

		If ButtonClickCount = 7 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.White
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.Red
			Shape5.BackColor = Color.Red
			Shape6.BackColor = Color.Red
			Shape7.BackColor = Color.Red
			RB6.Checked = True
		End If

		If ButtonClickCount = 8 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.White
			Shape5.BackColor = Color.White
			Shape6.BackColor = Color.White
			Shape7.BackColor = Color.White
			RB7.Checked = True
		End If

		If ButtonClickCount = 9 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.Red
			Shape5.BackColor = Color.Red
			Shape6.BackColor = Color.Red
			Shape7.BackColor = Color.Red
			RB8.Checked = True
		End If

		If ButtonClickCount = 10 Then
			Shape1.BackColor = Color.Red
			Shape2.BackColor = Color.Red
			Shape3.BackColor = Color.Red
			Shape4.BackColor = Color.Red
			Shape5.BackColor = Color.White
			Shape6.BackColor = Color.Red
			Shape7.BackColor = Color.Red
			RB9.Checked = True
		End If

		If ButtonClickCount > 10 Then
			ButtonClickCount = 0
			Shape1.BackColor = Color.White
			Shape2.BackColor = Color.White
			Shape3.BackColor = Color.White
			Shape4.BackColor = Color.White
			Shape6.BackColor = Color.White
			Shape5.BackColor = Color.White
			Shape7.BackColor = Color.White
			RB1.Checked = False
			RB2.Checked = False
			RB3.Checked = False
			RB4.Checked = False
			RB5.Checked = False
			RB6.Checked = False
			RB7.Checked = False
			RB8.Checked = False
			RB9.Checked = False
			RB0.Checked = False
		End If

	End Sub

End Class
