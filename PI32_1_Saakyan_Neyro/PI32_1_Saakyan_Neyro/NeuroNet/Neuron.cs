using static System.Math;


namespace PI32_1_Saakyan_Neyro.NeuroNet
{

    class Neuron
    {
        //поля
        private NeuronType type; //тип нейрона
        private double[] weights; //его веса
        private double[] inputs; //его входы
        private double output; //его выход
        private double derivative; //производная

        //константы для функции активации
        private double a = 0.001d; //это для функции рело, а у меня логистическая ес чо
    }
}
