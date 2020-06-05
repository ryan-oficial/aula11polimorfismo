namespace aula11polimorfismo
{
    public class Calculo
    {
        public string Calcular(){
            return "A vida do Player nao precisa ser calculada";
        }
        public string Calcular(int vida){
            return "A vida atual do player e "+vida;
        }
        public string Calcular(int vida, int escudo){
            return "A vida do Player com escudo e "+ (vida+escudo);
        }
        public string Calcular(string nome, string sobrenome){
            return $"O nome completo do player e {nome} {sobrenome}";
        }
    }
}