using System;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// Unity扩展
    /// </summary>
    public static class UnityExtension
    {
        /// <summary>
        /// 获取或增加组件
        /// </summary>
        /// <typeparam name="T">要获取或增加的组件</typeparam>
        /// <param name="gameObject">目标对象</param>
        /// <returns>获取或增加的组件</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T component = gameObject.GetComponent<T>();
            if(component == null)
            {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }

        /// <summary>
        /// 获取或增加组件
        /// </summary>
        /// <param name="gameObject">目标对象</param>
        /// <param name="type">要获取或增加的组件类型</param>
        /// <returns>获取或增加的组件</returns>
        public static Component GetOrAddComponent(this GameObject gameObject, Type type)
        {
            Component component = gameObject.GetComponent(type);
            if(component == null)
            {
                component = gameObject.AddComponent(type);
            }

            return component;
        }

        /// <summary>
        /// 获取GameObject是否在场景中
        /// </summary>
        /// <param name="gameObject">目标对象</param>
        /// <returns>GameObject是否在场景中</returns>
        /// <remarks>若返回true，表明此GameObject是场景中的实体对象；若返回false，表明此GameObject是一个Prefab</remarks>
        public static bool InScene(this GameObject gameObject)
        {
            return gameObject.scene.name != null;
        }

        /// <summary>
        /// 取 <see cref = "UnityEngine.Vector3" /> 的(x, y, z)转换为 <see cref = "UnityEngine.Vector2" />的(x, z)
        /// </summary>
        /// <param name="vector3">要转换的Vector3</param>
        /// <returns>转换后的Vector2</returns>
        public static Vector2 ToVector2(this Vector3 vector3)
        {
            return new Vector2(vector3.x, vector3.z);
        }

        /// <summary>
        /// 取 <see cref = "UnityEngine.Vector2" /> 的(x, y)转换为 <see cref = "UnityEngine.Vector3" />的(x, 0, z)
        /// </summary>
        /// <param name="vector2">要转换的vector2</param>
        /// <returns>转换后的Vector3</returns>
        public static Vector3 ToVector3(this Vector2 vector2)
        {
            return new Vector3(vector2.x, 0f, vector2.y);
        }

        /// <summary>
        /// 取 <see cref = "UnityEngine.Vector2" /> 的(x, y)和给定参数y转换为 <see cref = "UnityEngine.Vector3" />的(x, 参数y, z)
        /// </summary>
        /// <param name="vector2">要转换的vector2</param>
        /// <param name="y">Vector3的y值</param>
        /// <returns>转换后的Vector3</returns>
        public static Vector3 ToVector3(this Vector2 vector2, float y)
        {
            return new Vector3(vector2.x, y, vector2.y);
        }

        #region Transform

        /// <summary>
        /// 设置绝对位置的x坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">x坐标值</param>
        public static void SetPositionX(this Transform transform, float newValue)
        {
            Vector3 v = transform.position;
            v.x = newValue;
            transform.position = v;
        }

        /// <summary>
        /// 设置绝对位置的y坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">y坐标值</param>
        public static void SetPositionY(this Transform transform, float newValue)
        {
            Vector3 v = transform.position;
            v.y = newValue;
            transform.position = v;
        }

        /// <summary>
        /// 设置绝对位置的z坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">z坐标值</param>
        public static void SetPositionZ(this Transform transform, float newValue)
        {
            Vector3 v = transform.position;
            v.z = newValue;
            transform.position = v;
        }

        /// <summary>
        /// 增加绝对位置的x坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">x坐标值增量</param>
        public static void AddPositonX(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.position;
            v.x += deltaValue;
            transform.position = v;
        }

        /// <summary>
        /// 增加绝对位置的y坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">y坐标值增量</param>
        public static void AddPositionY(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.position;
            v.y += deltaValue;
            transform.position = v;
        }

        /// <summary>
        /// 增加绝对位置的z坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">z坐标值增量</param>
        public static void AddPositonZ(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.position;
            v.z += deltaValue;
            transform.position = v;
        }

        /// <summary>
        /// 设置相对位置的x坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">x坐标值</param>
        public static void SetLocalPositionX(this Transform transform, float newValue)
        {
            Vector3 v = transform.localPosition;
            v.x = newValue;
            transform.localPosition = v;
        }

        /// <summary>
        /// 设置相对位置的y坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">y坐标值</param>
        public static void SetLocalPositionY(this Transform transform, float newValue)
        {
            Vector3 v = transform.localPosition;
            v.y = newValue;
            transform.localPosition = v;
        }

        /// <summary>
        /// 设置相对位置的z坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">z坐标值</param>
        public static void SetLocalPositionZ(this Transform transform, float newValue)
        {
            Vector3 v = transform.localPosition;
            v.z = newValue;
            transform.localPosition = v;
        }

        /// <summary>
        /// 增加相对位置的x坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">x坐标值增量</param>
        public static void AddLocalPositionX(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localPosition;
            v.x += deltaValue;
            transform.localPosition = v;
        }

        /// <summary>
        /// 增加相对位置的y坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">y坐标值增量</param>
        public static void AddLocalPositionY(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localPosition;
            v.y += deltaValue;
            transform.localPosition = v;
        }

        /// <summary>
        /// 增加相对位置的z坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">z坐标值增量</param>
        public static void AddLocalPositionZ(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localPosition;
            v.z += deltaValue;
            transform.localPosition = v;
        }

        /// <summary>
        /// 设置相对尺寸的x分量
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">x分量值</param>
        public static void SetLocalScaleX(this Transform transform, float newValue)
        {
            Vector3 v = transform.localScale;
            v.x = newValue;
            transform.localScale = v;
        }

        /// <summary>
        /// 设置相对尺寸的y分量
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">y分量值</param>
        public static void SetLocalScaleY(this Transform transform, float newValue)
        {
            Vector3 v = transform.localScale;
            v.y = newValue;
            transform.localScale = v;
        }

        /// <summary>
        /// 设置相对尺寸的z分量
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="newValue">z分量值</param>
        public static void SetLocalScaleZ(this Transform transform, float newValue)
        {
            Vector3 v = transform.localScale;
            v.z = newValue;
            transform.localScale = v;
        }

        /// <summary>
        /// 增加相对尺寸的x分量
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">x分量增量</param>
        public static void AddLocalScaleX(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localScale;
            v.x += deltaValue;
            transform.localScale = v;
        }

        /// <summary>
        /// 增加相对尺寸的y分量
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">y分量增量</param>
        public static void AddLocalScaleY(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localScale;
            v.y += deltaValue;
            transform.localScale = v;
        }

        /// <summary>
        /// 增加相对尺寸的z分量
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="deltaValue">z分量增量</param>
        public static void AddLocalScaleZ(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localScale;
            v.z += deltaValue;
            transform.localScale = v;
        }

        /// <summary>
        /// 二维空间下使 <see cref = "UnityEngine.Transform" /> 指向指向目标点的算法，使用世界坐标
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="lookAtPoint2D">要朝向的二维坐标点</param>
        /// <remarks>假定其forward向量为 <see cref = "UnityEngine.Vector3.up" /> </remarks>
        public static void LookAt2D(this Transform transform, Vector2 lookAtPoint2D)
        {
            Vector3 vector = lookAtPoint2D.ToVector3() - transform.position;
            vector.y = 0f;

            if(vector.magnitude > 0f)
            {
                transform.rotation = Quaternion.LookRotation(vector.normalized, Vector3.up);
            }
        }

        /// <summary>
        /// 递归设置游戏对象的层次
        /// </summary>
        /// <param name="transform"> <see cref = "UnityEngine.Transform" />对象 </param>
        /// <param name="layer">目标层次的编号</param>
        public static void SetLayerRecursively(this Transform transform, int layer)
        {
            Transform[] transforms = transform.GetComponentsInChildren<Transform>(true);
            for(int i=0; i<transforms.Length; i++)
            {
                transforms[i].gameObject.layer = layer;
            }
        }
        #endregion
    }
}
