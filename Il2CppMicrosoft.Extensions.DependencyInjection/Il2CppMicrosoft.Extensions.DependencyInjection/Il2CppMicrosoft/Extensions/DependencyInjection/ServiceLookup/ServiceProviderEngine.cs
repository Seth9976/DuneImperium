using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000029 RID: 41
	public class ServiceProviderEngine : Object
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x0000A6EC File Offset: 0x000088EC
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceProviderEngine()
		{
			Il2CppClassPointerStore<ServiceProviderEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceProviderEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderEngine>.NativeClassPtr);
			ServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Abstract_Virtual_New_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngine>.NativeClassPtr, 100663583);
			ServiceProviderEngine.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngine>.NativeClassPtr, 100663584);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000A744 File Offset: 0x00008944
		[CallerCount(0)]
		public unsafe virtual Func<ServiceProviderEngineScope, Object> RealizeService(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Abstract_Virtual_New_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProviderEngine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProviderEngine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngine.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000029FF File Offset: 0x00000BFF
		public ServiceProviderEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_RealizeService_Public_Abstract_Virtual_New_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
