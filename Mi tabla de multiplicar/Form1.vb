﻿Public Class Form1
    Private Sub btnlongitud_Click(sender As Object, e As EventArgs) Handles btnlongitud.Click
        If cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) / 10
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 1000
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 1000000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0394
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 0.00328084
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 0.00109361
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) * 0.000000621371
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0001
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.01
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 100000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 0.393701
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0328084
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0109361
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) * 0.00000621371
            lblnum.Text = "Milla"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.001
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.1
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 1000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 39.3701
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 3.28084
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 1.09361
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) * 0.000621371
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.1
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000000.0
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 100000
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 39370
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 3281
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 1094
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 1.609
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 10000
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 25.4
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 2.54
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 39.97
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 39370
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) / 12
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) / 36
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 63360
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 394
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) / 3.937
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 305
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 30.48
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 3.281
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 3281
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 12
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) / 3
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 5280
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 32.808
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 3.048
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 914
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 91.44
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 1.094
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 1094
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 36
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 3
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 1760
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 10.936
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 9.144
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1609000.0
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 160934
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) * 1609
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) * 1.609
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 63360
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 5280
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 1760
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 161
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 16093
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 10000
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 394
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 32.808
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 10.936
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 161
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 10
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 10000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 3.937
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) / 3.048
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) / 9.144
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 16093
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "dm"
        End If
    End Sub

    Private Sub btnalmacenamiento_Click(sender As Object, e As EventArgs) Handles btnalmacenamiento.Click
        If cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.001
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000001
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000000001
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000000000001
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000000000000001
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E-18
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E-21
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7.8125
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1.0E+15
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1.0E+18
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8000000.0
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7813
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000000.0
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1.0E+15
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8000000000.0
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7812000.0
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000000.0
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8000000000000.0
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7812000000.0
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8.0E+15
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7812000000000.0
            lblnum1.Text = "KBB"

        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+15
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8.0E+18
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7.812E+15
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+18
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+15
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7.812E+18
            lblnum1.Text = "KBB"

        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+18
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+15
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000000000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8.0E+15
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8.0E+18
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 9.223E+18
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 9.223E+18
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1024
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7.812
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7813
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7812000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7812000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7812000000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 976600000000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7.813E+18
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 9.223E+18
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1024
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "KBB"
        End If
    End Sub

    Private Sub btntiempo_Click(sender As Object, e As EventArgs) Handles btntiempo.Click
        If cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000000.0
            lblnum2.Text = "Seng"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60000000000.0
            lblnum2.Text = "Min"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600000000000.0
            lblnum2.Text = "Hora"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400000000000.0
            lblnum2.Text = "Dia"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800000000000.0
            lblnum2.Text = "Smn"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2.628E+15
            lblnum2.Text = "Mes"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3.154E+16
            lblnum2.Text = "A.N"


        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 0.001
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000.0
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60000000.0
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600000000.0
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400000000.0
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800000000.0
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2628000000000.0
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 31540000000000.0
            lblnum2.Text = "A N"

        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60000
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600000.0
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400000.0
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800000.0
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2628000000.0
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 31540000000.0
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2628000.0
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 31540000.0
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60000
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1440
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 10080
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 43800
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 525600
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 24
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 168
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 730
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 8760
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1440
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 24
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 7
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 30.417
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 365
            lblnum2.Text = "A N"



        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 10080
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 168
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) * 7
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 4.345
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 52.143
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2.628E+15
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2628000000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2628000000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2628000.0
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 43800
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 730
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) * 30.417
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) * 4.345
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 4.345
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 52.143
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3.154E+16
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 31540000000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 31540000000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 31540000.0
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 525600
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 8760
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) * 365
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) * 52.143
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 12
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "A N"
        End If
    End Sub

    Private Sub btnvolumen_Click(sender As Object, e As EventArgs) Handles btnvolumen.Click
        If cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 1000
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 4.546
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 67.628
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 2.113
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Onza liquida imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) * 35.195
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 3.785
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1000
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Pie Cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 28.317
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Pulgada Cubica" Then
            lblr5.Text = Val(txtcodigo5.Text) * 61.024
            lblnum5.Text = "PULGC"


        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1000
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 4546
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 14.787
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 473
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Onza liquida imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 29.574
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 3785
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1000000.0
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Pie Cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 28317
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Pulgada Cubica" Then
            lblr5.Text = Val(txtcodigo5.Text) / 16.387
            lblnum5.Text = "PULGC"


        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 4.546
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 4546
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 307
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 9.608
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) * 160
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 1.201
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 220
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 6.229
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text) * 277
            lblnum5.Text = "PULGC"


        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) / 67.628
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) / 14.787
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 307
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 32
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) / 1.922
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 256
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 67628
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1915
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1.108
            lblnum5.Text = "PULGC"



        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) / 2.113
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 473
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 9.608
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 32
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) * 16.653
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 8
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 2113
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 59.844
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text) * 28.875
            lblnum5.Text = "PULGC"


        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) / 35.195
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 28.413
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 160
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 1.922
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 16.653
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) * 16.653
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 8
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 2113
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 59.844
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text) * 28.875
            lblnum5.Text = "PULGC"


        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 3.785
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 3785
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1.201
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 256
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 8
            lblnum5.Text = ""
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) * 133
            lblnum5.Text = "piec"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "mll"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 264
            lblnum5.Text = "Ce"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 7.481
            lblnum5.Text = "Ge"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text) * 231
            lblnum5.Text = "PULGC"


        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 1000
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1000000.0
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) * 220
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 67628
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 2113
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) * 35195
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 264
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text) * 35.315
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text) * 61024
            lblnum5.Text = "PULGC"


        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 1000
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 1000000.0
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) * 220
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 67628
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 2113
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) * 35195
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 264
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 264
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text) * 231
            lblnum5.Text = "PULGC"



        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Litros" Then
            lblr5.Text = Val(txtcodigo5.Text) / 61.024
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Mililitros" Then
            lblr5.Text = Val(txtcodigo5.Text) * 16.387
            lblnum5.Text = "MLL"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Galón Imperial" Then
            lblr5.Text = Val(txtcodigo5.Text) / 277
            lblnum5.Text = "GI"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) * 1.108
            lblnum5.Text = "CE"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 28.875
            lblnum5.Text = "PE"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblr5.Text = Val(txtcodigo5.Text) / 1.734
            lblnum5.Text = "OLI"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Galón estadounidense" Then
            lblr5.Text = Val(txtcodigo5.Text) / 231
            lblnum5.Text = "GE"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Metro cubico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 61024
            lblnum5.Text = "MC"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Pie cúbico" Then
            lblr5.Text = Val(txtcodigo5.Text) / 1728
            lblnum5.Text = "PC"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblr5.Text = Val(txtcodigo5.Text)
            lblnum5.Text = "PC"
        End If

    End Sub

    Private Sub btnmasa_Click(sender As Object, e As EventArgs) Handles btnmasa.Click
        If cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000
            lblnum4.Text = "Kg"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000000
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000000000
            lblnum4.Text = "Mg"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000000000000
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1.016
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1.102
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) * 157
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) * 2205
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Tonelada" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) * 35274
            lblnum4.Text = "oz"

        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000
            lblnum4.Text = "t"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000000.0
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000000000.0
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1016
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) / 907
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) / 6.35
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) * 2.205
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Kilogramo" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) * 35.274
            lblnum4.Text = "oz"

        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000000.0
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000
            lblnum4.Text = "ml"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000000.0
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1016000.0
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) / 907185
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) / 6350
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) / 454
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Gramo" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) / 28.35
            lblnum4.Text = "oz"


        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000000000.0
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000000.0
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1000
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1016000000.0
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) / 907200000.0
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) / 6350000.0
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) / 453592
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Miligramo" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) / 28350
            lblnum4.Text = "oz"

        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Microgramo " Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000000000000.0
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000000000.0
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000000.0
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1000
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1016000000000.0
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) / 907200000000.0
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) / 6350000000.0
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) / 453600000.0
            lblnum4.Text = "libra"
        ElseIf cboxentrada4.Text = "Microgramo" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) / 28350000.0
            lblnum4.Text = "oz"

        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1.016
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1016
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1016000.0
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1016000000.0
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1016000000000.0
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) * 1.12
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) * 160
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) * 2240
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Tonelada Larga" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) * 35840
            lblnum4.Text = "oz"

        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1.102
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 907
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 907185
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 907200000000.0
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 907120000000.0
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 1.12
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) * 143
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) * 2000
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Tonelada corta" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) * 32000
            lblnum4.Text = "oz"

        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 157
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 6.35
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 6350
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 6350000.0
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 6350000000.0
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 160
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) / 143
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) * 14
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Stone" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) * 224
            lblnum4.Text = "oz"

        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "oz"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 35274
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 35.274
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 28.35
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 28350
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 28350000.0
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 35840
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) / 32000
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) / 224
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Onza" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text) / 16
            lblnum4.Text = "lb"

        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Libra" Then
            lblr4.Text = Val(txtcodigo4.Text)
            lblnum4.Text = "lb"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Tonelada" Then
            lblr4.Text = Val(txtcodigo4.Text) / 2205
            lblnum4.Text = "T"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Kilogramo" Then
            lblr4.Text = Val(txtcodigo4.Text) / 2.205
            lblnum4.Text = "kg"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Gramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 454
            lblnum4.Text = "g"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Miligramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 453592
            lblnum4.Text = "mg"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Microgramo" Then
            lblr4.Text = Val(txtcodigo4.Text) * 453600000.0
            lblnum4.Text = "µg"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Tonelada Larga" Then
            lblr4.Text = Val(txtcodigo4.Text) / 2240
            lblnum4.Text = "LT"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Tonelada corta" Then
            lblr4.Text = Val(txtcodigo4.Text) / 2000
            lblnum4.Text = "ST"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Stone" Then
            lblr4.Text = Val(txtcodigo4.Text) / 14
            lblnum4.Text = "st"
        ElseIf cboxentrada4.Text = "Libra" And cboxsalida4.Text = "Onza" Then
            lblr4.Text = Val(txtcodigo4.Text) * 16
            lblnum4.Text = "oz"
        End If
    End Sub

    Private Sub btnmoneda_Click(sender As Object, e As EventArgs) Handles btnmoneda.Click
        If cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "CS"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Dolar estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.11
            lblnum3.Text = "DE"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Quetzal " Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.88
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 2.82
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Colón Costarricense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 68.05
            lblnum3.Text = "CC"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.11
            lblnum3.Text = "B"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Cordoba nicaraguense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 3.98
            lblnum3.Text = "CN"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida.Text = "Dolar canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.15
            lblnum3.Text = "DC"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Peso mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 2.51
            lblnum3.Text = "PM"
        ElseIf cbxentrada3.Text = "Colón Salvadoreño" And cbxsalida3.Text = "Sol peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.41
            lblnum3.Text = "SP"


        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 8.75
            lblnum3.Text = "CS"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Dolar estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "DE"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Quetzal " Then
            lblr3.Text = Val(txtcodigo3.Text) * 7.7
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 24.66
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Colón Costarricense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 595.4
            lblnum3.Text = "CC"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.0
            lblnum3.Text = "B"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Cordoba nicaraguense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 34.84
            lblnum3.Text = "CN"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida.Text = "Dolar canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.32
            lblnum3.Text = "DC"
        ElseIf cbxentrada3.Text = "Dolar estadounidense" And cbxsalida3.Text = "Peso mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 21.98
            lblnum3.Text = "PM"
        ElseIf cbxentrada3.Text = " Dolar estadounidense" And cbxsalida3.Text = "Sol peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 3.58
            lblnum3.Text = "SP"

        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.14
            lblnum3.Text = "CS"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Dolar estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.13
            lblnum3.Text = "DE"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Quetzal " Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 3.2
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Colón Costarricense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 77.32
            lblnum3.Text = "CC"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.13
            lblnum3.Text = "B"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Cordoba nicaraguense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 4.52
            lblnum3.Text = "CN"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida.Text = "Dolar canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.17
            lblnum3.Text = "DC"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Peso mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 2.85
            lblnum3.Text = "PM"
        ElseIf cbxentrada3.Text = "Quetzal" And cbxsalida3.Text = "Sol peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.46
            lblnum3.Text = "SP"

        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.36
            lblnum3.Text = "CS"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Dolar estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.041
            lblnum3.Text = "DE"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Quetzal " Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.31
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Colón Costarricense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 24.15
            lblnum3.Text = "CC"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.041
            lblnum3.Text = "B"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Cordoba nicaraguense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.41
            lblnum3.Text = "CN"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida.Text = "Dolar canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.053
            lblnum3.Text = "DC"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Peso mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.89
            lblnum3.Text = "PM"
        ElseIf cbxentrada3.Text = "Lempira" And cbxsalida3.Text = "Sol peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.15
            lblnum3.Text = "SP"


        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.015
            lblnum3.Text = "CS"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Dolar estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.0017
            lblnum3.Text = "DE"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Quetzal " Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.013
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.041
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Colón Costarricense" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "CC"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.0017
            lblnum3.Text = "B"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Cordoba nicaraguense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.059
            lblnum3.Text = "CN"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida.Text = "Dolar canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.0022
            lblnum3.Text = "DC"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Peso mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.037
            lblnum3.Text = "PM"
        ElseIf cbxentrada3.Text = "Colón Costarricense" And cbxsalida3.Text = "Sol peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.006
            lblnum3.Text = "SP"


        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = " PAB"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 8.75
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Dolar Estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 10000
            lblnum3.Text = " USD"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Quetzal" Then
            lblr3.Text = Val(txtcodigo3.Text) * 7.68
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 24.66
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Colón Costarisense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 595.4
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Cordoba Nicaraguence" Then
            lblr3.Text = Val(txtcodigo3.Text) * 34.87
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Dolar Canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.32
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Peso Mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 22.14
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Balboa" And cbxsalida3.Text = "Sol Peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 3.56
            lblnum3.Text = "S/"

        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Cordoba nicaraguense" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.25
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Dolar Estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.029
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Quetzal" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.22
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.71
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Colón Costarisense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 17.09
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.029
            lblnum3.Text = "PAB"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Dolar Canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.038
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Peso Mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.63
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Cordoba nicaraguense" And cbxsalida3.Text = "Sol Peruano" Then
            lblr3.Text = (Val(txtcodigo3.Text) * 0.1)
            lblnum3.Text = "S/"


        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Dolar Canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 6.63
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Dolar Estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.76
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Quetzal" Then
            lblr3.Text = Val(txtcodigo3.Text) * 5.84
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 18.69
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Colón Costarisense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 451.83
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Cordoba Nicaraguence" Then
            lblr3.Text = Val(txtcodigo3.Text) * 26.4
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Peso Mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 16.68
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.76
            lblnum3.Text = "S/"
        ElseIf cbxentrada3.Text = "Dolar Canadiense" And cbxsalida3.Text = "Sol Peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 2.71
            lblnum3.Text = "S/"

        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Peso Mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.4
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Dolar Estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.046
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Quetzal" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.35
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.12
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Colón Costarisense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 27.09
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.046
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Cordoba Nicaraguence" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.59
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Dolar Canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.06
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Peso Mexicano" And cbxsalida3.Text = "Sol Peruano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.16
            lblnum3.Text = "$"


        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Sol Peruano" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "S/"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Colón Salvadoreño" Then
            lblr3.Text = Val(txtcodigo3.Text) * 2.44
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Dolar Estadounidense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.28
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Quetzal" Then
            lblr3.Text = Val(txtcodigo3.Text) * 2.17
            lblnum3.Text = "Q"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Lempira" Then
            lblr3.Text = Val(txtcodigo3.Text) * 6.95
            lblnum3.Text = "L"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Colón Costarisense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 166.41
            lblnum3.Text = "₡"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Balboa" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.28
            lblnum3.Text = "$"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Cordoba Nicaraguence" Then
            lblr3.Text = Val(txtcodigo3.Text) * 9.81
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Dolar Canadiense" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.37
            lblnum3.Text = "C$"
        ElseIf cbxentrada3.Text = "Sol Peruano" And cbxsalida3.Text = "Peso Mexicano" Then
            lblr3.Text = Val(txtcodigo3.Text) * 6.14
            lblnum3.Text = "$"
        End If

    End Sub
End Class
