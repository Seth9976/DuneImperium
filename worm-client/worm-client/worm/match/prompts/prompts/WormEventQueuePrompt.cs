using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000B9 RID: 185
	public class WormEventQueuePrompt : BasePrompt
	{
		// Token: 0x06000758 RID: 1880 RVA: 0x0002EABC File Offset: 0x0002CCBC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventQueuePrompt()
		{
			Il2CppClassPointerStore<WormEventQueuePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormEventQueuePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventQueuePrompt>.NativeClassPtr);
			WormEventQueuePrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventQueuePrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormEventQueuePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventQueuePrompt>.NativeClassPtr, 100664274);
			WormEventQueuePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventQueuePrompt>.NativeClassPtr, 100664275);
			WormEventQueuePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventQueuePrompt>.NativeClassPtr, 100664276);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0002EB3C File Offset: 0x0002CD3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 524963, RefRangeEnd = 524967, XrefRangeStart = 524963, XrefRangeEnd = 524967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventQueuePrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventQueuePrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventQueuePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0002EB88 File Offset: 0x0002CD88
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventQueuePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0002EBC8 File Offset: 0x0002CDC8
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventQueuePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00005B36 File Offset: 0x00003D36
		public WormEventQueuePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0002EBFC File Offset: 0x0002CDFC
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00005B3F File Offset: 0x00003D3F
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventQueuePrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventQueuePrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;
	}
}
