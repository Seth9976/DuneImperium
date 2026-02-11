using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200008F RID: 143
	[Serializable]
	public sealed class ChromaticAberration : VolumeComponent
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x00041D9C File Offset: 0x0003FF9C
		// Note: this type is marked as 'beforefieldinit'.
		static ChromaticAberration()
		{
			Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ChromaticAberration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr);
			ChromaticAberration.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, "intensity");
			ChromaticAberration.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, 100665004);
			ChromaticAberration.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, 100665005);
			ChromaticAberration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, 100665006);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00041E1C File Offset: 0x0004001C
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberration.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00041E58 File Offset: 0x00040058
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberration.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00041E94 File Offset: 0x00040094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611925, XrefRangeEnd = 611931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChromaticAberration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public ChromaticAberration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00041ED0 File Offset: 0x000400D0
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00007BFE File Offset: 0x00005DFE
		public unsafe ClampedFloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
