
/***** TABELA PAIS *****/
CREATE TABLE tb_pais (
  id_pais int IDENTITY(1,1) PRIMARY KEY,
  nome varchar(100),
  sigla varchar(3),
  DDI varchar(3),
  status_pais varchar (1),
  data_criacao datetime,
  data_ult_alteracao datetime
  
);

/***** TABELA ESTADOS *****/
CREATE TABLE tb_estados (
  id_estado int IDENTITY(1,1) PRIMARY KEY,
  nome varchar(100),
  uf varchar(2), 
  id_pais int not null,
  status_estado varchar (1),
  data_criacao datetime,
  data_ult_alteracao datetime, 
  FOREIGN KEY (id_pais) REFERENCES tb_pais(id_pais)
);

/***** TABELA CIDADES *****/
CREATE TABLE tb_cidades (
  id_cidade int IDENTITY(1,1) PRIMARY KEY,
  nome varchar(100),
  DDD varchar(3), 
  id_estado int not null,
  status_cidade varchar (1),
  data_criacao datetime,
  data_ult_alteracao datetime,
  FOREIGN KEY (id_estado) REFERENCES tb_estados(id_estado)
);

/***** TABELA CONDIÇÃO DE PAGAMENTO *****/
CREATE TABLE tb_condicao_pagamento (
  id_condicao int PRIMARY KEY,
  condicao varchar(30) NOT NULL,
  parcelas int NOT NULL,
  taxa decimal(10,2) NOT NULL,
  multa decimal(10,2) NOT NULL,
  desconto decimal(10,2) NOT NULL,
  status_condicao varchar(1),
  data_criacao datetime,
  data_ult_alteracao datetime
);

/***** TABELA CLIENTES *****/
CREATE TABLE tb_clientes (
  id_cliente int IDENTITY(1,1) PRIMARY KEY,
  status_cliente varchar(1),
  nome varchar(50),
  sexo varchar(1),
  apelido varchar(50),
  rg varchar (30),
  cpf varchar (20) Unique,
  email varchar(200),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  id_cidade int not null,
  id_condicao_pagamento int,
  data_nasc datetime,
  data_criacao datetime,
  tipo_cliente nvarchar (1),
  data_ult_alteracao datetime,
  FOREIGN KEY (id_cidade) REFERENCES tb_cidades(id_cidade), 
  FOREIGN KEY (id_condicao_pagamento) REFERENCES tb_condicao_pagamento(id_condicao)
);

/***** TABELA FORNECEDORES *****/
CREATE TABLE tb_fornecedores (
  id_fornecedor int IDENTITY(1,1) PRIMARY KEY,
  status_fornecedor varchar(1),
  nome_fantasia varchar(100),
  razao_social varchar(100),
  data_fundacao datetime,
  insc_municipal varchar(50),
  insc_estadual varchar(50),
  rg varchar (30),
  cnpj varchar (100),
  email varchar(200),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  tipo_fornecedor varchar(1),
  data_criacao datetime,
  id_condicao_pagamento int,
  data_ult_alteracao datetime,
  id_cidade int not null,
  FOREIGN KEY (id_cidade) REFERENCES tb_cidades(id_cidade),
  FOREIGN KEY (id_condicao_pagamento) REFERENCES tb_condicao_pagamento(id_condicao) 
);

/***** TABELA CARGOS *****/
CREATE TABLE  tb_cargos (
  id_cargo int IDENTITY(1,1) PRIMARY KEY,
  status_cargo varchar(1),
  cargo varchar(100),
  data_criacao datetime,
  data_ult_alteracao datetime
)

/***** TABELA MARCAS *****/
CREATE TABLE  tb_marcas (
  id_marca int IDENTITY(1,1) PRIMARY KEY,
  marca varchar(255),
  descricao varchar(255),
  data_criacao datetime,
  data_ult_alteracao datetime
)
/***** TABELA FUNCIONARIOS *****/

