namespace Solid.LiskovSubstitutionPrinciple.LSP
{

////////////////////////////////////////////////////////////////////////
//    Exemplo de como infringir o Liskov Principle:                   //
//                                                                    //
//   O princípio nos diz que devemos substituir nossas clases filhas, //    
//  pela classe base sem quebrar a aplicação.                         //
//   Com isso evitamos forçar implementações bases em rotinas que     //
//  deveriam fazer parte de outro grupo.                              //
//                                                                    //                           
////////////////////////////////////////////////////////////////////////
    public class ClienteAlvo : BaseCliente
    {
        public ClienteAlvo(string nome, DateTime dataCadasto) : base (nome, dataCadasrto) {}

        public override bool ClientePremium()
        {
            // O cliente alvo não tem uma data de cadastro, pois, ainda não é cliente fixo.
        }

    }
}
////////////////////////////////////////////////////////////////////////
//    Exemplo de como infringir o Liskov Principle:                   //
//                                                                    //
//  No exemplo acima a classe ClienteAlvo não deve herdar de cliente, //    
// já que BaseCliente, tem como obrigação que seja passado uma data   //
// de cadastro que no caso de alguém que ainda esta sendo sondado não //
// existe.                                                            //
//                                                                    //                           
////////////////////////////////////////////////////////////////////////