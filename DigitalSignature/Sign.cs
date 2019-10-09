using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DigitalSignature
{
    public class Sign
    {

        public static string getSign(string param) {
            Hashtable dic = PluSoft.Utils.JSON.Decode(param.Replace("\r\n","")) as Hashtable;
            if (dic ==null|| dic.ContainsKey( "timestamp" ))
            {
                string timestamp = dic["timestamp"].ToString();
                dic.Remove("timestamp");
                dic.Remove("signature");
                return signature(timestamp, strCoalition(dic));
            }
            else {
                return "缺少必要json参数或者时间戳timestamp";
            }
        }

        private static string strCoalition(Hashtable dic)
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            foreach (var key in dic.Keys)
            {
                string value = string.Empty;
                if (dic[key] != null)
                {
                    if (dic[key] is Hashtable)
                        value = strCoalition(dic[key] as Hashtable);
                    else
                        value = dic[key].ToString();
                }
                list.Add((key + value).ToUpper());
            }
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
            }
            return sb.ToString();
        }



        /// <summary>
        /// 参数签名验证
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="param"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        private static string signature(string timestamp, string entrystring)
        {

            string e1 = MD5Encrypt32(entrystring);
            return MD5Encrypt32(e1 + timestamp);
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns></returns>
        private static string MD5Encrypt32(string data)
        {
            string pwd = string.Empty;
            //实例化一个md5对像
            MD5 md5 = MD5.Create();
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。 X 表示大写， x 表示小写， X2和x2表示不省略首位为0的十六进制数字 
                pwd = pwd + s[i].ToString("X2");
            }
            return pwd;
        }
    }
}
