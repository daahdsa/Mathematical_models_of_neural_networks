using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI32_1_Saakyan_Neyro.NeuroNet
{
    internal class Layer
    {
        //поля
        //модификаторы protected стоят для внутрииерархического использования членов класа
        protected string name_Layer; //наименование слояб которое используется для связи с одн
        string pathDirWeights; //путь к каталогу где находится 
        string pathFileWeights;
        protected int numofneurons;
        protected int numofprevneurons;
        protected const double learningrate = 0.05d;
        protected const double momentum=0.050d;
        protected double[,] lastdeltaweights;
        protected Neuron[] neurons;

        //свойства
        public double[] Data;



        //конструктор

        protected Layer (int non, int nopn, NeyronType nt, string nm_Layer)
        {
            numofneurons = non;
            numofprevneurons = nopn;
            neurons = new Neuron[non];
            name_Layer = nm_Layer;
            pathDirWeights = AppDomain.CurrentDomain.BaseDirectory + "memory\\";
            pathFileWeights = pathDirWeights + name_Layer + "_memoru.csv";

            lastdeltaweights= 
        }
    }
}
