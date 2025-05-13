CREATE DATABASE bd_concursos;
USE bd_concursos;

CREATE TABLE candidato(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(45),
cpf VARCHAR(45),
data_nascimento DATE
);

CREATE TABLE cargo(
id INT PRIMARY KEY AUTO_INCREMENT,
nome_cargo VARCHAR(45),
edital VARCHAR(60),
salario_base DECIMAL
);

CREATE TABLE inscricao(
id INT PRIMARY KEY AUTO_INCREMENT,
numero_insc VARCHAR(45),
data_inscricao DATE,
nota_conh_gerais DECIMAL,
nota_conh_especificos DECIMAL,
candidato_id_fk INT NOT NULL,
FOREIGN KEY (candidato_id_fk) REFERENCES candidato (id),
cargo_id_fk INT NOT NULL,
FOREIGN KEY (cargo_id_fk) REFERENCES cargo (id)
);

