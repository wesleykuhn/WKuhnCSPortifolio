using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace ClassesOnly.Translators
{
    public static class JsonSerialization
    {
        public static string ObjectToString<T>(T obj)
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            //ultilizei o microsoftDateFormatSettings para lidar com os formatos de DateTime do Json para C#.
            return JsonConvert.SerializeObject(obj, microsoftDateFormatSettings);
        }

        public static T TxtStringToObject<T>(string text)
        {
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();

                return (T)jss.Deserialize(text, typeof(T));
            }
            catch (Exception ex)
            {
                ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message);
                T nullObj = default(T);
                return nullObj;
            }
        }

        public static void ObjectToTxtFile<T>(T obj, string path)
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            //ultilizei o microsoftDateFormatSettings para lidar com os formatos de DateTime do Json para C#.
            string result = JsonConvert.SerializeObject(obj, microsoftDateFormatSettings);

            File.WriteAllText(path, result);
        }

        public static T TxtFileToObject<T>(string path)
        {
            try
            {
                string serializedObject = File.ReadAllText(path);
                JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };

                T obj = default(T);

                try
                {
                    //ultilizei o microsoftDateFormatSettings para lidar com os formatos de DateTime do Json para C#.
                    obj = JsonConvert.DeserializeObject<T>(serializedObject, microsoftDateFormatSettings);
                }
                catch (Exception ex)
                {
                    ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message);

                    obj = default(T);
                }

                return obj;
            }
            catch (Exception ex)
            {
                ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message);
                T nullObj = default(T);
                return nullObj;
            }
        }

        public static void ObjectsListToTxtFile<T>(List<T> objs, string path)
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            //ultilizei o microsoftDateFormatSettings para lidar com os formatos de DateTime do Json para C#.
            string result = JsonConvert.SerializeObject(objs, microsoftDateFormatSettings);

            File.WriteAllText(path, result);
        }

        public static List<T> TxtFileToObjectsList<T>(string path)
        {
            try
            {
                string serializedObject = File.ReadAllText(path);
                JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };

                List<T> objs;

                //ultilizei o microsoftDateFormatSettings para lidar com os formatos de DateTime do Json para C#.
                objs = JsonConvert.DeserializeObject<List<T>>(serializedObject, microsoftDateFormatSettings);

                return objs;
            }
            catch (Exception ex)
            {
                ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message);
                List<T> nullList = new List<T>();
                return nullList;
            }
        }
    }
}
