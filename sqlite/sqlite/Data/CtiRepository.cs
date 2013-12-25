using SqliteDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;

namespace SqliteDemo.Data
{
    public class CtiRepository : SqLiteBaseRepository
    {
        public List<LINE> GetList()
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                List<LINE> result = cnn.Query<LINE>(
                    @"SELECT Id,AgentId, AgentName  FROM VoiceCardLine").ToList<LINE>();
                return result;
            }
        }

        public void Save(List<LINE> list)
        {
            using (var conn = SimpleDbConnection())
            {
                conn.Open();
                foreach (var item in list)
                {
                    conn.Execute("insert into VoiceCardLine (AgentId,AgentName) Values(@AgentId,@AgentName)", item);
                }
            }
        }

        public void UpdateReceivedCount(int id, string agentName)
        {
            using (var conn = SimpleDbConnection())
            {
                conn.Open();

                conn.Execute("update VoiceCardLine set AgentName =@AgentName where Id=@Id", new { Id = id, AgentName = agentName });
            }
        }
    }
}
