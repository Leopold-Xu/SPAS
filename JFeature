using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAS
{
    public class JFeature<T>
    {
        private string _type= "Feature";
        private JGeometry<T> _geometry;
        private object _properties;
        /// <summary>
        /// 要素对象
        /// </summary>
        /// <param name="geometry">几何对象</param>
        /// <param name="properties">属性对象</param>
        public JFeature(JGeometry<T> geometry, object properties)
        {
            _geometry = geometry;
            _properties = properties;
        }
        /// <summary>
        /// 要素类型
        /// </summary>
        public string type { get => _type; set => _type = value; }
        /// <summary>
        /// 几何属性
        /// </summary>
        public JGeometry<T> geometry { get => _geometry; set => _geometry = value; }
        /// <summary>
        /// 属性信息
        /// </summary>
        public object properties { get => _properties; set => _properties = value; }
    }

}
