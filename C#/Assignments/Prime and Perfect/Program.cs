using System;

namespace Prime_and_Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int value = Convert.ToInt32(Console.ReadLine());

            PP obj = new PP();

            Boolean ret = obj.ChkPerfect(value);
            if(ret == true)
            {
                Console.WriteLine("Number is Perfect");
            }
            else
            {
                Console.WriteLine("Number is not Perfect");
            }

            Boolean ret1 = obj.ChkPrime(value);
            if(ret == true)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }

    class PP
    {
        public Boolean ChkPrime(int No)
        {
            int i = 0;

            for (i = 2; i <= No; i++)
            {
                if ((No % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public Boolean ChkPerfect(int No)
        {
            int sum = 0;

	        for(int i = 1 ; i < No ; i++)
	        {
		        if((No % i) == 0)
		        {
			        sum = sum + i;
		        }
	        }
	
	        if(sum == No)
	        {
		        return true;
	        }
	        else
	        {
		        return false;
	         }
        }
    }
}
