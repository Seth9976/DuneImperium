using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace lib.src.input.context
{
	// Token: 0x02000016 RID: 22
	public class ToggleClickPassthrough : MonoBehaviour
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00009358 File Offset: 0x00007558
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleClickPassthrough()
		{
			Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "lib.src.input.context", "ToggleClickPassthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr);
			ToggleClickPassthrough.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr, "toggle");
			ToggleClickPassthrough.NativeFieldInfoPtr_triggerPointerSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr, "triggerPointerSounds");
			ToggleClickPassthrough.NativeMethodInfoPtr_Event_ClickToggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr, 100663381);
			ToggleClickPassthrough.NativeMethodInfoPtr_Event_ClickToggle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr, 100663382);
			ToggleClickPassthrough.NativeMethodInfoPtr_Event_ClickToggleOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr, 100663383);
			ToggleClickPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr, 100663384);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009400 File Offset: 0x00007600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119373, XrefRangeEnd = 1119381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ClickToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleClickPassthrough.NativeMethodInfoPtr_Event_ClickToggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009434 File Offset: 0x00007634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119381, XrefRangeEnd = 1119389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ClickToggle(bool overrideTriggerPointerSounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overrideTriggerPointerSounds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleClickPassthrough.NativeMethodInfoPtr_Event_ClickToggle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00009474 File Offset: 0x00007674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119389, XrefRangeEnd = 1119391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ClickToggleOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleClickPassthrough.NativeMethodInfoPtr_Event_ClickToggleOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000094A8 File Offset: 0x000076A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleClickPassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleClickPassthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleClickPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002468 File Offset: 0x00000668
		public ToggleClickPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000094E4 File Offset: 0x000076E4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002471 File Offset: 0x00000671
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleClickPassthrough.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleClickPassthrough.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00009514 File Offset: 0x00007714
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002490 File Offset: 0x00000690
		public unsafe bool triggerPointerSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleClickPassthrough.NativeFieldInfoPtr_triggerPointerSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleClickPassthrough.NativeFieldInfoPtr_triggerPointerSounds)) = value;
			}
		}

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_triggerPointerSounds;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Event_ClickToggle_Public_Void_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Event_ClickToggle_Public_Void_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Event_ClickToggleOff_Public_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
