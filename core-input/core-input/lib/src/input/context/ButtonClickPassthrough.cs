using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace lib.src.input.context
{
	// Token: 0x02000013 RID: 19
	public class ButtonClickPassthrough : MonoBehaviour
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00008D4C File Offset: 0x00006F4C
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonClickPassthrough()
		{
			Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "lib.src.input.context", "ButtonClickPassthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr);
			ButtonClickPassthrough.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr, "button");
			ButtonClickPassthrough.NativeFieldInfoPtr_triggerPointerSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr, "triggerPointerSounds");
			ButtonClickPassthrough.NativeMethodInfoPtr_Event_ClickButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr, 100663370);
			ButtonClickPassthrough.NativeMethodInfoPtr_Event_ClickButton_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr, 100663371);
			ButtonClickPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr, 100663372);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008DE0 File Offset: 0x00006FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119315, XrefRangeEnd = 1119323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ClickButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonClickPassthrough.NativeMethodInfoPtr_Event_ClickButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008E14 File Offset: 0x00007014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119323, XrefRangeEnd = 1119331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ClickButton(bool overrideTriggerPointerSounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overrideTriggerPointerSounds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonClickPassthrough.NativeMethodInfoPtr_Event_ClickButton_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00008E54 File Offset: 0x00007054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119331, XrefRangeEnd = 1119332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonClickPassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonClickPassthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonClickPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000236A File Offset: 0x0000056A
		public ButtonClickPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00008E90 File Offset: 0x00007090
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002373 File Offset: 0x00000573
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonClickPassthrough.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonClickPassthrough.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00008EC0 File Offset: 0x000070C0
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002392 File Offset: 0x00000592
		public unsafe bool triggerPointerSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonClickPassthrough.NativeFieldInfoPtr_triggerPointerSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonClickPassthrough.NativeFieldInfoPtr_triggerPointerSounds)) = value;
			}
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_triggerPointerSounds;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Event_ClickButton_Public_Void_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Event_ClickButton_Public_Void_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
