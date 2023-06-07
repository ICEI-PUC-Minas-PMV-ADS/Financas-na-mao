# Registro de Testes de Usabilidade

Após realizar os testes de usabilidade, obtém-se um relatório a partir das análises realizadas. O Registro de Testes de Usabilidade é um relatório que contém as evidências dos testes e relatos dos usuários participantes, baseado no Plano de Testes de Usabilidade desenvolvido para os casos de uso desta etapa.

| Atividade a ser realizada | Feedback do usuário | Considerações (quais os problemas, deficiências, limitações, etc) | Sugestão de melhorias |
|--------------------|------------------------------------|------------------------------------|------------------------------------|
| Tela Inicial | Ótimo | A Tela Inicial possui um design intuitivo e de facil entendimento. | A Tela Inicial esta de acordo com as diretrizes e não requer nenhuma modificação adicional.|
| Campos 'Quem somos', 'Política de Privacidade', 'Termos de Uso' e 'Fale Conosco' na Tela Inicial| Regular | No campo 'Fale conosco', ao enviar uma mensagem para os administradores da aplicação, não há retorno do sistema confirmando o envio. | Desenvolver um alerta informando que a mensagem foi enviada com sucesso ou que houve erro no envio |
| Cadastro de usuário - Campos obrigatórios: Nome, Sobrenome, Contato, E-mail, Senha, Telefone, Confirmação da senha | Excelente| O formulário garante que todos os campos necessários sejam preenchidos adequadamente.| O formulário está em conformidade com as diretrizes e não requer nenhuma modificação adicional.| 
| Realizar login na aplicação - Campos obrigatórios: E-mail e senha | Excelente | O formulário garante que todos os campos necessários sejam preenchidos adequadamente. | O formulário está em conformidade com as diretrizes e não requer nenhuma modificação adicional.|
| Campo 'Esqueci minha Senha' - Campo obrigatório: E-mail  | Excelente | É feito o envio do link por e-mail para resetar a senha.  | O formulário está em conformidade com as diretrizes e não requer nenhuma modificação adicional.|
| Menu Lateral | Bom | O menu fica 'escondido' na página, ficando visível apenas se o usuário clicar no seu nome de usuário no canto superior direito | Colocar o menu em local mais visível e de fácil acesso |
| Tela Minhas Movimentações | Ótimo | Todos os campos devem sem preenchidos, mesmo se o usuário não desejar informar nenhuma observação ou a natureza da despesa. Mesmo que o usuário coloque a data da despesa, ao adiciona-la, a mesma não é informada na tela das movimentações| Permitir que o campo 'Observações' seja opcional para preenchimento. O campo 'Natureza' tem a mesma função do campo 'Categoria', podendo ser removido. Visualizar a data da despesa na página inicial da tela 'Minhas movimentações' |
| Cadastrar categorias | Ótimo | O usuário consegue criar categorias de despesas com facilidade | Fazer com que haja o retorno automático para a página de despesas após adicionar uma categoria |
| Tela 'Meus proventos' | Ótimo | ****** | ****** |
| Cadastrar novo provento | Ótimo | ****** | ****** |
| Tela 'Investimento' | Ótimo | ****** | ****** |
| Fazer novo investimento | Ótimo | ****** |  ****** |


