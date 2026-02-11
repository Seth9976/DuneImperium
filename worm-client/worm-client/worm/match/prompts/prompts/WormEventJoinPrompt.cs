using System;
using boardgames.menus.prompts;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000B5 RID: 181
	public class WormEventJoinPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x0002E4AC File Offset: 0x0002C6AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventJoinPrompt()
		{
			Il2CppClassPointerStore<WormEventJoinPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormEventJoinPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventJoinPrompt>.NativeClassPtr);
			WormEventJoinPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventJoinPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormEventJoinPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinPrompt>.NativeClassPtr, 100664262);
			WormEventJoinPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinPrompt>.NativeClassPtr, 100664263);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0002E518 File Offset: 0x0002C718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502453, RefRangeEnd = 502455, XrefRangeStart = 502453, XrefRangeEnd = 502455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventJoinPrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventJoinPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0002E564 File Offset: 0x0002C764
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00005A7B File Offset: 0x00003C7B
		public WormEventJoinPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0002E5A4 File Offset: 0x0002C7A4
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00005A84 File Offset: 0x00003C84
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;
	}
}
