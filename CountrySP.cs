using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDapper.domain
{
    public class CountrySP
    {
        public List<Models.CountryInfo> GetAllCountry()
        {
            var result = DapperORM.ReturnList<dynamic>("select tbl_country.countryId,tbl_country.countryName,tbl_state.stateId AS States_stateId,tbl_state.stateName AS States_stateName from tbl_country inner join tbl_state on tbl_state.countryId = tbl_country.countryId", null);
            Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Models.CountryInfo), new List<string> { "countryId" });
            Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Models.StateInfo), new List<string> { "stateId" });
            var data = (Slapper.AutoMapper.MapDynamic<Models.CountryInfo>(result) as IEnumerable<Models.CountryInfo>).ToList();
            return data;
        }
        public Models.CountryInfo GetCountryById()
        {
            var result = DapperORM.ReturnList<dynamic>("select tbl_country.countryId,tbl_country.countryName,tbl_state.stateId AS State_stateId,tbl_state.stateName AS State_stateName from tbl_country inner join tbl_state on tbl_state.countryId = tbl_country.countryId where tbl_state.stateId=1", null);
            var data = (Slapper.AutoMapper.MapDynamic<Models.CountryInfo>(result)).FirstOrDefault();
            return data;
        }
    }
}
