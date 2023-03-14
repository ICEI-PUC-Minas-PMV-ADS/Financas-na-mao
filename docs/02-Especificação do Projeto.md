# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>


## Personas

![Persona John](./img/personaJohn.jpg)
![Persona John](./img/personaVanda.jpg)
![Persona John](./img/personaMirian.jpg)


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|John Castro Ramos  | Gostaria de receber indicadores de alertas de limites de gastos | Para evitar possíveis gastos excessivos. |
| John Castro Ramos | Gostaria de definir limites de gastos para categorias específicas | Para ter maior controle com gastos em despesas primárias e secundárias. |
| Vanda Sabino Ribeiro | Gostaria de informações do meu fluxo financeiro em forma de gráficos | Para poder ter uma melhor visualização da minha situação financeira |
| Vanda Sabino Ribeiro | Gostaria de cadastrar minhas despesas diárias | Para poder ter mais organização no ato de pagamento de contas. |
| Mirian Mota dos Santos  | Gostaria de ter acesso a relatórios de vendas dos ativos investidos | Para ter controle dos produtos mais solicitados. |
| Mirian Mota dos Santos  | Gostaria de informações dos rendimentos dos ativos ao decorrer do tempo | Para ter controle de investimentos futuros. |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 19/06/2023. |
|RE-02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend e Backend, utilizando as linguagens HTML, CSS, JavaScript e C#. |
|RE-03| O projeto conta com a participação de sete integrantes, que dividirão as atividades de desenvolvimento, não podendo subcontratar o trabalho. |
|RE-04| O projeto não poderá gerar custos. |



## Diagrama de Casos de Uso

![Diagrama de casos de uso](./img/diagrama-casos-de-uso.png)