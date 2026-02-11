using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Authentication.ExtendedProtection;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D3 RID: 467
	public class ServiceNameStore : Object
	{
		// Token: 0x06001CC1 RID: 7361 RVA: 0x0008C37C File Offset: 0x0008A57C
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceNameStore()
		{
			Il2CppClassPointerStore<ServiceNameStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServiceNameStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceNameStore>.NativeClassPtr);
			ServiceNameStore.NativeFieldInfoPtr_serviceNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceNameStore>.NativeClassPtr, "serviceNames");
			ServiceNameStore.NativeFieldInfoPtr_serviceNameCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceNameStore>.NativeClassPtr, "serviceNameCollection");
			ServiceNameStore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceNameStore>.NativeClassPtr, 100667699);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476294, RefRangeEnd = 476295, XrefRangeStart = 476285, XrefRangeEnd = 476294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceNameStore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceNameStore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceNameStore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0000C39C File Offset: 0x0000A59C
		public ServiceNameStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0008C424 File Offset: 0x0008A624
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0000C3A5 File Offset: 0x0000A5A5
		public unsafe List<string> serviceNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceNameStore.NativeFieldInfoPtr_serviceNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceNameStore.NativeFieldInfoPtr_serviceNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0008C454 File Offset: 0x0008A654
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
		public unsafe ServiceNameCollection serviceNameCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceNameStore.NativeFieldInfoPtr_serviceNameCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceNameCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceNameStore.NativeFieldInfoPtr_serviceNameCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_serviceNames;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_serviceNameCollection;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
