using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class MeasureEntity : IMeasureRepository
    {
        public MeasureEntity(int areaId, DateTime measureDate, float measureValue) 
        {
            AreaId = areaId;
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }


        public MeasureEntity GetLatest()
        {
            return new MeasureEntity(AreaId, MeasureDate, MeasureValue);
        }


        public int AreaId { get; }

        public DateTime MeasureDate { get; }

        public float MeasureValue { get; }




    }
}
