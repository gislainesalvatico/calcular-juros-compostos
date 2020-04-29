# Desafio
Desafio para criação de uma api que retorna a taxa de juros e outra que calcule o juros composto com base na taxa de juros retornada na primeira api (API REST, ASP .NET Core, TDD, Swagger).

# API 1 - GMS.Api1TaxaJuros
Retorna a taxa de juros 0,01 (fixo no código).<br />
Responde pelo path relativo "/taxaJuros".<br />
Exemplo: /taxaJuros - Resultado esperado: 0,01 

# API 2 - GMS.Api2CalculaJuros
Possui dois endpoints:<br />

1 - Calcula Juros<br />
Retorna o valor do cálculo de juros compostos (Valor Final = Valor Inicial * (1 + juros) ^ Tempo).<br />
Responde pelo path relativo "/calculajuros/{valorInicial}/{meses}".<br />
Parâmetros:<br />
  valorInicial: decimal<br />
  meses: int<br />
Exemplo: /calculajuros/100/5 - Resultado esperado: 105,10<br />

2 - Show me the code<br />
Retorna url do github com o código do desafio.<br />
Responde pelo path relativo "/showmethecode".<br />
Exemplo: /showmethecode - Resultado esperado: https://github.com/gislainesalvatico/calcular-juros-compostos
