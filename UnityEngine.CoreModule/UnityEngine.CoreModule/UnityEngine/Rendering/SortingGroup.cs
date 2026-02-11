using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200025A RID: 602
	public sealed class SortingGroup : Behaviour
	{
		// Token: 0x0600292D RID: 10541 RVA: 0x000AB08C File Offset: 0x000A928C
		// Note: this type is marked as 'beforefieldinit'.
		static SortingGroup()
		{
			Il2CppClassPointerStore<SortingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr);
			SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668502);
			SortingGroup.NativeMethodInfoPtr_UpdateAllSortingGroups_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668503);
			SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668504);
			SortingGroup.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668505);
			SortingGroup.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668506);
			SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668507);
			SortingGroup.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668508);
			SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668509);
			SortingGroup.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668510);
			SortingGroup.NativeMethodInfoPtr_get_sortAtRoot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668511);
			SortingGroup.NativeMethodInfoPtr_set_sortAtRoot_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668512);
			SortingGroup.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668513);
			SortingGroup.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668514);
			SortingGroup.NativeMethodInfoPtr_get_index_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668515);
			SortingGroup.NativeMethodInfoPtr_get_sortingKey_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668516);
			SortingGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100668517);
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000AB1FC File Offset: 0x000A93FC
		public unsafe static int invalidSortingGroupID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 685586, RefRangeEnd = 685590, XrefRangeStart = 685584, XrefRangeEnd = 685586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000AB22C File Offset: 0x000A942C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685590, XrefRangeEnd = 685592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAllSortingGroups()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_UpdateAllSortingGroups_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000AB254 File Offset: 0x000A9454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685594, RefRangeEnd = 685595, XrefRangeStart = 685592, XrefRangeEnd = 685594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SortingGroup GetSortingGroupByIndex(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortingGroup>(intPtr3) : null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x000AB294 File Offset: 0x000A9494
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x000AB2CC File Offset: 0x000A94CC
		public unsafe string sortingLayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685595, XrefRangeEnd = 685597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685597, XrefRangeEnd = 685599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x000AB310 File Offset: 0x000A9510
		// (set) Token: 0x06002934 RID: 10548 RVA: 0x000AB34C File Offset: 0x000A954C
		public unsafe int sortingLayerID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685601, RefRangeEnd = 685602, XrefRangeStart = 685599, XrefRangeEnd = 685601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685602, XrefRangeEnd = 685604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x000AB38C File Offset: 0x000A958C
		// (set) Token: 0x06002936 RID: 10550 RVA: 0x000AB3C8 File Offset: 0x000A95C8
		public unsafe int sortingOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685606, RefRangeEnd = 685607, XrefRangeStart = 685604, XrefRangeEnd = 685606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685607, XrefRangeEnd = 685609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x000AB408 File Offset: 0x000A9608
		// (set) Token: 0x06002938 RID: 10552 RVA: 0x000AB444 File Offset: 0x000A9644
		public unsafe bool sortAtRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685609, XrefRangeEnd = 685611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortAtRoot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685611, XrefRangeEnd = 685613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_set_sortAtRoot_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000AB484 File Offset: 0x000A9684
		public unsafe int sortingGroupID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685613, XrefRangeEnd = 685615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000AB4C0 File Offset: 0x000A96C0
		public unsafe int sortingGroupOrder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685615, XrefRangeEnd = 685617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000AB4FC File Offset: 0x000A96FC
		public unsafe int index
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685617, XrefRangeEnd = 685619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_index_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000AB538 File Offset: 0x000A9738
		public unsafe uint sortingKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685619, XrefRangeEnd = 685621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingKey_Internal_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000AB574 File Offset: 0x000A9774
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x0000FF4B File Offset: 0x0000E14B
		public SortingGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0;

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllSortingGroups_Public_Static_Void_0;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeMethodInfoPtr_get_sortAtRoot_Public_get_Boolean_0;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeMethodInfoPtr_set_sortAtRoot_Public_set_Void_Boolean_0;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Internal_get_Int32_0;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingKey_Internal_get_UInt32_0;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
