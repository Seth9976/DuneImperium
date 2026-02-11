using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.utils
{
	// Token: 0x020000F4 RID: 244
	public static class HexMath : global::Il2CppSystem.Object
	{
		// Token: 0x06000A76 RID: 2678 RVA: 0x0003E46C File Offset: 0x0003C66C
		// Note: this type is marked as 'beforefieldinit'.
		static HexMath()
		{
			Il2CppClassPointerStore<HexMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.utils", "HexMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HexMath>.NativeClassPtr);
			HexMath.NativeMethodInfoPtr_HexWidth_Public_Static_Single_Single_HexOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexMath>.NativeClassPtr, 100664801);
			HexMath.NativeMethodInfoPtr_HexHeight_Public_Static_Single_Single_HexOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexMath>.NativeClassPtr, 100664802);
			HexMath.NativeMethodInfoPtr_HexHSpacing_Public_Static_Single_Single_HexOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexMath>.NativeClassPtr, 100664803);
			HexMath.NativeMethodInfoPtr_HexVSpacing_Public_Static_Single_Single_HexOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexMath>.NativeClassPtr, 100664804);
			HexMath.NativeMethodInfoPtr_HexPositionFromCoords_Public_Static_Vector3_Single_Int32_Int32_HexOrientation_RelevantAxes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexMath>.NativeClassPtr, 100664805);
			HexMath.NativeMethodInfoPtr_HexDistance_Public_Static_Single_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexMath>.NativeClassPtr, 100664806);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0003E514 File Offset: 0x0003C714
		[CallerCount(0)]
		public unsafe static float HexWidth(float hexSize, HexMath.HexOrientation hexOrientation = HexMath.HexOrientation.PointUp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hexSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexOrientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexMath.NativeMethodInfoPtr_HexWidth_Public_Static_Single_Single_HexOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0003E560 File Offset: 0x0003C760
		[CallerCount(0)]
		public unsafe static float HexHeight(float hexSize, HexMath.HexOrientation hexOrientation = HexMath.HexOrientation.PointUp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hexSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexOrientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexMath.NativeMethodInfoPtr_HexHeight_Public_Static_Single_Single_HexOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0003E5AC File Offset: 0x0003C7AC
		[CallerCount(0)]
		public unsafe static float HexHSpacing(float hexSize, HexMath.HexOrientation hexOrientation = HexMath.HexOrientation.PointUp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hexSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexOrientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexMath.NativeMethodInfoPtr_HexHSpacing_Public_Static_Single_Single_HexOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0003E5F8 File Offset: 0x0003C7F8
		[CallerCount(0)]
		public unsafe static float HexVSpacing(float hexSize, HexMath.HexOrientation hexOrientation = HexMath.HexOrientation.PointUp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hexSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexOrientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexMath.NativeMethodInfoPtr_HexVSpacing_Public_Static_Single_Single_HexOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0003E644 File Offset: 0x0003C844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506772, XrefRangeEnd = 506781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 HexPositionFromCoords(float hexSize, int r, int s, HexMath.HexOrientation hexOrientation = HexMath.HexOrientation.PointUp, HexMath.RelevantAxes relevantAxes = HexMath.RelevantAxes.XZ)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hexSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexOrientation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relevantAxes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexMath.NativeMethodInfoPtr_HexPositionFromCoords_Public_Static_Vector3_Single_Int32_Int32_HexOrientation_RelevantAxes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0003E6BC File Offset: 0x0003C8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506781, XrefRangeEnd = 506790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float HexDistance(int r1, int s1, int r2, int s2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexMath.NativeMethodInfoPtr_HexDistance_Public_Static_Single_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0000708F File Offset: 0x0000528F
		public HexMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_HexWidth_Public_Static_Single_Single_HexOrientation_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_HexHeight_Public_Static_Single_Single_HexOrientation_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_HexHSpacing_Public_Static_Single_Single_HexOrientation_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_HexVSpacing_Public_Static_Single_Single_HexOrientation_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_HexPositionFromCoords_Public_Static_Vector3_Single_Int32_Int32_HexOrientation_RelevantAxes_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_HexDistance_Public_Static_Single_Int32_Int32_Int32_Int32_0;

		// Token: 0x02000337 RID: 823
		[Serializable]
		public enum HexOrientation
		{
			// Token: 0x04001866 RID: 6246
			PointUp,
			// Token: 0x04001867 RID: 6247
			FlatUp
		}

		// Token: 0x02000338 RID: 824
		public enum RelevantAxes
		{
			// Token: 0x04001869 RID: 6249
			XY,
			// Token: 0x0400186A RID: 6250
			XZ,
			// Token: 0x0400186B RID: 6251
			YZ
		}
	}
}
