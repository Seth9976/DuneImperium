using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x0200004F RID: 79
	public static class Utils : global::Il2CppSystem.Object
	{
		// Token: 0x0600050F RID: 1295 RVA: 0x0001C21C File Offset: 0x0001A41C
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeMethodInfoPtr_Vector3FromAngle_Internal_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664270);
			Utils.NativeMethodInfoPtr_Angle2D_Internal_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664271);
			Utils.NativeMethodInfoPtr_Vector3AreApproximatelyEqual_Internal_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664272);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001C288 File Offset: 0x0001A488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1134585, RefRangeEnd = 1134588, XrefRangeStart = 1134583, XrefRangeEnd = 1134585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Vector3FromAngle(float degrees, float magnitude)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref degrees;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref magnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Vector3FromAngle_Internal_Static_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134600, RefRangeEnd = 1134601, XrefRangeStart = 1134588, XrefRangeEnd = 1134600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle2D(Vector3 from, Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Angle2D_Internal_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001C320 File Offset: 0x0001A520
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 860302, RefRangeEnd = 860307, XrefRangeStart = 860302, XrefRangeEnd = 860307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Vector3AreApproximatelyEqual_Internal_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00003AC1 File Offset: 0x00001CC1
		public Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_Vector3FromAngle_Internal_Static_Vector3_Single_Single_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_Angle2D_Internal_Static_Single_Vector3_Vector3_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_Vector3AreApproximatelyEqual_Internal_Static_Boolean_Vector3_Vector3_0;
	}
}
