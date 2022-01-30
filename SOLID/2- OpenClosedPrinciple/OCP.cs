
namespace Solid.OpenClosedPrinciple.OCP
{

////////////////////////////////////////////////////////////////////////
//    Exemplo de como infringir o Open/Closed Principle:              //
//                                                                    //
//   O princípio nos diz que devemos estender nossas classes          //    
//  atravé de Heranças ou interfaces.                                 //
//   Mas, uma vez criada não devem ser modificadas.                   //
//                                                                    //
//   Na dúvida versione a aplicação e evite que ela quebre.           //                           
////////////////////////////////////////////////////////////////////////
    public class ContaBancaria
    {
        public string NumeroDaConta { get; set; }
        public string NumeroDaAgencia { get; set; }
        public string TipoDaConta { get; set; }
        public string ContaCorrente { get; set; }
        public string Poupanca { get; set; }



      public ContaBancaria(string numeroDaConta, string numeroDaAgencia, string tipoDaConta)
      {
         NumeroDaConta = numeroDaConta;
         NumeroDaAgencia = numeroDaAgencia;
      }

      public void TipoDaConta()
      {
          if(tipoDaConta == 1)
          {
              return ContaCorrente + NumeroDaAgencia;                      
          }                                                                 
          else                                                              ////////////////////////////////////////////////////////////////////////    
          {                                                                 //    Exemplo de como infringir o Open/Closed Principle:              //
              return Poupanca + NumeroDaAgencia;                            //                                                                    //
          }                                                                 //   Se precisarmos adicionar, por exemplo chave do PIX como opção,   //    
                                                                            //  todas as classes que já herdam dessa, vão exigir mudanças para    //
                                                                            //  que não quebrem.                                                  //
                                                                            //    Nesse caso, devemos usar uma classe base com métodos comuns, e  //
                                                                            //   criar uma para cada tipo de necessidade, onde a mesma vai        //                                                               //
                                                                            //   ser estendida com os recursos da base, que não sera modificada,  //
                                                                            //   ou criar interfaces para que os contratos herdados sejam         //     
                                                                            //   obrigatoriamente implementados.                                  //                           
                                                                            ////////////////////////////////////////////////////////////////////////   
      
      }

    }
}







