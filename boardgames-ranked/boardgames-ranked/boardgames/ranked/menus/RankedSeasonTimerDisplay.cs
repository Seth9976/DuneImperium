using System;
using boardgames.menus.ui;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.ranked.menus
{
	// Token: 0x0200002C RID: 44
	public class RankedSeasonTimerDisplay : TimerDisplay
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00007E20 File Offset: 0x00006020
		// Note: this type is marked as 'beforefieldinit'.
		static RankedSeasonTimerDisplay()
		{
			Il2CppClassPointerStore<RankedSeasonTimerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedSeasonTimerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedSeasonTimerDisplay>.NativeClassPtr);
			RankedSeasonTimerDisplay.NativeFieldInfoPtr_daysLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonTimerDisplay>.NativeClassPtr, "daysLocKey");
			RankedSeasonTimerDisplay.NativeFieldInfoPtr_titleLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonTimerDisplay>.NativeClassPtr, "titleLocKey");
			RankedSeasonTimerDisplay.NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSeasonTimerDisplay>.NativeClassPtr, 100663436);
			RankedSeasonTimerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSeasonTimerDisplay>.NativeClassPtr, 100663437);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007EA0 File Offset: 0x000060A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225788, XrefRangeEnd = 1225809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayText(TimeSpan time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedSeasonTimerDisplay.NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_String_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007EF0 File Offset: 0x000060F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225809, XrefRangeEnd = 1225815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedSeasonTimerDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedSeasonTimerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedSeasonTimerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002F4A File Offset: 0x0000114A
		public RankedSeasonTimerDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00007F2C File Offset: 0x0000612C
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002F53 File Offset: 0x00001153
		public unsafe string daysLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonTimerDisplay.NativeFieldInfoPtr_daysLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonTimerDisplay.NativeFieldInfoPtr_daysLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00007F54 File Offset: 0x00006154
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002F72 File Offset: 0x00001172
		public unsafe string titleLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonTimerDisplay.NativeFieldInfoPtr_titleLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonTimerDisplay.NativeFieldInfoPtr_titleLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_daysLocKey;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_titleLocKey;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_String_TimeSpan_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
