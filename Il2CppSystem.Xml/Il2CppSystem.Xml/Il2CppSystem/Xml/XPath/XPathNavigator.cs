using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x020000AF RID: 175
	public class XPathNavigator : XPathItem
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x000662AC File Offset: 0x000644AC
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNavigator()
		{
			Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr);
			XPathNavigator.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "comparer");
			XPathNavigator.NativeFieldInfoPtr_NodeTypeLetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "NodeTypeLetter");
			XPathNavigator.NativeFieldInfoPtr_UniqueIdTbl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "UniqueIdTbl");
			XPathNavigator.NativeFieldInfoPtr_ContentKindMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "ContentKindMasks");
			XPathNavigator.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666292);
			XPathNavigator.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666293);
			XPathNavigator.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666294);
			XPathNavigator.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666295);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666296);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666297);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666298);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666299);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666300);
			XPathNavigator.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666301);
			XPathNavigator.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666302);
			XPathNavigator.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666303);
			XPathNavigator.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666304);
			XPathNavigator.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666305);
			XPathNavigator.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666306);
			XPathNavigator.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666307);
			XPathNavigator.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666308);
			XPathNavigator.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666309);
			XPathNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666310);
			XPathNavigator.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666311);
			XPathNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666312);
			XPathNavigator.NativeMethodInfoPtr_MoveToNamespace_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666313);
			XPathNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666314);
			XPathNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666315);
			XPathNavigator.NativeMethodInfoPtr_MoveToParent_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666316);
			XPathNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Abstract_Virtual_New_Boolean_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666317);
			XPathNavigator.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666318);
			XPathNavigator.NativeMethodInfoPtr_IsText_Internal_Static_Boolean_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666319);
			XPathNavigator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100666320);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00066570 File Offset: 0x00064770
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000665B4 File Offset: 0x000647B4
		public unsafe override XmlSchemaType XmlType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383412, XrefRangeEnd = 383419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00066600 File Offset: 0x00064800
		public unsafe override Object TypedValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383419, XrefRangeEnd = 383434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0006664C File Offset: 0x0006484C
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383434, XrefRangeEnd = 383448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00066698 File Offset: 0x00064898
		public unsafe override bool ValueAsBoolean
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383448, XrefRangeEnd = 383466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000666E0 File Offset: 0x000648E0
		public unsafe override DateTime ValueAsDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383466, XrefRangeEnd = 383484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00066728 File Offset: 0x00064928
		public unsafe override double ValueAsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383484, XrefRangeEnd = 383502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00066770 File Offset: 0x00064970
		public unsafe override int ValueAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383502, XrefRangeEnd = 383520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x000667B8 File Offset: 0x000649B8
		public unsafe override long ValueAsLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383520, XrefRangeEnd = 383538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00066800 File Offset: 0x00064A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383538, XrefRangeEnd = 383552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00066870 File Offset: 0x00064A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383552, XrefRangeEnd = 383557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigator.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x000668B0 File Offset: 0x00064AB0
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x000668FC File Offset: 0x00064AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383557, XrefRangeEnd = 383562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00066950 File Offset: 0x00064B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383562, XrefRangeEnd = 383576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupPrefix(string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000669A4 File Offset: 0x00064BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383576, XrefRangeEnd = 383592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x000669FC File Offset: 0x00064BFC
		[CallerCount(0)]
		public unsafe virtual XPathNavigator Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_XPathNavigator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNavigator>(intPtr3) : null;
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00066A48 File Offset: 0x00064C48
		public unsafe virtual XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XPathNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00066A90 File Offset: 0x00064C90
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00066AD4 File Offset: 0x00064CD4
		public unsafe virtual string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00066B18 File Offset: 0x00064D18
		public unsafe virtual string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00066B5C File Offset: 0x00064D5C
		public unsafe virtual Object UnderlyingObject
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00066BA8 File Offset: 0x00064DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383592, XrefRangeEnd = 383593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveToNamespace(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToNamespace_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00066C00 File Offset: 0x00064E00
		[CallerCount(0)]
		public unsafe virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceScope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00066C54 File Offset: 0x00064E54
		[CallerCount(0)]
		public unsafe virtual bool MoveToNextNamespace(XPathNamespaceScope namespaceScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceScope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00066CA8 File Offset: 0x00064EA8
		[CallerCount(0)]
		public unsafe virtual bool MoveToParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToParent_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00066CF0 File Offset: 0x00064EF0
		[CallerCount(0)]
		public unsafe virtual bool IsSamePosition(XPathNavigator other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Abstract_Virtual_New_Boolean_XPathNavigator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00066D48 File Offset: 0x00064F48
		public unsafe virtual IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383593, XrefRangeEnd = 383596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00066D94 File Offset: 0x00064F94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383596, RefRangeEnd = 383598, XrefRangeStart = 383596, XrefRangeEnd = 383596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsText(XPathNodeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigator.NativeMethodInfoPtr_IsText_Internal_Static_Boolean_XPathNodeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00066DD4 File Offset: 0x00064FD4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathNavigator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00007B6E File Offset: 0x00005D6E
		public XPathNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00066E10 File Offset: 0x00065010
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x00007B77 File Offset: 0x00005D77
		public unsafe static XPathNavigatorKeyComparer comparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_comparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNavigatorKeyComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00066E38 File Offset: 0x00065038
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x00007B89 File Offset: 0x00005D89
		public unsafe static Il2CppStructArray<char> NodeTypeLetter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_NodeTypeLetter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_NodeTypeLetter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00066E60 File Offset: 0x00065060
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x00007B9B File Offset: 0x00005D9B
		public unsafe static Il2CppStructArray<char> UniqueIdTbl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_UniqueIdTbl, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_UniqueIdTbl, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x00066E88 File Offset: 0x00065088
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x00007BAD File Offset: 0x00005DAD
		public unsafe static Il2CppStructArray<int> ContentKindMasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_ContentKindMasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_ContentKindMasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeFieldInfoPtr_NodeTypeLetter;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeFieldInfoPtr_UniqueIdTbl;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeFieldInfoPtr_ContentKindMasks;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_XPathNavigator_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XPathNodeType_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_New_get_Object_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNamespace_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_IsSamePosition_Public_Abstract_Virtual_New_Boolean_XPathNavigator_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_IsText_Internal_Static_Boolean_XPathNodeType_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
