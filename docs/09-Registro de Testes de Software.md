# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

## Avaliação

| **Caso de Teste** 	| **CT-01 - Realizar cadastro e efetuar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O site deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar e realizar login no sistema. |
| Passos 	| - Acessar o sistema <br> - Visualizar a página principal<br> - Clicar em “Crie sua conta”<br> - Preencher os campos obrigatórios (Nome, e-mail, senha e confirmar senha)<br> - Clicar no botão “Cadastrar”<br> - Preencher campos para login (e-mail e senha)<br> - Clicar no botão “Entrar” | - O cadastro foi realizado com sucesso. |
|Critérios de Êxito| - Usuário logado na aplicação.|

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/f0cad795-9096-45f2-bc8e-dbad721e5251

| **Caso de Teste** 	| **CT-02 - Realizar a recuperação de senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - O site deve permitir ao usuário a recuperação de senha e validar a entrada de dados. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar a recuperação de senha. |
| Passos 	| - Acessar o Navegador - Visualizar a página principal - Clicar em “Entrar” - Clicar em “Esqueceu sua senha” - Preencher o campo obrigatório (e-mail) - Clicar em “Redefinir Senha” - Preencher os campos obrigatórios (nova senha e repetir senha) - Clicar em “Redefinir Senha” - Efetuar login | - O cadastro foi realizado com sucesso. |
|Critérios de Êxito| - Acesso na aplicação pelo login.|

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/dd6e9e15-a22d-4b49-bdc2-0f13b4781368

 | **Caso de Teste** 	| **CT-03 - Cadastrar categorias para as movimentações** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03 - O site deve permitir ao usuário cadastrar livremente categorias de suas movimentações, como alimentação, transporte e etc. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar categorias de suas movimentações. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Minhas Movimentações”<br> - Clicar em “Incluir Despesa” <br>- Clicar em “Incluir Nova Categoria” <br>- Digitar o nome da nova categoria <br>- Clicar em “Adicionar”|
|Critérios de Êxito| - Categoria cadastrada deve aparecer na página de Categorias.|

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/0ad97816-ce5d-4b8b-bf6b-101ea9af5009

| **Caso de Teste** 	| **CT-04 - Inserir e editar itens** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-04 - O site deve permitir ao usuário inserir e editar itens cadastrados organizados por categorias. |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir e editar itens. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Minhas Movimentações”<br> - Clicar em “Incluir Despesa”<br> - Preencher os campos (Valor, Data, Nome da despesa, Despesa fixa, Categoria, Periodicidade e Observações)<br> - Clicar em “Adicionar Despesa” |
|Critérios de Êxito| - Os itens devem aparecer na página “Minhas Movimentações”
|

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/8abaa28c-509f-40e5-96a1-3852ffc3d46a

| **Caso de Teste** 	| **CT-05 - Análises dos orçamentos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-05 - O site deve permitir ao usuário fazer as análises dos orçamentos e acompanhamento da carteira, através de gráficos, relatórios e receitas. |
| Objetivo do Teste 	| Verificar se o usuário consegue fazer análises dos orçamentos e acompanhamento da carteira. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login - Acessar a página “Minhas Movimentações”<br> - Rolar a página para baixo |
|Critérios de Êxito| Deve-se visualizar um gráfico de pizza. |

| **Caso de Teste** 	| **CT-06 - Exportar relatórios** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-07 - O site deve permitir ao usuário exportar relatórios para planilhas. |
| Objetivo do Teste 	| Verificar se o usuário consegue exportar relatórios para planilhas. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Minhas Movimentações”<br> - Clicar em “Gerar relatório de movimentações |
|Critérios de Êxito| - Deve-se visualizar o relatório em planilha. |

