using RedBlackCS;

namespace Test
{
	public class MyObj
	{
		private int     intMyObjKey;
		private string  myData;
		
		public int Key
		{
			get
            {
				return intMyObjKey;
			}
			
			set
			{
				intMyObjKey = value;
			}
		}
		public string Data
		{
			get
            {
				return myData;
			}
			
			set
			{
				myData = value;
			}
		}
		
		public MyObj(int key, string data) 
        {
			this.Key    = key;
			this.Data   = data;
		}
		
		public override string ToString()
		{
			return intMyObjKey.ToString();
		}
	}
}
