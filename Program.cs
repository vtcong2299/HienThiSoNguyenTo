using System;


namespace HienThiSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int quantityNum;
            int i;
            int countNum=0;
            Console.WriteLine("In ra cac so nguyen to theo thu tu tang dan: ");
            Console.WriteLine("*******************************************: ");
            Console.Write("Nhap vao so luong so nguyen to can in ra: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out quantityNum))
                {
                    break;
                }
                else
                {
                   Console.Write("Nhap lai so luong so nguyen to can in ra: "); 
                }
            }
            for(num=0;;num++)
            {
                int count=0;
                
                if(countNum<quantityNum)
                {
                    if (num>=2)
                    {
                        for (i=2;i<num;i++)
                        {
                            if(num%i==0)
                            {
                                count++;
                            }
                        }
                        if(count==0)
                        {
                            Console.Write("{0,5}",num);
                            countNum++;
                        }
                    }
                }
                else
                {
                    break;
                }
                
                
            }
            Console.ReadKey();

            
           
        }
    }
}