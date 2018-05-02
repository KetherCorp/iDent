using System;

namespace DSD.def
{
    public class Point
    {
        private float positionX { get; set; }
        private float positionY { get; set; }

        public Point(){}

        public Point(float positionX, float positionY){
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public void Translate(float amountX, float amountY){
            positionX += amountX;
            positionY += amountY;
        }
    }
}
