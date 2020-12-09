

namespace SA02_PhillipeRocha
{
    class Cadastroculinaria
    {
        public string  Receita { get; set; }
        public double Preparacao { get; set; }
        public double Dificuldade { get; set; }
        public double Quantidade { get; set; }
        public string Categoria { get; set; }

        public Cadastroculinaria(string nomereceita, double tempopreparacao, double graudificuldade
            , double numpessoa, string Categolinaria)
        {
            Receita = nomereceita;            
            Preparacao = tempopreparacao;
            Dificuldade = graudificuldade;
            Quantidade = numpessoa;
            Categoria = Categolinaria;
          
        }
        public override string ToString()
        {
            return "Obrigado!"; 
        }

    }
    

    
}
