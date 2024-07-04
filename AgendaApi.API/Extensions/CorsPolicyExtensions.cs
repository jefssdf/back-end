namespace AgendaApi.API.Extensions
{
    public static class CorsPolicyExtensions
    {
        public static void ConfigureCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    .WithOrigins("http://github.com", "https://gitlab.com") // Defina os domínios permitidos aqui
                    .AllowAnyMethod() // Permitir qualquer método HTTP (GET, POST, etc.)
                    .AllowAnyHeader() // Permitir qualquer cabeçalho HTTP
                    .AllowCredentials()); // Permitir credenciais (cookies, cabeçalhos de autenticação, etc.)
            });
        }
    }
}
