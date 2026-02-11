using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000B8 RID: 184
	public class WormEventMoreInfoPrompt : BasePrompt
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x0002E94C File Offset: 0x0002CB4C
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventMoreInfoPrompt()
		{
			Il2CppClassPointerStore<WormEventMoreInfoPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormEventMoreInfoPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventMoreInfoPrompt>.NativeClassPtr);
			WormEventMoreInfoPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventMoreInfoPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormEventMoreInfoPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventMoreInfoPrompt>.NativeClassPtr, 100664271);
			WormEventMoreInfoPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventMoreInfoPrompt>.NativeClassPtr, 100664272);
			WormEventMoreInfoPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventMoreInfoPrompt>.NativeClassPtr, 100664273);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0002E9CC File Offset: 0x0002CBCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 524963, RefRangeEnd = 524967, XrefRangeStart = 524963, XrefRangeEnd = 524967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventMoreInfoPrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventMoreInfoPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventMoreInfoPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0002EA18 File Offset: 0x0002CC18
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventMoreInfoPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0002EA58 File Offset: 0x0002CC58
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventMoreInfoPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00005B0E File Offset: 0x00003D0E
		public WormEventMoreInfoPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0002EA8C File Offset: 0x0002CC8C
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00005B17 File Offset: 0x00003D17
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventMoreInfoPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventMoreInfoPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;
	}
}
