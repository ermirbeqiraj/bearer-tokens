using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Models
{
    public class Project : Entity, IAggregateRoot
    {
        public string Name { get; private set; }

        private readonly List<Details> _details;
        public IReadOnlyList<Details> Details => _details.AsReadOnly();

        private Project()
        {
            _details = new List<Details>();
        }

        public Project(string name)
        {
            Name = name;
        }

        public void AddDetails(string url, string bearerToken, ENV env, string appInsights)
        {
            var details = new Details(url, bearerToken, env, appInsights);
            _details.Add(details);
        }

        public void RemoveDetails(Guid id)
        {
            var details = _details.Where(x => x.Id == id).SingleOrDefault();
            _details.Remove(details);
        }
    }
}
