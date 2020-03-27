#language: pt-br
@pesquisaGoogle
Funcionalidade: Google Pesquisa

@pesquisaSuccess
Cenario: Pesquisa Valida
	Dado que eu esteja na pagina inicial do google
	Quando eu pesquisar por um assunto
	Entao me retorna os resultados indexados

@pesquisaUndefined
Cenario: Pesquisa vazia
	Dado que eu esteja na pagina inicial do google
	Quando eu pesquisar sem preencher o assunto
	Entao continuarei na mesma pagian aguardando um assunto