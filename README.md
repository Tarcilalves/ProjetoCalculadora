
   ![Operadores Aritméticos e a Classe Math](https://github.com/Tarcilalves/ProjetoCalculadora/assets/107896645/dbd5a46a-fd51-42d2-9988-671c9bc263bd)

<h1 align="left">
  <img src="https://github.com/Tarcilalves/ProjetoCalculadora/assets/107896645/759d337e-ad24-416d-b2df-c6e933e2a8e8" width="30px" alt="6231036"> 
  Projeto Calculadora
</h1>

## Percurso
<table>
  </thead>
  <tbody align="left">
    <tr>
      <td>01</td>
      <td>Operadores Aritméticos</td>
    </tr>
    <tr>
      <td>02</td>
      <td>Classe Math</td>     
    </tr>
    <tr>
      <td>03</td>
      <td>Links úteis</td>  
    </tr>    
  </tbody>
  <tfoot>
</table>

## Objetivo 🎯
Aprender os fundamentos do C# com foco em **Operadores Aritméticos** e **Classe Math**.

## Ferramentas 🛠️
[![GitHub](https://img.shields.io/badge/GitHub-000?style=for-the-badge&logo=github&logoColor=30A3DC)](https://docs.github.com/)
[![Git](https://img.shields.io/badge/Git-000?style=for-the-badge&logo=git&logoColor=E94D5F)](https://git-scm.com/doc) 
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-000?style=for-the-badge&logo=windows&logoColor=2CA5E0)
![Vscode](https://img.shields.io/badge/Vscode-007ACC?style=for-the-badge&logo=visual-studio-code&logoColor=white)

<h2>
  Operadores Aritméticos 
</h2>

 > Em C#, os operadores são símbolos especiais que realizam operações em variáveis e valores. Aqui estão alguns dos principais tipos de operadores em C#:

1. **Operadores Aritméticos:**
    - Realizam operações matemáticas básicas.

```
int soma = 5 + 3;
int subtracao = 7 - 2;
int multiplicacao = 4 * 6;
int divisao = 10 / 2;
int resto = 15 % 4; // Retorna o resto da divisão
```
2. **Operadores de Atribuição:**
   - O operador de atribuição ‘=’ atribui o valor do operando do lado direito a uma variável, um   =  ou um elemento indexador fornecido pelo operando dp lado esquerdo. O resultado de uma expressão de atribuição é o valor atribuído a um operando do lado esquerdo. O tipo do operandos do lado direito deve ser do mesmo tipo ou implicitamente conversível para o operando do lado esquerdo. 
```
int x = 10;
x += 5; // Equivalente a x = x + 5;
```
3. **Operadores de Comparação:**
    - Comparam valores e retornam resultados booleanos.
```
bool igual = (a == b);
bool diferente = (a != b);
bool maiorQue = (a > b);
bool menorQue = (a < b);
bool maiorOuIgual = (a >= b);
bool menorOuIgual = (a <= b);
```
4. **Operadores de Incremento e Decremento:**
    - Aumentam ou diminuem o valor de uma variável por 1.
```
int contador = 5;
contador++;
contador--;
```
5. **Operadores de Bitwise:**
    - Realizam operações a nível de bit.
```
int bitwiseAND = a & b;
int bitwiseOR = a | b;
int bitwiseXOR = a ^ b;
int bitwiseComplemento = ~a;
```
<h2>
  Combinando Operadores
</h2>

 > Em C#, você pode combinar o sinal de atribuição (=) com operadores aritméticos para realizar operações e atribuir o resultado a uma variável. Isso é conhecido como "operador composto de atribuição"

**Alguns exemplos:**
```

int x = 5;

// Operador composto de adição
x += 3;  // Equivalente a x = x + 3;

// Operador composto de subtração
x -= 2;  // Equivalente a x = x - 2;

// Operador composto de multiplicação
x *= 4;  // Equivalente a x = x * 4;

// Operador composto de divisão
x /= 2;  // Equivalente a x = x / 2;

// Operador composto de resto
x %= 3;  // Equivalente a x = x % 3;
```

<h1>
  Classe Math
</h1>


> A classe Math em C# (e em várias outras linguagens de programação) fornece um conjunto de métodos estáticos para realizar operações matemáticas comuns. Esses métodos são implementados como métodos estáticos, o que significa que você pode chamá-los diretamente usando o nome da classe sem precisar criar uma instância dela.<br>
A classe Math inclui uma variedade de métodos para operações matemáticas, como trigonometria, exponenciação, raiz quadrada, arredondamento, valor absoluto, entre outros.

##  Projeto: Calculadora
A proposta central do Projeto Calculadora é proporcionar aos usuários as principais operações matemáticas e funções trigonométricas por meio de um menu de escolhas. O programa guiará o usuário, solicitando a seguinte informação: "Qual operação deseja fazer?". A escolha do usuário será feita a partir de uma lista fornecida.

Nas operações de soma, subtração, multiplicação, divisão e potência, o programa pedirá que o usuário forneça dois números para realizar a operação. Já nas funções trigonométricas, o programa solicitará o ângulo necessário para calcular o seno, cosseno e tangente. O resultado será gerado conforme a escolha da operação.

Após a conclusão de uma operação, o programa deverá retornar ao menu principal, possibilitando ao usuário realizar outras operações ou encerrar o programa.

```
Seja bem-vindo à Minha Calculadora!

1 - Adição       
2 - Subtração 
3 - Multiplicação
4 - Divisão
5 - Potência
6 - Seno
7 - Coseno
8 - Tangente
0 - Sair

Qual operação deseja fazer?
```
Neste projeto, pude aplicar os conhecimentos adquiridos sobre operações aritméticas e a utilização da classe Math em programação. A familiaridade com as operações matemáticas básicas, como soma, subtração, multiplicação, divisão e potenciação, foi crucial para implementar um programa funcional de calculadora.

Além disso, a estrutura de controle de fluxo utilizando o **switch case** proporcionou uma maneira eficiente de lidar com diferentes escolhas do usuário, tornando o código mais organizado e fácil de entender. A classe Math ofereceu uma gama de funções trigonométricas que enriqueceram as capacidades da calculadora, proporcionando uma experiência abrangente para o usuário.

Dessa forma, a aplicação prática desses conceitos permitiu a criação de uma calculadora versátil, capaz de realizar diversas operações matemáticas e trigonométricas de forma eficiente e intuitiva. Este projeto não apenas consolidou os conhecimentos teóricos adquiridos, mas também ofereceu a oportunidade de desenvolver habilidades práticas na implementação de lógica de programação para resolver problemas matemáticos.

## Links Úteis

[Microsoft-arithmetic-operators](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators)

[W3schools](https://www.w3schools.com/cs/cs_operators.php)


## Pessoas Desenvolvedoras do Projeto

|<img src="https://github.com/Tarcilalves/ProjetoCalculadora/assets/107896645/8a70a052-692d-4513-ad32-0b07089f8734" width="30%" alt="fo" align="left">|
|--|
|<p align="left">Tarcila Alves</p>| 

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/tarcilacardosoalves/) 	[![Instagram](https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/tarcilacardosoalves/)








