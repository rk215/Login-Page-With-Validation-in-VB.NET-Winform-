Imports System.Text.RegularExpressions
Imports System.Data.SqlClient


Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress



        lbuser.Visible = True   'for Second Time User Want to Enter Username then Only Label lbUser is Display 
        UserLeftCharacter.Visible = True
        lbPass.Visible = False
        PassLeftCharacter.Visible = False

        Dim Email As String

        Email = TextBox1.Text      'PASSING TEXTBOX VALUE TO THE EMAIL STRING VARIABLE .

        If Email = "" Then
            lbuser.Text = "Maximum 25 character and  At(@),dot(.) and   @  after single.(dot) is Allowed."
        Else
            If Email.Length > 30 Then
                e.Handled = True
            Else

                'FOR USER HAVE TO KNOW HOW MUCH CHARACTER USER ARE TYPED IN USERNAME FIELD 
                UserLeftCharacter.Visible = True
                PassLeftCharacter.Visible = False
                'FOR FINDING LENGTH OF TEXTBOX .
                Dim i As Integer
                For i = 0 To Email.Length
                    UserLeftCharacter.Visible = True
                    PassLeftCharacter.Visible = False

                    If Email.Length() = 30 Then

                        If AscW(e.KeyChar) = 8 Then
                            e.Handled = False
                        Else
                            e.Handled = True
                        End If
                        UserLeftCharacter.Text = " Characters Are Out Of Range"
                    Else
                        UserLeftCharacter.Text = " Characters are Writen:" & i + 1
                    End If

                Next

                'NOW FINDING THE POSITION OF AT(@) AND .(DOT) CHARACTER IN USER TEXTBOX.

                Dim nemail As New Regex("^[a-z][a-zA-Z0-9.@_]*$", RegexOptions.IgnoreCase)  'FOR ALLOWING A-Z,a-z,0-9,DOT(.),@(AT)  BUT FIRST CHARACTER MUST BE BETWEEN A-Z 

                Email = TextBox1.Text   'PASS THE VALUE OF TEXTBOX TO EMAIL VARIABLE

                'FOR FIDING THE INDEX OF AT(@),DOT(.) AND SECOND DOT(.) WHICH DON'T ALLOW

                'BY DEFAULT ALL VARIABLE INDEX VALUE IS -1.THAT MEANS IF WE DON'T PUT ANY SYMBOL THEN INVALID ID MESSAGE WILL APEARS

                Dim indexof_at, indexofDot, second_at, second_dot_index As Integer

                indexof_at = Email.IndexOf("@")     'FINDING THE INDEX OF FIRST @ IN USERNME TEXTBOX.
                second_at = Email.IndexOf("@", indexof_at + 1)   'FINDING THE INDEX OF SECOND @ IN USERNME TEXTBOX.
                indexofDot = Email.IndexOf(".", indexof_at + 1)   'FINDING THE INDEX OF FIRST .(DOT) IN USERNME TEXTBOX AFTER @ .
                second_dot_index = Email.IndexOf(".", indexofDot + 1)
                'FOR CHECKING IS USER INPUT SYMBOL,CHARACTER,DIGIT IN USER ID OR NOT 

                If nemail.IsMatch(Email) And (Email.Length > 5) And indexof_at <> -1 And indexofDot <> -1 And
                                                    second_at = -1 And second_dot_index = -1 Then

                    lbuser.Text = "Email ID is Valid"      'MEANS ALL CONDITION ARE SATISFIED.
                Else
                    lbuser.Text = "Email ID not Valid"   'MEANS ALL CONDITION ARE NOT SATISFIED.
                End If


            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        'FOR DISPLAYING THE USER PASSWORD IN LABEL 
        If CheckBox1.Checked = True Then   'FOR CHECKING  WHETHER USER CHECKED(TICK THE MARK) THE CHECKBOX 

            lbShowPass.Visible = True  'VISIBLE SHOW PASSWORD LABEL
            lbShowPass.Text = TextBox2.Text     'PASSING TEXTBOX VALUE TO SHOW PASSWORD LABEL.

        Else

            lbShowPass.Visible = False    'It Means it is Unchecked .so we Disable the Label lbShowPass

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        'FOR CHECKING WHETHER THE USER TEXTBOX AND PASSWORD TEXTBX IS BLANK OR NOT 

        If (lbuser.Text = ("Email ID is Valid")) And (lbPass.Text = ("Password Is Valid")) Then
            'write you ADO.NET Code here

            MessageBox.Show("Congratulation, You Entered the  Right Email-ID", "Email Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            TextBox1.Clear()     'CLEARING THE TEXTBOX(USERNAME).
            TextBox2.Clear()    'CLEARING THE TEXTBOX(PASSWORD).
            lbShowPass.Visible = False     'VISIBLE SHOW PASSWORD LABEL
            lbuser.Visible = False          'DISABLE  USER LABEL.
            lbPass.Visible = False          'DISABLE PASSWORD LABEL.
            CheckBox1.Checked = False       'UNCHECKED THE SHOWING PASSWORD CHECKBOX.
            PassLeftCharacter.Visible = False   'DISABLE REMAINING CHARACTER LABEL FOR USERNAME
            UserLeftCharacter.Visible = False    'DISABLE REMAINING CHARACTER LABEL FOR PASSWORD

        Else

            MessageBox.Show("Sorry, You may input Wrong username or password " & vbNewLine & "or You Missed Some field" & vbNewLine & "Please Filled it", "Email Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Clear() 'CLEARING THE TEXTBOX(USERNAME).
            TextBox2.Clear() 'CLEARING THE TEXTBOX(PASSWORD).
            lbShowPass.Visible = False      'DISABLE  SHOWING PASSWORD LABEL.
            lbuser.Visible = False    'DISABLE  USER INDICATOR LABEL.
            lbPass.Visible = False   'DISABLE  PASSWORD INDICATOR LABEL.
            CheckBox1.Checked = False   'UNCHECKED THE PASSWORD SHOWING CHECKBOX.
        End If



    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        End   'FOR ENDING THE PROJECT

    End Sub

    Private Sub TextBox2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        lbuser.Visible = False
        UserLeftCharacter.Visible = False
        lbPass.Visible = True
        PassLeftCharacter.Visible = True
        Dim pass As String
        Dim c As Integer = 0

        lbPass.Visible = True    'for Second Time User Want to Enter Password then Only Label lbPass  is Display 

        'IN FIRST SPACE WE ERASE THE LABEL INFORMATION(FOR CHECKING VALID OR NOT). IF TEXTBOX IS BLANK
        If TextBox2.Text = "" Then
            lbPass.Text = "Length Greater than 4 and UnderScore and dot(.) are Allow"

        Else
            pass = TextBox2.Text
            If pass.Length > 14 Then    'FOR RESTRICT THE USER ONLY 30 CHARACTER ARE ALLOW

                e.Handled = True

            Else

                'FOR USER HAVE TO KNOW HOW MUCH CHARACTER USER ARE TYPED IN PASSWORD FIELD 

                Dim i As Integer
                For i = 0 To pass.Length


                    UserLeftCharacter.Visible = False
                    PassLeftCharacter.Visible = True
                    lbuser.Visible = False
                    If pass.Length() = 14 Then
                        PassLeftCharacter.Text = " Characters Are Out Of Range"
                        If AscW(e.KeyChar) = 8 Then
                            e.Handled = False
                        Else
                            e.Handled = True
                        End If

                    Else
                        If TextBox2.Text = "" Then
                            PassLeftCharacter.Visible = False
                            PassLeftCharacter.Text = " Characters are Writen: 0"
                        Else
                            PassLeftCharacter.Visible = True
                            PassLeftCharacter.Text = " Characters are Writen:" & i + 1

                        End If
                    End If


                Next

                Dim npass As New Regex("^[0-9a-z_][A-Z0-9._]*$", RegexOptions.IgnoreCase)   'FOR ALLOWING ONLY 0-9 ,A-Z,a-z,.(DOT),_(UNDERSCOR) ARE ALLOW

                'YOU MUST HAVE PUT UNDERSCORE AND DOT IN PASWORD BOX 

                pass = TextBox2.Text

                Dim id_of_dot, id_of_Ud, second_id_of_dot, second_id_of_Ud As Integer

                'BY DEFAULT THE VALUE OF DOT(.) AND UNDERSCORE(_) IS -1 AND AFTER PUT CHARACTER IT'S VALUE CHANGED FROM -1 TO 0.


                id_of_Ud = pass.IndexOf("_")   'FINDING THE INDEX OF UNDERSCORE CHARACTER

                id_of_dot = pass.IndexOf(".")     'FINDING THE INDEX OF DOT CHARACTER 

                second_id_of_dot = pass.IndexOf(".", id_of_dot + 1)   'FOR NOT ALLOWING ANTHER DOT(.)

                second_id_of_Ud = pass.IndexOf("_", id_of_Ud + 1)       ''FOR NOT ALLOWING ANTHER UNDERSCORE(_)


                'WE HAVE TO CHECK WHETHER USER INPUT RIGHT ENTRIES OF NOT 

                'WE CAN NOT ALLOW DOT(.) OR UNDERSCORE(_) FOR TWO OR MORE TIMES  SO THE CONDITION IS HERE    (second_id_of_dot = -1 And second_id_of_Ud = -1)

                If npass.IsMatch(pass) And pass.Length > 4 And id_of_Ud <> -1 And id_of_dot <> -1 And (second_id_of_dot = -1 And second_id_of_Ud = -1) Then  'HERE WE USE ISMATCH METHOD FOR CHECKING THE CONDTION FROM THE PASSWORD TEXTBOX 

                    lbPass.Text = "Password Is Valid"

                Else
                    lbPass.Text = "Password Is Invalid"

                End If

            End If
        End If




    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        'For Displaying Password Dynamically  When the CheckBox is Checked(true)


        If CheckBox1.Checked = True Then  'FOR CHECKING  WHETHER USER CHECKED(TICK THE MARK) THE CHECKBOX 
            lbShowPass.Visible = True
            lbShowPass.Text = TextBox2.Text       'IT Means CheckBox Is Checked , so we Display  Password Dynamically
        Else
            lbShowPass.Visible = False      'it Means We CheckedBox Is Unchecked . So we Cannot display Label lbPassShow  in Form. 


        End If

    End Sub
End Class
