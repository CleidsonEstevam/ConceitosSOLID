namespace Solid.SingleResponsibilityPrinciple.SRP
{
////////////////////////////////////////////////////////////////////////
//    Exemplo de como infringir o Sigle Responsibility Principle:     //
//                                                                    //
//  O princípio nos diz que devemos construir classes                 //    
// com apenas um objetivo.                                            //
//                                                                    //
//  Se sua classe precisa de mais de uma razão para mudar,            //
// ela está fazendo mais de uma coisa.                                //                           
////////////////////////////////////////////////////////////////////////

    public class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int NumeroDoPedido { get; private set; }
        public double TotalDaCompra {get; private set;}
      
        public Usuario(string nome, string email, double totalDaCompra, int numeroDoPedido)
        {
            this.Nome = nome;
            this.Email = email;
            this.NumeroDoPedido = numeroDoPedido;
            this.TotalDaCompra = totalDaCompra;
        }

        public void EnviarNFPorEmail()
        {
            //Método para fazer envio de Email com Nota FIscal
        }
        public void AcessoAoDB()
        {
            SqlConnection conexao = new SqlConnection("string de conexao");
            SqlCommand cmd = new SqlCommand();
     
               conexao.Close();
         }

    }  


}
