using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000BD RID: 189
	public class WormPlayerInformationPrompt : DismissablePrompt
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x0002F28C File Offset: 0x0002D48C
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerInformationPrompt()
		{
			Il2CppClassPointerStore<WormPlayerInformationPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormPlayerInformationPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInformationPrompt>.NativeClassPtr);
			WormPlayerInformationPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormPlayerInformationPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPrompt>.NativeClassPtr, 100664289);
			WormPlayerInformationPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPrompt>.NativeClassPtr, 100664290);
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002F338 File Offset: 0x0002D538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 502457, RefRangeEnd = 502462, XrefRangeStart = 502457, XrefRangeEnd = 502462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerInformationPrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInformationPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00005CD3 File Offset: 0x00003ED3
		public WormPlayerInformationPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0002F384 File Offset: 0x0002D584
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00005CDC File Offset: 0x00003EDC
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;
	}
}
