using System;
using boardgames.menus.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace dwd.canis
{
	// Token: 0x0200004E RID: 78
	public class TutorialRequiresDLCPromptBehaviour : PromptBehaviour<TutorialRequiresDLCPrompt>
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x00026E00 File Offset: 0x00025000
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialRequiresDLCPromptBehaviour()
		{
			Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "TutorialRequiresDLCPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr);
			TutorialRequiresDLCPromptBehaviour.NativeFieldInfoPtr_shopButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr, "shopButton");
			TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr, 100663771);
			TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Event_Shop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr, 100663772);
			TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr, 100663773);
			TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr, 100663774);
			TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr, 100663775);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00026EA8 File Offset: 0x000250A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499311, XrefRangeEnd = 499328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00026EDC File Offset: 0x000250DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499328, XrefRangeEnd = 499333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Shop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Event_Shop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00026F10 File Offset: 0x00025110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499333, XrefRangeEnd = 499338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00026F44 File Offset: 0x00025144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499338, XrefRangeEnd = 499343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00026F78 File Offset: 0x00025178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499343, XrefRangeEnd = 499346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialRequiresDLCPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialRequiresDLCPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003528 File Offset: 0x00001728
		public TutorialRequiresDLCPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00026FB4 File Offset: 0x000251B4
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00003531 File Offset: 0x00001731
		public unsafe Button shopButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialRequiresDLCPromptBehaviour.NativeFieldInfoPtr_shopButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialRequiresDLCPromptBehaviour.NativeFieldInfoPtr_shopButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_shopButton;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_Event_Shop_Public_Void_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_Event_Play_Public_Void_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
