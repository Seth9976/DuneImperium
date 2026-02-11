using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class AnimationClipPair : Object
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationClipPair()
		{
			Il2CppClassPointerStore<AnimationClipPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationClipPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationClipPair>.NativeClassPtr);
			AnimationClipPair.NativeFieldInfoPtr_originalClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationClipPair>.NativeClassPtr, "originalClip");
			AnimationClipPair.NativeFieldInfoPtr_overrideClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationClipPair>.NativeClassPtr, "overrideClip");
			AnimationClipPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPair>.NativeClassPtr, 100663698);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000E860 File Offset: 0x0000CA60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationClipPair()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationClipPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002509 File Offset: 0x00000709
		public AnimationClipPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000E89C File Offset: 0x0000CA9C
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002512 File Offset: 0x00000712
		public unsafe AnimationClip originalClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationClipPair.NativeFieldInfoPtr_originalClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationClipPair.NativeFieldInfoPtr_originalClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000E8CC File Offset: 0x0000CACC
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002531 File Offset: 0x00000731
		public unsafe AnimationClip overrideClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationClipPair.NativeFieldInfoPtr_overrideClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationClipPair.NativeFieldInfoPtr_overrideClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_originalClip;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_overrideClip;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
