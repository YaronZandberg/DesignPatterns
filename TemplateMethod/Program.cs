using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //new OracleSelectAllQuery().Run();
            OracleTemplateBase selectAllQuery = new OracleSelectAllQuery();
            selectAllQuery.Run();
            Console.WriteLine();

            //new OracleUpdateQuery().Run();
            OracleTemplateBase updateOracleQuery = new OracleUpdateQuery();
            updateOracleQuery.Run();
            Console.WriteLine();

            MongoTemplateBase insertMongoQuery = new MongoInsertQuery();
            insertMongoQuery.Run();
            Console.WriteLine();

            MongoTemplateBase updateMongoQuery = new MongoUpdateQuery();
            updateMongoQuery.Run();
            Console.WriteLine();

            MongoTemplateBase deleteMongoQuery = new MongoDeleteQuery();
            deleteMongoQuery.Run();
            Console.WriteLine();
        }
    }
}
