OtakuVerse – Catálogo de Animes
🎯 Descrição do Projeto

OtakuVerse é uma aplicação web de catálogo de animes que permite aos usuários explorar e descobrir animes e suas plataformas de exibição.

Frontend: React + TypeScript + Tailwind CSS

Backend: ASP.NET Core Web API

Banco de dados: SQL Server com migrations e seed automatizados

Containerização: Docker Compose

O projeto foi desenvolvido com boas práticas de programação, incluindo DTOs, AutoMapper, Repository e UnitOfWork, garantindo fácil manutenção e escalabilidade.

Arquitetura

Frontend

Desenvolvido em React + TypeScript

Layout responsivo com Tailwind CSS

Axios

Funcionalidades:

Listagem de animes

Página de detalhes com descrição, imagem e plataformas

Tratamento de loading e erros

Backend

Desenvolvido em ASP.NET Core Web API

Boas práticas:

DTOs e AutoMapper

Repository e UnitOfWork

Banco de dados SQL Server via Entity Framework Core

CORS configurado para comunicação com o frontend

Banco de Dados

Tabelas: Animes e Plataformas

Seed inicial com 8 animes e 5 plataformas

Configuração automática via migrations

Containerização

Docker Compose com três containers:

db: SQL Server (porta 1433)

animeapi: Backend ASP.NET Core (porta 5000)

frontend: React + TypeScript (porta 3000)

Rede bridge mynetwork para comunicação entre containers

Variáveis de ambiente configuradas para conexão e URLs

Como Rodar o Projeto

Clonar o repositório

git clone https://github.com/Gabriel-Ferreira-DEV/ProjetoCatalogoAnime
cd ProjetoCatalogoAnime-main/ProjetoCatalogoAnime-mai (Obs.: o docker-compose.yml está nesse diretório, então é importante estar nele antes de rodar os comandos.)

Subir os containers

docker compose up -d

Containers que serão iniciados:

db → SQL Server (porta 1433)

animeapi → Backend (porta 5000)

frontend → Frontend (porta 3000)

Acessar a aplicação

Frontend: http://localhost:3000

API: http://localhost:5000/api/animes

Banco de Dados

Usuário: sa

Senha: SenhaForte123!

Banco: AnimeDb (populado automaticamente via seed)

Tecnologias Utilizadas

Frontend: React, TypeScript, Tailwind CSS

Backend: ASP.NET Core, Entity Framework Core, AutoMapper

Banco de Dados: SQL Server

Containerização: Docker, Docker Compose
