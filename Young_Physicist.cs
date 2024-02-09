using System;
namespace codeforces{
    class Program{
        public static void Main(string[] args){
            int t;
            int x=0;
            int y=0;
            int z=0;
            t=Convert.ToInt32(Console.ReadLine());
            while(t>0){
                string[] input = Console.ReadLine().Split();
                x += Convert.ToInt32(input[0]);
                y += Convert.ToInt32(input[1]);
                z += Convert.ToInt32(input[2]);
                t--;
            }
            if(x==0 && y==0 && z==0){
                Console.WriteLine("YES");
            }
            else{
                Console.WriteLine("NO");
            }
        }
    }
}