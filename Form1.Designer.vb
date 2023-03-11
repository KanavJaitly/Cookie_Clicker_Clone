<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CookieClicker
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CookieClicker))
        btn_cookie_click = New Button()
        Cookie_Value = New Label()
        PassiveCookieTimer = New Timer(components)
        btn_click_upgrade = New Button()
        btn_passive_one_upgrade = New Button()
        lbl_Click_Level_Value = New Label()
        lbl_Passive_One_Level = New Label()
        lbl_Click_Upgrade_Cost = New Label()
        lbl_Passive_One_Upgrade_Cost = New Label()
        RoundButton1 = New RoundButton()
        Cookie_Boost = New Button()
        SuspendLayout()
        ' 
        ' btn_cookie_click
        ' 
        btn_cookie_click.Location = New Point(432, 441)
        btn_cookie_click.Margin = New Padding(4)
        btn_cookie_click.Name = "btn_cookie_click"
        btn_cookie_click.Size = New Size(401, 131)
        btn_cookie_click.TabIndex = 0
        btn_cookie_click.Text = "Click to increase cookies by 1"
        btn_cookie_click.UseVisualStyleBackColor = True
        ' 
        ' Cookie_Value
        ' 
        Cookie_Value.AutoSize = True
        Cookie_Value.BorderStyle = BorderStyle.FixedSingle
        Cookie_Value.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        Cookie_Value.Location = New Point(454, 11)
        Cookie_Value.Margin = New Padding(4, 0, 4, 0)
        Cookie_Value.Name = "Cookie_Value"
        Cookie_Value.Size = New Size(290, 78)
        Cookie_Value.TabIndex = 1
        Cookie_Value.Text = "Cookies: 0"
        Cookie_Value.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PassiveCookieTimer
        ' 
        PassiveCookieTimer.Interval = 1000
        ' 
        ' btn_click_upgrade
        ' 
        btn_click_upgrade.Location = New Point(15, 72)
        btn_click_upgrade.Margin = New Padding(4)
        btn_click_upgrade.Name = "btn_click_upgrade"
        btn_click_upgrade.Size = New Size(141, 91)
        btn_click_upgrade.TabIndex = 2
        btn_click_upgrade.Text = "Increase Value Of Click"
        btn_click_upgrade.UseVisualStyleBackColor = True
        ' 
        ' btn_passive_one_upgrade
        ' 
        btn_passive_one_upgrade.Location = New Point(15, 304)
        btn_passive_one_upgrade.Margin = New Padding(4)
        btn_passive_one_upgrade.Name = "btn_passive_one_upgrade"
        btn_passive_one_upgrade.Size = New Size(141, 91)
        btn_passive_one_upgrade.TabIndex = 3
        btn_passive_one_upgrade.Text = "Passive One Upgrade"
        btn_passive_one_upgrade.UseVisualStyleBackColor = True
        ' 
        ' lbl_Click_Level_Value
        ' 
        lbl_Click_Level_Value.AutoSize = True
        lbl_Click_Level_Value.Font = New Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Click_Level_Value.Location = New Point(15, 168)
        lbl_Click_Level_Value.Margin = New Padding(4, 0, 4, 0)
        lbl_Click_Level_Value.Name = "lbl_Click_Level_Value"
        lbl_Click_Level_Value.Size = New Size(120, 54)
        lbl_Click_Level_Value.TabIndex = 4
        lbl_Click_Level_Value.Text = "LvL: 0"
        lbl_Click_Level_Value.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_Passive_One_Level
        ' 
        lbl_Passive_One_Level.AutoSize = True
        lbl_Passive_One_Level.Font = New Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Passive_One_Level.Location = New Point(15, 399)
        lbl_Passive_One_Level.Margin = New Padding(4, 0, 4, 0)
        lbl_Passive_One_Level.Name = "lbl_Passive_One_Level"
        lbl_Passive_One_Level.Size = New Size(120, 54)
        lbl_Passive_One_Level.TabIndex = 5
        lbl_Passive_One_Level.Text = "LvL: 0"
        lbl_Passive_One_Level.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_Click_Upgrade_Cost
        ' 
        lbl_Click_Upgrade_Cost.AutoSize = True
        lbl_Click_Upgrade_Cost.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Click_Upgrade_Cost.Location = New Point(15, 34)
        lbl_Click_Upgrade_Cost.Margin = New Padding(4, 0, 4, 0)
        lbl_Click_Upgrade_Cost.Name = "lbl_Click_Upgrade_Cost"
        lbl_Click_Upgrade_Cost.Size = New Size(90, 32)
        lbl_Click_Upgrade_Cost.TabIndex = 6
        lbl_Click_Upgrade_Cost.Text = "Price: 2"
        lbl_Click_Upgrade_Cost.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_Passive_One_Upgrade_Cost
        ' 
        lbl_Passive_One_Upgrade_Cost.AutoSize = True
        lbl_Passive_One_Upgrade_Cost.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Passive_One_Upgrade_Cost.Location = New Point(15, 265)
        lbl_Passive_One_Upgrade_Cost.Margin = New Padding(4, 0, 4, 0)
        lbl_Passive_One_Upgrade_Cost.Name = "lbl_Passive_One_Upgrade_Cost"
        lbl_Passive_One_Upgrade_Cost.Size = New Size(103, 32)
        lbl_Passive_One_Upgrade_Cost.TabIndex = 7
        lbl_Passive_One_Upgrade_Cost.Text = "Price: 10"
        lbl_Passive_One_Upgrade_Cost.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RoundButton1
        ' 
        RoundButton1.Image = CType(resources.GetObject("RoundButton1.Image"), Image)
        RoundButton1.Location = New Point(486, 202)
        RoundButton1.Name = "RoundButton1"
        RoundButton1.Size = New Size(267, 232)
        RoundButton1.TabIndex = 8
        RoundButton1.Text = "RoundButton1"
        RoundButton1.UseVisualStyleBackColor = True
        ' 
        ' Cookie_Boost
        ' 
        Cookie_Boost.Location = New Point(965, 72)
        Cookie_Boost.Name = "Cookie_Boost"
        Cookie_Boost.Size = New Size(207, 75)
        Cookie_Boost.TabIndex = 9
        Cookie_Boost.Text = "Cookie Boost"
        Cookie_Boost.UseVisualStyleBackColor = True
        ' 
        ' CookieClicker
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1228, 588)
        Controls.Add(Cookie_Boost)
        Controls.Add(RoundButton1)
        Controls.Add(lbl_Passive_One_Upgrade_Cost)
        Controls.Add(lbl_Click_Upgrade_Cost)
        Controls.Add(lbl_Passive_One_Level)
        Controls.Add(lbl_Click_Level_Value)
        Controls.Add(btn_passive_one_upgrade)
        Controls.Add(btn_click_upgrade)
        Controls.Add(Cookie_Value)
        Controls.Add(btn_cookie_click)
        Margin = New Padding(4)
        Name = "CookieClicker"
        Text = "Cookie Clicker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_cookie_click As Button
    Friend WithEvents Cookie_Value As Label
    Friend WithEvents PassiveCookieTimer As Timer
    Friend WithEvents btn_click_upgrade As Button
    Friend WithEvents btn_passive_one_upgrade As Button
    Friend WithEvents lbl_Click_Level_Value As Label
    Friend WithEvents lbl_Passive_One_Level As Label
    Friend WithEvents lbl_Click_Upgrade_Cost As Label
    Friend WithEvents lbl_Passive_One_Upgrade_Cost As Label
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Cookie_Boost As Button
End Class
