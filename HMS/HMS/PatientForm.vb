Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CreatePatient.Click
        Dim FirstName As String = FnameBox.Text
        Dim MiddleName As String = MnameBox.Text
        Dim LastName As String = Lname.Text
        Dim Dob As DateTimePicker = Birthday
        If MaleButton.Checked Then
            Dim Gender As String = MaleButton.Text
        End If

        If FemaleButton.Checked Then
            Dim Gender As String = FemaleButton.Text
        End If
        Dim type As String = PtypeBox.Text
        Dim Suite As String = SuiteBox.Text
        Dim StreetName As String = StreetBox.Text
        Dim Postal As String = PcodeBox.Text
        Dim City As String = CityBox.Text
        Dim Province As String = ProvinceBox.Text
        Dim Country As String = CountryBox.Text
        Dim PrimaryNumb As String = PnumbBox.Text
        Dim EmergName As String = EnameBox.Text
        Dim EmergRelation As String = RelationshipBox.Text

        Dim EmergNumb As String = EnumbBox.Text









    End Sub


End Class



