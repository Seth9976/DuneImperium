using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.animation
{
	// Token: 0x020002BB RID: 699
	public class AnimatorConsistentTimeScale : MonoBehaviour
	{
		// Token: 0x060020F4 RID: 8436 RVA: 0x0008B224 File Offset: 0x00089424
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorConsistentTimeScale()
		{
			Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.animation", "AnimatorConsistentTimeScale");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr);
			AnimatorConsistentTimeScale.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr, "anim");
			AnimatorConsistentTimeScale.NativeFieldInfoPtr_cachedTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr, "cachedTimeScale");
			AnimatorConsistentTimeScale.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr, 100668756);
			AnimatorConsistentTimeScale.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr, 100668757);
			AnimatorConsistentTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr, 100668758);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0008B2B8 File Offset: 0x000894B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542897, XrefRangeEnd = 542901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorConsistentTimeScale.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x0008B2EC File Offset: 0x000894EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542901, XrefRangeEnd = 542905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorConsistentTimeScale.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0008B320 File Offset: 0x00089520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542905, XrefRangeEnd = 542906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorConsistentTimeScale()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorConsistentTimeScale>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorConsistentTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000113D7 File Offset: 0x0000F5D7
		public AnimatorConsistentTimeScale(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x0008B35C File Offset: 0x0008955C
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x000113E0 File Offset: 0x0000F5E0
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorConsistentTimeScale.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorConsistentTimeScale.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x0008B38C File Offset: 0x0008958C
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x000113FF File Offset: 0x0000F5FF
		public unsafe float cachedTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorConsistentTimeScale.NativeFieldInfoPtr_cachedTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorConsistentTimeScale.NativeFieldInfoPtr_cachedTimeScale)) = value;
			}
		}

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_cachedTimeScale;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
