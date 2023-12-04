using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolasColoridas
{
    public class Cor
    {
        private int red;
        private int blue;
        private int green;
        private int alpha;
        public int media;

        public Cor(int vermelho, int verde, int azul, int alfa){
            red = vermelho; 
            blue = azul;
            green = verde;
            alpha = alfa;

        }
        public Cor(int vermelho, int verde, int azul){
            red = vermelho;
            blue = azul;
            green = verde;
            alpha = 255;
        }
        public int getterRe(){
            return red;
        }
        public int getterBl(){
            return blue;
        }
        public int getterGr(){
        return green;    
        }
        public int getterAl(){
        return alpha;
        }
        public int getterMe(){
        return media = (red + green + blue)/2;
        }
        public void setRe(int vermelho){
            int setred =  vermelho;
        }
        public void setBl(int azul){
            int  setBl = azul;
        }
        public void setGr(int verde){
            int setGr = verde;
        }public void setAl(int alfa){
            int setAl = alfa;
        }
    }
}