CREATE TABLE tb_funcionarios (
  id_funcionario int IDENTITY(1,1) PRIMARY KEY, 
  status_funcionario varchar(1),
  nome varchar(100),
  apelido varchar(100) UNIQUE,
  sexo varchar(1),
  rg varchar (30),
  cpf varchar (20),
  email varchar(200) UNIQUE,
  senha varchar(150),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  data_nasc datetime,
  data_criacao datetime,
  data_ult_alteracao datetime,
  id_cargo int not null,
  id_cidade int not null,
  FOREIGN KEY (id_cidade) REFERENCES tb_cidades(id_cidade),
  FOREIGN KEY (id_cargo) REFERENCES tb_cargos(id_cargo)
);

/***** TABELA FORMA DE PAGAMENTO *****/
CREATE TABLE tb_forma_pagamento(
  id_forma int IDENTITY(1,1) PRIMARY KEY,
  status_forma varchar (1),
  forma varchar(50) not null,
  data_criacao datetime,
  data_ult_alteracao datetime
);

create table tb_parcelas(
  id_condicao int not null,
  id_forma int not null,
  num_parcela int not null,
  dias_totais int not null,
  porcentagem decimal(5,2),
  data_criacao datetime,
  data_ult_alteracao datetime,
  primary key (id_condicao, num_parcela, id_forma),
  FOREIGN KEY (id_forma) REFERENCES tb_forma_pagamento(id_forma),
  FOREIGN KEY (id_condicao) REFERENCES tb_condicao_pagamento(id_condicao) ON DELETE CASCADE
);
CREATE TABLE tb_contas_receber(
  id_receber int IDENTITY(1,1) PRIMARY KEY,
  id_forma int,
  situacao varchar(10),
  data_criacao datetime not null
);

CREATE TABLE tb_receber_parcelas(
  id_receber int not null,
  num_parcela int not null,
  valor decimal,
  vencimento datetime,
  PRIMARY KEY (id_receber, num_parcela),
  FOREIGN KEY (id_receber) REFERENCES tb_contas_receber(id_receber) 
);

-- Tabela de Categoria
CREATE TABLE [dbo].[tb_categorias] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
	[Foto]           VARBINARY (MAX) NULL,
    [Nome] VARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Nome] ASC)
);

-- Tabela de Produtos
CREATE TABLE tb_produtos (
  id_produto int IDENTITY(1,1) PRIMARY KEY not null,
  nome VARCHAR (150) NOT NULL,
  id_categoria INT NOT NULL,
  descricao_produto varchar(255) not null,
  unidade_medida varchar(50) not null,
  id_marca int,
  preco_custo decimal (10,2)null,
  preco_venda decimal (10,2)null,
  qtd_estoque int not null,
  status_produto varchar (1),
  foto  VARBINARY (MAX) NULL,
  data_criacao datetime,
  referencia nvarchar(10),
  data_ult_alteracao datetime,
  UNIQUE NONCLUSTERED ([Nome] ASC),
  FOREIGN KEY ([id_categoria]) REFERENCES [dbo].[tb_categorias] ([Id]),
  FOREIGN KEY ([id_marca]) REFERENCES [dbo].[tb_marcas] ([Id_marca]),
);

-- Tabela de produtos_fornecedor 
CREATE TABLE tb_produtos_fornecedores (
  id_produto_fornecedor int IDENTITY(1,1) PRIMARY KEY,
  id_produto int not null,
  id_fornecedor int not null,
  codigo_produto_fornecedor varchar(100) not null,
  data_criacao datetime,
  data_ult_alteracao datetime,
  FOREIGN KEY (id_produto) REFERENCES tb_produtos(id_produto),
  FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id_fornecedor)
);

CREATE TABLE tb_compras(
  num_nfc int not null,
  modelo_nfc int not null,
  serie_nfc int not null,
  id_fornecedor int not null,
  id_condicao int not null,
  valor_total decimal not null,
  valor_frete decimal not null,
  valor_seguro decimal not null,
  valor_outras_despesas decimal not null,
  data_chegada datetime not null,
  data_emissao datetime not null,
  data_cancelamento datetime,
  data_criacao datetime,
  PRIMARY KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor),
  FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id_fornecedor)
);

