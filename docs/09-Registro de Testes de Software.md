# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

## Avaliação

| **Caso de Teste** 	| **CT-01 - Realizar cadastro e efetuar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O site deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar e realizar login no sistema. |
| Passos 	| - Acessar o sistema <br> - Visualizar a página principal<br> - Clicar em “Crie sua conta”<br> - Preencher os campos obrigatórios (Nome, e-mail, senha e confirmar senha)<br> - Clicar no botão “Cadastrar”<br> - Preencher campos para login (e-mail e senha)<br> - Clicar no botão “Entrar” | - O cadastro foi realizado com sucesso. |
|Critérios de Êxito| - Usuário logado na aplicação.|

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/8aabe76c-86fb-49b1-9b3f-27cf48a5b7f5


| **Caso de Teste** 	| **CT-02 - Realizar a recuperação de senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - O site deve permitir ao usuário a recuperação de senha e validar a entrada de dados. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar a recuperação de senha. |
| Passos 	| - Acessar o Navegador - Visualizar a página principal - Clicar em “Entrar” - Clicar em “Esqueceu sua senha” - Preencher o campo obrigatório (e-mail) - Clicar em “Redefinir Senha” - Preencher os campos obrigatórios (nova senha e repetir senha) - Clicar em “Redefinir Senha” - Efetuar login | - O cadastro foi realizado com sucesso. |
|Critérios de Êxito| - Acesso na aplicação pelo login.|

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/f5495b61-dff4-444a-b998-4f6d80161e5b


 | **Caso de Teste** 	| **CT-03 - Cadastrar categorias para as movimentações** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03 - O site deve permitir ao usuário cadastrar livremente categorias de suas movimentações, como alimentação, transporte e etc. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar categorias de suas movimentações. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Despesas”<br> - Clicar em “Nova Movimentação” <br>- Clicar em “Incluir Nova Categoria” <br>- Digitar o nome da nova categoria <br>- Clicar em “Adicionar”|
|Critérios de Êxito| - Categoria cadastrada deve aparecer na página de Categorias.|

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/4bd9234d-0ba6-43f4-ba64-ee81bfcc14b9


| **Caso de Teste** 	| **CT-04 - Inserir e editar itens** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-04 - O site deve permitir ao usuário inserir e editar itens cadastrados organizados por categorias. |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir e editar itens. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Despesas”<br> - Clicar em “Nova Movimentação”<br> - Preencher os campos (Valor, Data, Nome da despesa, Despesa fixa, Categoria, Periodicidade e Observações)<br> - Clicar em “Adicionar Despesa” |
|Critérios de Êxito| - Os itens devem aparecer na página “Despesas” |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/0cd971b4-73a1-4b56-967e-4cf3097d3758


| **Caso de Teste** 	| **CT-05 - Análises dos orçamentos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-05 - O site deve permitir ao usuário fazer as análises dos orçamentos e acompanhamento da carteira, através de gráficos, relatórios e receitas. |
| Objetivo do Teste 	| Verificar se o usuário consegue fazer análises dos orçamentos e acompanhamento da carteira. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Visão Geral”<br> |
|Critérios de Êxito| Deve-se visualizar um gráfico. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/e1e6334a-0e53-46ec-8509-17a834b00f97


| **Caso de Teste** 	| **CT-06 - Exportar relatórios** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-07 - O site deve permitir ao usuário exportar relatórios para planilhas. |
| Objetivo do Teste 	| Verificar se o usuário consegue exportar relatórios para planilhas. |
| Passos 	| - Acessar o sistema<br> - Efetuar cadastro (se necessário)<br> - Efetuar login<br> - Acessar a página “Visão Geral”<br> - Rolar a tela para baixo<br> - Clicar em “Gerar receita" |
|Critérios de Êxito| - Deve-se visualizar o relatório em pdf. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/82393577/406f7250-561a-48b5-a249-ef9198a5d147
