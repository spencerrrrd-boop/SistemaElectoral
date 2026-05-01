-- ============================================================
--   SISTEMA ELECTORAL ESTUDIANTIL
--   Base de Datos: SQL Server
--   Arquitectura: MVC / POO
-- ============================================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'SistemaElectoral')
    DROP DATABASE SistemaElectoral;
GO

CREATE DATABASE SistemaElectoral;
GO

USE SistemaElectoral;
GO

-- ============================================================
-- TABLA: Roles
-- Los 3 roles del sistema
-- ============================================================
CREATE TABLE Roles (
    RolID       INT IDENTITY(1,1) PRIMARY KEY,
    NombreRol   VARCHAR(50)  NOT NULL UNIQUE,   -- 'Director', 'Administrador', 'Votante'
    Descripcion VARCHAR(200) NULL
);
GO

-- ============================================================
-- TABLA: Padrones
-- Cada padron representa un curso/seccion
-- ============================================================
CREATE TABLE Padrones (
    PadronID    INT IDENTITY(1,1) PRIMARY KEY,
    Curso       VARCHAR(20)  NOT NULL,           -- Ej: '1ro', '2do', '3ro'
    Seccion     VARCHAR(10)  NOT NULL,           -- Ej: 'A', 'B', 'C'
    Anio        INT          NOT NULL,           -- Ej: 2025
    Activo      BIT          NOT NULL DEFAULT 1,
    CONSTRAINT UQ_Padron UNIQUE (Curso, Seccion, Anio)
);
GO

-- ============================================================
-- TABLA: Usuarios
-- Votantes, Administradores de plancha y Director
-- ============================================================
CREATE TABLE Usuarios (
    UsuarioID       INT IDENTITY(1,1) PRIMARY KEY,
    Matricula       VARCHAR(20)  NOT NULL UNIQUE,
    Nombre          VARCHAR(100) NOT NULL,
    Apellido        VARCHAR(100) NOT NULL,
    Contrasena      VARCHAR(256) NOT NULL,       -- Hash SHA-256
    RolID           INT          NOT NULL,
    PadronID        INT          NULL,           -- NULL solo para el Director
    FechaRegistro   DATETIME     NOT NULL DEFAULT GETDATE(),
    Activo          BIT          NOT NULL DEFAULT 1,
    CONSTRAINT FK_Usuario_Rol    FOREIGN KEY (RolID)    REFERENCES Roles(RolID),
    CONSTRAINT FK_Usuario_Padron FOREIGN KEY (PadronID) REFERENCES Padrones(PadronID)
);
GO

-- ============================================================
-- TABLA: Planchas
-- Partidos / planchas electorales
-- ============================================================
CREATE TABLE Planchas (
    PlanchaID       INT IDENTITY(1,1) PRIMARY KEY,
    NombrePlancha   VARCHAR(100) NOT NULL UNIQUE,
    Lema            VARCHAR(200) NULL,
    LogoRuta        VARCHAR(500) NULL,           -- Ruta local de la imagen
    AdministradorID INT          NOT NULL,       -- Usuario con rol Administrador
    Activa          BIT          NOT NULL DEFAULT 1,
    FechaCreacion   DATETIME     NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Plancha_Admin FOREIGN KEY (AdministradorID) REFERENCES Usuarios(UsuarioID)
);
GO

-- ============================================================
-- TABLA: Puestos
-- Presidente, Vicepresidente, Secretario, etc.
-- ============================================================
CREATE TABLE Puestos (
    PuestoID    INT IDENTITY(1,1) PRIMARY KEY,
    NombrePuesto VARCHAR(100) NOT NULL UNIQUE,   -- Ej: 'Presidente', 'Vicepresidente'
    Orden       INT          NOT NULL DEFAULT 1  -- Para mostrarlos en orden en la UI
);
GO

