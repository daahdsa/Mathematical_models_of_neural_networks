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

        //свойства
        public double[] Weights { get => weights; set => weights = value; }
        public double[] Inputs { get => weights; set => weights = value; }

        public double Output { get => output; }
        public double Derivative { get => derivative; }

        // конструктор
        public Neuron (double [] memoryWeights, NeuronType typeNeuron)
        {
            type = typeNeuron;
            weights = memoryWeights;
        }

        public void Activator(double[] i)
        {
            inputs = i;
            double sum = weights[0];
            for(int j = 0; j< inputs.Length; j++)
            {
                sum += inputs[j] * weights[j + 1];
            }

            switch (type)
            {
                case NeuronType.Hidden:
                    output = Logic(sum);
                    derivative = Logic_Derivativator(sum);
                    break;

                case NeuronType.Output:
                    output = Exp(sum);
                    break;
            }

            public double Logic(sum)
            {
                return 0;
            }
        

            public double Logic_Derivativator(sum)
            {
                return sum;
            }

        }

    }
}
