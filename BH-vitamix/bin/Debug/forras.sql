DROP DATABASE IF EXISTS tapkiegeszito;
CREATE DATABASE tapkiegeszito CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE tapkiegeszito;

CREATE TABLE kategoria (
  id int NOT NULL,
  nev varchar(32) COLLATE utf8mb4_hungarian_ci NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE termek (
  id int NOT NULL,
  nev varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL,
  kiszereles int NOT NULL,
  egysegar int NOT NULL,
  kategoriaId int NOT NULL,
  PRIMARY KEY (id),
  CONSTRAINT FK_termek_kategoria FOREIGN KEY (kategoriaId) REFERENCES kategoria (id)
);

CREATE TABLE vasarlo (
  id int NOT NULL,
  nev varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE eladas (
  id int NOT NULL AUTO_INCREMENT,
  vasarloId int NOT NULL,
  termekId int NOT NULL,
  mennyiseg int NOT NULL,
  PRIMARY KEY (id),
  CONSTRAINT FK_eladas_vasarlo FOREIGN KEY (vasarloId) REFERENCES vasarlo (id),
  CONSTRAINT FK_eladas_termek FOREIGN KEY (termekId) REFERENCES termek (id)
);

INSERT INTO kategoria VALUES
(1, 'Fehérje'),
(2, 'Vitamin'),
(3, 'Aminosav'),
(4, 'Edzés előtti'),
(5, 'Egészségmegőrző');

INSERT INTO termek VALUES
(1, 'Whey Protein', 1000, 12000, 1),
(2, 'Multivitamin', 300, 4500, 2),
(3, 'BCAA 2:1:1', 400, 6500, 3),
(4, 'Pre-Workout Extreme', 250, 8900, 4),
(5, 'Omega-3 Halolaj', 90, 3500, 5),
(6, 'Casein Protein', 1000, 13500, 1),
(7, 'C-vitamin 1000mg', 120, 2900, 2),
(8, 'Glutamin', 500, 7200, 3);

INSERT INTO vasarlo VALUES
(1, 'Kovács Adél'),
(2, 'Nagy Márk'),
(3, 'Szabó Dénes'),
(4, 'Tóth Lilla'),
(5, 'Varga Bence');

INSERT INTO eladas (vasarloId, termekId, mennyiseg) VALUES
(1, 1, 2),
(1, 2, 1),
(2, 1, 1),
(3, 3, 2),
(3, 5, 1),
(4, 4, 1),
(4, 1, 1),
(5, 2, 3),
(5, 7, 2),
(2, 8, 1),
(1, 6, 1);
