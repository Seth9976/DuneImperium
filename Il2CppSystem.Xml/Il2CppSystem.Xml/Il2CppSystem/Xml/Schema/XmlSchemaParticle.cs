using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D3 RID: 467
	public class XmlSchemaParticle : XmlSchemaAnnotated
	{
		// Token: 0x06002726 RID: 10022 RVA: 0x000B6F30 File Offset: 0x000B5130
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaParticle()
		{
			Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaParticle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr);
			XmlSchemaParticle.NativeFieldInfoPtr_minOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "minOccurs");
			XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "maxOccurs");
			XmlSchemaParticle.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "flags");
			XmlSchemaParticle.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "Empty");
			XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccursString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668969);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccursString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668970);
			XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccursString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668971);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccursString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668972);
			XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccurs_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668973);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668974);
			XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccurs_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668975);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668976);
			XmlSchemaParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668977);
			XmlSchemaParticle.NativeMethodInfoPtr_get_NameString_Internal_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668978);
			XmlSchemaParticle.NativeMethodInfoPtr_GetQualifiedName_Internal_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668979);
			XmlSchemaParticle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668980);
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000B70A0 File Offset: 0x000B52A0
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x000B70D8 File Offset: 0x000B52D8
		public unsafe string MinOccursString
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 413099, RefRangeEnd = 413105, XrefRangeStart = 413098, XrefRangeEnd = 413099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccursString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 413114, RefRangeEnd = 413117, XrefRangeStart = 413105, XrefRangeEnd = 413114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccursString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000B711C File Offset: 0x000B531C
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x000B7154 File Offset: 0x000B5354
		public unsafe string MaxOccursString
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 413120, RefRangeEnd = 413124, XrefRangeStart = 413117, XrefRangeEnd = 413120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccursString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 413142, RefRangeEnd = 413143, XrefRangeStart = 413124, XrefRangeEnd = 413142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccursString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000B7198 File Offset: 0x000B5398
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x000B71D4 File Offset: 0x000B53D4
		public unsafe Decimal MinOccurs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccurs_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 413152, RefRangeEnd = 413190, XrefRangeStart = 413143, XrefRangeEnd = 413152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000B7214 File Offset: 0x000B5414
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x000B7250 File Offset: 0x000B5450
		public unsafe Decimal MaxOccurs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccurs_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 413203, RefRangeEnd = 413230, XrefRangeStart = 413190, XrefRangeEnd = 413203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x000B7290 File Offset: 0x000B5490
		public unsafe virtual bool IsEmpty
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 413235, RefRangeEnd = 413237, XrefRangeStart = 413230, XrefRangeEnd = 413235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000B72D8 File Offset: 0x000B54D8
		public unsafe virtual string NameString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413237, XrefRangeEnd = 413239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaParticle.NativeMethodInfoPtr_get_NameString_Internal_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000B731C File Offset: 0x000B551C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 413257, RefRangeEnd = 413260, XrefRangeStart = 413239, XrefRangeEnd = 413257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName GetQualifiedName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_GetQualifiedName_Internal_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000B735C File Offset: 0x000B555C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 413266, RefRangeEnd = 413273, XrefRangeStart = 413260, XrefRangeEnd = 413266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0001094B File Offset: 0x0000EB4B
		public XmlSchemaParticle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000B7398 File Offset: 0x000B5598
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00010954 File Offset: 0x0000EB54
		public unsafe Decimal minOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_minOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_minOccurs)) = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000B73C0 File Offset: 0x000B55C0
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x0001096F File Offset: 0x0000EB6F
		public unsafe Decimal maxOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs)) = value;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000B73E8 File Offset: 0x000B55E8
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x0001098A File Offset: 0x0000EB8A
		public unsafe XmlSchemaParticle.Occurs flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000B7410 File Offset: 0x000B5610
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x000109A5 File Offset: 0x0000EBA5
		public unsafe static XmlSchemaParticle Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaParticle.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaParticle.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeFieldInfoPtr_minOccurs;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeFieldInfoPtr_maxOccurs;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr_get_MinOccursString_Public_get_String_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_set_MinOccursString_Public_set_Void_String_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxOccursString_Public_get_String_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxOccursString_Public_set_Void_String_0;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_get_MinOccurs_Public_get_Decimal_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxOccurs_Public_get_Decimal_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_get_NameString_Internal_Virtual_New_get_String_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_GetQualifiedName_Internal_XmlQualifiedName_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000271 RID: 625
		[Flags]
		public enum Occurs
		{
			// Token: 0x04002766 RID: 10086
			None = 0,
			// Token: 0x04002767 RID: 10087
			Min = 1,
			// Token: 0x04002768 RID: 10088
			Max = 2
		}

		// Token: 0x02000272 RID: 626
		public class EmptyParticle : XmlSchemaParticle
		{
			// Token: 0x06003278 RID: 12920 RVA: 0x000DFD8C File Offset: 0x000DDF8C
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyParticle()
			{
				Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "EmptyParticle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr);
				XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr, 100668982);
				XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr, 100668983);
			}

			// Token: 0x170010FB RID: 4347
			// (get) Token: 0x06003279 RID: 12921 RVA: 0x000DFDE0 File Offset: 0x000DDFE0
			public unsafe override bool IsEmpty
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600327A RID: 12922 RVA: 0x000DFE28 File Offset: 0x000DE028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413089, XrefRangeEnd = 413098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyParticle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600327B RID: 12923 RVA: 0x00015A00 File Offset: 0x00013C00
			public EmptyParticle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002769 RID: 10089
			private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0;

			// Token: 0x0400276A RID: 10090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
