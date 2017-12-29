using System.Collections.Generic;

namespace TT_Task2.Models
{
    public class Name
    {
        public string given { get; set; }
        public string family { get; set; }
    }

    public class Email
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Profiles
    {
    }

    public class Location
    {
        public string label { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string regionCode { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string formatted { get; set; }
    }

    public class End
    {
        public int year { get; set; }
    }

    public class Education
    {
        public string name { get; set; }
        public string degree { get; set; }
        public End end { get; set; }
    }

    public class Topic
    {
        public string name { get; set; }
    }

    public class Details
    {
        public Name name { get; set; }
        public object age { get; set; }
        public string gender { get; set; }
        public List<Email> emails { get; set; }
        public List<object> phones { get; set; }
        public Profiles profiles { get; set; }
        public List<Location> locations { get; set; }
        public List<object> employment { get; set; }
        public List<object> photos { get; set; }
        public List<Education> education { get; set; }
        public List<object> urls { get; set; }
        public List<object> interests { get; set; }
        public List<Topic> topics { get; set; }
    }

    public class DataAddOn
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool enabled { get; set; }
        public bool applied { get; set; }
        public string description { get; set; }
        public string docLink { get; set; }
    }

    public class RootObject
    {
        public string fullName { get; set; }
        public object ageRange { get; set; }
        public string gender { get; set; }
        public string location { get; set; }
        public string title { get; set; }
        public string organization { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public string bio { get; set; }
        public string avatar { get; set; }
        public string website { get; set; }
        public Details details { get; set; }
        public List<DataAddOn> dataAddOns { get; set; }
        public string updated { get; set; }
    }
}
