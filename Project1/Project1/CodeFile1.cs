using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


class OddEvenDemo
{
    static void Main() {
        int number, reminder;

    number=Int32.Parse(

        Interaction.InputBox(
        "Input name: ","Prüfung"
        )
        );
        
        reminder = number%2;
        string txt = "Sie ausfühlen";

    txt+= (reminder==0?"Chetnoe":"Nechetnoe")+" chislo!";
        MessageBox.Show(txt);
        }
        }