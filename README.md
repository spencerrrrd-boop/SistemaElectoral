# 🗳️ Sistema Electoral Estudiantil

Sistema de votaciones escolares desarrollado en **C# WinForms** con **SQL Server**, aplicando arquitectura **MVC** y **Programación Orientada a Objetos**.

---

## 📋 Descripción

Aplicación de escritorio para llevar a cabo votaciones escolares a nivel de colegio y/o curso. Permite gestionar planchas electorales, registrar votantes, emitir votos de forma secreta y visualizar estadísticas en tiempo real.

---

## 🚀 Tecnologías

| Tecnología | Uso |
|---|---|
| C# .NET Framework 4.8 | Lenguaje principal |
| Windows Forms (WinForms) | Interfaz gráfica |
| SQL Server (SQLEXPRESS) | Base de datos |
| Microsoft.Data.SqlClient | Conexión a BD |
| iTextSharp | Exportación a PDF |
| Git / GitHub | Control de versiones |

---

## 🏗️ Arquitectura

El proyecto sigue una arquitectura en capas **MVC adaptado a WinForms**:

```
SistemaElectoral1/
├── Models/          → Entidades del sistema (POO)
├── AccesoDatos/     → Consultas SQL (DAL)
├── LogicaNegocio/   → Reglas de negocio (BLL)
├── Vistas/          → Formularios WinForms
└── Recursos/        → Logos e imágenes
```

---

## 📦 Módulos del Sistema

| Módulo | Descripción |
|---|---|
| Login | Autenticación con roles específicos |
| Menú Principal | Navegación adaptada por rol |
| Votación | Selección de plancha y emisión de voto secreto |
| Planchas Electorales | Gestión de partidos y candidatos |
| Registro de Usuarios | Alta de votantes y administradores |
| Panel de Votaciones | Estadísticas en tiempo real |
| Reportes | Generación y exportación a PDF |
| Gestionar Período | Control del período de votación |

---

## 👥 Roles del Sistema

| Rol | Permisos |
|---|---|
| **Director** | Control total del sistema |
| **Administrador** | Gestiona su propia plancha |
| **Votante** | Emite su voto y ve el panel |

---

## 🔒 Reglas de Negocio

- Un usuario solo puede votar **una vez** por período
- El voto es **secreto** — nadie puede ver por quién votó
- Un votante solo puede votar en su **padrón asignado**
- Los votos se protegen con **hash SHA-256**
- Todos los eventos quedan registrados en **logs de auditoría**

---

## ⚙️ Instalación

### Requisitos
- Visual Studio 2019 o superior
- SQL Server con instancia SQLEXPRESS
- .NET Framework 4.8

### Pasos

1. **Clonar el repositorio**
```bash
git clone https://github.com/TU_USUARIO/SistemaElectoral.git
cd SistemaElectoral
```

2. **Crear la base de datos**
   - Abrir SQL Server Management Studio
   - Ejecutar el script `Database/SistemaElectoral_DB.sql`

3. **Configurar la conexión**
   - Abrir `AccesoDatos/Conexion.cs`
   - Cambiar `TU_SERVIDOR` por el nombre de tu instancia SQL Server

4. **Abrir el proyecto**
   - Abrir `SistemaElectoral1/SistemaElectoral1.sln` en Visual Studio
   - Click en **Build → Rebuild Solution**
   - Presionar **F5** para ejecutar

### Usuario inicial
| Campo | Valor |
|---|---|
| Matrícula | `DIR-0001` |
| Contraseña | `Admin123` |
| Rol | Director |

---

## 📊 Reportes disponibles

- Reporte General de Votos
- Plancha Ganadora
- Integrantes por Partido
- Listado de Participantes

Todos exportables a **PDF**.

---

## 🌿 Estructura de ramas Git

```
main          → Código estable
feature/models        → Modelos POO
feature/acceso-datos  → Capa DAL
feature/logica-negocio → Capa BLL
feature/vistas        → Formularios WinForms
```

---

## 👨‍💻 Autor

Desarrollado como proyecto académico individual.

**Institución:** [Colegio apec fernando arturo de meriño]  
**Estudiantes:** Elvin inoa, Badir Spencer.
**Materia:** Desarrollo de aplicaciones informaticas  
**Año:** 2026
