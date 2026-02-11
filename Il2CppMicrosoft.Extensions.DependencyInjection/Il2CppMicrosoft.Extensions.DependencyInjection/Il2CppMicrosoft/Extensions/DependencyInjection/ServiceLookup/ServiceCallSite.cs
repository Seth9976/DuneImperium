using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000024 RID: 36
	public class ServiceCallSite : Object
	{
		// Token: 0x06000179 RID: 377 RVA: 0x0000972C File Offset: 0x0000792C
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceCallSite()
		{
			Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceCallSite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr);
			ServiceCallSite.NativeFieldInfoPtr__Cache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, "<Cache>k__BackingField");
			ServiceCallSite.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, "<Value>k__BackingField");
			ServiceCallSite.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, "<Key>k__BackingField");
			ServiceCallSite.NativeMethodInfoPtr__ctor_Protected_Void_ResultCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663551);
			ServiceCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663552);
			ServiceCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663553);
			ServiceCallSite.NativeMethodInfoPtr_get_Kind_Public_Abstract_Virtual_New_get_CallSiteKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663554);
			ServiceCallSite.NativeMethodInfoPtr_get_Cache_Public_get_ResultCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663555);
			ServiceCallSite.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663556);
			ServiceCallSite.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663557);
			ServiceCallSite.NativeMethodInfoPtr_get_Key_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663558);
			ServiceCallSite.NativeMethodInfoPtr_set_Key_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663559);
			ServiceCallSite.NativeMethodInfoPtr_get_CaptureDisposable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr, 100663560);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009860 File Offset: 0x00007A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204802, XrefRangeEnd = 1204804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite(ResultCache cache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCallSite>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cache));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCallSite.NativeMethodInfoPtr__ctor_Protected_Void_ResultCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000098B0 File Offset: 0x00007AB0
		public unsafe virtual Type ServiceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000098FC File Offset: 0x00007AFC
		public unsafe virtual Type ImplementationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00009948 File Offset: 0x00007B48
		public unsafe virtual CallSiteKind Kind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceCallSite.NativeMethodInfoPtr_get_Kind_Public_Abstract_Virtual_New_get_CallSiteKind_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00009990 File Offset: 0x00007B90
		public unsafe ResultCache Cache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCallSite.NativeMethodInfoPtr_get_Cache_Public_get_ResultCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ResultCache(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000099C8 File Offset: 0x00007BC8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00009A08 File Offset: 0x00007C08
		public unsafe Object Value
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCallSite.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCallSite.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00009A4C File Offset: 0x00007C4C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00009A8C File Offset: 0x00007C8C
		public unsafe Object Key
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCallSite.NativeMethodInfoPtr_get_Key_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCallSite.NativeMethodInfoPtr_set_Key_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00009AD0 File Offset: 0x00007CD0
		public unsafe bool CaptureDisposable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1204818, RefRangeEnd = 1204820, XrefRangeStart = 1204804, XrefRangeEnd = 1204818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCallSite.NativeMethodInfoPtr_get_CaptureDisposable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000282D File Offset: 0x00000A2D
		public ServiceCallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00009B0C File Offset: 0x00007D0C
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002836 File Offset: 0x00000A36
		public ResultCache _Cache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCallSite.NativeFieldInfoPtr__Cache_k__BackingField);
				return new ResultCache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCallSite.NativeFieldInfoPtr__Cache_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00009B3C File Offset: 0x00007D3C
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002864 File Offset: 0x00000A64
		public unsafe Object _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCallSite.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCallSite.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009B6C File Offset: 0x00007D6C
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002883 File Offset: 0x00000A83
		public unsafe Object _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCallSite.NativeFieldInfoPtr__Key_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCallSite.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr__Cache_k__BackingField;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ResultCache_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Abstract_Virtual_New_get_CallSiteKind_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Public_get_ResultCache_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Object_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_Object_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_CaptureDisposable_Public_get_Boolean_0;
	}
}
