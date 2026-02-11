using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001F9 RID: 505
	public class OnlineMatchesPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x06001764 RID: 5988 RVA: 0x0006981C File Offset: 0x00067A1C
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineMatchesPrompt()
		{
			Il2CppClassPointerStore<OnlineMatchesPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "OnlineMatchesPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineMatchesPrompt>.NativeClassPtr);
			OnlineMatchesPrompt.NativeFieldInfoPtr_canCrossplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPrompt>.NativeClassPtr, "canCrossplay");
			OnlineMatchesPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			OnlineMatchesPrompt.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPrompt>.NativeClassPtr, 100666721);
			OnlineMatchesPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPrompt>.NativeClassPtr, 100666722);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0006989C File Offset: 0x00067A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525219, XrefRangeEnd = 525246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineMatchesPrompt(bool canCrossplay)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineMatchesPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canCrossplay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPrompt.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x000698E4 File Offset: 0x00067AE4
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0000D0F9 File Offset: 0x0000B2F9
		public OnlineMatchesPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x00069924 File Offset: 0x00067B24
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x0000D102 File Offset: 0x0000B302
		public unsafe bool canCrossplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPrompt.NativeFieldInfoPtr_canCrossplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPrompt.NativeFieldInfoPtr_canCrossplay)) = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0006994C File Offset: 0x00067B4C
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x0000D11D File Offset: 0x0000B31D
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeFieldInfoPtr_canCrossplay;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;
	}
}
