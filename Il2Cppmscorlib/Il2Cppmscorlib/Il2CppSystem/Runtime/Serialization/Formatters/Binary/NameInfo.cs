using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000375 RID: 885
	public sealed class NameInfo : Object
	{
		// Token: 0x06003720 RID: 14112 RVA: 0x0010E760 File Offset: 0x0010C960
		// Note: this type is marked as 'beforefieldinit'.
		static NameInfo()
		{
			Il2CppClassPointerStore<NameInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "NameInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameInfo>.NativeClassPtr);
			NameInfo.NativeFieldInfoPtr_NIFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIFullName");
			NameInfo.NativeFieldInfoPtr_NIobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIobjectId");
			NameInfo.NativeFieldInfoPtr_NIassemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIassemId");
			NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIprimitiveTypeEnum");
			NameInfo.NativeFieldInfoPtr_NItype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItype");
			NameInfo.NativeFieldInfoPtr_NIisSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisSealed");
			NameInfo.NativeFieldInfoPtr_NIisArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArray");
			NameInfo.NativeFieldInfoPtr_NIisArrayItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArrayItem");
			NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnObject");
			NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnMember");
			NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisParentTypeOnObject");
			NameInfo.NativeFieldInfoPtr_NIarrayEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIarrayEnum");
			NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIsealedStatusChecked");
			NameInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671587);
			NameInfo.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671588);
			NameInfo.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671589);
			NameInfo.NativeMethodInfoPtr_get_NIname_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671590);
			NameInfo.NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671591);
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x0010E8F8 File Offset: 0x0010CAF8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0010E934 File Offset: 0x0010CB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391167, XrefRangeEnd = 1391169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x0010E968 File Offset: 0x0010CB68
		public unsafe bool IsSealed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391169, XrefRangeEnd = 1391170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x0010E9A4 File Offset: 0x0010CBA4
		// (set) Token: 0x06003725 RID: 14117 RVA: 0x0010E9DC File Offset: 0x0010CBDC
		public unsafe string NIname
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1391171, RefRangeEnd = 1391175, XrefRangeStart = 1391170, XrefRangeEnd = 1391171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_get_NIname_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x0001410F File Offset: 0x0001230F
		public NameInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x0010EA20 File Offset: 0x0010CC20
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x00014118 File Offset: 0x00012318
		public unsafe string NIFullName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIFullName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIFullName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x0010EA48 File Offset: 0x0010CC48
		// (set) Token: 0x0600372A RID: 14122 RVA: 0x00014137 File Offset: 0x00012337
		public unsafe long NIobjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIobjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIobjectId)) = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x0010EA70 File Offset: 0x0010CC70
		// (set) Token: 0x0600372C RID: 14124 RVA: 0x00014152 File Offset: 0x00012352
		public unsafe long NIassemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIassemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIassemId)) = value;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x0010EA98 File Offset: 0x0010CC98
		// (set) Token: 0x0600372E RID: 14126 RVA: 0x0001416D File Offset: 0x0001236D
		public unsafe InternalPrimitiveTypeE NIprimitiveTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum)) = value;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600372F RID: 14127 RVA: 0x0010EAC0 File Offset: 0x0010CCC0
		// (set) Token: 0x06003730 RID: 14128 RVA: 0x00014188 File Offset: 0x00012388
		public unsafe Type NItype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06003731 RID: 14129 RVA: 0x0010EAF0 File Offset: 0x0010CCF0
		// (set) Token: 0x06003732 RID: 14130 RVA: 0x000141A7 File Offset: 0x000123A7
		public unsafe bool NIisSealed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisSealed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisSealed)) = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x0010EB18 File Offset: 0x0010CD18
		// (set) Token: 0x06003734 RID: 14132 RVA: 0x000141C2 File Offset: 0x000123C2
		public unsafe bool NIisArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArray)) = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06003735 RID: 14133 RVA: 0x0010EB40 File Offset: 0x0010CD40
		// (set) Token: 0x06003736 RID: 14134 RVA: 0x000141DD File Offset: 0x000123DD
		public unsafe bool NIisArrayItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArrayItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArrayItem)) = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x0010EB68 File Offset: 0x0010CD68
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x000141F8 File Offset: 0x000123F8
		public unsafe bool NItransmitTypeOnObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject)) = value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x0010EB90 File Offset: 0x0010CD90
		// (set) Token: 0x0600373A RID: 14138 RVA: 0x00014213 File Offset: 0x00012413
		public unsafe bool NItransmitTypeOnMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember)) = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x0010EBB8 File Offset: 0x0010CDB8
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x0001422E File Offset: 0x0001242E
		public unsafe bool NIisParentTypeOnObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject)) = value;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x0010EBE0 File Offset: 0x0010CDE0
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x00014249 File Offset: 0x00012449
		public unsafe InternalArrayTypeE NIarrayEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIarrayEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIarrayEnum)) = value;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x0010EC08 File Offset: 0x0010CE08
		// (set) Token: 0x06003740 RID: 14144 RVA: 0x00014264 File Offset: 0x00012464
		public unsafe bool NIsealedStatusChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked)) = value;
			}
		}

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeFieldInfoPtr_NIFullName;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeFieldInfoPtr_NIobjectId;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeFieldInfoPtr_NIassemId;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeFieldInfoPtr_NIprimitiveTypeEnum;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeFieldInfoPtr_NItype;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeFieldInfoPtr_NIisSealed;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeFieldInfoPtr_NIisArray;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeFieldInfoPtr_NIisArrayItem;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeFieldInfoPtr_NItransmitTypeOnObject;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeFieldInfoPtr_NItransmitTypeOnMember;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeFieldInfoPtr_NIisParentTypeOnObject;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeFieldInfoPtr_NIarrayEnum;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeFieldInfoPtr_NIsealedStatusChecked;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr_get_NIname_Public_get_String_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0;
	}
}
