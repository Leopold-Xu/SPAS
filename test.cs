            string  featureCollectionJson;
            string sql = "SELECT TOTAL_FS,LOUBOUNDS,HEIGHT FROM DOOR where loubounds is not null";
            //从数据库查询并返回数据
            DataTable dt = OraHelper.ExecuteDataSet(ConnStr, sql).Tables[0];
            var features = new List<JFeature<List<List<List<double>>>>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //属性字段分数和高度
                double fs = 0, height = 0;
                double.TryParse(dt.Rows[i]["TOTAL_FS"].ToString(), out fs);
                double.TryParse(dt.Rows[i]["HEIGHT"].ToString(), out height);
                //建筑物的面的坐标串数组
                var loubounds = JsonConvert.DeserializeObject<List<List<double>>>(dt.Rows[i]["LOUBOUNDS"].ToString());
                var coordinates = new List<List<List<double>>> { loubounds };
                var geometry = new JGeometry<List<List<List<double>>>>(geometryType.Polygon, coordinates);
                var feature = new JFeature<List<List<List<double>>>>(geometry, new { fs, height });
                features.Add(feature);
            }
            var jFeatureCollection = new JFeatureCollection<List<List<List<double>>>>("FeatureCollection", features);
            //序列化将对象转为json字符串返回给前端
            featureCollectionJson = JsonConvert.SerializeObject(jFeatureCollection);
