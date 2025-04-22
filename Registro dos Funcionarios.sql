USE BibliotecaDB
INSERT INTO Funcionarios (NomeUsuario, SenhaHash, NomeCompleto, Cargo, Email, DataCadastro, UltimoLogin, Ativo)
VALUES
('jcarvalho', HASHBYTES('SHA2_256', 'Senha123!'), 'João Carvalho', 'Analista de Sistemas', 'joao.carvalho@empresa.com', GETDATE(), NULL, 1),
('mpereira', HASHBYTES('SHA2_256', 'Senha123!'), 'Maria Pereira', 'Gerente de Projetos', 'maria.pereira@empresa.com', GETDATE(), NULL, 0),
('rlima', HASHBYTES('SHA2_256', 'Senha123!'), 'Roberto Lima', 'Desenvolvedor', 'roberto.lima@empresa.com', GETDATE(), NULL, 1),
('asouza', HASHBYTES('SHA2_256', 'Senha123!'), 'Ana Souza', 'Designer UX/UI', 'ana.souza@empresa.com', GETDATE(), NULL, 1),
('fmartins', HASHBYTES('SHA2_256', 'Senha123!'), 'Fabio Martins', 'Suporte Técnico', 'fabio.martins@empresa.com', GETDATE(), NULL, 1),
('lferreira', HASHBYTES('SHA2_256', 'Senha123!'), 'Laura Ferreira', 'Recursos Humanos', 'laura.ferreira@empresa.com', GETDATE(), NULL, 1),
('cgomes', HASHBYTES('SHA2_256', 'Senha123!'), 'Carlos Gomes', 'Diretor Financeiro', 'carlos.gomes@empresa.com', GETDATE(), NULL, 1),
('poliveira', HASHBYTES('SHA2_256', 'Senha123!'), 'Patricia Oliveira', 'Marketing', 'patricia.oliveira@empresa.com', GETDATE(), NULL, 0),
('jrodrigues', HASHBYTES('SHA2_256', 'Senha123!'), 'José Rodrigues', 'Vendas', 'jose.rodrigues@empresa.com', GETDATE(), NULL, 0),
('msilva', HASHBYTES('SHA2_256', 'Senha123!'), 'Mariana Silva', 'Desenvolvedora Frontend', 'mariana.silva@empresa.com', GETDATE(), NULL, 1)

