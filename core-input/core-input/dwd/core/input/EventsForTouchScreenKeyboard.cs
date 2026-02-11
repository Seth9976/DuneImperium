using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.input
{
	// Token: 0x02000041 RID: 65
	public class EventsForTouchScreenKeyboard : MonoBehaviour
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x0000CD88 File Offset: 0x0000AF88
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForTouchScreenKeyboard()
		{
			Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "EventsForTouchScreenKeyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr);
			EventsForTouchScreenKeyboard.NativeFieldInfoPtr_keyboardDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr, "keyboardDisplayed");
			EventsForTouchScreenKeyboard.NativeFieldInfoPtr_onKeyboardEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr, "onKeyboardEnabled");
			EventsForTouchScreenKeyboard.NativeFieldInfoPtr_onKeyboardDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr, "onKeyboardDisabled");
			EventsForTouchScreenKeyboard.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr, 100663552);
			EventsForTouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr, 100663553);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000CE1C File Offset: 0x0000B01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120355, XrefRangeEnd = 1120358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForTouchScreenKeyboard.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000CE50 File Offset: 0x0000B050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120358, XrefRangeEnd = 1120368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForTouchScreenKeyboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForTouchScreenKeyboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForTouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00003242 File Offset: 0x00001442
		public EventsForTouchScreenKeyboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000CE8C File Offset: 0x0000B08C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000324B File Offset: 0x0000144B
		public unsafe bool keyboardDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForTouchScreenKeyboard.NativeFieldInfoPtr_keyboardDisplayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForTouchScreenKeyboard.NativeFieldInfoPtr_keyboardDisplayed)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00003266 File Offset: 0x00001466
		public unsafe UnityEvent onKeyboardEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForTouchScreenKeyboard.NativeFieldInfoPtr_onKeyboardEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForTouchScreenKeyboard.NativeFieldInfoPtr_onKeyboardEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00003285 File Offset: 0x00001485
		public unsafe UnityEvent onKeyboardDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForTouchScreenKeyboard.NativeFieldInfoPtr_onKeyboardDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForTouchScreenKeyboard.NativeFieldInfoPtr_onKeyboardDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_keyboardDisplayed;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_onKeyboardEnabled;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_onKeyboardDisabled;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
