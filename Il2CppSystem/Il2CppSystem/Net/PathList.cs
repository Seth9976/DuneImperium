using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020001DE RID: 478
	[Serializable]
	public class PathList : Object
	{
		// Token: 0x06001DB7 RID: 7607 RVA: 0x0008F63C File Offset: 0x0008D83C
		// Note: this type is marked as 'beforefieldinit'.
		static PathList()
		{
			Il2CppClassPointerStore<PathList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "PathList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathList>.NativeClassPtr);
			PathList.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathList>.NativeClassPtr, "m_list");
			PathList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667835);
			PathList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667836);
			PathList.NativeMethodInfoPtr_GetCookiesCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667837);
			PathList.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667838);
			PathList.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667839);
			PathList.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667840);
			PathList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667841);
			PathList.NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100667842);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0008F720 File Offset: 0x0008D920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477691, XrefRangeEnd = 477702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0008F75C File Offset: 0x0008D95C
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477702, XrefRangeEnd = 477703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0008F798 File Offset: 0x0008D998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477726, RefRangeEnd = 477727, XrefRangeStart = 477703, XrefRangeEnd = 477726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCookiesCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_GetCookiesCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0008F7D4 File Offset: 0x0008D9D4
		public unsafe ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700090B RID: 2315
		public unsafe Object this[string s]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477727, XrefRangeEnd = 477728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 477732, RefRangeEnd = 477733, XrefRangeStart = 477728, XrefRangeEnd = 477732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0008F8B8 File Offset: 0x0008DAB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 451031, RefRangeEnd = 451039, XrefRangeStart = 451031, XrefRangeEnd = 451039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0008F8F8 File Offset: 0x0008DAF8
		public unsafe Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0000CA70 File Offset: 0x0000AC70
		public PathList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0008F938 File Offset: 0x0008DB38
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0000CA79 File Offset: 0x0000AC79
		public unsafe SortedList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathList.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathList.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr_GetCookiesCount_Public_Int32_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ICollection_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0;

		// Token: 0x0200032E RID: 814
		[Serializable]
		public class PathListComparer : Object
		{
			// Token: 0x06002F47 RID: 12103 RVA: 0x000CE2D8 File Offset: 0x000CC4D8
			// Note: this type is marked as 'beforefieldinit'.
			static PathListComparer()
			{
				Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathList>.NativeClassPtr, "PathListComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr);
				PathList.PathListComparer.NativeFieldInfoPtr_StaticInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr, "StaticInstance");
				PathList.PathListComparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr, 100667843);
				PathList.PathListComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr, 100667844);
			}

			// Token: 0x06002F48 RID: 12104 RVA: 0x000CE340 File Offset: 0x000CC540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477670, XrefRangeEnd = 477691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IComparer_Compare(Object ol, Object or)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ol);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.PathListComparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F49 RID: 12105 RVA: 0x000CE3A0 File Offset: 0x000CC5A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathListComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.PathListComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F4A RID: 12106 RVA: 0x000152F1 File Offset: 0x000134F1
			public PathListComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x06002F4B RID: 12107 RVA: 0x000CE3DC File Offset: 0x000CC5DC
			// (set) Token: 0x06002F4C RID: 12108 RVA: 0x000152FA File Offset: 0x000134FA
			public unsafe static PathList.PathListComparer StaticInstance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PathList.PathListComparer.NativeFieldInfoPtr_StaticInstance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathList.PathListComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PathList.PathListComparer.NativeFieldInfoPtr_StaticInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002510 RID: 9488
			private static readonly IntPtr NativeFieldInfoPtr_StaticInstance;

			// Token: 0x04002511 RID: 9489
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x04002512 RID: 9490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
