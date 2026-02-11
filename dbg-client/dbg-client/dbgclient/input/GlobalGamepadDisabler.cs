using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dbgclient.input
{
	// Token: 0x020000AC RID: 172
	public class GlobalGamepadDisabler : MonoBehaviour
	{
		// Token: 0x060006E6 RID: 1766 RVA: 0x0003357C File Offset: 0x0003177C
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalGamepadDisabler()
		{
			Il2CppClassPointerStore<GlobalGamepadDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.input", "GlobalGamepadDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalGamepadDisabler>.NativeClassPtr);
			GlobalGamepadDisabler.NativeFieldInfoPtr_forceDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalGamepadDisabler>.NativeClassPtr, "forceDisabled");
			GlobalGamepadDisabler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalGamepadDisabler>.NativeClassPtr, 100664370);
			GlobalGamepadDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalGamepadDisabler>.NativeClassPtr, 100664371);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000335E8 File Offset: 0x000317E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503930, XrefRangeEnd = 503934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalGamepadDisabler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0003361C File Offset: 0x0003181C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalGamepadDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalGamepadDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalGamepadDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000052AB File Offset: 0x000034AB
		public GlobalGamepadDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00033658 File Offset: 0x00031858
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000052B4 File Offset: 0x000034B4
		public unsafe bool forceDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalGamepadDisabler.NativeFieldInfoPtr_forceDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalGamepadDisabler.NativeFieldInfoPtr_forceDisabled)) = value;
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_forceDisabled;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
