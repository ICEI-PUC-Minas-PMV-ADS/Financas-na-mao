# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:
- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APIS)

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

 
| **Caso de Teste** 	| **CT-01 - Realizar cadastro e efetuar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O site deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar e realizar login no sistema. |
| Passos 	| - Acessar o sistema <br> - Visualizar a página principal<br> - Clicar em “Crie sua conta”<br> - Preencher os campos obrigatórios (Nome, e-mail, senha e confirmar senha)<br> - Clicar no botão “Cadastrar”<br> - Preencher campos para login (e-mail e senha)<br> - Clicar no botão “Entrar” | - O cadastro foi realizado com sucesso. |
|Critérios de Êxito| - Comunicação correta com o banco de dados.|


| **Caso de Teste** 	| **CT-02 - Realizar a recuperação de senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - O site deve permitir ao usuário a recuperação de senha e validar a entrada de dados. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar a recuperação de senha. |
| Passos 	| - Acessar o Navegador - Visualizar a página principal - Clicar em “Entrar” - Clicar em “Esqueceu sua senha” - Preencher o campo obrigatório (e-mail) - Clicar em “Redefinir Senha” - Preencher os campos obrigatórios (nova senha e repetir senha) - Clicar em “Redefinir Senha” - Efetuar login | - O cadastro foi realizado com sucesso. |
|Critérios de Êxito| - Acesso na aplicação pelo login.|

 | **Caso de Teste** 	| **CT-03 - Cadastrar categorias para as movimentações** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03 - O site deve permitir ao usuário cadastrar livremente categorias de suas movimentações, como alimentação, transporte e etc. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar categorias de suas movimentações. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Minhas Movimentações”<br> - Clicar em “Incluir Despesa” <br>- Clicar em “Incluir Nova Categoria” <br>- Digitar o nome da nova categoria <br>- Clicar em “Adicionar”|
|Critérios de Êxito| - Comunicação correta com o banco de dados.<br> - Categoria criada.|

| **Caso de Teste** 	| **CT-04 - Inserir e editar itens** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-04 - O site deve permitir ao usuário inserir e editar itens cadastrados organizados por categorias. |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir e editar itens. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Minhas Movimentações”<br> - Clicar em “Incluir Despesa”<br> - Preencher os campos (Valor, Data, Nome da despesa, Despesa fixa, Categoria, Periodicidade e Observações)<br> - Clicar em “Adicionar Despesa” |
|Critérios de Êxito| - Comunicação correta com o banco de dados.<br> - Os itens devem aparecer na página “Minhas Movimentações”
|

| **Caso de Teste** 	| **CT-05 - Análises dos orçamentos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-05 - O site deve permitir ao usuário fazer as análises dos orçamentos e acompanhamento da carteira, através de gráficos, relatórios e receitas. |
| Objetivo do Teste 	| Verificar se o usuário consegue fazer análises dos orçamentos e acompanhamento da carteira. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login - Acessar a página “Minhas Movimentações”<br> - Rolar a página para baixo |
|Critérios de Êxito| Deve-se visualizar um gráfico de pizza. |

| **Caso de Teste** 	| **CT-06 - Visualizar informações de ativos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-06 - O site deve permitir ao usuário visualizar as informações de ativos pré-definidos pelo sistema de ações e fundos imobiliários, como preço atual, proventos recebidos e saldo. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar informações de ativos. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login - Acessar a página “Investimentos”<br> - Clicar em “Fazer investimento”<br> - Preencher os campos (Onde deseja aplicar, Valor aplicado, Data da aplicação, Deseja fazer esta aplicação com periodicidade, Periodicidade do Investimento)<br> - Clicar em Salvar |
|Critérios de Êxito| - Comunicação correta com o banco de dados.<br> - Deve conseguir visualizar um resumo e um gráfico. |

| **Caso de Teste** 	| **CT-07 - Exportar relatórios** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-07 - O site deve permitir ao usuário exportar relatórios para planilhas. |
| Objetivo do Teste 	| Verificar se o usuário consegue exportar relatórios para planilhas. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Minhas Movimentações”<br> - Clicar em “Gerar relatório de movimentações |
|Critérios de Êxito| - Deve-se visualizar o relatório em planilha. |