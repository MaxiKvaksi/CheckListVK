using CheckList_Konstruktor;

namespace CheckListNM
{
    class Session
    {
        Platoon platoon;
        Subject subject;
        Student student;
        CheckList checkList;
        bool isTest;
        public int countOfChecks;

        public Session(Platoon platoon, Subject subject, CheckList checkList, Student student, bool isTest)
        {
            this.Platoon = platoon;
            this.Subject = subject;
            this.CheckList = checkList;
            this.Student = student;
            this.IsTest = isTest;
        }

        public Platoon Platoon { get => platoon; set => platoon = value; }
        public Subject Subject { get => subject; set => subject = value; }
        public Student Student { get => student; set => student = value; }
        public CheckList CheckList { get => checkList; set => checkList = value; }
        public bool IsTest { get => isTest; set => isTest = value; }
    }
}