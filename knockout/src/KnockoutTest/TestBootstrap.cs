using Nancy;
using Nancy.Conventions;

namespace KnockoutTest
{
    public class TestBootstrap : DefaultNancyBootstrapper    
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));

            Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat(context.ModuleName, "/Views/", viewName));
        }
    }
}