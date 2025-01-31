# Gerenciador de Tarefas

Bem-vindo ao Gerenciador de Tarefas, um projeto de aplicativo console desenvolvido em C#. Este projeto tem como objetivo ajudar no gerenciamento de tarefas do dia a dia, permitindo que o usuário adicione, liste, edite e gerencie tarefas de forma simples e eficiente.

## Funcionalidades

- **Adicionar Tarefa**: Insira o título, descrição e prazo de conclusão para uma nova tarefa.
- **Listar Tarefas**: Visualize todas as tarefas cadastradas, incluindo status e prazo de conclusão.
- **Editar Tarefa**: Altere as informações de uma tarefa existente, como título, descrição ou prazo de conclusão.
- **Excluir Tarefa**: Remova tarefas indesejadas do sistema.
- **Marcar como Concluída**: Atualize o status de uma tarefa para "Concluída".
- **Sair**: Finaliza o programa.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET 9

## Requisitos

- .NET SDK instalado (versão 9.0).

## Como Executar o Projeto

Clone o repositório:

```bash
git clone https://github.com/ronaldo-dsantos/GerenciadorDeTarefas.git
```

Navegue até a pasta do projeto:

```bash
cd GerenciadorDeTarefas
```

Compile o projeto:

```bash
dotnet build
```

Execute o projeto:

```bash
dotnet run
```

## Exemplos de Uso

### Adicionar Tarefa

Ao selecionar a opção "Adicionar Tarefa", você será solicitado a informar:

- **Título**: Um nome para a tarefa.
- **Descrição**: Detalhes adicionais sobre a tarefa.
- **Prazo de Conclusão**: Data no formato dd/mm/aaaa.

### Listar Tarefas

Visualize uma lista com todas as tarefas adicionadas, incluindo:

- **ID**
- **Título**
- **Descrição**
- **Prazo de Conclusão**
- **Status** (Pendente ou Concluída)

### Editar Tarefa

Escolha uma tarefa pelo ID e altere suas informações, como título, descrição ou prazo.

### Excluir Tarefa

Selecione uma tarefa pelo ID e remova-a do sistema.

### Marcar como Concluída

Atualize o status de uma tarefa para "Concluída".

## Contribuições

Contribuições são bem-vindas! Caso queira adicionar funcionalidades ou corrigir bugs, siga os passos abaixo:

1. Faça um fork deste repositório.
2. Crie uma nova branch:

    ```bash
    git checkout -b minha-feature
    ```

3. Realize as alterações e faça commit:

    ```bash
    git commit -m "Adiciona nova funcionalidade"
    ```

4. Envie as alterações para o repositório:

    ```bash
    git push origin minha-feature
    ```

5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo LICENSE para mais informações.