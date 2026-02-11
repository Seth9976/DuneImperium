using System;
using System.Runtime.InteropServices;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.prompts
{
	// Token: 0x020000FC RID: 252
	public class TapMozPrompt : DismissablePrompt
	{
		// Token: 0x06000AB4 RID: 2740 RVA: 0x0003F80C File Offset: 0x0003DA0C
		// Note: this type is marked as 'beforefieldinit'.
		static TapMozPrompt()
		{
			Il2CppClassPointerStore<TapMozPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompts", "TapMozPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMozPrompt>.NativeClassPtr);
			TapMozPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			TapMozPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPrompt>.NativeClassPtr, 100664872);
			TapMozPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPrompt>.NativeClassPtr, 100664873);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003F878 File Offset: 0x0003DA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507233, XrefRangeEnd = 507245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TapMozPrompt(DataComposition promptData, [Optional] Il2CppStringArray flavors)
		{
			if (flavors == null)
			{
				flavors = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMozPrompt>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flavors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0003F8E4 File Offset: 0x0003DAE4
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00007117 File Offset: 0x00005317
		public TapMozPrompt(DataComposition promptData, params string[] flavors)
			: this(promptData, new Il2CppStringArray(flavors))
		{
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00007126 File Offset: 0x00005326
		public TapMozPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0003F924 File Offset: 0x0003DB24
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0000712F File Offset: 0x0000532F
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Il2CppStringArray_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;
	}
}