CREATE TABLE tb_itens_compras(
  num_nfc int not null,
  modelo_nfc int not null,
  serie_nfc int not null,
  id_fornecedor int not null,
  id_produto int not null,
  qtd_produto int not null,
  preco_custo decimal (10,2) not null,
  total_custo decimal (10,2) not null,
  percentual_compra decimal (10,2) not null,
  desconto decimal (10,2) null,
  media_ponderada decimal (10,2) not null,
  data_criacao datetime,
  PRIMARY KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor, id_produto), -- Mudança aqui quando colocar XML
  FOREIGN KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor) REFERENCES tb_compras (num_nfc, modelo_nfc, serie_nfc, id_fornecedor),
  FOREIGN KEY (id_produto) REFERENCES tb_produtos (id_produto), --id_produto_fornecedor e tb_produto_fornecedor
  FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id_fornecedor)-- Mudança aqui quando colocar XML
);
CREATE TABLE tb_contas_pagar(
  num_nfc int not null,
  modelo_nfc int not null,
  serie_nfc int not null,
  num_parcela int not null,
  id_fornecedor int not null,
  id_condicao int not null,
  valor decimal(10,2) not null,
  situacao varchar(10) not null,
  data_baixa datetime,
  data_vencimento datetime not null,
  data_criacao datetime not null,
  data_ult_alteracao datetime not null,
  PRIMARY KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor, num_parcela),
  FOREIGN KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor) REFERENCES tb_compras (num_nfc, modelo_nfc, serie_nfc, id_fornecedor),
  FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id_fornecedor),
  FOREIGN KEY (id_condicao) REFERENCES tb_condicao_pagamento (id_condicao)
)
-- Tabela de Laboratorio
CREATE TABLE tb_laboratorio (
  id_laboratorio int IDENTITY(1,1) PRIMARY KEY not null,
  nome VARCHAR(150),
  data_criacao datetime null,
  data_ult_alteracao datetime null,
  );
  -- Tabela de Doutores
CREATE TABLE tb_doutores (
  id_doutor int IDENTITY(1,1) PRIMARY KEY not null,
  nome VARCHAR(150),
  data_criacao datetime null,
  data_ult_alteracao datetime null,
  );
-- Tabela de eceitas
CREATE TABLE tb_Receitas (
  id_receita int IDENTITY(1,1) PRIMARY KEY not null,
  id_cliente int not null,
  id_laboratorio int not null,
  id_doutor int not null,
  data_recebimento datetime null,
  data_cadastro datetime null,
  data_ultima_alteracao datetime null,
  od_esf_longe DECIMAL(10,2) null,
  od_cil_longe DECIMAL(10,2) null,
  od_eixo_longe DECIMAL(10,2) null,
  od_dnp_longe DECIMAL(10,2) null,
  od_adicao_longe DECIMAL(10,2) null,
  od_altura_longe DECIMAL(10,2) null,
  ed_esf_longe DECIMAL(10,2) null,
  ed_cil_longe DECIMAL(10,2) null,
  ed_eixo_longe DECIMAL(10,2) null,
  ed_dnp_longe DECIMAL(10,2) null,
  ed_edadicao_longe DECIMAL(10,2) null,
  ed_altura_longe DECIMAL(10,2) null, 
  od_esf_perto DECIMAL(10,2) null,
  od_cil_perto DECIMAL(10,2) null,
  od_eixo_perto DECIMAL(10,2) null,
  od_dnp_perto DECIMAL(10,2) null,
  oe_esf_perto DECIMAL(10,2) null,
  oe_cil_perto DECIMAL(10,2) null,
  oe_eixo_perto DECIMAL(10,2) null,
  oe_dnp_perto DECIMAL(10,2) null,
  FOREIGN KEY ([id_laboratorio]) REFERENCES [dbo].[tb_laboratorio] ([id_laboratorio]),
  FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[tb_clientes] ([id_cliente]),
  FOREIGN KEY ([id_doutor]) REFERENCES [dbo].[tb_doutores] ([id_doutor]),
);
  -- Tabela de Clientes_Receitas
