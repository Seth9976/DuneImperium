using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FF RID: 255
	public class XElementWrapper : XContainerWrapper
	{
		// Token: 0x06001504 RID: 5380 RVA: 0x00072AC0 File Offset: 0x00070CC0
		// Note: this type is marked as 'beforefieldinit'.
		static XElementWrapper()
		{
			Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XElementWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr);
			XElementWrapper.NativeFieldInfoPtr__attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, "_attributes");
			XElementWrapper.NativeMethodInfoPtr_get_Element_Private_get_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667290);
			XElementWrapper.NativeMethodInfoPtr__ctor_Public_Void_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667291);
			XElementWrapper.NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_Final_New_Void_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667292);
			XElementWrapper.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667293);
			XElementWrapper.NativeMethodInfoPtr_HasImplicitNamespaceAttribute_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667294);
			XElementWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667295);
			XElementWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667296);
			XElementWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667297);
			XElementWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667298);
			XElementWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667299);
			XElementWrapper.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667300);
			XElementWrapper.NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr, 100667301);
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x00072BF4 File Offset: 0x00070DF4
		public unsafe XElement Element
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 765643, RefRangeEnd = 765646, XrefRangeStart = 765641, XrefRangeEnd = 765643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElementWrapper.NativeMethodInfoPtr_get_Element_Private_get_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00072C34 File Offset: 0x00070E34
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XElementWrapper(XElement element)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XElementWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElementWrapper.NativeMethodInfoPtr__ctor_Public_Void_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00072C80 File Offset: 0x00070E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765646, XrefRangeEnd = 765655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAttributeNode(IXmlNode attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElementWrapper.NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_Final_New_Void_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00072CC4 File Offset: 0x00070EC4
		public unsafe override List<IXmlNode> Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765655, XrefRangeEnd = 765674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementWrapper.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_List_1_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00072D10 File Offset: 0x00070F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765710, RefRangeEnd = 765711, XrefRangeStart = 765674, XrefRangeEnd = 765710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasImplicitNamespaceAttribute(string namespaceUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElementWrapper.NativeMethodInfoPtr_HasImplicitNamespaceAttribute_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00072D60 File Offset: 0x00070F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765711, XrefRangeEnd = 765713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IXmlNode AppendChild(IXmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00072DBC File Offset: 0x00070FBC
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x00072E00 File Offset: 0x00071000
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765713, XrefRangeEnd = 765718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765718, XrefRangeEnd = 765725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00072E50 File Offset: 0x00071050
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765725, XrefRangeEnd = 765727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x00072E94 File Offset: 0x00071094
		public unsafe override string NamespaceUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765727, XrefRangeEnd = 765732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00072ED8 File Offset: 0x000710D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765732, XrefRangeEnd = 765739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetPrefixOfNamespace(string namespaceUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElementWrapper.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x00072F20 File Offset: 0x00071120
		public unsafe virtual bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765739, XrefRangeEnd = 765744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElementWrapper.NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000084D0 File Offset: 0x000066D0
		public XElementWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00072F5C File Offset: 0x0007115C
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x000084D9 File Offset: 0x000066D9
		public unsafe List<IXmlNode> _attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElementWrapper.NativeFieldInfoPtr__attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElementWrapper.NativeFieldInfoPtr__attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr__attributes;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_get_Element_Private_get_XElement_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XElement_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_Final_New_Void_IXmlNode_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_List_1_IXmlNode_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_HasImplicitNamespaceAttribute_Private_Boolean_String_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_get_String_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_Final_New_String_String_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0;
	}
}
