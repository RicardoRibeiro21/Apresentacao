-- Inserindo valores nas tabelas 
INSERT INTO usuario (nome_usuario, idade_usuario, email_usuario, senha_usuario ) 
	 VALUES ('Ricardo Ribeiro Lopes', 19, 'ricardo.sao@hotmail.com', 'ricardo')

INSERT INTO tipo_avaliacao (titulo, descricao) 
	 VALUES ('Poomsae', 'Demonstração de movimentos'),
			('Tchagui', 'Chutes basicos'),
			('Kibondon Jack', 'Posturas básicas'),
			('Matcho Kyorugui', 'Luta Combinada'),
			('Flexibilidade', 'Flexibilidade dos membros'),
			('Força', 'Força do participante'),
			('Quebramento', 'Quebramento de madeira')

INSERT INTO avaliador (nome_avaliador, funcao) 
	 VALUES ('Bruna Alencar', 'Taekwondista'),
			('João Roberto', 'Taekwondista'),
		    ('Joelmir Pin', 'Taekwondista')

INSERT INTO avaliacao (id_avaliacao,id_avaliador,id_usuario, nota)
	 VALUES (1, 1, 1, 9), (1, 2, 1, 10), (1, 3, 1, 8), -- Poomsae
			(2, 1, 1, 9), (2, 2, 1, 8), (2, 3, 1, 8), -- Tchagui			
			(3, 1, 1, 9), (3, 2, 1, 8), (3, 3, 1, 10), -- Kinbondon Jack
			(4, 1, 1, 10), (4, 2, 1, 10), (4, 3, 1, 10), -- Mactho Kyourugui
			(5, 1, 1, 6), (5, 2, 1, 5), (5, 3, 1, 6), -- Flexibilidade
			(6, 1, 1, 10), (6, 2, 1, 10), (6, 3, 1, 10), -- Força
			(7, 1, 1, 8), (7, 2, 1, 10), (7, 3, 1, 10) -- Quebramento

