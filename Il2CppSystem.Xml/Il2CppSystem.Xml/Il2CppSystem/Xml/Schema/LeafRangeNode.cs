using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000120 RID: 288
	public sealed class LeafRangeNode : LeafNode
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x00080D78 File Offset: 0x0007EF78
		// Note: this type is marked as 'beforefieldinit'.
		static LeafRangeNode()
		{
			Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "LeafRangeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr);
			LeafRangeNode.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "min");
			LeafRangeNode.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "max");
			LeafRangeNode.NativeFieldInfoPtr_nextIteration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "nextIteration");
			LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667170);
			LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667171);
			LeafRangeNode.NativeMethodInfoPtr_get_Max_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667172);
			LeafRangeNode.NativeMethodInfoPtr_get_Min_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667173);
			LeafRangeNode.NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667174);
			LeafRangeNode.NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667175);
			LeafRangeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667176);
			LeafRangeNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100667177);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00080E84 File Offset: 0x0007F084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392434, XrefRangeEnd = 392435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeafRangeNode(Decimal min, Decimal max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00080EDC File Offset: 0x0007F0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392435, XrefRangeEnd = 392436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeafRangeNode(int pos, Decimal min, Decimal max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00080F40 File Offset: 0x0007F140
		public unsafe Decimal Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_Max_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x00080F7C File Offset: 0x0007F17C
		public unsafe Decimal Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_Min_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x00080FB8 File Offset: 0x0007F1B8
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x00080FF8 File Offset: 0x0007F1F8
		public unsafe BitSet NextIteration
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0008103C File Offset: 0x0007F23C
		public unsafe override bool IsRangeNode
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00081078 File Offset: 0x0007F278
		[CallerCount(0)]
		public unsafe override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0000AB32 File Offset: 0x00008D32
		public LeafRangeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x000810E0 File Offset: 0x0007F2E0
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0000AB3B File Offset: 0x00008D3B
		public unsafe Decimal min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x00081108 File Offset: 0x0007F308
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x0000AB56 File Offset: 0x00008D56
		public unsafe Decimal max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00081130 File Offset: 0x0007F330
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x0000AB71 File Offset: 0x00008D71
		public unsafe BitSet nextIteration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_nextIteration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_nextIteration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeFieldInfoPtr_nextIteration;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decimal_Decimal_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Decimal_Decimal_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_get_Decimal_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Decimal_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_get_Boolean_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;
	}
}
