using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class MeasureEntity
    {
        public MeasureEntity(int areaId, DateTime measureDate, float measureValue) 
        {
            AreaId = new AreaId(areaId);
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }


        //public MeasureEntity GetLatest()
        //{
            
        //}


        public AreaId AreaId { get; }

        public DateTime MeasureDate { get; }

        public float MeasureValue { get; }




    }
}
