using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000B4 RID: 180
	public class WormEarnedSkirmishBadgePrompt : DismissablePrompt
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x0002E2F8 File Offset: 0x0002C4F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormEarnedSkirmishBadgePrompt()
		{
			Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormEarnedSkirmishBadgePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr);
			WormEarnedSkirmishBadgePrompt.NativeFieldInfoPtr__Badge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr, "<Badge>k__BackingField");
			WormEarnedSkirmishBadgePrompt.NativeFieldInfoPtr__Rank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr, "<Rank>k__BackingField");
			WormEarnedSkirmishBadgePrompt.NativeMethodInfoPtr_get_Badge_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr, 100664259);
			WormEarnedSkirmishBadgePrompt.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr, 100664260);
			WormEarnedSkirmishBadgePrompt.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr, 100664261);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0002E38C File Offset: 0x0002C58C
		public unsafe string Badge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePrompt.NativeMethodInfoPtr_get_Badge_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x0002E3C4 File Offset: 0x0002C5C4
		public unsafe int Rank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePrompt.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0002E400 File Offset: 0x0002C600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696833, RefRangeEnd = 696834, XrefRangeStart = 696831, XrefRangeEnd = 696833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEarnedSkirmishBadgePrompt(string badge, int rank)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEarnedSkirmishBadgePrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(badge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePrompt.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00005A38 File Offset: 0x00003C38
		public WormEarnedSkirmishBadgePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0002E45C File Offset: 0x0002C65C
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00005A41 File Offset: 0x00003C41
		public unsafe string _Badge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePrompt.NativeFieldInfoPtr__Badge_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePrompt.NativeFieldInfoPtr__Badge_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0002E484 File Offset: 0x0002C684
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00005A60 File Offset: 0x00003C60
		public unsafe int _Rank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePrompt.NativeFieldInfoPtr__Rank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePrompt.NativeFieldInfoPtr__Rank_k__BackingField)) = value;
			}
		}

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr__Badge_k__BackingField;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr__Rank_k__BackingField;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_get_Badge_Public_get_String_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_Int32_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
