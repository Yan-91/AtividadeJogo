namespace Aula16
{
    public class Jogo
    {
        public string nome { get; set; }
        public int preco { get; set; }
        public string descricao { get; set; }
        public int estoque{ get; set; }

        public Jogo(){

        }
        public Jogo(string _nome){
            this.nome = _nome;
        }

        public Jogo(string _nome, int _preco, string _descricao,int _estoque ){
            this.nome =         _nome;
            this.preco =        _preco;
            this.descricao =    _descricao;
            this.estoque =         _estoque;
        }

    }
}
    
