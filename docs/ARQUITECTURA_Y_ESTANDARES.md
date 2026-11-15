# Arquitectura y estándares

## Proyectos y dependencias
- SpeedPDF.App: composición de dependencias y UI WinForms.
- SpeedPDF.Core: contratos, modelos y reglas; no depende de UI ni proveedores.
- SpeedPDF.PdfEngine: adaptadores que encapsulan la biblioteca PDF seleccionada.
- SpeedPDF.Infrastructure: filesystem, logs, temporales, configuración y actualizaciones.
- SpeedPDF.Tests.Unit: pruebas rápidas. Integración y E2E se incorporarán al crecer los casos de uso.

Las dependencias apuntan hacia Core. Core no conoce infraestructura, WinForms ni bibliotecas PDF. Preferir composición e inyección de dependencias frente a singletons globales.

## Clean Code, DRY, KISS y SOLID
- SRP: una responsabilidad principal por clase.
- OCP: incorporar motores mediante adaptadores.
- LSP: respetar contratos y precondiciones.
- ISP: interfaces pequeñas orientadas al consumidor.
- DIP: reglas centrales dependen de abstracciones.
- DRY: compartir reglas reales; no abstraer coincidencias accidentales.
- KISS: monolito modular, sin microservicios ni procesos residentes innecesarios.
- Nombres explícitos, métodos acotados y validación en los límites.

## TDD
Red: escribir primero la prueba y confirmar que falla por la razón correcta. Green: implementar lo mínimo. Refactor: mejorar sin romper pruebas. Cada corrección de defecto añade prueba de regresión.

## Pruebas
Unitarias para reglas y validaciones. Integración para motor PDF, filesystem y temporales. E2E para flujos completos de UI. Casos: PDF vacío, protegido, corrupto, escaneado, muchas páginas, imágenes pesadas, rutas con caracteres especiales, permisos y disco lleno. Usar fixtures controlados, nunca documentos personales.

## Errores y logs
Errores esperables deben dar mensajes accionables. Excepciones inesperadas se registran con operación e identificador de correlación. No registrar contraseñas, contenido PDF ni datos sensibles. Logs locales con retención limitada. La UI no debe bloquearse durante operaciones.

## Git
main estable. Ramas feature/, fix/, chore/ y docs/. Commits Conventional Commits (feat, fix, test, docs, refactor, build, chore). Pull Request y CI verde antes de integrar. No subir binarios, PDFs de usuarios, secretos ni carpetas de compilación.

## Dependencias y CI/CD
Fijar versiones exactas. Revisar mantenimiento, compatibilidad Windows 7 SP1 x64, binarios nativos y licencia de redistribución. Registrar versión y licencia en DEPENDENCIAS.md. CI compila en Windows y ejecuta pruebas en push y Pull Request. Publicación de instaladores se habilitará tras definir firma, empaquetado y matriz de pruebas.
