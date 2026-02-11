using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001EA RID: 490
	public class WormEnableInSpecificSkirmish : MonoBehaviour
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x0005A148 File Offset: 0x00058348
		// Note: this type is marked as 'beforefieldinit'.
		static WormEnableInSpecificSkirmish()
		{
			Il2CppClassPointerStore<WormEnableInSpecificSkirmish>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEnableInSpecificSkirmish");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEnableInSpecificSkirmish>.NativeClassPtr);
			WormEnableInSpecificSkirmish.NativeFieldInfoPtr_toEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnableInSpecificSkirmish>.NativeClassPtr, "toEnable");
			WormEnableInSpecificSkirmish.NativeFieldInfoPtr_skirmishRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnableInSpecificSkirmish>.NativeClassPtr, "skirmishRule");
			WormEnableInSpecificSkirmish.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnableInSpecificSkirmish>.NativeClassPtr, 100666300);
			WormEnableInSpecificSkirmish.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnableInSpecificSkirmish>.NativeClassPtr, 100666301);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0005A1C8 File Offset: 0x000583C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715725, XrefRangeEnd = 715757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnableInSpecificSkirmish.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0005A1FC File Offset: 0x000583FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715757, XrefRangeEnd = 715765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEnableInSpecificSkirmish()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEnableInSpecificSkirmish>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnableInSpecificSkirmish.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0000D214 File Offset: 0x0000B414
		public WormEnableInSpecificSkirmish(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x0005A238 File Offset: 0x00058438
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0000D21D File Offset: 0x0000B41D
		public unsafe List<GameObject> toEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnableInSpecificSkirmish.NativeFieldInfoPtr_toEnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnableInSpecificSkirmish.NativeFieldInfoPtr_toEnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x0005A268 File Offset: 0x00058468
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0000D23C File Offset: 0x0000B43C
		public unsafe int skirmishRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnableInSpecificSkirmish.NativeFieldInfoPtr_skirmishRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnableInSpecificSkirmish.NativeFieldInfoPtr_skirmishRule)) = value;
			}
		}

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeFieldInfoPtr_toEnable;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeFieldInfoPtr_skirmishRule;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
