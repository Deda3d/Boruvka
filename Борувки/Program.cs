using System;
using System.Collections;

int[][] v = new int[12][];
v[1] = new int[] { 7, 4, 8 };
v[2] = new int[] { 7, 9, 3, 5 };
v[3] = new int[] { 2, 5 };
v[4] = new int[] { 1, 7, 8, 9 };
v[5] = new int[] { 8, 10, 3, 2, 9 };
v[6] = new int[] { 11, 10 };
v[7] = new int[] { 1, 4, 9, 2, 11 };
v[8] = new int[] { 1, 4, 5, 10 };
v[9] = new int[] { 4, 7, 2, 5 };
v[10] = new int[] { 8, 5, 6, 11 };
v[11] = new int[] { 7, 6, 10 };

double[] l = new double[2000];
bool[] lconc = new bool[2000];
l[17] = 5.4;
l[14] = 1.0;
l[18] = 1.01;
l[27] = 7.0;
l[29] = 0.9;
l[23] = 0.61;
l[25] = 1.11;
l[32] = 0.61;
l[35] = 0.5;
l[41] = 1.0;
l[47] = 5.7;
l[48] = 1.05;
l[49] = 0.51;
l[58] = 0.8;
l[510] = 0.6;
l[53] = 0.5;
l[52] = 1.11;
l[59] = 1.1;
l[611] = 0.81;
l[610] = 0.75;
l[71] = 5.4;
l[74] = 5.7;
l[79] = 6.4;
l[72] = 7.0;
l[711] = 7.4;
l[81] = 1.01;
l[84] = 1.05;
l[85] = 0.8;
l[810] = 1.2;
l[94] = 0.51;
l[97] = 6.4;
l[92] = 0.9;
l[95] = 1.1;
l[108] = 1.2;
l[105] = 0.6;
l[106] = 0.75;
l[1011] = 1.5;
l[117] = 7.4;
l[116] = 0.81;
l[1110] = 1.5;

ArrayList lused = new ArrayList();
string ll = "";
int jmin = 999999999;

for(int i = 1; i < v.Length; i++)
{
    double min = 999999;
    for(int j = 0; j < v[i].Length; j++)
    {
        ll = i.ToString() + v[i][j].ToString();
        if (l[Convert.ToInt32(ll)] < min)
        {
            min = l[Convert.ToInt32(ll)];
            jmin = v[i][j];
        }
    }
    if(!lused.Contains(min)) lused.Add(min);
    ll = i.ToString() + jmin.ToString();
    lconc[Convert.ToInt32(ll)] = true;
    ll = jmin.ToString() + i.ToString();
    lconc[Convert.ToInt32(ll)] = true;
}
for (int i = 0; i < lconc.Length; i++) if (lconc[i] == true) Console.WriteLine(i);