using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Product
{
    public class RedisCache
    {
        public void RedisConnection(string key, string value)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            data.StringSet(key, value);
        }
        
        public string RedisConnection(string key)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            var result = data.StringGet(key);
            return result;
        }
    }
}