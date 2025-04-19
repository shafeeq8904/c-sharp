
#  ASP.NET Core Microservice – Synchronous Service-to-Service Communication

This project demonstrates how a **microservice** can synchronously call an **external service** (API) to retrieve data—in this case, product information from the [Fake Store API](https://fakestoreapi.com/).

---

##  How It Works

1. A client sends a **GET** request to our API endpoint like:
   ```
   GET /api/products/1
   ```

2. The `ProductsController` receives the request and uses a **service** (`IProductService`) to process it.

3. `ProductService` uses `HttpClient` to call the **external Fake Store API** like:
   ```
   https://fakestoreapi.com/products/1
   ```

4. The result is returned back to the controller, then to the client.

---

##  Folder Structure

```
SynchronousProductConsumer/
│
├── Controllers/
│   └── ProductsController.cs       // API endpoints for fetching products
│
├── Services/
│   ├── IProductService.cs         // Interface defining contract for product service
│   └── ProductService.cs          // Implements synchronous call using HttpClient
│
├── Models/
│   └── Product.cs                 // Model matching the structure of external API response
│
├── Program.cs                     // Sets up the application and dependency injection
└── README.md
```

---

##  Technologies Used

- **ASP.NET Core Web API**
- **C#**
- **HttpClient**
- **Swagger (Swashbuckle)**
- **System.Text.Json**
- **Fake Store API** (external)

---

##  Key Concepts

### 1.  Synchronous Communication

Synchronous communication means the service **waits** for the external service to respond before proceeding.

```csharp
var response = _httpClient.GetAsync(url).Result;
```

> `.Result` blocks the thread until a response is received. This is useful for simple, quick external calls.

---

### 2.  Interface + Service Pattern

Using `IProductService` and `ProductService`:

- `IProductService` defines what functions are available (contract).
- `ProductService` implements how those functions are done (logic).

```csharp
public interface IProductService {
    Product GetProductById(int id);
}
```

```csharp
public class ProductService : IProductService {
    public Product GetProductById(int id) { ... }
}
```

This helps with **loose coupling** and **unit testing**.

---

### 3.  Dependency Injection

Dependency Injection is used to provide objects (like `HttpClient`) to classes that need them.

```csharp
builder.Services.AddHttpClient<IProductService, ProductService>();
```

This tells ASP.NET Core:
> "Whenever someone asks for `IProductService`, give them a `ProductService` with an HttpClient already configured."

---

### 4.  API Documentation with Swagger

Swagger is enabled to let you **interact** with and **test** the API via a web browser.

After running the project, navigate to:

```
http://localhost:<port>/swagger
```

---

##  Running the Project

### 1.  Install Dependencies

```bash
dotnet add package Swashbuckle.AspNetCore
```

### 2. ▶ Run the Project

```bash
dotnet run
```

### 3.  Test Using Swagger

Go to:

```
http://localhost:<port>/swagger
```

Use `/api/products/{id}` to fetch data from the external API.

---

##  Example Response

Request:
```
GET /api/products/1
```

Response:
```json
{
  "id": 1,
  "title": "Fjallraven Backpack",
  "price": 109.95,
  "description": "Perfect pack for everyday use...",
  "category": "men's clothing",
  "image": "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg"
}
```

---

##  Summary of Concepts

| Concept                     | What It Means                                              |
|-----------------------------|------------------------------------------------------------|
| **Synchronous Call**        | Blocking call that waits for external response             |
| **Service Layer**           | Contains business logic, keeps controllers clean           |
| **Interface (IProductService)** | Defines what methods the service must implement         |
| **Dependency Injection**    | Inject services like HttpClient instead of manually creating |
| **External API**            | Our service is consuming another API’s data                |

---


