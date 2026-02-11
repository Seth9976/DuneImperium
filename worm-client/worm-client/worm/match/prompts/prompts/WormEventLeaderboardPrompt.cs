using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000B6 RID: 182
	public class WormEventLeaderboardPrompt : Object
	{
		// Token: 0x06000740 RID: 1856 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventLeaderboardPrompt()
		{
			Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormEventLeaderboardPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr);
			WormEventLeaderboardPrompt.NativeFieldInfoPtr__Resolved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr, "<Resolved>k__BackingField");
			WormEventLeaderboardPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormEventLeaderboardPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr, 100664264);
			WormEventLeaderboardPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr, 100664265);
			WormEventLeaderboardPrompt.NativeMethodInfoPtr_set_Resolved_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr, 100664266);
			WormEventLeaderboardPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr, 100664267);
			WormEventLeaderboardPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr, 100664268);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0002E690 File Offset: 0x0002C890
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventLeaderboardPrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventLeaderboardPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0002E6DC File Offset: 0x0002C8DC
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0002E718 File Offset: 0x0002C918
		public unsafe virtual bool Resolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardPrompt.NativeMethodInfoPtr_set_Resolved_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0002E758 File Offset: 0x0002C958
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0002E798 File Offset: 0x0002C998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00005AA3 File Offset: 0x00003CA3
		public WormEventLeaderboardPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0002E7CC File Offset: 0x0002C9CC
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00005AAC File Offset: 0x00003CAC
		public unsafe bool _Resolved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPrompt.NativeFieldInfoPtr__Resolved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPrompt.NativeFieldInfoPtr__Resolved_k__BackingField)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0002E7F4 File Offset: 0x0002C9F4
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00005AC7 File Offset: 0x00003CC7
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr__Resolved_k__BackingField;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolved_Private_set_Void_Boolean_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;
	}
}
