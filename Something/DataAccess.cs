using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    public class DataAccess
    {
    //    //private readonly string _connectionString;

    //    public DataAccess()
    //    {
    //        //_connectionString = "Data Source =.\\sqlexpress; Initial Catalog = Ola; Integrated Security = True";
    //    }

    //    public static IEnumerable<Rabat> GetRabats()
    //    {
    //        string _connectionString = "Data Source =.\\sqlexpress; Initial Catalog = Ola; Integrated Security = True";
    //        const string queryRabats = @"select * from sl_Rabat";
    //        const string queryTowars = @"select * from tw__Towar join sl_Rabat on tw__Towar.tw_IdRabat = sl_Rabat.rt_id;";

    //        using SqlConnection connection = new(_connectionString);

    //        IEnumerable<Rabat> list = connection.Query<Rabat>(queryRabats);
    //        foreach(var rabat in list)
    //        {
    //            rabat.Towary = connection.Query<Towar>(queryTowars, rabat).ToList();
    //        }
    //        return list;
    //    }

    //    public static IEnumerable<Towar> GetTowars()
    //    {
    //        string _connectionString = "Data Source =.\\sqlexpress; Initial Catalog = Ola; Integrated Security = True";
    //        const string query = @"select * from tw__Towar t left join sl_Rabat r on t.tw_IdRabat = r.rt_id";

    //        using SqlConnection connection = new(_connectionString);
    //        var list = connection.Query<Towar, Rabat, Towar>(
    //            query,
    //            (towar, rabat) =>
    //            {
    //                towar.Rabat = rabat;
    //                return towar;
    //            });
    //        return list;
    //    }

    //    public static IEnumerable<Rabat> GetRabatList()
    //    {
    //        string _connectionString = "Data Source =.\\sqlexpress; Initial Catalog = Ola; Integrated Security = True";
    //        var lookup = new Dictionary<int, Rabat>();
    //        const string query = @"select * from sl_Rabat r left join tw__Towar t on r.rt_id = t.tw_IdRabat";

    //        using SqlConnection connection = new(_connectionString);
    //        var list = connection.Query<Rabat, Towar, Rabat>(
    //            query,
    //            (rabat, towar) =>
    //            {
    //                if (!lookup.TryGetValue(rabat.rt_id, out Rabat found))
    //                {
    //                    lookup.Add(rabat.rt_id, found = rabat);
    //                }
    //                found.Towary.Add(towar);
    //                return found;
    //            }).Distinct().ToList();
    //        return list;
    //    }
    }
}
