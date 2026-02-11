using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000018 RID: 24
	public class CacheControlHeaderValue : Object
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00009D8C File Offset: 0x00007F8C
		// Note: this type is marked as 'beforefieldinit'.
		static CacheControlHeaderValue()
		{
			Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "CacheControlHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr);
			CacheControlHeaderValue.NativeFieldInfoPtr_extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "extensions");
			CacheControlHeaderValue.NativeFieldInfoPtr_no_cache_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "no_cache_headers");
			CacheControlHeaderValue.NativeFieldInfoPtr_private_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "private_headers");
			CacheControlHeaderValue.NativeFieldInfoPtr__MaxAge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<MaxAge>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__MaxStale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<MaxStale>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__MaxStaleLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<MaxStaleLimit>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__MinFresh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<MinFresh>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__MustRevalidate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<MustRevalidate>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__NoCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<NoCache>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__NoStore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<NoStore>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__NoTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<NoTransform>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__OnlyIfCached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<OnlyIfCached>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__Private_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<Private>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__ProxyRevalidate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<ProxyRevalidate>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__Public_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<Public>k__BackingField");
			CacheControlHeaderValue.NativeFieldInfoPtr__SharedMaxAge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, "<SharedMaxAge>k__BackingField");
			CacheControlHeaderValue.NativeMethodInfoPtr_get_Extensions_Public_get_ICollection_1_NameValueHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663508);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_MaxAge_Public_get_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663509);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_MaxAge_Public_set_Void_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663510);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_MaxStale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663511);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_MaxStale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663512);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_MaxStaleLimit_Public_get_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663513);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_MaxStaleLimit_Public_set_Void_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663514);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_MinFresh_Public_get_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663515);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_MinFresh_Public_set_Void_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663516);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_MustRevalidate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663517);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_MustRevalidate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663518);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_NoCache_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663519);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_NoCache_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663520);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_NoCacheHeaders_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663521);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_NoStore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663522);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_NoStore_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663523);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_NoTransform_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663524);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_NoTransform_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663525);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_OnlyIfCached_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663526);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_OnlyIfCached_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663527);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_Private_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663528);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_Private_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663529);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_PrivateHeaders_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663530);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_ProxyRevalidate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663531);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_ProxyRevalidate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663532);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_Public_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663533);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_Public_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663534);
			CacheControlHeaderValue.NativeMethodInfoPtr_get_SharedMaxAge_Public_get_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663535);
			CacheControlHeaderValue.NativeMethodInfoPtr_set_SharedMaxAge_Public_set_Void_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663536);
			CacheControlHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663537);
			CacheControlHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663538);
			CacheControlHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663539);
			CacheControlHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_CacheControlHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663540);
			CacheControlHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663541);
			CacheControlHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr, 100663542);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000A1B8 File Offset: 0x000083B8
		public unsafe ICollection<NameValueHeaderValue> Extensions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172607, XrefRangeEnd = 1172614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_Extensions_Public_get_ICollection_1_NameValueHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<NameValueHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000A1F8 File Offset: 0x000083F8
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000A230 File Offset: 0x00008430
		public unsafe Nullable<TimeSpan> MaxAge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_MaxAge_Public_get_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_MaxAge_Public_set_Void_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000A278 File Offset: 0x00008478
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000A2B4 File Offset: 0x000084B4
		public unsafe bool MaxStale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_MaxStale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_MaxStale_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000A2F4 File Offset: 0x000084F4
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000A32C File Offset: 0x0000852C
		public unsafe Nullable<TimeSpan> MaxStaleLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_MaxStaleLimit_Public_get_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_MaxStaleLimit_Public_set_Void_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000A374 File Offset: 0x00008574
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000A3AC File Offset: 0x000085AC
		public unsafe Nullable<TimeSpan> MinFresh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_MinFresh_Public_get_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_MinFresh_Public_set_Void_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000A3F4 File Offset: 0x000085F4
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000A430 File Offset: 0x00008630
		public unsafe bool MustRevalidate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_MustRevalidate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_MustRevalidate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000A470 File Offset: 0x00008670
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000A4AC File Offset: 0x000086AC
		public unsafe bool NoCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_NoCache_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_NoCache_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000A4EC File Offset: 0x000086EC
		public unsafe ICollection<string> NoCacheHeaders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1172621, RefRangeEnd = 1172622, XrefRangeStart = 1172614, XrefRangeEnd = 1172621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_NoCacheHeaders_Public_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000A52C File Offset: 0x0000872C
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000A568 File Offset: 0x00008768
		public unsafe bool NoStore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_NoStore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_NoStore_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A5A8 File Offset: 0x000087A8
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000A5E4 File Offset: 0x000087E4
		public unsafe bool NoTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_NoTransform_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_NoTransform_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000A624 File Offset: 0x00008824
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000A660 File Offset: 0x00008860
		public unsafe bool OnlyIfCached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_OnlyIfCached_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_OnlyIfCached_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A6A0 File Offset: 0x000088A0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000A6DC File Offset: 0x000088DC
		public unsafe bool Private
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_Private_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_Private_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000A71C File Offset: 0x0000891C
		public unsafe ICollection<string> PrivateHeaders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1172629, RefRangeEnd = 1172630, XrefRangeStart = 1172622, XrefRangeEnd = 1172629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_PrivateHeaders_Public_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000A75C File Offset: 0x0000895C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000A798 File Offset: 0x00008998
		public unsafe bool ProxyRevalidate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_ProxyRevalidate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_ProxyRevalidate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000A7D8 File Offset: 0x000089D8
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0000A814 File Offset: 0x00008A14
		public unsafe bool Public
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_Public_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_Public_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000A854 File Offset: 0x00008A54
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000A88C File Offset: 0x00008A8C
		public unsafe Nullable<TimeSpan> SharedMaxAge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_get_SharedMaxAge_Public_get_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_set_SharedMaxAge_Public_set_Void_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172630, XrefRangeEnd = 1172704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000A914 File Offset: 0x00008B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172704, XrefRangeEnd = 1172730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CacheControlHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000A96C File Offset: 0x00008B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172730, XrefRangeEnd = 1172759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CacheControlHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172759, XrefRangeEnd = 1172903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out CacheControlHeaderValue parsedValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_CacheControlHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new CacheControlHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000AA18 File Offset: 0x00008C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172903, XrefRangeEnd = 1173043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CacheControlHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000AA5C File Offset: 0x00008C5C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CacheControlHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheControlHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheControlHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002978 File Offset: 0x00000B78
		public CacheControlHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000AA98 File Offset: 0x00008C98
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002981 File Offset: 0x00000B81
		public unsafe List<NameValueHeaderValue> extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr_extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NameValueHeaderValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr_extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000029A0 File Offset: 0x00000BA0
		public unsafe List<string> no_cache_headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr_no_cache_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr_no_cache_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000029BF File Offset: 0x00000BBF
		public unsafe List<string> private_headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr_private_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr_private_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000AB28 File Offset: 0x00008D28
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000029DE File Offset: 0x00000BDE
		public Nullable<TimeSpan> _MaxAge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MaxAge_k__BackingField);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MaxAge_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000AB58 File Offset: 0x00008D58
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002A0C File Offset: 0x00000C0C
		public unsafe bool _MaxStale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MaxStale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MaxStale_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000AB80 File Offset: 0x00008D80
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002A27 File Offset: 0x00000C27
		public Nullable<TimeSpan> _MaxStaleLimit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MaxStaleLimit_k__BackingField);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MaxStaleLimit_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002A55 File Offset: 0x00000C55
		public Nullable<TimeSpan> _MinFresh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MinFresh_k__BackingField);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MinFresh_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000ABE0 File Offset: 0x00008DE0
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002A83 File Offset: 0x00000C83
		public unsafe bool _MustRevalidate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MustRevalidate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__MustRevalidate_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000AC08 File Offset: 0x00008E08
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002A9E File Offset: 0x00000C9E
		public unsafe bool _NoCache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__NoCache_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__NoCache_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000AC30 File Offset: 0x00008E30
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002AB9 File Offset: 0x00000CB9
		public unsafe bool _NoStore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__NoStore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__NoStore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000AC58 File Offset: 0x00008E58
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public unsafe bool _NoTransform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__NoTransform_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__NoTransform_k__BackingField)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000AC80 File Offset: 0x00008E80
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002AEF File Offset: 0x00000CEF
		public unsafe bool _OnlyIfCached_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__OnlyIfCached_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__OnlyIfCached_k__BackingField)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000ACA8 File Offset: 0x00008EA8
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002B0A File Offset: 0x00000D0A
		public unsafe bool _Private_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__Private_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__Private_k__BackingField)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002B25 File Offset: 0x00000D25
		public unsafe bool _ProxyRevalidate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__ProxyRevalidate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__ProxyRevalidate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002B40 File Offset: 0x00000D40
		public unsafe bool _Public_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__Public_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__Public_k__BackingField)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000AD20 File Offset: 0x00008F20
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002B5B File Offset: 0x00000D5B
		public Nullable<TimeSpan> _SharedMaxAge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__SharedMaxAge_k__BackingField);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheControlHeaderValue.NativeFieldInfoPtr__SharedMaxAge_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_extensions;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_no_cache_headers;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_private_headers;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr__MaxAge_k__BackingField;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr__MaxStale_k__BackingField;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr__MaxStaleLimit_k__BackingField;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr__MinFresh_k__BackingField;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr__MustRevalidate_k__BackingField;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr__NoCache_k__BackingField;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr__NoStore_k__BackingField;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr__NoTransform_k__BackingField;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr__OnlyIfCached_k__BackingField;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr__Private_k__BackingField;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr__ProxyRevalidate_k__BackingField;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr__Public_k__BackingField;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr__SharedMaxAge_k__BackingField;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_Extensions_Public_get_ICollection_1_NameValueHeaderValue_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxAge_Public_get_Nullable_1_TimeSpan_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxAge_Public_set_Void_Nullable_1_TimeSpan_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxStale_Public_get_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxStale_Public_set_Void_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxStaleLimit_Public_get_Nullable_1_TimeSpan_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxStaleLimit_Public_set_Void_Nullable_1_TimeSpan_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_MinFresh_Public_get_Nullable_1_TimeSpan_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_set_MinFresh_Public_set_Void_Nullable_1_TimeSpan_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_MustRevalidate_Public_get_Boolean_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_set_MustRevalidate_Public_set_Void_Boolean_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_get_NoCache_Public_get_Boolean_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_set_NoCache_Public_set_Void_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_NoCacheHeaders_Public_get_ICollection_1_String_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_NoStore_Public_get_Boolean_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_set_NoStore_Public_set_Void_Boolean_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_NoTransform_Public_get_Boolean_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_set_NoTransform_Public_set_Void_Boolean_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_OnlyIfCached_Public_get_Boolean_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_set_OnlyIfCached_Public_set_Void_Boolean_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_Private_Public_get_Boolean_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_set_Private_Public_set_Void_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateHeaders_Public_get_ICollection_1_String_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyRevalidate_Public_get_Boolean_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_set_ProxyRevalidate_Public_set_Void_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_Public_Public_get_Boolean_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_set_Public_Public_set_Void_Boolean_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedMaxAge_Public_get_Nullable_1_TimeSpan_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedMaxAge_Public_set_Void_Nullable_1_TimeSpan_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_CacheControlHeaderValue_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
