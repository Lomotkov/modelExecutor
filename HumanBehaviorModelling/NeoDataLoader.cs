using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver.V1;

namespace HumanBehaviorModelling
{
    class NeoDataLoader : IDisposable
    {
        private readonly IDriver _driver;

        public NeoDataLoader(string uri, string user, string password)
        {
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        public IStatementResult GetStatementResult(string query)
        {
            using (var session = _driver.Session())
            {
                var trans = session.WriteTransaction(tx =>
                {
                    var result = tx.Run(query);
                    return result;
                });
                return trans;
            }
        }

        public string GetNumberOfAgents()
        {
            return GetStatementResult("match (n) -[r: Экземпляр]->(m: Агент) return count(n)")
                .Single()[0]
                .As<string>();
        }

        public List<String> GetAllAgentsInstancesId()
        {
            return GetStatementResult("match (n)-[r:Экземпляр]->(m:Агент) return id(n)")
                .Select(record => record[0]
                .As<string>())
                .ToList();
        }

        public string GetParentOfNode(string nodeID) // Для рекурсивного поиска родителя
        {
            return GetStatementResult("match (n) -[r: Экземпляр]->(m) where id(n) = " + nodeID + " return count(n)")
                .Single()[0]
                .As<string>();
        }

        public List<String> GetAllParameterNamesOfAgent(string agentID) // Здесь по идее нужно заюзать поиск родителя
        {

            return GetStatementResult("match(n: Агент) -[r: Имеет_параметр]->(m) return m.name")
                .Select(record => record[0]
                .As<string>())
                .ToList();
        }

        public string GetParameterValue(string nodeID, string parameterName)
        {
            return GetStatementResult("match (n) where id(n) = " + nodeID + " return n." + parameterName)
                .Single()[0]
                .As<string>();
        }

        public List<String> GetRelatedNodesIdList(string relationType, string nodeID)
        {
            return GetStatementResult("match (n)<-[r:" + relationType + "]-(m) where id(n) = " + nodeID + " return id(m)")
                .Select(record => record[0]
                .As<string>())
                .ToList();
        }

        public List<String> GetNodeLabels(string nodeID)
        {
            return GetStatementResult("match (n) where id(n) = " + nodeID + " return labels(n)")
                .Select(record => record[0]
                .As<string>())
                .ToList();
        }

        public string GetRelationshipBetweenStatementsParameterValue(string firstNodeID, string secondNodeID, string parameterName)
        {
            return GetStatementResult("match (n)-[r]->(m) where id(n) = " + firstNodeID + " and id(m) = " + secondNodeID + " return r." + parameterName)
                .Single()[0]
                .As<string>();
        }

        public List<String> GetStatesInWhichNodeGoes(string nodeID)
        {
            return GetStatementResult("match (n)-[r:Переход_в]->(m) where id(n) = " + nodeID + " return id(m)")
                .Select(record => record[0]
                .As<string>())
                .ToList();
        }

        public void SetNodeParameter(string nodeID, string param, string value)
        {
            GetStatementResult("match(n) where id(n) = " + nodeID + " set n." + param + " = " + value);
        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}
