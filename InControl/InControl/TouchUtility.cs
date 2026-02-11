using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005D RID: 93
	public static class TouchUtility : global::Il2CppSystem.Object
	{
		// Token: 0x0600091E RID: 2334 RVA: 0x00027E0C File Offset: 0x0002600C
		// Note: this type is marked as 'beforefieldinit'.
		static TouchUtility()
		{
			Il2CppClassPointerStore<TouchUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchUtility>.NativeClassPtr);
			TouchUtility.NativeMethodInfoPtr_AnchorToViewPoint_Public_Static_Vector2_TouchControlAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchUtility>.NativeClassPtr, 100664471);
			TouchUtility.NativeMethodInfoPtr_RoundVector_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchUtility>.NativeClassPtr, 100664472);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00027E64 File Offset: 0x00026064
		[CallerCount(0)]
		public unsafe static Vector2 AnchorToViewPoint(TouchControlAnchor touchControlAnchor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchControlAnchor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchUtility.NativeMethodInfoPtr_AnchorToViewPoint_Public_Static_Vector2_TouchControlAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00027EA4 File Offset: 0x000260A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786351, XrefRangeEnd = 786353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 RoundVector(Vector2 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchUtility.NativeMethodInfoPtr_RoundVector_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00005A6E File Offset: 0x00003C6E
		public TouchUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_AnchorToViewPoint_Public_Static_Vector2_TouchControlAnchor_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_RoundVector_Public_Static_Vector2_Vector2_0;
	}
}
