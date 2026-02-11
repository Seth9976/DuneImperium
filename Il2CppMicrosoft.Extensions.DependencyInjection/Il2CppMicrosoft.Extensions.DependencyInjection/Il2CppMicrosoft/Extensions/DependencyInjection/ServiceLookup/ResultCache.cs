using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000021 RID: 33
	public sealed class ResultCache : ValueType
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00008EE4 File Offset: 0x000070E4
		// Note: this type is marked as 'beforefieldinit'.
		static ResultCache()
		{
			Il2CppClassPointerStore<ResultCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ResultCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultCache>.NativeClassPtr);
			ResultCache.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, "<Location>k__BackingField");
			ResultCache.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, "<Key>k__BackingField");
			ResultCache.NativeMethodInfoPtr_None_Public_Static_ResultCache_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, 100663531);
			ResultCache.NativeMethodInfoPtr__ctor_Internal_Void_CallSiteResultCacheLocation_ServiceCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, 100663532);
			ResultCache.NativeMethodInfoPtr__ctor_Public_Void_ServiceLifetime_ServiceIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, 100663533);
			ResultCache.NativeMethodInfoPtr_get_Location_Public_get_CallSiteResultCacheLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, 100663534);
			ResultCache.NativeMethodInfoPtr_set_Location_Public_set_Void_CallSiteResultCacheLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, 100663535);
			ResultCache.NativeMethodInfoPtr_get_Key_Public_get_ServiceCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, 100663536);
			ResultCache.NativeMethodInfoPtr_set_Key_Public_set_Void_ServiceCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCache>.NativeClassPtr, 100663537);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008FC8 File Offset: 0x000071C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204746, XrefRangeEnd = 1204750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResultCache None(Type serviceType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultCache.NativeMethodInfoPtr_None_Public_Static_ResultCache_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ResultCache(intPtr);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00009004 File Offset: 0x00007204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1204751, RefRangeEnd = 1204753, XrefRangeStart = 1204750, XrefRangeEnd = 1204751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResultCache(CallSiteResultCacheLocation lifetime, ServiceCacheKey cacheKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultCache>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lifetime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cacheKey));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultCache.NativeMethodInfoPtr__ctor_Internal_Void_CallSiteResultCacheLocation_ServiceCacheKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00009068 File Offset: 0x00007268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204753, XrefRangeEnd = 1204758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResultCache(ServiceLifetime lifetime, ServiceIdentifier serviceIdentifier, int slot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultCache>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lifetime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultCache.NativeMethodInfoPtr__ctor_Public_Void_ServiceLifetime_ServiceIdentifier_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000090DC File Offset: 0x000072DC
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00009120 File Offset: 0x00007320
		public unsafe CallSiteResultCacheLocation Location
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultCache.NativeMethodInfoPtr_get_Location_Public_get_CallSiteResultCacheLocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultCache.NativeMethodInfoPtr_set_Location_Public_set_Void_CallSiteResultCacheLocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00009164 File Offset: 0x00007364
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000091A0 File Offset: 0x000073A0
		public unsafe ServiceCacheKey Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultCache.NativeMethodInfoPtr_get_Key_Public_get_ServiceCacheKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ServiceCacheKey(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204758, XrefRangeEnd = 1204759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultCache.NativeMethodInfoPtr_set_Key_Public_set_Void_ServiceCacheKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000274A File Offset: 0x0000094A
		public ResultCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002753 File Offset: 0x00000953
		public ResultCache()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultCache>.NativeClassPtr))
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000091EC File Offset: 0x000073EC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002765 File Offset: 0x00000965
		public unsafe CallSiteResultCacheLocation _Location_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultCache.NativeFieldInfoPtr__Location_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultCache.NativeFieldInfoPtr__Location_k__BackingField)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00009214 File Offset: 0x00007414
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002780 File Offset: 0x00000980
		public ServiceCacheKey _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultCache.NativeFieldInfoPtr__Key_k__BackingField);
				return new ServiceCacheKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultCache.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_None_Public_Static_ResultCache_Type_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CallSiteResultCacheLocation_ServiceCacheKey_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServiceLifetime_ServiceIdentifier_Int32_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_CallSiteResultCacheLocation_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_set_Location_Public_set_Void_CallSiteResultCacheLocation_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_ServiceCacheKey_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_ServiceCacheKey_0;
	}
}
