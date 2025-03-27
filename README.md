<div align=center>

# Jogo da Forca
  
</div>

![](https://imgur.com/FLDB9p0.gif)

## Introdução
Neste jogo, o sistema escolhe aleatoriamente uma palavra secreta que deve ser adivinhada pelo jogador. Ele pode sugerir letras e, caso estejam corretas, elas são reveladas na palavra. Caso erre, partes do boneco na forca são desenhadas. O jogo termina quando o jogador adivinha corretamente a palavra ou esgota suas tentativas.

## Funcionalidades
- **Seleção Aleatória de Palavra**: O jogo escolhe uma palavra aleatoriamente a partir de um banco de palavras.
- **Sistema de Tentativas**: O jogador tem um número limitado de erros antes que o jogo seja encerrado.
- **Banco de Palavras Personalizável**: Possibilidade de editar ou adicionar novas palavras ao jogo.
- **Desenho da forca**: Cada vez que o jogador erra uma letra, o desenho da forca é incrementado, parte por parte. Quando o desenho da forca é completo, o jogador perde o jogo.

## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=github,git,cs,dotnet)](https://skillicons.dev)

## Como Jogar
1. O jogo seleciona uma palavra aleatória e exibe a dica correspondente.
2. O jogador insere uma letra por vez.
3. Se a letra estiver na palavra, ela aparece nas posições corretas.
4. Se a letra não estiver na palavra, um erro é registrado e parte do boneco é desenhada.
5. O jogo termina quando o jogador acerta a palavra ou esgota suas tentativas.

## Instalação e Execução

### Requisitos
- **.NET SDK** (recomendado .NET 8.0 ou superior)
- **Visual Studio** para compilar e executar o projeto

### Passos
1. **Clonar o Repositório**:
   ```bash
   git clone https://github.com/kbiasebetti/jogo-da-forca.git
2. **Acessar o diretório do projeto:**
   ```bash
   cd jogo-da-forca
3. **Restaurar dependências:**
   ```bash
   dotnet restore
4. **Compilar e executar:**
   ```bash
   dotnet run
