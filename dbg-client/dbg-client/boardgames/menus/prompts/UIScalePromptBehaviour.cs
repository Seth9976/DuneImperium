using System;
using boardgames.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001DE RID: 478
	public class UIScalePromptBehaviour : PromptBehaviour<UIScalePrompt>
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x00064FD8 File Offset: 0x000631D8
		// Note: this type is marked as 'beforefieldinit'.
		static UIScalePromptBehaviour()
		{
			Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "UIScalePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr);
			UIScalePromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr, "confirmButton");
			UIScalePromptBehaviour.NativeFieldInfoPtr_selectedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr, "selectedScale");
			UIScalePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr, 100666535);
			UIScalePromptBehaviour.NativeMethodInfoPtr_Event_UIScaleToggleOn_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr, 100666536);
			UIScalePromptBehaviour.NativeMethodInfoPtr_Event_UIScaleToggleOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr, 100666537);
			UIScalePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr, 100666538);
			UIScalePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr, 100666539);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00065094 File Offset: 0x00063294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523810, XrefRangeEnd = 523812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScalePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000650D0 File Offset: 0x000632D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523812, XrefRangeEnd = 523814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UIScaleToggleOn(int scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalePromptBehaviour.NativeMethodInfoPtr_Event_UIScaleToggleOn_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00065110 File Offset: 0x00063310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523814, XrefRangeEnd = 523816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UIScaleToggleOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalePromptBehaviour.NativeMethodInfoPtr_Event_UIScaleToggleOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00065144 File Offset: 0x00063344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523816, XrefRangeEnd = 523823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00065178 File Offset: 0x00063378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523823, XrefRangeEnd = 523826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScalePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScalePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0000C8B3 File Offset: 0x0000AAB3
		public UIScalePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x000651B4 File Offset: 0x000633B4
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x0000C8BC File Offset: 0x0000AABC
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalePromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalePromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x000651E4 File Offset: 0x000633E4
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x0000C8DB File Offset: 0x0000AADB
		public unsafe int selectedScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalePromptBehaviour.NativeFieldInfoPtr_selectedScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalePromptBehaviour.NativeFieldInfoPtr_selectedScale)) = value;
			}
		}

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeFieldInfoPtr_selectedScale;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_Event_UIScaleToggleOn_Public_Void_Int32_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_Event_UIScaleToggleOff_Public_Void_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
