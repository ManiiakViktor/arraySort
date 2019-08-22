using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySort
{
    class Program
    {
        static void Main(string[] args)
        
            {
               
                int[] nums = new int[7];
                Console.WriteLine("enter 7 numbers ");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("{0}-е namber: ", i + 1);
                    nums[i] = Int32.Parse(Console.ReadLine());
                }

                
                int temp;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }

               
                Console.WriteLine("conclusion ");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i]);
                }
                Console.ReadLine();
            }
        }
    }
