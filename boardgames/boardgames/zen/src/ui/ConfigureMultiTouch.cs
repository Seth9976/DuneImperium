using System;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.ui
{
	// Token: 0x0200004C RID: 76
	public class ConfigureMultiTouch : MonoBehaviour
	{
		// Token: 0x060002FB RID: 763 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureMultiTouch()
		{
			Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.ui", "ConfigureMultiTouch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr);
			ConfigureMultiTouch.NativeFieldInfoPtr_pref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr, "pref");
			ConfigureMultiTouch.NativeFieldInfoPtr_cached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr, "cached");
			ConfigureMultiTouch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr, 100663816);
			ConfigureMultiTouch.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr, 100663817);
			ConfigureMultiTouch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr, 100663818);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0001AB34 File Offset: 0x00018D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985503, XrefRangeEnd = 985520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureMultiTouch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001AB68 File Offset: 0x00018D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985520, XrefRangeEnd = 985529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureMultiTouch.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001AB9C File Offset: 0x00018D9C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureMultiTouch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureMultiTouch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureMultiTouch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003486 File Offset: 0x00001686
		public ConfigureMultiTouch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001ABD8 File Offset: 0x00018DD8
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000348F File Offset: 0x0000168F
		public unsafe ISetting<bool> pref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureMultiTouch.NativeFieldInfoPtr_pref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISetting<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureMultiTouch.NativeFieldInfoPtr_pref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001AC08 File Offset: 0x00018E08
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000034AE File Offset: 0x000016AE
		public unsafe ulong cached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureMultiTouch.NativeFieldInfoPtr_cached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureMultiTouch.NativeFieldInfoPtr_cached)) = value;
			}
		}

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_pref;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_cached;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
