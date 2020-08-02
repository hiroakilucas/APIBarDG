# APIBarDG

#### Dia 1 sexta
- [X] Montar uma estrategia para desenvolvimento do projeto 

#### Dia 2 sabado
- [X] Ler o pdf requisitos funcionais e requisitos tecnicos 
- [X] Verificar a arquitetura Arquitetura Hexagonal
- [X] Utilizar arquitetura n camadas

- [X] Criar a api em dotnet core
- [X] Criar api com rest ou json
    - [X] Um método que receba o código da comanda e o item comprado, e registre esse item para a comanda
	- [X] Um método que irá fazer o fechamento da comanda, que consiste em: Gerar a nota fiscal que o cliente irá pagar discriminando os itens comprados, o desconto aplicado e o valor total no final.
	- [X] Um método para resetar a comanda.

##### Cardápio
   - Os itens que podem ser comprados são:
	    1. Cerveja: R$ 5,00
	    2. Conhaque: R$ 20,00
	    3. Suco: R$ 50,00
	    4. Água: R$ 70,00

###### Regras de negocio 
- [ ] Na compra de 1 cerveja e 1 suco, essa cerveja sai por 3 reais
- [ ] Se o cliente comprar 3 conhaques mais 2 cervejas, poderá pedir uma água de graça.
- [ ] Só é permitido 3 sucos por comanda.

#### Dia 3 domingo
- [ ] Ler o pdf requisitos funcionais e requisitos tecnicos 
- [ ] Unit test na api
- [ ] Adicionar a resiliência na api

#### Dia 4 segunda
- [ ] Criar as telas e consumo da api
- [X] Utilizar o nugget do swagger ui (https://localhost:44382/swagger)
o Https://github.com/domaindrivendev/Swashbuckle.AspNetCore Ou
https://github.com/domaindrivendev/Swashbuckle

#### Dia 5 terça 
- [ ] Utilizar injeção de dependencia
- [ ] Gravar os dados na localdb ou sqlite

#### Dia 6 quarta 
- [ ] Criar uma estratégia de autenticação entre a Api e a Interface

#### Dia 7 quinta
- [ ] Escrever no read-me as decisões tomadas 
- [ ] Entrega do projeto no GitHub
