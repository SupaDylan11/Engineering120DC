using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialisatonApp;
public class SerialiserBinary
{
    public void SerialiseToFile<T>(string filePath, T item)
    {
        FileStream filestream = File.Create(filePath);
        BinaryFormatter writer = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
        writer.Serialize(filestream, item);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
        filestream.Close();
    }

    public T DeserialiseFromFile<T>(string filePath)
    {
        Stream filestream = File.OpenRead(filePath);
        BinaryFormatter reader = new BinaryFormatter();
        var deserialisedItem = reader.Deserialize(filestream);
        filestream.Close();
        return (T) deserialisedItem;
    }
}

