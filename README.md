# Desafio
Desafio para criação de uma api que retorna a taxa de juros e outra que calcule o juros composto com base na taxa de juros retornada na primeira api (API REST, .NET Core, TDD, Swagger).

# API 1 - GMS.Api1TaxaJuros
Retorna a taxa de juros 0,01 (fixo no código).
Responde pelo path relativo "/taxaJuros".
Exemplo: /taxaJuros - Resultado esperado: 0,01 

# API 2 - GMS.Api2CalculaJuros
Possui dois endpoints:

#1) Calcula Juros 
Retorna o valor do cálculo de juros compostos (Valor Final = Valor Inicial * (1 + juros) ^ Tempo).
Responde pelo path relativo "/calculajuros/{valorInicial}/{meses}" .
Parâmetros:
  valorInicial: decimal
  meses: int
Exemplo: /calculajuros/100/5 - Resultado esperado: 105,10 

#2) Show me the code 
Retorna url do github com o código do desafio.
Responde pelo path relativo "/showmethecode".
Exemplo: /showmethecode - Resultado esperado: https://github.com/gislainesalvatico/calcular-juros-compostos
