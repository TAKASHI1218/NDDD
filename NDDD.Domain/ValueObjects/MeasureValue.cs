using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureValue:ValueObject<MeasureValue>
    {

        public MeasureValue(float value)
        {
            Value = value;
        }

        public string MeasureValueDisplayValue =>
            Math.Round(Value, 2) + "℃";


        public float Value { get; }


        protected override bool EqualsCore(MeasureValue other)
        {
           return this.Value == other.Value;
        }
    }
}
