using System;
using System.Collections.Generic;
using System.Text;

namespace AppVanguarda.Models
{
 
    public class Item
    {
        public string name { get; set; }
        public int type { get; set; }
        public object image { get; set; }
        public int global_sea_diff { get; set; }
        public Global global { get; set; }
        public Sea sea { get; set; }
    }

    public class Global
    {
        public Week week { get; set; }
        public int latest { get; set; }
        public DateTime latest_time { get; set; }
    }

    public class Week
    {
        public Datum[] data { get; set; }
        public float change { get; set; }
    }

    public class Datum
    {
        public bool snap { get; set; }
        public int price { get; set; }
        public DateTime time { get; set; }
    }

    public class Sea
    {
        public Week1 week { get; set; }
        public int latest { get; set; }
        public DateTime latest_time { get; set; }
    }

    public class Week1
    {
        public Datum1[] data { get; set; }
        public int change { get; set; }
    }

    public class Datum1
    {
        public bool snap { get; set; }
        public int price { get; set; }
        public DateTime time { get; set; }
    }

}
