using Microsoft.JSInterop;

namespace blazor_personal_library.Shared.Utils
{
    public static class IJSRunTimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            return await jSRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}
