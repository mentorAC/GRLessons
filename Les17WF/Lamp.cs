using System.Drawing;

namespace Les17WF
{
    internal class Lamp
    {

        private int isTurnOn;

        public Color Change()
        {
            isTurnOn++;
            if (isTurnOn == 3)
            {
                isTurnOn = 0;
            }

            if (isTurnOn == 0)
            {
                return Color.White;
            }
            else if (isTurnOn == 1)
            {
                return Color.Black;
            }
            else
            {
                return Color.Gray;
            }

        }

    }
}
