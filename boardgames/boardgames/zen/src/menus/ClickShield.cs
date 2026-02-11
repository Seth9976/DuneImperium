using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.menus
{
	// Token: 0x02000051 RID: 81
	public class ClickShield : MonoBehaviour
	{
		// Token: 0x06000446 RID: 1094 RVA: 0x0001D6B8 File Offset: 0x0001B8B8
		// Note: this type is marked as 'beforefieldinit'.
		static ClickShield()
		{
			Il2CppClassPointerStore<ClickShield>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "ClickShield");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickShield>.NativeClassPtr);
			ClickShield.NativeFieldInfoPtr_shield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickShield>.NativeClassPtr, "shield");
			ClickShield.NativeMethodInfoPtr_DisableClicks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickShield>.NativeClassPtr, 100663845);
			ClickShield.NativeMethodInfoPtr_EnableClicks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickShield>.NativeClassPtr, 100663846);
			ClickShield.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickShield>.NativeClassPtr, 100663847);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001D738 File Offset: 0x0001B938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985862, RefRangeEnd = 985863, XrefRangeStart = 985860, XrefRangeEnd = 985862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableClicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickShield.NativeMethodInfoPtr_DisableClicks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001D76C File Offset: 0x0001B96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985863, XrefRangeEnd = 985865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableClicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickShield.NativeMethodInfoPtr_EnableClicks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickShield()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickShield>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickShield.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00003F4B File Offset: 0x0000214B
		public ClickShield(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001D7DC File Offset: 0x0001B9DC
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00003F54 File Offset: 0x00002154
		public unsafe CanvasGroup shield
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickShield.NativeFieldInfoPtr_shield);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickShield.NativeFieldInfoPtr_shield), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_shield;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_DisableClicks_Public_Void_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_EnableClicks_Public_Void_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
