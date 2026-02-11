using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200018C RID: 396
	public sealed class SchemaNotation : Object
	{
		// Token: 0x0600218E RID: 8590 RVA: 0x000A11D4 File Offset: 0x0009F3D4
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaNotation()
		{
			Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaNotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr);
			SchemaNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "name");
			SchemaNotation.NativeFieldInfoPtr_systemLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "systemLiteral");
			SchemaNotation.NativeFieldInfoPtr_pubid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "pubid");
			SchemaNotation.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100668173);
			SchemaNotation.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100668174);
			SchemaNotation.NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100668175);
			SchemaNotation.NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100668176);
			SchemaNotation.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100668177);
			SchemaNotation.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100668178);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x000A12B8 File Offset: 0x0009F4B8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNotation(XmlQualifiedName name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000A1304 File Offset: 0x0009F504
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x000A1344 File Offset: 0x0009F544
		// (set) Token: 0x06002192 RID: 8594 RVA: 0x000A137C File Offset: 0x0009F57C
		public unsafe string SystemLiteral
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000A13C0 File Offset: 0x0009F5C0
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x000A13F8 File Offset: 0x0009F5F8
		public unsafe string Pubid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0000E441 File Offset: 0x0000C641
		public SchemaNotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x000A143C File Offset: 0x0009F63C
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x0000E44A File Offset: 0x0000C64A
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x000A146C File Offset: 0x0009F66C
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x0000E469 File Offset: 0x0000C669
		public unsafe string systemLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_systemLiteral);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_systemLiteral), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x000A1494 File Offset: 0x0009F694
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x0000E488 File Offset: 0x0000C688
		public unsafe string pubid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_pubid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_pubid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeFieldInfoPtr_systemLiteral;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeFieldInfoPtr_pubid;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeMethodInfoPtr_get_Pubid_Internal_get_String_0;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0;
	}
}
