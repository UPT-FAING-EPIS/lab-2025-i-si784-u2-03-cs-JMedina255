# 📘 Documentación del Proyecto BankAccount

Este sitio ha sido generado con [DocFX](https://dotnet.github.io/docfx/) como parte del laboratorio de **pruebas unitarias con NUnit** y documentación automática de componentes en C#.

La documentación cubre tanto el **comportamiento funcional del componente BankAccount**, como los escenarios de prueba, arquitectura del proyecto y métricas clave.

---

## 🏗 Estructura del Proyecto

El proyecto está compuesto por:

- 📁 `Bank.Domain`: Biblioteca de clases que contiene la lógica del sistema bancario (`BankAccount.cs`).
- 📁 `Bank.Domain.Tests`: Proyecto de pruebas unitarias basado en NUnit.
- 📁 `api/`: Documentación generada automáticamente desde el código fuente (`.yml`).
- 📁 `Cobertura/`: Reporte de cobertura de pruebas generado con ReportGenerator (si aplica).

---

## 🧾 Descripción del Componente

La clase principal es:

```csharp
public class BankAccount
