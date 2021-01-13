using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Pixl.Systems.Networking
{
    public class ByteArray
    {

        public static byte[] FromString(string e)
        {
            return Encoding.UTF8.GetBytes(e);
        }

        public static string ToString(byte[] e)
        {
            return Encoding.UTF8.GetString(e);
        }

        public static byte[] FromObject(object e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, e);

                return ms.ToArray();

                ms.Close();
            }
        }

        public static object ToObject(byte[] e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream(e))
            {
                return bf.Deserialize(ms);

                ms.Close();
            }
        }


    }
}
