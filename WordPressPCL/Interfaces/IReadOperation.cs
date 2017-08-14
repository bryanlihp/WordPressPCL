﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace WordPressPCL.Interfaces
{
    /// <summary>
    /// Interface with required Get methods
    /// </summary>
    /// <typeparam name="TClass">return class type</typeparam>
    public interface IReadOperation<TClass>
    {
        /// <summary>
        /// Get object by Id
        /// </summary>
        /// <param name="ID">Object Id</param>
        /// <param name="embed">Is use embed info</param>
        /// <param name="useAuth">Is use auth header</param>
        /// <returns>requested object</returns>
        Task<TClass> GetByID(int ID, bool embed = false, bool useAuth = false);

        /// <summary>
        /// Get all objects
        /// </summary>
        /// <param name="embed">Is use embed info</param>
        /// <param name="useAuth">Is use auth header</param>
        /// <returns>List of objects</returns>
        Task<IEnumerable<TClass>> GetAll(bool embed = false, bool useAuth = false);
    }
}