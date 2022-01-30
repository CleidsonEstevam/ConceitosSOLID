<h1 align="center">Repositório com abordagem didática sobre:</h1>
<h1 align="center">
<img src="https://github.com/CleidsonEstevam/ConceitosSOLID/blob/main/SOLID/6-%20Imagens/maxresdefault.jpg" height="300" width="500"/>
</h1>
<p align="center" height="400" width="400">
 <a href="#resumo">Resumo</a> •
 <a href="#exemplo">Problemas resolvidos pelo SOLID</a> •
 <a href="#extras">Extras</a> •
 <a href="#autor">Autor</a> 
</p>
<h4 align="center"> 
	🚧  Projeto Finalizado! 🚧
</h4>
<h3 id="resumo">✅ Resumo:</h3>
<p>SOLID é um acrônimo dos cinco princípios da programação orientada a objetos e design de código, foi identificado por Uncle Bob por volta do ano 2000.<br/>
Cada letra representa um princípio a ser seguido para melhor construção dos códigos, são eles:<br/><br/>
S ➡ Single Responsibility Principle (SRP): O princípio fala que uma classe deve ter um, e somente um, motivo para mudar.<br/><br/>
O ➡ Open Closed Principle (OCP): Clases devem estar abertas para expansão, mas, uma vez criadas, devem permanecer fechadas para modificações.<br/><br/>
L ➡ Liskov Substitution Principle (LSP): Classes base devem ser substituíveis por suas classes derivadas, sem que a aplicação quebre.<br/><br/>
I ➡ Interface Segregation Principle (ISP): Interfaces infladas devem ser eliminadas de nossos códigos, muitas interfaces específicas são melhores que uma interface única.<br/><br/>
D ➡ Dependency Inversion Principle (DIP): Sempre sependa de uma abstração e não de uma implementação.
</p>
<br/>
<h3 id="exemplo">✅ Alguns Problemas que o SOLID pode resolver:</h3>
<p>
❌Se uma classe possuir mais de uma responsabilidade, ou seja, ter mais de uma razões para ser modificada, pode gerar problemas futuros, se por exemplo, uma (Classe CLiente) tiver também dados de (Pedidos) que esse cliente realizou, ou (método de envio de Nota Fiscal por e-mail), quando a regra de alguns desses "métodos extras" mudar, toda classe será comprometida.<br/>
  <br/>
  Se ao se deparar com esse problema aplicarmos o princípio de LISKOV, delegar para cada classe uma responsabilidade, vão ficar segregadas, limpas, e bem definidas, nos permitindo um código mais legível, testável e de fácil manutenção.<br/>
  <a href="https://github.com/CleidsonEstevam/ConceitosSOLID/blob/main/SOLID/1-%20SingleResponsibilityPrinciple/SRP.cs">🖱Clique aqui e veja um exemplo de classe que viola esse princípio.<a/>
<br/>
<br/>
 ❌Um dos princípios da programação orientada a objetos (POO), é a Extensibilidade, uma classe pode receber uma extensão de outra para seu crecimento, certo, e onde fica o problema nisso?<br/> Se por exemplo herdarmos uma extensão de uma classe ContaBancaria, e nela temos dois métodos, Poupança e ContaCorente, se precisarmos adicionar mais algum método depois que a mesma foi expandida, além de incluir If's em nosso código, pode ser gerado bags em todas nossas classes que herdam de ContaBancaria, criando assim problemas e podendo até quebrar nossa aplicação.<br/>
 <br/>
 A letra O do SOLID lhe da com esse tipo de problema, devemos sempre segregar nossas classes para que fiquem o mais enxutas possíveis, criando uma classe base, com médos genericos e outras com métodos mais particulares, e fazendo assim com que possamos eextender sem precisar modificar.<br/>
    <a href="https://github.com/CleidsonEstevam/ConceitosSOLID/blob/main/SOLID/2-%20OpenClosedPrinciple/OCP.cs">🖱Clique aqui e veja um exemplo de classe que viola esse princípio.<a/>
</p>
<br/>
    <h3 id="extras">✅ Informações extras do repositório:</h3>
 <p>Existe mais alguns exemplos didáticos nos diretórios do projeto, são situações simples, onde o único objetivo é inlustrar violações do SOLID.<p/>
<br/>  
<h3 id="autor">✅ Autor:</h3>
 <p>Cleidson Estevam<p/>
 <p>Desenvolvedor .NET<p/>
 <p>cleidsonestevamdasilva@hotmail.com<p>
