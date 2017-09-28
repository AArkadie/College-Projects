using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class NeuralNet
    {
        //input[#n +1], medin[#neurons], medout[#neurons], synone[#inputs + 1, #neurons]
        //syntwo[#neurons, #output], error[#outputs], sigma[#neurons], sigmoid[#neurons]
        public float[] input, medin, medout, error, sigma, sigmoid;
        float[,] synone, syntwo;
        Random r = new Random();
        public int numIn, numOut, numNeurons;
        public float rate;

        public NeuralNet(int numIn, int numOut, int numNeurons, float rate)
        {
            this.numIn = numIn;
            this.numOut = numOut;
            this.numNeurons = numNeurons;
            this.rate = rate;
            input = new float[numNeurons + 1];
            medin = new float[numNeurons];
            medout = new float[numNeurons];
            synone = new float[numIn + 1, numNeurons];//fill with randoms
            for (int i = 0; i < synone.GetLength(0); i++)
            {
                for (int j = 0; j < synone.GetLength(1); j++)
                {
                    synone[i, j] = (float)r.NextDouble()/10;
                }
            }
            syntwo = new float[numNeurons, numOut];//fill with randoms
            for (int i = 0; i < syntwo.GetLength(0); i++)
            {
                for (int j = 0; j < syntwo.GetLength(1); j++)
                {
                    syntwo[i, j] = (float)r.NextDouble()/10;
                }
            }
            error = new float[numOut];
            sigma = new float[numNeurons];
            sigmoid = new float[numNeurons];
        }


        public float[] evaluate(float[] input1)
        {
            float[] output = new float[numOut];
            for(int i = 0; i < numIn; i++)
            {
                input[i] = input1[i];
            }
            input[numIn] = 1;
                //Coordinate Conversion
            for (int i = 0; i < numNeurons; i++)
            {
                medin[i] = 0;
                for (int j = 0; j < numIn + 1; j++)
                {
                    medin[i] += synone[j, i] * input[j];
                }
                medout[i] = (float)Math.Tanh(medin[i]);
            }

            for (int i = 0; i < numOut; i++)
            {
                output[i] = 0;
                for(int j = 0; j < numNeurons; j++)
                {
                    output[i] += syntwo[j, i] * medout[j];
                }
            }
            return output;
        }

        
        

        public void train(float [] input1, float [] target)
        {
            
                float[] burn = evaluate(input1);
                for(int j = 0; j < numOut; j++)
                {
                    error[j] = target[j] - burn[j];
                }
            //Back Propagation
            for (int i = 0; i < numOut; i++)
            {
                for (int j = 0; j < numNeurons; j++)
                {
                    syntwo[j, i] += rate * medout[j] * error[i];
                }
            }
            for (int i = 0; i < numNeurons; i++)
            {
                sigma[i] = 0;
                for (int j = 0; j < numOut; j++)
                {
                    sigma[i] += error[j] * syntwo[i, j];
                }
                sigmoid[i] = (float)(1 - Math.Pow(medout[i], 2));
            }
            for (int i = 0; i < numIn + 1; i++)
            {
                for (int j = 0; j < numNeurons; j++)
                {
                    float delta = rate * sigmoid[j] * sigma[j] * input[i];
                    synone[i, j] += delta;
                }
            }
        }

    }
}
