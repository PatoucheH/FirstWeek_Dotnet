using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class EventRegistration
    {
        public List<(string EventName, string AttendeeName)> eventList = new();

        public void RegisterAttendee(string eventName, string attendeeName)
        {
            eventList.Add ((eventName, attendeeName));
        }

        public void RemoveRegistration(string eventName, string attendeeName)
        {
            if (eventList.Contains((eventName, attendeeName))) 
            {
                eventList.Remove((eventName, attendeeName));
            }
            else
            {
                Console.WriteLine("Registration doesn't exist");
            }
        }

        public void ListEventRegistration (string eventName)
        {
            foreach(var registration in eventList)
            {
                if (registration.EventName.Equals(eventName,StringComparison.OrdinalIgnoreCase)) Console.WriteLine(registration.AttendeeName);
            }
        }


        public void ShowAllRegistration()
        {
            foreach(var registration in eventList)
            {
                Console.WriteLine($"Attendee name : {registration.AttendeeName}\t\tEvent name : {registration.EventName}");
            }
        }
    }
}
