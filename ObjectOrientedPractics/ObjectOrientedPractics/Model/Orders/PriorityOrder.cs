using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет приоритетный заказ с возможностью выбора времени доставки.
    /// </summary>
    [Serializable]
    public class PriorityOrder : Order
    {
        private DateTime _deliveryDate;
        private string _deliveryTimeSlot;

        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get => _deliveryDate;
            set => _deliveryDate = value;
        }

        /// <summary>
        /// Желаемый временной слот доставки.
        /// Допустимые значения: "9:00 – 11:00", "11:00 – 13:00", ..., "19:00 – 21:00"
        /// </summary>
        public string DeliveryTimeSlot
        {
            get => _deliveryTimeSlot;
            set
            {
                // Валидация (опционально, можно усилить позже)
                var validSlots = new[]
                {
                    "9:00 – 11:00",
                    "11:00 – 13:00",
                    "13:00 – 15:00",
                    "15:00 – 17:00",
                    "17:00 – 19:00",
                    "19:00 – 21:00"
                };

                bool isValid = false;
                foreach (var slot in validSlots)
                {
                    if (slot == value)
                    {
                        isValid = true;
                        break;
                    }
                }

                if (!isValid)
                    throw new ArgumentException("Недопустимый временной слот доставки.");

                _deliveryTimeSlot = value;
            }
        }

        /// <summary>
        /// Создаёт приоритетный заказ на основе корзины.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="cart">Корзина покупателя.</param>
        /// <param name="deliveryDate">Желаемая дата доставки.</param>
        /// <param name="deliveryTimeSlot">Временной слот доставки.</param>
        public PriorityOrder(Address address, Cart cart, DateTime deliveryDate, string deliveryTimeSlot)
            : base(address, cart)
        {
            DeliveryDate = deliveryDate;
            DeliveryTimeSlot = deliveryTimeSlot;
        }

        /// <summary>
        /// Конструктор по умолчанию (для сериализации).
        /// </summary>
        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Today.AddDays(1); // завтра по умолчанию
            DeliveryTimeSlot = "9:00 – 11:00";
        }
    }
}