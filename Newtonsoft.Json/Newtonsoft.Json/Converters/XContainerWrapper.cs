using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FC RID: 252
	public class XContainerWrapper : XObjectWrapper
	{
		// Token: 0x060014E1 RID: 5345 RVA: 0x00072084 File Offset: 0x00070284
		// Note: this type is marked as 'beforefieldinit'.
		static XContainerWrapper()
		{
			Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XContainerWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr);
			XContainerWrapper.NativeFieldInfoPtr__childNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, "_childNodes");
			XContainerWrapper.NativeMethodInfoPtr_get_Container_Private_get_XContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, 100667265);
			XContainerWrapper.NativeMethodInfoPtr__ctor_Public_Void_XContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, 100667266);
			XContainerWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, 100667267);
			XContainerWrapper.NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, 100667268);
			XContainerWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, 100667269);
			XContainerWrapper.NativeMethodInfoPtr_WrapNode_Internal_Static_IXmlNode_XObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, 100667270);
			XContainerWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr, 100667271);
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00072154 File Offset: 0x00070354
		public unsafe XContainer Container
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 765481, RefRangeEnd = 765483, XrefRangeStart = 765479, XrefRangeEnd = 765481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainerWrapper.NativeMethodInfoPtr_get_Container_Private_get_XContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XContainer>(intPtr3) : null;
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00072194 File Offset: 0x00070394
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XContainerWrapper(XContainer container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XContainerWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainerWrapper.NativeMethodInfoPtr__ctor_Public_Void_XContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x000721E0 File Offset: 0x000703E0
		public unsafe override List<IXmlNode> ChildNodes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 765516, RefRangeEnd = 765517, XrefRangeStart = 765483, XrefRangeEnd = 765516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainerWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_get_List_1_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0007222C File Offset: 0x0007042C
		public unsafe virtual bool HasChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765517, XrefRangeEnd = 765520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainerWrapper.NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00072274 File Offset: 0x00070474
		public unsafe override IXmlNode ParentNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765520, XrefRangeEnd = 765526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainerWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000722C0 File Offset: 0x000704C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 765583, RefRangeEnd = 765590, XrefRangeStart = 765526, XrefRangeEnd = 765583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IXmlNode WrapNode(XObject node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainerWrapper.NativeMethodInfoPtr_WrapNode_Internal_Static_IXmlNode_XObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00072304 File Offset: 0x00070504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765597, RefRangeEnd = 765598, XrefRangeStart = 765590, XrefRangeEnd = 765597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IXmlNode AppendChild(IXmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainerWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00008477 File Offset: 0x00006677
		public XContainerWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00072360 File Offset: 0x00070560
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x00008480 File Offset: 0x00006680
		public unsafe List<IXmlNode> _childNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainerWrapper.NativeFieldInfoPtr__childNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainerWrapper.NativeFieldInfoPtr__childNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeFieldInfoPtr__childNodes;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Private_get_XContainer_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XContainer_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_get_List_1_IXmlNode_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_WrapNode_Internal_Static_IXmlNode_XObject_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0;
	}
}
