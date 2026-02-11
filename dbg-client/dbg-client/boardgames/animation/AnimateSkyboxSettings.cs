using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.animation
{
	// Token: 0x020002B8 RID: 696
	public class AnimateSkyboxSettings : MonoBehaviour
	{
		// Token: 0x060020DC RID: 8412 RVA: 0x0008AD98 File Offset: 0x00088F98
		// Note: this type is marked as 'beforefieldinit'.
		static AnimateSkyboxSettings()
		{
			Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.animation", "AnimateSkyboxSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr);
			AnimateSkyboxSettings.NativeFieldInfoPtr_skyboxMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr, "skyboxMaterial");
			AnimateSkyboxSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr, 100668746);
			AnimateSkyboxSettings.NativeMethodInfoPtr_ForceUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr, 100668747);
			AnimateSkyboxSettings.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr, 100668748);
			AnimateSkyboxSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr, 100668749);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x0008AE2C File Offset: 0x0008902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542825, XrefRangeEnd = 542827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateSkyboxSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x0008AE60 File Offset: 0x00089060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542827, XrefRangeEnd = 542833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateSkyboxSettings.NativeMethodInfoPtr_ForceUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0008AE94 File Offset: 0x00089094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateSkyboxSettings.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0008AEC8 File Offset: 0x000890C8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimateSkyboxSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateSkyboxSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateSkyboxSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00011344 File Offset: 0x0000F544
		public AnimateSkyboxSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0008AF04 File Offset: 0x00089104
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x0001134D File Offset: 0x0000F54D
		public unsafe Material skyboxMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateSkyboxSettings.NativeFieldInfoPtr_skyboxMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateSkyboxSettings.NativeFieldInfoPtr_skyboxMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_skyboxMaterial;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_Public_Void_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