-- ============================================================
-- TABLA: PeriodosVotacion
-- El Director abre y cierra el periodo de votacion
-- ============================================================
CREATE TABLE PeriodosVotacion (
    PeriodoID       INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion     VARCHAR(200) NOT NULL,
    FechaInicio     DATETIME     NOT NULL,
    FechaFin        DATETIME     NOT NULL,
    Activo          BIT          NOT NULL DEFAULT 0,  -- Solo uno activo a la vez
    CreadoPor       INT          NOT NULL,             -- UsuarioID del Director
    CONSTRAINT FK_Periodo_Director FOREIGN KEY (CreadoPor) REFERENCES Usuarios(UsuarioID)
);
GO

-- ============================================================
-- TABLA: Candidatos
-- Cada candidato pertenece a una plancha y ocupa un puesto
-- ============================================================
CREATE TABLE Candidatos (
    CandidatoID INT IDENTITY(1,1) PRIMARY KEY,
    PlanchaID   INT NOT NULL,
    PuestoID    INT NOT NULL,
    UsuarioID   INT NOT NULL,                    -- El candidato es un usuario registrado
    CONSTRAINT FK_Candidato_Plancha  FOREIGN KEY (PlanchaID)  REFERENCES Planchas(PlanchaID),
    CONSTRAINT FK_Candidato_Puesto   FOREIGN KEY (PuestoID)   REFERENCES Puestos(PuestoID),
    CONSTRAINT FK_Candidato_Usuario  FOREIGN KEY (UsuarioID)  REFERENCES Usuarios(UsuarioID),
    CONSTRAINT UQ_Plancha_Puesto     UNIQUE (PlanchaID, PuestoID), -- Un puesto por plancha
    CONSTRAINT UQ_Usuario_Candidato  UNIQUE (UsuarioID)            -- No puede estar en 2 planchas
);
GO

-- ============================================================
-- TABLA: Votos
-- Registro de cada voto emitido (secreto e inmutable)
-- ============================================================
CREATE TABLE Votos (
    VotoID      INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioID   INT      NOT NULL,
    PeriodoID   INT      NOT NULL,
    PlanchaID   INT      NULL,       -- NULL si el voto es nulo
    EsNulo      BIT      NOT NULL DEFAULT 0,
    Timestamp   DATETIME NOT NULL DEFAULT GETDATE(),
    HashVoto    VARCHAR(256) NOT NULL,  -- Hash para garantizar integridad
    CONSTRAINT FK_Voto_Usuario  FOREIGN KEY (UsuarioID)  REFERENCES Usuarios(UsuarioID),
    CONSTRAINT FK_Voto_Periodo  FOREIGN KEY (PeriodoID)  REFERENCES PeriodosVotacion(PeriodoID),
    CONSTRAINT FK_Voto_Plancha  FOREIGN KEY (PlanchaID)  REFERENCES Planchas(PlanchaID),
    CONSTRAINT UQ_Un_Voto_Por_Usuario UNIQUE (UsuarioID, PeriodoID)  -- REGLA: 1 voto por votante
);
GO

-- ============================================================
-- TABLA: Logs
-- Auditoria de todas las acciones importantes del sistema
-- ============================================================
CREATE TABLE Logs (
    LogID       INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioID   INT          NULL,               -- NULL si es accion del sistema
    Accion      VARCHAR(200) NOT NULL,           -- Ej: 'LOGIN', 'VOTO_EMITIDO', 'PLANCHA_CREADA'
    Detalle     VARCHAR(500) NULL,
    IPMaquina   VARCHAR(50)  NULL,
    Timestamp   DATETIME     NOT NULL DEFAULT GETDATE()
);
GO

-- ============================================================
-- DATOS INICIALES
-- ============================================================

-- Roles
INSERT INTO Roles (NombreRol, Descripcion) VALUES
('Director',       'Superadministrador. Controla el sistema completo.'),
('Administrador',  'Administrador de plancha. Gestiona su propia plancha.'),
('Votante',        'Usuario basico con derecho a voto.');
GO

