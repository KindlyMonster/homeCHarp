using System.Collections.Generic;
using System.Linq;

namespace pony
{
    class FirstClass
    {
        private List<string> name = new List<string>();
        private bool flagChek;//проверка элемента start
        private void changeFlag()//меняю флаг и удаляю первое значение
        {
            name.Remove(name[0]);
            flagChek = !flagChek;
        }
        public FirstClass()//пустой конструктор
        {
            List<string> name = new List<string>() { "start" };//поле с 1 элементом что работало
            flagChek = true;
        }
        public FirstClass(string[] strArr)//конструктор с массивом
        {
            List<string> name0 = strArr.OfType<string>().ToList();//преобразуем массив в список
            for (int i = 0; i < name0.Count; i++)
                if (!name.Contains(name0[i]))//ищу совпадения в списке
                    name.Add(name0[i]);//добавляем в список
            changeFlag();
        }
        public FirstClass(List<string> listName)//конструктор со списком
        {
            name.AddRange(listName);
            changeFlag();
        }
        public void addList(List<string> listName)//добавление списка
        {
            for (int i = 0; i < listName.Count; i++)
                if (!name.Contains(listName[i]))//ищу совпадения в списке
                    name.Add(listName[i]);//добавляем в список
        }
        public static FirstClass operator +(FirstClass name1, FirstClass name2)//перегрузка оператора сложения
        {
            FirstClass uno2List = new FirstClass(name1.name.ToArray());
            uno2List.addList(name2.name);
            return uno2List;
        }
        public override string ToString()
        {
            if (flagChek)
            {
                string allList = "";
                foreach (string elem in name)
                    allList += elem + "\n";
                return allList;
            }
            else
                return "ErrorEmptyList"; //обработка если список пустой
        }
        public string minElemList()//поиск минимального элемента
        {
            string minElem = "";
            int count = int.MaxValue;
            foreach (string elem in name)
            {
                if (count > elem.Length)
                {
                    count = elem.Length;
                    minElem = elem + "\n";
                }
            }
            return minElem;
        }
        public string getElem2Index(int index)//поиск по индексу
        {
            if (index < name.Count)
                return name.ElementAt(index);
            else
                return "OutOfBounds";
        }
    }
}
