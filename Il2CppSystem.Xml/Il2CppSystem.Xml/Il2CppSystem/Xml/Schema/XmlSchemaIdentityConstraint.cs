using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C6 RID: 454
	public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
	{
		// Token: 0x0600265C RID: 9820 RVA: 0x000B3EBC File Offset: 0x000B20BC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaIdentityConstraint()
		{
			Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaIdentityConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr);
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "name");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "selector");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "fields");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_qualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "qualifiedName");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_compiledConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "compiledConstraint");
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668842);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668843);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_XmlSchemaXPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668844);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Selector_Public_set_Void_XmlSchemaXPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668845);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668846);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668847);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668848);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_CompiledConstraint_Internal_get_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668849);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_CompiledConstraint_Internal_set_Void_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668850);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668851);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668852);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668853);
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000B4040 File Offset: 0x000B2240
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x000B4078 File Offset: 0x000B2278
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000B40BC File Offset: 0x000B22BC
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x000B40FC File Offset: 0x000B22FC
		public unsafe XmlSchemaXPath Selector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_XmlSchemaXPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaXPath>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Selector_Public_set_Void_XmlSchemaXPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x000B4140 File Offset: 0x000B2340
		public unsafe XmlSchemaObjectCollection Fields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x000B4180 File Offset: 0x000B2380
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000B41C0 File Offset: 0x000B23C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQualifiedName(XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x000B4204 File Offset: 0x000B2404
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x000B4244 File Offset: 0x000B2444
		public unsafe CompiledIdentityConstraint CompiledConstraint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_CompiledConstraint_Internal_get_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_CompiledConstraint_Internal_set_Void_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x000B4288 File Offset: 0x000B2488
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x000B42CC File Offset: 0x000B24CC
		public unsafe override string NameAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000B431C File Offset: 0x000B251C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412362, RefRangeEnd = 412364, XrefRangeStart = 412351, XrefRangeEnd = 412362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaIdentityConstraint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000104A0 File Offset: 0x0000E6A0
		public XmlSchemaIdentityConstraint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x000B4358 File Offset: 0x000B2558
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x000104A9 File Offset: 0x0000E6A9
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x000B4380 File Offset: 0x000B2580
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x000104C8 File Offset: 0x0000E6C8
		public unsafe XmlSchemaXPath selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaXPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x000B43B0 File Offset: 0x000B25B0
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x000104E7 File Offset: 0x0000E6E7
		public unsafe XmlSchemaObjectCollection fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x000B43E0 File Offset: 0x000B25E0
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x00010506 File Offset: 0x0000E706
		public unsafe XmlQualifiedName qualifiedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_qualifiedName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_qualifiedName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x000B4410 File Offset: 0x000B2610
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x00010525 File Offset: 0x0000E725
		public unsafe CompiledIdentityConstraint compiledConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_compiledConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_compiledConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeFieldInfoPtr_selector;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedName;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeFieldInfoPtr_compiledConstraint;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_get_Selector_Public_get_XmlSchemaXPath_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_set_Selector_Public_set_Void_XmlSchemaXPath_0;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_get_CompiledConstraint_Internal_get_CompiledIdentityConstraint_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_set_CompiledConstraint_Internal_set_Void_CompiledIdentityConstraint_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
