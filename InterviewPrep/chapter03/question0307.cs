using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class question0307
    {
        public static void NotMain(String[] args)
        {
            AnimalQueues q = new AnimalQueues();
            Console.WriteLine();
        }
    }

    public class AnimalQueues
    {
        AnimalQueue dogQ;
        AnimalQueue catQ;

        public AnimalQueues()
        {
            dogQ = new AnimalQueue();
            catQ = new AnimalQueue();
        }

        public Cat DequeueCats()
        {
            return catQ.Dequeue() as Cat;
        }

        public void EnqueueCat(Cat c)
        {
            catQ.Enqueue(c);
        }

        public void EnqueueDog(Dog d)
        {
            dogQ.Enqueue(d);
        }

        public Dog DequeueDogs()
        {
            return dogQ.Dequeue() as Dog;
        }

        public Animal DequeueAny()
        {
            Animal oldDog = dogQ.Peek();
            Animal oldCat = catQ.Peek();
            if (oldDog == null)
                return catQ.Dequeue();
            if (oldCat == null)
                return dogQ.Dequeue();
            if (oldDog.timeArrived < oldCat.timeArrived)
                return dogQ.Dequeue();
            return catQ.Dequeue();
        }

    }

    public class AnimalQueue
    {
        Animal first;
        Animal last;
        public AnimalQueue()
        {
            first = null;
            last = null;
        }

        public Animal Peek()
        {
            return first;
        }

        public void Enqueue(Animal a)
        {
            if (last == null)
            {
                last = a;
                first = a;
                return;
            }
            last.next = a;
            last = last.next;
        }

        public Animal Dequeue()
        {
            if (first == null)
                return null;
            Animal returned = first;
            first = first.next;
            if (first == null)
                last = null;
            return returned;
        }
    }

    public class Animal
    {
        public DateTime timeArrived;
        public Animal next;
        public Animal()
        {
            timeArrived = DateTime.Now;
            next = null;
        }
    }

    public class Cat : Animal
    {
    }

    public class Dog : Animal
    {
    }
}
