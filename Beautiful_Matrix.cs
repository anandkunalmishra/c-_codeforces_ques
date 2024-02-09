using System;
namespace codeforces{
    class Program{
        public static void Main(string[] args){
            int[,] arr = new int [5,5];
            for(int i=0;i<5;i++){
                string[] input = Console.ReadLine().Split();
                for(int j=0;j<5;j++){
                    arr[i,j] = int.Parse(input[j]);
                    if(arr[i,j]==1){
                        Console.WriteLine(Math.Abs(i-2)+Math.Abs(j-2));
                        return;
                    }
                }
            }
            return;
        }
    }
}