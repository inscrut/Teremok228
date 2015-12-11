using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teremok228
{
    class Gorilla : soul
    {
        Random _rnd2 = new Random();

        public Gorilla(int _w, int _h, bool _s, int or, int ce, int ch, string dt)
        {
            type_u = "Gorilla";
            weight_b = _w;
            height_b = _h;

            if (_s) sex_b = "Он";
            else sex_b = "Она";

            if (_s)
            {
                switch (_rnd2.Next(0, 3))
                {
                    case 0:
                        name_u = "Жора";
                        break;
                    case 1:
                        name_u = "Семен";
                        break;
                    case 2:
                        name_u = "Саня";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (_rnd2.Next(0, 3))
                {
                    case 0:
                        name_u = "Мила";
                        break;
                    case 1:
                        name_u = "Лиза";
                        break;
                    case 2:
                        name_u = "Карина";
                        break;
                    default:
                        break;
                }
            }
            switch (or)
            {
                case 0:
                    orient_x = "Асексуал";
                    break;
                case 1:
                    orient_x = "Натурал";
                    break;
                case 2:
                    orient_x = "Гей";
                    break;
                default:
                    break;
            }
            switch (ce)
            {
                case 0:
                    color_e = "Зеленый";
                    break;
                case 1:
                    color_e = "Красный";
                    break;
                case 2:
                    color_e = "Голубой";
                    break;
                default:
                    break;
            }
            switch (ch)
            {
                case 0:
                    color_h = "Черный";
                    break;
                case 1:
                    color_h = "Белый";
                    break;
                case 2:
                    color_h = "Полосатый";
                    break;
                default:
                    break;
            }
            date_d = dt;
        }

        public override void Sound()
        {
            System.Media.SoundPlayer SoundPlayer = new System.Media.SoundPlayer(Properties.Resources.goril);
            SoundPlayer.Load();
            SoundPlayer.Play();
        }
    }
}
