using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000033 RID: 51
	public class Borders : Object
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00018B58 File Offset: 0x00016D58
		// Note: this type is marked as 'beforefieldinit'.
		static Borders()
		{
			Il2CppClassPointerStore<Borders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "Borders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Borders>.NativeClassPtr);
			Borders.NativeFieldInfoPtr__Bottom_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Borders>.NativeClassPtr, "<Bottom>k__BackingField");
			Borders.NativeFieldInfoPtr__Left_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Borders>.NativeClassPtr, "<Left>k__BackingField");
			Borders.NativeFieldInfoPtr__Right_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Borders>.NativeClassPtr, "<Right>k__BackingField");
			Borders.NativeFieldInfoPtr__Top_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Borders>.NativeClassPtr, "<Top>k__BackingField");
			Borders.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Borders>.NativeClassPtr, "<ETag>k__BackingField");
			Borders.NativeMethodInfoPtr_get_Bottom_Public_Virtual_New_get_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663957);
			Borders.NativeMethodInfoPtr_set_Bottom_Public_Virtual_New_set_Void_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663958);
			Borders.NativeMethodInfoPtr_get_Left_Public_Virtual_New_get_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663959);
			Borders.NativeMethodInfoPtr_set_Left_Public_Virtual_New_set_Void_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663960);
			Borders.NativeMethodInfoPtr_get_Right_Public_Virtual_New_get_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663961);
			Borders.NativeMethodInfoPtr_set_Right_Public_Virtual_New_set_Void_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663962);
			Borders.NativeMethodInfoPtr_get_Top_Public_Virtual_New_get_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663963);
			Borders.NativeMethodInfoPtr_set_Top_Public_Virtual_New_set_Void_Border_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663964);
			Borders.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663965);
			Borders.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663966);
			Borders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Borders>.NativeClassPtr, 100663967);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00018CC8 File Offset: 0x00016EC8
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00018D14 File Offset: 0x00016F14
		public unsafe virtual Border Bottom
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_get_Bottom_Public_Virtual_New_get_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Border>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_set_Bottom_Public_Virtual_New_set_Void_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00018D64 File Offset: 0x00016F64
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00018DB0 File Offset: 0x00016FB0
		public unsafe virtual Border Left
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_get_Left_Public_Virtual_New_get_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Border>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_set_Left_Public_Virtual_New_set_Void_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00018E00 File Offset: 0x00017000
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00018E4C File Offset: 0x0001704C
		public unsafe virtual Border Right
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_get_Right_Public_Virtual_New_get_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Border>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_set_Right_Public_Virtual_New_set_Void_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00018E9C File Offset: 0x0001709C
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00018EE8 File Offset: 0x000170E8
		public unsafe virtual Border Top
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_get_Top_Public_Virtual_New_get_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Border>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_set_Top_Public_Virtual_New_set_Void_Border_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00018F38 File Offset: 0x00017138
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00018F7C File Offset: 0x0001717C
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Borders.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00018FCC File Offset: 0x000171CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Borders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Borders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Borders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00003AF1 File Offset: 0x00001CF1
		public Borders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00019008 File Offset: 0x00017208
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00003AFA File Offset: 0x00001CFA
		public unsafe Border _Bottom_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Bottom_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Border>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Bottom_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00019038 File Offset: 0x00017238
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00003B19 File Offset: 0x00001D19
		public unsafe Border _Left_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Left_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Border>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Left_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00019068 File Offset: 0x00017268
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00003B38 File Offset: 0x00001D38
		public unsafe Border _Right_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Right_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Border>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Right_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00019098 File Offset: 0x00017298
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003B57 File Offset: 0x00001D57
		public unsafe Border _Top_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Top_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Border>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__Top_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x000190C8 File Offset: 0x000172C8
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003B76 File Offset: 0x00001D76
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Borders.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr__Bottom_k__BackingField;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr__Left_k__BackingField;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr__Right_k__BackingField;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr__Top_k__BackingField;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_Bottom_Public_Virtual_New_get_Border_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_set_Bottom_Public_Virtual_New_set_Void_Border_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_Virtual_New_get_Border_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_set_Left_Public_Virtual_New_set_Void_Border_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_Virtual_New_get_Border_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_set_Right_Public_Virtual_New_set_Void_Border_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_get_Top_Public_Virtual_New_get_Border_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_set_Top_Public_Virtual_New_set_Void_Border_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
