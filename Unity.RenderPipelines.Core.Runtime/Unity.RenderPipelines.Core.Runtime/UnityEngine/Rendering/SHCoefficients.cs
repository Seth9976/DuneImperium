using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C5 RID: 197
	[Serializable]
	[StructLayout(2)]
	public struct SHCoefficients
	{
		// Token: 0x06000E4E RID: 3662 RVA: 0x00041B80 File Offset: 0x0003FD80
		// Note: this type is marked as 'beforefieldinit'.
		static SHCoefficients()
		{
			Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SHCoefficients");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr);
			SHCoefficients.NativeFieldInfoPtr_SHAr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHAr");
			SHCoefficients.NativeFieldInfoPtr_SHAg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHAg");
			SHCoefficients.NativeFieldInfoPtr_SHAb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHAb");
			SHCoefficients.NativeFieldInfoPtr_SHBr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHBr");
			SHCoefficients.NativeFieldInfoPtr_SHBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHBg");
			SHCoefficients.NativeFieldInfoPtr_SHBb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHBb");
			SHCoefficients.NativeFieldInfoPtr_SHC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHC");
			SHCoefficients.NativeFieldInfoPtr_ProbesOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "ProbesOcclusion");
			SHCoefficients.NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665345);
			SHCoefficients.NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665346);
			SHCoefficients.NativeMethodInfoPtr_GetSHA_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665347);
			SHCoefficients.NativeMethodInfoPtr_GetSHB_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665348);
			SHCoefficients.NativeMethodInfoPtr_GetSHC_Private_Static_Vector4_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665349);
			SHCoefficients.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SHCoefficients_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665350);
			SHCoefficients.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665351);
			SHCoefficients.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665352);
			SHCoefficients.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665353);
			SHCoefficients.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100665354);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00041D18 File Offset: 0x0003FF18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973975, RefRangeEnd = 973977, XrefRangeStart = 973943, XrefRangeEnd = 973975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHCoefficients(SphericalHarmonicsL2 sh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00041D4C File Offset: 0x0003FF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973977, XrefRangeEnd = 973978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHCoefficients(SphericalHarmonicsL2 sh, Vector4 probesOcclusion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probesOcclusion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00041D8C File Offset: 0x0003FF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973978, XrefRangeEnd = 973983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_GetSHA_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00041DD8 File Offset: 0x0003FFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973983, XrefRangeEnd = 973987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_GetSHB_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00041E24 File Offset: 0x00040024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973987, XrefRangeEnd = 973990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetSHC(SphericalHarmonicsL2 sh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_GetSHC_Private_Static_Vector4_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00041E64 File Offset: 0x00040064
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 973990, RefRangeEnd = 973994, XrefRangeStart = 973990, XrefRangeEnd = 973990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SHCoefficients other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SHCoefficients_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00041EA4 File Offset: 0x000400A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973994, XrefRangeEnd = 973998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00041EE8 File Offset: 0x000400E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973998, XrefRangeEnd = 974004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00041F18 File Offset: 0x00040118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974004, XrefRangeEnd = 974005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SHCoefficients left, SHCoefficients right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00041F64 File Offset: 0x00040164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974005, XrefRangeEnd = 974006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SHCoefficients left, SHCoefficients right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHCoefficients.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000083A5 File Offset: 0x000065A5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, ref this));
		}

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_SHAr;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeFieldInfoPtr_SHAg;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr_SHAb;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr_SHBr;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr_SHBg;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr_SHBb;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeFieldInfoPtr_SHC;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeFieldInfoPtr_ProbesOcclusion;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_Vector4_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_GetSHA_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_GetSHB_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_GetSHC_Private_Static_Vector4_SphericalHarmonicsL2_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SHCoefficients_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0;

		// Token: 0x04000ABF RID: 2751
		[FieldOffset(0)]
		public Vector4 SHAr;

		// Token: 0x04000AC0 RID: 2752
		[FieldOffset(16)]
		public Vector4 SHAg;

		// Token: 0x04000AC1 RID: 2753
		[FieldOffset(32)]
		public Vector4 SHAb;

		// Token: 0x04000AC2 RID: 2754
		[FieldOffset(48)]
		public Vector4 SHBr;

		// Token: 0x04000AC3 RID: 2755
		[FieldOffset(64)]
		public Vector4 SHBg;

		// Token: 0x04000AC4 RID: 2756
		[FieldOffset(80)]
		public Vector4 SHBb;

		// Token: 0x04000AC5 RID: 2757
		[FieldOffset(96)]
		public Vector4 SHC;

		// Token: 0x04000AC6 RID: 2758
		[FieldOffset(112)]
		public Vector4 ProbesOcclusion;
	}
}
