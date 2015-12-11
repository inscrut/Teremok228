using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teremok228
{
    public abstract class soul
    {
        protected int weight_b = 0;
        protected int height_b = 0;
        protected string sex_b = "";
        protected string orient_x = "";
        protected string color_e = "";
        protected string color_h = "";
        protected string date_d = "";
        protected string name_u = "";
        protected string type_u = "";

        public int Weight { get { return weight_b; } }
        public int Height { get { return height_b; } }
        public string Sex { get { return sex_b; } }
        public string Orientation { get { return orient_x; } }
        public string Color_Head { get { return color_h; } }
        public string Color_Eyes { get { return color_e; } }
        public abstract void Sound();
        public string Date { get { return date_d; } }
        public string Name { get { return name_u; } }
        public string Type { get { return type_u; } }
    }
}
