namespace Atividade_1
{
    public class Celula
    {
        private String nome;
        private Celula anterior;

        public Celula() { }
        public Celula(string nome, Celula anterior)
        {
            this.nome = nome;
            this.anterior = anterior;
        }
        public string getNome()
        {
            return nome;
        }
        public Celula getAnterior()
        {
            return anterior;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setAnterior(Celula anterior)
        {
            this.anterior = anterior;
        }
    }
}
