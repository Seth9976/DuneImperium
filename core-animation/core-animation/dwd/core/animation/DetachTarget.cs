using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000009 RID: 9
	public class DetachTarget : MonoBehaviour
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00003B1C File Offset: 0x00001D1C
		// Note: this type is marked as 'beforefieldinit'.
		static DetachTarget()
		{
			Il2CppClassPointerStore<DetachTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "DetachTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetachTarget>.NativeClassPtr);
			DetachTarget.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachTarget>.NativeClassPtr, "targets");
			DetachTarget.NativeMethodInfoPtr_Event_DetachIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachTarget>.NativeClassPtr, 100663334);
			DetachTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachTarget>.NativeClassPtr, 100663335);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003B88 File Offset: 0x00001D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263248, XrefRangeEnd = 1263274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DetachIndex(int targetIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachTarget.NativeMethodInfoPtr_Event_DetachIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003BC8 File Offset: 0x00001DC8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetachTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetachTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022DA File Offset: 0x000004DA
		public DetachTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003C04 File Offset: 0x00001E04
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000022E3 File Offset: 0x000004E3
		public unsafe Il2CppReferenceArray<GameObject> targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachTarget.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachTarget.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Event_DetachIndex_Public_Void_Int32_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
