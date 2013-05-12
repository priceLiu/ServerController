Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

'**************************************************************************************************************
'*
'*  Aero Controls FOR .NET 2.0
'*  
'*  LabeledDivider Control
'* 
'*  This control written by Blake Pell (bpell@indiana.edu, blakepell@hotmail.com, http://www.blakepell.com)
'*  Initial Date:  07/25/2009
'*  Last Updated:  07/27/2009
'* 
'*  This code is released under the Microsoft Community License (Ms-CL).
'*
'**************************************************************************************************************/

' This control was originally written in C#, I have converted it to VB and removed anything that wasn't necessary for this
' project. The original code is available from here: http://windowsformsaero.codeplex.com/
' Link was working as of July 11th 2010.

Namespace CustomControls
    ''' <summary>
    ''' The labeled divider provides a Aero styled divider with an option caption, similiar to what is seen in the
    ''' Control Panel dialogs of Windows 7 and Vista.
    ''' </summary>
    Public Class DividerControl
        Inherits Control
        
        Public Sub New()
            Me.Font = New Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me._text = Me.Name
            Me.ForeColor = Color.Gray
            Me.Width = 200
        End Sub

        Protected Overloads Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim sbDividerColor As New SolidBrush(Color.FromArgb(176, 191, 222))
            Dim sbForeColor As New SolidBrush(Me.ForeColor)

            ' Draw the caption string, then get the size of it as it appears on the screen so
            ' we know where to put the caption.
            e.Graphics.DrawString(Me.Text, Me.Font, sbForeColor, 0, 0)
            Dim sf As SizeF = e.Graphics.MeasureString(Me.Text, Me.Font)

            ' This didn't quiet get in the center so I had to add 1 pixel to the sf.Height / 2

            Dim rect As New Rectangle(CInt(sf.Width), CInt((sf.Height) / 2) + 1, Me.Width - CInt(sf.Width), 1)
            e.Graphics.FillRectangle(sbDividerColor, rect)

            sbForeColor.Dispose()
            sbDividerColor.Dispose()
        End Sub

        'Shared dividerColor As Color = Color.FromArgb(176, 191, 222)
        '''' <summary>
        '''' The color of the divider line.
        '''' </summary>
        '<Description("The color of the divider line."), Category("Appearance")> _
        'Public Property DividerColor() As Color
        '    Get
        '        Return Me._dividerColor
        '    End Get
        '    Set(ByVal value As Color)
        '        Me._dividerColor = value
        '    End Set
        'End Property

        Private _text As String = ""
        ''' <summary>
        ''' The text that should be used for the caption.  If the caption is set to blank and the divider position is set to center then
        ''' a simple divider line will be drawn.
        ''' </summary>
        ''' <remarks>
        ''' After a change is made to the text property we want to invalidate the control so it triggers a new paint message being sent.
        ''' </remarks>
        <Description("The text that will display as the caption."), Category("Appearance"), DefaultValue("DividerLabel")> _
        Public Overloads Overrides Property Text() As String
            Get
                Return Me._text
            End Get
            Set(ByVal value As String)
                Me._text = value
                Me.Invalidate()
            End Set
        End Property

    End Class
End Namespace
