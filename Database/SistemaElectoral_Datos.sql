-- ============================================================
--   SISTEMA ELECTORAL ESTUDIANTIL
--   Script de Datos Iniciales
--   Ejecutar DESPUES de SistemaElectoral_DB.sql
--   No borra nada, solo inserta datos necesarios
-- ============================================================

USE SistemaElectoral;
GO

-- ============================================================
-- PADRONES (1ro a 3ro con A y B, 4to a 6to con tecnicos)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Padrones WHERE Curso = '1ro Secundaria' AND Seccion = 'A')
INSERT INTO Padrones (Curso, Seccion, Anio) VALUES
('1ro Secundaria', 'A', 2026),
('1ro Secundaria', 'B', 2026),
('2do Secundaria', 'A', 2026),
('2do Secundaria', 'B', 2026),
('3ro Secundaria', 'A', 2026),
('3ro Secundaria', 'B', 2026),
('4to Secundaria', 'Gestion', 2026),
('4to Secundaria', 'Electronica', 2026),
('4to Secundaria', 'Informatica', 2026),
('4to Secundaria', 'Academico', 2026),
('5to Secundaria', 'Gestion', 2026),
('5to Secundaria', 'Electronica', 2026),
('5to Secundaria', 'Informatica', 2026),
('5to Secundaria', 'Academico', 2026),
('6to Secundaria', 'Gestion', 2026),
('6to Secundaria', 'Electronica', 2026),
('6to Secundaria', 'Informatica', 2026),
('6to Secundaria', 'Academico', 2026);
GO

-- ============================================================
-- USUARIO DIRECTOR
-- Matricula: DIR-0001 | Contrasena: Admin123
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Matricula = 'DIR-0001')
INSERT INTO Usuarios (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID)
VALUES (
    'DIR-0001', 'Director', 'Sistema',
    '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2',
    (SELECT RolID FROM Roles WHERE NombreRol = 'Director'),
    NULL
);
GO

-- ============================================================
-- ADMINISTRADORES DE PLANCHA
-- Contrasena de todos: Admin123
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Matricula = 'ADM-6INF')
INSERT INTO Usuarios (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID)
VALUES 
('ADM-6INF', 'Admin', '6to Inf',  '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 2, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Informatica')),
('ADM-6ELE', 'Admin', '6to Elec', '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 2, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Electronica')),
('ADM-4ELE', 'Admin', '4to Elec', '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 2, (SELECT PadronID FROM Padrones WHERE Curso = '4to Secundaria' AND Seccion = 'Electronica')),
('ADM-5INF', 'Admin', '5to Inf',  '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 2, (SELECT PadronID FROM Padrones WHERE Curso = '5to Secundaria' AND Seccion = 'Informatica'));
GO

-- ============================================================
-- PLANCHAS ELECTORALES
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Planchas WHERE NombrePlancha = 'Plancha 6to Inf')
INSERT INTO Planchas (NombrePlancha, Lema, AdministradorID)
VALUES 
('Plancha 6to Inf',  'Por un mejor futuro',  (SELECT UsuarioID FROM Usuarios WHERE Matricula = 'ADM-6INF')),
('Plancha 6to Elec', 'Juntos somos mas',     (SELECT UsuarioID FROM Usuarios WHERE Matricula = 'ADM-6ELE')),
('Plancha 4to Elec', 'El cambio comienza',   (SELECT UsuarioID FROM Usuarios WHERE Matricula = 'ADM-4ELE')),
('Plancha 5to Inf',  'Unidos por el cambio', (SELECT UsuarioID FROM Usuarios WHERE Matricula = 'ADM-5INF'));
GO

-- ============================================================
-- CANDIDATOS PLANCHA 4to Elec
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Matricula = '2026-4E01')
BEGIN
    INSERT INTO Usuarios (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID) VALUES
    ('2026-4E01', 'Carlos',  'Mendez',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '4to Secundaria' AND Seccion = 'Electronica')),
    ('2026-4E02', 'Maria',   'Santos',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '4to Secundaria' AND Seccion = 'Electronica')),
    ('2026-4E03', 'Luis',    'Ramirez',  '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '4to Secundaria' AND Seccion = 'Electronica')),
    ('2026-4E04', 'Ana',     'Torres',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '4to Secundaria' AND Seccion = 'Electronica')),
    ('2026-4E05', 'Pedro',   'Gomez',    '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '4to Secundaria' AND Seccion = 'Electronica'));

    INSERT INTO Candidatos (PlanchaID, PuestoID, UsuarioID) VALUES
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 4to Elec'), 1, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-4E01')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 4to Elec'), 2, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-4E02')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 4to Elec'), 3, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-4E03')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 4to Elec'), 4, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-4E04')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 4to Elec'), 5, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-4E05'));
END
GO

