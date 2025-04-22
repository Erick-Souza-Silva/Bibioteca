USE BibliotecaDB
GO

INSERT INTO Requisicoes (UsuarioID, LivroID, FuncionarioID, Status)
VALUES
(1, 1, 1, 'Aprovada'),
(2, 3, 2, 'Pendente'),
(3, 5, 3, 'Devolvido'),
(4, 2, 4, 'Aprovada'),
(5, 4, 5, 'Devolvido'),
(6, 7, 6, 'Pendente'),
(7, 6, 7, 'Aprovada'),
(8, 9, 8, 'Devolvido'),
(9, 8, 9, 'Aprovada'),
(10, 10, 10, 'Pendente')