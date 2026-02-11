using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FD RID: 253
	public class XObjectWrapper : Object
	{
		// Token: 0x060014EC RID: 5356 RVA: 0x00072390 File Offset: 0x00070590
		// Note: this type is marked as 'beforefieldinit'.
		static XObjectWrapper()
		{
			Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XObjectWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr);
			XObjectWrapper.NativeFieldInfoPtr__xmlObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, "_xmlObject");
			XObjectWrapper.NativeMethodInfoPtr__ctor_Public_Void_XObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667272);
			XObjectWrapper.NativeMethodInfoPtr_get_WrappedNode_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667273);
			XObjectWrapper.NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667274);
			XObjectWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667275);
			XObjectWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667276);
			XObjectWrapper.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667277);
			XObjectWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667278);
			XObjectWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667279);
			XObjectWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667280);
			XObjectWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_New_IXmlNode_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667281);
			XObjectWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr, 100667282);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000724B0 File Offset: 0x000706B0
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XObjectWrapper(XObject xmlObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XObjectWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObjectWrapper.NativeMethodInfoPtr__ctor_Public_Void_XObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000724FC File Offset: 0x000706FC
		public unsafe virtual Object WrappedNode
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObjectWrapper.NativeMethodInfoPtr_get_WrappedNode_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0007253C File Offset: 0x0007073C
		public unsafe virtual XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00072584 File Offset: 0x00070784
		public unsafe virtual string LocalName
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000725C8 File Offset: 0x000707C8
		public unsafe virtual List<IXmlNode> ChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765598, XrefRangeEnd = 765602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_List_1_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00072614 File Offset: 0x00070814
		public unsafe virtual List<IXmlNode> Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765602, XrefRangeEnd = 765606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_List_1_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00072660 File Offset: 0x00070860
		public unsafe virtual IXmlNode ParentNode
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x000726AC File Offset: 0x000708AC
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x000726F0 File Offset: 0x000708F0
		public unsafe virtual string Value
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765606, XrefRangeEnd = 765611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00072740 File Offset: 0x00070940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765611, XrefRangeEnd = 765616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_New_IXmlNode_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0007279C File Offset: 0x0007099C
		public unsafe virtual string NamespaceUri
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObjectWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0000849F File Offset: 0x0000669F
		public XObjectWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000727E0 File Offset: 0x000709E0
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x000084A8 File Offset: 0x000066A8
		public unsafe XObject _xmlObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectWrapper.NativeFieldInfoPtr__xmlObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectWrapper.NativeFieldInfoPtr__xmlObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr__xmlObject;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XObject_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_get_WrappedNode_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_XmlNodeType_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_New_get_String_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_List_1_IXmlNode_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_List_1_IXmlNode_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_IXmlNode_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_New_IXmlNode_IXmlNode_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_New_get_String_0;
	}
}
