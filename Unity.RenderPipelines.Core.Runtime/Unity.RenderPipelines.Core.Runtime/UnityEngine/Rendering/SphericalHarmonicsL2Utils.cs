using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200009C RID: 156
	public class SphericalHarmonicsL2Utils : Object
	{
		// Token: 0x06000B88 RID: 2952 RVA: 0x00036F84 File Offset: 0x00035184
		// Note: this type is marked as 'beforefieldinit'.
		static SphericalHarmonicsL2Utils()
		{
			Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SphericalHarmonicsL2Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_GetL1_Public_Static_Void_SphericalHarmonicsL2_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665035);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_GetL2_Public_Static_Void_SphericalHarmonicsL2_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665036);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL0_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665037);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1R_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665038);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1G_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665039);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1B_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665040);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665041);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetCoefficient_Public_Static_Void_byref_SphericalHarmonicsL2_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665042);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr_GetCoefficient_Public_Static_Vector3_SphericalHarmonicsL2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665043);
			SphericalHarmonicsL2Utils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr, 100665044);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0003707C File Offset: 0x0003527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970592, XrefRangeEnd = 970601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L1_R;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L1_G;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L1_B;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_GetL1_Public_Static_Void_SphericalHarmonicsL2_byref_Vector3_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000370D8 File Offset: 0x000352D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970601, XrefRangeEnd = 970616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L2_0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L2_1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L2_2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L2_3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &L2_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_GetL2_Public_Static_Void_SphericalHarmonicsL2_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00037154 File Offset: 0x00035354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970616, XrefRangeEnd = 970619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref L0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL0_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00037194 File Offset: 0x00035394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970619, XrefRangeEnd = 970622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref L1_R;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1R_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000371D4 File Offset: 0x000353D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970622, XrefRangeEnd = 970625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref L1_G;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1G_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00037214 File Offset: 0x00035414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970625, XrefRangeEnd = 970628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref L1_B;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1B_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00037254 File Offset: 0x00035454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970628, XrefRangeEnd = 970637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref L1_R;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref L1_G;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref L1_B;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetL1_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000372B0 File Offset: 0x000354B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970637, XrefRangeEnd = 970640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_SetCoefficient_Public_Static_Void_byref_SphericalHarmonicsL2_Int32_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00037300 File Offset: 0x00035500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970640, XrefRangeEnd = 970643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr_GetCoefficient_Public_Static_Vector3_SphericalHarmonicsL2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0003734C File Offset: 0x0003554C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SphericalHarmonicsL2Utils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphericalHarmonicsL2Utils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2Utils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00006F77 File Offset: 0x00005177
		public SphericalHarmonicsL2Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_GetL1_Public_Static_Void_SphericalHarmonicsL2_byref_Vector3_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_GetL2_Public_Static_Void_SphericalHarmonicsL2_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_SetL0_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_SetL1R_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_SetL1G_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_SetL1B_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_SetL1_Public_Static_Void_byref_SphericalHarmonicsL2_Vector3_Vector3_Vector3_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_SetCoefficient_Public_Static_Void_byref_SphericalHarmonicsL2_Int32_Vector3_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_GetCoefficient_Public_Static_Vector3_SphericalHarmonicsL2_Int32_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
