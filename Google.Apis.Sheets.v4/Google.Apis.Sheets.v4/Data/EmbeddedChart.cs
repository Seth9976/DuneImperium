using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200006B RID: 107
	public class EmbeddedChart : Object
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x0002857C File Offset: 0x0002677C
		// Note: this type is marked as 'beforefieldinit'.
		static EmbeddedChart()
		{
			Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "EmbeddedChart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr);
			EmbeddedChart.NativeFieldInfoPtr__ChartId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, "<ChartId>k__BackingField");
			EmbeddedChart.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, "<Position>k__BackingField");
			EmbeddedChart.NativeFieldInfoPtr__Spec_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, "<Spec>k__BackingField");
			EmbeddedChart.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, "<ETag>k__BackingField");
			EmbeddedChart.NativeMethodInfoPtr_get_ChartId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664457);
			EmbeddedChart.NativeMethodInfoPtr_set_ChartId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664458);
			EmbeddedChart.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664459);
			EmbeddedChart.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664460);
			EmbeddedChart.NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_ChartSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664461);
			EmbeddedChart.NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_ChartSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664462);
			EmbeddedChart.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664463);
			EmbeddedChart.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664464);
			EmbeddedChart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr, 100664465);
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x000286B0 File Offset: 0x000268B0
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x000286F4 File Offset: 0x000268F4
		public unsafe virtual Nullable<int> ChartId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_get_ChartId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_set_ChartId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00028748 File Offset: 0x00026948
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00028794 File Offset: 0x00026994
		public unsafe virtual EmbeddedObjectPosition Position
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x000287E4 File Offset: 0x000269E4
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00028830 File Offset: 0x00026A30
		public unsafe virtual ChartSpec Spec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_ChartSpec_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartSpec>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_ChartSpec_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00028880 File Offset: 0x00026A80
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x000288C4 File Offset: 0x00026AC4
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedChart.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00028914 File Offset: 0x00026B14
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmbeddedChart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedChart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedChart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00005A14 File Offset: 0x00003C14
		public EmbeddedChart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00028950 File Offset: 0x00026B50
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00005A1D File Offset: 0x00003C1D
		public Nullable<int> _ChartId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__ChartId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__ChartId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00028980 File Offset: 0x00026B80
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00005A4B File Offset: 0x00003C4B
		public unsafe EmbeddedObjectPosition _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__Position_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__Position_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x000289B0 File Offset: 0x00026BB0
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00005A6A File Offset: 0x00003C6A
		public unsafe ChartSpec _Spec_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__Spec_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartSpec>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__Spec_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x000289E0 File Offset: 0x00026BE0
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00005A89 File Offset: 0x00003C89
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedChart.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr__ChartId_k__BackingField;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr__Spec_k__BackingField;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_get_ChartId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_set_ChartId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_ChartSpec_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_ChartSpec_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
