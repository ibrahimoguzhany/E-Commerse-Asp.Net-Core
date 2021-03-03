using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace CoreIntro_0.CommonTools
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string objectString = JsonConvert.SerializeObject(value);//seriliazeOnject json formatinda string'e cevirmektir.
            session.SetString(key, objectString);
        }

        //Session'i geri almak lazim... Generic metorlar

        public static T GetObject<T>(this ISession session, string key) where T:class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }

            T deserializedObject = JsonConvert.DeserializeObject<T>(objectString);
            return deserializedObject;
        }

    }
}
