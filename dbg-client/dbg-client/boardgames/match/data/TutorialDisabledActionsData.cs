using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x0200027B RID: 635
	public class TutorialDisabledActionsData : DataComponent
	{
		// Token: 0x06001DD4 RID: 7636 RVA: 0x00080F90 File Offset: 0x0007F190
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialDisabledActionsData()
		{
			Il2CppClassPointerStore<TutorialDisabledActionsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "TutorialDisabledActionsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialDisabledActionsData>.NativeClassPtr);
			TutorialDisabledActionsData.NativeFieldInfoPtr_tutorialDisabledActionsAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialDisabledActionsData>.NativeClassPtr, "tutorialDisabledActionsAttribute");
			TutorialDisabledActionsData.NativeMethodInfoPtr_get_TutorialDisabledActionsAttribute_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDisabledActionsData>.NativeClassPtr, 100668192);
			TutorialDisabledActionsData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDisabledActionsData>.NativeClassPtr, 100668193);
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00080FFC File Offset: 0x0007F1FC
		public unsafe List<string> TutorialDisabledActionsAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 537825, RefRangeEnd = 537826, XrefRangeStart = 537821, XrefRangeEnd = 537825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialDisabledActionsData.NativeMethodInfoPtr_get_TutorialDisabledActionsAttribute_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0008103C File Offset: 0x0007F23C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialDisabledActionsData(IAttribute<List<string>> tutorialDisabledActionsAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialDisabledActionsData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tutorialDisabledActionsAttribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialDisabledActionsData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0000FC72 File Offset: 0x0000DE72
		public TutorialDisabledActionsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00081088 File Offset: 0x0007F288
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		public unsafe IAttribute<List<string>> tutorialDisabledActionsAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialDisabledActionsData.NativeFieldInfoPtr_tutorialDisabledActionsAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialDisabledActionsData.NativeFieldInfoPtr_tutorialDisabledActionsAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_tutorialDisabledActionsAttribute;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialDisabledActionsAttribute_Public_get_List_1_String_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_String_0;
	}
}
