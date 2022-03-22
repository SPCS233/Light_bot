Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Diagnostics.Eventing

Public Class Form1
    Private fileIni As Object
    Private list1 As Object


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dir("./data/login/login.ini") = "" Then
            LoginForm1.Show()
            MsgBox("未发现配置文件等文件已经自动创建")
        End If
        If Dir("./logs", vbDirectory) = "" Then '判断文件夹是否存在
            MkDir(Path:="./logs") '创建文件夹 msgbox ("创建完毕")
        End If
        If Dir("./plugins", vbDirectory) = "" Then '判断文件夹是否存在
            MkDir(Path:="./plugins") '创建文件夹 msgbox ("创建完毕")
        End If
        If Dir("./data", vbDirectory) = "" Then '判断文件夹是否存在
            MkDir(Path:="./data") '创建文件夹 msgbox ("创建完毕")
        End If
        If Dir("./data/login", vbDirectory) = "" Then '判断文件夹是否存在
            MkDir(Path:="./data/login") '创建文件夹 msgbox ("创建完毕")
        End If
        If Not File.Exists("./data/login/login.ini") Then
            Dim mystream As FileStream
            mystream = New System.IO.FileStream("./data/login/login.ini", FileMode.Create)
            Dim writer As StreamWriter
            writer = New System.IO.StreamWriter(mystream)
            Try
                writer.WriteLine("[bot]")
                writer.WriteLine("公域=假")
                writer.WriteLine("自动登录=假")
                writer.WriteLine("APPID=")
                writer.WriteLine("TOKEN=")
                ReadIni("公域", "=", "假")
            Catch exp As Exception
                MsgBox(exp.Message)
            Finally
                writer.Close()
                mystream.Close()
            End Try
        End If

    End Sub

    Private Sub ReadIni(v1 As String, v2 As String, v3 As String)
        Throw New NotImplementedException()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
