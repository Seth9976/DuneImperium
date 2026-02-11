using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200009B RID: 155
	[Serializable]
	[StructLayout(2)]
	public struct SphericalHarmonicsL1
	{
		// Token: 0x06000B7C RID: 2940 RVA: 0x00036C0C File Offset: 0x00034E0C
		// Note: this type is marked as 'beforefieldinit'.
		static SphericalHarmonicsL1()
		{
			Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SphericalHarmonicsL1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr);
			SphericalHarmonicsL1.NativeFieldInfoPtr_shAr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "shAr");
			SphericalHarmonicsL1.NativeFieldInfoPtr_shAg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "shAg");
			SphericalHarmonicsL1.NativeFieldInfoPtr_shAb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "shAb");
			SphericalHarmonicsL1.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "zero");
			SphericalHarmonicsL1.NativeMethodInfoPtr_op_Addition_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665026);
			SphericalHarmonicsL1.NativeMethodInfoPtr_op_Subtraction_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665027);
			SphericalHarmonicsL1.NativeMethodInfoPtr_op_Multiply_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665028);
			SphericalHarmonicsL1.NativeMethodInfoPtr_op_Division_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665029);
			SphericalHarmonicsL1.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665030);
			SphericalHarmonicsL1.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665031);
			SphericalHarmonicsL1.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665032);
			SphericalHarmonicsL1.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665033);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00036D2C File Offset: 0x00034F2C
		[CallerCount(0)]
		public unsafe static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_op_Addition_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00036D78 File Offset: 0x00034F78
		[CallerCount(0)]
		public unsafe static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_op_Subtraction_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00036DC4 File Offset: 0x00034FC4
		[CallerCount(0)]
		public unsafe static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_op_Multiply_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00036E10 File Offset: 0x00035010
		[CallerCount(0)]
		public unsafe static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_op_Division_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00036E5C File Offset: 0x0003505C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 970568, RefRangeEnd = 970570, XrefRangeStart = 970568, XrefRangeEnd = 970568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00036EA8 File Offset: 0x000350A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970570, XrefRangeEnd = 970574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00036EF4 File Offset: 0x000350F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970574, XrefRangeEnd = 970580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00036F38 File Offset: 0x00035138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970580, XrefRangeEnd = 970592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL1.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00006F57 File Offset: 0x00005157
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, ref this));
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00036F68 File Offset: 0x00035168
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00006F69 File Offset: 0x00005169
		public unsafe static SphericalHarmonicsL1 zero
		{
			get
			{
				SphericalHarmonicsL1 sphericalHarmonicsL;
				IL2CPP.il2cpp_field_static_get_value(SphericalHarmonicsL1.NativeFieldInfoPtr_zero, (void*)(&sphericalHarmonicsL));
				return sphericalHarmonicsL;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SphericalHarmonicsL1.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr_shAr;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeFieldInfoPtr_shAg;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_shAb;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400089A RID: 2202
		[FieldOffset(0)]
		public Vector4 shAr;

		// Token: 0x0400089B RID: 2203
		[FieldOffset(16)]
		public Vector4 shAg;

		// Token: 0x0400089C RID: 2204
		[FieldOffset(32)]
		public Vector4 shAb;
	}
}
