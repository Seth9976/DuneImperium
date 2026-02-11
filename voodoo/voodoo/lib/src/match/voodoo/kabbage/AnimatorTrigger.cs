using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace lib.src.match.voodoo.kabbage
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public sealed class AnimatorTrigger : ValueType
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00009CD4 File Offset: 0x00007ED4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorTrigger()
		{
			Il2CppClassPointerStore<AnimatorTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.src.match.voodoo.kabbage", "AnimatorTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorTrigger>.NativeClassPtr);
			AnimatorTrigger.NativeFieldInfoPtr_triggerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTrigger>.NativeClassPtr, "triggerName");
			AnimatorTrigger.NativeFieldInfoPtr_fxAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTrigger>.NativeClassPtr, "fxAnimator");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000225D File Offset: 0x0000045D
		public AnimatorTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002266 File Offset: 0x00000466
		public AnimatorTrigger()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorTrigger>.NativeClassPtr))
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00009D2C File Offset: 0x00007F2C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002278 File Offset: 0x00000478
		public unsafe string triggerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTrigger.NativeFieldInfoPtr_triggerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTrigger.NativeFieldInfoPtr_triggerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00009D54 File Offset: 0x00007F54
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002297 File Offset: 0x00000497
		public unsafe Animator fxAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTrigger.NativeFieldInfoPtr_fxAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTrigger.NativeFieldInfoPtr_fxAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_triggerName;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_fxAnimator;
	}
}
