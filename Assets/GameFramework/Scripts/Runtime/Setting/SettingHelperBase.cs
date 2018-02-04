using GameFramework.Setting;
using UnityEngine;
using System;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 配置管理辅助器基类
    /// </summary>
    public abstract class SettingHelperBase : MonoBehaviour, ISettingHelper
    {
        /// <summary>
        /// 加载配置
        /// </summary>
        /// <returns>是否加载配置成功</returns>
        public abstract bool Load();

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <returns>是否保存配置成功</returns>
        public abstract bool Save();

        /// <summary>
        /// 检查是否存在指定配置项
        /// </summary>
        /// <param name="key">要检查的配置项名称</param>
        /// <returns>是否存在指定配置项</returns>
        public abstract bool HasKey(string key);

        /// <summary>
        /// 移除指定配置项
        /// </summary>
        /// <param name="key">要移除的配置项名称</param>
        public abstract void RemoveKey(string key);

        /// <summary>
        /// 清空所有配置项
        /// </summary>
        public abstract void RemoveAllKeys();

        /// <summary>
        /// 从指定配置项中读取布尔值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <returns>读取的布尔值</returns>
        public abstract bool GetBool(string key);

        /// <summary>
        /// 从指定配置项中读取布尔值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <param name="defaultValue">当指定的配置项不存在时，返回此默认值</param>
        /// <returns>读取的布尔值</returns>
        public abstract bool GetBool(string key, bool defaultValue);

        /// <summary>
        /// 向指定配置项中写入布尔值
        /// </summary>
        /// <param name="key">要写入的配置项的名称</param>
        /// <param name="value">要写入的布尔值</param>
        public abstract void SetBool(string key, bool value);

        /// <summary>
        /// 从指定配置项中读取整数值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <returns>读取的整数值</returns>
        public abstract int GetInt(string key);

        /// <summary>
        /// 从指定配置项中读取整数值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <param name="defautlValue">当指定的配置项不存在时，返回此默认值</param>
        /// <returns>读取的整数值</returns>
        public abstract int GetInt(string key, int defautlValue);

        /// <summary>
        /// 向指定配置项中写入整数值
        /// </summary>
        /// <param name="key">要写入的配置项的名称</param>
        /// <param name="value">要写入的整数值</param>
        public abstract void SetInt(string key, int value);

        /// <summary>
        /// 从指定配置项中读取浮点数值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <returns>读取的浮点数值</returns>
        public abstract float GetFloat(string key);

        /// <summary>
        /// 从指定配置项中读取浮点数值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <param name="defaultValue">当指定的配置项不存在时，返回此默认值</param>
        /// <returns>读取的浮点数值</returns>
        public abstract float GetFloat(string key, float defaultValue);

        /// <summary>
        /// 向指定配置项中写入浮点数值
        /// </summary>
        /// <param name="key">要写入的配置项的名称</param>
        /// <param name="value">写入的浮点数值</param>
        public abstract void SetFloat(string key, float value);

        /// <summary>
        /// 从指定配置项中读取字符串值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <returns>读取的字符串值</returns>
        public abstract string GetString(string key);

        /// <summary>
        /// 从指定配置项中读取字符串值
        /// </summary>
        /// <param name="key">要获取配置项的名称</param>
        /// <param name="defaultValue">当指定的配置项不存在时，返回此默认值</param>
        /// <returns>读取的字符串值</returns>
        public abstract string GetString(string key, string defaultValue);

        /// <summary>
        /// 向指定配置项中写入字符串值
        /// </summary>
        /// <param name="key">要写入的配置项的名称</param>
        /// <param name="value">写入的字符串值</param>
        public abstract void SetString(string key, string value);

        /// <summary>
        /// 从指定配置项中读取对象
        /// </summary>
        /// <typeparam name="T">要读取对象的类型</typeparam>
        /// <param name="key">要获取配置项的名称</param>
        /// <returns>读取的对象</returns>
        public abstract T GetObject<T>(string key);

        /// <summary>
        /// 从指定配置项中读取对象
        /// </summary>
        /// <param name="objectType">要读取对象的类型</param>
        /// <param name="key">要获取配置项的名称</param>
        /// <returns>读取的对象</returns>
        public abstract object GetObject(Type objectType, string key);

        /// <summary>
        /// 从指定配置项中读取对象
        /// </summary>
        /// <typeparam name="T">要读取对象的类型</typeparam>
        /// <param name="key">要获取配置项的名称</param>
        /// <param name="defaultObject">当指定的配置项不存在时，返回此默认对象</param>
        /// <returns>读取的对象</returns>
        public abstract T GetObject<T>(string key, T defaultObject);

        /// <summary>
        /// 从指定配置项中读取对象
        /// </summary>
        /// <param name="objectType">要读取对象的类型</param>
        /// <param name="key">要获取配置项的名称</param>
        /// <param name="defaultObject">当指定的配置项不存在时，返回此默认对象</param>
        /// <returns>读取的对象</returns>
        public abstract object GetObject(Type objectType, string key, object defaultObject);

        /// <summary>
        /// 向指定配置项中写入对象
        /// </summary>
        /// <typeparam name="T">要写入对象的类型</typeparam>
        /// <param name="key">要写入配置项的名称</param>
        /// <param name="obj">要写入的对象</param>
        public abstract void SetObject<T>(string key, T obj);

        /// <summary>
        /// 向指定配置项中写入对象
        /// </summary>
        /// <param name="key">要写入配置项的名称</param>
        /// <param name="obj">要写入的对象</param>
        public abstract void SetObject(string key, object obj);
    }
}
