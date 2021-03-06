using ExercicioApiEcommerce.Enumeradores;

namespace ExercicioApiEcommerce.Entidades
{
    public abstract class Pagamento
    {
        public bool Valido { get; set; }
        public EFormaPagamento FormaPagamento { get; protected set; }
        public decimal Valor { get; protected set; }

        public abstract void Validar();
    }
}
