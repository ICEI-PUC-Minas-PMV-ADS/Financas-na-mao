# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

### Funcionalidade 01: Fazer Login (RF-001)
A funcionalidade de Fazer Login (RF-001) permite que um usuário cadastrado acesse a plataforma `Finanças na mão`, fornecendo suas credenciais de login, como nome de usuário e senha. Ao fazer login, o usuário poderá posteriormente realizar outras atividades disponíveis na plataforma.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Login.cshtml / HomeController.cs / login.js / Login.cshtml.cs


![Publicação de interação](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/copia_de_seguran%C3%A7a/docs/img/login.jpeg)


### Funcionalidade 02: Validar Dados de Login (RF-001)
A funcionalidade de Validar Dados de Login (RF-001) permite a verificação de autenticidade das informações fornecidas por um usuário ao tentar acessar a plataforma `Finanças na mão`. Ela garante que as credenciais de login, como nome de usuário e senha, sejam válidas e correspondam às informações armazenadas no banco de dados do sistema. 

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Login.cshtml / HomeController.cs / login.js / Login.cshtml.cs


![Publicação de interação](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/copia_de_seguran%C3%A7a/docs/img/login.jpeg)

##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Certifique que o seu `Cadastro` foi efetuado corretamente.
3. Clique em `Entrar`.
4. Forneça os seus dados de login  `E-mail` e `Senha` válido nos campos apresentados.
5. Clique no botão `Entrar`.

##### Artefatos produzidos
* [Login.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Login.cshtml)
* [HomeController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Controllers/HomeController.cs)
* [login.js](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/wwwroot/js/login.js)
* [Login.cshtml.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Login.cshtml.cs)


### Funcionalidade 03: Efetuar Cadastro	(RF-001)
A funcionalidade de Efetuar Cadastro (RF-001) permite que um usuário crie uma conta no sistema, fornecendo as informações necessárias para acessar os recursos disponíveis.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![Screenshot 2023-05-07 143228](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/copia_de_seguran%C3%A7a/docs/img/registro.jpeg)


### Funcionalidade 04: Validar Dados de Cadastro (RF-001)
A funcionalidade de Validar Dados de Cadastro (RF-001) permite verificar se as informações fornecidas por um usuário ao se cadastrar em um sistema ou serviço online são válidas e atendem aos critérios pré-definidos. Essa validação garante a integridade dos dados inseridos, evitando erros, inconsistências ou informações inválidas no cadastro. Além disso, ajuda a garantir a qualidade dos dados armazenados no sistema.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![Screenshot 2023-05-07 143228](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/copia_de_seguran%C3%A7a/docs/img/registro.jpeg)

##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Clique no botão `Crie sua conta`.
3. Insira um  `Nome`,`Sobrenome`, `Contato`, `E-mail` válido nos campos apresentados.
4. Insira uma `Senha` válida.
5. Confirme a `Senha`.
6. Clique no botão `Cadastrar`.

##### Artefatos produzidos
* [Register.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml)
* [Register.cshtml.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml.cs)
* [HomeController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Controllers/HomeController.cs)
* [cadastro.js](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/wwwroot/js/cadastro.js)
