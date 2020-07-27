# APIBarDG

dia 1 sexta
[x] montar uma estrategia para desenvolvimento do projeto 

dia 2 sabado
[x] ler o pdf requisitos funcionais e requisitos tecnicos 
[x] verificar a arquitetura Arquitetura Hexagonal
[x] utilizar arquitetura n camadas

[ ] criar a api em dotnet core
[ ] criar api com rest ou json
	[ ] Um método que receba o código da comanda e o item comprado, e registre esse item para a comanda
	[ ] Um método que irá fazer o fechamento da comanda, que consiste em: Gerar a nota fiscal que o cliente irá pagar discriminando os itens comprados, o desconto aplicado e o valor total no final.
	[ ] Um método para resetar a comanda.

Cardápio
	Os itens que podem ser comprados são:
	1. Cerveja: R$ 5,00
	2. Conhaque: R$ 20,00
	3. Suco: R$ 50,00
	4. Água: R$ 70,00

regras de negocio 
	[ ] Na compra de 1 cerveja e 1 suco, essa cerveja sai por 3 reais
	[ ] Se o cliente comprar 3 conhaques mais 2 cervejas, poderá pedir uma água de graça.
	[ ] Só é permitido 3 sucos por comanda.

dia 3 domingo
[ ] ler o pdf requisitos funcionais e requisitos tecnicos 
[ ] unit test na api
[ ] adicionar a resiliencia na api

dia 4 segunda
[ ] criar as telas e consumo da api
[x] Utilizar o nugget do swagger ui (https://localhost:44382/swagger)
o Https://github.com/domaindrivendev/Swashbuckle.AspNetCore Ou
https://github.com/domaindrivendev/Swashbuckle

dia 5 terça 
[ ] utilizar injeção de dependencia
[ ] gravar os dados na localdb ou sqlite

dia 6 quarta 
[ ] Criar uma estratégia de autenticação entre a Api e a Interface

dia 7 quinta
[ ] escrever no read-me as decisões tomadas 
[ ] entrega do projeto no github
