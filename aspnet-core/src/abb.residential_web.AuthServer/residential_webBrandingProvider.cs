using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace abb.residential_web;

[Dependency(ReplaceServices = true)]
public class residential_webBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "residential_web";
}
