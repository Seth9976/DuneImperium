using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace core.animation
{
	// Token: 0x02000013 RID: 19
	public static class AnimatorExtentions : global::Il2CppSystem.Object
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00005128 File Offset: 0x00003328
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorExtentions()
		{
			Il2CppClassPointerStore<AnimatorExtentions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "core.animation", "AnimatorExtentions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorExtentions>.NativeClassPtr);
			AnimatorExtentions.NativeMethodInfoPtr_GetProperty_Public_Static_AnimatorControllerParameter_Animator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorExtentions>.NativeClassPtr, 100663393);
			AnimatorExtentions.NativeMethodInfoPtr_HasProperty_Public_Static_Boolean_Animator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorExtentions>.NativeClassPtr, 100663394);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005180 File Offset: 0x00003380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263677, XrefRangeEnd = 1263680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimatorControllerParameter GetProperty(this Animator animator, int nameHash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorExtentions.NativeMethodInfoPtr_GetProperty_Public_Static_AnimatorControllerParameter_Animator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimatorControllerParameter>(intPtr3) : null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000051D4 File Offset: 0x000033D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1263683, RefRangeEnd = 1263684, XrefRangeStart = 1263680, XrefRangeEnd = 1263683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasProperty(this Animator animator, int nameHash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorExtentions.NativeMethodInfoPtr_HasProperty_Public_Static_Boolean_Animator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002686 File Offset: 0x00000886
		public AnimatorExtentions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Static_AnimatorControllerParameter_Animator_Int32_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Static_Boolean_Animator_Int32_0;
	}
}
