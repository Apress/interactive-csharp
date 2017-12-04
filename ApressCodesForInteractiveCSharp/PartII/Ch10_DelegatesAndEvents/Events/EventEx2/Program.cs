using System;

namespace EventEx2
{
    //Step-a. Create a subclass of System.EventArgs
    public class JobNoEventArgs : EventArgs
    {
        //Step-b.Encapsulate your intended data with the event. In the below example, we have used a property.
        private int jobNo;
        public int JobNo
        {
            get
            {
                return jobNo;
            }
            set
            {
                JobNo = value;
            }
        }
        public JobNoEventArgs(int jobNo)
        {
            this.jobNo = jobNo;
        }
    }
    //Step1-Create a publisher
    class Publisher
    {
        //Step1.1-Create a delegate.Delegate name should be "yourEventName"+EventHandler
        //public delegate void JobDoneEventHandler(object sender, EventArgs args);
        public delegate void JobDoneEventHandler(object sender, JobNoEventArgs args);
        //Step1.2-Create the event based on the delgate
        public event JobDoneEventHandler JobDone;
        public void ProcessOneJob()
        {
            Console.WriteLine("Publisher:One Job is processed");
            //Step1.3-Raise the event
            OnJobDone();
        }
        /*The standard pattern requires that the method should be tagged with protected virtual. 
         * Also the name must match name of the event and it will be prefixed with “On”.*/
        protected virtual void OnJobDone()
        {
            if (JobDone != null)
                //Step-c. Lastly create an instance of the event generator class and pass it with the event.
                JobDone(this,new JobNoEventArgs(1));
        }
    }
    //Step2-Create a subscriber
    class Subscriber
    {
        //Handling the event
        public void OnJobDoneEventHandler(object sender, JobNoEventArgs args)
        {
            Console.WriteLine(" Subscriber is notified.Number of job processed is :{0}",args.JobNo);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Event example 2:Passing data with events***");
            Publisher sender = new Publisher();
            Subscriber receiver = new Subscriber();
            sender.JobDone += receiver.OnJobDoneEventHandler;
            sender.ProcessOneJob();
            Console.ReadKey();
        }
    }
}