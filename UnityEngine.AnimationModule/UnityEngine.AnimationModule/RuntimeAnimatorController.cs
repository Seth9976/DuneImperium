using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public class RuntimeAnimatorController : Object
	{
		// Token: 0x0600029C RID: 668 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeAnimatorController()
		{
			Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "RuntimeAnimatorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr);
			RuntimeAnimatorController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr, 100663729);
			RuntimeAnimatorController.NativeMethodInfoPtr_get_animationClips_Public_get_Il2CppReferenceArray_1_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr, 100663730);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220840, XrefRangeEnd = 1220844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAnimatorController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAnimatorController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000FC30 File Offset: 0x0000DE30
		public unsafe Il2CppReferenceArray<AnimationClip> animationClips
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220844, XrefRangeEnd = 1220846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAnimatorController.NativeMethodInfoPtr_get_animationClips_Public_get_Il2CppReferenceArray_1_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr3) : null;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000028CF File Offset: 0x00000ACF
		public RuntimeAnimatorController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_animationClips_Public_get_Il2CppReferenceArray_1_AnimationClip_0;
	}
}
