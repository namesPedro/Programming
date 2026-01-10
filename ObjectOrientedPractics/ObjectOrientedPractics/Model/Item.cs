using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет товар в системе.
    /// </summary>
    [Serializable]
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
        /// Название товара (не более 200 символов).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается когда название пустое или превышает 200 символов.</exception>
        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название товара не может быть пустым");
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Описание товара (не более 1000 символов).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается когда описание превышает 1000 символов.</exception>
        public string Info
        {
            get => _info;
            private set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Стоимость товара (от 0 до 100 000).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается когда стоимость выходит за допустимые пределы.</exception>
        public double Cost
        {
            get => _cost;
            private set
            {
                if (value < 0 || value > 100000)
                    throw new ArgumentException("Стоимость товара должна быть в диапазоне от 0 до 100 000");
                _cost = value;
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }

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
        /// Обновляет информацию о товаре.
        /// </summary>
        /// <param name="name">Новое название товара.</param>
        /// <param name="info">Новое описание товара.</param>
        /// <param name="cost">Новая стоимость товара.</param>
        public void Update(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <inheritdoc/>
        public bool Equals(Item other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return Equals(obj as Item);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <inheritdoc/>
        public int CompareTo(Item other)
        {
            if (other is null) return 1;
            return Cost.CompareTo(other.Cost);
        }
    }
}