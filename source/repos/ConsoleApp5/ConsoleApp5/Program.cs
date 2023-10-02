Random z = new Random();
int nu = z.Next(9999);
string s = nu.ToString();
while (s.Length != 4)
{
    s = "0" + s;
}
Console.WriteLine(s);
char[] rr = s.ToCharArray();

int i =0;
string a = Convert.ToString(Console.ReadLine());
char[] qq = a.ToCharArray();

while (true)
{
    int m = 0;
    int n = 0;
    char o = '0';
    if (a == s)
    {
        Console.WriteLine("You are right");
        break;
    }
    else if(i<=5)
    {
        //Console.WriteLine(qq[0]);
        if(a.Length == 4)
        {
            for(int j=0;j<4; j++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (rr[j] == qq[y])
                    {
                        m += 1;
                        if (rr[j] != o)
                        {
                            o = qq[y];
                            n += 1;
                            //Console.WriteLine(o +"n"+ n + "rr" + rr[j] + "qq" + qq[y]);
                        }
                    }                
                }
            }
            Console.WriteLine($"符合{m}不重複{n}");
        }        
        Console.WriteLine("Try again");
        a = Convert.ToString(Console.ReadLine());
        qq = a.ToCharArray();
        i++;
    }
    else
    {
        Console.WriteLine("Fall");
        break;
    }
}
