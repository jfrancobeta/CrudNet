


# 🛠️ Prueba Técnica - CRUD de Productos en ASP.NET Core

Este proyecto es una Web API desarrollada como parte de una prueba técnica para el cargo de desarrollador. Implementa operaciones CRUD básicas sobre un recurso de tipo **Product** con una base de datos en memoria.

---

## 📚 Estructura del proyecto

crudProduct/
├── Controllers/
│ └── ProductController.cs
├── Models/
│ └── Product.cs
├── Repositories/
│ ├── IProductRepository.cs
│ └── ProductRepository.cs
├── Services/
│ └── ProductService.cs
├── data/
│ └── ProductDbContext.cs (solo si se desea usar EF con InMemory)
├── Program.cs


---

Se abrirá automáticamente la documentación Swagger en el navegador:
Método	Ruta	Descripción
GET	/api/product	Obtener todos los productos
GET	/api/product/{id}	Obtener un producto por ID
POST	/api/product	Crear un nuevo producto
PUT	/api/product/{id}	Actualizar un producto
DELETE	/api/product/{id}	Eliminar un producto

✅ Validaciones aplicadas
Name: Requerido, mínimo 1 carácter.

Price: Requerido, Mayor a 0.

Quantity: Requerido, Mayor a 0.

Estas validaciones están implementadas mediante Data Annotations en el modelo Product.

🧪 Ejemplo de JSON para POST/PUT
Editar
{
  "name": "Teclado inalámbrico",
  "price": 129.99,
  "quantity": 5
}
🧠 Observaciones
El proyecto no utiliza base de datos real. Todos los productos se almacenan en una lista en memoria o en un contexto EF en memoria (UseInMemoryDatabase), según versión.

Swagger está habilitado para facilitar la exploración de la API.

📌 Autor
Nombre: Juan David Franco Betancur

📧 juandavid.francob@gmail.com

