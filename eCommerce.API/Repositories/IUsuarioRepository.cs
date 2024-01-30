using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();
        Usuario Get(int id);
        void add(Usuario usuario);
        void update(Usuario usuario);
        void delete(int id);

    }
}
