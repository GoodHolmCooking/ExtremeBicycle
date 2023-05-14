using Microsoft.AspNetCore.Mvc;

namespace ExtremeBicycle.Controllers {
    public class ProductController : Controller {
        public IActionResult Index() {
            return View();
        }

        // Create
        //[HttpPost]
        //public ActionResult<int> AddItem(Category item) {
        //    _recipesContext.Categories.Add(item);
        //    _recipesContext.SaveChanges();
        //    return Created($"/api/Categories/{item.CategoryId}", item.CategoryId);
        //}

        // Read
        //[HttpGet]
        //public ActionResult<IEnumerable<Category>> GetItems() {
        //    return _recipesContext.Categories
        //        .ToList();
        //}

        //[HttpGet("{id}")]
        //public ActionResult<Category> GetItem(int id) {
        //    var category = _recipesContext.Categories
        //        .Where(c => c.CategoryId == id)
        //        .FirstOrDefault();

        //    if (category == null) {
        //        return NotFound();
        //    }

        //    return category;
        //}

        // Update
        //[HttpPut("{id}")]
        //public ActionResult<Category> UpdateItem(int id, [FromBody] Category update) {

        //    var foundCategory = _recipesContext.Categories.FirstOrDefault(c => c.CategoryId == id);
        //    foundCategory.CategoryName = update.CategoryName;
        //    _recipesContext.SaveChanges();
        //    return foundCategory;
        //}

        // Delete
        //[HttpDelete("{id}")]
        //public ActionResult DeleteItem(int id) {
        //    var category = _recipesContext.Categories.FirstOrDefault(c => c.CategoryId == id);
        //    if (category == null) return NotFound();
        //    _recipesContext.Categories.Remove(category);
        //    _recipesContext.SaveChanges();

        //    return NoContent();
        //}
    }
}
