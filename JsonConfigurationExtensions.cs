using Microsoft.Extensions.Configuration;
using System;

namespace Niputi.Configuration.Json
{
    public static class JsonConfigurationExtensions
    {

        ///// <summary>
        ///// Adds the Json configuration provider at <paramref name="path"/> to <paramref name="builder"/>.
        ///// </summary>
        ///// <param name="builder">The <see cref="IConfigurationBuilder"/> to add to.</param>
        ///// <param name="path">Path relative to the base path stored in 
        ///// <see cref="IConfigurationBuilder.Properties"/> of <paramref name="builder"/>.</param>
        ///// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        //public static IConfigurationBuilder AddJson(this IConfigurationBuilder builder, string path)
        //{
        //    return AddJson(builder, path: path);
        //}


        /// <summary>
        /// Adds a Json configuration source to <paramref name="builder"/>.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/> to add to.</param>
        /// <param name="JsonString"> Json String
        /// <see cref="IConfigurationBuilder.Properties"/> of <paramref name="builder"/>.</param>
        /// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        public static IConfigurationBuilder AddJson(this IConfigurationBuilder builder, string JsonString)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            if (string.IsNullOrEmpty(JsonString))
            {
                throw new ArgumentException(Resources.Error_InvalidFilePath, nameof(JsonString));
            }

            var source = new JsonConfigurationSource
            {
                JsonString = JsonString
            };
            builder.Add(source);
            return builder;
        }

    }
}
