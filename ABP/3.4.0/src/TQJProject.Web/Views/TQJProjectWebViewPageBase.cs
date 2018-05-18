using Abp.Web.Mvc.Views;

namespace TQJProject.Web.Views
{
    public abstract class TQJProjectWebViewPageBase : TQJProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class TQJProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TQJProjectWebViewPageBase()
        {
            LocalizationSourceName = TQJProjectConsts.LocalizationSourceName;
        }
    }
}