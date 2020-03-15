-- Selecionar as tabelas 
SELECT * FROM usuario

SELECT id_usuario, nome_usuario, idade_usuario, email_usuario, idade_usuario, email_usuario, senha_usuario FROM usuario;

SELECT id_usuario, nome_usuario, idade_usuario, email_usuario, idade_usuario, email_usuario, senha_usuario FROM usuario WHERE id_usuario = 1;

SELECT * FROM tipo_avaliacao

SELECT * FROM avaliacao

SELECT * FROM avaliador

-- Selecionando o usuário, o avaliador e o titulo através dos id's com Foreign key utilizando INNER JOIN
SELECT ta.titulo Titulo, u.nome_usuario Usuario, ar.nome_avaliador Avaliador, nota 
  FROM avaliacao av INNER JOIN tipo_avaliacao ta ON ta.id_tipo_avaliacao = av.id_avaliacao
					INNER JOIN usuario u ON u.id_usuario = av.id_usuario
					INNER JOIN avaliador ar ON ar.id_avaliador = av.id_avaliador

