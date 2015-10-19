using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TibiaTekBot.Features;

namespace TibiaTekBot
{
    public class Kernel
    {
        public ExperienceChecker ExperienceChecker
        {
            get; private set;
        }

        public Kernel()
        {
            Client = new Tibia();
            ExperienceChecker = new ExperienceChecker(this);
        }

        public Tibia Client
        {
            get; private set;
        }

        public void Start()
        {
            
        }
    }
}
