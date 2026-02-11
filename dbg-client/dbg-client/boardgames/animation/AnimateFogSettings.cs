using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.animation
{
	// Token: 0x020002B7 RID: 695
	public class AnimateFogSettings : MonoBehaviour
	{
		// Token: 0x060020CA RID: 8394 RVA: 0x0008AAD8 File Offset: 0x00088CD8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimateFogSettings()
		{
			Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.animation", "AnimateFogSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr);
			AnimateFogSettings.NativeFieldInfoPtr_show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, "show");
			AnimateFogSettings.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, "color");
			AnimateFogSettings.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, "mode");
			AnimateFogSettings.NativeFieldInfoPtr_startDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, "startDistance");
			AnimateFogSettings.NativeFieldInfoPtr_endDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, "endDistance");
			AnimateFogSettings.NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, "density");
			AnimateFogSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, 100668742);
			AnimateFogSettings.NativeMethodInfoPtr_ForceUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, 100668743);
			AnimateFogSettings.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, 100668744);
			AnimateFogSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr, 100668745);
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x0008ABD0 File Offset: 0x00088DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542800, XrefRangeEnd = 542806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateFogSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x0008AC04 File Offset: 0x00088E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 542807, RefRangeEnd = 542808, XrefRangeStart = 542806, XrefRangeEnd = 542807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateFogSettings.NativeMethodInfoPtr_ForceUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0008AC38 File Offset: 0x00088E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 542823, RefRangeEnd = 542824, XrefRangeStart = 542808, XrefRangeEnd = 542823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateFogSettings.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x0008AC6C File Offset: 0x00088E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542824, XrefRangeEnd = 542825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimateFogSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateFogSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateFogSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00011299 File Offset: 0x0000F499
		public AnimateFogSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0008ACA8 File Offset: 0x00088EA8
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x000112A2 File Offset: 0x0000F4A2
		public unsafe bool show
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_show);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_show)) = value;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0008ACD0 File Offset: 0x00088ED0
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x000112BD File Offset: 0x0000F4BD
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0008ACF8 File Offset: 0x00088EF8
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x000112D8 File Offset: 0x0000F4D8
		public unsafe FogMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0008AD20 File Offset: 0x00088F20
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x000112F3 File Offset: 0x0000F4F3
		public unsafe float startDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_startDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_startDistance)) = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0008AD48 File Offset: 0x00088F48
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0001130E File Offset: 0x0000F50E
		public unsafe float endDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_endDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_endDistance)) = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x0008AD70 File Offset: 0x00088F70
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x00011329 File Offset: 0x0000F529
		public unsafe float density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateFogSettings.NativeFieldInfoPtr_density)) = value;
			}
		}

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeFieldInfoPtr_show;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr_startDistance;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr_endDistance;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_density;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_Public_Void_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
