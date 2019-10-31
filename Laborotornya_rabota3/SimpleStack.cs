
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laborotornya_rabota3
{
    class SimpleStack<T>: SimpleList<T>: where T : IComparable
    { 
      public void Push(T element) 
        {  
            Add(element); 
        }
  
       
     
    }
