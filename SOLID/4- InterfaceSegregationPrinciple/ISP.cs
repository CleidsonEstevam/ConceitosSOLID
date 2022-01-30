namespace Solid.InterfaceSegregationPrinciple.ISP
{
////////////////////////////////////////////////////////////////////////
//    Exemplo de como infringir Insterface Segregation Principle:     //
//                                                                    //
//  O princípio nos diz que devemos evitar inflar nossas interfaces,  //    
// evitando assim que classes deixem métodos vazios ao herdá-la       //
//  Devemos manter nossas interfaces limpas e segregadas implementando//
// apenas contratos necessários a quem lhe invoque.                   //
//                                                                    //                           
////////////////////////////////////////////////////////////////////////
     interface IVeiculo
    {
        void ConfigurarCarro();
        void ConfigurarMoto();
        void ConfigurarAviao();
    }

/////////////////////////////////////////////////////////////////////////
//    Exemplo de como infringir Insterface Segregation Principle:      //
//                                                                     //
//  Todos os contratos declarados são de fato veículos, mas, com suas  //    
// próprias características, na classe CARRO, por exemplo, teremos a   //
// assinatura Moto e Avião vazias, instanciadas apenas porque a        //
// Interface IVeiculo obriga, sujando o código e quebrando o princípio.//
//                                                                     //                           
/////////////////////////////////////////////////////////////////////////
}