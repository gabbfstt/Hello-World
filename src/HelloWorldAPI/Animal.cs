namespace HelloWorldAPI
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        public string Classe { get; set; }
        public string Local { get; set; }
        public string Imagem { get; set; }

        public Animal(string nome, 
                        string idade, 
                        string genero, 
                        string especie, 
                        string classe, 
                        string local, 
                        string imagem)
        {
            Nome = nome;
            Idade = int.Parse(idade);
            Genero = genero;
            Especie = especie;
            Classe = classe;
            Local = local;
            Imagem = imagem;

        }
    }
}
