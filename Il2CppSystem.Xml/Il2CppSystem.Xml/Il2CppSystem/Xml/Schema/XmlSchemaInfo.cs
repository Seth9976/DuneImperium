using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CD RID: 461
	public class XmlSchemaInfo : Object
	{
		// Token: 0x06002698 RID: 9880 RVA: 0x000B4AB8 File Offset: 0x000B2CB8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaInfo()
		{
			Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr);
			XmlSchemaInfo.NativeFieldInfoPtr_isDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "isDefault");
			XmlSchemaInfo.NativeFieldInfoPtr_isNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "isNil");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaElement");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaAttribute");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaType");
			XmlSchemaInfo.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "memberType");
			XmlSchemaInfo.NativeFieldInfoPtr_validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "validity");
			XmlSchemaInfo.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "contentType");
			XmlSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668868);
			XmlSchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668869);
			XmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668870);
			XmlSchemaInfo.NativeMethodInfoPtr_set_Validity_Public_set_Void_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668871);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668872);
			XmlSchemaInfo.NativeMethodInfoPtr_set_IsDefault_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668873);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668874);
			XmlSchemaInfo.NativeMethodInfoPtr_set_IsNil_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668875);
			XmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668876);
			XmlSchemaInfo.NativeMethodInfoPtr_set_MemberType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668877);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668878);
			XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668879);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668880);
			XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaElement_Public_set_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668881);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668882);
			XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaAttribute_Public_set_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668883);
			XmlSchemaInfo.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668884);
			XmlSchemaInfo.NativeMethodInfoPtr_get_XmlType_Internal_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668885);
			XmlSchemaInfo.NativeMethodInfoPtr_get_HasDefaultValue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668886);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsUnionType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668887);
			XmlSchemaInfo.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668888);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000B4D2C File Offset: 0x000B2F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 412405, RefRangeEnd = 412408, XrefRangeStart = 412400, XrefRangeEnd = 412405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000B4D68 File Offset: 0x000B2F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412408, XrefRangeEnd = 412413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInfo(XmlSchemaValidity validity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref validity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x000B4DB0 File Offset: 0x000B2FB0
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x000B4DEC File Offset: 0x000B2FEC
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_Validity_Public_set_Void_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000B4E2C File Offset: 0x000B302C
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x000B4E68 File Offset: 0x000B3068
		public unsafe virtual bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_IsDefault_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000B4EA8 File Offset: 0x000B30A8
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x000B4EE4 File Offset: 0x000B30E4
		public unsafe virtual bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_IsNil_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x000B4F24 File Offset: 0x000B3124
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x000B4F64 File Offset: 0x000B3164
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_MemberType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000B4FA8 File Offset: 0x000B31A8
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x000B4FE8 File Offset: 0x000B31E8
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 412414, RefRangeEnd = 412420, XrefRangeStart = 412413, XrefRangeEnd = 412414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000B502C File Offset: 0x000B322C
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x000B506C File Offset: 0x000B326C
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 412422, RefRangeEnd = 412425, XrefRangeStart = 412420, XrefRangeEnd = 412422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaElement_Public_set_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x000B50B0 File Offset: 0x000B32B0
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x000B50F0 File Offset: 0x000B32F0
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 412427, RefRangeEnd = 412429, XrefRangeStart = 412425, XrefRangeEnd = 412427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaAttribute_Public_set_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000B5134 File Offset: 0x000B3334
		public unsafe XmlSchemaContentType ContentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x000B5170 File Offset: 0x000B3370
		public unsafe XmlSchemaType XmlType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 412429, RefRangeEnd = 412432, XrefRangeStart = 412429, XrefRangeEnd = 412429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_XmlType_Internal_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000B51B0 File Offset: 0x000B33B0
		public unsafe bool HasDefaultValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412432, RefRangeEnd = 412433, XrefRangeStart = 412432, XrefRangeEnd = 412432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_HasDefaultValue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x000B51EC File Offset: 0x000B33EC
		public unsafe bool IsUnionType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 412433, RefRangeEnd = 412437, XrefRangeStart = 412433, XrefRangeEnd = 412433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsUnionType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000B5228 File Offset: 0x000B3428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412441, RefRangeEnd = 412443, XrefRangeStart = 412437, XrefRangeEnd = 412441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00010687 File Offset: 0x0000E887
		public XmlSchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000B525C File Offset: 0x000B345C
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x00010690 File Offset: 0x0000E890
		public unsafe bool isDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isDefault)) = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000B5284 File Offset: 0x000B3484
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x000106AB File Offset: 0x0000E8AB
		public unsafe bool isNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isNil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isNil)) = value;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000B52AC File Offset: 0x000B34AC
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x000106C6 File Offset: 0x0000E8C6
		public unsafe XmlSchemaElement schemaElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000B52DC File Offset: 0x000B34DC
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x000106E5 File Offset: 0x0000E8E5
		public unsafe XmlSchemaAttribute schemaAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000B530C File Offset: 0x000B350C
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x00010704 File Offset: 0x0000E904
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000B533C File Offset: 0x000B353C
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x00010723 File Offset: 0x0000E923
		public unsafe XmlSchemaSimpleType memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000B536C File Offset: 0x000B356C
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x00010742 File Offset: 0x0000E942
		public unsafe XmlSchemaValidity validity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_validity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_validity)) = value;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000B5394 File Offset: 0x000B3594
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x0001075D File Offset: 0x0000E95D
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeFieldInfoPtr_isDefault;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeFieldInfoPtr_isNil;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeFieldInfoPtr_schemaElement;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeFieldInfoPtr_schemaAttribute;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeFieldInfoPtr_validity;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_set_Validity_Public_set_Void_XmlSchemaValidity_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDefault_Public_set_Void_Boolean_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNil_Public_set_Void_Boolean_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaElement_Public_set_Void_XmlSchemaElement_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaAttribute_Public_set_Void_XmlSchemaAttribute_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Internal_get_XmlSchemaType_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultValue_Internal_get_Boolean_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnionType_Internal_get_Boolean_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
	}
}
