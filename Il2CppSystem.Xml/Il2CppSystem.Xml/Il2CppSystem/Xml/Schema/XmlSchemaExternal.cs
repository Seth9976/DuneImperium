using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B2 RID: 434
	public class XmlSchemaExternal : XmlSchemaObject
	{
		// Token: 0x060025D7 RID: 9687 RVA: 0x000B2600 File Offset: 0x000B0800
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaExternal()
		{
			Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaExternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr);
			XmlSchemaExternal.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, "location");
			XmlSchemaExternal.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, "baseUri");
			XmlSchemaExternal.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, "schema");
			XmlSchemaExternal.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, "id");
			XmlSchemaExternal.NativeFieldInfoPtr_moreAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, "moreAttributes");
			XmlSchemaExternal.NativeFieldInfoPtr_compositor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, "compositor");
			XmlSchemaExternal.NativeMethodInfoPtr_get_SchemaLocation_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668781);
			XmlSchemaExternal.NativeMethodInfoPtr_set_SchemaLocation_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668782);
			XmlSchemaExternal.NativeMethodInfoPtr_get_Schema_Public_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668783);
			XmlSchemaExternal.NativeMethodInfoPtr_set_Schema_Public_set_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668784);
			XmlSchemaExternal.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668785);
			XmlSchemaExternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668786);
			XmlSchemaExternal.NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668787);
			XmlSchemaExternal.NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668788);
			XmlSchemaExternal.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668789);
			XmlSchemaExternal.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668790);
			XmlSchemaExternal.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668791);
			XmlSchemaExternal.NativeMethodInfoPtr_get_Compositor_Internal_get_Compositor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668792);
			XmlSchemaExternal.NativeMethodInfoPtr_set_Compositor_Internal_set_Void_Compositor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668793);
			XmlSchemaExternal.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr, 100668794);
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000B27C0 File Offset: 0x000B09C0
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x000B27F8 File Offset: 0x000B09F8
		public unsafe string SchemaLocation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_get_SchemaLocation_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_set_SchemaLocation_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000B283C File Offset: 0x000B0A3C
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x000B287C File Offset: 0x000B0A7C
		public unsafe XmlSchema Schema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_get_Schema_Public_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_set_Schema_Public_set_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000B28C0 File Offset: 0x000B0AC0
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x000B28F8 File Offset: 0x000B0AF8
		public unsafe string Id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000B293C File Offset: 0x000B0B3C
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x000B297C File Offset: 0x000B0B7C
		public unsafe Uri BaseUri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000B29C0 File Offset: 0x000B0BC0
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x000B2A04 File Offset: 0x000B0C04
		public unsafe override string IdAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaExternal.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaExternal.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000B2A54 File Offset: 0x000B0C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetUnhandledAttributes(Il2CppReferenceArray<XmlAttribute> moreAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moreAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaExternal.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000B2AA4 File Offset: 0x000B0CA4
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x000B2AE0 File Offset: 0x000B0CE0
		public unsafe Compositor Compositor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_get_Compositor_Internal_get_Compositor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr_set_Compositor_Internal_set_Void_Compositor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000B2B20 File Offset: 0x000B0D20
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaExternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaExternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaExternal.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x0000FEFB File Offset: 0x0000E0FB
		public XmlSchemaExternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000B2B5C File Offset: 0x000B0D5C
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x0000FF04 File Offset: 0x0000E104
		public unsafe string location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_location);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_location), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000B2B84 File Offset: 0x000B0D84
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x0000FF23 File Offset: 0x0000E123
		public unsafe Uri baseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_baseUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x000B2BB4 File Offset: 0x000B0DB4
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x0000FF42 File Offset: 0x0000E142
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x000B2BE4 File Offset: 0x000B0DE4
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x0000FF61 File Offset: 0x0000E161
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x000B2C0C File Offset: 0x000B0E0C
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x0000FF80 File Offset: 0x0000E180
		public unsafe Il2CppReferenceArray<XmlAttribute> moreAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_moreAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_moreAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x000B2C3C File Offset: 0x000B0E3C
		// (set) Token: 0x060025F2 RID: 9714 RVA: 0x0000FF9F File Offset: 0x0000E19F
		public unsafe Compositor compositor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_compositor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaExternal.NativeFieldInfoPtr_compositor)) = value;
			}
		}

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeFieldInfoPtr_baseUri;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeFieldInfoPtr_moreAttributes;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeFieldInfoPtr_compositor;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaLocation_Public_get_String_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaLocation_Public_set_Void_String_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_get_Schema_Public_get_XmlSchema_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_set_Schema_Public_set_Void_XmlSchema_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_get_Compositor_Internal_get_Compositor_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_set_Compositor_Internal_set_Void_Compositor_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
