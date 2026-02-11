using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001FF RID: 511
	public class TutorialSelectPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x06001785 RID: 6021 RVA: 0x00069EC8 File Offset: 0x000680C8
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialSelectPrompt()
		{
			Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "TutorialSelectPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr);
			TutorialSelectPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr, "<Result>k__BackingField");
			TutorialSelectPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr, 100666734);
			TutorialSelectPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr, 100666735);
			TutorialSelectPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr, 100666736);
			TutorialSelectPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr, 100666737);
			TutorialSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr, 100666738);
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x00069F70 File Offset: 0x00068170
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x00069FB0 File Offset: 0x000681B0
		public unsafe virtual DataComposition Result
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00069FF4 File Offset: 0x000681F4
		[CallerCount(0)]
		public unsafe override void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialSelectPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0006A030 File Offset: 0x00068230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525283, RefRangeEnd = 525284, XrefRangeStart = 525282, XrefRangeEnd = 525283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(DataComposition result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0006A074 File Offset: 0x00068274
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 524574, RefRangeEnd = 524584, XrefRangeStart = 524574, XrefRangeEnd = 524584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialSelectPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0000D1DE File Offset: 0x0000B3DE
		public TutorialSelectPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0006A0B0 File Offset: 0x000682B0
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x0000D1E7 File Offset: 0x0000B3E7
		public unsafe DataComposition _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_DataComposition_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_DataComposition_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
