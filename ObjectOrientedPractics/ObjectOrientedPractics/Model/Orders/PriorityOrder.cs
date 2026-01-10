using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет приоритетный заказ с возможностью выбора даты и времени доставки.
    /// </summary>
    public class PriorityOrder : Order
    {
        private static readonly string[] ValidTimeSlots =
        {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };

        private DateTime _deliveryDate;
        private string _deliveryTimeSlot;

        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get => _deliveryDate;
            set => _deliveryDate = value.Date; // сохраняем только дату, без времени
        }

        /// <summary>
        /// Желаемый временной слот доставки.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если указан недопустимый слот.</exception>
        public string DeliveryTimeSlot
        {
            get => _deliveryTimeSlot;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Временной слот не может быть пустым.");

                foreach (var slot in ValidTimeSlots)
                {
                    if (slot == value)
                    {
                        _deliveryTimeSlot = value;
                        return;
                    }
                }

                throw new ArgumentException("Недопустимый временной слот доставки.");
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="cart">Корзина с товарами.</param>
        /// <param name="deliveryDate">Желаемая дата доставки.</param>
        /// <param name="deliveryTimeSlot">Временной слот доставки.</param>
        public PriorityOrder(Address address, Cart cart, DateTime deliveryDate, string deliveryTimeSlot)
            : base(address, cart)
        {
            DeliveryDate = deliveryDate;
            DeliveryTimeSlot = deliveryTimeSlot;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, доставка: {DeliveryDate:dd.MM.yyyy} {DeliveryTimeSlot}";
        }
    }
}