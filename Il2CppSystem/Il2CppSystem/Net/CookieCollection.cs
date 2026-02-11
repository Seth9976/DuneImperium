using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020001DB RID: 475
	[Serializable]
	public class CookieCollection : Object
	{
		// Token: 0x06001D71 RID: 7537 RVA: 0x0008E670 File Offset: 0x0008C870
		// Note: this type is marked as 'beforefieldinit'.
		static CookieCollection()
		{
			Il2CppClassPointerStore<CookieCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr);
			CookieCollection.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_version");
			CookieCollection.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_list");
			CookieCollection.NativeFieldInfoPtr_m_TimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_TimeStamp");
			CookieCollection.NativeFieldInfoPtr_m_has_other_versions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_has_other_versions");
			CookieCollection.NativeFieldInfoPtr_m_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_IsReadOnly");
			CookieCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667801);
			CookieCollection.NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667802);
			CookieCollection.NativeMethodInfoPtr_Add_Public_Void_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667803);
			CookieCollection.NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667804);
			CookieCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667805);
			CookieCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667806);
			CookieCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667807);
			CookieCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667808);
			CookieCollection.NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667809);
			CookieCollection.NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667810);
			CookieCollection.NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667811);
			CookieCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667812);
			CookieCollection.NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667813);
			CookieCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100667814);
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0008E81C File Offset: 0x0008CA1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 477098, RefRangeEnd = 477101, XrefRangeStart = 477088, XrefRangeEnd = 477098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008F5 RID: 2293
		public unsafe Cookie this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 477103, RefRangeEnd = 477106, XrefRangeStart = 477101, XrefRangeEnd = 477103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cookie>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0008E8A4 File Offset: 0x0008CAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477106, XrefRangeEnd = 477114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Cookie cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_Add_Public_Void_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0008E8E8 File Offset: 0x0008CAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477138, RefRangeEnd = 477139, XrefRangeStart = 477114, XrefRangeEnd = 477138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(CookieCollection cookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0008E92C File Offset: 0x0008CB2C
		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 467480, RefRangeEnd = 467481, XrefRangeStart = 467480, XrefRangeEnd = 467481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0008E968 File Offset: 0x0008CB68
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0008E9A4 File Offset: 0x0008CBA4
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x0008E9E4 File Offset: 0x0008CBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477139, XrefRangeEnd = 477140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0008EA34 File Offset: 0x0008CC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477140, XrefRangeEnd = 477144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime TimeStamp(CookieCollection.Stamp how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0008EA80 File Offset: 0x0008CC80
		public unsafe bool IsOtherVersionSeen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0008EABC File Offset: 0x0008CCBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 477171, RefRangeEnd = 477174, XrefRangeStart = 477144, XrefRangeEnd = 477171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalAdd(Cookie cookie, bool isStrict)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStrict;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0008EB18 File Offset: 0x0008CD18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 477193, RefRangeEnd = 477196, XrefRangeStart = 477174, XrefRangeEnd = 477193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(Cookie cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0008EB68 File Offset: 0x0008CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477196, XrefRangeEnd = 477197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0008EBA8 File Offset: 0x0008CDA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477202, RefRangeEnd = 477203, XrefRangeStart = 477197, XrefRangeEnd = 477202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0000C898 File Offset: 0x0000AA98
		public CookieCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0008EBE8 File Offset: 0x0008CDE8
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x0000C8A1 File Offset: 0x0000AAA1
		public unsafe int m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_version)) = value;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0008EC10 File Offset: 0x0008CE10
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0000C8BC File Offset: 0x0000AABC
		public unsafe ArrayList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0008EC40 File Offset: 0x0008CE40
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x0000C8DB File Offset: 0x0000AADB
		public unsafe DateTime m_TimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_TimeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_TimeStamp)) = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0008EC68 File Offset: 0x0008CE68
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x0000C8F6 File Offset: 0x0000AAF6
		public unsafe bool m_has_other_versions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_has_other_versions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_has_other_versions)) = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0008EC90 File Offset: 0x0008CE90
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x0000C911 File Offset: 0x0000AB11
		public unsafe bool m_IsReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_IsReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_IsReadOnly)) = value;
			}
		}

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeStamp;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeFieldInfoPtr_m_has_other_versions;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeFieldInfoPtr_m_IsReadOnly;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Cookie_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200032C RID: 812
		public enum Stamp
		{
			// Token: 0x04002504 RID: 9476
			Check,
			// Token: 0x04002505 RID: 9477
			Set,
			// Token: 0x04002506 RID: 9478
			SetToUnused,
			// Token: 0x04002507 RID: 9479
			SetToMaxUsed
		}

		// Token: 0x0200032D RID: 813
		public class CookieCollectionEnumerator : Object
		{
			// Token: 0x06002F39 RID: 12089 RVA: 0x000CE068 File Offset: 0x000CC268
			// Note: this type is marked as 'beforefieldinit'.
			static CookieCollectionEnumerator()
			{
				Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "CookieCollectionEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr);
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_cookies");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_count");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_index");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_version");
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100667815);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100667816);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100667817);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100667818);
			}

			// Token: 0x06002F3A RID: 12090 RVA: 0x000CE134 File Offset: 0x000CC334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477070, XrefRangeEnd = 477072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookieCollectionEnumerator(CookieCollection cookies)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookies);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000EC7 RID: 3783
			// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000CE180 File Offset: 0x000CC380
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477072, XrefRangeEnd = 477088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F3C RID: 12092 RVA: 0x000CE1C0 File Offset: 0x000CC3C0
			[CallerCount(0)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F3D RID: 12093 RVA: 0x000CE1FC File Offset: 0x000CC3FC
			[CallerCount(0)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F3E RID: 12094 RVA: 0x00015278 File Offset: 0x00013478
			public CookieCollectionEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EC3 RID: 3779
			// (get) Token: 0x06002F3F RID: 12095 RVA: 0x000CE230 File Offset: 0x000CC430
			// (set) Token: 0x06002F40 RID: 12096 RVA: 0x00015281 File Offset: 0x00013481
			public unsafe CookieCollection m_cookies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x06002F41 RID: 12097 RVA: 0x000CE260 File Offset: 0x000CC460
			// (set) Token: 0x06002F42 RID: 12098 RVA: 0x000152A0 File Offset: 0x000134A0
			public unsafe int m_count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count)) = value;
				}
			}

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x06002F43 RID: 12099 RVA: 0x000CE288 File Offset: 0x000CC488
			// (set) Token: 0x06002F44 RID: 12100 RVA: 0x000152BB File Offset: 0x000134BB
			public unsafe int m_index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index)) = value;
				}
			}

			// Token: 0x17000EC6 RID: 3782
			// (get) Token: 0x06002F45 RID: 12101 RVA: 0x000CE2B0 File Offset: 0x000CC4B0
			// (set) Token: 0x06002F46 RID: 12102 RVA: 0x000152D6 File Offset: 0x000134D6
			public unsafe int m_version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version)) = value;
				}
			}

			// Token: 0x04002508 RID: 9480
			private static readonly IntPtr NativeFieldInfoPtr_m_cookies;

			// Token: 0x04002509 RID: 9481
			private static readonly IntPtr NativeFieldInfoPtr_m_count;

			// Token: 0x0400250A RID: 9482
			private static readonly IntPtr NativeFieldInfoPtr_m_index;

			// Token: 0x0400250B RID: 9483
			private static readonly IntPtr NativeFieldInfoPtr_m_version;

			// Token: 0x0400250C RID: 9484
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0;

			// Token: 0x0400250D RID: 9485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400250E RID: 9486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400250F RID: 9487
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
