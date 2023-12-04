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
        private int nrvezes;

        public int getterRa(){
            return raio;
        }
        public int getterNr(){
            return nrvezes;
        }
        public Cor getterMuda(){
            return muda;
        }

        public Bola(Cor cor,int rai)
        {
            muda = cor;
            raio = rai;
            nrvezes = 0;
        }
        public void Pop(int des){
            if(des > 0){
                raio = 0;
            }
        }
        public void Atirar(int atira){
            if(raio > 1){
                nrvezes++;
            }
        }
    }
}