using System;

namespace EventEx1    
{
    //Step1-Create a publisher
    class Publisher
    {
        //Step1.1-Create a delegate.Delegate name should be "yourEventName"+EventHandler
        public delegate void JobDoneEventHandler(object sender, EventArgs args);
        //Step1.2-Create the event based on the delgate
        public event JobDoneEventHandler JobDone;
        #region custom event accessors
        //private JobDoneEventHandler _JobDone;       
        //public event JobDoneEventHandler JobDone
        //{
        //    add
        //    {
        //        _JobDone += value;
        //    }
        //    remove
        //    {
        //        _JobDone -= value;
        //    }
        //}
        #endregion
        public void ProcessOneJob()
        {
            Console.WriteLine("Publisher:One Job is processed");
            //Step1.3-Raise the event
            OnJobDone();
        }
        /*The standard pattern requires that the method should be tagged with protected virtual. 
         Also the name must match name of the event and it will be prefixed with “On”.*/
        protected virtual void OnJobDone()
        {
            if (JobDone != null)
                JobDone(this, EventArgs.Empty);
        }

    }
    //Step2-Create a subscriber
    class Subscriber
    {
        //Handling the event
        public void OnJobDoneEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine(" Subscriber is notified ");
        }
    }
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("***A simple event demo***");
            Publisher sender = new Publisher();
            Subscriber receiver = new Subscriber();
            sender.JobDone += receiver.OnJobDoneEventHandler;
            sender.ProcessOneJob();
          
            Console.ReadKey();
        }
    }
}
