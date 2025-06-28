# 🛠️ CRUD de Productos - ASP.NET Core Web API

Este proyecto es una Web API desarrollada como parte de una prueba técnica para el cargo de desarrollador. Implementa operaciones CRUD completas sobre un recurso de tipo **Product** utilizando una base de datos en memoria.


## ✨ Características

- ✅ Operaciones CRUD completas (Create, Read, Update, Delete)
- ✅ Base de datos en memoria para pruebas
- ✅ Documentación automática con Swagger/OpenAPI
- ✅ Validaciones de datos con Data Annotations
- ✅ Arquitectura limpia con separación de responsabilidades
- ✅ Inyección de dependencias

## 📚 Estructura del Proyecto

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

## 🚀 Instalación y Ejecución

### Pasos para ejecutar

1. **Clonar el repositorio**
   ```bash
   git clone <url-del-repositorio>
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
   https://localhost:7xxx/swagger
   ```

## 🌐 Endpoints de la API

| Método | Ruta | Descripción | Código de Respuesta |
|--------|------|-------------|-------------------|
| `GET` | `/api/product` | Obtener todos los productos | 200 OK |
| `GET` | `/api/product/{id}` | Obtener un producto por ID | 200 OK / 404 Not Found |
| `POST` | `/api/product` | Crear un nuevo producto | 201 Created / 400 Bad Request |
| `PUT` | `/api/product/{id}` | Actualizar un producto existente | 200 OK / 404 Not Found / 400 Bad Request |
| `DELETE` | `/api/product/{id}` | Eliminar un producto | 204 No Content / 404 Not Found |

## ✅ Validaciones

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

## 🧪 Ejemplos de Uso

### Crear un nuevo producto (POST)

**Request:**
```http
POST /api/product
Content-Type: application/json

{
  "name": "Teclado inalámbrico",
  "price": 129.99,
  "quantity": 5
}
```

**Response:**
```http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "id": 1,
  "name": "Teclado inalámbrico",
  "price": 129.99,
  "quantity": 5
}
```

### Actualizar un producto (PUT)

**Request:**
```http
PUT /api/product/1
Content-Type: application/json

{
  "name": "Teclado inalámbrico RGB",
  "price": 149.99,
  "quantity": 3
}
```

### Obtener todos los productos (GET)

**Request:**
```http
GET /api/product
```

**Response:**
```http
HTTP/1.1 200 OK
Content-Type: application/json

[
  {
    "id": 1,
    "name": "Teclado inalámbrico RGB",
    "price": 149.99,
    "quantity": 3
  }
]
```

## 🔧 Tecnologías Utilizadas

- **ASP.NET Core 6.0+** - Framework web
- **Entity Framework Core** - ORM (con InMemoryDatabase)
- **Swagger/OpenAPI** - Documentación de API
- **Data Annotations** - Validaciones
- **Dependency Injection** - Inyección de dependencias

## 🧠 Notas Técnicas

- El proyecto utiliza una base de datos **en memoria** para facilitar las pruebas y demostración
- Todos los datos se pierden al reiniciar la aplicación
- Swagger está habilitado por defecto para facilitar la exploración y prueba de la API
- La arquitectura sigue principios de separación de responsabilidades con capas bien definidas

## 📝 Posibles Mejoras

- [ ] Implementar logging con Serilog
- [ ] Agregar pruebas unitarias e integración
- [ ] Implementar paginación para el endpoint GET
- [ ] Agregar filtros de búsqueda
- [ ] Implementar autenticación y autorización
- [ ] Agregar versionado de API

## 📌 Autor

**Juan David Franco Betancur**
- 📧 Email: juandavid.francob@gmail.com
- 🔗 LinkedIn: [Agregar perfil]
- 🐙 GitHub: [Agregar perfil]

---

*Desarrollado como parte de una prueba técnica para el cargo de desarrollador.*
