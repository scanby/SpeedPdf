# Especificación inicial — Speed PDF

**Estado:** aprobado como línea base inicial.  
**Última actualización:** 2026-11-14.

## 1. Visión del producto

Speed PDF será una aplicación de escritorio para Windows que permita realizar operaciones habituales sobre documentos PDF desde el equipo del usuario. El procesamiento de documentos será local y no requerirá cargar archivos a servicios externos.

## 2. Alcance funcional

### MVP

- Comprimir PDF.
- Unir varios PDF.
- Dividir PDF por rangos o páginas.
- Convertir PDF a imágenes.
- Convertir imágenes a PDF.
- Organizar páginas: reordenar, rotar, eliminar y extraer.
- Proteger PDF mediante contraseña/cifrado.

### Etapas posteriores

- PDF a Word, Excel y PowerPoint.
- Office a PDF.
- Marcas de agua y numeración.
- OCR.
- Reparación y comparación de PDF.
- Firmas, edición, censura, PDF/A y formularios.

Las funciones posteriores no forman parte del compromiso del MVP. Se priorizarán después de validar calidad, complejidad, rendimiento y licenciamiento.

## 3. Plataforma y compatibilidad

- Arquitectura exclusivamente x64.
- Sistemas objetivo: Windows 7 SP1 x64 en adelante.
- Tecnología propuesta: C# + WinForms + .NET Framework 4.8.
- Instalador con dependencias incluidas cuando la redistribución y las licencias lo permitan.
- El instalador deberá comprobar los prerrequisitos de sistema y ofrecer su instalación cuando corresponda.
- La compatibilidad final dependerá de las pruebas de cada biblioteca y componente nativo.

Windows 7 está fuera del soporte general de seguridad. La compatibilidad técnica no equivale a soporte de seguridad vigente.

## 4. Objetivos de rendimiento

Son metas de diseño que deberán medirse en equipos reales, no garantías:

- Uso de CPU prácticamente nulo en reposo.
- RAM en reposo objetivo: 50–100 MB.
- RAM en operaciones sencillas objetivo: 100–200 MB.
- Evitar cargar todas las páginas y miniaturas simultáneamente.
- Vista previa opcional y renderizado bajo demanda.
- Operaciones secuenciales por defecto.
- Interfaz no bloqueante durante el procesamiento.
- Cancelación cuando sea técnicamente segura.
- Gestión y limpieza de archivos temporales.
- Liberación de recursos al cerrar documentos.

Equipo de referencia: Intel Core i3 de segunda generación, 8 GB de RAM y HDD o SSD.

## 5. Arquitectura propuesta

Solución modular de escritorio, sin microservicios ni servidor local.

- **SpeedPDF.App:** formularios, controles, navegación y experiencia de usuario.
- **SpeedPDF.Core:** modelos, reglas de negocio, interfaces y coordinación de tareas.
- **SpeedPDF.PdfEngine:** operaciones PDF, conversión y renderizado.
- **SpeedPDF.Infrastructure:** sistema de archivos, temporales, configuración, registros y actualizaciones.
- **SpeedPDF.Tests:** pruebas unitarias y de integración.
- **Installer:** empaquetado y prerrequisitos.

Estructura inicial prevista:

```
SpeedPDF/
├── SpeedPDF.App/
│   ├── Forms/
│   ├── Controls/
│   ├── Resources/
│   └── Program.cs
├── SpeedPDF.Core/
│   ├── Services/
│   ├── Models/
│   ├── Interfaces/
│   ├── Configuration/
│   └── Exceptions/
├── SpeedPDF.PdfEngine/
│   ├── Merge/
│   ├── Split/
│   ├── Compress/
│   ├── Convert/
│   ├── Organize/
│   ├── Protect/
│   └── Render/
├── SpeedPDF.Infrastructure/
│   ├── FileSystem/
│   ├── TemporaryFiles/
│   ├── Logging/
│   └── Updates/
├── SpeedPDF.Tests/
├── Installer/
└── docs/
```

## 6. Criterios para seleccionar bibliotecas

Antes de integrar cualquier motor PDF se deberá comprobar:

1. Compatibilidad real con .NET Framework 4.8 y Windows objetivo.
2. Disponibilidad de binarios x64 para todos los componentes nativos.
3. Licencia y obligaciones de redistribución, especialmente si la aplicación se distribuye de forma propietaria.
4. Mantenimiento, seguridad y procedencia de los paquetes.
5. Calidad del resultado en documentos reales.
6. Consumo de memoria y rendimiento en hardware modesto.

No se incorporará una dependencia únicamente porque permita compilar. Se documentarán versión, licencia, origen y pruebas.

## 7. Identidad visual aprobada

Nombre: **Speed PDF**  
Dirección visual: **Professional Red & Navy**.

| Uso | Color | HEX |
|---|---|---|
| Marca, navegación y títulos | Azul navy | #202B3B |
| Acciones principales | Rojo principal | #C9363E |
| Acentos | Rojo coral | #E54848 |
| Superficies | Blanco | #FFFFFF |
| Fondo de trabajo | Gris claro | #F3F5F8 |
| Texto secundario | Gris azulado | #64748B |
| Bordes | Gris neutro | #E5E7EB |
| Estado exitoso | Verde | #16A36A |

Modo claro como predeterminado. Interfaz sobria, minimalista y propia de una aplicación de escritorio.

## 8. Principios UX

- Navegación lateral persistente.
- Inicio con herramientas frecuentes, selección de archivos y recientes.
- Flujo común: seleccionar archivos, configurar, ejecutar, ver progreso y acceder al resultado.
- Arrastrar y soltar y selección múltiple.
- Mantener originales; no sobrescribir sin confirmación.
- Mostrar errores accionables y estados de éxito, cancelación y progreso.
- Informar tamaño original, tamaño final y reducción al comprimir.
- Escalar correctamente en 100 %, 125 % y 150 % de DPI.
- Evitar animaciones y efectos que aumenten innecesariamente el consumo.

## 9. Pruebas mínimas

Validar con documentos de 1, 100 y 500 páginas, PDFs escaneados, alta resolución, protegidos, dañados y de gran tamaño.

Matriz de sistemas: Windows 7 SP1, 8, 8.1, 10 y 11 x64, según disponibilidad de entornos de prueba. Probar HDD y SSD, distintas escalas DPI y equipos de referencia.

## 10. Decisiones pendientes antes de programar

- Selección final del motor PDF y sus licencias.
- Estrategia de compresión y calidad.
- Motor de renderizado y vista previa.
- Tecnología de instalador y distribución de prerrequisitos.
- Diseño detallado y validación del prototipo de la pantalla principal.
- Política de versiones, actualizaciones y firma del instalador.

## 11. Estado

La identidad visual y los criterios generales de plataforma, arquitectura y rendimiento están aprobados como línea base. La implementación aún no ha comenzado.
