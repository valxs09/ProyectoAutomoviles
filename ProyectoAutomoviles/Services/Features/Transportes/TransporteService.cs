using ProyectoAutomoviles.Domain.Entities;

namespace ProyectoAutomoviles.Services.Features.Transportes{
    public class TransporteService
    {
        private readonly List<Transporte> _transporte = new();

        public IEnumerable<Transporte> GetAll()
        {
            return _transporte;
        }

        public Transporte? GetById(int id)
        {
            return _transporte.FirstOrDefault(transporte => transporte.Id == id);
        }

        public void Add(Transporte transporte)
        {
            _transporte.Add(transporte);
        }

        public void Update(Transporte transporteToUpdate)
        {
            var transporte = GetById(transporteToUpdate.Id);
            if (transporte != null)
            {
                _transporte.Remove(transporte);
                _transporte.Add(transporteToUpdate);
            }
        }

        public void Delete(int id)
        {
            var transporte = GetById(id);
            if (transporte != null)
                _transporte.Remove(transporte);
        }
    }
}
