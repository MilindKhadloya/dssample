using System;
using System.IO;

//Queue implementation using Array

namespace MilindQuene
{
class Queue
{
   private int initialSize;
   private int [] Queuearray = new int [initialSize];
   private int Head ; 
   private int Tail;
   private int ActualQueueSize = 0;
   
   //Queue initilization 
   public Queue()
   {
	   initialSize = 20;
	   Head = -1;
	   Tail =-1;
   }
   
   public Queue( int newsize)
   {
	   initialSize = newsize;
	   Head = -1;
	   Tail =-1;
   }
   public void Enqueue(int element)
   {
	   if (isQueueFull())
	   {
		 //resize the array and copy the element over functionality is not implmented
		 Console.WriteLine("Queue is full");
         return;		 
	   }
	   Tail ++;
	   ActualQueueSize++;
	   Queuearray[Tail] = element;
	   if (Head==-1)
	   {
		   Head = Tail;
	   }
		   
	   if (Tail >= initialSize)
	   {
		   //Rearrange array and reset Head and tail, if tail reaches to max postion reset head and tail
		   reArrangeArray();
		   
	   }
   }
   
   public int DeQueue()
   {
	   if (isQueueEmpty())
	   {
		   Console.WriteLine ("Queue is Empty");
		   return -1;
	   }
	   
	   int value = Queuearray[Head];
	   Head++;
	   ActualQueueSize--;
	   if (Head > Tail)
	   {
		   Head =-1;
		   Tail = -1;
	   }
	   return value;
	   //Rearrange array
  
   }
   
   private Boolean isQueueEmpty()
   {
	   if ((Head > Tail ) || (Tail == -1) || (Head == -1))
		   return true;
	   else
		   return false;
   }
   
   private bool isQueueFull()
   {
	   if ((ActualQueueSize -1) >= initialSize)
		   return true;
	   else 
		   return false;
   }
   
   private void  resizeQueue()
   {
	   initialSize = initialSize *2;
	   
   }
   
   //This fuction will rearragne the arrary and reset head to 0 position and tail to actula last value.
    private void reArrangeArray()
   {
	   Console.WriteLine("Rearrange Queue Head={0}; Tail={1}", Head,Tail);
	   int newindex =0;
	   for (int i=Head; i <= Tail; i++)
	   {
		   Queuearray[newindex] = Queuearray[i];
		   newindex++;
	   }
	   Head =0;
	   Tail = newindex-1;
	   Console.WriteLine("Rearrange completed Queue Head={0}; Tail={1}", Head,Tail);
   }
 
} 

class Program
{
  //sample Main program to show queue implementation
  public static void Main()
   {
     Queue qw = new Queue();
	 Console.WriteLine("Processing item = {0}",qw.DeQueue());
	 qw.Enqueue(20);
	 Console.WriteLine("Processing item = {0}",qw.DeQueue());
	 qw.Enqueue(25);
	 qw.Enqueue(30);
	 qw.Enqueue(35);
	 Console.WriteLine("Processing item = {0}",qw.DeQueue());
	 qw.Enqueue(40);
	 Console.WriteLine("Processing item = {0}",qw.DeQueue());
	 qw.Enqueue(45);
	 Console.WriteLine("Processing item = {0}",qw.DeQueue());
	 qw.Enqueue(50);
	 qw.Enqueue(55);
	 qw.Enqueue(60);
	 Console.WriteLine("Processing item = {0}",qw.DeQueue());
   }
}
}