using System;
using boardgames.menus.prompts;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.prompts.prompts
{
	// Token: 0x02000097 RID: 151
	public class DailyChallengePrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x000303D8 File Offset: 0x0002E5D8
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengePrompt()
		{
			Il2CppClassPointerStore<DailyChallengePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts.prompts", "DailyChallengePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengePrompt>.NativeClassPtr);
			DailyChallengePrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengePrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			DailyChallengePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengePrompt>.NativeClassPtr, 100664206);
			DailyChallengePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengePrompt>.NativeClassPtr, 100664207);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00030444 File Offset: 0x0002E644
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00030484 File Offset: 0x0002E684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502453, RefRangeEnd = 502455, XrefRangeStart = 502451, XrefRangeEnd = 502453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengePrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengePrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000049C4 File Offset: 0x00002BC4
		public DailyChallengePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000304D0 File Offset: 0x0002E6D0
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000049CD File Offset: 0x00002BCD
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengePrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengePrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;
	}
}
