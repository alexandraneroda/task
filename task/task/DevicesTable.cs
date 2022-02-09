using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class DevicesTable
    {
        public List<IDevice> Devices { get; set; } = new List<IDevice>();
        string[] ArrStr;// объявляем массив
        int size = 2;
        public DevicesTable()
        {
            Devices.Add(new Device("Panasonic") { Type = Device.Types.Camera, Price = 10 });
            Devices.Add(new Device("Sooner") { Type = Device.Types.Printer, Price = 20 });
            Devices.Add(new Device("Dream") { Type = Device.Types.Camera, Price = 310 });
        }

        public override string ToString()
        {
            return this.Price.ToString(); //я хочу переменную Price из IDevice преобразовать в string
        }
        public void OneDArray() 
        {

            this.size = size;
            ArrStr = new string[size];//я хочу, чтобы строки, помещенные в массив, были связаны с моими переменными

        }

        // Метод, позволяющий ввести элементы массива с клавиатуры.
        public void InputArrStr()
        {
            //Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < ArrStr.Length; i++)
            {
                //Console.Write("A[{0}] = ", i);
                ArrStr[i] = int.Parse(Console.ReadLine()); //мне нужно разобраться, как пропистаь здесь ввод из DGV
            }
        }

        // Метод, позволяющий вывести элементы массива на экран.
        public void ShowArrStr()
        {
            foreach (int item in ArrStr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();//снова-таки, вывод должен быть в DGV
        }

        //Метод, позволяющий добавлять элементы в массив

        //то есть метод, который принимает массив, создает новый массив большего или меньшего размера, повторно заполняет
        //этот массив значениями, полученными из исходного массива, и возвращает новый массив
        public int[] AddArr(int[] ArrStr, int var)
        {
            int[] NewArr = new int[ArrStr.Length + 1];
            for (int i = 0; i < ArrStr.Length; i++)
            {
                NewArr[i] = ArrStr[i];
            }
            NewArr[NewArr.Length - 1] = var;
            return NewArr;
        }

        //Метод, позволяющий удалять элементы из массива
        public int[] RemoveArr(int[] ArrStr, int index)
        {
            int[] NewArr = new int[ArrStr.Length - 1];
            for (int i = 0; i < ArrStr.Length; i++)
            {
                if (i < index)
                {
                    NewArr[i] = ArrStr[i];
                }
                else
                {
                    NewArr[i] = ArrStr[i + 1];
                }
            }
            return NewArr;
        }
        
        public void Add(IDevice device)
        {
            Devices.Add(device);
        }

        public void Remove(IDevice device)
        {
            Devices.Remove(device);
        }

        public void Remove(int index)
        {
            Devices.RemoveAt(index);
        }
    }
}