CREATE TABLE tb_clientes_receitas (
  id_clientes_receitas int IDENTITY(1,1) PRIMARY KEY not null,
  id_receita int not null,
  id_cliente int not null,
  data_criacao datetime null,
  data_ult_alteracao datetime null,
  FOREIGN KEY ([id_receita]) REFERENCES [dbo].[tb_receitas] ([id_receita])ON DELETE CASCADE,
  FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[tb_clientes] ([id_cliente])
);

/***** TABELA SERVICOS *****/
CREATE TABLE tb_servicos (
  id_servico INT IDENTITY(1,1) PRIMARY KEY,
  descricao VARCHAR(100) NOT NULL,
  status_servico VARCHAR(1) NOT NULL,
  data_criacao DATETIME NOT NULL,
  data_ult_alteracao DATETIME NOT NULL
);

-- Criação da tabela MenuOpcoes
CREATE TABLE [dbo].[tb_MenuOpcoes]
(
	[Id_menu] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(100) NOT NULL, 
    [Descricao] VARCHAR(255) NOT NULL, 
    [Nivel] TINYINT NOT NULL
);
-- Criação da tabela PermissaoMenu como tabela intermediária
CREATE TABLE [dbo].[tb_PermissaoMenu] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [FuncionarioId]      INT            NOT NULL,
    [MenuOpcaoId]    INT            NOT NULL,
    [PodeAdicionar]  BIT            NOT NULL,
    [PodeAlterar]    BIT            NOT NULL,
    [PodeExcluir]    BIT            NOT NULL,
    [PodeConsultar]  BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PermissaoMenu_Funcionarios_FuncionarioId] FOREIGN KEY ([FuncionarioId]) REFERENCES [tb_funcionarios]([Id_funcionario]),
    CONSTRAINT [FK_PermissaoMenu_MenuOpcoes_MenuOpcaoId] FOREIGN KEY ([MenuOpcaoId]) REFERENCES [tb_MenuOpcoes]([Id_menu])
);

-------------- TRIGGERS ---------------------------


-- Trigger para tb_condicao_pagamento
CREATE TRIGGER trg_NoNegativeValues_tb_condicao_pagamento
ON tb_condicao_pagamento
FOR INSERT, UPDATE
AS
BEGIN
    -- Verificar valores negativos
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE parcelas < 0
           OR taxa < 0
           OR multa < 0
           OR desconto < 0
    )
    BEGIN
        -- Lança um erro
        RAISERROR ('Não é permitido inserir ou atualizar com valores negativos.', 16, 1);
        -- ROLLBACK TRANSACTION; -- Não necessário, o erro interrompe a operação
    END
END;
GO

-- Trigger para tb_parcelas
CREATE TRIGGER trg_NoNegativeValues_tb_parcelas
ON tb_parcelas
FOR INSERT, UPDATE
AS
BEGIN
    -- Verificar valores negativos
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE dias_totais < 0
           OR porcentagem < 0
    )
    BEGIN
        -- Lança um erro
        RAISERROR ('Não é permitido inserir ou atualizar com valores negativos.', 16, 1);
        -- ROLLBACK TRANSACTION; -- Não necessário, o erro interrompe a operação
    END
END;
GO


------------------------------------------- EM TESTES -- TESTES
-- Cria um orçamento  uma lista de itens ou produtos e essa lista coloca na lista de produtos da OS, 
-- com o orçamento realizado  pode-se realizar uma venda futura levando para o form de vendas.
-- tb_clientes: Armazena informações dos clientes.
-- tb_produtos: Armazena informações dos produtos.
-- tb_servicos: Armazena informações dos serviços.
-- tb_ProdutosServicos: Tabela associativa para produtos e serviços, diferenciando-os pelo campo tipo.
-- tb_Ordem_Servico: Armazena informações sobre as ordens de serviço.
-- tb_Itens_Os: Tabela associativa que armazena os itens (produtos/serviços) incluídos em cada ordem de serviço.

