using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    public abstract class Export
    {
        public abstract void Save();
    }

    public class Excel : Export
    {
        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class Pdf : Export
    {
        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class Csv : Export
    {
        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class ThirdPartyExport : Export
    {
        public override void Save()
        {
            ThirdParty thirdParty = new ThirdParty();
            thirdParty.Export();
        }
    }


    public class ThirdParty
    {
        public void Export()
        {
            throw new NotImplementedException();
        }
    }
}
