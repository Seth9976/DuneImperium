using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Google.Apis.Http
{
	// Token: 0x0200002E RID: 46
	public class IConfigurableHttpClientInitializer : Il2CppObjectBase
	{
		// Token: 0x06000210 RID: 528 RVA: 0x00002CAD File Offset: 0x00000EAD
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigurableHttpClientInitializer()
		{
			Il2CppClassPointerStore<IConfigurableHttpClientInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "IConfigurableHttpClientInitializer");
			IConfigurableHttpClientInitializer.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurableHttpClientInitializer>.NativeClassPtr, 100663620);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000BBAC File Offset: 0x00009DAC
		[CallerCount(0)]
		public unsafe virtual void Initialize(ConfigurableHttpClient httpClient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpClient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurableHttpClientInitializer.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_ConfigurableHttpClient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002CDC File Offset: 0x00000EDC
		public IConfigurableHttpClientInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_ConfigurableHttpClient_0;
	}
}
