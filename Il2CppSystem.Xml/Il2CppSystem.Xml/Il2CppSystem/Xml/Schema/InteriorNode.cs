using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200011A RID: 282
	public class InteriorNode : SyntaxTreeNode
	{
		// Token: 0x060018ED RID: 6381 RVA: 0x00080220 File Offset: 0x0007E420
		// Note: this type is marked as 'beforefieldinit'.
		static InteriorNode()
		{
			Il2CppClassPointerStore<InteriorNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "InteriorNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr);
			InteriorNode.NativeFieldInfoPtr_leftChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, "leftChild");
			InteriorNode.NativeFieldInfoPtr_rightChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, "rightChild");
			InteriorNode.NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100667144);
			InteriorNode.NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100667145);
			InteriorNode.NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100667146);
			InteriorNode.NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100667147);
			InteriorNode.NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100667148);
			InteriorNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100667149);
			InteriorNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100667150);
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x00080304 File Offset: 0x0007E504
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00080344 File Offset: 0x0007E544
		public unsafe SyntaxTreeNode LeftChild
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00080388 File Offset: 0x0007E588
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x000803C8 File Offset: 0x0007E5C8
		public unsafe SyntaxTreeNode RightChild
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0008040C File Offset: 0x0007E60C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392322, RefRangeEnd = 392324, XrefRangeStart = 392301, XrefRangeEnd = 392322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00080474 File Offset: 0x0007E674
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteriorNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000804E8 File Offset: 0x0007E6E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteriorNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0000AABE File Offset: 0x00008CBE
		public InteriorNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00080524 File Offset: 0x0007E724
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0000AAC7 File Offset: 0x00008CC7
		public unsafe SyntaxTreeNode leftChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_leftChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_leftChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00080554 File Offset: 0x0007E754
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0000AAE6 File Offset: 0x00008CE6
		public unsafe SyntaxTreeNode rightChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_rightChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_rightChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeFieldInfoPtr_leftChild;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeFieldInfoPtr_rightChild;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