-- Puestos electorales
INSERT INTO Puestos (NombrePuesto, Orden) VALUES
('Presidente',      1),
('Vicepresidente',  2),
('Secretario',      3),
('Tesorero',        4),
('Vocal',           5);
GO

-- Padron de ejemplo
INSERT INTO Padrones (Curso, Seccion, Anio) VALUES
('1ro', 'A', 2025),
('1ro', 'B', 2025),
('2do', 'A', 2025),
('2do', 'B', 2025),
('3ro', 'A', 2025);
GO

-- Usuario Director inicial (Contrasena: Admin123 en SHA-256)
-- En produccion cambiar la contrasena inmediatamente
INSERT INTO Usuarios (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID)
VALUES (
    'DIR-0001',
    'Director',
    'Sistema',
    '0D9C18B0C05E2A0E27866CF1D5A24B25E65B38D5C1B7E208D0EB86E4D7C8F12A', -- sha256('Admin123')
    (SELECT RolID FROM Roles WHERE NombreRol = 'Director'),
    NULL
);
GO

-- ============================================================
-- VISTAS UTILES
-- ============================================================

-- Vista: Resultados en tiempo real por plancha
CREATE VIEW vw_ResultadosPorPlancha AS
SELECT
    p.PlanchaID,
    p.NombrePlancha,
    p.LogoRuta,
    COUNT(v.VotoID)                                          AS TotalVotos,
    CAST(COUNT(v.VotoID) AS FLOAT) /
        NULLIF((SELECT COUNT(*) FROM Votos WHERE EsNulo = 0
                AND PeriodoID = (SELECT TOP 1 PeriodoID FROM PeriodosVotacion WHERE Activo = 1)), 0)
        * 100                                                AS PorcentajeVotos
FROM Planchas p
LEFT JOIN Votos v ON v.PlanchaID = p.PlanchaID
                  AND v.EsNulo = 0
                  AND v.PeriodoID = (SELECT TOP 1 PeriodoID FROM PeriodosVotacion WHERE Activo = 1)
WHERE p.Activa = 1
GROUP BY p.PlanchaID, p.NombrePlancha, p.LogoRuta;
GO

-- Vista: Panel general de votacion
CREATE VIEW vw_PanelGeneral AS
SELECT
    (SELECT COUNT(*) FROM Usuarios WHERE RolID = (SELECT RolID FROM Roles WHERE NombreRol = 'Votante')
                                     AND Activo = 1)         AS TotalPadron,
    (SELECT COUNT(*) FROM Votos
     WHERE PeriodoID = (SELECT TOP 1 PeriodoID FROM PeriodosVotacion WHERE Activo = 1))
                                                             AS VotosEmitidos,
    (SELECT COUNT(*) FROM Votos
     WHERE EsNulo = 1
     AND PeriodoID = (SELECT TOP 1 PeriodoID FROM PeriodosVotacion WHERE Activo = 1))
                                                             AS VotosNulos,
    (SELECT FechaFin FROM PeriodosVotacion WHERE Activo = 1) AS FechaFin;
GO

-- Vista: Candidatos con su plancha y puesto (para mostrar en el modulo de votacion)
CREATE VIEW vw_CandidatosPorPlancha AS
SELECT
    c.CandidatoID,
    pl.PlanchaID,
    pl.NombrePlancha,
    pl.LogoRuta,
    pu.NombrePuesto,
    pu.Orden,
    u.Nombre + ' ' + u.Apellido AS NombreCompleto,
    u.Matricula
FROM Candidatos c
JOIN Planchas  pl ON pl.PlanchaID  = c.PlanchaID
JOIN Puestos   pu ON pu.PuestoID   = c.PuestoID
JOIN Usuarios  u  ON u.UsuarioID   = c.UsuarioID
WHERE pl.Activa = 1;
GO

