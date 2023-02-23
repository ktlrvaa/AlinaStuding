using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers_01
{
    internal class Dictionary
    {
        private string[] _original = new string[5];
        private string [] _translation = new string[5];

        public Dictionary()
        {
            _original[0] = "Бесконечность"; _translation[0] = "Infinity";
            _original[1] = "Солнце"; _translation[1] = "Sun"; 
            _original[2] = "Северное сияние"; _translation[2] = "Aurora";
            _original[3] = "Шмель"; _translation[3] = "Bumblebee"; 
            _original[4] = "Созвездие"; _translation[4] = "Constellation"; 
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _original.Length; i++)

                    if (_original[i] == index)
                    return _original[i] + " - " + _translation[i];

                return string.Format($"{index} - нет перевода для этого слова.");
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _original.Length)
                    return _original[index] + " - " + _translation[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

    }
}
