using Context;
using Model.Models.Common;
using Model.ViewModels.Common;
using Model.ViewModels.General;
using Repository.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public class RCity : Repository<City>, IRCity
    {
        public RCity(SolutionContext context) : base(context)
        {

        }

        public async Task<BaseRetornoApi<CityViewModel>> GetListCityAsync(int? estadoId, string cidade, int? pageNumber, int? rowspPage)
        {
            BaseRetornoApi<CityViewModel> retornoApi = new BaseRetornoApi<CityViewModel>();

            var filtroEstado = estadoId.HasValue && estadoId.Value != 0 ? $"WHERE [EstadoId] = {estadoId}" : "";
            filtroEstado = !string.IsNullOrEmpty(cidade) ?
                string.Concat(!string.IsNullOrEmpty(filtroEstado) ?
                string.Concat(filtroEstado, "AND ") : "WHERE", $"[Cidade] like '%{cidade}%'") : filtroEstado;

            retornoApi.Data = (await GetListAsync(new City(), @$"
                                            DECLARE @PageNumber AS INT, @RowspPage AS INT
                                                SET @PageNumber = {pageNumber ?? 1}
                                                SET @RowspPage = {rowspPage ?? 10} 
                                            SELECT * FROM GEN_City
                                                {filtroEstado}
                                                ORDER BY CityId
                                                OFFSET ((@PageNumber - 1) * @RowspPage) ROWS
                                                FETCH NEXT @RowspPage ROWS ONLY;"))
                                            .Select(x => (CityViewModel)x).ToList();
            retornoApi.PaginaAtual = pageNumber ?? 1;

            return retornoApi;
        }
    }
}
