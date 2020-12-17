/*let idade = 5;
console.log('idade');
let altura = 180;*/
 /*let nome = 'rafael'; //string literal
let idade = 25.90;//number literal
let estaAprovado = true; //bloolean
let sobrenome = Undefined; //Undefined
let corSelecionada = null //Redefinir um valor*/
/*
let pessoa = {
  nome:  'gabriel',
  idade: 25,
  estaAprovado: true,
  sobrenome: 'falcão'
};
console.log(pessoa);
*/
/*
//ARAYS
let familia = [true,65,'gabriel',12];
console.log(familia.length);
console.log(familia[0]);
*/

//functions
/*
let corSite='azul'
 function resetarCor(cor, tonalidade){
   corSite=cor + tonalidade;
 }
console.log(corSite);
resetarCor("verde"," claro");
console.log(corSite);
*/
//function realiza uma tarefa e não devolve nada
/*
function dizerNome(){
  console.log('Gabriel');
}
dizerNome();
//faz alguma cálculo e retorna algo
function multiplicarPorDois(valor){
  return valor*2;
}
//console.log(multiplicarPorDois(5));
let resultado = multiplicarPorDois(5);

console.log(resultado);
*/

//operadores Aritiméticos(matemátricos)
/*
let salario = 100;
console.log(salario+salario);
console.log(salario-salario);
console.log(salario*salario);
console.log(salario/salario);
console.log(5**5);*/

//++ --
/*
let idade = 18;
console.log(idade++);
console.log(idade);*/

//operadores Atribuição
/*
let valorTeclado = 100;
valorTeclado+=valorTeclado;//vale para todos os operadores matemáticos
//valorTeclado= valorTeclado+valorTeclado;
console.log(valorTeclado);*/

//Operadores de Comparação

//Operadores de igualdade
//igualdade estrita
/*
console.log( 1===1 );//compara os valores e o tipo
console.log ('1' === 1);*/

//igualdade solta
/*
console.log (1==1);
*/
/*let pontos = 100;
  let tipo = pontos >100? 'premium' : 'comum';
  console.log(tipo);*/

//Operadores lógicos

   //operador logico E (&&)
   // retorna true  se os 2 operandos forem true
   //console.log(true && false);
   /*
   let maiorIdade = true;
   let possuiCarteira = true;
   let podeAplicar = maiorIdade && possuiCarteira;
   console.log(podeAplicar);*/

   //Operador logico ou (||)
   /*
   let maiorIdade = true;
   let possuiCarteira = false ;
   let podeAplicar = maiorIdade || possuiCarteira;

  console.log(podeAplicar);
  */
  //Operador Not (!)
  /*
  let maiorIdade = false;
  let possuiCarteira = false ;
  let podeAplicar = maiorIdade || possuiCarteira;

 console.log('Pode aplicar:',podeAplicar);

   let candidatoRecusado = !podeAplicar;
   console.log('Candidato Recusado:',candidatoRecusado);
   */
//Operadores bitwise

// Falsy
//underfined
//null
// 0
//false
//''
//NaN - not a number

//truthy
/*
let corPersonalizada = '';
let corPadrao = 'Azul';
let corPerfil = corPersonalizada|| corPadrao
console.log(corPerfil);
*/

//trocar variaveis
/*
let a ='vermelho';
let b = 'azul';

let c = a;
a = b;
b = c;

console.log(a);
console.log(b);
*/

// if..else

//  Se a hora estiver entre 6hrs até 12: Bom dia!
// Se estiver entre 12 e 18: Boa Tarde
// Caso contrário: boa noite.
/*
 let a = 16;

 if(a>6 && a<=12){
   console.log("Bom dia!");
 }
 else if(a>12 && a<=18){
   console.log("Boa tarde!")
 }
 else {
   console.log("Boa noite!")
 }
*/
//Switch case
/*
let permissao; //comum,gerente,diretor.
permissao = 'diretor'
switch (permissao) {
  case 'comum' : console.log("Você é um usuário comum");
      break;
    case 'gerente' : console.log("Você é um gerente");
      break;
    case 'diretor' : console.log("Você é um diretor");
      break;
      default: console.log("Usuário não reconhecido");

}
*/
//laços de repetição
//1.For
/*
    for(let i=1;i<=5;i++){
    if(i%2!==0){//mostrar somente num impares modulus
         console.log(i);
      }
    }
*/

