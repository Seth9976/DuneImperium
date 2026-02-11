using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000066 RID: 102
	public class MergeFailedEventArgs : EventArgs
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x000335E0 File Offset: 0x000317E0
		// Note: this type is marked as 'beforefieldinit'.
		static MergeFailedEventArgs()
		{
			Il2CppClassPointerStore<MergeFailedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "MergeFailedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MergeFailedEventArgs>.NativeClassPtr);
			MergeFailedEventArgs.NativeFieldInfoPtr__Table_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MergeFailedEventArgs>.NativeClassPtr, "<Table>k__BackingField");
			MergeFailedEventArgs.NativeFieldInfoPtr__Conflict_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MergeFailedEventArgs>.NativeClassPtr, "<Conflict>k__BackingField");
			MergeFailedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataTable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeFailedEventArgs>.NativeClassPtr, 100664926);
			MergeFailedEventArgs.NativeMethodInfoPtr_get_Conflict_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeFailedEventArgs>.NativeClassPtr, 100664927);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00033660 File Offset: 0x00031860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905216, RefRangeEnd = 905217, XrefRangeStart = 905210, XrefRangeEnd = 905216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MergeFailedEventArgs(DataTable table, string conflict)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MergeFailedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(conflict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeFailedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataTable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000336C0 File Offset: 0x000318C0
		public unsafe string Conflict
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeFailedEventArgs.NativeMethodInfoPtr_get_Conflict_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00004F8B File Offset: 0x0000318B
		public MergeFailedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x000336F8 File Offset: 0x000318F8
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00004F94 File Offset: 0x00003194
		public unsafe DataTable _Table_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MergeFailedEventArgs.NativeFieldInfoPtr__Table_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MergeFailedEventArgs.NativeFieldInfoPtr__Table_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00033728 File Offset: 0x00031928
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00004FB3 File Offset: 0x000031B3
		public unsafe string _Conflict_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MergeFailedEventArgs.NativeFieldInfoPtr__Conflict_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MergeFailedEventArgs.NativeFieldInfoPtr__Conflict_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr__Table_k__BackingField;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr__Conflict_k__BackingField;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_String_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_get_Conflict_Public_get_String_0;
	}
}
