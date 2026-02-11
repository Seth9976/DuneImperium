using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.canis.core_animation.src
{
	// Token: 0x02000003 RID: 3
	public class PauseParticleFromAnimationEvent : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002C58 File Offset: 0x00000E58
		// Note: this type is marked as 'beforefieldinit'.
		static PauseParticleFromAnimationEvent()
		{
			Il2CppClassPointerStore<PauseParticleFromAnimationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "lib.canis.core_animation.src", "PauseParticleFromAnimationEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseParticleFromAnimationEvent>.NativeClassPtr);
			PauseParticleFromAnimationEvent.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseParticleFromAnimationEvent>.NativeClassPtr, "particles");
			PauseParticleFromAnimationEvent.NativeMethodInfoPtr_PauseParticle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseParticleFromAnimationEvent>.NativeClassPtr, 100663299);
			PauseParticleFromAnimationEvent.NativeMethodInfoPtr_PauseParticleAndChildren_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseParticleFromAnimationEvent>.NativeClassPtr, 100663300);
			PauseParticleFromAnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseParticleFromAnimationEvent>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002CD8 File Offset: 0x00000ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263121, XrefRangeEnd = 1263123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseParticle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseParticleFromAnimationEvent.NativeMethodInfoPtr_PauseParticle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002D0C File Offset: 0x00000F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263123, XrefRangeEnd = 1263125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseParticleAndChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseParticleFromAnimationEvent.NativeMethodInfoPtr_PauseParticleAndChildren_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002D40 File Offset: 0x00000F40
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PauseParticleFromAnimationEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseParticleFromAnimationEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseParticleFromAnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002059 File Offset: 0x00000259
		public PauseParticleFromAnimationEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002D7C File Offset: 0x00000F7C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe ParticleSystem particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseParticleFromAnimationEvent.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseParticleFromAnimationEvent.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_PauseParticle_Public_Void_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_PauseParticleAndChildren_Public_Void_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
