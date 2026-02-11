using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.eventtriggers.clientactions
{
	// Token: 0x020000BD RID: 189
	public class ShowPopup : ClientAction
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00016138 File Offset: 0x00014338
		// Note: this type is marked as 'beforefieldinit'.
		static ShowPopup()
		{
			Il2CppClassPointerStore<ShowPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.eventtriggers.clientactions", "ShowPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr);
			ShowPopup.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr, "Text");
			ShowPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr, "Title");
			ShowPopup.NativeFieldInfoPtr_InstructionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr, "InstructionString");
			ShowPopup.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr, "Handle");
			ShowPopup.NativeFieldInfoPtr_Blocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr, "Blocking");
			ShowPopup.NativeFieldInfoPtr_Modal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr, "Modal");
			ShowPopup.NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_LocalizableText_LocalizableText_PopupID_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr, 100663674);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000161F4 File Offset: 0x000143F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1195334, RefRangeEnd = 1195336, XrefRangeStart = 1195329, XrefRangeEnd = 1195334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowPopup(LocalizableText text, LocalizableText title, LocalizableText instructionString, PopupID handle, bool blocking, bool modal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowPopup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instructionString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowPopup.NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_LocalizableText_LocalizableText_PopupID_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00005D63 File Offset: 0x00003F63
		public ShowPopup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00016294 File Offset: 0x00014494
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00005D6C File Offset: 0x00003F6C
		public unsafe LocalizableText Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x000162C4 File Offset: 0x000144C4
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00005D8B File Offset: 0x00003F8B
		public unsafe LocalizableText Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x000162F4 File Offset: 0x000144F4
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005DAA File Offset: 0x00003FAA
		public unsafe LocalizableText InstructionString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_InstructionString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_InstructionString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00016324 File Offset: 0x00014524
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005DC9 File Offset: 0x00003FC9
		public unsafe PopupID Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PopupID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00016354 File Offset: 0x00014554
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00005DE8 File Offset: 0x00003FE8
		public unsafe bool Blocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Blocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Blocking)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001637C File Offset: 0x0001457C
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00005E03 File Offset: 0x00004003
		public unsafe bool Modal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Modal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowPopup.NativeFieldInfoPtr_Modal)) = value;
			}
		}

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_InstructionString;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_Blocking;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_Modal;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_LocalizableText_LocalizableText_PopupID_Boolean_Boolean_0;
	}
}
