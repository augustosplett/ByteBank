namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int NumeroAgencia { get; set; }
        public int NumeroConta { get; set; }
        private double _saldo = 100;
        public static int TotalDeContasCriadas { get; private set; }
        public ContaCorrente(Cliente cliente, int agencia, int numero)
        {
            Titular = cliente;
            NumeroAgencia = agencia;
            NumeroConta = numero;
            ContaCorrente.TotalDeContasCriadas++;
        }
        public double Saldo
        {
            get { return _saldo; }
            set 
            {
                if (value > 0) return;
                _saldo = value; 
            }
        }
  
        public bool Sacar(double valor)
        {
            if(valor <= this._saldo)
            {
                _saldo -= valor;
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo <= valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }   
}
