/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        var meetings = intervals.OrderBy(x => x.start).ToList();

        for(int i = 0; i < meetings.Count - 1; i++)
        {
            var currentMeeting = meetings[i];
            var nextMeeting = meetings[i + 1];
            
            if(currentMeeting.end > nextMeeting.start || currentMeeting.end > nextMeeting.end)
                return false;
        }

        return true;
    }
}
