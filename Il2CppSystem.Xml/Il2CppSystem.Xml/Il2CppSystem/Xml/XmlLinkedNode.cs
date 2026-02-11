using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200006E RID: 110
	public class XmlLinkedNode : XmlNode
	{
		// Token: 0x06000D6A RID: 3434 RVA: 0x000504E4 File Offset: 0x0004E6E4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlLinkedNode()
		{
			Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlLinkedNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr);
			XmlLinkedNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, "next");
			XmlLinkedNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, 100665485);
			XmlLinkedNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, 100665486);
			XmlLinkedNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, 100665487);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00050564 File Offset: 0x0004E764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374639, RefRangeEnd = 374640, XrefRangeStart = 374637, XrefRangeEnd = 374639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlLinkedNode(XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLinkedNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000505B0 File Offset: 0x0004E7B0
		public unsafe override XmlNode PreviousSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlLinkedNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000505FC File Offset: 0x0004E7FC
		public unsafe override XmlNode NextSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlLinkedNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000067AF File Offset: 0x000049AF
		public XmlLinkedNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00050648 File Offset: 0x0004E848
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x000067B8 File Offset: 0x000049B8
		public unsafe XmlLinkedNode next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLinkedNode.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLinkedNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_get_XmlNode_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0;
	}
}
