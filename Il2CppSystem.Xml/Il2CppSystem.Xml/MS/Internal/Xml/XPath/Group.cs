using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000202 RID: 514
	public class Group : AstNode
	{
		// Token: 0x06002D3C RID: 11580 RVA: 0x000D0558 File Offset: 0x000CE758
		// Note: this type is marked as 'beforefieldinit'.
		static Group()
		{
			Il2CppClassPointerStore<Group>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Group");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Group>.NativeClassPtr);
			Group.NativeFieldInfoPtr__groupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_groupNode");
			Group.NativeMethodInfoPtr__ctor_Public_Void_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100669833);
			Group.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100669834);
			Group.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100669835);
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x000D05D8 File Offset: 0x000CE7D8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group(AstNode groupNode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Group>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr__ctor_Public_Void_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000D0624 File Offset: 0x000CE824
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40756, RefRangeEnd = 40759, XrefRangeStart = 40756, XrefRangeEnd = 40759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Group.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000D066C File Offset: 0x000CE86C
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Group.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x00012AB3 File Offset: 0x00010CB3
		public Group(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x000D06B4 File Offset: 0x000CE8B4
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00012ABC File Offset: 0x00010CBC
		public unsafe AstNode _groupNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__groupNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__groupNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr__groupNode;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AstNode_0;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;
	}
}
