using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Data.Common;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data
{
	// Token: 0x02000078 RID: 120
	[Serializable]
	public sealed class SimpleType : Object
	{
		// Token: 0x06000B1D RID: 2845 RVA: 0x0003930C File Offset: 0x0003750C
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleType()
		{
			Il2CppClassPointerStore<SimpleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "SimpleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleType>.NativeClassPtr);
			SimpleType.NativeFieldInfoPtr__baseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_baseType");
			SimpleType.NativeFieldInfoPtr__baseSimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_baseSimpleType");
			SimpleType.NativeFieldInfoPtr__xmlBaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_xmlBaseType");
			SimpleType.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_name");
			SimpleType.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_length");
			SimpleType.NativeFieldInfoPtr__minLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_minLength");
			SimpleType.NativeFieldInfoPtr__maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_maxLength");
			SimpleType.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_pattern");
			SimpleType.NativeFieldInfoPtr__ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_ns");
			SimpleType.NativeFieldInfoPtr__maxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_maxExclusive");
			SimpleType.NativeFieldInfoPtr__maxInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_maxInclusive");
			SimpleType.NativeFieldInfoPtr__minExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_minExclusive");
			SimpleType.NativeFieldInfoPtr__minInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_minInclusive");
			SimpleType.NativeFieldInfoPtr__enumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, "_enumeration");
			SimpleType.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665145);
			SimpleType.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665146);
			SimpleType.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665147);
			SimpleType.NativeMethodInfoPtr_LoadTypeValues_Internal_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665148);
			SimpleType.NativeMethodInfoPtr_IsPlainString_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665149);
			SimpleType.NativeMethodInfoPtr_get_BaseType_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665150);
			SimpleType.NativeMethodInfoPtr_get_XmlBaseType_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665151);
			SimpleType.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665152);
			SimpleType.NativeMethodInfoPtr_get_Namespace_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665153);
			SimpleType.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665154);
			SimpleType.NativeMethodInfoPtr_get_MaxLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665155);
			SimpleType.NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665156);
			SimpleType.NativeMethodInfoPtr_get_BaseSimpleType_Internal_get_SimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665157);
			SimpleType.NativeMethodInfoPtr_get_SimpleTypeQualifiedName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665158);
			SimpleType.NativeMethodInfoPtr_QualifiedName_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665159);
			SimpleType.NativeMethodInfoPtr_ToNode_Internal_XmlNode_XmlDocument_Hashtable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665160);
			SimpleType.NativeMethodInfoPtr_CreateEnumeratedType_Internal_Static_SimpleType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665161);
			SimpleType.NativeMethodInfoPtr_CreateByteArrayType_Internal_Static_SimpleType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665162);
			SimpleType.NativeMethodInfoPtr_CreateLimitedStringType_Internal_Static_SimpleType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665163);
			SimpleType.NativeMethodInfoPtr_CreateSimpleType_Internal_Static_SimpleType_StorageType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665164);
			SimpleType.NativeMethodInfoPtr_HasConflictingDefinition_Internal_String_SimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665165);
			SimpleType.NativeMethodInfoPtr_CanHaveMaxLength_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665166);
			SimpleType.NativeMethodInfoPtr_ConvertToAnnonymousSimpleType_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleType>.NativeClassPtr, 100665167);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00039620 File Offset: 0x00037820
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 907420, RefRangeEnd = 907426, XrefRangeStart = 907401, XrefRangeEnd = 907420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleType(string baseType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0003966C File Offset: 0x0003786C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 907457, RefRangeEnd = 907464, XrefRangeStart = 907426, XrefRangeEnd = 907457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleType(XmlSchemaSimpleType node)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000396B8 File Offset: 0x000378B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907464, XrefRangeEnd = 907469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00039714 File Offset: 0x00037914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907564, RefRangeEnd = 907566, XrefRangeStart = 907469, XrefRangeEnd = 907564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTypeValues(XmlSchemaSimpleType node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_LoadTypeValues_Internal_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00039758 File Offset: 0x00037958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907581, RefRangeEnd = 907582, XrefRangeStart = 907566, XrefRangeEnd = 907581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlainString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_IsPlainString_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00039794 File Offset: 0x00037994
		public unsafe string BaseType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_BaseType_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x000397CC File Offset: 0x000379CC
		public unsafe XmlQualifiedName XmlBaseType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_XmlBaseType_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0003980C File Offset: 0x00037A0C
		public unsafe string Name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00039844 File Offset: 0x00037A44
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_Namespace_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0003987C File Offset: 0x00037A7C
		public unsafe int Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x000398B8 File Offset: 0x00037AB8
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x000398F4 File Offset: 0x00037AF4
		public unsafe int MaxLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_MaxLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00039934 File Offset: 0x00037B34
		public unsafe SimpleType BaseSimpleType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_BaseSimpleType_Internal_get_SimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00039974 File Offset: 0x00037B74
		public unsafe string SimpleTypeQualifiedName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 907585, RefRangeEnd = 907589, XrefRangeStart = 907582, XrefRangeEnd = 907585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_get_SimpleTypeQualifiedName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x000399AC File Offset: 0x00037BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907589, XrefRangeEnd = 907591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string QualifiedName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_QualifiedName_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000399F4 File Offset: 0x00037BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907591, XrefRangeEnd = 907649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefixes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inRemoting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_ToNode_Internal_XmlNode_XmlDocument_Hashtable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00039A64 File Offset: 0x00037C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907649, XrefRangeEnd = 907656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleType CreateEnumeratedType(string values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_CreateEnumeratedType_Internal_Static_SimpleType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00039AA8 File Offset: 0x00037CA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907662, RefRangeEnd = 907664, XrefRangeStart = 907656, XrefRangeEnd = 907662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleType CreateByteArrayType(string encoding)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_CreateByteArrayType_Internal_Static_SimpleType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00039AEC File Offset: 0x00037CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907670, RefRangeEnd = 907672, XrefRangeStart = 907664, XrefRangeEnd = 907670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleType CreateLimitedStringType(int length)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_CreateLimitedStringType_Internal_Static_SimpleType_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00039B2C File Offset: 0x00037D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907685, RefRangeEnd = 907687, XrefRangeStart = 907672, XrefRangeEnd = 907685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleType CreateSimpleType(StorageType typeCode, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_CreateSimpleType_Internal_Static_SimpleType_StorageType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr3) : null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00039B80 File Offset: 0x00037D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907695, RefRangeEnd = 907697, XrefRangeStart = 907687, XrefRangeEnd = 907695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HasConflictingDefinition(SimpleType otherSimpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherSimpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_HasConflictingDefinition_Internal_String_SimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00039BC8 File Offset: 0x00037DC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 907702, RefRangeEnd = 907708, XrefRangeStart = 907697, XrefRangeEnd = 907702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanHaveMaxLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_CanHaveMaxLength_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00039C04 File Offset: 0x00037E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907717, RefRangeEnd = 907718, XrefRangeStart = 907708, XrefRangeEnd = 907717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertToAnnonymousSimpleType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleType.NativeMethodInfoPtr_ConvertToAnnonymousSimpleType_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000055A0 File Offset: 0x000037A0
		public SimpleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00039C38 File Offset: 0x00037E38
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x000055A9 File Offset: 0x000037A9
		public unsafe string _baseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__baseType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__baseType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00039C60 File Offset: 0x00037E60
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000055C8 File Offset: 0x000037C8
		public unsafe SimpleType _baseSimpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__baseSimpleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__baseSimpleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00039C90 File Offset: 0x00037E90
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x000055E7 File Offset: 0x000037E7
		public unsafe XmlQualifiedName _xmlBaseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__xmlBaseType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__xmlBaseType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00039CC0 File Offset: 0x00037EC0
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00005606 File Offset: 0x00003806
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x00039CE8 File Offset: 0x00037EE8
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00005625 File Offset: 0x00003825
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00039D10 File Offset: 0x00037F10
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00005640 File Offset: 0x00003840
		public unsafe int _minLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__minLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__minLength)) = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00039D38 File Offset: 0x00037F38
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x0000565B File Offset: 0x0000385B
		public unsafe int _maxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__maxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__maxLength)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00039D60 File Offset: 0x00037F60
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x00005676 File Offset: 0x00003876
		public unsafe string _pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00039D88 File Offset: 0x00037F88
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x00005695 File Offset: 0x00003895
		public unsafe string _ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00039DB0 File Offset: 0x00037FB0
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x000056B4 File Offset: 0x000038B4
		public unsafe string _maxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__maxExclusive);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__maxExclusive), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00039DD8 File Offset: 0x00037FD8
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x000056D3 File Offset: 0x000038D3
		public unsafe string _maxInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__maxInclusive);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__maxInclusive), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00039E00 File Offset: 0x00038000
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x000056F2 File Offset: 0x000038F2
		public unsafe string _minExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__minExclusive);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__minExclusive), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00039E28 File Offset: 0x00038028
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00005711 File Offset: 0x00003911
		public unsafe string _minInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__minInclusive);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__minInclusive), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00039E50 File Offset: 0x00038050
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00005730 File Offset: 0x00003930
		public unsafe string _enumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__enumeration);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleType.NativeFieldInfoPtr__enumeration), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeFieldInfoPtr__baseType;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr__baseSimpleType;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr__xmlBaseType;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr__minLength;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr__maxLength;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr__pattern;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr__ns;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr__maxExclusive;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr__maxInclusive;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr__minExclusive;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr__minInclusive;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr__enumeration;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaSimpleType_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_LoadTypeValues_Internal_Void_XmlSchemaSimpleType_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_IsPlainString_Internal_Boolean_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Internal_get_String_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlBaseType_Internal_get_XmlQualifiedName_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Internal_get_String_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLength_Internal_get_Int32_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int32_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseSimpleType_Internal_get_SimpleType_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleTypeQualifiedName_Public_get_String_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_QualifiedName_Internal_String_String_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_ToNode_Internal_XmlNode_XmlDocument_Hashtable_Boolean_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_CreateEnumeratedType_Internal_Static_SimpleType_String_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_CreateByteArrayType_Internal_Static_SimpleType_String_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_CreateLimitedStringType_Internal_Static_SimpleType_Int32_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_CreateSimpleType_Internal_Static_SimpleType_StorageType_Type_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_HasConflictingDefinition_Internal_String_SimpleType_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_CanHaveMaxLength_Internal_Boolean_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToAnnonymousSimpleType_Internal_Void_0;
	}
}