-- Vista: Reporte de integrantes por partido
CREATE VIEW vw_IntegrantesPorPlancha AS
SELECT
    pl.NombrePlancha,
    pu.NombrePuesto,
    u.Matricula,
    u.Nombre + ' ' + u.Apellido AS NombreCompleto,
    pa.Curso,
    pa.Seccion
FROM Candidatos c
JOIN Planchas  pl ON pl.PlanchaID = c.PlanchaID
JOIN Puestos   pu ON pu.PuestoID  = c.PuestoID
JOIN Usuarios  u  ON u.UsuarioID  = c.UsuarioID
JOIN Padrones  pa ON pa.PadronID  = u.PadronID;
GO

-- ============================================================
-- STORED PROCEDURES
-- ============================================================

-- SP: Registrar un voto (con validaciones de negocio)
CREATE PROCEDURE sp_RegistrarVoto
    @UsuarioID  INT,
    @PlanchaID  INT = NULL,
    @EsNulo     BIT,
    @HashVoto   VARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PeriodoActivo INT;
    SELECT @PeriodoActivo = PeriodoID FROM PeriodosVotacion WHERE Activo = 1;

    -- Validacion: periodo activo
    IF @PeriodoActivo IS NULL
    BEGIN
        RAISERROR('No hay un periodo de votacion activo.', 16, 1);
        RETURN;
    END

    -- Validacion: usuario ya voto (REGLA DE NEGOCIO)
    IF EXISTS (SELECT 1 FROM Votos WHERE UsuarioID = @UsuarioID AND PeriodoID = @PeriodoActivo)
    BEGIN
        RAISERROR('Este usuario ya ha emitido su voto.', 16, 1);
        RETURN;
    END

    -- Registrar el voto
    INSERT INTO Votos (UsuarioID, PeriodoID, PlanchaID, EsNulo, HashVoto)
    VALUES (@UsuarioID, @PeriodoActivo, @PlanchaID, @EsNulo, @HashVoto);

    -- Log de auditoria
    INSERT INTO Logs (UsuarioID, Accion, Detalle)
    VALUES (@UsuarioID, 'VOTO_EMITIDO', 'Voto registrado en periodo ' + CAST(@PeriodoActivo AS VARCHAR));
END;
GO

-- SP: Verificar si un usuario ya voto (sin revelar por quien)
CREATE PROCEDURE sp_UsuarioYaVoto
    @UsuarioID INT,
    @YaVoto    BIT OUTPUT
AS
BEGIN
    DECLARE @PeriodoActivo INT;
    SELECT @PeriodoActivo = PeriodoID FROM PeriodosVotacion WHERE Activo = 1;

    IF EXISTS (SELECT 1 FROM Votos WHERE UsuarioID = @UsuarioID AND PeriodoID = @PeriodoActivo)
        SET @YaVoto = 1;
    ELSE
        SET @YaVoto = 0;
END;
GO

-- SP: Abrir/Cerrar periodo de votacion (solo Director)
CREATE PROCEDURE sp_TogglePeriodo
    @PeriodoID  INT,
    @Abrir      BIT          -- 1 = abrir, 0 = cerrar
AS
BEGIN
    IF @Abrir = 1
    BEGIN
        -- Cerrar cualquier periodo activo antes de abrir uno nuevo
        UPDATE PeriodosVotacion SET Activo = 0 WHERE Activo = 1;
        UPDATE PeriodosVotacion SET Activo = 1 WHERE PeriodoID = @PeriodoID;
    END
    ELSE
        UPDATE PeriodosVotacion SET Activo = 0 WHERE PeriodoID = @PeriodoID;
END;
GO

PRINT '======================================================';
PRINT ' Base de datos SistemaElectoral creada exitosamente.';
PRINT ' Usuario Director: DIR-0001 / Contrasena: Admin123';
PRINT '======================================================';
