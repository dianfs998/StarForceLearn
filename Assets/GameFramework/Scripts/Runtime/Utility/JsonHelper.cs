using GameFramework;
using UnityEngine;
using System;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// JSON函数集辅助器
    /// </summary>
    internal class JsonHelper : Utility.Json.IJsonHelper
    {
        /// <summary>
        /// 将对象序列化为JSON字符串
        /// </summary>
        /// <param name="obj">要序列化的对象</param>
        /// <returns>序列化后的JSON字符串</returns>
        public string ToJson(object obj)
        {
            return JsonUtility.ToJson(obj);
        }

        /// <summary>
        /// 将JSON字符串反序列为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">要反序列化的JSON字符串</param>
        /// <returns>反序列化后的对象</returns>
        public T ToObject<T>(string json)
        {
            return JsonUtility.FromJson<T>(json);
        }

        /// <summary>
        /// 将JSON字符串反序列为对象
        /// </summary>
        /// <param name="objectType">对象类型</param>
        /// <param name="json">要反序列化的JSON字符串</param>
        /// <returns>反序列化后的对象</returns>
        public object ToObject(Type objectType, string json)
        {
            return JsonUtility.FromJson(json, objectType);
        }
    }
}
