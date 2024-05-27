using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120201021_Abdulkerim_Pekince_lab5
{
    public partial class Game4x4 : Form
    {
        string user;
        int cho;
        public Game4x4()
        {
            InitializeComponent();
        }
        public Game4x4(string u, int i)
        {
            InitializeComponent();
            user = u;
            cho = i;
        }

        string[] XOX = new string[16] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        Random rnd = new Random();
        
        int noloseandwin(string[] xox1, int k, string t)
        {
            switch(k)
            {
                case 0:
                    if (xox1[1] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[2] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[4] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    return -1;

                case 1:
                    if (xox1[0] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[2] == t)
                    {
                        if (xox1[0] == "") return 0;
                        else if (xox1[3] == "") return 3;
                    }
                    if (xox1[3] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if(t == "x")
                    {
                        if (xox1[0] == "")
                        {
                            if (xox1[2] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 0; else return 2;
                            }
                            else return 0;
                        }
                        else if (xox1[2] == "") return 2;
                        else return -1;
                    }
                    else return -1;

                case 2:
                    if (xox1[0] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[1] == t)
                    {
                        if (xox1[0] == "") return 0;
                    }
                    if (xox1[3] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[1] == t)
                    {
                        if (xox1[3] == "") return 3;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if(t == "x")
                    {
                        if (xox1[1] == "")
                        {
                            if (xox1[3] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 1; else return 3;
                            }
                            else return 1;
                        }
                        else if (xox1[3] == "") return 3;
                        else return -1;
                    }
                    else return -1;

                case 3:
                    if (xox1[1] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[2] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[7] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    return -1;

                case 4:
                    if (xox1[0] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[0] == "") return 0;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[12] == "") return 12;
                    }
                    if (xox1[12] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if(t == "x")
                    {
                        if (xox1[0] == "")
                        {
                            if (xox1[8] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 0; else return 8;
                            }
                            else return 0;
                        }
                        else if (xox1[8] == "") return 8;
                        else return -1;
                    }
                   else return -1;

                case 5:
                    if (xox1[0] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[0] == "") return 0;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[15] == "") return 15;
                    }
                    if (xox1[15] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[2] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[1] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[4] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    if (xox1[7] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if(t == "x")
                    {
                        if (xox1[6] == "")
                        {
                            if (xox1[10] == "")
                            {
                                if (xox1[9] == "")
                                {
                                    int random = rnd.Next(0, 3);
                                    if (random == 0) return 6;
                                    else if (random == 1) return 10;
                                    else return 9;
                                }
                                int rand = rnd.Next(0, 2);
                                if (rand == 0) return 6;
                                else return 10;
                            }
                            else return 6;
                        }
                        else if (xox1[10] == "")
                        {
                            if (xox1[9] == "")
                            {
                                int rando = rnd.Next(0, 2);
                                if (rando == 0) return 10;
                                else return 9;
                            }
                            else return 10;
                        }
                        else if (xox1[9] == "") return 9;
                        else return -1;
                    }
                    else return -1;

                case 6:
                    if (xox1[1] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[3] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[3] == "") return 3;
                    }
                    if (xox1[12] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[12] == "") return 12;
                    }
                    if (xox1[2] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[7] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    if (xox1[4] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    if (t == "x")
                    {
                        if (xox1[5] == "")
                        {
                            if (xox1[10] == "")
                            {
                                if (xox1[9] == "")
                                {
                                    int random = rnd.Next(0, 3);
                                    if (random == 0) return 5;
                                    else if (random == 1) return 10;
                                    else return 9;
                                }
                                int rand = rnd.Next(0, 2);
                                if (rand == 0) return 5;
                                else return 10;
                            }
                            else return 5;
                        }
                        else if (xox1[10] == "")
                        {
                            if (xox1[9] == "")
                            {
                                int rando = rnd.Next(0, 2);
                                if (rando == 0) return 10;
                                else return 9;
                            }
                            else return 10;
                        }
                        else if (xox1[9] == "") return 9;
                        else return -1;
                    }
                    else return -1;

                case 7:
                    if (xox1[10] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[3] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[3] == "") return 3;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[15] == "") return 15;
                    }
                    if (xox1[15] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (t == "x")
                    {
                        if (xox1[11] == "")
                        {
                            if (xox1[3] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 11; else return 3;
                            }
                            else return 11;
                        }
                        else if (xox1[3] == "") return 3;
                        else return -1;
                    }
                    else return -1;

                case 8:
                    if (xox1[5] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[2] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[4] == t)
                    {
                        if (xox1[0] == "") return 0;
                    }
                    if (xox1[0] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    if (xox1[4] == t)
                    {
                        if (xox1[12] == "") return 12;
                    }
                    if (xox1[12] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (t == "x")
                    {
                        if (xox1[12] == "")
                        {
                            if (xox1[4] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 12; else return 4;
                            }
                            else return 12;
                        }
                        else if (xox1[4] == "") return 4;
                        else return -1;
                    }
                    else return -1;

                case 9:
                    if (xox1[4] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    if (xox1[12] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[12] == "") return 12;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[3] == "") return 3;
                    }
                    if (xox1[3] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[1] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (t == "x")
                    {
                        if (xox1[5] == "")
                        {
                            if (xox1[10] == "")
                            {
                                if (xox1[6] == "")
                                {
                                    int random = rnd.Next(0, 3);
                                    if (random == 0) return 5;
                                    else if (random == 1) return 10;
                                    else return 6;
                                }
                                int rand = rnd.Next(0, 2);
                                if (rand == 0) return 5;
                                else return 10;
                            }
                            else return 5;
                        }
                        else if (xox1[10] == "")
                        {
                            if (xox1[6] == "")
                            {
                                int rando = rnd.Next(0, 2);
                                if (rando == 0) return 10;
                                else return 6;
                            }
                            else return 10;
                        }
                        else if (xox1[6] == "") return 6;
                        else return -1;
                    }
                    else return -1;

                case 10:
                    if (xox1[7] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    if (xox1[0] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[0] == "") return 0;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[15] == "") return 15;
                    }
                    if (xox1[15] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[2] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[2] == "") return 2;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (t == "x")
                    {
                        if (xox1[5] == "")
                        {
                            if (xox1[9] == "")
                            {
                                if (xox1[6] == "")
                                {
                                    int random = rnd.Next(0, 3);
                                    if (random == 0) return 5;
                                    else if (random == 1) return 9;
                                    else return 6;
                                }
                                int rand = rnd.Next(0, 2);
                                if (rand == 0) return 5;
                                else return 9;
                            }
                            else return 5;
                        }
                        else if (xox1[9] == "")
                        {
                            if (xox1[6] == "")
                            {
                                int rando = rnd.Next(0, 2);
                                if (rando == 0) return 9;
                                else return 6;
                            }
                            else return 9;
                        }
                        else if (xox1[6] == "") return 6;
                        else return -1;
                    }
                    else return -1;

                case 11:
                    if (xox1[1] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[1] == "") return 1;
                    }
                    if (xox1[3] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    if (xox1[7] == t)
                    {
                        if (xox1[3] == "") return 3;
                    }
                    if (xox1[7] == t)
                    {
                        if (xox1[15] == "") return 15;
                    }
                    if (xox1[15] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (t == "x")
                    {
                        if (xox1[15] == "")
                        {
                            if (xox1[7] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 15; else return 7;
                            }
                            else return 15;
                        }
                        else if (xox1[7] == "") return 7;
                        else return -1;
                    }
                    else return -1;

                case 12:
                    if (xox1[9] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[4] == t)
                    {
                        if (xox1[8] == "") return 8;
                    }
                    if (xox1[8] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    return -1;

                case 13:
                    if (xox1[10] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    if (xox1[7] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[12] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[12] == "") return 12;
                    }
                    if (xox1[15] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[15] == "") return 15;
                    }
                    if (t == "x")
                    {
                        if (xox1[14] == "")
                        {
                            if (xox1[12] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 14; else return 12;
                            }
                            else return 14;
                        }
                        else if (xox1[12] == "") return 12;
                        else return -1;
                    }
                    else return -1;

                case 14:
                    if (xox1[4] == t)
                    {
                        if (xox1[9] == "") return 9;
                    }
                    if (xox1[9] == t)
                    {
                        if (xox1[4] == "") return 4;
                    }
                    if (xox1[10] == t)
                    {
                        if (xox1[6] == "") return 6;
                    }
                    if (xox1[6] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[12] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[12] == "") return 12;
                    }
                    if (xox1[15] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[15] == "") return 15;
                    }
                    if (t == "x")
                    {
                        if (xox1[15] == "")
                        {
                            if (xox1[13] == "")
                            {
                                int random = rnd.Next(0, 2);
                                if (random == 0) return 15; else return 13;
                            }
                            else return 15;
                        }
                        else if (xox1[13] == "") return 13;
                        else return -1;
                    }
                    else return -1;

                case 15:
                    if (xox1[10] == t)
                    {
                        if (xox1[5] == "") return 5;
                    }
                    if (xox1[5] == t)
                    {
                        if (xox1[10] == "") return 10;
                    }
                    if (xox1[11] == t)
                    {
                        if (xox1[7] == "") return 7;
                    }
                    if (xox1[7] == t)
                    {
                        if (xox1[11] == "") return 11;
                    }
                    if (xox1[13] == t)
                    {
                        if (xox1[14] == "") return 14;
                    }
                    if (xox1[14] == t)
                    {
                        if (xox1[13] == "") return 13;
                    }
                    return -1;

                default: return -1;
            }
        }

        int PC_choose(string[] xox) // bilgisayarın hamlesini kesin olaraktan belirleyen fonksiyon
        {

            for (int i = 0; i < 16; i++)
            {
                if (xox[i] == "o")
                {
                    int result = noloseandwin(xox, i, "o");
                    if (result != -1)
                    {
                        return result;
                    }
                }
            }
            for (int i = 0; i < 16; ++i)
            {
                if (xox[i] == "x")
                {
                    int result = noloseandwin(xox, i, "x");
                    if (result != -1)
                    {
                        return result;
                    }
                }
            }
            for (int i = 0; i < 16; i++)
            {
                if (xox[i] == "")
                {
                    while (true)
                    {
                        int choice = rnd.Next(0, 16);
                        if (xox[choice] == "") return choice;
                    }
                }
            }
            return -1;
        }

        void changeWithO(int i) // bilgisayarın hamlesinin hesaplanmasından sonra butonun resmini O yapan ve XOX arrayine ekleyen fonksiyon
        {
            switch (i)
            {
                case 0:
                    this.button1.BackgroundImage = Properties.Resources.o;
                    XOX[0] = "o";
                    break;

                case 1:
                    this.button2.BackgroundImage = Properties.Resources.o;
                    XOX[1] = "o";
                    break;

                case 2:
                    this.button3.BackgroundImage = Properties.Resources.o;
                    XOX[2] = "o";
                    break;

                case 3:
                    this.button4.BackgroundImage = Properties.Resources.o;
                    XOX[3] = "o";
                    break;

                case 4:
                    this.button5.BackgroundImage = Properties.Resources.o;
                    XOX[4] = "o";
                    break;

                case 5:
                    this.button6.BackgroundImage = Properties.Resources.o;
                    XOX[5] = "o";
                    break;

                case 6:
                    this.button7.BackgroundImage = Properties.Resources.o;
                    XOX[6] = "o";
                    break;

                case 7:
                    this.button8.BackgroundImage = Properties.Resources.o;
                    XOX[7] = "o";
                    break;

                case 8:
                    this.button9.BackgroundImage = Properties.Resources.o;
                    XOX[8] = "o";
                    break;

                case 9:
                    this.button10.BackgroundImage = Properties.Resources.o;
                    XOX[9] = "o";
                    break;

                case 10:
                    this.button11.BackgroundImage = Properties.Resources.o;
                    XOX[10] = "o";
                    break;

                case 11:
                    this.button12.BackgroundImage = Properties.Resources.o;
                    XOX[11] = "o";
                    break;

                case 12:
                    this.button13.BackgroundImage = Properties.Resources.o;
                    XOX[12] = "o";
                    break;

                case 13:
                    this.button14.BackgroundImage = Properties.Resources.o;
                    XOX[13] = "o";
                    break;

                case 14:
                    this.button15.BackgroundImage = Properties.Resources.o;
                    XOX[14] = "o";
                    break;

                case 15:
                    this.button16.BackgroundImage = Properties.Resources.o;
                    XOX[15] = "o";
                    break;

                default:
                    break;
            }
        }

        int checkResult(string[] xox, string t) // her hamleden sonra oyunu kontrol eden fonksiyon
        {
            if (xox[0] == t)
            {
                if (xox[1] == t)
                {
                    if (xox[2] == t) return 1;
                }
                if (xox[5] == t)
                {
                    if (xox[10] == t) return 1;
                }
                if (xox[4] == t)
                {
                    if (xox[8] == t) return 1;
                }
            }
            if (xox[3] == t)
            {
                if (xox[2] == t)
                {
                    if (xox[1] == t) return 1;
                }
                if (xox[6] == t)
                {
                    if (xox[9] == t) return 1;
                }
                if (xox[7] == t)
                {
                    if (xox[11] == t) return 1;
                }
            }
            if (xox[12] == t)
            {
                if (xox[4] == t)
                {
                    if (xox[8] == t) return 1;
                }
                if (xox[9] == t)
                {
                    if (xox[6] == t) return 1;
                }
                if (xox[13] == t)
                {
                    if (xox[14] == t) return 1;
                }
            }
            if (xox[15] == t)
            {
                if (xox[14] == t)
                {
                    if (xox[13] == t) return 1;
                }
                if (xox[10] == t)
                {
                    if (xox[5] == t) return 1;
                }
                if (xox[11] == t)
                {
                    if (xox[7] == t) return 1;
                }
            }
            if (xox[7] == t)
            {
                if (xox[6] == t)
                {
                    if (xox[5] == t) return 1;
                }
                if (xox[10] == t)
                {
                    if (xox[13] == t) return 1;
                }
            }
            if (xox[11] == t)
            {
                if (xox[10] == t)
                {
                    if (xox[9] == t) return 1;
                }
                if (xox[6] == t)
                {
                    if (xox[1] == t) return 1;
                }
            }
            if (xox[14] == t)
            {
                if (xox[6] == t)
                {
                    if (xox[10] == t) return 1;
                }
                if (xox[9] == t)
                {
                    if (xox[4] == t) return 1;
                }
            }
            if (xox[13] == t)
            {
                if (xox[9] == t)
                {
                    if (xox[5] == t) return 1;
                }
            }
            if (xox[8] == t)
            {
                if (xox[9] == t)
                {
                    if (xox[10] == t) return 1;
                }
                if (xox[5] == t)
                {
                    if (xox[2] == t) return 1;
                }
            }
            if (xox[4] == t)
            {
                if (xox[6] == t)
                {
                    if (xox[5] == t) return 1;
                }
            }
            if (xox[1] == t)
            {
                if (xox[9] == t)
                {
                    if (xox[5] == t) return 1;
                }
            }
            if (xox[2] == t)
            {
                if (xox[6] == t)
                {
                    if (xox[10] == t) return 1;
                }
            }
            return 0;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fr = new Form2(user, cho);
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (XOX[0] == "")
            {
                int start = checkResult(XOX, "x");
                if (start == 1)   // oyun çoktan bitmiş mi diye kontrol ediliyor
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    start = checkResult(XOX, "o");
                    if (start == 1)   // oyun çoktan bitmiş mi diye kontrol ediliyor
                    {
                        MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                    }
                    else
                    {
                        this.button1.BackgroundImage = Properties.Resources.x;
                        XOX[0] = "x"; // oyuncunun hamlesi gerçekleştiriliyor
                        int result = checkResult(XOX, "x"); // oyuncunun hamlesinden sonra kazanmış mı konrolü
                        if (result == 1)
                        {
                            // oyuncunun kazanması durumu
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX); // bilgisayarın hamlesi belirleniyor
                            if (choice == -1) // XOX arrayinin doluluğu kontrol ediliyor 
                            {
                                // XOX arrayinin kimsenin kazanmamasına rağmen dolu olduğu saptandı = beraberlik durumu
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice); // bilgisayarın hamlesi oynanıyor
                                result = checkResult(XOX, "o"); // bilgisayar kazanmış mı kontrol ediliyor
                                if (result == 1)
                                {
                                    // bilgisayarın kazanma durumu
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }
                    }
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[1] == "")
                    {
                        this.button2.BackgroundImage = Properties.Resources.x;
                        XOX[1] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[2] == "")
                    {
                        this.button3.BackgroundImage = Properties.Resources.x;
                        XOX[2] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[3] == "")
                    {
                        this.button4.BackgroundImage = Properties.Resources.x;
                        XOX[3] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[4] == "")
                    {
                        this.button5.BackgroundImage = Properties.Resources.x;
                        XOX[4] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[5] == "")
                    {
                        this.button6.BackgroundImage = Properties.Resources.x;
                        XOX[5] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[6] == "")
                    {
                        this.button7.BackgroundImage = Properties.Resources.x;
                        XOX[6] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[7] == "")
                    {
                        this.button8.BackgroundImage = Properties.Resources.x;
                        XOX[7] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[8] == "")
                    {
                        this.button9.BackgroundImage = Properties.Resources.x;
                        XOX[8] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[9] == "")
                    {
                        this.button10.BackgroundImage = Properties.Resources.x;
                        XOX[9] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[10] == "")
                    {
                        this.button11.BackgroundImage = Properties.Resources.x;
                        XOX[10] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[11] == "")
                    {
                        this.button12.BackgroundImage = Properties.Resources.x;
                        XOX[11] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[12] == "")
                    {
                        this.button13.BackgroundImage = Properties.Resources.x;
                        XOX[12] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[13] == "")
                    {
                        this.button14.BackgroundImage = Properties.Resources.x;
                        XOX[13] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[14] == "")
                    {
                        this.button15.BackgroundImage = Properties.Resources.x;
                        XOX[14] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int start = checkResult(XOX, "x");
            if (start == 1)
            {
                MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
            }
            else
            {
                start = checkResult(XOX, "o");
                if (start == 1)
                {
                    MessageBox.Show("Oyun çoktan bitti! Tekrardan oynamak için Restart butonuna basınız.");
                }
                else
                {
                    if (XOX[15] == "")
                    {
                        this.button16.BackgroundImage = Properties.Resources.x;
                        XOX[15] = "x";
                        int result = checkResult(XOX, "x");
                        if (result == 1)
                        {
                            MessageBox.Show("Oyuncu Kazandı");
                        }
                        else
                        {
                            int choice = PC_choose(XOX);
                            if (choice == -1)
                            {
                                MessageBox.Show("Beraberlik");
                            }
                            else
                            {
                                changeWithO(choice);
                                result = checkResult(XOX, "o");
                                if (result == 1)
                                {
                                    MessageBox.Show("Bilgisayar Kazandı");
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                // XOX arrayi başlangıçtaki haline döndürülüyor
                XOX[i] = "";
            }
            // butondaki resimler temizleniyor
            button1.BackgroundImage = null; button2.BackgroundImage = null; button3.BackgroundImage = null;
            button4.BackgroundImage = null; button5.BackgroundImage = null; button6.BackgroundImage = null;
            button7.BackgroundImage = null; button8.BackgroundImage = null; button9.BackgroundImage = null;
            button10.BackgroundImage = null; button11.BackgroundImage = null;button12.BackgroundImage = null;
            button13.BackgroundImage = null; button14.BackgroundImage = null; button15.BackgroundImage = null;
            button16.BackgroundImage = null;
        }
    }
}
