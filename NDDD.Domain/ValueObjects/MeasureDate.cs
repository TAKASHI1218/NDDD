using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureDate : ValueObject<MeasureDate>
    {
        public MeasureDate(DateTime value)
        {
            Value = value;
        }

        public string MeasureDateDisplayValue =>
            Value.ToString("yyyy/MM/dd HH:mm:ss");

        public DateTime Value { get; }

        protected override bool EqualsCore(MeasureDate other)
        {
            return this.Value == other.Value;
        }
    }
}
