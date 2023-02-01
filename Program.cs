using System;


namespace BubbleSortProgram {

    class BubbleSort {
        protected int[] data = new int[20];
        protected int num;
        private bool flag = true;

        public void SetNumbersToSort(int _n){
            num = _n;
        }

        public void AcceptAllData(){
            for (int i = 0; i < num; i++){
                Console.Write("Data {0}: ", i + 1);
                int currentData = Convert.ToInt32(Console.ReadLine());
                data[i] = currentData;
            }
        }

        public void SortData(){
            SetFlag(true);
            for (int i = 1; i < num; i++){
                int prevData = data[i - 1];
                int currentData = data[i];

                if (prevData > currentData){
                    int temporaryData = data[i];
                    data[i] = prevData;
                    data[i - 1] = temporaryData;

                    SetFlag(false);
                }
            }
        }

        public void DisplayData(){
            for (int i = 0; i < num; i++){
                Console.WriteLine("Data {0} is {1}\n", i + 1, data[i]);
            }
        }

        public bool GetFlag(){
            return flag;
        }

        public void SetFlag(bool newFlag){
            flag = newFlag;
        }

    }

    class Program {

        public static void Main(String[] args){

            Console.Write("Enter the number of data to sort: ");
            int numbersToSort = Convert.ToInt32(Console.ReadLine());

            BubbleSort bubbleSort = new BubbleSort();

            bubbleSort.SetNumbersToSort(numbersToSort);

            bubbleSort.AcceptAllData();

            bubbleSort.SortData();

            while (bubbleSort.GetFlag() == false){
                bubbleSort.SortData();
            }

            bubbleSort.DisplayData();
        }

    }
}




// /* Teacher's code */
// /* This program is to demonstrate how a bubble sort works */
// using System;
// namespace bubble_sorting
// {
//     class Bubble
//     {
//         protected int num;
//         protected int[] data = new int[20];
//         // Assume the numbers are perfectly sorted
//         protected bool flag = true;

//         public void acceptData()
//         {
//             Console.WriteLine("Num of Accept Data {0}", getNumToSort());
//             for (int i = 0; i < getNumToSort(); i++)
//             {
//                 Console.WriteLine("Enter data? {0}", i);
//                 data[i] = Convert.ToInt32(Console.ReadLine());
//             }

//         }
//         //Receive the number of integer valus to sort
//         public void setNumToSort(int nums)
//         {
//             num = nums;
//         }
//         public int getNumToSort()
//         {
//             return num;
//         }

//         public void bubbleSortData()
//         {
//             flag = true;
//             int temp = 0;
//             //Console.WriteLine("Num to BubbleSort Size {0}",getNumToSort());
//             for (int i = 0; i < getNumToSort(); i++)
//             {
//                 Console.WriteLine("Data value: {0}", data[i]);
//                 if (data[i] > data[i + 1])
//                 {
//                     //Perform data swapping
//                     temp = data[i];
//                     data[i] = data[i + 1];
//                     Console.WriteLine("Swap Data {0}", data[i]);
//                     data[i + 1] = temp;
//                     flag = false;
//                 }
//             }
//         }
//         public void printBubbleSortData()
//         {
//             Console.WriteLine("_____________________");
//             for (int i = 0; i < getNumToSort(); i++)
//             {
//                 Console.WriteLine("Sorted Data {0}", data[i]);
//             }
//         }
//         class sortData
//         {
//             static void Main(string[] args)
//             {
//                 int nos;
//                 Bubble NewBubble = new Bubble();
//                 Console.WriteLine("Data Size?");
//                 nos = Convert.ToInt32(Console.ReadLine());
//                 //Console.ReadKey();
//                 Console.WriteLine("Num Data to Sort Size {0}", nos);
//                 NewBubble.setNumToSort(nos);
//                 NewBubble.acceptData();
//                 //Check the first pass of the sorting
//                 NewBubble.bubbleSortData();
//                 while (NewBubble.flag == false)
//                 {
//                     NewBubble.flag = true;
//                     NewBubble.bubbleSortData();
//                 }
//                 NewBubble.printBubbleSortData();
//             }
//         }
//     }
// }





