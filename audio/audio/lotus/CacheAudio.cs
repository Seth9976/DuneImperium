using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200000B RID: 11
	public class CacheAudio : MonoBehaviour
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000036E0 File Offset: 0x000018E0
		// Note: this type is marked as 'beforefieldinit'.
		static CacheAudio()
		{
			Il2CppClassPointerStore<CacheAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus", "CacheAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheAudio>.NativeClassPtr);
			CacheAudio.NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheAudio>.NativeClassPtr, "resources");
			CacheAudio.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheAudio>.NativeClassPtr, 100663325);
			CacheAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheAudio>.NativeClassPtr, 100663326);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000374C File Offset: 0x0000194C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261354, XrefRangeEnd = 1261362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheAudio.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003780 File Offset: 0x00001980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261362, XrefRangeEnd = 1261370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CacheAudio()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002286 File Offset: 0x00000486
		public CacheAudio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000037BC File Offset: 0x000019BC
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000228F File Offset: 0x0000048F
		public unsafe List<GameAudioResolver.ResolverResource> resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheAudio.NativeFieldInfoPtr_resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameAudioResolver.ResolverResource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheAudio.NativeFieldInfoPtr_resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_resources;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
