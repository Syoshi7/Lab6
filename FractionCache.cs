using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class FractionCache
    {
        private Fraction fraction;   // Ссылка на объект дроби
        private double? cachedValue; // кэш значение

        public FractionCache(Fraction fraction)
        {
            this.fraction = fraction;
            cachedValue = null;
        }

        // Получение закэшированного значения
        public double GetCachedDecimalValue()
        {
            if (!cachedValue.HasValue)
            {
                Console.WriteLine("Кэш пуст. Вычисляем...");
                cachedValue = fraction.GetDecimalValue();
            }
            else
            {
                Console.WriteLine("Значение взято из кэша.");
            }
            return cachedValue.Value;
        }

        public void InvalidateCache()
        {
            cachedValue = null;
        }
    }

}
