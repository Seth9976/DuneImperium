using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000028 RID: 40
	public sealed class ServiceProviderCallSite : ServiceCallSite
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x0000A4B0 File Offset: 0x000086B0
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceProviderCallSite()
		{
			Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceProviderCallSite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr);
			ServiceProviderCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr, "<ServiceType>k__BackingField");
			ServiceProviderCallSite.NativeFieldInfoPtr__ImplementationType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr, "<ImplementationType>k__BackingField");
			ServiceProviderCallSite.NativeFieldInfoPtr__Kind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr, "<Kind>k__BackingField");
			ServiceProviderCallSite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr, 100663579);
			ServiceProviderCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr, 100663580);
			ServiceProviderCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr, 100663581);
			ServiceProviderCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr, 100663582);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000A56C File Offset: 0x0000876C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204986, XrefRangeEnd = 1205005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProviderCallSite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProviderCallSite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderCallSite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000A5A8 File Offset: 0x000087A8
		public unsafe override Type ServiceType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000A5E8 File Offset: 0x000087E8
		public unsafe override Type ImplementationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000A628 File Offset: 0x00008828
		public unsafe override CallSiteKind Kind
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000299D File Offset: 0x00000B9D
		public ServiceProviderCallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000A664 File Offset: 0x00008864
		// (set) Token: 0x060001BE RID: 446 RVA: 0x000029A6 File Offset: 0x00000BA6
		public unsafe Type _ServiceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000A694 File Offset: 0x00008894
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x000029C5 File Offset: 0x00000BC5
		public unsafe Type _ImplementationType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderCallSite.NativeFieldInfoPtr__ImplementationType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderCallSite.NativeFieldInfoPtr__ImplementationType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000A6C4 File Offset: 0x000088C4
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x000029E4 File Offset: 0x00000BE4
		public unsafe CallSiteKind _Kind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderCallSite.NativeFieldInfoPtr__Kind_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderCallSite.NativeFieldInfoPtr__Kind_k__BackingField)) = value;
			}
		}

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr__ServiceType_k__BackingField;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr__ImplementationType_k__BackingField;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr__Kind_k__BackingField;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0;
	}
}
