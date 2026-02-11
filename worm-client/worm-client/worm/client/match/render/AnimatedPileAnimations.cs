using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.client.match.render
{
	// Token: 0x02000298 RID: 664
	public class AnimatedPileAnimations : MonoBehaviour
	{
		// Token: 0x06001B07 RID: 6919 RVA: 0x0006B088 File Offset: 0x00069288
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatedPileAnimations()
		{
			Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "AnimatedPileAnimations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr);
			AnimatedPileAnimations.NativeFieldInfoPtr_intro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr, "intro");
			AnimatedPileAnimations.NativeFieldInfoPtr_outro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr, "outro");
			AnimatedPileAnimations.NativeMethodInfoPtr_get_Intro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr, 100667222);
			AnimatedPileAnimations.NativeMethodInfoPtr_get_Outro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr, 100667223);
			AnimatedPileAnimations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr, 100667224);
			AnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr, 100667225);
			AnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr, 100667226);
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0006B144 File Offset: 0x00069344
		public unsafe virtual TriggeredBlockingAnimation Intro
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileAnimations.NativeMethodInfoPtr_get_Intro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0006B184 File Offset: 0x00069384
		public unsafe virtual TriggeredBlockingAnimation Outro
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileAnimations.NativeMethodInfoPtr_get_Outro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0006B1C4 File Offset: 0x000693C4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatedPileAnimations()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedPileAnimations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileAnimations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0006B200 File Offset: 0x00069400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject IGameObject_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0006B240 File Offset: 0x00069440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform IGameObject_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0000FB0B File Offset: 0x0000DD0B
		public AnimatedPileAnimations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0006B280 File Offset: 0x00069480
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000FB14 File Offset: 0x0000DD14
		public unsafe TriggeredBlockingAnimation intro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileAnimations.NativeFieldInfoPtr_intro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileAnimations.NativeFieldInfoPtr_intro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0006B2B0 File Offset: 0x000694B0
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0000FB33 File Offset: 0x0000DD33
		public unsafe TriggeredBlockingAnimation outro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileAnimations.NativeFieldInfoPtr_outro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileAnimations.NativeFieldInfoPtr_outro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeFieldInfoPtr_intro;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeFieldInfoPtr_outro;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_get_Intro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_get_Outro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;
	}
}