-- ============================================================
-- CANDIDATOS PLANCHA 5to Inf
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Matricula = '2026-5I01')
BEGIN
    INSERT INTO Usuarios (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID) VALUES
    ('2026-5I01', 'Brithany', 'Hidalgo',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '5to Secundaria' AND Seccion = 'Informatica')),
    ('2026-5I02', 'Genesis',  'Almanzar',  '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '5to Secundaria' AND Seccion = 'Informatica')),
    ('2026-5I03', 'Badir',    'Perez',     '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '5to Secundaria' AND Seccion = 'Informatica')),
    ('2026-5I04', 'Felix',    'Alcantara', '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '5to Secundaria' AND Seccion = 'Informatica')),
    ('2026-5I05', 'Ramfis',   'Velazquez', '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '5to Secundaria' AND Seccion = 'Informatica'));

    INSERT INTO Candidatos (PlanchaID, PuestoID, UsuarioID) VALUES
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 5to Inf'), 1, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-5I01')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 5to Inf'), 2, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-5I02')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 5to Inf'), 3, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-5I03')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 5to Inf'), 4, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-5I04')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 5to Inf'), 5, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-5I05'));
END
GO

-- ============================================================
-- CANDIDATOS PLANCHA 6to Inf
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Matricula = '2026-6I01')
BEGIN
    INSERT INTO Usuarios (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID) VALUES
    ('2026-6I01', 'Roonie',  'Castro',    '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Informatica')),
    ('2026-6I02', 'Fabian',  'Lorenzo',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Informatica')),
    ('2026-6I03', 'Carlos',  'Tevez',     '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Informatica')),
    ('2026-6I04', 'Gabriel', 'Francisco', '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Informatica')),
    ('2026-6I05', 'Victor',  'Recio',     '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Informatica'));

    INSERT INTO Candidatos (PlanchaID, PuestoID, UsuarioID) VALUES
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Inf'), 1, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6I01')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Inf'), 2, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6I02')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Inf'), 3, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6I03')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Inf'), 4, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6I04')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Inf'), 5, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6I05'));
END
GO

-- ============================================================
-- CANDIDATOS PLANCHA 6to Elec
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Matricula = '2026-6E01')
BEGIN
    INSERT INTO Usuarios (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID) VALUES
    ('2026-6E01', 'Nissi',    'Ramirez',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Electronica')),
    ('2026-6E02', 'Valeria',  'Peralta',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Electronica')),
    ('2026-6E03', 'Yamfris',  'Morillo',   '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Electronica')),
    ('2026-6E04', 'Misael',   'Alcantara', '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Electronica')),
    ('2026-6E05', 'Santiago', 'Reyes',     '3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2', 3, (SELECT PadronID FROM Padrones WHERE Curso = '6to Secundaria' AND Seccion = 'Electronica'));

    INSERT INTO Candidatos (PlanchaID, PuestoID, UsuarioID) VALUES
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Elec'), 1, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6E01')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Elec'), 2, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6E02')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Elec'), 3, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6E03')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Elec'), 4, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6E04')),
    ((SELECT PlanchaID FROM Planchas WHERE NombrePlancha = 'Plancha 6to Elec'), 5, (SELECT UsuarioID FROM Usuarios WHERE Matricula = '2026-6E05'));
END
GO

-- ============================================================
-- PERIODO DE VOTACION
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM PeriodosVotacion WHERE Descripcion = 'Elecciones Estudiantiles 2026')
INSERT INTO PeriodosVotacion (Descripcion, FechaInicio, FechaFin, Activo, CreadoPor)
VALUES (
    'Elecciones Estudiantiles 2026',
    GETDATE(),
    DATEADD(HOUR, 8, GETDATE()),
    0,
    (SELECT UsuarioID FROM Usuarios WHERE Matricula = 'DIR-0001')
);
GO

PRINT '======================================================';
PRINT ' Datos iniciales insertados correctamente.';
PRINT ' Director: DIR-0001 / Contrasena: Admin123';
PRINT ' Admins: ADM-6INF, ADM-6ELE, ADM-4ELE, ADM-5INF';
PRINT ' Contrasena de todos: Admin123';
PRINT '======================================================';
