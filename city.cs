using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class Class1
{
	public Class1()
	{
		public string name {  get; set; }
		public double temperature { get; set; }
		public int humidity { get; set; }
		public double windSpeed { get; set; }


		public Class1(string line, string separator)
		{
		string[] data = line.Split(separator);
		name = data[0];
		temperature = double.Parse(data[1].Replace('.',','));
		humidity = int.Parse(data[2].Replace('.', ','));
		windSpeed = double.Parse(data[3].Replace('.', ','));
		}

    }
}
