using System;
namespace codeforces{
    class Program{
        public static void Main(string[] args){
            int length,time;
            string[] input = Console.ReadLine().Split();
            length = int.Parse(input[0]);
            time = int.Parse(input[1]);
            char[] arr= Console.ReadLine().ToCharArray(); 
            while(time>0){
                for(int i=0;i<length-1;i++){
                    if(arr[i]=='B' && arr[i+1]=='G'){
                        arr[i]='G';
                        arr[i+1] = 'B';
                        i++;
                    }
                }
                time--;
            }
            string result = new string(arr);
            System.Console.WriteLine(result);
        }
    }
}