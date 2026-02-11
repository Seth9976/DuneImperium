using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000119 RID: 281
	public class NamespaceListNode : SyntaxTreeNode
	{
		// Token: 0x060018E2 RID: 6370 RVA: 0x0007FF18 File Offset: 0x0007E118
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceListNode()
		{
			Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NamespaceListNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr);
			NamespaceListNode.NativeFieldInfoPtr_namespaceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, "namespaceList");
			NamespaceListNode.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, "particle");
			NamespaceListNode.NativeMethodInfoPtr__ctor_Public_Void_NamespaceList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100667139);
			NamespaceListNode.NativeMethodInfoPtr_GetResolvedSymbols_Public_Virtual_New_ICollection_SymbolsDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100667140);
			NamespaceListNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100667141);
			NamespaceListNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100667142);
			NamespaceListNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100667143);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0007FFD4 File Offset: 0x0007E1D4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceListNode(NamespaceList namespaceList, Object particle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namespaceList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceListNode.NativeMethodInfoPtr__ctor_Public_Void_NamespaceList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00080034 File Offset: 0x0007E234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392255, XrefRangeEnd = 392257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_GetResolvedSymbols_Public_Virtual_New_ICollection_SymbolsDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00080090 File Offset: 0x0007E290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392257, XrefRangeEnd = 392291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00080104 File Offset: 0x0007E304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392291, XrefRangeEnd = 392296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructPos(BitSet firstpos, BitSet lastpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00080178 File Offset: 0x0007E378
		public unsafe override bool IsNullable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392296, XrefRangeEnd = 392301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0000AA77 File Offset: 0x00008C77
		public NamespaceListNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x000801C0 File Offset: 0x0007E3C0
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000AA80 File Offset: 0x00008C80
		public unsafe NamespaceList namespaceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_namespaceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_namespaceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x000801F0 File Offset: 0x0007E3F0
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0000AA9F File Offset: 0x00008C9F
		public unsafe Object particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr_namespaceList;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NamespaceList_Object_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_GetResolvedSymbols_Public_Virtual_New_ICollection_SymbolsDictionary_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;
	}
}
