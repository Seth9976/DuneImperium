using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.animation
{
	// Token: 0x020002BC RID: 700
	public class DetachChildParticles : MonoBehaviour
	{
		// Token: 0x060020FD RID: 8445 RVA: 0x0008B3B4 File Offset: 0x000895B4
		// Note: this type is marked as 'beforefieldinit'.
		static DetachChildParticles()
		{
			Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.animation", "DetachChildParticles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr);
			DetachChildParticles.NativeFieldInfoPtr_systems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr, "systems");
			DetachChildParticles.NativeFieldInfoPtr_onDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr, "onDestroy");
			DetachChildParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr, 100668759);
			DetachChildParticles.NativeMethodInfoPtr_Event_DetachParticles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr, 100668760);
			DetachChildParticles.NativeMethodInfoPtr_DetachParticles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr, 100668761);
			DetachChildParticles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr, 100668762);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x0008B45C File Offset: 0x0008965C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542906, XrefRangeEnd = 542907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachChildParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0008B490 File Offset: 0x00089690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542907, XrefRangeEnd = 542908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DetachParticles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachChildParticles.NativeMethodInfoPtr_Event_DetachParticles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x0008B4C4 File Offset: 0x000896C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 542921, RefRangeEnd = 542923, XrefRangeStart = 542908, XrefRangeEnd = 542921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachParticles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachChildParticles.NativeMethodInfoPtr_DetachParticles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x0008B4F8 File Offset: 0x000896F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542923, XrefRangeEnd = 542928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetachChildParticles()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetachChildParticles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachChildParticles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0001141A File Offset: 0x0000F61A
		public DetachChildParticles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x0008B534 File Offset: 0x00089734
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x00011423 File Offset: 0x0000F623
		public unsafe Il2CppReferenceArray<ParticleSystem> systems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachChildParticles.NativeFieldInfoPtr_systems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachChildParticles.NativeFieldInfoPtr_systems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x0008B564 File Offset: 0x00089764
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x00011442 File Offset: 0x0000F642
		public unsafe bool onDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachChildParticles.NativeFieldInfoPtr_onDestroy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachChildParticles.NativeFieldInfoPtr_onDestroy)) = value;
			}
		}

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_systems;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_onDestroy;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_Event_DetachParticles_Public_Void_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_DetachParticles_Private_Void_0;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
