CREATE TABLE [Usuarios] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [nome] nvarchar(255) NOT NULL,
  [email] nvarchar(255) UNIQUE NOT NULL,
  [data_nascimento] nvarchar(255) NOT NULL,
  [telefone] nvarchar(255) NOT NULL,
  [id_pessoa_fisica] int,
  [id_tipo_pessoa] int NOT NULL,
  [id_endereco] int NOT NULL
)
GO

CREATE TABLE [PessoaFisica] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [cpf] nvarchar(255) UNIQUE NOT NULL,
  [rg] nvarchar(255) UNIQUE NOT NULL
)
GO

CREATE TABLE [TipoUsuario] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [name] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [Enderecos] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [cep] nvarchar(255) NOT NULL,
  [endereco] nvarchar(255) NOT NULL,
  [bairro] nvarchar(255) NOT NULL,
  [cidade] nvarchar(255) NOT NULL,
  [estado] nvarchar(255) NOT NULL,
  [uf] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [Fornecedores] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [nome_fantasia] nvarchar(255) NOT NULL,
  [email] nvarchar(255) UNIQUE NOT NULL,
  [telefone] nvarchar(255) NOT NULL,
  [id_pessoa_juridica] int,
  [id_endereco] int NOT NULL
)
GO

CREATE TABLE [PessoaJurifica] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [cnpj] nvarchar(255) UNIQUE NOT NULL,
  [inscricao_estadual] nvarchar(255) NOT NULL,
  [razao_social] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [Produtos] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [nome] nvarchar(255) NOT NULL,
  [descricao] nvarchar(255),
  [tamanho] float NOT NULL,
  [tipo_manga] nvarchar(255),
  [tipo_decote] nvarchar(255),
  [preco] decimal(18, 2) NOT NULL,
  [imagem] nvarchar(255),
  [id_fornecedor] int NOT NULL
)
GO

CREATE TABLE [Cores] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [name] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [ProdutosCores] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [id_produto] int NOT NULL,
  [id_cor] int NOT NULL
)
GO

CREATE TABLE [Locacoes] (
  [id] int PRIMARY KEY NOT NULL IDENTITY(1, 1)
)
GO

ALTER TABLE [Usuarios] ADD FOREIGN KEY ([id_pessoa_fisica]) REFERENCES [PessoaFisica] ([id])
GO

ALTER TABLE [Usuarios] ADD FOREIGN KEY ([id_tipo_pessoa]) REFERENCES [TipoUsuario] ([id])
GO

ALTER TABLE [Usuarios] ADD FOREIGN KEY ([id_endereco]) REFERENCES [Enderecos] ([id])
GO

ALTER TABLE [Fornecedores] ADD FOREIGN KEY ([id_pessoa_juridica]) REFERENCES [PessoaJurifica] ([id])
GO

ALTER TABLE [Fornecedores] ADD FOREIGN KEY ([id_endereco]) REFERENCES [Enderecos] ([id])
GO

ALTER TABLE [Produtos] ADD FOREIGN KEY ([id_fornecedor]) REFERENCES [Fornecedores] ([id])
GO

ALTER TABLE [ProdutosCores] ADD FOREIGN KEY ([id_produto]) REFERENCES [Produtos] ([id])
GO

ALTER TABLE [ProdutosCores] ADD FOREIGN KEY ([id_cor]) REFERENCES [Cores] ([id])
GO
