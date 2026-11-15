# Speed PDF

Aplicación de escritorio para Windows orientada a la gestión y transformación de documentos PDF, con procesamiento local y una interfaz sencilla.

## Estado del proyecto

**Fase:** definición y preparación de la base del proyecto.

La primera versión se enfocará en operaciones esenciales sobre PDF. La arquitectura y las dependencias se validarán antes de comenzar la implementación.

## Objetivos

- Procesar documentos localmente, sin subir archivos a Internet.
- Mantener una aplicación ligera y adecuada para equipos modestos.
- Ofrecer una experiencia clara y consistente.
- Conservar los archivos originales y controlar los archivos temporales.
- Evitar procesos residentes y telemetría innecesarios.

## Plataforma objetivo

- Windows x64.
- Compatibilidad objetivo: Windows 7 SP1 x64 y versiones posteriores, sujeta a validación técnica de cada dependencia.
- Hardware de referencia: Intel Core i3 de segunda generación y 8 GB de RAM.
- Funcionamiento sin conexión para las operaciones de documentos.

> Nota: Windows 7 está fuera del soporte general de seguridad de Microsoft. La compatibilidad técnica no implica que el sistema operativo siga siendo seguro o tenga soporte vigente.

## Stack tecnológico propuesto

- C#.
- Windows Forms (WinForms).
- .NET Framework 4.8.
- Compilación x64.

Las bibliotecas PDF y sus licencias aún deben evaluarse antes de incorporarlas.

## Funciones previstas para el MVP

1. Comprimir PDF.
2. Unir PDF.
3. Dividir PDF.
4. PDF a imágenes.
5. Imágenes a PDF.
6. Organizar PDF: reordenar, rotar, eliminar y extraer páginas.
7. Proteger PDF.

La conversión de PDF a Word se evaluará como una función posterior por su complejidad y requisitos de calidad.

## Diseño visual

Identidad visual aprobada: **Professional Red & Navy**.

- Azul navy: `#202B3B`
- Rojo principal: `#C9363E`
- Rojo coral: `#E54848`
- Blanco: `#FFFFFF`
- Gris claro: `#F3F5F8`
- Gris azulado: `#64748B`

## Estructura prevista

```
SpeedPDF/
├── SpeedPDF.App/
├── SpeedPDF.Core/
├── SpeedPDF.PdfEngine/
├── SpeedPDF.Infrastructure/
├── SpeedPDF.Tests/
├── Installer/
└── docs/
```

## Documentación

Consulta [la especificación inicial](docs/ESPECIFICACION_INICIAL.md) para conocer las decisiones funcionales, técnicas y visuales.

## Estado de implementación

Este repositorio contiene la documentación inicial. Todavía no incluye código ejecutable ni dependencias de terceros.
