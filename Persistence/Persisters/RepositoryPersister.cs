using System.Collections.Generic;
using System.IO;
using Domain.Bases;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace Persistence.Persisters
{
    public abstract class RepositoryPersister<T> : IRepositoryPersister<T> where T : Entity
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        protected RepositoryPersister(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public List<T> Load()
        {
            string path = GetFilePath();
            string json = File.ReadAllText(path);

            var list = JsonConvert.DeserializeObject<List<T>>(json);

            return list;
        }

        public void Persist(List<T> entities)
        {
            string path = GetFilePath();
            string json = JsonConvert.SerializeObject(entities);
            File.WriteAllText(path, json);
        }

        private string GetFilePath()
        {
            string fileName = $"{typeof(T).Name}.json";
            string folder = Path.Combine(_hostingEnvironment.WebRootPath, "Repository");
            string path = Path.Combine(folder, fileName);
            return path;
        }
    }
}
