using System;
using dwd.core.data.composition;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.prompts
{
	// Token: 0x020000FD RID: 253
	public class TutorialPrompt : FlavoredDismissablePrompt
	{
		// Token: 0x06000ABB RID: 2747 RVA: 0x0003F954 File Offset: 0x0003DB54
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialPrompt()
		{
			Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompts", "TutorialPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr);
			TutorialPrompt.NativeFieldInfoPtr__DialogType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr, "<DialogType>k__BackingField");
			TutorialPrompt.NativeMethodInfoPtr_get_DialogType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr, 100664874);
			TutorialPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr, 100664875);
			TutorialPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr, 100664876);
			TutorialPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr, 100664877);
			TutorialPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr, 100664878);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0003F9FC File Offset: 0x0003DBFC
		public unsafe string DialogType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPrompt.NativeMethodInfoPtr_get_DialogType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0003FA34 File Offset: 0x0003DC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507245, XrefRangeEnd = 507250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialPrompt(DataComposition data, string dialogType, IEnumerable<string> additionalTags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0003FAA4 File Offset: 0x0003DCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507250, XrefRangeEnd = 507252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialPrompt(DataComposition data, string dialogType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0003FB04 File Offset: 0x0003DD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507252, XrefRangeEnd = 507256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0003FB54 File Offset: 0x0003DD54
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0000714E File Offset: 0x0000534E
		public TutorialPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0003FB90 File Offset: 0x0003DD90
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00007157 File Offset: 0x00005357
		public unsafe string _DialogType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPrompt.NativeFieldInfoPtr__DialogType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPrompt.NativeFieldInfoPtr__DialogType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr__DialogType_k__BackingField;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_get_DialogType_Public_get_String_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_IEnumerable_1_String_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0;
	}
}
