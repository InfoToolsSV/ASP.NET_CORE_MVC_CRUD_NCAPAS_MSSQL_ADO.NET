using BussinessLayer;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class ProductoController(ProductoService productoService) : Controller
    {
        private readonly ProductoService _productoService = productoService;

        public IActionResult Index()
        {
            var productos = _productoService.GetAllProductos();
            return View(productos);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if(ModelState.IsValid)
            {
                _productoService.AddProducto(producto);
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        public IActionResult Edit(int id)
        {
            Producto producto = _productoService.GetProductoById(id);
            if (producto==null)
            {
                return NotFound();
            }

            return View(producto);
        }
        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            if(ModelState.IsValid)
            {
                _productoService.UpdateProducto(producto);
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        public IActionResult Delete(int id)
        {
            Producto producto = _productoService.GetProductoById(id);
            if (producto==null)
            {
                return NotFound();
            }

            return View(producto);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _productoService.DeleteProducto(id);
            return RedirectToAction(nameof(Index));
        }
    }
}