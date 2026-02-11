using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000142 RID: 322
	public class MemberDescriptor : Object
	{
		// Token: 0x060012FA RID: 4858 RVA: 0x0006545C File Offset: 0x0006365C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberDescriptor()
		{
			Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "MemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr);
			MemberDescriptor.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "name");
			MemberDescriptor.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "displayName");
			MemberDescriptor.NativeFieldInfoPtr_nameHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "nameHash");
			MemberDescriptor.NativeFieldInfoPtr_attributeCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "attributeCollection");
			MemberDescriptor.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "attributes");
			MemberDescriptor.NativeFieldInfoPtr_originalAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "originalAttributes");
			MemberDescriptor.NativeFieldInfoPtr_attributesFiltered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "attributesFiltered");
			MemberDescriptor.NativeFieldInfoPtr_attributesFilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "attributesFilled");
			MemberDescriptor.NativeFieldInfoPtr_metadataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "metadataVersion");
			MemberDescriptor.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "category");
			MemberDescriptor.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "description");
			MemberDescriptor.NativeFieldInfoPtr_lockCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "lockCookie");
			MemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666060);
			MemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_MemberDescriptor_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666061);
			MemberDescriptor.NativeMethodInfoPtr_get_AttributeArray_Protected_Virtual_New_get_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666062);
			MemberDescriptor.NativeMethodInfoPtr_set_AttributeArray_Protected_Virtual_New_set_Void_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666063);
			MemberDescriptor.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666064);
			MemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666065);
			MemberDescriptor.NativeMethodInfoPtr_get_NameHashCode_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666066);
			MemberDescriptor.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666067);
			MemberDescriptor.NativeMethodInfoPtr_CheckAttributesValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666068);
			MemberDescriptor.NativeMethodInfoPtr_CreateAttributeCollection_Protected_Virtual_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666069);
			MemberDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666070);
			MemberDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_New_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666071);
			MemberDescriptor.NativeMethodInfoPtr_FilterAttributesIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666072);
			MemberDescriptor.NativeMethodInfoPtr_FindMethod_Protected_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666073);
			MemberDescriptor.NativeMethodInfoPtr_FindMethod_Protected_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666074);
			MemberDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666075);
			MemberDescriptor.NativeMethodInfoPtr_GetInvocationTarget_Protected_Virtual_New_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666076);
			MemberDescriptor.NativeMethodInfoPtr_GetSite_Protected_Static_ISite_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666077);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000656E4 File Offset: 0x000638E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 461261, RefRangeEnd = 461265, XrefRangeStart = 461251, XrefRangeEnd = 461261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberDescriptor(string name, Il2CppReferenceArray<Attribute> attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00065744 File Offset: 0x00063944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461299, RefRangeEnd = 461301, XrefRangeStart = 461265, XrefRangeEnd = 461299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberDescriptor(MemberDescriptor oldMemberDescriptor, Il2CppReferenceArray<Attribute> newAttributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldMemberDescriptor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_MemberDescriptor_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x000657A4 File Offset: 0x000639A4
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x000657F0 File Offset: 0x000639F0
		public unsafe virtual Il2CppReferenceArray<Attribute> AttributeArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461301, XrefRangeEnd = 461303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_get_AttributeArray_Protected_Virtual_New_get_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461303, XrefRangeEnd = 461310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_set_AttributeArray_Protected_Virtual_New_set_Void_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00065840 File Offset: 0x00063A40
		public unsafe virtual AttributeCollection Attributes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 461316, RefRangeEnd = 461319, XrefRangeStart = 461310, XrefRangeEnd = 461316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_AttributeCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0006588C File Offset: 0x00063A8C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461319, XrefRangeEnd = 461320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x000658D0 File Offset: 0x00063AD0
		public unsafe virtual int NameHashCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_get_NameHashCode_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00065918 File Offset: 0x00063B18
		public unsafe virtual string DisplayName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461320, XrefRangeEnd = 461329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0006595C File Offset: 0x00063B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461337, RefRangeEnd = 461339, XrefRangeStart = 461329, XrefRangeEnd = 461337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAttributesValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_CheckAttributesValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00065990 File Offset: 0x00063B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461339, XrefRangeEnd = 461343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AttributeCollection CreateAttributeCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_CreateAttributeCollection_Protected_Virtual_New_AttributeCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000659DC File Offset: 0x00063BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461343, XrefRangeEnd = 461357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00065A34 File Offset: 0x00063C34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 461362, RefRangeEnd = 461365, XrefRangeStart = 461357, XrefRangeEnd = 461362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillAttributes(IList attributeList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_New_Void_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00065A84 File Offset: 0x00063C84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 461419, RefRangeEnd = 461422, XrefRangeStart = 461365, XrefRangeEnd = 461419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterAttributesIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_FilterAttributesIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00065AB8 File Offset: 0x00063CB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461424, RefRangeEnd = 461426, XrefRangeStart = 461422, XrefRangeEnd = 461424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo FindMethod(Type componentClass, string name, Il2CppReferenceArray<Type> args, Type returnType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_FindMethod_Protected_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00065B34 File Offset: 0x00063D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461430, RefRangeEnd = 461432, XrefRangeStart = 461426, XrefRangeEnd = 461430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo FindMethod(Type componentClass, string name, Il2CppReferenceArray<Type> args, Type returnType, bool publicOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_FindMethod_Protected_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00065BBC File Offset: 0x00063DBC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00065C04 File Offset: 0x00063E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461432, XrefRangeEnd = 461452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetInvocationTarget(Type type, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberDescriptor.NativeMethodInfoPtr_GetInvocationTarget_Protected_Virtual_New_Object_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00065C74 File Offset: 0x00063E74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 461461, RefRangeEnd = 461466, XrefRangeStart = 461452, XrefRangeEnd = 461461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ISite GetSite(Object component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_GetSite_Protected_Static_ISite_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00008A51 File Offset: 0x00006C51
		public MemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00065CB8 File Offset: 0x00063EB8
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00008A5A File Offset: 0x00006C5A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00065CE0 File Offset: 0x00063EE0
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x00008A79 File Offset: 0x00006C79
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00065D08 File Offset: 0x00063F08
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00008A98 File Offset: 0x00006C98
		public unsafe int nameHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_nameHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_nameHash)) = value;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x00065D30 File Offset: 0x00063F30
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x00008AB3 File Offset: 0x00006CB3
		public unsafe AttributeCollection attributeCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributeCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributeCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x00065D60 File Offset: 0x00063F60
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x00008AD2 File Offset: 0x00006CD2
		public unsafe Il2CppReferenceArray<Attribute> attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00065D90 File Offset: 0x00063F90
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00008AF1 File Offset: 0x00006CF1
		public unsafe Il2CppReferenceArray<Attribute> originalAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_originalAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_originalAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00065DC0 File Offset: 0x00063FC0
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x00008B10 File Offset: 0x00006D10
		public unsafe bool attributesFiltered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributesFiltered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributesFiltered)) = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00065DE8 File Offset: 0x00063FE8
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00008B2B File Offset: 0x00006D2B
		public unsafe bool attributesFilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributesFilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_attributesFilled)) = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00065E10 File Offset: 0x00064010
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00008B46 File Offset: 0x00006D46
		public unsafe int metadataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_metadataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_metadataVersion)) = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00065E38 File Offset: 0x00064038
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00008B61 File Offset: 0x00006D61
		public unsafe string category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_category);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x00065E60 File Offset: 0x00064060
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x00008B80 File Offset: 0x00006D80
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x00065E88 File Offset: 0x00064088
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x00008B9F File Offset: 0x00006D9F
		public unsafe Object lockCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_lockCookie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.NativeFieldInfoPtr_lockCookie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeFieldInfoPtr_nameHash;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeFieldInfoPtr_attributeCollection;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeFieldInfoPtr_originalAttributes;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeFieldInfoPtr_attributesFiltered;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeFieldInfoPtr_attributesFilled;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeFieldInfoPtr_metadataVersion;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeFieldInfoPtr_lockCookie;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_MemberDescriptor_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeArray_Protected_Virtual_New_get_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeArray_Protected_Virtual_New_set_Void_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_AttributeCollection_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_get_NameHashCode_Protected_Virtual_New_get_Int32_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttributesValid_Private_Void_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttributeCollection_Protected_Virtual_New_AttributeCollection_0;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr_FillAttributes_Protected_Virtual_New_Void_IList_0;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr_FilterAttributesIfNeeded_Private_Void_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Protected_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Protected_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_Type_Boolean_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_GetInvocationTarget_Protected_Virtual_New_Object_Type_Object_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_GetSite_Protected_Static_ISite_Object_0;
	}
}
