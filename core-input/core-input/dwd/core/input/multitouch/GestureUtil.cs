using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.input.multitouch
{
	// Token: 0x02000069 RID: 105
	public static class GestureUtil : global::Il2CppSystem.Object
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00013240 File Offset: 0x00011440
		// Note: this type is marked as 'beforefieldinit'.
		static GestureUtil()
		{
			Il2CppClassPointerStore<GestureUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "GestureUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GestureUtil>.NativeClassPtr);
			GestureUtil.NativeMethodInfoPtr_GetCenterPoint_Public_Static_Vector2_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureUtil>.NativeClassPtr, 100663739);
			GestureUtil.NativeMethodInfoPtr_GetAngle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureUtil>.NativeClassPtr, 100663740);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00013298 File Offset: 0x00011498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122234, XrefRangeEnd = 1122249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetCenterPoint(this Gesture gesture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gesture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureUtil.NativeMethodInfoPtr_GetCenterPoint_Public_Static_Vector2_Gesture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000132DC File Offset: 0x000114DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122249, XrefRangeEnd = 1122250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAngle(Vector2 from, Vector2 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureUtil.NativeMethodInfoPtr_GetAngle_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00004475 File Offset: 0x00002675
		public GestureUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_GetCenterPoint_Public_Static_Vector2_Gesture_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_GetAngle_Public_Static_Single_Vector2_Vector2_0;
	}
}
