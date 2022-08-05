using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Runtime.Caching;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        SqlConnection connection = new SqlConnection(@"Data Source=CMDLHRDB01;Initial Catalog=AbdurRehman;Persist Security Info=True;User ID=sa;Password=CureMD2022");
        // GET api/values
        public string Get()
        {
            ObjectCache _cache = MemoryCache.Default;
            //return new string[] { "value1", "value2" };
            if(_cache["Students"] is null)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM STUDENTS", connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                  //  _cache["Students"] = dt;
                    CacheItemPolicy _policy = new CacheItemPolicy();
                    _policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10);
                    CacheItem ci = new CacheItem("Students",dt);
                    _cache.Add(ci, _policy);
                    
                    return JsonConvert.SerializeObject(_cache.Get("Students"));
                }
                else
                {
                    return "No Data Found";
                    
                }

            }
            else
            {
                return JsonConvert.SerializeObject(_cache.Get("Students"));
            }
        }
    }
}
