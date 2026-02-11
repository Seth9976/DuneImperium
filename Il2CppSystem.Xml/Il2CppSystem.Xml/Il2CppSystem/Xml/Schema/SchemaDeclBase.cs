using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000185 RID: 389
	public class SchemaDeclBase : Object
	{
		// Token: 0x06001F70 RID: 8048 RVA: 0x0009AE7C File Offset: 0x0009907C
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaDeclBase()
		{
			Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaDeclBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr);
			SchemaDeclBase.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "name");
			SchemaDeclBase.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "prefix");
			SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "isDeclaredInExternal");
			SchemaDeclBase.NativeFieldInfoPtr_presence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "presence");
			SchemaDeclBase.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "schemaType");
			SchemaDeclBase.NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "datatype");
			SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "defaultValueRaw");
			SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "defaultValueTyped");
			SchemaDeclBase.NativeFieldInfoPtr_maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "maxLength");
			SchemaDeclBase.NativeFieldInfoPtr_minLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "minLength");
			SchemaDeclBase.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "values");
			SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668032);
			SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668033);
			SchemaDeclBase.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668034);
			SchemaDeclBase.NativeMethodInfoPtr_set_Name_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668035);
			SchemaDeclBase.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668036);
			SchemaDeclBase.NativeMethodInfoPtr_set_Prefix_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668037);
			SchemaDeclBase.NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668038);
			SchemaDeclBase.NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668039);
			SchemaDeclBase.NativeMethodInfoPtr_get_Presence_Internal_get_Use_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668040);
			SchemaDeclBase.NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668041);
			SchemaDeclBase.NativeMethodInfoPtr_get_MaxLength_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668042);
			SchemaDeclBase.NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668043);
			SchemaDeclBase.NativeMethodInfoPtr_get_MinLength_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668044);
			SchemaDeclBase.NativeMethodInfoPtr_set_MinLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668045);
			SchemaDeclBase.NativeMethodInfoPtr_get_SchemaType_Internal_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668046);
			SchemaDeclBase.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668047);
			SchemaDeclBase.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668048);
			SchemaDeclBase.NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668049);
			SchemaDeclBase.NativeMethodInfoPtr_AddValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668050);
			SchemaDeclBase.NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668051);
			SchemaDeclBase.NativeMethodInfoPtr_set_Values_Internal_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668052);
			SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668053);
			SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueRaw_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668054);
			SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668055);
			SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668056);
			SchemaDeclBase.NativeMethodInfoPtr_CheckEnumeration_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668057);
			SchemaDeclBase.NativeMethodInfoPtr_CheckValue_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100668058);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0009B1A4 File Offset: 0x000993A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 403472, RefRangeEnd = 403475, XrefRangeStart = 403464, XrefRangeEnd = 403472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDeclBase(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x0009B204 File Offset: 0x00099404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403481, RefRangeEnd = 403482, XrefRangeStart = 403475, XrefRangeEnd = 403481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDeclBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x0009B240 File Offset: 0x00099440
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x0009B280 File Offset: 0x00099480
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Name_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x0009B2C4 File Offset: 0x000994C4
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x0009B2FC File Offset: 0x000994FC
		public unsafe string Prefix
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 403484, RefRangeEnd = 403496, XrefRangeStart = 403482, XrefRangeEnd = 403484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Prefix_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x0009B340 File Offset: 0x00099540
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x0009B37C File Offset: 0x0009957C
		public unsafe bool IsDeclaredInExternal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0009B3BC File Offset: 0x000995BC
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x0009B3F8 File Offset: 0x000995F8
		public unsafe SchemaDeclBase.Use Presence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Presence_Internal_get_Use_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0009B438 File Offset: 0x00099638
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x0009B474 File Offset: 0x00099674
		public unsafe long MaxLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_MaxLength_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x0009B4B4 File Offset: 0x000996B4
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x0009B4F0 File Offset: 0x000996F0
		public unsafe long MinLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_MinLength_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_MinLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x0009B530 File Offset: 0x00099730
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x0009B570 File Offset: 0x00099770
		public unsafe XmlSchemaType SchemaType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_SchemaType_Internal_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0009B5B4 File Offset: 0x000997B4
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0009B5F4 File Offset: 0x000997F4
		public unsafe XmlSchemaDatatype Datatype
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0009B638 File Offset: 0x00099838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 403509, RefRangeEnd = 403511, XrefRangeStart = 403496, XrefRangeEnd = 403509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_AddValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x0009B67C File Offset: 0x0009987C
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0009B6BC File Offset: 0x000998BC
		public unsafe List<string> Values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Values_Internal_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0009B700 File Offset: 0x00099900
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x0009B738 File Offset: 0x00099938
		public unsafe string DefaultValueRaw
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 403512, RefRangeEnd = 403527, XrefRangeStart = 403511, XrefRangeEnd = 403512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueRaw_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x0009B77C File Offset: 0x0009997C
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x0009B7BC File Offset: 0x000999BC
		public unsafe Object DefaultValueTyped
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0009B800 File Offset: 0x00099A00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 403528, RefRangeEnd = 403532, XrefRangeStart = 403527, XrefRangeEnd = 403528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckEnumeration(Object pVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pVal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_CheckEnumeration_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0009B850 File Offset: 0x00099A50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 403532, RefRangeEnd = 403538, XrefRangeStart = 403532, XrefRangeEnd = 403532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckValue(Object pVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pVal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_CheckValue_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0000CCCF File Offset: 0x0000AECF
		public SchemaDeclBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0009B8A0 File Offset: 0x00099AA0
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0009B8D0 File Offset: 0x00099AD0
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0000CCF7 File Offset: 0x0000AEF7
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0009B8F8 File Offset: 0x00099AF8
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0000CD16 File Offset: 0x0000AF16
		public unsafe bool isDeclaredInExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal)) = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0009B920 File Offset: 0x00099B20
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0000CD31 File Offset: 0x0000AF31
		public unsafe SchemaDeclBase.Use presence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_presence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_presence)) = value;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0009B948 File Offset: 0x00099B48
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0009B978 File Offset: 0x00099B78
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0000CD6B File Offset: 0x0000AF6B
		public unsafe XmlSchemaDatatype datatype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_datatype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0000CD8A File Offset: 0x0000AF8A
		public unsafe string defaultValueRaw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0009B9D0 File Offset: 0x00099BD0
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0000CDA9 File Offset: 0x0000AFA9
		public unsafe Object defaultValueTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0009BA00 File Offset: 0x00099C00
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		public unsafe long maxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_maxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_maxLength)) = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0009BA28 File Offset: 0x00099C28
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0000CDE3 File Offset: 0x0000AFE3
		public unsafe long minLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_minLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_minLength)) = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0009BA50 File Offset: 0x00099C50
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0000CDFE File Offset: 0x0000AFFE
		public unsafe List<string> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeFieldInfoPtr_isDeclaredInExternal;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr_presence;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeFieldInfoPtr_datatype;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueRaw;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueTyped;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeFieldInfoPtr_maxLength;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeFieldInfoPtr_minLength;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Internal_get_String_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Internal_set_Void_String_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_get_Presence_Internal_get_Use_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLength_Internal_get_Int64_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int64_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_get_MinLength_Internal_get_Int64_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr_set_MinLength_Internal_set_Void_Int64_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Internal_get_XmlSchemaType_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Internal_Void_String_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_set_Values_Internal_set_Void_List_1_String_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueRaw_Internal_set_Void_String_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnumeration_Internal_Boolean_Object_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Internal_Boolean_Object_0;

		// Token: 0x0200025E RID: 606
		public enum Use
		{
			// Token: 0x0400266F RID: 9839
			Default,
			// Token: 0x04002670 RID: 9840
			Required,
			// Token: 0x04002671 RID: 9841
			Implied,
			// Token: 0x04002672 RID: 9842
			Fixed,
			// Token: 0x04002673 RID: 9843
			RequiredFixed
		}
	}
}
