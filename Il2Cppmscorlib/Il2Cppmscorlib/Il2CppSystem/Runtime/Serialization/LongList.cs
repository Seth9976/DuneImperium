using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032D RID: 813
	[Serializable]
	public class LongList : Object
	{
		// Token: 0x060031D2 RID: 12754 RVA: 0x000FCB04 File Offset: 0x000FAD04
		// Note: this type is marked as 'beforefieldinit'.
		static LongList()
		{
			Il2CppClassPointerStore<LongList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "LongList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongList>.NativeClassPtr);
			LongList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_values");
			LongList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_count");
			LongList.NativeFieldInfoPtr_m_totalItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_totalItems");
			LongList.NativeFieldInfoPtr_m_currentItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_currentItem");
			LongList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671120);
			LongList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671121);
			LongList.NativeMethodInfoPtr_Add_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671122);
			LongList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671123);
			LongList.NativeMethodInfoPtr_StartEnumeration_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671124);
			LongList.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671125);
			LongList.NativeMethodInfoPtr_get_Current_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671126);
			LongList.NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671127);
			LongList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671128);
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000FCC38 File Offset: 0x000FAE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385884, XrefRangeEnd = 1385889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000FCC74 File Offset: 0x000FAE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385889, XrefRangeEnd = 1385894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000FCCBC File Offset: 0x000FAEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385894, XrefRangeEnd = 1385899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_Add_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x000FCCFC File Offset: 0x000FAEFC
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000FCD38 File Offset: 0x000FAF38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 979871, RefRangeEnd = 979876, XrefRangeStart = 979871, XrefRangeEnd = 979876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEnumeration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_StartEnumeration_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000FCD6C File Offset: 0x000FAF6C
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x000FCDA8 File Offset: 0x000FAFA8
		public unsafe long Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_get_Current_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000FCDE4 File Offset: 0x000FAFE4
		[CallerCount(0)]
		public unsafe bool RemoveElement(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000FCE30 File Offset: 0x000FB030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385899, XrefRangeEnd = 1385905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000112FE File Offset: 0x0000F4FE
		public LongList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x000FCE64 File Offset: 0x000FB064
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x00011307 File Offset: 0x0000F507
		public unsafe Il2CppStructArray<long> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x000FCE94 File Offset: 0x000FB094
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x00011326 File Offset: 0x0000F526
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x000FCEBC File Offset: 0x000FB0BC
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x00011341 File Offset: 0x0000F541
		public unsafe int m_totalItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_totalItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_totalItems)) = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x000FCEE4 File Offset: 0x000FB0E4
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x0001135C File Offset: 0x0000F55C
		public unsafe int m_currentItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_currentItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_currentItem)) = value;
			}
		}

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeFieldInfoPtr_m_totalItems;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeFieldInfoPtr_m_currentItem;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Int64_0;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeMethodInfoPtr_StartEnumeration_Internal_Void_0;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Int64_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;
	}
}
