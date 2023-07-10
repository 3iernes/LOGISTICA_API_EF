using Microsoft.EntityFrameworkCore;
using API_LOGISTICA_EF_NET.Models;

namespace API_LOGISTICA_EF_NET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }
        //Desde la entidad Vehiculo se crea la tabla Vehiculos en la base de datos, así se lee
        public DbSet<Vehiculo> Vehiculos => Set<Vehiculo>();
        public DbSet<Maquina> Maquinas => Set<Maquina>();
        public DbSet<CajaChica> CajaChicas => Set<CajaChica>();
        public DbSet<CargaCombustible> CargaCombustibles => Set<CargaCombustible>();
        public DbSet<Checklist> Checklists => Set<Checklist>();
        public DbSet<ChecklistItem> ChecklistItems => Set<ChecklistItem>();
        public DbSet<Chofer> Choferes => Set<Chofer>();
        public DbSet<CodsTransporteGastosPersonal> CodsTransporteGastosPersonals => Set<CodsTransporteGastosPersonal>();
        public DbSet<CombustibleComprobantes> CombustibleComprobantes => Set<CombustibleComprobantes>();
        public DbSet<CostoKmHoras> CostoKmHoras => Set<CostoKmHoras>();
        public DbSet<Cubierta> Cubiertas => Set<Cubierta>();
        public DbSet<CubiertaAccion> CubiertaAcciones => Set<CubiertaAccion>();
        public DbSet<CubiertasVehPersonal> CubiertasVehPersonals => Set<CubiertasVehPersonal>();
        public DbSet<CuerpoChecklist> CuerpoChecklists => Set<CuerpoChecklist>();
        public DbSet<DetalleResultChecklist> DetalleResultChecklists => Set<DetalleResultChecklist>();
        public DbSet<Empresas> Empresas => Set<Empresas>();
        public DbSet<Equipos> Equipos => Set<Equipos>();
        public DbSet<GastosPersonal> GastosPersonal => Set<GastosPersonal>();
        public DbSet<GastosVehiculos> GastosVehiculos => Set<GastosVehiculos>();
        public DbSet<ItemsChecklistTipos> ItemsChecklistTipos => Set<ItemsChecklistTipos>();
        public DbSet<LargaDist> LargaDists => Set<LargaDist>();
        public DbSet<Localidades> Localidades => Set<Localidades>();
        public DbSet<MaquinasTipos> MaquinasTipos => Set<MaquinasTipos>();
        public DbSet<Maquinistas> Maquinistas => Set<Maquinistas>();
        public DbSet<MarcasCubiertas> MarcasCubiertas => Set<MarcasCubiertas>();
        public DbSet<MedidasCubiertas> MedidasCubiertas => Set<MedidasCubiertas>();
        public DbSet<MovimientosCajaChica> MovimientosCajaChicas => Set<MovimientosCajaChica>();
        public DbSet<Operativos> Operativos => Set<Operativos>();
        public DbSet<OperativosTipos> OperativosTipos => Set<OperativosTipos>();
        public DbSet<OrigenesCargaCombustible> OrigenesCargaCombustible => Set<OrigenesCargaCombustible>();
        public DbSet<PersonalvehsEventos> PersonalvehsEventos => Set<PersonalvehsEventos>();
        public DbSet<Place> Places => Set<Place>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Provincia> Provincias => Set<Provincia>();
        public DbSet<ResultadoChecklist> ResultadoChecklists => Set<ResultadoChecklist>();
        public DbSet<RoutesFront> Routes => Set<RoutesFront>();
        public DbSet<TipoTarifa> TipoTarifas => Set<TipoTarifa>();
        public DbSet<TipoViaje> TipoViajes => Set<TipoViaje>();
        public DbSet<UserRoute> UserRoutes => Set<UserRoute>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<VehiculoCubierta> VehiculoCubiertas => Set<VehiculoCubierta>();
        public DbSet<VehiculoPersonal> VehiculoPersonals => Set<VehiculoPersonal>();
        public DbSet<VehiculoPersonalCubierta> VehiculoPersonalCubiertas => Set<VehiculoPersonalCubierta>();
        public DbSet<VehiculoTipo> VehiculoTipos => Set<VehiculoTipo>();
        public DbSet<Viaje> Viajes => Set<Viaje>();
        public DbSet<ViajeCubierta> ViajeCubiertas => Set<ViajeCubierta>();
        public DbSet<ViajeEquipo> ViajeEquipos => Set<ViajeEquipo>();
        public DbSet<ViajeEstado> ViajeEstados => Set<ViajeEstado>();
        public DbSet<VPCargaCombustible> VPCargasCombustible => Set<VPCargaCombustible>();
        public DbSet<VPCategoriaEvento> VPCategoriaEventos => Set<VPCategoriaEvento>();
    }
}
