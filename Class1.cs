using System;

public class KodePos
{
	string n = Console.ReadLine();
	public getkodepos()
	{
		string[11] a;
		a = new string["Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"];
		int[11] b;
		b = [40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273];
		bool cek = false;
		string n = Console.ReadLine(string n);
		for(int i = 0; i < a[i].Length; i++)
        {
			if( n = a[i])
			{
				cek = true;
				if (cek = true)
				{
					for(int j = 0;  j < b[i].Length; j++)
					{
						if (i == j)
						{
							return b[j];
						}
					}
				}
			}
		}
	}
}