/***** TABELA PRODUTOSSERVICOS *****/
CREATE TABLE tb_ProdutosServicos (
  id_produto_servico INT IDENTITY(1,1) PRIMARY KEY,
  descricao VARCHAR(255) NOT NULL,
  tipo CHAR(1) NOT NULL, -- 'P' para Produto, 'S' para Serviço
  id_produto INT NULL,
  id_servico INT NULL,
  FOREIGN KEY (id_produto) REFERENCES tb_produtos(id_produto),
  FOREIGN KEY (id_servico) REFERENCES tb_servicos(id_servico)
);

/***** TABELA ORDEM SERVICO *****/ 
CREATE TABLE tb_Ordem_Servico (
  id_ordem INT IDENTITY(1,1) PRIMARY KEY,
  id_cliente INT NOT NULL,
  status_ordem VARCHAR(1) NOT NULL,
  data_entrega DATETIME NOT NULL,
  data_criacao DATETIME NOT NULL,
  data_ult_alteracao DATETIME NOT NULL,
  FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id_cliente)
);

/***** TABELA ITENS ORDEM SERVICOS *****/ 
CREATE TABLE tb_Itens_Os (
  id_itens_os INT IDENTITY(1,1) PRIMARY KEY,
  id_ordem INT NOT NULL,
  id_produto_servico INT NOT NULL,
  quantidade DECIMAL(10,2) NOT NULL,
  valor DECIMAL(10,2) NOT NULL,
  subtotal DECIMAL(10,2),
  desconto DECIMAL(10,2) NULL,
  data_criacao DATETIME NOT NULL,
  data_ult_alteracao DATETIME NOT NULL,
  FOREIGN KEY (id_ordem) REFERENCES tb_Ordem_Servico(id_ordem) ON DELETE CASCADE,
  FOREIGN KEY (id_produto_servico) REFERENCES tb_ProdutosServicos(id_produto_servico)
);

-------------------------------------------------------
CREATE TABLE tb_vendas (
  num_nfv INT NOT NULL,
  modelo_nfv INT NOT NULL,
  serie_nfv INT NOT NULL,
  id_cliente INT NOT NULL,
  id_condicao INT NOT NULL,
  valor_total DECIMAL(10,2) NOT NULL,
  valor_frete DECIMAL(10,2) NOT NULL,
  valor_seguro DECIMAL(10,2) NOT NULL,
  valor_outras_despesas DECIMAL(10,2) NOT NULL,
  data_saida DATETIME NOT NULL,
  data_emissao DATETIME NOT NULL,
  data_cancelamento DATETIME,
  data_criacao DATETIME,
  PRIMARY KEY (num_nfv, modelo_nfv, serie_nfv, id_cliente),
  FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id_cliente)
);
CREATE TABLE tb_itens_vendas (
  num_nfv INT NOT NULL,
  modelo_nfv INT NOT NULL,
  serie_nfv INT NOT NULL,
  id_cliente INT NOT NULL,
  id_item INT NOT NULL,
  tipo_item VARCHAR(1) NOT NULL, -- 'P' para produto, 'S' para serviço
  qtd_item INT NOT NULL, -- Para serviços, pode ser 1
  preco_unitario DECIMAL(10,2) NOT NULL,
  total_item DECIMAL(10,2) NOT NULL,
  desconto DECIMAL(10,2),
  data_criacao DATETIME,
  PRIMARY KEY (num_nfv, modelo_nfv, serie_nfv, id_cliente, id_item, tipo_item),
  FOREIGN KEY (num_nfv, modelo_nfv, serie_nfv, id_cliente) REFERENCES tb_vendas(num_nfv, modelo_nfv, serie_nfv, id_cliente),
  FOREIGN KEY (id_item) REFERENCES tb_produtos(id_produto) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (id_item) REFERENCES tb_servicos(id_servico) ON DELETE CASCADE ON UPDATE CASCADE
);


// ALTERAR Para ele verificar se é tipo Produto ou serviço e buscar produto ou serviço de acordo nos metodos etc.



