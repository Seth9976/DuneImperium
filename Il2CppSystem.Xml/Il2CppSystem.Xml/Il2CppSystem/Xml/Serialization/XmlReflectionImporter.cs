using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DD RID: 221
	public class XmlReflectionImporter : Object
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x0006D1FC File Offset: 0x0006B3FC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReflectionImporter()
		{
			Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlReflectionImporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr);
			XmlReflectionImporter.NativeFieldInfoPtr_initialDefaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "initialDefaultNamespace");
			XmlReflectionImporter.NativeFieldInfoPtr_attributeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "attributeOverrides");
			XmlReflectionImporter.NativeFieldInfoPtr_includedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "includedTypes");
			XmlReflectionImporter.NativeFieldInfoPtr_helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "helper");
			XmlReflectionImporter.NativeFieldInfoPtr_arrayChoiceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "arrayChoiceCount");
			XmlReflectionImporter.NativeFieldInfoPtr_relatedMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "relatedMaps");
			XmlReflectionImporter.NativeFieldInfoPtr_allowPrivateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "allowPrivateTypes");
			XmlReflectionImporter.NativeFieldInfoPtr_errSimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "errSimple");
			XmlReflectionImporter.NativeFieldInfoPtr_errSimple2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "errSimple2");
			XmlReflectionImporter.NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666514);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666515);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666516);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666517);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666518);
			XmlReflectionImporter.NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666519);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666520);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666521);
			XmlReflectionImporter.NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666522);
			XmlReflectionImporter.NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666523);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666524);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666525);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666526);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666527);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666528);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666529);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666530);
			XmlReflectionImporter.NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666531);
			XmlReflectionImporter.NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666532);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666533);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666534);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666535);
			XmlReflectionImporter.NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666536);
			XmlReflectionImporter.NativeMethodInfoPtr_IncludeType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666537);
			XmlReflectionImporter.NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666538);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0006D4D4 File Offset: 0x0006B6D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385863, RefRangeEnd = 385865, XrefRangeStart = 385839, XrefRangeEnd = 385863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeOverrides);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0006D534 File Offset: 0x0006B734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385865, XrefRangeEnd = 385866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0006D584 File Offset: 0x0006B784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385866, XrefRangeEnd = 385867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0006D5E8 File Offset: 0x0006B7E8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 385898, RefRangeEnd = 385917, XrefRangeStart = 385867, XrefRangeEnd = 385898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0006D65C File Offset: 0x0006B85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385953, RefRangeEnd = 385954, XrefRangeStart = 385917, XrefRangeEnd = 385953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0006D6D0 File Offset: 0x0006B8D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 386007, RefRangeEnd = 386015, XrefRangeStart = 385954, XrefRangeEnd = 386007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultXmlType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0006D758 File Offset: 0x0006B958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386020, RefRangeEnd = 386022, XrefRangeStart = 386015, XrefRangeEnd = 386020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBaseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0006D7DC File Offset: 0x0006B9DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386199, RefRangeEnd = 386201, XrefRangeStart = 386022, XrefRangeEnd = 386199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBaseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0006D860 File Offset: 0x0006BA60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 386209, RefRangeEnd = 386212, XrefRangeStart = 386201, XrefRangeEnd = 386209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0006D8B4 File Offset: 0x0006BAB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 386221, RefRangeEnd = 386228, XrefRangeStart = 386212, XrefRangeEnd = 386221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0006D920 File Offset: 0x0006BB20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 386233, RefRangeEnd = 386236, XrefRangeStart = 386228, XrefRangeEnd = 386233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestingLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0006D9B8 File Offset: 0x0006BBB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386375, RefRangeEnd = 386377, XrefRangeStart = 386236, XrefRangeEnd = 386375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestingLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0006DA50 File Offset: 0x0006BC50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386403, RefRangeEnd = 386404, XrefRangeStart = 386377, XrefRangeEnd = 386403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0006DAC4 File Offset: 0x0006BCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386404, XrefRangeEnd = 386409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0006DB38 File Offset: 0x0006BD38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386477, RefRangeEnd = 386478, XrefRangeStart = 386409, XrefRangeEnd = 386477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0006DBAC File Offset: 0x0006BDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386478, XrefRangeEnd = 386487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0006DC20 File Offset: 0x0006BE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386487, XrefRangeEnd = 386498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportIncludedTypes(Type type, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0006DC74 File Offset: 0x0006BE74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386601, RefRangeEnd = 386602, XrefRangeStart = 386498, XrefRangeEnd = 386601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<XmlReflectionMember> GetReflectionMembers(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<XmlReflectionMember>>(intPtr3) : null;
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0006DCC4 File Offset: 0x0006BEC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386753, RefRangeEnd = 386754, XrefRangeStart = 386602, XrefRangeEnd = 386753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rmember);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr3) : null;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0006DD38 File Offset: 0x0006BF38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386856, RefRangeEnd = 386858, XrefRangeStart = 386754, XrefRangeEnd = 386856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cls);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386907, RefRangeEnd = 386908, XrefRangeStart = 386858, XrefRangeEnd = 386907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rmember);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0006DE70 File Offset: 0x0006C070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386943, RefRangeEnd = 386945, XrefRangeStart = 386908, XrefRangeEnd = 386943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0006DEFC File Offset: 0x0006C0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386945, XrefRangeEnd = 386946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeNull(TypeData type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0006DF4C File Offset: 0x0006C14C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386980, RefRangeEnd = 386982, XrefRangeStart = 386946, XrefRangeEnd = 386980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncludeType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_IncludeType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0006DF90 File Offset: 0x0006C190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386982, XrefRangeEnd = 386996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetDefaultValue(TypeData typeData, Object defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00008A87 File Offset: 0x00006C87
		public XmlReflectionImporter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0006DFF4 File Offset: 0x0006C1F4
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x00008A90 File Offset: 0x00006C90
		public unsafe string initialDefaultNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_initialDefaultNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_initialDefaultNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0006E01C File Offset: 0x0006C21C
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x00008AAF File Offset: 0x00006CAF
		public unsafe XmlAttributeOverrides attributeOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_attributeOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributeOverrides>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_attributeOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0006E04C File Offset: 0x0006C24C
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x00008ACE File Offset: 0x00006CCE
		public unsafe ArrayList includedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_includedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_includedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0006E07C File Offset: 0x0006C27C
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00008AED File Offset: 0x00006CED
		public unsafe ReflectionHelper helper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_helper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_helper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0006E0AC File Offset: 0x0006C2AC
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00008B0C File Offset: 0x00006D0C
		public unsafe int arrayChoiceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_arrayChoiceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_arrayChoiceCount)) = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x00008B27 File Offset: 0x00006D27
		public unsafe ArrayList relatedMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_relatedMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_relatedMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0006E104 File Offset: 0x0006C304
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x00008B46 File Offset: 0x00006D46
		public unsafe bool allowPrivateTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_allowPrivateTypes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_allowPrivateTypes)) = value;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0006E12C File Offset: 0x0006C32C
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x00008B61 File Offset: 0x00006D61
		public unsafe static string errSimple
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0006E14C File Offset: 0x0006C34C
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x00008B73 File Offset: 0x00006D73
		public unsafe static string errSimple2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr_initialDefaultNamespace;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr_attributeOverrides;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeFieldInfoPtr_includedTypes;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeFieldInfoPtr_helper;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr_arrayChoiceCount;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeFieldInfoPtr_relatedMaps;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeFieldInfoPtr_allowPrivateTypes;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeFieldInfoPtr_errSimple;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_errSimple2;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_IncludeType_Public_Void_Type_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0;

		// Token: 0x02000249 RID: 585
		[ObfuscatedName("System.Xml.Serialization.XmlReflectionImporter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060030CD RID: 12493 RVA: 0x000DB304 File Offset: 0x000D9504
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr);
				XmlReflectionImporter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, "<>9");
				XmlReflectionImporter.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, "<>9__28_0");
				XmlReflectionImporter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, 100666541);
				XmlReflectionImporter.__c.NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, 100666542);
			}

			// Token: 0x060030CE RID: 12494 RVA: 0x000DB380 File Offset: 0x000D9580
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030CF RID: 12495 RVA: 0x000DB3BC File Offset: 0x000D95BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385827, XrefRangeEnd = 385839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ImportClassMapping_b__28_0(XmlReflectionMember m1, XmlReflectionMember m2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.__c.NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060030D0 RID: 12496 RVA: 0x00014926 File Offset: 0x00012B26
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001069 RID: 4201
			// (get) Token: 0x060030D1 RID: 12497 RVA: 0x000DB41C File Offset: 0x000D961C
			// (set) Token: 0x060030D2 RID: 12498 RVA: 0x0001492F File Offset: 0x00012B2F
			public unsafe static XmlReflectionImporter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReflectionImporter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106A RID: 4202
			// (get) Token: 0x060030D3 RID: 12499 RVA: 0x000DB444 File Offset: 0x000D9644
			// (set) Token: 0x060030D4 RID: 12500 RVA: 0x00014941 File Offset: 0x00012B41
			public unsafe static Comparison<XmlReflectionMember> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<XmlReflectionMember>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025E0 RID: 9696
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040025E1 RID: 9697
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040025E2 RID: 9698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040025E3 RID: 9699
			private static readonly IntPtr NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0;
		}
	}
}
