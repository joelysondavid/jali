# Passo a passo Container Docker com MSSqlServer

## Baixando Imagem Docker:
	docker pull mcr.microsoft.com/mssql/server:2019-latest

## Rodando docker com a imagem que acabou de baixar 
	docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=power!SenHa123' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
