using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000092 RID: 146
	[Serializable]
	public sealed class ColorLookup : VolumeComponent
	{
		// Token: 0x06000CCD RID: 3277 RVA: 0x000424B4 File Offset: 0x000406B4
		// Note: this type is marked as 'beforefieldinit'.
		static ColorLookup()
		{
			Il2CppClassPointerStore<ColorLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ColorLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr);
			ColorLookup.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr, "texture");
			ColorLookup.NativeFieldInfoPtr_contribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr, "contribution");
			ColorLookup.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr, 100665013);
			ColorLookup.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr, 100665014);
			ColorLookup.NativeMethodInfoPtr_ValidateLUT_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr, 100665015);
			ColorLookup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr, 100665016);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0004255C File Offset: 0x0004075C
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorLookup.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00042598 File Offset: 0x00040798
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorLookup.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000425D4 File Offset: 0x000407D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612065, RefRangeEnd = 612066, XrefRangeStart = 612047, XrefRangeEnd = 612065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateLUT()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorLookup.NativeMethodInfoPtr_ValidateLUT_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00042610 File Offset: 0x00040810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612066, XrefRangeEnd = 612077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorLookup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00007DC2 File Offset: 0x00005FC2
		public ColorLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0004264C File Offset: 0x0004084C
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00007DCB File Offset: 0x00005FCB
		public unsafe TextureParameter texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorLookup.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorLookup.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0004267C File Offset: 0x0004087C
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00007DEA File Offset: 0x00005FEA
		public unsafe ClampedFloatParameter contribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorLookup.NativeFieldInfoPtr_contribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorLookup.NativeFieldInfoPtr_contribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_contribution;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLUT_Public_Boolean_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
