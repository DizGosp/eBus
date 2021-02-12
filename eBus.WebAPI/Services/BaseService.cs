using AutoMapper;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {
        protected readonly eBusContext _db;
        protected readonly IMapper _mapper;
        public BaseService(eBusContext c, IMapper m) { _db = c; _mapper = m; }
        public virtual List<TModel> Get(TSearch search)
        {
            var list = _db.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var list = _db.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(list);
        }
    }
}
