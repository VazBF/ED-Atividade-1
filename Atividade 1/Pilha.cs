namespace Atividade_1
{
    public class Pilha
    {
        private Celula top;
        private int qtd;
        public void push(String nome)
        {
            Celula nova = new Celula();
            nova.setNome(nome);
            nova.setAnterior(top);
            this.top = nova;
        }
        public void pop()
        {
            if (!isEmpyt())
            {
                top = top.getAnterior();
            }
            else
            {
                Console.WriteLine("Pilha vazia");
            }
        }
        public bool isEmpyt()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int getSize()
        {
            return qtd;
        }
        public void imprimir()
        {
            Celula p = top;
            if (isEmpyt())
            {
                Console.WriteLine("Pilha vazia");
            }
            else 
            {
                while (p != null)
                {
                    Console.WriteLine(p.getNome());
                    p = p.getAnterior();
                }
            }
        }
        public Celula getTop()
        {
            return top;
        }
    }
}
