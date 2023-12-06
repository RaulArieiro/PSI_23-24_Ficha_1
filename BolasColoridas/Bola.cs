using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolasColoridas
{
    public class Bola
    {
        private Cor muda; 
        private int raio;
        private int nrAtiradas;
        private bool rebentou;

        public int GetterRa(){
            return raio;
        }
        public int GetterNr(){
            return nrAtiradas;
        }
        public Cor GetterMuda(){
            return muda;
        }

        public Bola(Cor muda, int raio){
            this.muda = muda;
            this.raio = raio;
        }
        public void Pop(){
            raio = 0;
            rebentou = true;        
        }
        public void Atirar(){
            if(!rebentou){
                nrAtiradas++;
            }
        }
        public int GetVezesAtirada(){
            return nrAtiradas;
        }
        public Cor GetCor(){
            return muda;
        }

    }
}