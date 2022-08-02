using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisatonApp;
public interface ISerialise<T>
{
    void SerialiseToFile<T>(string filePath, T item);
    T DeserialiseFromFile(string filePath);
}
