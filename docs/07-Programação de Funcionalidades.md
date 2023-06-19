# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

### Funcionalidade 01: Fazer Login (RF-001)
A funcionalidade de Fazer Login (RF-001) permite que um usuário cadastrado acesse a plataforma `Finanças na mão`, fornecendo suas credenciais de login, como nome de usuário e senha. Ao fazer login, o usuário poderá posteriormente realizar outras atividades disponíveis na plataforma.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Login.cshtml / HomeController.cs / login.js / Login.cshtml.cs


![login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/1be4aea9-132a-4651-9913-25b48a92abdc)


### Funcionalidade 02: Validar Dados de Login (RF-001)
A funcionalidade de Validar Dados de Login (RF-001) permite a verificação de autenticidade das informações fornecidas por um usuário ao tentar acessar a plataforma `Finanças na mão`. Ela garante que as credenciais de login, como nome de usuário e senha, sejam válidas e correspondam às informações armazenadas no banco de dados do sistema. 

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Login.cshtml / HomeController.cs / login.js / Login.cshtml.cs


![loginvalidacao](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/0c831e08-c74a-4113-b778-4489f05bb587)


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

![cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/b70d194c-0976-4122-ad12-9b8eb3538824)


### Funcionalidade 04: Validar Dados de Cadastro (RF-001)
A funcionalidade de Validar Dados de Cadastro (RF-001) permite verificar se as informações fornecidas por um usuário ao se cadastrar em um sistema ou serviço online são válidas e atendem aos critérios pré-definidos. Essa validação garante a integridade dos dados inseridos, evitando erros, inconsistências ou informações inválidas no cadastro. Além disso, ajuda a garantir a qualidade dos dados armazenados no sistema.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir ao usuário a possível realização de login ou cadastro e validar a entrada de dados. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![cadastrovalidacao](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/7be7df4b-27de-476c-a646-82b240132d40)


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

![cadastrarcategoria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/3e8f0563-a970-4d86-bb41-7a0480a27016)

![criarcategoria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/78529912-b48a-42f4-8934-a21e3354f98c)

![indexcategoria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/3e99e16c-843f-476e-b392-2c3c077d186e)

##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Adicione uma `Despesa` ou um `Provento`.
3. Localize `Incluir categoria`. 
5. Clique para criar uma nova categoria.

##### Artefatos produzidos
* [Index.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Categorias/Index.cshtml)
* [Create.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Categorias/Create.cshtml)
* [Lancamentos/Index.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Lancamentos/Create.cshtml)
* [Proventos/Index.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Proventos/IndexProvento.cshtml)

### Funcionalidade 07: Editar categoria (RF-004)

A funcionalidade Editar categoria (RF-004), permita aos usuários editar os itens cadastrados no sistema. Os itens devem estar organizados por categoria, proporcionando uma estrutura clara e organizada para o gerenciamento dos dados.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-003| O sistema deve permitir que o usuário edite itens cadastrados, organizados por categoria.| Edit.cshtml / CategoriasController.cs / Edit.cshtml.cs / site.css

![editarcategoria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Categorias/Edit.cshtml)

##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Adicione uma `Categoria`.
3. Localize o simbolo de `Editar categória`. 
5. Clique no simbolo e faça as alterações.
6. Em seguida, clique em `Salvar`.  

##### Artefatos produzidos
* [Edit.cshtml](src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Categorias/Edit.cshtml)

### Funcionalidade 08: Análise de Receitas (RF-005)

A funcionalidade Análise de Receitas (RF-005), deve fornecer funcionalidades que permitam aos usuários realizar análises detalhadas do orçamento. Essas análises devem ser apresentadas de forma visual, por meio de gráficos, fornecendo uma visão clara e compreensível das informações financeiras.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-003| O sistema deve permitir ao usuário realizar análises de orçamento através de gráficos.| LancamentoController.cs / Index.cshtml.cs / site.css

![semmovimentacao](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/7707b7d4-c3f9-4bde-8cf7-d2fa50e51b03)

![commovimentacoes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/250b0729-050c-4275-bf09-909371ef5f4b)

![visaogeral](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/7e01321a-7d3c-475f-beff-4aa370bd5da3)

##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. No menu, clique em `Despesas`.
3. Clique em `Incluir despesa`. 
5. Preencha os campos obrigatórios.
6. Em seguida, clique em `Adicionar despesa` para salvar.
7. Após, no menu, localize `Visão geral`.  

##### Artefatos produzidos
* [Index.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Lancamentos/Index.cshtml)
* [Create.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Lancamentos/Create.cshtml)
* [VisaoGeral.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Shared/IndexVisao.cshtml)

### Funcionalidade 09: Análise de Proventos (RF-006)