**Detalhamento Análise Heurística**
| ID | Característica | [Sim] / [Não] | Comentários |
|:---------------|:------------------------------------|------------------------------------|:------------------------------------|
| 1 - Visibilidade do status do sistema |
| 1.1 | As telas do sistema iniciam com um título que descreve seu conteúdo? | [Sim] [x] | Sim, as telas do sistema iniciam com um título que descreve seu conteúdo.|
| 1.2 | O ícone selecionado é destacado dos demais não selecionados? | [Sim] [x] | Sim, os icones selecionados geralmente são destacados dos demais não selecionados.|
| 1.3 | Há feedback visual do menu ou escolhas selecionadas? | [Não] [x] |Não, o sistema não oferece feedback visual para indicar qual menu ou escolha foi selecionada pelo usuário.|
| 1.4 | O sistema provê visibilidade do estado atual e alternativas para ação? | [Sim] [x] |Sim, o sistema fornece visibilidade do estado atual e alternativas para ação.|
| 2 - Correspondência entre sistema e mundo real |
| 2.1 | Os ícones e ilustrações são concretos e familiares? | [Sim] [x] | Sim, os ícones e ilustrações são concretos e familiares. |
| 2.2 | As cores, quando utilizadas, correspondem aos códigos de cores comuns? | [Sim] [x] | Sim, as cores correspondem aos códigos de cores comuns. |
| 2.3 | A linguagem utilizada evita jargões técnicos? | [Sim] [x] | Sim, a linguagem utilizada evita jargões. |
| 2.4 | Os números são devidamente separados nos milhares e nos decimais? | [Não] [x] | Não, os números não são devidamente separados nos milhares e nos decimais. |
| 3 - Controle de usuário e liberdade |
| 3.1 | Se o sistema utiliza janelas que se sobrepõem, ele permite a organização e troca simples? | [Não] [x] | Não, o sistema não possui janelas que se sobrepõem. |
| 3.2 | Quando o usuário conclui uma tarefa, o sistema aguarda uma ação antes de processar? | [Sim] [x] | Sim, quando o usuário conclui uma tarefa, o sistema não aguarda uma ação antes de processar. |
| 3.3 | O usuário é solicitado a confirmar tarefas que possuem consequências drásticas? | [Não] [x] | Não, o usuário não é solicitado a confirmar tarefas que possuem consequências drásticas. |
| 3.4 | Existe uma funcionalidade para desfazer ações realizadas pelo usuário? | [Não] [x] | Não, não existe uma funcionalidade para desfazer as ações ralizadas pelo usuário. |
| 3.5 | O usuário pode editar, copiar e colar durante a entrada de dados? | [Sim] [x] | Sim, o usuário pode editar, copiar e colar durante a entrada de dados. |
| 3.6 | O usuário pode se mover entre campos e janelas livremente? | [Sim] [x] | Sim, o usuário pode se mover entre campos e janelas livremente. |
| 3.7 | O usuário pode configurar o sistema, a sessão, a tela conforme sua preferência? | [Sim] [x] | Sim, o usuário pode fazer a configuração conforme sua preferência. |
| 4 - Consistência e padrões |
| 4.1 | O sistema evita uso constante de letras maiúsculas? | [Sim] [x] | Sim, o sistema evita uso constante de letras maiúsculas. |
| 4.2 | Os números são justificados à direita e alinhados quanto aos decimais? | [Sim] [x] | Sim, os números são justificados à direita e alinhados quanto aos decimais.  |
| 4.3 | Os ícones e ilustrações são rotulados? | [Sim] [x] | Sim, os icones e ilustrações são rotulados. |
| 4.4 | As instruções aparecem de forma consistente sempre no mesmo local? | [Sim] [x] | Sim, as instruções aparecem de forma consistente sempre no mesmo local. |
| 4.5 | Os objetos do sistema são nomeados de maneira consistente em todo o sistema? | [Sim] [x] | Sim, os objetos do sistema são nomeados de maneira consistente em todo o sistema. |
| 4.6 | Os campos obrigatórios e opcionais são corretamente sinalizados? | [Sim] [x] | Sim, os campos obrigatórios e opcionais são corretamente sinalizados. |
| 5 - Prevenção de erros |
| 5.1 | As opções de menu são lógicas, distintas e mutualmente exclusivas? | [Sim] [x] | Sim, as opções de menu são lógicas, distintas e mutualmente exclusivas. |
| 5.2 | Se o sistema exibe múltiplas janelas, a navegação entre janelas é simples e visível? | [Sim] [x] | Sim, a navegação entre janelas é simples e visível. |
| 5.3 | O sistema alerta o usuário se ele está prestes a fazer erros críticos? | [Não] [x] | Não, o sistema não alerta o usuário se ele está prestes a fazer erros críticos. |
| 6 - Reconhecimento ao invés de recordação |
| 6.1 | Há distinção clara quando é possível selecionar um item ou vários? | [Sim] [x] | Sim, há distinção clara quando é possível selecionar um item ou vários. |
| 6.2 | Os rótulos de campo estão próximos dos campos e separados pelo menos um espaço? | [Sim] [x] | Sim, Os rótulos de campo estão próximos dos campos e separados por um  espaço. |
| 6.3 | São utilizadas bordas para identificar possiveis grupos de elementos? | [Sim] [x] | Sim, são utilizadas bordas para identificar possiveis grupos de elementos. |
| 6.4 | Existem opções default para o que o usuário precisa selecionar? | [Sim] [x] | Sim, existem opções default para o que o usuário precisa selecionar. |
| 6.5 | Há alguma diferença visível para identificar a janela ativa? | [Não] [x] | Não, não há nenhuma diferença visível para identificar a janela ativa. |
| 7 - Flexibilidade e eficiência de uso |
| 7.1 | Existem atalhos para as funções disponíveis no sistema? | [Sim] [x] | Sim, existem atalhos para as funções disponíveis no sistema. |
| 7.2 | O usuário pode realizar a tarefa de maneiras mais simplificadas?| [Não] [x] | Não, o usuário não pode realizar a tarefa de maneiras mais simplificadas. |
| 7.3 | O sistema permite integração com outras fontes das informações tratadas? | [Sim] [x] | Sim, o sistema permite integração com outras fontes das informações tratadas. |
| 8 - Estética e design minimalista |
| 8.1 | Apenas a informação necessária para ação está visível na tela? | [Sim] [x] | Sim, apenas a informação necessária para ação está visível na tela |
| 8.2 | Os ícones e ilustrações estão distintos do seu fundo? | [Sim] [x] | Sim, os ícones e ilustrações estão distintos do seu fundo |
| 8.3 | Os agrupamentos são separados por espaço em branco? | [Não] [x] | Não, os agrupamentos não são separados por espaço em branco. Porém, são separados de acordo com a paleta de cores da aplicação. |
| 8.4 | Os rótulos e menus são breves, familiares e descritivos das opções que representam? | [Sim] [x] | Sim, Os rótulos são familiares e descritivos das opções que representam.  |
| 9 - Ajudar os usuários e reconhecer, diagnosticar se recuperar de erros |
| 9.1 | É utilizado um sinal sonoro para alertar de erros? | [Não] [x] | Não, não é utilizado um sinal sonoro para alertar de erros |
| 9.2 | Os questionamentos são breves e sem ambiguidade? | [Sim] [x] | Sim, os questionamentos são breves e sem ambiguidade |
| 9.3 | Se um erro é detectado, o usuário tem visibilidade sobre qual o local gerador do erro? | [Sim] [x] | Sim, o usuário tem visibilidade sobre qual o local gerador do erro. |
| 9.4 | As mensagens de erro identificam a severidade e a causa do erro? | [Não] [x] | Não, as mensagens de erro não identificam a severidade, apenas a causa do erro. |
| 9.5 | As mensagens de erro sugerem uma ação para correção? | [Sim] [x] | Sim, as mensagens de erro sugerem uma ação para correção. |
| 10 - Ajuda e documentação |
| 10.1 | As instruções online estão visualmente distintas? | [Sim] [x] | Sim, as instruções online estão visualmente distintas |
| 10.2 | Existe ajuda online sensível ao contexto? | [Não] [x] | Não, não existe ajuda online sensível ao contexto |
| 10.3 | É simples o acesso a ajuda do sistema e retorno ao sistema?| [Sim] [x] | Sim, é simples o acesso a ajuda do sistema e retorno ao sistema |


