using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B4 RID: 436
	public class XmlSchemaFacet : XmlSchemaAnnotated
	{
		// Token: 0x060025F3 RID: 9715 RVA: 0x000B2C64 File Offset: 0x000B0E64
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaFacet()
		{
			Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr);
			XmlSchemaFacet.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, "value");
			XmlSchemaFacet.NativeFieldInfoPtr_isFixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, "isFixed");
			XmlSchemaFacet.NativeFieldInfoPtr_facetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, "facetType");
			XmlSchemaFacet.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668795);
			XmlSchemaFacet.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668796);
			XmlSchemaFacet.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668797);
			XmlSchemaFacet.NativeMethodInfoPtr_set_IsFixed_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668798);
			XmlSchemaFacet.NativeMethodInfoPtr_get_FacetType_Internal_get_FacetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668799);
			XmlSchemaFacet.NativeMethodInfoPtr_set_FacetType_Internal_set_Void_FacetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668800);
			XmlSchemaFacet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668801);
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000B2D5C File Offset: 0x000B0F5C
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x000B2D94 File Offset: 0x000B0F94
		public unsafe string Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000B2DD8 File Offset: 0x000B0FD8
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x000B2E20 File Offset: 0x000B1020
		public unsafe virtual bool IsFixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaFacet.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412262, XrefRangeEnd = 412266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaFacet.NativeMethodInfoPtr_set_IsFixed_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000B2E6C File Offset: 0x000B106C
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x000B2EA8 File Offset: 0x000B10A8
		public unsafe FacetType FacetType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_get_FacetType_Internal_get_FacetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 403825, RefRangeEnd = 403834, XrefRangeStart = 403825, XrefRangeEnd = 403834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_set_FacetType_Internal_set_Void_FacetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000B2EE8 File Offset: 0x000B10E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x0000FFBA File Offset: 0x0000E1BA
		public XmlSchemaFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000B2F24 File Offset: 0x000B1124
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0000FFC3 File Offset: 0x0000E1C3
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000B2F4C File Offset: 0x000B114C
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0000FFE2 File Offset: 0x0000E1E2
		public unsafe bool isFixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_isFixed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_isFixed)) = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000B2F74 File Offset: 0x000B1174
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0000FFFD File Offset: 0x0000E1FD
		public unsafe FacetType facetType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_facetType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_facetType)) = value;
			}
		}

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeFieldInfoPtr_isFixed;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeFieldInfoPtr_facetType;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFixed_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetType_Internal_get_FacetType_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_set_FacetType_Internal_set_Void_FacetType_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
