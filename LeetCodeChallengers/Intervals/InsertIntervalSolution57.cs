﻿namespace LeetCodeChallengers.Intervals;

/*
 * 57. Insert Interval
 * 
 * You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti. You are also given an interval newInterval = [start, end] that represents the start and end of another interval.
 * Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).
 * Return intervals after the insertion.
 * 
 * Example 1:
 * Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
 * Output: [[1,5],[6,9]]
 * 
 * Example 2:
 * Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
 * Output: [[1,2],[3,10],[12,16]]
 * Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
 * 
 * Constraints:
 * 0 <= intervals.length <= 104
 * intervals[i].length == 2
 * 0 <= start^i <= end^i <= 105
 * intervals is sorted by start^i in ascending order.
 * newInterval.length == 2
 * 0 <= start <= end <= 10^5
 */
public class InsertIntervalSolution57
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
        {
            return new List<int[]> { newInterval }.ToArray();
        }

        var result = new List<int[]>();
        var inserted = false;

        foreach (var interval in intervals)
        {
            if (interval[1] < newInterval[0] || interval[0] > newInterval[1])
            {
                if (interval[0] > newInterval[1] && !inserted)
                {
                    inserted = true;
                    result.Add(newInterval);
                }
                result.Add(interval);
            }

            if (newInterval[0] >= interval[0] && newInterval[0] <= interval[1])
            {
                newInterval[0] = interval[0];
            }

            if (newInterval[1] >= interval[0] && newInterval[1] <= interval[1])
            {
                newInterval[1] = interval[1];
            }
        }

        if (!inserted)
        {
            result.Add(newInterval);
        }

        return result.ToArray();
    }
}
