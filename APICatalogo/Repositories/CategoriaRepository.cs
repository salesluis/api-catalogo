using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Repositories;

public class CategoriaRepository :  ICategoriaRepository
{
    private AppDbContext _context;
    
    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Categoria> GetAllAsync()
    {
        return _context.Categorias.ToList();
    }
    public Categoria GetById(int id)
    {
        var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
        return categoria;
    }

    public Categoria Create(Categoria categoria)
    {
        if (categoria is null)
            throw new ArgumentNullException(nameof(categoria));
        _context.Categorias?.Add(categoria);
        _context.SaveChanges();
        return categoria;
    }

    public Categoria Update(Categoria categoria)
    {
        if (categoria is null)
            throw new ArgumentNullException(nameof(categoria));
        //nessa linha abaixo o entoty framework esta pegando a categoria
        // que está na memoria e esta atualizando para a percistindo no banco de dados
        _context.Entry(categoria).State = EntityState.Modified;
        _context.SaveChanges();
        return categoria;
    }

    public Categoria Delete(int id)
    {
        //nesse caso pode usar o metodo Finf, pois ele vai buscar na memoria e o 
        // FistOrDefault bate no banco de dados para verificar o Id, mas só funciona esse
        /// método se o campo for uma chave primaria
        var categoria = _context.Categorias.Find(id);
        
        if (categoria is null)
            throw new ArgumentNullException(nameof(categoria));
        
        _context.Categorias?.Remove(categoria);
        _context.SaveChanges();
        return categoria;
    }
}