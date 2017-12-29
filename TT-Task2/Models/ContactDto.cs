namespace TT_Task2.Models
{
    public class ContactDto
    {

        public class ContactModelDto
        {
            public string fullName { get; set; }
            public string location { get; set; }
            public string twitter { get; set; }
            public string linkedin { get; set; }
            public string facebook { get; set; }
            public string bio { get; set; }
            public string avatar { get; set; }
            public string website { get; set; }
            public Details details { get; set; }
        }

    }
}
