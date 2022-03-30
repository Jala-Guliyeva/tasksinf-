using System;
using System.Collections.Generic;
using System.Text;

namespace Datetime_sinf.Models
{
    internal class MeetingSchedule
    {
         List<Meeting> _meetings;

        public MeetingSchedule()
        {
            _meetings = new List<Meeting>();
        }
        public void AddMeeting(Meeting meeting)
        {
            if (_meetings.Exists(m => m.FromDate == meeting.FromDate && m.ToDate == meeting.ToDate))
                throw new Exception();
                    _meetings.Add(meeting); 
        }
        /*Meeting meetings = _meetings.Find(m=> m.Name==meeting.Name);*/
        //    if (meetings!=null)
        //    {
        //        throw new Exception("var!");
        //    }
        //    _meetings.Add(meeting);



        
        public int FindMeetingsCount(DateTime date)
        {
            return _meetings.FindAll(m => m.FromDate > date).Count;
            

        }
        public List  FindMeetings()
        {

        return _

        }
        public bool ExistMeetingsByName(string name)
        {
          
            return _meetings.FindAll(m=>m.Name==name);
            
        }
        public void ExistMeetings(Predicate<Meeting>predicate)
        {

            return _meetings.Exists(predicate);
        }
    }
}