//2.While
/*
let i = 5;
while (i>=1){
  if(i%2!==0){//mostrar somente num impares //modulus//
       console.log(i);
    }
    i--;
}
*/
//3.DO while
/*
let i = 0;
do{
  console.log('digitando',i);
  i++;
}
while( i<10)
*/
//4. For in
/*
const pessoa ={
  nome: 'gabriel',
  idade: 16
};
for(let chave in pessoa){
  console.log(chave,pessoa['nome']);
}
const cores= ['Vermelho','Azul','Verde'];

for(let indice in cores){
  console.log(indice,cores[indice])
}
*/

//5.  For..of
/*
const cores= ['Vermelho','Azul','Verde'];

for(let cor of cores){
  console.log(cor);
}
*/
//Escrevga uma fução que usa 2 números e retorna o maior entre eles
/*
let valorMaximo = max(10,20);
console.log(valorMaximo);
 function max(numero1,numero2){
   if(numero1>numero2)
   return numero1;
   else
     return numero2;

    // pode ser feito dessa forma tb
    //return numero1>numero2 ? numero1: numero2;
 }
 */
/* const resultado = fizzBuzz();

console.log(resultado);

function fizzBuzz(entrada){
  if(typeof entrada !== 'number')
  return 'Não é um número!'
  if(entrada % 3 === 0 && entrada % 5 === 0)
  return 'FizzBuzz';
  if(entrada % 3 === 0)
  return 'Fizz';
  if(entrada % 5 === 0)
  return 'Buzz';
    return entrada;
} */
/* verificarVelocidade()

function verificarVelocidade(velocidade){
    const velocidadeMaxima = 70;
    const pontosQuilo = 5;
    if(velocidade <=velocidadeMaxima)
    console.log("ok");
    else{
      const pontos = Math.floor(((velocidade - velocidadeMaxima)/pontosQuilo));//Math.floor serve para arredondar
      if(pontos>=12)
        console.log("Carteira suspensa!");
        else
        console.log('Pontos:', pontos);
  }
} */
/* exibirTipo(40);
function exibirTipo(limite){
  for(let i=0; i <= limite; i++){
    if ( i % 2 === 0 )
    console.log(i,"PAR")
    else
    console.log(i,"impar")
  }
} */
/* const filme = {
  titulo : 'vingadores',
  ano: 2018,
  diretor: 'Robin',
  personagem: 'Thor'
}
exibirPropriedades(filme);
function exibirPropriedades(obj){
  for( prop in obj )
  if(typeof obj[prop] === 'string')
  console.log(prop,obj[prop]);
} */
/* somar(50);
function somar(limite){
   let multiplosDe3 = 0;
   let multiplosDe5 = 0;
   for(let i =0; i <=10;i++){
      if(i % 3 === 0) 
      multiplosDe3 += i;
      if(i % 5 === 0)
      multiplosDe5 += i;
   }
   console.log(multiplosDe3+multiplosDe5);
} */
/* const array = [70,70,80];

console.log(mediaDoAluno(array));

function mediaDoAluno(notas){

  const media = calcularMedia(notas)

    if (media < 59) return 'F';
    if (media < 69) return 'D';
    if (media < 79) return 'C';
    if (media < 89) return 'B';
    return 'A';
}
function calcularMedia(array){
  let soma = 0;
  for (let valor of array){
     soma += valor;
  }
  return soma/(array.length);

} */
/* exibirAsteriscos(10)
function exibirAsteriscos(linhas){
/*   let padrao = ''
  for(let linha = 1; linha<=linhas;linha++){
    padrao += '*'
      console.log(padrao)
  } */

  /*   for(let linha = 1; linha <= linhas;linha++){
      let padrao = '';
        for(let i=0;i< linha;i++){
          padrao += '*';
        }
        console.log(padrao);
      }
} */ 
/*
exibirNumerosPrimos(15);

function exibirNumerosPrimos(limite){
  for(let numero=2;numero<= limite;numero++){
    let ehPrimo = true;
      for(let divisor =2 ; divisor<numero;divisor++){
        if(numero % divisor === 0){
          ehPrimo = false;
          break;
        }
      }
      if (ehPrimo) console.log(numero);
  }
}
*/
