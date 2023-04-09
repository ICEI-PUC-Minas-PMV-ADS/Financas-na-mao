# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

<div align="center">
<img src="https://user-images.githubusercontent.com/83494301/230747613-25321de9-9cc4-438b-8f54-89bc0ee2e389.png" width="700px" />
</div>

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

<div align="center">
<img src="https://user-images.githubusercontent.com/83494301/230741928-2d047b6e-79ca-47a4-a6f2-50da83c802e3.png" width="700px" />
</div>

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

![Esquema Relacional](https://user-images.githubusercontent.com/83494301/230747211-900ea594-1403-4052-9a9b-3f88a1615ff7.png)

## Tecnologias Utilizadas

**Linguagens utilizadas:**
* C#: Linguagem de programação moderna e orientada a objetos, utilizada para desenvolvimento do backend da solução.
* Javascript: Linguagem de programação utilizada no frontend para adicionar interatividade e dinamismo a solução.

**Frameworks utilizados:**
* ASP.NET Core MVC: implementa o padrão Model-View-Controller e oferece uma base sólida para o desenvolvimento da solução.
* Entity Framework: ORM para criação automática de tabelas no banco de dados a partir das nossas classes dentro do código (code-first)

Optamos pelo uso do framework ASP.NET Core MVC para o desenvolvimento da solução, devido à sua capacidade de implementar o padrão Model-View-Controller e fornecer recursos poderosos para o desenvolvimento de aplicativos web modernos.

**Bibliotecas utilizadas:**
* jquery-ajax-unobtrusive: é utilizada no projeto para permitir a adição de atributos "data-" personalizados ao HTML, possibilitando a adição de funções AJAX do JQuery, sem a necessidade de recarregar a página inteira para alterar um único elemento.

**API utilizada:**
* ASP.NET Core Identity: API utilizada para implementar a função de login e autenticação do usuário na interface do usuário, devido à sua facilidade de uso e integração com outros recursos do ASP.NET Core.

**IDE de desenvolvimento:**
* O Visual Studio Community foi selecionado por sua excelente integração com o Framework ASP.NET, bem como outras ferramentas-chave como o SQL Serve.

SQL Server foi escolhido devido à sua eficiência e flexibilidade na manipulação e organização de grandes volumes de dados. Além disso, o SQL oferece recursos avançados de segurança e integridade dos dados, que são fundamentais em um projeto de gerenciamento financeiro.

**Outras tecnologias utilizadas:**
* HTML: Linguagem de marcação utilizada para criar e estruturar conteúdo na web.
* CSS: Linguagem de folha de estilo utilizada para estilizar e formatar páginas web criadas com HTML.
* Razor: Sintaxe de marcação usada para criar páginas web dinâmicas no framework ASP.NET da Microsoft.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

<div align="center">
<img src="https://user-images.githubusercontent.com/83494301/230752587-58d44310-ac12-4be0-af85-bf78eb262184.png" width="700px" />
</div>

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
