
using CheckList_Konstruktor;
using CheckListNM;
using Newtonsoft.Json;

namespace CheckList
{
    class Result
    {
        [JsonProperty]
        string subject;
        [JsonProperty]
        string checkList;
        [JsonProperty]
        string platoon;
        [JsonProperty]
        string student;

        public Result(string subject, string checkList, string platoon, string student)
        {
            this.subject = subject;
            this.checkList = checkList;
            this.platoon = platoon;
            this.student = student;
        }
    }
}
