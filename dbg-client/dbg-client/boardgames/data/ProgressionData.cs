using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x02000190 RID: 400
	public class ProgressionData : VersionedDataComponent
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x00055B6C File Offset: 0x00053D6C
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressionData()
		{
			Il2CppClassPointerStore<ProgressionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ProgressionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr);
			ProgressionData.NativeFieldInfoPtr_complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, "complete");
			ProgressionData.NativeFieldInfoPtr_locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, "locked");
			ProgressionData.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, 100665773);
			ProgressionData.NativeMethodInfoPtr_set_Complete_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, 100665774);
			ProgressionData.NativeMethodInfoPtr_get_Locked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, 100665775);
			ProgressionData.NativeMethodInfoPtr_set_Locked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, 100665776);
			ProgressionData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, 100665777);
			ProgressionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr, 100665778);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00055C3C File Offset: 0x00053E3C
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00055C78 File Offset: 0x00053E78
		public unsafe bool Complete
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressionData.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 499927, RefRangeEnd = 499930, XrefRangeStart = 499927, XrefRangeEnd = 499930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressionData.NativeMethodInfoPtr_set_Complete_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00055CB8 File Offset: 0x00053EB8
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00055CF4 File Offset: 0x00053EF4
		public unsafe bool Locked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressionData.NativeMethodInfoPtr_get_Locked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 515109, RefRangeEnd = 515116, XrefRangeStart = 515109, XrefRangeEnd = 515116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressionData.NativeMethodInfoPtr_set_Locked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00055D34 File Offset: 0x00053F34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 514337, RefRangeEnd = 514341, XrefRangeStart = 514337, XrefRangeEnd = 514341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressionData(bool complete, bool locked)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref complete;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressionData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00055D8C File Offset: 0x00053F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515169, XrefRangeEnd = 515179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProgressionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000A732 File Offset: 0x00008932
		public ProgressionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00055DD0 File Offset: 0x00053FD0
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0000A73B File Offset: 0x0000893B
		public unsafe bool complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionData.NativeFieldInfoPtr_complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionData.NativeFieldInfoPtr_complete)) = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00055DF8 File Offset: 0x00053FF8
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x0000A756 File Offset: 0x00008956
		public unsafe bool locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionData.NativeFieldInfoPtr_locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionData.NativeFieldInfoPtr_locked)) = value;
			}
		}

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_complete;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_locked;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_set_Complete_Public_set_Void_Boolean_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_get_Locked_Public_get_Boolean_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_set_Locked_Public_set_Void_Boolean_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
