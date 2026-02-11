using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x0200000D RID: 13
	public class PlayParticleFromAnimationEventIndexed : MonoBehaviour
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00004114 File Offset: 0x00002314
		// Note: this type is marked as 'beforefieldinit'.
		static PlayParticleFromAnimationEventIndexed()
		{
			Il2CppClassPointerStore<PlayParticleFromAnimationEventIndexed>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "PlayParticleFromAnimationEventIndexed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayParticleFromAnimationEventIndexed>.NativeClassPtr);
			PlayParticleFromAnimationEventIndexed.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayParticleFromAnimationEventIndexed>.NativeClassPtr, "particles");
			PlayParticleFromAnimationEventIndexed.NativeMethodInfoPtr_PlayParticle_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayParticleFromAnimationEventIndexed>.NativeClassPtr, 100663349);
			PlayParticleFromAnimationEventIndexed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayParticleFromAnimationEventIndexed>.NativeClassPtr, 100663350);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004180 File Offset: 0x00002380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263302, XrefRangeEnd = 1263323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayParticle(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayParticleFromAnimationEventIndexed.NativeMethodInfoPtr_PlayParticle_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000041C0 File Offset: 0x000023C0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayParticleFromAnimationEventIndexed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayParticleFromAnimationEventIndexed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayParticleFromAnimationEventIndexed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002424 File Offset: 0x00000624
		public PlayParticleFromAnimationEventIndexed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000041FC File Offset: 0x000023FC
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000242D File Offset: 0x0000062D
		public unsafe Il2CppReferenceArray<ParticleSystem> particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayParticleFromAnimationEventIndexed.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayParticleFromAnimationEventIndexed.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_PlayParticle_Public_Void_Int32_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
