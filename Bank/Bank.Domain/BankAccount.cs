using System;

namespace Bank.Domain
{
    /// <summary>
    /// Representa una cuenta bancaria con funcionalidades de crédito y débito.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Mensaje de error cuando el monto a debitar excede el saldo disponible.
        /// </summary>
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";

        /// <summary>
        /// Mensaje de error cuando el monto a debitar es menor que cero.
        /// </summary>
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        /// <summary>
        /// Nombre del cliente propietario de la cuenta (solo lectura).
        /// </summary>
        private readonly string m_customerName;

        /// <summary>
        /// Saldo actual de la cuenta bancaria.
        /// </summary>
        private double m_balance;

        /// <summary>
        /// Constructor privado utilizado internamente para evitar instanciación sin parámetros.
        /// </summary>
        private BankAccount() { }

        /// <summary>
        /// Inicializa una nueva instancia de <see cref="BankAccount"/>.
        /// </summary>
        /// <param name="customerName">Nombre del cliente.</param>
        /// <param name="balance">Saldo inicial de la cuenta.</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Obtiene el nombre del cliente de la cuenta.
        /// </summary>
        public string CustomerName { get { return m_customerName; } }

        /// <summary>
        /// Obtiene el saldo actual de la cuenta.
        /// </summary>
        public double Balance { get { return m_balance; } }

        /// <summary>
        /// Realiza una operación de débito sobre la cuenta.
        /// </summary>
        /// <param name="amount">Monto a debitar.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Se lanza si el monto excede el saldo o es menor que cero.
        /// </exception>
        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);

            m_balance -= amount;
        }

        /// <summary>
        /// Realiza una operación de crédito sobre la cuenta.
        /// </summary>
        /// <param name="amount">Monto a acreditar.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Se lanza si el monto es menor que cero.
        /// </exception>
        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");

            m_balance += amount;
        }
    }
}
