using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Google.Apis.Http
{
	// Token: 0x02000030 RID: 48
	public class IHttpClientFactory : Il2CppObjectBase
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00002D66 File Offset: 0x00000F66
		// Note: this type is marked as 'beforefieldinit'.
		static IHttpClientFactory()
		{
			Il2CppClassPointerStore<IHttpClientFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "IHttpClientFactory");
			IHttpClientFactory.NativeMethodInfoPtr_CreateHttpClient_Public_Abstract_Virtual_New_ConfigurableHttpClient_CreateHttpClientArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHttpClientFactory>.NativeClassPtr, 100663630);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000C00C File Offset: 0x0000A20C
		[CallerCount(0)]
		public unsafe virtual ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHttpClientFactory.NativeMethodInfoPtr_CreateHttpClient_Public_Abstract_Virtual_New_ConfigurableHttpClient_CreateHttpClientArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002D95 File Offset: 0x00000F95
		public IHttpClientFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_CreateHttpClient_Public_Abstract_Virtual_New_ConfigurableHttpClient_CreateHttpClientArgs_0;
	}
}
