Public Class Form1
    Dim selectedCapital As String
    Dim selectedCountry As String
    Dim countryCapital As New Dictionary(Of String, String)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize the dictionary with country-capital pairs
        countryCapital.Add("Canada", "Ottawa")
        countryCapital.Add("England", "London")
        countryCapital.Add("France", "Paris")
        countryCapital.Add("Germany", "Berlin")
        countryCapital.Add("India", "New Delhi")
        countryCapital.Add("Italy", "Rome")
        countryCapital.Add("Japan", "Tokyo")
        countryCapital.Add("Mexico", "Mexico City")
        countryCapital.Add("People’s Republic of China", "Beijing")
        countryCapital.Add("Russia", "Moscow")
        countryCapital.Add("Spain", "Madrid")
        countryCapital.Add("United States", "Washington, D.C.")

        ' Populate ComboBox with country names
        For Each country As String In countryCapital.Keys
            ComboBox1.Items.Add(country)
        Next

        ' Populate ComboBox with capital names
        For Each capital As String In countryCapital.Values
            ComboBox2.Items.Add(capital)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        selectedCountry = ComboBox1.SelectedItem.ToString()
        If countryCapital.ContainsKey(selectedCountry) Then
            ComboBox2.Text = "The capital of " & selectedCountry & " is " & countryCapital(selectedCountry)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        selectedCapital = ComboBox2.SelectedItem.ToString()
        selectedCountry = ""
        For Each kvp As KeyValuePair(Of String, String) In countryCapital
            If kvp.Value = selectedCapital Then
                selectedCountry = kvp.Key
                Exit For
            End If
        Next
        If Not String.IsNullOrEmpty(selectedCountry) Then
            ComboBox1.Text = "The country with capital " & selectedCapital & " is " & selectedCountry
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
