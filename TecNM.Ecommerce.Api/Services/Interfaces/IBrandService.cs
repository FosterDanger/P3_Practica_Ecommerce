using TecNM.Ecommerce.Core.Dto;

namespace TecNM.Ecommerce.Api.Services.Interfaces;

public interface IBrandService
{
    //metodo para guardar categorias.
    Task<BrandDto> SaveAsync(BrandDto brand);
    
    //metodo para actualizar las categorias.
    Task<BrandDto> UpdateAsync(BrandDto brand);
    
    //Metodo para retornar una lista de categorias.
    Task<List<BrandDto>> GetAllAsync();
    
    //Metodo para retornar el id de las categoria que borrara.
    Task<bool> BrandExist(int id);
    
    //Metodo para obtener una categoria por id.
    Task<BrandDto> GetById(int id);
    
    //Metodo para borrar.
    Task<bool> DeleteAsync(int id);
}