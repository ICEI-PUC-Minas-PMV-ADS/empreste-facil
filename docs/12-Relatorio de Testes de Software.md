# Relatórios de Teste de Software
Todos os testes realizados foram registrados em vídeo e estão disponíveis em uma pasta no drive, para acessá-la clique [aqui](https://drive.google.com/drive/folders/1-CcwwJpaCUywCMCzQeib4ZTu8PbtBmd2?usp=sharing) 

## Processo de registro de teste
Todos os usuários concordaram em participar dos testes e estavam de acordo com a gravação do procedimento, cientes de ter seu nome divulgado, bem como tendo o mesmo perguntado no início de cada gravação e sendo orientados a não utilizar informações sensíveis no processo.

O objetivo de execução de tais testes visava a interação pura do usuário, podendo ter interferência do condutor para que o usuário focasse nas funcionalidades a serem testadas.

Os testes foram conduzidos por Iago Ferreira e foram submetidos as participações dos seguintes usuários:
|**Nome de usuário**|**Link para vídeo do teste**|
|:---:|:---:|
|Geovana Melo - Teste com erros|https://drive.google.com/file/d/1Hx8YO46QfEvi0-CsQTbdRARmvvcoFdTe/view?usp=sharing|
|Geovana Melo - Teste completo|https://drive.google.com/file/d/1N8sBBKg95m6RLQmqFeAMfxbLQb8Gd-UM/view?usp=sharing|
|Giovane Damazio|https://drive.google.com/file/d/1IB6QQvi9Sb_MfFB2QHNBspCGmz_jGSn6/view?usp=sharing|
|Pedro Artur|https://drive.google.com/file/d/1aSbXdqlRoU7PDLGq5a-549HFeozyAkym/view?usp=sharing|
|Maria Clara|https://drive.google.com/file/d/1jgELo_j7YB3kCa1lnPmchwHaS2AGdLGK/view?usp=sharing|

Dentre as funcionalidades testadas estavam o fluxo de registro, login, logout, pedido de empréstimo, relatório de usuários registrados e aprovação de pedido de empréstimo

### Usuario - Geovana Melo (teste com erros)
No primeiro teste, ao tentar registrar o usuário houve um problema relacionado ao deploy da aplicação que impediu que o teste pudesse ser finalizado, conforme registrado em vídeo.

### Usuario - Geovana Melo (teste completo)
Após a correção do erro de deploy foi reiniciado o processo de teste da aplicação, o usuário conseguiu realizar a ação de registro e login sem problemas, porém se confundiu durante o processo de pedido de empréstimo, mesmo conseguindo realizar a simulação do pedido.

Fora da gravação sugiram comentários sobre as fontes utilizadas no projeto e sobre a interface de usuário, relacionado ao excesso de imperativos utilizados.

Outro comentário surgiu fora da gravação, durante uma conversa sobre o processo, solicitando uma melhora focada no fluxo de solicitação de empréstimo que integrando a simulação do mesmo ao fluxo, de forma a facilitar o processo.

### Usuario - Giovane Damazio
Usuario conseguiu efetuar todo o fluxo de registro e login do usuário, bem como o fluxo de administração, embora tenha apresentado dificuldade durante a aprovação do empréstimo e sugeriu uma melhor descrição do campo para melhor experiência durante o fluxo de aprovação de empréstimo.

### Usuario - Maria Clara
O usuário conseguiu realizar todas as ações durante o teste, porém teve problemas durante seu registro, uma ação inesperada caso o usuário digite um espaço no campo de usuário, ação essa que poderia ser tratado no frontend da aplicação, evitando transtornos, estaremos registrando como um bug de baixa criticidade, uma vez que mensagem de erro utilizada para evidenciar o problema não é descritiva. 

Ao pedir para solicitar o empréstimo na tela de simulação foi levada à tela de login, nesse momento o ideal seria, caso o usuário estivesse logado, levar para a tela de pedir empréstimo, talvez já levando para a funcionalidade com os campos preenchidos.

Durante o pedido de empréstimo o usuário tentou utilizar virgula ao invés de ponto, algo que poderia ser resolvido caso uma máscara fosse utilizada no campo de valor da parcela, podemos catalogar como um bug de baixa criticidade.

### Usuario - Pedro Artur
Usuário conseguiu utilizar todos os fluxos com agilidade e interagiu fluentemente com a aplicação, gostou da forma da navegação e intuitividade da mesma, porém evidenciou um problema durante a aprovação do pedido que poderia ser corrigido com um campo de descrição da combobox de estado do pedido.
