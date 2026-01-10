using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет товар в системе.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Название товара (не более 200 символов, не может быть пустым).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если название пустое или превышает 200 символов.</exception>
        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название товара не может быть пустым.", nameof(value));
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                if (_name != value)
                {
                    _name = value;
                    OnNameChanged();
                }
            }
        }

        /// <summary>
        /// Описание товара (не более 1000 символов).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если описание превышает 1000 символов.</exception>
        public string Info
        {
            get => _info;
            private set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                string newValue = value ?? string.Empty;
                if (_info != newValue)
                {
                    _info = newValue;
                    OnInfoChanged();
                }
            }
        }

        /// <summary>
        /// Стоимость товара (от 0 до 100 000 включительно).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если стоимость выходит за допустимые пределы.</exception>
        public double Cost
        {
            get => _cost;
            private set
            {
                const double MinCost = 0;
                const double MaxCost = 100_000;
                if (value < MinCost || value > MaxCost)
                    throw new ArgumentException($"Стоимость товара должна быть в диапазоне от {MinCost} до {MaxCost}.");

                if (Math.Abs(_cost - value) > 0.01)
                {
                    _cost = value;
                    OnCostChanged();
                }
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }

        // Если понадобятся
        public event EventHandler NameChanged;
        public event EventHandler InfoChanged;
        public event EventHandler CostChanged;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Обновляет название, описание и стоимость товара.
        /// </summary>
        /// <param name="name">Новое название.</param>
        /// <param name="info">Новое описание.</param>
        /// <param name="cost">Новая стоимость.</param>
        public void Update(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }

        protected virtual void OnNameChanged() => NameChanged?.Invoke(this, EventArgs.Empty);
        protected virtual void OnInfoChanged() => InfoChanged?.Invoke(this, EventArgs.Empty);
        protected virtual void OnCostChanged() => CostChanged?.Invoke(this, EventArgs.Empty);

        public object Clone() => new Item(Name, Info, Cost, Category);

        public bool Equals(Item other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        public override bool Equals(object obj) => Equals(obj as Item);

        public override int GetHashCode() => Id.GetHashCode();

        public int CompareTo(Item other)
        {
            if (other is null) return 1;
            return Cost.CompareTo(other.Cost);
        }
    }
}