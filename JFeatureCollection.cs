using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  SPAS
{
  
    public class JFeatureCollection<T>
    {
        private string _type;
        private List<JFeature<T>> _features;
       /// <summary>
       /// 要素集合
       /// </summary>
       /// <param name="type">要素类型</param>
       /// <param name="features">要素数组</param>
        public JFeatureCollection(string type, List<JFeature<T>> features)
        {
            _type = type;
            _features = features;
        }
        /// <summary>
        /// 类型
        /// </summary>
        public string type { get => _type; set => _type = value; }
        /// <summary>
        /// 要素数组
        /// </summary>
        public List<JFeature<T>> features { get => _features; set => _features = value; }
    }
}
