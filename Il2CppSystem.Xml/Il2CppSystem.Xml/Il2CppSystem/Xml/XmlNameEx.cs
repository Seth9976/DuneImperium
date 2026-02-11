using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000071 RID: 113
	public sealed class XmlNameEx : XmlName
	{
		// Token: 0x06000DB5 RID: 3509 RVA: 0x00051AA8 File Offset: 0x0004FCA8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNameEx()
		{
			Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNameEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr);
			XmlNameEx.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "flags");
			XmlNameEx.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "memberType");
			XmlNameEx.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "schemaType");
			XmlNameEx.NativeFieldInfoPtr_decl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "decl");
			XmlNameEx.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665532);
			XmlNameEx.NativeMethodInfoPtr_get_Validity_Public_Virtual_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665533);
			XmlNameEx.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665534);
			XmlNameEx.NativeMethodInfoPtr_get_IsNil_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665535);
			XmlNameEx.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665536);
			XmlNameEx.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665537);
			XmlNameEx.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665538);
			XmlNameEx.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665539);
			XmlNameEx.NativeMethodInfoPtr_SetValidity_Public_Void_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665540);
			XmlNameEx.NativeMethodInfoPtr_SetIsDefault_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665541);
			XmlNameEx.NativeMethodInfoPtr_SetIsNil_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665542);
			XmlNameEx.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100665543);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00051C18 File Offset: 0x0004FE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375206, RefRangeEnd = 375207, XrefRangeStart = 375184, XrefRangeEnd = 375206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerDoc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00051CD0 File Offset: 0x0004FED0
		public unsafe override XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_Validity_Public_Virtual_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00051D0C File Offset: 0x0004FF0C
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00051D48 File Offset: 0x0004FF48
		public unsafe override bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_IsNil_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00051D84 File Offset: 0x0004FF84
		public unsafe override XmlSchemaSimpleType MemberType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00051DC4 File Offset: 0x0004FFC4
		public unsafe override XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00051E04 File Offset: 0x00050004
		public unsafe override XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375207, XrefRangeEnd = 375208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00051E44 File Offset: 0x00050044
		public unsafe override XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375208, XrefRangeEnd = 375209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00051E84 File Offset: 0x00050084
		[CallerCount(0)]
		public unsafe void SetValidity(XmlSchemaValidity value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_SetValidity_Public_Void_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00051EC4 File Offset: 0x000500C4
		[CallerCount(0)]
		public unsafe void SetIsDefault(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_SetIsDefault_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00051F04 File Offset: 0x00050104
		[CallerCount(0)]
		public unsafe void SetIsNil(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_SetIsNil_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00051F44 File Offset: 0x00050144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375209, XrefRangeEnd = 375230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00006917 File Offset: 0x00004B17
		public XmlNameEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00051F94 File Offset: 0x00050194
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00006920 File Offset: 0x00004B20
		public unsafe byte flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00051FBC File Offset: 0x000501BC
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x0000693B File Offset: 0x00004B3B
		public unsafe XmlSchemaSimpleType memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00051FEC File Offset: 0x000501EC
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x0000695A File Offset: 0x00004B5A
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0005201C File Offset: 0x0005021C
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00006979 File Offset: 0x00004B79
		public unsafe Object decl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_decl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_decl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_decl;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Virtual_get_XmlSchemaValidity_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Virtual_get_Boolean_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_XmlSchemaSimpleType_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Virtual_get_XmlSchemaType_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_get_XmlSchemaElement_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_get_XmlSchemaAttribute_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_SetValidity_Public_Void_XmlSchemaValidity_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_SetIsDefault_Public_Void_Boolean_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_SetIsNil_Public_Void_Boolean_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_IXmlSchemaInfo_0;
	}
}
