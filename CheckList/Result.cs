
using CheckList_Konstruktor;
using CheckListNM;
using Newtonsoft.Json;
using System;

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
        [JsonProperty]
        string mark;
        [JsonProperty]
        bool isTest;
        [JsonProperty]
        DateTime dateTime;

        public Result(string subject, string checkList, string platoon, 
            string student, string mark, bool isTest, DateTime dateTime)
        {
            this.subject = subject;
            this.checkList = checkList;
            this.platoon = platoon;
            this.student = student;
            this.mark = mark;
            this.isTest = isTest;
            this.dateTime = dateTime;
        }
    }
}
