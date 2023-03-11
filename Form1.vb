Imports System.Net

Public Class CookieClicker
    'global variable
    Public totalCookies, ClickValue, ClickLevel As Integer
    Public PassiveOneVal, PassiveOneLevel, c As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCookies = 0
        ClickValue = 1
        ClickLevel = 1

        PassiveOneVal = 0
        PassiveOneLevel = 1
        'comment in visual basic
        'Private Sub means funciton
        'Form1_Load just means when you start the program

        'starts the time
        set_Timer(1000)
        '1000 is once a second
        '100 is 1/10 of a second
        PassiveCookieTimer.Start()
    End Sub

    Private Sub btn_cookie_click_Click(sender As Object, e As EventArgs) Handles btn_cookie_click.Click
        cookie_click()
    End Sub

    'helper function
    'increments the cookie value
    Private Sub cookie_click()
        totalCookies = totalCookies + ClickValue
        Cookie_Value.Text = "Cookies: " + totalCookies.ToString
    End Sub

    'Passive Cookie Function
    Private Sub PassiveCookieTimer_Tick(sender As Object, e As EventArgs) Handles PassiveCookieTimer.Tick
        totalCookies = totalCookies + PassiveOneVal
        Cookie_Value.Text = "Cookies: " + totalCookies.ToString
    End Sub

    'helper function
    Private Sub set_Timer(interval As Integer)
        PassiveCookieTimer.Interval = interval
    End Sub

    Private Sub btn_click_upgrade_Click(sender As Object, e As EventArgs) Handles btn_click_upgrade.Click
        Dim upgradeCost As Integer
        upgradeCost = ClickLevel * 2

        If totalCookies >= upgradeCost Then
            totalCookies = totalCookies - upgradeCost

            ClickLevel = ClickLevel + 1
            ClickValue = (ClickLevel - 1) * 5

            upgradeCost = ClickLevel * 2
            lbl_Click_Level_Value.Text = "LvL: " + ClickLevel.ToString
            lbl_Click_Upgrade_Cost.Text = "Price: " + upgradeCost.ToString
            btn_cookie_click.Text = "Click to increase cookies by " + ClickValue.ToString
        End If
    End Sub

    Private Sub btn_passive_one_upgrade_Click(sender As Object, e As EventArgs) Handles btn_passive_one_upgrade.Click
        Dim upgradeCost As Integer
        upgradeCost = PassiveOneLevel * PassiveOneLevel * 10
        If totalCookies >= upgradeCost Then
            totalCookies = totalCookies - upgradeCost

            PassiveOneLevel = PassiveOneLevel + 1
            PassiveOneVal = PassiveOneVal + 10
            upgradeCost = PassiveOneLevel * PassiveOneLevel * 10

            lbl_Passive_One_Level.Text = "LvL: " + PassiveOneLevel.ToString
            lbl_Passive_One_Upgrade_Cost.Text = "Price: " + upgradeCost.ToString
        End If
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        cookie_click()
    End Sub

    Private Sub Cookie_Boost_Click(sender As Object, e As EventArgs) Handles Cookie_Boost.Click
        set_Timer(1000)
        'Githubtest
    End Sub
End Class
