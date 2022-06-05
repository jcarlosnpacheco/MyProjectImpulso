using Abp.AutoMapper;
using MyProjectImpulso.Authentication.External;

namespace MyProjectImpulso.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
