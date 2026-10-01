using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI32_1_Saakyan_Neyro.NeuroNet
{
    enum MemoryMode //режим раброты памяти
    {
        GET, //считывание памяти
        SET, //сохранение памяти
        INIT //инициализирует память
    }

    enum NeuronType //тип нейрона
    {
        Hidden, //скрытый
        Output //открытый
    }

    enum NetworkMode  //режим работы
    {
        Train, //обучение
        Test, //Проверка
        Demo //распознанавние
    }




}
