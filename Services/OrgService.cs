using GCAT.NET.Entities.Organization;
using Microsoft.EntityFrameworkCore;

namespace GCAT.NET.Services
{
    /// <inheritdoc cref="IEntityService"/>
    public class OrgService : IEntityService<Org>
    {
        private readonly DbContext _context;

        public OrgService(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Create a batch of organizations
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public Task<Org> Create(IEnumerable<Org> items)
        {
            return null;
        }

        /// <summary>
        /// Get a batch of organizations
        /// </summary>
        /// <param name="codes"></param>
        /// <returns></returns>
        public Task<Org> Read(IEnumerable<string> codes)
        {
            return  null;
        }

        /// <summary>
        /// Update a batch of organizations
        /// </summary>
        /// <param name="codes"></param>
        /// <returns></returns>
        public Task<Org> Update(IEnumerable<Org> codes)
        {
            return  null;
        }

        /// <summary>
        /// Delete a batch of organizations
        /// </summary>
        /// <param name="codes"></param>
        /// <returns></returns>
        public Task<Org> Delete(IEnumerable<Org> codes)
        {
            return  null;
        }
    }
}