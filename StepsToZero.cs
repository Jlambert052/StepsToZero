namespace StepsToZero {

    public class Solution {

            public void Steps(int num) {
                int nbr = num;
                int steps = 0;
                while(num != 0) {
                    if(num % 2 ==0) {
                        num = num / 2;
                        steps++;
                    }
                    else if(num % 2 == 1) {
                        num -= 1;
                        steps++;
                    }
                }
                System.Console.WriteLine($"The starting number was {nbr}, it took {steps} iterations to bring it to zero.");
            }

    }

}
