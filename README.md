#  CRUD de Productos - ASP.NET Core Web API

Este proyecto es una Web API desarrollada como parte de una prueba técnica para el cargo de desarrollador. Implementa operaciones CRUD completas sobre un recurso de tipo **Product** utilizando una base de datos en memoria.


##  Características

- ✅ Operaciones CRUD completas (Create, Read, Update, Delete)
- ✅ Base de datos en memoria 
- ✅ Documentación automática con Swagger/OpenAPI
- ✅ Validaciones de datos con Data Annotations
- ✅ Arquitectura limpia con separación de responsabilidades
- ✅ Inyección de dependencias

##  Estructura del Proyecto

```
crudProduct/
├── Controllers/
│   └── ProductController.cs       # Controlador principal de la API
├── Models/
│   └── Product.cs                 # Modelo de datos del producto
├── Repositories/
│   ├── IProductRepository.cs      # Interfaz del repositorio
│   └── ProductRepository.cs       # Implementación del repositorio
├── Services/
│   └── ProductService.cs          # Lógica de negocio
├── Data/
│   └── ProductDbContext.cs        # Contexto de Entity Framework 
├── Program.cs                     # Punto de entrada de la aplicación
```

##  Instalación y Ejecución

### Pasos para ejecutar

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/jfrancobeta/CrudNet.git
   cd crudProduct
   ```

2. **Restaurar dependencias**
   ```bash
   dotnet restore
   ```

3. **Ejecutar la aplicación**
   ```bash
   dotnet run
   ```

4. **Acceder a la documentación**
   
   La aplicación se abrirá automáticamente en el navegador mostrando la documentación Swagger en:
   ```
   https://localhost:7069/swagger
   ```

##  Endpoints de la API

| Método | Ruta | Descripción |
|--------|------|-------------|
| `GET` | `/api/product` | Obtener todos los productos |
| `GET` | `/api/product/{id}` | Obtener un producto por ID | 
| `POST` | `/api/product` | Crear un nuevo producto | 
| `PUT` | `/api/product/{id}` | Actualizar un producto existente | 
| `DELETE` | `/api/product/{id}` | Eliminar un producto | 

##  Validaciones

El modelo `Product` incluye las siguientes validaciones:

- **Name**: 
  - ✅ Requerido
  - ✅ Mínimo 1 carácter
  
- **Price**: 
  - ✅ Requerido
  - ✅ Debe ser mayor a 0
  
- **Quantity**: 
  - ✅ Requerido
  - ✅ Debe ser mayor a 0

*Las validaciones están implementadas mediante Data Annotations en el modelo Product.*


##  Notas Técnicas

- El proyecto utiliza una base de datos **en memoria** para facilitar las pruebas y demostración
- Todos los datos se pierden al reiniciar la aplicación
- Swagger está habilitado por defecto para facilitar la exploración y prueba de la API
- La arquitectura sigue principios de separación de responsabilidades con capas bien definidas


##  Autor

**Juan David Franco Betancur**
- 📧 Email: juandavid.francob@gmail.com


---

*Desarrollado como parte de una prueba técnica para el cargo de desarrollador.*
