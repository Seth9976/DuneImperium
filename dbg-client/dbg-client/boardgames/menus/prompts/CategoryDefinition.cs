using System;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D6 RID: 470
	[Serializable]
	public class CategoryDefinition : Object
	{
		// Token: 0x06001583 RID: 5507 RVA: 0x00063418 File Offset: 0x00061618
		// Note: this type is marked as 'beforefieldinit'.
		static CategoryDefinition()
		{
			Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "CategoryDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr);
			CategoryDefinition.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "locKey");
			CategoryDefinition.NativeFieldInfoPtr_categoryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "categoryID");
			CategoryDefinition.NativeFieldInfoPtr_divisorCategoryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "divisorCategoryID");
			CategoryDefinition.NativeFieldInfoPtr_maxOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "maxOnly");
			CategoryDefinition.NativeFieldInfoPtr_asTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "asTotal");
			CategoryDefinition.NativeFieldInfoPtr_asPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "asPercent");
			CategoryDefinition.NativeFieldInfoPtr_filters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "filters");
			CategoryDefinition.NativeFieldInfoPtr_customValueFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, "customValueFormat");
			CategoryDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr, 100666466);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000634FC File Offset: 0x000616FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 522557, RefRangeEnd = 522558, XrefRangeStart = 522546, XrefRangeEnd = 522557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CategoryDefinition(string categoryID, string divisorCategoryID, bool maxOnly, bool asTotal, bool asPercent, string locKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(divisorCategoryID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxOnly;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asTotal;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asPercent;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		public CategoryDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00063598 File Offset: 0x00061798
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000C1E5 File Offset: 0x0000A3E5
		public unsafe string locKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_locKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x000635C0 File Offset: 0x000617C0
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000C204 File Offset: 0x0000A404
		public unsafe string categoryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_categoryID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_categoryID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x000635E8 File Offset: 0x000617E8
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000C223 File Offset: 0x0000A423
		public unsafe string divisorCategoryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_divisorCategoryID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_divisorCategoryID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00063610 File Offset: 0x00061810
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000C242 File Offset: 0x0000A442
		public unsafe bool maxOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_maxOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_maxOnly)) = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00063638 File Offset: 0x00061838
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000C25D File Offset: 0x0000A45D
		public unsafe bool asTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_asTotal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_asTotal)) = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00063660 File Offset: 0x00061860
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x0000C278 File Offset: 0x0000A478
		public unsafe bool asPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_asPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_asPercent)) = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00063688 File Offset: 0x00061888
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x0000C293 File Offset: 0x0000A493
		public unsafe List<StatsFilter> filters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_filters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatsFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_filters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x000636B8 File Offset: 0x000618B8
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x0000C2B2 File Offset: 0x0000A4B2
		public unsafe string customValueFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_customValueFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryDefinition.NativeFieldInfoPtr_customValueFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeFieldInfoPtr_categoryID;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeFieldInfoPtr_divisorCategoryID;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeFieldInfoPtr_maxOnly;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeFieldInfoPtr_asTotal;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeFieldInfoPtr_asPercent;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeFieldInfoPtr_filters;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeFieldInfoPtr_customValueFormat;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_String_0;
	}
}
