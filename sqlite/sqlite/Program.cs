using SqliteDemo.Data;
using SqliteDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqliteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LINE> list = new List<LINE>();
            list.Add(new LINE() { AgentId = 1, AgentName = "A" });
            list.Add(new LINE() { AgentId = 2, AgentName = "B" });
            list.Add(new LINE() { AgentId = 3, AgentName = "C" });

            CtiRepository ctiRep = new CtiRepository();
            ctiRep.Save(list);
            Console.WriteLine("save success");

            List<LINE> listInfo = ctiRep.GetList();
            if (listInfo != null && listInfo.Count() > 0)
            {
                Console.WriteLine("get list success");
            }

            ctiRep.UpdateReceivedCount(1, "P");
            List<LINE> listInfo1 = ctiRep.GetList();
            Console.ReadKey();
        }
    }
}
