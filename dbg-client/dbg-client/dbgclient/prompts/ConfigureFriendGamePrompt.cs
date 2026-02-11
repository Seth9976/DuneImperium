using System;
using dbgclient.data;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.prompts
{
	// Token: 0x02000093 RID: 147
	public class ConfigureFriendGamePrompt : ResolvablePrompt<FriendGameConfigData>
	{
		// Token: 0x060005C7 RID: 1479 RVA: 0x0002FF70 File Offset: 0x0002E170
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureFriendGamePrompt()
		{
			Il2CppClassPointerStore<ConfigureFriendGamePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts", "ConfigureFriendGamePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureFriendGamePrompt>.NativeClassPtr);
			ConfigureFriendGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			ConfigureFriendGamePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePrompt>.NativeClassPtr, 100664198);
			ConfigureFriendGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePrompt>.NativeClassPtr, 100664199);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0002FFDC File Offset: 0x0002E1DC
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0003001C File Offset: 0x0002E21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502420, XrefRangeEnd = 502424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureFriendGamePrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureFriendGamePrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00004931 File Offset: 0x00002B31
		public ConfigureFriendGamePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00030068 File Offset: 0x0002E268
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0000493A File Offset: 0x00002B3A
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;
	}
}