**Avaliação Estática (inspeção feita pela equipe de desenvolvimento ou alguém interno)**
| Heurísticas |	Notas dos avaliadores |	Média	| Consenso |	Considerações |	Melhorias |
|---------------|------------------------------------|------------------------------------|------------------------------------|------------------------------------|------------------------------------|
| Visibilidade do status do sistema | Avaliador1: 4 - Ótimo | 4 | 4 | O usuário consegue identificar seu status (logado ou não) na aplicação. | Nenhuma melhoria a ser implementada. |
| Correspondência entre sistema e mundo real | Avaliador1: 5 - Excelente | 5 | 5 | Há correspondencia do sistema com o mundo real  | Nenhuma melhoria a ser implementada. |
| Controle de usuário e liberdade | Avaliador1: 4 - Ótimo  | 4 | 4 | O usuário tem total controle da aplicação | Nenhuma melhoria a ser implementada |
| Consistência e padrões | Avaliador1: 5 - Excelente | 5 | 5 | Há um padrão em toda aplicação | Nenhuma melhoria a ser implementada |
| Prevenção de erros | Avaliador1: 5 - Excelente | 5 | 5 | Os erros são prevenidos, e caso aconteçam, o reparo é eficiente | Nenhuma melhoria a ser implementada |
| Reconhecimento ao invés de recordação | Avaliador1: 5 - Excelente | 5 | 5 | Há o reconhecimento da aplicação pelo seu nome e identidade visual | Nenhuma melhoria a ser implementada |
| Flexibilidade e eficiência de uso | Avaliador1: 5 - Excelente | 5 | 5 | A aplicação é eficiente e flexível, atendendo a demanda do usuário | Nenhuma melhoria a ser implementada |
| Estética e design minimalista | Avaliador1: 5 - Excelente | 5 | 5 | A aplicação tem cores que conversam entre si, além de uma estética lógica e de facil entendimento | Nenhuma melhoria a ser implementada |
| Ajudar os usuários e reconhecer, diagnosticar se recuperar de erros | Avaliador1: 5 - Excelente | 5 | 5 | A aplicação dá suporte ao usuário para reparar possíveis falhas | Nenhuma melhoria a ser considerada |
| Ajuda e documentação | Avaliador1: 5 - Excelente | 5 | 5 | Contato para ajuda disponível na aplicação e a disposição do usuário. | Nenhuma melhoria a ser considerada. |

**O que fazer para melhorar**
| Heurísticas |	Melhoria |
|---------------|------------------------------------|
| Visibilidade do status do sistema | Não há melhorias a serem consideradas neste quesito |
| Correspondência entre sistema e mundo real | Não há melhorias a serem consideradas neste quesito |
| Controle de usuário e liberdade | Não há melhorias a serem consideradas neste quesito |
| Consistência e padrões | Não há melhorias a serem consideradas neste quesito |
| Prevenção de erros | Não há melhorias a serem consideradas neste quesito |
| Reconhecimento ao invés de recordação | Não há melhorias a serem consideradas neste quesito |
| Flexibilidade e eficiência de uso | Não há melhorias a serem consideradas neste quesito |
| Estética e design minimalista | Não há melhorias a serem consideradas neste quesito |
| Ajudar os usuários e reconhecer, diagnosticar se recuperar de erros | Não há melhorias a serem consideradas neste quesito |
| Ajuda e documentação | Não há melhorias a serem consideradas neste quesito |
