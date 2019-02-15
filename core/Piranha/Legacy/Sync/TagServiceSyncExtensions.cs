/*
 * Copyright (c) 2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Piranha.Data;

namespace Piranha.Services
{
    public static class TagServiceSyncExtensions
    {
        /// <summary>
        /// Gets all available models for the specified blog.
        /// </summary>
        /// <param name="id">The blog id</param>
        /// <returns>The available models</returns>
        public static IEnumerable<Tag> GetAll(this TagService service, Guid blogId)
        {
            return service.GetAllAsync(blogId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the models for the post with the given id.
        /// </summary>
        /// <param name="postId">The post id</param>
        /// <returns>The model</returns>
        public static IEnumerable<Tag> GetByPostId(this TagService service, Guid postId)
        {
            return service.GetByPostIdAsync(postId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        /// <returns>The model, or null if it doesn't exist</returns>
        public static Tag GetById(this TagService service, Guid id)
        {
            return service.GetByIdAsync(id).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the model with the given slug.
        /// </summary>
        /// <param name="blogId">The blog id</param>
        /// <param name="slug">The unique slug</param>
        /// <returns>The model</returns>
        public static Tag GetBySlug(this TagService service, Guid blogId, string slug)
        {
            return service.GetBySlugAsync(blogId, slug).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the model with the given title
        /// </summary>
        /// <param name="blogId">The blog id</param>
        /// <param name="title">The unique title</param>
        /// <returns>The model</returns>
        public static Tag GetByTitle(this TagService service, Guid blogId, string title)
        {
            return service.GetByTitleAsync(blogId, title).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Adds or updates the given model in the database
        /// depending on its state.
        /// </summary>
        /// <param name="model">The model</param>
        public static void Save(this TagService service, Tag model)
        {
            service.SaveAsync(model).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        public static void Delete(this TagService service, Guid id)
        {
            service.DeleteAsync(id).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the given model.
        /// </summary>
        /// <param name="model">The model</param>
        public static void Delete(this TagService service, Tag model)
        {
            service.DeleteAsync(model).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes all unused categories for the specified blog.
        /// </summary>
        /// <param name="blogId">The blog id</param>
        public static void DeleteUnused(this TagService service, Guid blogId)
        {
            service.DeleteUnusedAsync(blogId).GetAwaiter().GetResult();
        }
    }
}