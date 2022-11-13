using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class UserInteraction
    {
        private MouseEventArgs e;
        public UserInteraction(MouseEventArgs mouseEventArgs)
        {
            e = mouseEventArgs;
        }
        public string GetPos()
        {
            float x = e.X;
            float y = e.Y;
            if (x <= 56 && y <= 56)
            {
                return "00";
            }
            else if ((x >= 58 && x <= 112) && y <= 56)
            {
                return "01";
            }
            else if ((x >= 114 && x <= 166) && y <= 56)
            {
                return "02";
            }
            else if ((x >= 171 && x <= 220) && y <= 56)
            {
                return "03";
            }
            else if ((x >= 224 && x <= 276) && y <= 56)
            {
                return "04";
            }
            else if ((x >= 280 && x <= 329) && y <= 56)
            {
                return "05";
            }
            else if ((x >= 334 && x <= 386) && y <= 56)
            {
                return "06";
            }
            else if ((x >= 390 && x <= 440) && y <= 56)
            {
                return "07";
            }
            else if ((x >= 442 && x <= 497) && y <= 56)
            {
                return "08";
            }


            else if (x <= 56 && (y >= 59 && y <= 111))
            {
                return "10";
            }
            else if (x <= 56 && (y >= 115 && y <= 167))
            {
                return "20";
            }
            else if (x <= 56 && (y >= 171 && y <= 223))
            {
                return "30";
            }
            else if (x <= 56 && (y >= 225 && y <= 275))
            {
                return "40";
            }
            else if (x <= 56 && (y >= 280 && y <= 329))
            {
                return "50";
            }
            else if (x <= 56 && (y >= 337 && y <= 387))
            {
                return "60";
            }
            else if (x <= 56 && (y >= 392 && y <= 442))
            {
                return "70";
            }
            else if (x <= 56 && (y >= 445 && y <= 496))
            {
                return "80";
            }


            else if ((x >= 58 && x <= 112) && (y >= 59 && y <= 111))
            {
                return "11";
            }
            else if (((x >= 114 && x <= 166)) && (y >= 59 && y <= 111))
            {
                return "12";
            }
            else if ((x >= 171 && x <= 220) && (y >= 59 && y <= 111))
            {
                return "13";
            }
            else if ((x >= 224 && x <= 276) && (y >= 59 && y <= 111))
            {
                return "14";
            }
            else if ((x >= 280 && x <= 329) && (y >= 59 && y <= 111))
            {
                return "15";
            }
            else if ((x >= 334 && x <= 386) && (y >= 59 && y <= 111))
            {
                return "16";
            }
            else if ((x >= 390 && x <= 440) && (y >= 59 && y <= 111))
            {
                return "17";
            }
            else if ((x >= 442 && x <= 497) && (y >= 59 && y <= 111))
            {
                return "18";
            }
            else if ((x >= 58 && x <= 112) && (y >= 115 && y <= 167))
            {
                return "21";
            }
            else if ((x >= 114 && x <= 166) && (y >= 115 && y <= 167))
            {
                return "22";
            }
            else if ((x >= 171 && x <= 220) && (y >= 115 && y <= 167))
            {
                return "23";
            }
            else if ((x >= 224 && x <= 276) && (y >= 115 && y <= 167))
            {
                return "24";
            }
            else if ((x >= 280 && x <= 329) && (y >= 115 && y <= 167))
            {
                return "25";
            }
            else if ((x >= 334 && x <= 386) && (y >= 115 && y <= 167))
            {
                return "26";
            }
            else if ((x >= 390 && x <= 440) && (y >= 115 && y <= 167))
            {
                return "27";
            }
            else if ((x >= 442 && x <= 497) && (y >= 115 && y <= 167))
            {
                return "28";
            }
            else if ((x >= 58 && x <= 112) && (y >= 171 && y <= 223))
            {
                return "31";
            }
            else if ((x >= 114 && x <= 166) && (y >= 171 && y <= 223))
            {
                return "32";
            }
            else if ((x >= 171 && x <= 220) && (y >= 171 && y <= 223))
            {
                return "33";
            }
            else if ((x >= 224 && x <= 276) && (y >= 171 && y <= 223))
            {
                return "34";
            }
            else if ((x >= 280 && x <= 329) && (y >= 171 && y <= 223))
            {
                return "35";
            }
            else if ((x >= 334 && x <= 386) && (y >= 171 && y <= 223))
            {
                return "36";
            }
            else if ((x >= 390 && x <= 440) && (y >= 171 && y <= 223))
            {
                return "37";
            }
            else if ((x >= 442 && x <= 497) && (y >= 171 && y <= 223))
            {
                return "38";
            }
            else if ((x >= 58 && x <= 112) && (y >= 225 && y <= 275))
            {
                return "41";
            }
            else if ((x >= 114 && x <= 166) && (y >= 225 && y <= 275))
            {
                return "42";
            }
            else if ((x >= 171 && x <= 220) && (y >= 225 && y <= 275))
            {
                return "43";
            }
            else if ((x >= 224 && x <= 276) && (y >= 225 && y <= 275))
            {
                return "44";
            }
            else if ((x >= 280 && x <= 329) && (y >= 225 && y <= 275))
            {
                return "45";
            }
            else if ((x >= 334 && x <= 386) && (y >= 225 && y <= 275))
            {
                return "46";
            }
            else if ((x >= 390 && x <= 440) && (y >= 225 && y <= 275))
            {
                return "47";
            }
            else if ((x >= 442 && x <= 497) && (y >= 225 && y <= 275))
            {
                return "48";
            }
            else if ((x >= 58 && x <= 112) && (y >= 280 && y <= 329))
            {
                return "51";
            }
            else if ((x >= 114 && x <= 166) && (y >= 280 && y <= 329))
            {
                return "52";
            }
            else if ((x >= 171 && x <= 220) && (y >= 280 && y <= 329))
            {
                return "53";
            }
            else if ((x >= 224 && x <= 276) && (y >= 280 && y <= 329))
            {
                return "54";
            }
            else if ((x >= 280 && x <= 329) && (y >= 280 && y <= 329))
            {
                return "55";
            }
            else if ((x >= 334 && x <= 386) && (y >= 280 && y <= 329))
            {
                return "56";
            }
            else if ((x >= 390 && x <= 440) && (y >= 280 && y <= 329))
            {
                return "57";
            }
            else if ((x >= 442 && x <= 497) && (y >= 280 && y <= 329))
            {
                return "58";
            }
            else if ((x >= 58 && x <= 112) && (y >= 337 && y <= 387))
            {
                return "61";
            }
            else if ((x >= 114 && x <= 166) && (y >= 337 && y <= 387))
            {
                return "62";
            }
            else if ((x >= 171 && x <= 220) && (y >= 337 && y <= 387))
            {
                return "63";
            }
            else if ((x >= 224 && x <= 276) && (y >= 337 && y <= 387))
            {
                return "64";
            }
            else if ((x >= 280 && x <= 329) && (y >= 337 && y <= 387))
            {
                return "65";
            }
            else if ((x >= 334 && x <= 386) && (y >= 337 && y <= 387))
            {
                return "66";
            }
            else if ((x >= 390 && x <= 440) && (y >= 337 && y <= 387))
            {
                return "67";
            }
            else if ((x >= 442 && x <= 497) && (y >= 337 && y <= 387))
            {
                return "68";
            }
            else if ((x >= 58 && x <= 112) && (y >= 337 && y <= 387))
            {
                return "61";
            }
            else if ((x >= 58 && x <= 112) && (y >= 392 && y <= 442))
            {
                return "71";
            }
            else if ((x >= 114 && x <= 166) && (y >= 392 && y <= 442))
            {
                return "72";
            }
            else if ((x >= 171 && x <= 220) && (y >= 392 && y <= 442))
            {
                return "73";
            }
            else if ((x >= 224 && x <= 276) && (y >= 392 && y <= 442))
            {
                return "74";
            }
            else if ((x >= 280 && x <= 329) && (y >= 392 && y <= 442))
            {
                return "75";
            }
            else if ((x >= 334 && x <= 386) && (y >= 392 && y <= 442))
            {
                return "76";
            }
            else if ((x >= 390 && x <= 440) && (y >= 392 && y <= 442))
            {
                return "77";
            }
            else if ((x >= 442 && x <= 497) && (y >= 392 && y <= 442))
            {
                return "78";
            }
            else if ((x >= 58 && x <= 112) && (y >= 445 && y <= 496))
            {
                return "81";
            }
            else if ((x >= 114 && x <= 166) && (y >= 445 && y <= 496))
            {
                return "82";
            }
            else if ((x >= 171 && x <= 220) && (y >= 445 && y <= 496))
            {
                return "83";
            }
            else if ((x >= 224 && x <= 276) && (y >= 445 && y <= 496))
            {
                return "84";
            }
            else if ((x >= 280 && x <= 329) && (y >= 445 && y <= 496))
            {
                return "85";
            }
            else if ((x >= 334 && x <= 386) && (y >= 445 && y <= 496))
            {
                return "86";
            }
            else if ((x >= 390 && x <= 440) && (y >= 445 && y <= 496))
            {
                return "87";
            }
            else if ((x >= 442 && x <= 497) && (y >= 445 && y <= 496))
            {
                return "88";
            }
            return "";
        }
    }
}
