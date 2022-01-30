namespace Solid.DependecyInversionPrinciple.DIP
{
////////////////////////////////////////////////////////////////////////
//    Exemplo de como infringir Dependency Inversion Principle:       //
//                                                                    //
//  O princípio nos diz que devemos depender de abstrações e não de,  //    
// implementações.                                                    //
//  E as abstrações não devem depender de detalhes,                   // 
//  detalhes devem depender de abstrações.                            //
////////////////////////////////////////////////////////////////////////
                           

    public void Pagamento(string id)
    {
        SQLServerProduto produto = new SQLServerProduto();
        string produtoDB = produto.GetProdutoById(id);
        
        return produtoDb;
    }
 //////////////////////////////////////////////////////////////////////////
//  No exemplo a classe de regra de negocio (Pagamento) depende de outra //      
// implementação de nível inferior (SQLServerProduto).                   //                                              
//  Nesse caso, se precisarmos trocar o banco de dados, a aplicação      //    
// iria quebrar pela alta dependência da classe pagamento com a instância//                                                      
// do SQLserver.                                                         // 
///////////////////////////////////////////////////////////////////////////

}