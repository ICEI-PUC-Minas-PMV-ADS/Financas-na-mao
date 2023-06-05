# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

### Funcionalidade 01: Fazer Login (RF-001)
A funcionalidade de Fazer Login (RF-001) permite que um usuário cadastrado acesse a plataforma `Finanças na mão`, fornecendo suas credenciais de login, como nome de usuário e senha. Ao fazer login, o usuário poderá posteriormente realizar outras atividades disponíveis na plataforma.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Login.cshtml / HomeController.cs / login.js / Login.cshtml.cs


![Publicação de interação](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/e9586857-2254-4e21-8c21-a35dd5da2a6b)


### Funcionalidade 02: Validar Dados de Login (RF-001)
A funcionalidade de Validar Dados de Login (RF-001) permite a verificação de autenticidade das informações fornecidas por um usuário ao tentar acessar a plataforma `Finanças na mão`. Ela garante que as credenciais de login, como nome de usuário e senha, sejam válidas e correspondam às informações armazenadas no banco de dados do sistema. 

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Login.cshtml / HomeController.cs / login.js / Login.cshtml.cs


![Publicação de interação](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/fb7b3147-cb76-4198-a51f-593ccbfbdfb0)


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

![Publicação de interação](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/e69b9746-5f8e-43fa-94b2-b5fd86218eeb)


### Funcionalidade 04: Validar Dados de Cadastro (RF-001)
A funcionalidade de Validar Dados de Cadastro (RF-001) permite verificar se as informações fornecidas por um usuário ao se cadastrar em um sistema ou serviço online são válidas e atendem aos critérios pré-definidos. Essa validação garante a integridade dos dados inseridos, evitando erros, inconsistências ou informações inválidas no cadastro. Além disso, ajuda a garantir a qualidade dos dados armazenados no sistema.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![Publicação de interação](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/04309348-bbfe-47cb-b11f-9cf186ac7e91)


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


### Funcionalidade 06: Cadastro de categoria (RF-003)

A funcionalidade Cadastro de categoria (RF-003),tem o objetivo possibilitar a classificação e categorização de elementos ou itens dentro de um sistema ou aplicativo. Ela permite aos usuários criar categorias personalizadas e atribuir itens a essas categorias com base em critérios específicos. Isso facilita a organização e busca dos itens, tornando mais fácil para os usuários encontrar as informações ou produtos que desejam. Além disso, o cadastro de categoria pode ser utilizado para análises, relatórios e tomadas de decisão com base nas diferentes categorias existentes no sistema.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-003| O sistema deve permitir ao usuário cadastrar livremente categorias de suas movimentações, como alimentação, transporte e etc.| Create.cshtml / CategoriasController.cs / Create.cshtml.cs / site.css

![Criar categoria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/6a3fc875-d92a-4e8a-bb89-52673abe06d9)

![Criar categoria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/6775bbb2-9f70-4cea-8b74-232051856150)


##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Adicione uma Despesa em `Minhas Movimentações`.
3. Preencha os campos obrigatórios.
4. Localize `Incluir categoria`. 
5. Clique em `Incluir categoria` para criar uma categoria.

##### Artefatos produzidos
* [Register.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml)
* [Register.cshtml.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml.cs)
* [HomeController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Controllers/HomeController.cs)
* [cadastro.js](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/wwwroot/js/cadastro.js)

### Funcionalidade 05: Responsividade (RNF-002)

A funcionalidade Transparencia (RF-006),tem o objetivo de fornecer informações claras, abrangentes e acessíveis aos usuários da plataforma `Finanças na mão`. Estamos comprometidos em informar aos usuários como seus dados serão coletados, usados e protegidos, bem como as regras e condições de uso do serviço. Essa transparência proporciona aos usuários uma maior confiança na utilização do serviço, permite que eles tomem decisões informadas sobre o compartilhamento de dados pessoais e ajuda a fortalecer a relação de confiança entre a organização e os usuários.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-002| O sistema deve ser responsivo permitindo a visualização em um celular de forma adequada. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![ Responsivo - Página inicial](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/71b43df1-a6d1-4119-9c59-e02e898e45e0)


![Responsivo - Cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/e017b14c-2733-46fd-a0ab-dab750ad44ca)


![Responsivo - Login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/8bd9c5e0-6c91-4aee-9c53-693f87333c78)


![NavBar](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/1a64a1fd-5e97-4e5f-9bfc-b7029e5d4422)


##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Localize o rodapé da plataforma `Finanças na Mão`. 
3. Clique em `Política de Privacidade` para visualizar.
4. Clique em `Termos de Uso` para visualizar.
5. Clique em `Quem Somos` para visualizar.

##### Artefatos produzidos
* [Register.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml)
* [Register.cshtml.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml.cs)
* [HomeController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Controllers/HomeController.cs)
* [cadastro.js](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/wwwroot/js/cadastro.js)

### Funcionalidade 07: Transparência (RNF-006)

A funcionalidade Transparencia (RNF-006),tem o objetivo de fornecer informações claras, abrangentes e acessíveis aos usuários da plataforma `Finanças na mão`. Estamos comprometidos em informar aos usuários como seus dados serão coletados, usados e protegidos, bem como as regras e condições de uso do serviço. Essa transparência proporciona aos usuários uma maior confiança na utilização do serviço, permite que eles tomem decisões informadas sobre o compartilhamento de dados pessoais e ajuda a fortalecer a relação de confiança entre a organização e os usuários.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-006| O sistema deve ser transparênte em relação às Políticas de Privacidade, Termos de Serviços e Quem Somos. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![Política de Privacidade](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/7bc3c590-9813-4895-a651-d8d6a1b32b3b)

![Termos de Uso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/4b4cdb6c-6391-431f-b615-45dc6f8b73e8)


![Quem Somos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/9a43fbf3-16f0-4fdd-8e9e-4d9407d410a8)


##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Localize o rodapé da plataforma `Finanças na Mão`. 
3. Clique em `Política de Privacidade` para visualizar.
4. Clique em `Termos de Uso` para visualizar.
5. Clique em `Quem Somos` para visualizar.

##### Artefatos produzidos
* [Register.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml)
* [Register.cshtml.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Areas/Identity/Pages/Account/Register.cshtml.cs)
* [HomeController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Controllers/HomeController.cs)
* [cadastro.js](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/main/src/FinancasNaMaoMVC/FinancasNaMaoMVC/wwwroot/js/cadastro.js)












