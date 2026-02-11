using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010A RID: 266
	public sealed class BitSet : Object
	{
		// Token: 0x06001808 RID: 6152 RVA: 0x0007CF70 File Offset: 0x0007B170
		// Note: this type is marked as 'beforefieldinit'.
		static BitSet()
		{
			Il2CppClassPointerStore<BitSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "BitSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitSet>.NativeClassPtr);
			BitSet.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitSet>.NativeClassPtr, "count");
			BitSet.NativeFieldInfoPtr_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitSet>.NativeClassPtr, "bits");
			BitSet.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667046);
			BitSet.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667047);
			BitSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667048);
			BitSet.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667049);
			BitSet.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667050);
			BitSet.NativeMethodInfoPtr_Set_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667051);
			BitSet.NativeMethodInfoPtr_Get_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667052);
			BitSet.NativeMethodInfoPtr_NextSet_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667053);
			BitSet.NativeMethodInfoPtr_And_Public_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667054);
			BitSet.NativeMethodInfoPtr_Or_Public_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667055);
			BitSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667056);
			BitSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667057);
			BitSet.NativeMethodInfoPtr_Clone_Public_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667058);
			BitSet.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667059);
			BitSet.NativeMethodInfoPtr_Intersects_Public_Boolean_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667060);
			BitSet.NativeMethodInfoPtr_Subscript_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667061);
			BitSet.NativeMethodInfoPtr_EnsureLength_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100667062);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0007D11C File Offset: 0x0007B31C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0007D158 File Offset: 0x0007B358
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 391697, RefRangeEnd = 391706, XrefRangeStart = 391692, XrefRangeEnd = 391697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet(int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0007D1A0 File Offset: 0x0007B3A0
		public unsafe int Count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C3 RID: 1987
		public unsafe bool this[int index]
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 391706, RefRangeEnd = 391722, XrefRangeStart = 391706, XrefRangeEnd = 391706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0007D228 File Offset: 0x0007B428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391722, RefRangeEnd = 391724, XrefRangeStart = 391722, XrefRangeEnd = 391722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0007D25C File Offset: 0x0007B45C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 391725, RefRangeEnd = 391730, XrefRangeStart = 391724, XrefRangeEnd = 391725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Set_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0007D29C File Offset: 0x0007B49C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 391706, RefRangeEnd = 391722, XrefRangeStart = 391706, XrefRangeEnd = 391722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Get_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0007D2E8 File Offset: 0x0007B4E8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 391730, RefRangeEnd = 391754, XrefRangeStart = 391730, XrefRangeEnd = 391730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NextSet(int startFrom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startFrom;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_NextSet_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0007D334 File Offset: 0x0007B534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391754, RefRangeEnd = 391755, XrefRangeStart = 391754, XrefRangeEnd = 391754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void And(BitSet other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_And_Public_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0007D378 File Offset: 0x0007B578
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 391756, RefRangeEnd = 391763, XrefRangeStart = 391755, XrefRangeEnd = 391756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Or(BitSet other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Or_Public_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0007D3BC File Offset: 0x0007B5BC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0007D3F8 File Offset: 0x0007B5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391763, XrefRangeEnd = 391764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0007D448 File Offset: 0x0007B648
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 391776, RefRangeEnd = 391781, XrefRangeStart = 391764, XrefRangeEnd = 391776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Clone_Public_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0007D488 File Offset: 0x0007B688
		public unsafe bool IsEmpty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 391782, RefRangeEnd = 391783, XrefRangeStart = 391781, XrefRangeEnd = 391782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0007D4C4 File Offset: 0x0007B6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391787, RefRangeEnd = 391788, XrefRangeStart = 391783, XrefRangeEnd = 391787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects(BitSet other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Intersects_Public_Boolean_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0007D514 File Offset: 0x0007B714
		[CallerCount(0)]
		public unsafe int Subscript(int bitIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Subscript_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0007D560 File Offset: 0x0007B760
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 391793, RefRangeEnd = 391808, XrefRangeStart = 391788, XrefRangeEnd = 391793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLength(int nRequiredLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nRequiredLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_EnsureLength_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0000A425 File Offset: 0x00008625
		public BitSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0007D5A0 File Offset: 0x0007B7A0
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x0000A42E File Offset: 0x0000862E
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x0007D5C8 File Offset: 0x0007B7C8
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x0000A449 File Offset: 0x00008649
		public unsafe Il2CppStructArray<uint> bits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_bits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_bits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr_bits;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Boolean_Int32_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_NextSet_Public_Int32_Int32_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Void_BitSet_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Void_BitSet_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_BitSet_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_BitSet_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_Subscript_Private_Int32_Int32_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLength_Private_Void_Int32_0;
	}
}