A funcionalidade Análise de Receitas (RF-006), deve fornecer funcionalidades que permitam aos usuários analisar os proventos recebidos e o saldo financeiro de forma visual, utilizando gráficos. Isso possibilitará uma compreensão clara e visualmente representativa das informações relacionadas aos proventos e ao saldo.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-003| O sistema deve permitir ao usuário realizar análises de proventos recebidos e saldo através de gráficos.| LancamentoController.cs / Index.cshtml.cs / site.css

![semprovento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/daed7a31-847d-441e-af4c-b1a0ea427b77)

![indexprovento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/0eae58b6-3b4a-4351-a0a1-45fe4c4d59e1)

![visaogeral](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/7e01321a-7d3c-475f-beff-4aa370bd5da3)

##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. No menu, clique em `Despesas`.
3. Clique em `Incluir despesa`. 
5. Preencha os campos obrigatórios.
6. Em seguida, clique em `Adicionar despesa` para salvar.
7. Após, no menu, localize `Visão geral`.  

##### Artefatos produzidos
* [Index.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Proventos/IndexProvento.cshtml)
* [Create.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Proventos/CreateProvento.cshtml)
* [VisaoGeral.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/blob/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views/Shared/IndexVisao.cshtml)

### Funcionalidade 10: Responsividade (RNF-002)

A funcionalidade Transparencia (RF-006),tem o objetivo de fornecer informações claras, abrangentes e acessíveis aos usuários da plataforma `Finanças na mão`. Estamos comprometidos em informar aos usuários como seus dados serão coletados, usados e protegidos, bem como as regras e condições de uso do serviço. Essa transparência proporciona aos usuários uma maior confiança na utilização do serviço, permite que eles tomem decisões informadas sobre o compartilhamento de dados pessoais e ajuda a fortalecer a relação de confiança entre a organização e os usuários.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-002| O sistema deve ser responsivo permitindo a visualização em um celular de forma adequada. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![responsvidade5](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/cb4beacb-88eb-4871-be59-30a3434f0321)

![responsividade6](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/0c64c9a8-94ac-48fa-96f1-15c0ce97acad)

![responsividade7](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/8ba6ae09-3a81-4926-bf0f-18106bd182a7)

![responsvidade4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/11e69e96-82ac-415c-a2ff-40e05498d4ce)

![responvisidade1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/0d59064e-259a-472a-a531-2a1978af52d8)

![responsvidade3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/fb4ef720-5b8c-45b7-8bb9-848d703d7724)

![responsividade13](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/8b191afd-c4a5-4b59-8fe9-6ee19d78a590)

![responsividade12](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/f2d01285-9f81-4a22-9fc7-b704f5151344)

![responsividade11](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/161fcc20-87a6-4041-b60c-060244104945)

![responsividade10](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/60d33cf4-076f-46ea-a882-e9593a42a086)

![responsividade9](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/6c91d2e2-a88f-4621-afa3-3b9d92d7bb81)

![responsividade8](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/7c0d0635-362a-4015-bcb9-4cf374ad9da8)

##### Instruções de acesso
1. Acesse o site pelo [Link](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/copia_de_seguran%C3%A7a)
2. Localize o rodapé da plataforma `Finanças na Mão`. 
3. Clique em `Política de Privacidade` para visualizar.
4. Clique em `Termos de Uso` para visualizar.
5. Clique em `Quem Somos` para visualizar.

##### Artefatos produzidos
![Views](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views)

### Funcionalidade 11: Transparência (RNF-006)

A funcionalidade Transparencia (RNF-006),tem o objetivo de fornecer informações claras, abrangentes e acessíveis aos usuários da plataforma `Finanças na mão`. Estamos comprometidos em informar aos usuários como seus dados serão coletados, usados e protegidos, bem como as regras e condições de uso do serviço. Essa transparência proporciona aos usuários uma maior confiança na utilização do serviço, permite que eles tomem decisões informadas sobre o compartilhamento de dados pessoais e ajuda a fortalecer a relação de confiança entre a organização e os usuários.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RNF-006| O sistema deve ser transparênte em relação às Políticas de Privacidade, Termos de Serviços e Quem Somos. | Register.cshtml / HomeController.cs / cadastro.js / Register.cshtml.cs

![privacidade](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/be73c3c8-6b86-4cc4-8e07-8b3b089e74a1)

![termosdeuso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/9f058dc6-8137-47ea-bdc0-cddb80365e05)

![quemsomos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/fb401030-2044-4dee-aaf5-b01ee5be3142)

![faleconosco](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/assets/83494301/8f24e35a-67cf-4f1f-b83a-df3551f63b59)

##### Instruções de acesso
1. Acesse o site `Finanças na Mão` por um celular. 

##### Artefatos produzidos
![Views](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t5-grupo4/tree/db_local/src/FinancasNaMaoMVC/FinancasNaMaoMVC/Views)












