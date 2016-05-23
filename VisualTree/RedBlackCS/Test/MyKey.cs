using System;

namespace Test
{
	//
	// demonstrates using a key as a separate object
	//
	
	public class MyKey : IComparable
	{
		private int intMyKey;
		public	int Key
		{
			get
			{
				return intMyKey;
			}
			
			set
			{
				intMyKey = value;
			}
		}
		
		public MyKey(int key) 
		{
			intMyKey = key;
		}
		
		public int CompareTo(object key)
		{
			if(Key > ((MyKey)key).Key)
				return 1;
			else
				if(Key < ((MyKey)key).Key)
				return -1;
			else
				return 0;
		}

		public override string ToString()
		{
			return intMyKey.ToString();
		}
	}
}