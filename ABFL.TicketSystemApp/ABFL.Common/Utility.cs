using System;
using System.Collections.Generic;
using System.Linq;

namespace COMMON
{
    public class Utility
    {
        public static List<Years> YearList(int startYear)
        {
            try
            {
                List<Years> returnList = new List<Years>();
                while (startYear <= DateTime.Now.Year + 1)
                {
                    returnList.Add(new Years { YearNo = startYear });
                    startYear++;
                }

                return returnList.OrderByDescending(m => m.YearNo).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Months> MonthList(int currentYear)
        {
            try
            {
                List<Months> returnList = new List<Months>();
                if (currentYear == DateTime.Now.Year)
                {
                    for (int index = 0; index < DateTime.Now.Month; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1) });
                    }
                }
                else
                {
                    for (int index = 0; index < 12; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1) });
                    }
                }

                return returnList.OrderByDescending(m => m.MonthNo).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Day> DayList(int currentMonth)
        {
            try
            {
                List<Day> returnList = new List<Day>();
                if (currentMonth == DateTime.Now.Month)
                {
                    for (int index = 0; index < DateTime.Now.Day; index++)
                    {
                        returnList.Add(new Day { DayNo = index + 1 });
                    }
                }
                else
                {
                    for (int index = 0; index < 12; index++)
                    {
                        returnList.Add(new Day { DayNo = index + 1 });
                    }
                }

                return returnList.OrderByDescending(m => m.DayNo).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Months> MonthListWithTotalDays(int currentYear)
        {
            try
            {
                List<Months> returnList = new List<Months>();
                if (currentYear == DateTime.Now.Year)
                {
                    for (int index = 0; index < DateTime.Now.Month; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1), TotalDaysInMonth = DateTime.DaysInMonth(currentYear, index + 1) });
                    }
                }
                else
                {
                    for (int index = 0; index < 12; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1), TotalDaysInMonth = DateTime.DaysInMonth(currentYear, index + 1) });
                    }
                }
                return returnList.OrderByDescending(m => m.MonthNo).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Months> MonthListWithNextMonth(Int32 currentYear)
        {
            try
            {
                List<Months> returnList = new List<Months>();
                if (currentYear == DateTime.Now.Year)
                {
                    for (Int32 index = DateTime.Now.Month - 1; index < DateTime.Now.Month + 1; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1) });
                    }
                }
                else
                {
                    for (Int32 index = 0; index < 12; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1) });
                    }
                }

                return returnList.OrderByDescending(m => m.MonthNo).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetMonthName(int month)
        {
            return
                  month == 1 ? MonthName.Jan.ToString()
                : month == 2 ? MonthName.Feb.ToString()
                : month == 3 ? MonthName.Mar.ToString()
                : month == 4 ? MonthName.Apr.ToString()
                : month == 5 ? MonthName.May.ToString()
                : month == 6 ? MonthName.Jun.ToString()
                : month == 7 ? MonthName.Jul.ToString()
                : month == 8 ? MonthName.Aug.ToString()
                : month == 9 ? MonthName.Sep.ToString()
                : month == 10 ? MonthName.Oct.ToString()
                : month == 11 ? MonthName.Nob.ToString()
                : MonthName.Dec.ToString();
        }

        public static List<Years> YearListWithNextYear(int startYear)
        {
            try
            {
                List<Years> returnList = new List<Years>();
                int endYear = DateTime.Now.Year;
                if (DateTime.Now.Month == 12)
                {
                    endYear += 1;
                }
                while (startYear <= endYear)
                {
                    returnList.Add(new Years { YearNo = startYear });
                    startYear++;
                }

                return returnList.OrderByDescending(m => m.YearNo).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class Months
    {
        private int _MonthNo;
        private String _MonthName;

        public String MonthName
        {
            get { return _MonthName; }
            set { _MonthName = value; }
        }

        public int MonthNo
        {
            get { return _MonthNo; }
            set { _MonthNo = value; }
        }

        private int _TotalDaysInMonth;
        public int TotalDaysInMonth
        {
            get { return _TotalDaysInMonth; }
            set { _TotalDaysInMonth = value; }
        }
    }

    public class Day
    {
        public int DayNo { get; set; }

        public string DayName { get; set; }

    }

    public class Years
    {
        private int _yearNo;

        public int YearNo
        {
            get { return _yearNo; }
            set { _yearNo = value; }
        }
    }

    public enum MonthName
    {
        Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nob, Dec
    }
    public enum WorkingDays
    {
        Saturday = 1,
        Sunday = 2,
        Monday = 3,
        Tuesday = 4,
        Wednesday = 5,
        Thursday = 6,
        Friday = 7
    }

}