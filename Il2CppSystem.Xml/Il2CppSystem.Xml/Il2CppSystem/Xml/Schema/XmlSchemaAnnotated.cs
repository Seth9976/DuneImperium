using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000198 RID: 408
	public class XmlSchemaAnnotated : XmlSchemaObject
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x000A9B28 File Offset: 0x000A7D28
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAnnotated()
		{
			Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAnnotated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr);
			XmlSchemaAnnotated.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, "id");
			XmlSchemaAnnotated.NativeFieldInfoPtr_annotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, "annotation");
			XmlSchemaAnnotated.NativeFieldInfoPtr_moreAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, "moreAttributes");
			XmlSchemaAnnotated.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668475);
			XmlSchemaAnnotated.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668476);
			XmlSchemaAnnotated.NativeMethodInfoPtr_get_Annotation_Public_get_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668477);
			XmlSchemaAnnotated.NativeMethodInfoPtr_set_Annotation_Public_set_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668478);
			XmlSchemaAnnotated.NativeMethodInfoPtr_get_UnhandledAttributes_Public_get_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668479);
			XmlSchemaAnnotated.NativeMethodInfoPtr_set_UnhandledAttributes_Public_set_Void_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668480);
			XmlSchemaAnnotated.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668481);
			XmlSchemaAnnotated.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668482);
			XmlSchemaAnnotated.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668483);
			XmlSchemaAnnotated.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668484);
			XmlSchemaAnnotated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100668485);
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x000A9C70 File Offset: 0x000A7E70
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x000A9CA8 File Offset: 0x000A7EA8
		public unsafe string Id
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000A9CEC File Offset: 0x000A7EEC
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x000A9D2C File Offset: 0x000A7F2C
		public unsafe XmlSchemaAnnotation Annotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr_get_Annotation_Public_get_XmlSchemaAnnotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr_set_Annotation_Public_set_Void_XmlSchemaAnnotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x000A9D70 File Offset: 0x000A7F70
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x000A9DB0 File Offset: 0x000A7FB0
		public unsafe Il2CppReferenceArray<XmlAttribute> UnhandledAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr_get_UnhandledAttributes_Public_get_Il2CppReferenceArray_1_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlAttribute>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr_set_UnhandledAttributes_Public_set_Void_Il2CppReferenceArray_1_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000A9DF4 File Offset: 0x000A7FF4
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x000A9E38 File Offset: 0x000A8038
		public unsafe override string IdAttribute
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAnnotated.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAnnotated.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x000A9E88 File Offset: 0x000A8088
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAnnotated.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x000A9ED8 File Offset: 0x000A80D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAnnotated.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x000A9F28 File Offset: 0x000A8128
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnnotated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		public XmlSchemaAnnotated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000A9F64 File Offset: 0x000A8164
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0000F1DD File Offset: 0x0000D3DD
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotated.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotated.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000A9F8C File Offset: 0x000A818C
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		public unsafe XmlSchemaAnnotation annotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotated.NativeFieldInfoPtr_annotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotated.NativeFieldInfoPtr_annotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000A9FBC File Offset: 0x000A81BC
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0000F21B File Offset: 0x0000D41B
		public unsafe Il2CppReferenceArray<XmlAttribute> moreAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotated.NativeFieldInfoPtr_moreAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotated.NativeFieldInfoPtr_moreAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeFieldInfoPtr_annotation;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeFieldInfoPtr_moreAttributes;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_get_Annotation_Public_get_XmlSchemaAnnotation_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_set_Annotation_Public_set_Void_XmlSchemaAnnotation_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_get_UnhandledAttributes_Public_get_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_set_UnhandledAttributes_Public_set_Void_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
