using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000073 RID: 115
	[DefaultMember("Item")]
	public class XmlNode : Object
	{
		// Token: 0x06000DDD RID: 3549 RVA: 0x0005262C File Offset: 0x0005082C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNode()
		{
			Il2CppClassPointerStore<XmlNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNode>.NativeClassPtr);
			XmlNode.NativeFieldInfoPtr_parentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, "parentNode");
			XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665566);
			XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665567);
			XmlNode.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665568);
			XmlNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665569);
			XmlNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665570);
			XmlNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665571);
			XmlNode.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665572);
			XmlNode.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_XmlNodeList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665573);
			XmlNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665574);
			XmlNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665575);
			XmlNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_XmlAttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665576);
			XmlNode.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_New_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665577);
			XmlNode.NativeMethodInfoPtr_get_FirstChild_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665578);
			XmlNode.NativeMethodInfoPtr_get_LastChild_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665579);
			XmlNode.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665580);
			XmlNode.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_New_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665581);
			XmlNode.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_New_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665582);
			XmlNode.NativeMethodInfoPtr_AncestorNode_Internal_Boolean_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665583);
			XmlNode.NativeMethodInfoPtr_InsertBefore_Public_Virtual_New_XmlNode_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665584);
			XmlNode.NativeMethodInfoPtr_InsertAfter_Public_Virtual_New_XmlNode_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665585);
			XmlNode.NativeMethodInfoPtr_RemoveChild_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665586);
			XmlNode.NativeMethodInfoPtr_PrependChild_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665587);
			XmlNode.NativeMethodInfoPtr_AppendChild_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665588);
			XmlNode.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665589);
			XmlNode.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_New_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665590);
			XmlNode.NativeMethodInfoPtr_CanInsertBefore_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665591);
			XmlNode.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665592);
			XmlNode.NativeMethodInfoPtr_get_HasChildNodes_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665593);
			XmlNode.NativeMethodInfoPtr_CloneNode_Public_Abstract_Virtual_New_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665594);
			XmlNode.NativeMethodInfoPtr_CopyChildren_Internal_Virtual_New_Void_XmlDocument_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665595);
			XmlNode.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665596);
			XmlNode.NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665597);
			XmlNode.NativeMethodInfoPtr_set_Prefix_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665598);
			XmlNode.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665599);
			XmlNode.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665600);
			XmlNode.NativeMethodInfoPtr_HasReadOnlyParent_Internal_Static_Boolean_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665601);
			XmlNode.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665602);
			XmlNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665603);
			XmlNode.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665604);
			XmlNode.NativeMethodInfoPtr_AppendChildText_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665605);
			XmlNode.NativeMethodInfoPtr_get_InnerText_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665606);
			XmlNode.NativeMethodInfoPtr_set_InnerText_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665607);
			XmlNode.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665608);
			XmlNode.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665609);
			XmlNode.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665610);
			XmlNode.NativeMethodInfoPtr_WriteTo_Public_Abstract_Virtual_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665611);
			XmlNode.NativeMethodInfoPtr_WriteContentTo_Public_Abstract_Virtual_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665612);
			XmlNode.NativeMethodInfoPtr_RemoveAll_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665613);
			XmlNode.NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665614);
			XmlNode.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665615);
			XmlNode.NativeMethodInfoPtr_GetPrefixOfNamespaceStrict_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665616);
			XmlNode.NativeMethodInfoPtr_SetParent_Internal_Virtual_New_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665617);
			XmlNode.NativeMethodInfoPtr_SetParentForLoad_Internal_Virtual_New_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665618);
			XmlNode.NativeMethodInfoPtr_SplitName_Internal_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665619);
			XmlNode.NativeMethodInfoPtr_FindChild_Internal_Virtual_New_XmlNode_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665620);
			XmlNode.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_New_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665621);
			XmlNode.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665622);
			XmlNode.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665623);
			XmlNode.NativeMethodInfoPtr_get_XmlSpace_Internal_Virtual_New_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665624);
			XmlNode.NativeMethodInfoPtr_get_XmlLang_Internal_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665625);
			XmlNode.NativeMethodInfoPtr_get_IsText_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665626);
			XmlNode.NativeMethodInfoPtr_NestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665627);
			XmlNode.NativeMethodInfoPtr_UnnestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100665628);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00052B5C File Offset: 0x00050D5C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00052B98 File Offset: 0x00050D98
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 375382, RefRangeEnd = 375396, XrefRangeStart = 375373, XrefRangeEnd = 375382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode(XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00052BE4 File Offset: 0x00050DE4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x00052C28 File Offset: 0x00050E28
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x00052C6C File Offset: 0x00050E6C
		public unsafe virtual string Value
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375396, XrefRangeEnd = 375411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00052CBC File Offset: 0x00050EBC
		public unsafe virtual XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00052D04 File Offset: 0x00050F04
		public unsafe virtual XmlNode ParentNode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 375414, RefRangeEnd = 375416, XrefRangeStart = 375411, XrefRangeEnd = 375414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00052D50 File Offset: 0x00050F50
		public unsafe virtual XmlNodeList ChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375416, XrefRangeEnd = 375420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_XmlNodeList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeList>(intPtr3) : null;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00052D9C File Offset: 0x00050F9C
		public unsafe virtual XmlNode PreviousSibling
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00052DE8 File Offset: 0x00050FE8
		public unsafe virtual XmlNode NextSibling
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00052E34 File Offset: 0x00051034
		public unsafe virtual XmlAttributeCollection Attributes
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_XmlAttributeCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00052E80 File Offset: 0x00051080
		public unsafe virtual XmlDocument OwnerDocument
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375420, XrefRangeEnd = 375422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_New_get_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00052ECC File Offset: 0x000510CC
		public unsafe virtual XmlNode FirstChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_FirstChild_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x00052F18 File Offset: 0x00051118
		public unsafe virtual XmlNode LastChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_LastChild_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00052F64 File Offset: 0x00051164
		public unsafe virtual bool IsContainer
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00052FAC File Offset: 0x000511AC
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x00052FF8 File Offset: 0x000511F8
		public unsafe virtual XmlLinkedNode LastNode
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_New_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr3) : null;
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_New_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00053048 File Offset: 0x00051248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 375422, RefRangeEnd = 375425, XrefRangeStart = 375422, XrefRangeEnd = 375422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AncestorNode(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_AncestorNode_Internal_Boolean_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00053098 File Offset: 0x00051298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375438, RefRangeEnd = 375440, XrefRangeStart = 375425, XrefRangeEnd = 375438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_InsertBefore_Public_Virtual_New_XmlNode_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00053108 File Offset: 0x00051308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375453, RefRangeEnd = 375455, XrefRangeStart = 375440, XrefRangeEnd = 375453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_InsertAfter_Public_Virtual_New_XmlNode_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00053178 File Offset: 0x00051378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375469, RefRangeEnd = 375471, XrefRangeStart = 375455, XrefRangeEnd = 375469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode RemoveChild(XmlNode oldChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_RemoveChild_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000531D4 File Offset: 0x000513D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375471, RefRangeEnd = 375473, XrefRangeStart = 375471, XrefRangeEnd = 375471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode PrependChild(XmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_PrependChild_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00053230 File Offset: 0x00051430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375485, RefRangeEnd = 375487, XrefRangeStart = 375473, XrefRangeEnd = 375485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AppendChild(XmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_AppendChild_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0005328C File Offset: 0x0005148C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375487, XrefRangeEnd = 375495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000532FC File Offset: 0x000514FC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_New_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00053350 File Offset: 0x00051550
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_CanInsertBefore_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000533BC File Offset: 0x000515BC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00053428 File Offset: 0x00051628
		public unsafe virtual bool HasChildNodes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_HasChildNodes_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00053470 File Offset: 0x00051670
		[CallerCount(0)]
		public unsafe virtual XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_CloneNode_Public_Abstract_Virtual_New_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000534C8 File Offset: 0x000516C8
		[CallerCount(0)]
		public unsafe virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_CopyChildren_Internal_Virtual_New_Void_XmlDocument_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00053538 File Offset: 0x00051738
		public unsafe virtual string NamespaceURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375495, XrefRangeEnd = 375497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0005357C File Offset: 0x0005177C
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000535C0 File Offset: 0x000517C0
		public unsafe virtual string Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375497, XrefRangeEnd = 375499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_Prefix_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00053610 File Offset: 0x00051810
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00053654 File Offset: 0x00051854
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375499, XrefRangeEnd = 375502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0005369C File Offset: 0x0005189C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375502, XrefRangeEnd = 375505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasReadOnlyParent(XmlNode n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_HasReadOnlyParent_Internal_Static_Boolean_XmlNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000536E0 File Offset: 0x000518E0
		[CallerCount(0)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00053720 File Offset: 0x00051920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375505, XrefRangeEnd = 375509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00053760 File Offset: 0x00051960
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 375513, RefRangeEnd = 375516, XrefRangeStart = 375509, XrefRangeEnd = 375513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000537A0 File Offset: 0x000519A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375519, RefRangeEnd = 375521, XrefRangeStart = 375516, XrefRangeEnd = 375519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendChildText(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_AppendChildText_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x000537E4 File Offset: 0x000519E4
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x00053828 File Offset: 0x00051A28
		public unsafe virtual string InnerText
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 375528, RefRangeEnd = 375531, XrefRangeStart = 375521, XrefRangeEnd = 375528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_InnerText_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 375532, RefRangeEnd = 375534, XrefRangeStart = 375531, XrefRangeEnd = 375532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_InnerText_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00053878 File Offset: 0x00051A78
		public unsafe virtual string InnerXml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375534, XrefRangeEnd = 375541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x000538C8 File Offset: 0x00051AC8
		public unsafe virtual IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375541, XrefRangeEnd = 375545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00053914 File Offset: 0x00051B14
		public unsafe virtual string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375545, XrefRangeEnd = 375548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00053958 File Offset: 0x00051B58
		[CallerCount(0)]
		public unsafe virtual void WriteTo(XmlWriter w)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_WriteTo_Public_Abstract_Virtual_New_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000539A8 File Offset: 0x00051BA8
		[CallerCount(0)]
		public unsafe virtual void WriteContentTo(XmlWriter w)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_WriteContentTo_Public_Abstract_Virtual_New_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000539F8 File Offset: 0x00051BF8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 375548, RefRangeEnd = 375556, XrefRangeStart = 375548, XrefRangeEnd = 375548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_RemoveAll_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00053A34 File Offset: 0x00051C34
		public unsafe XmlDocument Document
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375556, XrefRangeEnd = 375558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00053A74 File Offset: 0x00051C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375558, XrefRangeEnd = 375561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetPrefixOfNamespace(string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00053AC8 File Offset: 0x00051CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375573, RefRangeEnd = 375574, XrefRangeStart = 375561, XrefRangeEnd = 375573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefixOfNamespaceStrict(string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_GetPrefixOfNamespaceStrict_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00053B10 File Offset: 0x00051D10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375575, RefRangeEnd = 375576, XrefRangeStart = 375574, XrefRangeEnd = 375575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetParent(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_SetParent_Internal_Virtual_New_Void_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00053B60 File Offset: 0x00051D60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetParentForLoad(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_SetParentForLoad_Internal_Virtual_New_Void_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00053BB0 File Offset: 0x00051DB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 375586, RefRangeEnd = 375591, XrefRangeStart = 375576, XrefRangeEnd = 375586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitName(string name, out string prefix, out string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_SplitName_Internal_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			localName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00053C1C File Offset: 0x00051E1C
		[CallerCount(0)]
		public unsafe virtual XmlNode FindChild(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_FindChild_Internal_Virtual_New_XmlNode_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00053C74 File Offset: 0x00051E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375591, XrefRangeEnd = 375592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_New_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventArgs>(intPtr3) : null;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00053D28 File Offset: 0x00051F28
		[CallerCount(0)]
		public unsafe virtual void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00053D78 File Offset: 0x00051F78
		[CallerCount(0)]
		public unsafe virtual void AfterEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00053DC8 File Offset: 0x00051FC8
		public unsafe virtual XmlSpace XmlSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375592, XrefRangeEnd = 375608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_XmlSpace_Internal_Virtual_New_get_XmlSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00053E10 File Offset: 0x00052010
		public unsafe virtual string XmlLang
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375608, XrefRangeEnd = 375615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_XmlLang_Internal_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00053E54 File Offset: 0x00052054
		public unsafe virtual bool IsText
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_IsText_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00053E9C File Offset: 0x0005209C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375617, RefRangeEnd = 375619, XrefRangeStart = 375615, XrefRangeEnd = 375617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_NestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00053EE4 File Offset: 0x000520E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375619, XrefRangeEnd = 375621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_UnnestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000069EE File Offset: 0x00004BEE
		public XmlNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00053F2C File Offset: 0x0005212C
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x000069F7 File Offset: 0x00004BF7
		public unsafe XmlNode parentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNode.NativeFieldInfoPtr_parentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNode.NativeFieldInfoPtr_parentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_parentNode;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_XmlNodeList_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSibling_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_XmlAttributeCollection_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_New_get_XmlDocument_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstChild_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_get_LastChild_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_New_get_XmlLinkedNode_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_New_set_Void_XmlLinkedNode_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_AncestorNode_Internal_Boolean_XmlNode_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_InsertBefore_Public_Virtual_New_XmlNode_XmlNode_XmlNode_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_InsertAfter_Public_Virtual_New_XmlNode_XmlNode_XmlNode_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_PrependChild_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_New_Boolean_XmlNodeType_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_CanInsertBefore_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChildNodes_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Abstract_Virtual_New_XmlNode_Boolean_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_CopyChildren_Internal_Virtual_New_Void_XmlDocument_XmlNode_Boolean_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_New_get_String_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_HasReadOnlyParent_Internal_Static_Boolean_XmlNode_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildText_Private_Void_StringBuilder_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerText_Public_Virtual_New_get_String_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_New_get_String_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Abstract_Virtual_New_Void_XmlWriter_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_WriteContentTo_Public_Abstract_Virtual_New_Void_XmlWriter_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Virtual_New_Void_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_New_String_String_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespaceStrict_Internal_String_String_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Internal_Virtual_New_Void_XmlNode_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_SetParentForLoad_Internal_Virtual_New_Void_XmlNode_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_SplitName_Internal_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_FindChild_Internal_Virtual_New_XmlNode_XmlNodeType_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_New_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_AfterEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Internal_Virtual_New_get_XmlSpace_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Internal_Virtual_New_get_String_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_get_IsText_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_NestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_UnnestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0;
	}
}
