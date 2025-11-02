using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Exceptions
{
    public sealed class DataNotExistsException:ExceptionBase
    {
        public DataNotExistsException() :base("データがありません")
        { }

        public override ExceptionKind Kind => ExceptionKind.Info;
    }
}
