using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace SPAS
{
    /// <summary>
    /// Geometry 的摘要说明
    /// </summary>
    public class JGeometry<T>
    {
        private string _type;
        private T _coordinates;
     
        /// <summary>
        /// 几何对象
        /// </summary>
        /// <param name="type">几何类型</param>
        /// <param name="coordinates">几何坐标串</param>
        public JGeometry(string type, T coordinates)
        {
            _type = type;
            _coordinates = coordinates;
        }
        /// <summary>
        /// 几何类型
        /// </summary>
        public string type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        /// <summary>
        /// 几何坐标串数组
        /// </summary>
        public T coordinates
        {
            get
            {
                return _coordinates;
            }

            set
            {
                _coordinates = value;
            }
        }
    }

}

    
