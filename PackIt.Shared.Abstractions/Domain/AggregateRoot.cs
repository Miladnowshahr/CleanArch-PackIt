using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Shared.Abstractions.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }
        public int Version { get; protected set; }

        public IEnumerable<IDomainEvent> Events => _event;

        private bool _versionIncremented;

        private readonly List<IDomainEvent> _event = new();

        protected void IncremetedVersion()
        {
            if (_versionIncremented)
            {
                return;
            }
            Version++;
            _versionIncremented = true;
        }

        public void ClearEvents() => _event.Clear();

        protected void AddEvent(IDomainEvent @event)
        {
            if (!_event.Any() && !_versionIncremented)
            {
                Version++;
                _versionIncremented = true;

                _event.Add(@event);
            }
        }
    }
}
