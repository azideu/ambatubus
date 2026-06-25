Imports System.Drawing
Imports System.Windows.Forms

Public Class Theme
    Public Property Background As Color
    Public Property PanelBackground As Color
    Public Property TextPrimary As Color
    Public Property TextSecondary As Color
    
    Public Property InputBackground As Color
    Public Property InputText As Color
    
    Public Property ButtonPrimary As Color
    Public Property ButtonPrimaryHover As Color
    Public Property ButtonSecondary As Color
    Public Property ButtonSecondaryHover As Color
    Public Property ButtonDanger As Color
    Public Property ButtonDangerHover As Color
    Public Property ButtonNeutral As Color
    Public Property ButtonNeutralHover As Color
    
    Public Property GridHeaderBackground As Color
    Public Property GridHeaderForeground As Color
    Public Property GridRowBackground As Color
    Public Property GridRowAltBackground As Color
    Public Property GridRowForeground As Color
    Public Property GridSelectionBackground As Color
    Public Property GridSelectionForeground As Color
    Public Property GridColor As Color
End Class

Public Class ThemeManager
    Public Shared DarkTheme As New Theme() With {
        .Background = Color.FromArgb(25, 30, 28),
        .PanelBackground = Color.FromArgb(35, 42, 38),
        .TextPrimary = Color.White,
        .TextSecondary = Color.FromArgb(140, 160, 150),
        .InputBackground = Color.FromArgb(35, 42, 38),
        .InputText = Color.FromArgb(220, 235, 225),
        .ButtonPrimary = Color.FromArgb(20, 150, 85),
        .ButtonPrimaryHover = Color.FromArgb(35, 175, 105),
        .ButtonSecondary = Color.FromArgb(30, 130, 190),
        .ButtonSecondaryHover = Color.FromArgb(50, 150, 210),
        .ButtonDanger = Color.FromArgb(180, 50, 50),
        .ButtonDangerHover = Color.FromArgb(210, 70, 70),
        .ButtonNeutral = Color.FromArgb(65, 75, 70),
        .ButtonNeutralHover = Color.FromArgb(85, 95, 90),
        .GridHeaderBackground = Color.FromArgb(20, 110, 60),
        .GridHeaderForeground = Color.White,
        .GridRowBackground = Color.FromArgb(35, 42, 38),
        .GridRowAltBackground = Color.FromArgb(30, 36, 33),
        .GridRowForeground = Color.FromArgb(220, 235, 225),
        .GridSelectionBackground = Color.FromArgb(25, 130, 75),
        .GridSelectionForeground = Color.White,
        .GridColor = Color.FromArgb(50, 60, 55)
    }

    Public Shared LightTheme As New Theme() With {
        .Background = Color.FromArgb(245, 247, 245),
        .PanelBackground = Color.FromArgb(255, 255, 255),
        .TextPrimary = Color.FromArgb(30, 35, 33),
        .TextSecondary = Color.FromArgb(90, 105, 100),
        .InputBackground = Color.FromArgb(255, 255, 255),
        .InputText = Color.FromArgb(30, 35, 33),
        .ButtonPrimary = Color.FromArgb(30, 170, 100),
        .ButtonPrimaryHover = Color.FromArgb(40, 190, 115),
        .ButtonSecondary = Color.FromArgb(45, 150, 215),
        .ButtonSecondaryHover = Color.FromArgb(60, 170, 230),
        .ButtonDanger = Color.FromArgb(200, 70, 70),
        .ButtonDangerHover = Color.FromArgb(230, 90, 90),
        .ButtonNeutral = Color.FromArgb(150, 160, 155),
        .ButtonNeutralHover = Color.FromArgb(170, 180, 175),
        .GridHeaderBackground = Color.FromArgb(25, 140, 80),
        .GridHeaderForeground = Color.White,
        .GridRowBackground = Color.FromArgb(255, 255, 255),
        .GridRowAltBackground = Color.FromArgb(248, 250, 249),
        .GridRowForeground = Color.FromArgb(30, 35, 33),
        .GridSelectionBackground = Color.FromArgb(40, 180, 110),
        .GridSelectionForeground = Color.White,
        .GridColor = Color.FromArgb(220, 225, 220)
    }

    Public Shared CurrentTheme As Theme = DarkTheme

    Public Shared Sub ToggleTheme()
        If CurrentTheme Is DarkTheme Then
            CurrentTheme = LightTheme
        Else
            CurrentTheme = DarkTheme
        End If
    End Sub

    Public Shared Sub ApplyTheme(ByVal frm As Form)
        frm.BackColor = CurrentTheme.Background
        ApplyThemeToControls(frm.Controls)
    End Sub

    Private Shared Sub ApplyThemeToControls(ByVal controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is Panel Then
                If ctrl.Name = "pnlSeatGrid" Then
                    ' Seat grid has custom colors inside, don't change panel backcolor, wait, panel is transparent usually, or background.
                    ctrl.BackColor = CurrentTheme.PanelBackground
                Else
                    ctrl.BackColor = CurrentTheme.PanelBackground
                End If
                ApplyThemeToControls(ctrl.Controls)
            ElseIf TypeOf ctrl Is GroupBox Then
                ctrl.ForeColor = CurrentTheme.TextSecondary
                ApplyThemeToControls(ctrl.Controls)
            ElseIf TypeOf ctrl Is Label Then
                Dim lbl As Label = DirectCast(ctrl, Label)
                ' If it's a big value label (e.g., lblTotalBookingsVal), it might have custom colors. We keep TextSecondary for standard labels.
                If lbl.Name.EndsWith("Val") AndAlso Not lbl.Name = "lblTodayRevenueVal" AndAlso Not lbl.Name = "lblTotalBookingsVal" AndAlso Not lbl.Name = "lblOccupancyVal" AndAlso Not lbl.Name = "lblTotalRoutesVal" Then
                    lbl.ForeColor = CurrentTheme.TextPrimary
                ElseIf lbl.Name.StartsWith("lblTitle") OrElse lbl.Font.Size >= 14 Then
                    lbl.ForeColor = CurrentTheme.TextPrimary
                ElseIf lbl.Name = "lblPrice" OrElse lbl.Name.EndsWith("Val") Then
                    ' Do not change specific stat labels that have colored text
                Else
                    lbl.ForeColor = CurrentTheme.TextSecondary
                End If
            ElseIf TypeOf ctrl Is TextBox Then
                ctrl.BackColor = CurrentTheme.InputBackground
                ctrl.ForeColor = CurrentTheme.InputText
            ElseIf TypeOf ctrl Is ComboBox Then
                ctrl.BackColor = CurrentTheme.InputBackground
                ctrl.ForeColor = CurrentTheme.InputText
            ElseIf TypeOf ctrl Is DateTimePicker Then
                ctrl.BackColor = CurrentTheme.InputBackground
                ctrl.ForeColor = CurrentTheme.InputText
            ElseIf TypeOf ctrl Is CheckBox Then
                ctrl.ForeColor = CurrentTheme.TextPrimary
            ElseIf TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                ' Keep the seating chart buttons as they are
                If btn.Parent IsNot Nothing AndAlso btn.Parent.Name = "pnlSeatGrid" Then
                    Continue For
                End If

                If btn.Name.Contains("Delete") OrElse btn.Name.Contains("Logout") Then
                    btn.BackColor = CurrentTheme.ButtonDanger
                    btn.ForeColor = Color.White
                ElseIf btn.Name.Contains("Update") Then
                    btn.BackColor = CurrentTheme.ButtonSecondary
                    btn.ForeColor = Color.White
                ElseIf btn.Name.Contains("Close") OrElse btn.Name.Contains("Clear") Then
                    btn.BackColor = CurrentTheme.ButtonNeutral
                    btn.ForeColor = Color.White
                Else
                    ' Default primary (Book, Add, Login, Manage...)
                    btn.BackColor = CurrentTheme.ButtonPrimary
                    btn.ForeColor = Color.White
                End If
            ElseIf TypeOf ctrl Is DataGridView Then
                Dim dgv As DataGridView = DirectCast(ctrl, DataGridView)
                dgv.BackgroundColor = CurrentTheme.PanelBackground
                dgv.GridColor = CurrentTheme.GridColor
                
                dgv.ColumnHeadersDefaultCellStyle.BackColor = CurrentTheme.GridHeaderBackground
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = CurrentTheme.GridHeaderForeground
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = CurrentTheme.GridHeaderBackground
                dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = CurrentTheme.GridHeaderForeground
                
                dgv.DefaultCellStyle.BackColor = CurrentTheme.GridRowBackground
                dgv.DefaultCellStyle.ForeColor = CurrentTheme.GridRowForeground
                dgv.DefaultCellStyle.SelectionBackColor = CurrentTheme.GridSelectionBackground
                dgv.DefaultCellStyle.SelectionForeColor = CurrentTheme.GridSelectionForeground
                
                dgv.AlternatingRowsDefaultCellStyle.BackColor = CurrentTheme.GridRowAltBackground
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = CurrentTheme.GridRowForeground
                dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = CurrentTheme.GridSelectionBackground
                dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = CurrentTheme.GridSelectionForeground
            End If
        Next
    End Sub
End Class
