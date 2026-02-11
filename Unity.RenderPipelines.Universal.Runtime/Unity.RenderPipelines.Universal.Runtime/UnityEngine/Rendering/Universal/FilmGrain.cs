using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000097 RID: 151
	[Serializable]
	public sealed class FilmGrain : VolumeComponent
	{
		// Token: 0x06000CF5 RID: 3317 RVA: 0x00042B10 File Offset: 0x00040D10
		// Note: this type is marked as 'beforefieldinit'.
		static FilmGrain()
		{
			Il2CppClassPointerStore<FilmGrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "FilmGrain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr);
			FilmGrain.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, "type");
			FilmGrain.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, "intensity");
			FilmGrain.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, "response");
			FilmGrain.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, "texture");
			FilmGrain.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100665021);
			FilmGrain.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100665022);
			FilmGrain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100665023);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00042BCC File Offset: 0x00040DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612134, XrefRangeEnd = 612135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00042C08 File Offset: 0x00040E08
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00042C44 File Offset: 0x00040E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612135, XrefRangeEnd = 612157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilmGrain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00007FA9 File Offset: 0x000061A9
		public FilmGrain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00042C80 File Offset: 0x00040E80
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00007FB2 File Offset: 0x000061B2
		public unsafe FilmGrainLookupParameter type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilmGrainLookupParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00042CB0 File Offset: 0x00040EB0
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00007FD1 File Offset: 0x000061D1
		public unsafe ClampedFloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00042CE0 File Offset: 0x00040EE0
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00007FF0 File Offset: 0x000061F0
		public unsafe ClampedFloatParameter response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00042D10 File Offset: 0x00040F10
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x0000800F File Offset: 0x0000620F
		public unsafe NoInterpTextureParameter texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoInterpTextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
