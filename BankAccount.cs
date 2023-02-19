using System;
using Extensions;

namespace StaticKeyword
{
    class BankAccount
    {
        public static decimal InterestRate;

        private decimal _amount;

        static BankAccount()// Если этот конструктор убрать, то значение по умолчанию было бы равно 0 и ставка отрицательная, деньги вычитаютя
        {
            InterestRate = 5;//то значение по умолчанию было бы равно 0, было бы не правильно
        }

        public BankAccount(decimal initialDeposit)
        {
            _amount = initialDeposit;
        }

        public void IncreaseAmout()
        {
            _amount += _amount * InterestRate / 100; // Здесь к нашему счету мы прибавляем значение счета в связи с поцентной ставкой
        }

        public decimal GetAmount()
        {
            return _amount;
        }

        public static decimal CalculateNewInterestRate() 
            => InterestRate + (decimal)new Random().Next(-1.0d, 1.0d);// возвращаем наша ставка + разница
    }
}
