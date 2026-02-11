using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000066 RID: 102
	public class CompositeTargetInformationListTargetInformation : TargetInformation
	{
		// Token: 0x06000356 RID: 854 RVA: 0x0000E83C File Offset: 0x0000CA3C
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeTargetInformationListTargetInformation()
		{
			Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "CompositeTargetInformationListTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation>.NativeClassPtr);
			CompositeTargetInformationListTargetInformation.NativeFieldInfoPtr_TargetInfoLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation>.NativeClassPtr, "TargetInfoLists");
			CompositeTargetInformationListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation>.NativeClassPtr, 100663476);
			CompositeTargetInformationListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation>.NativeClassPtr, 100663477);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194172, XrefRangeEnd = 1194183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInformationListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeTargetInformationListTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInformationListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00004282 File Offset: 0x00002482
		public CompositeTargetInformationListTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000E928 File Offset: 0x0000CB28
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000428B File Offset: 0x0000248B
		public unsafe List<CompositeTargetInformationListTargetInformation.TargetInformationList> TargetInfoLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.NativeFieldInfoPtr_TargetInfoLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompositeTargetInformationListTargetInformation.TargetInformationList>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.NativeFieldInfoPtr_TargetInfoLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_TargetInfoLists;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C3 RID: 195
		public class TargetInformationList : Object
		{
			// Token: 0x06000657 RID: 1623 RVA: 0x000168DC File Offset: 0x00014ADC
			// Note: this type is marked as 'beforefieldinit'.
			static TargetInformationList()
			{
				Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation>.NativeClassPtr, "TargetInformationList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr);
				CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_TargetInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr, "TargetInfos");
				CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_PilePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr, "PilePrompt");
				CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_PileIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr, "PileIcon");
				CompositeTargetInformationListTargetInformation.TargetInformationList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr, 100663478);
				CompositeTargetInformationListTargetInformation.TargetInformationList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr, 100663479);
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x0001696C File Offset: 0x00014B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194150, XrefRangeEnd = 1194161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInformationListTargetInformation.TargetInformationList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x000169B0 File Offset: 0x00014BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194161, XrefRangeEnd = 1194172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TargetInformationList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeTargetInformationListTargetInformation.TargetInformationList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInformationListTargetInformation.TargetInformationList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x00005F6A File Offset: 0x0000416A
			public TargetInformationList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x0600065B RID: 1627 RVA: 0x000169EC File Offset: 0x00014BEC
			// (set) Token: 0x0600065C RID: 1628 RVA: 0x00005F73 File Offset: 0x00004173
			public unsafe Il2CppReferenceArray<TargetInformation> TargetInfos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_TargetInfos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetInformation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_TargetInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x0600065D RID: 1629 RVA: 0x00016A1C File Offset: 0x00014C1C
			// (set) Token: 0x0600065E RID: 1630 RVA: 0x00005F92 File Offset: 0x00004192
			public unsafe LocalizableText PilePrompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_PilePrompt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_PilePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x0600065F RID: 1631 RVA: 0x00016A4C File Offset: 0x00014C4C
			// (set) Token: 0x06000660 RID: 1632 RVA: 0x00005FB1 File Offset: 0x000041B1
			public unsafe string PileIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_PileIcon);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInformationListTargetInformation.TargetInformationList.NativeFieldInfoPtr_PileIcon), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeFieldInfoPtr_TargetInfos;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeFieldInfoPtr_PilePrompt;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeFieldInfoPtr_PileIcon;

			// Token: 0x0400034F RID: 847
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04000350 RID: 848
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
