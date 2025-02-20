using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory
{
    public class NissanHeadlightFactory : HeadLightFactory
    {
        public override HeadLigth CreateHeadLight()
        {
            return new NissanHeadLight();
        }
    }
}
