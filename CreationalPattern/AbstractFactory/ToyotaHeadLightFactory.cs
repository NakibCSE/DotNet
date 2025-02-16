using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory
{
    public class ToyotaHeadLightFactory : HeadLightFactory
    {
        public override HeadLigth CreateHeadLight()
        {
            return new ToyotaHeadlight();
        }
    }
}
