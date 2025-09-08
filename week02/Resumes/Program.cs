
namespace Week02.Resumes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1._jobTitle = "Software Developer";
            job1._company = "Tech Corp";
            job1._startYear = 2020;
            job1._endYear = 2023;

            job1.Display();
        }
    }

    public class Job
    {
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
} 