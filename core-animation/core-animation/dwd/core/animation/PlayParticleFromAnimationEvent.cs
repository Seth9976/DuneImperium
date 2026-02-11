using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x0200000C RID: 12
	public class PlayParticleFromAnimationEvent : MonoBehaviour
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00004008 File Offset: 0x00002208
		// Note: this type is marked as 'beforefieldinit'.
		static PlayParticleFromAnimationEvent()
		{
			Il2CppClassPointerStore<PlayParticleFromAnimationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "PlayParticleFromAnimationEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayParticleFromAnimationEvent>.NativeClassPtr);
			PlayParticleFromAnimationEvent.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayParticleFromAnimationEvent>.NativeClassPtr, "particles");
			PlayParticleFromAnimationEvent.NativeMethodInfoPtr_PlayParticle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayParticleFromAnimationEvent>.NativeClassPtr, 100663347);
			PlayParticleFromAnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayParticleFromAnimationEvent>.NativeClassPtr, 100663348);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004074 File Offset: 0x00002274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263300, XrefRangeEnd = 1263302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayParticle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayParticleFromAnimationEvent.NativeMethodInfoPtr_PlayParticle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000040A8 File Offset: 0x000022A8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayParticleFromAnimationEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayParticleFromAnimationEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayParticleFromAnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000023FC File Offset: 0x000005FC
		public PlayParticleFromAnimationEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000040E4 File Offset: 0x000022E4
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002405 File Offset: 0x00000605
		public unsafe ParticleSystem particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayParticleFromAnimationEvent.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayParticleFromAnimationEvent.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_PlayParticle_Public_Void_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
