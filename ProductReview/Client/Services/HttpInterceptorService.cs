using Microsoft.AspNetCore.Components;
using System.Net;
using Toolbelt.Blazor;

namespace ProductReview.Client.Services
{
	public class HttpInterceptorService
	{
		private readonly HttpClientInterceptor interceptor;
		private readonly NavigationManager navManager;

		public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
		{
			this.interceptor = interceptor;
			this.navManager = navManager;
		}

		public void MonitorEvent() => interceptor.AfterSend += InterceptResponse;

		private void InterceptResponse(object sender, HttpClientInterceptorEventArgs e)
		{
			//throw new NotImplementedException();

			string message = string.Empty;
			if (!e.Response.IsSuccessStatusCode)
			{
				var responseCode = e.Response.StatusCode;

				switch (responseCode)
				{
					case HttpStatusCode.NotFound:
						navManager.NavigateTo("/404");
						message = "The requested resource was not found.";
						break;
					case HttpStatusCode.Unauthorized: /*this*/
					case HttpStatusCode.Forbidden: /*And this*/
						navManager.NavigateTo("/unauthorized"); /*will execute this*/
						message = "You are not authorized to access this resource. ";
						break;
					default:
						navManager.NavigateTo("/500");
						message = "Something went wrong, please contact Administrator";
						break;
				}
			}
		}

		public void DisposeEvent() => interceptor.AfterSend -= InterceptResponse;

	}
}
   

