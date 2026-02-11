using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000117 RID: 279
	public class SyntaxTreeNode : Object
	{
		// Token: 0x060018D1 RID: 6353 RVA: 0x0007F9F8 File Offset: 0x0007DBF8
		// Note: this type is marked as 'beforefieldinit'.
		static SyntaxTreeNode()
		{
			Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SyntaxTreeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr);
			SyntaxTreeNode.NativeMethodInfoPtr_ExpandTree_Public_Abstract_Virtual_New_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100667128);
			SyntaxTreeNode.NativeMethodInfoPtr_ConstructPos_Public_Abstract_Virtual_New_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100667129);
			SyntaxTreeNode.NativeMethodInfoPtr_get_IsNullable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100667130);
			SyntaxTreeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100667131);
			SyntaxTreeNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100667132);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0007FA8C File Offset: 0x0007DC8C
		[CallerCount(0)]
		public unsafe virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_ExpandTree_Public_Abstract_Virtual_New_Void_InteriorNode_SymbolsDictionary_Positions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0007FB00 File Offset: 0x0007DD00
		[CallerCount(0)]
		public unsafe virtual void ConstructPos(BitSet firstpos, BitSet lastpos, Il2CppReferenceArray<BitSet> followpos)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_ConstructPos_Public_Abstract_Virtual_New_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0007FB74 File Offset: 0x0007DD74
		public unsafe virtual bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_get_IsNullable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0007FBBC File Offset: 0x0007DDBC
		public unsafe virtual bool IsRangeNode
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0007FC04 File Offset: 0x0007DE04
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyntaxTreeNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxTreeNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0000AA4A File Offset: 0x00008C4A
		public SyntaxTreeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Abstract_Virtual_New_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Abstract_Virtual_New_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
