using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Serialization;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CF RID: 463
	public class XmlSchemaObject : Object
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x000B5888 File Offset: 0x000B3A88
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaObject()
		{
			Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr);
			XmlSchemaObject.NativeFieldInfoPtr_lineNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, "lineNum");
			XmlSchemaObject.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, "linePos");
			XmlSchemaObject.NativeFieldInfoPtr_sourceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, "sourceUri");
			XmlSchemaObject.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, "namespaces");
			XmlSchemaObject.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, "parent");
			XmlSchemaObject.NativeFieldInfoPtr_isProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, "isProcessing");
			XmlSchemaObject.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668900);
			XmlSchemaObject.NativeMethodInfoPtr_set_LineNumber_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668901);
			XmlSchemaObject.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668902);
			XmlSchemaObject.NativeMethodInfoPtr_set_LinePosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668903);
			XmlSchemaObject.NativeMethodInfoPtr_get_SourceUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668904);
			XmlSchemaObject.NativeMethodInfoPtr_set_SourceUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668905);
			XmlSchemaObject.NativeMethodInfoPtr_get_Parent_Public_get_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668906);
			XmlSchemaObject.NativeMethodInfoPtr_set_Parent_Public_set_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668907);
			XmlSchemaObject.NativeMethodInfoPtr_get_Namespaces_Public_get_XmlSerializerNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668908);
			XmlSchemaObject.NativeMethodInfoPtr_set_Namespaces_Public_set_Void_XmlSerializerNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668909);
			XmlSchemaObject.NativeMethodInfoPtr_OnAdd_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668910);
			XmlSchemaObject.NativeMethodInfoPtr_OnRemove_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668911);
			XmlSchemaObject.NativeMethodInfoPtr_OnClear_Internal_Virtual_New_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668912);
			XmlSchemaObject.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668913);
			XmlSchemaObject.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668914);
			XmlSchemaObject.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_New_Void_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668915);
			XmlSchemaObject.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_New_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668916);
			XmlSchemaObject.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668917);
			XmlSchemaObject.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668918);
			XmlSchemaObject.NativeMethodInfoPtr_get_IsProcessing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668919);
			XmlSchemaObject.NativeMethodInfoPtr_set_IsProcessing_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668920);
			XmlSchemaObject.NativeMethodInfoPtr_Clone_Internal_Virtual_New_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668921);
			XmlSchemaObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100668922);
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000B5AFC File Offset: 0x000B3CFC
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x000B5B38 File Offset: 0x000B3D38
		public unsafe int LineNumber
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_set_LineNumber_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000B5B78 File Offset: 0x000B3D78
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x000B5BB4 File Offset: 0x000B3DB4
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_set_LinePosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000B5BF4 File Offset: 0x000B3DF4
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x000B5C2C File Offset: 0x000B3E2C
		public unsafe string SourceUri
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_get_SourceUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_set_SourceUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000B5C70 File Offset: 0x000B3E70
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x000B5CB0 File Offset: 0x000B3EB0
		public unsafe XmlSchemaObject Parent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_get_Parent_Public_get_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_set_Parent_Public_set_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000B5CF4 File Offset: 0x000B3EF4
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x000B5D34 File Offset: 0x000B3F34
		public unsafe XmlSerializerNamespaces Namespaces
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 412455, RefRangeEnd = 412463, XrefRangeStart = 412450, XrefRangeEnd = 412455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_get_Namespaces_Public_get_XmlSerializerNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializerNamespaces>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_set_Namespaces_Public_set_Void_XmlSerializerNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x000B5D78 File Offset: 0x000B3F78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAdd(XmlSchemaObjectCollection container, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_OnAdd_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000B5DD8 File Offset: 0x000B3FD8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemove(XmlSchemaObjectCollection container, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_OnRemove_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000B5E38 File Offset: 0x000B4038
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClear(XmlSchemaObjectCollection container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_OnClear_Internal_Virtual_New_Void_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000B5E88 File Offset: 0x000B4088
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x000B5ECC File Offset: 0x000B40CC
		public unsafe virtual string IdAttribute
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000B5F1C File Offset: 0x000B411C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetUnhandledAttributes(Il2CppReferenceArray<XmlAttribute> moreAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moreAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_New_Void_Il2CppReferenceArray_1_XmlAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000B5F6C File Offset: 0x000B416C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_New_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x000B5FBC File Offset: 0x000B41BC
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x000B6000 File Offset: 0x000B4200
		public unsafe virtual string NameAttribute
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000B6050 File Offset: 0x000B4250
		// (set) Token: 0x060026E9 RID: 9961 RVA: 0x000B608C File Offset: 0x000B428C
		public unsafe bool IsProcessing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_get_IsProcessing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr_set_IsProcessing_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000B60CC File Offset: 0x000B42CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412463, XrefRangeEnd = 412466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_Clone_Internal_Virtual_New_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000B6118 File Offset: 0x000B4318
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000107FD File Offset: 0x0000E9FD
		public XmlSchemaObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x000B6154 File Offset: 0x000B4354
		// (set) Token: 0x060026EE RID: 9966 RVA: 0x00010806 File Offset: 0x0000EA06
		public unsafe int lineNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_lineNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_lineNum)) = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x000B617C File Offset: 0x000B437C
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x00010821 File Offset: 0x0000EA21
		public unsafe int linePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_linePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_linePos)) = value;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x000B61A4 File Offset: 0x000B43A4
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x0001083C File Offset: 0x0000EA3C
		public unsafe string sourceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_sourceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_sourceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x000B61CC File Offset: 0x000B43CC
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x0001085B File Offset: 0x0000EA5B
		public unsafe XmlSerializerNamespaces namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_namespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializerNamespaces>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_namespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000B61FC File Offset: 0x000B43FC
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x0001087A File Offset: 0x0000EA7A
		public unsafe XmlSchemaObject parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000B622C File Offset: 0x000B442C
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x00010899 File Offset: 0x0000EA99
		public unsafe bool isProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_isProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObject.NativeFieldInfoPtr_isProcessing)) = value;
			}
		}

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr_lineNum;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeFieldInfoPtr_sourceUri;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeFieldInfoPtr_isProcessing;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr_set_LineNumber_Public_set_Void_Int32_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_set_LinePosition_Public_set_Void_Int32_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceUri_Public_get_String_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceUri_Public_set_Void_String_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_XmlSchemaObject_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Public_set_Void_XmlSchemaObject_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespaces_Public_get_XmlSerializerNamespaces_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespaces_Public_set_Void_XmlSerializerNamespaces_0;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_OnAdd_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_OnRemove_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_OnClear_Internal_Virtual_New_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_New_get_String_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_New_set_Void_String_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_New_Void_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_New_Void_XmlSchemaAnnotation_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_New_get_String_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_New_set_Void_String_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_get_IsProcessing_Internal_get_Boolean_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_set_IsProcessing_Internal_set_Void_Boolean_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_New_XmlSchemaObject_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
