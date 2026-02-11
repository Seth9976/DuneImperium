using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	[StructLayout(2)]
	public struct RigidTransform
	{
		// Token: 0x06001F69 RID: 8041 RVA: 0x000A363C File Offset: 0x000A183C
		// Note: this type is marked as 'beforefieldinit'.
		static RigidTransform()
		{
			Il2CppClassPointerStore<RigidTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "RigidTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr);
			RigidTransform.NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, "rot");
			RigidTransform.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, "pos");
			RigidTransform.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, "identity");
			RigidTransform.NativeMethodInfoPtr__ctor_Public_Void_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671099);
			RigidTransform.NativeMethodInfoPtr__ctor_Public_Void_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671100);
			RigidTransform.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671101);
			RigidTransform.NativeMethodInfoPtr_AxisAngle_Public_Static_RigidTransform_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671102);
			RigidTransform.NativeMethodInfoPtr_EulerXYZ_Public_Static_RigidTransform_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671103);
			RigidTransform.NativeMethodInfoPtr_EulerXZY_Public_Static_RigidTransform_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671104);
			RigidTransform.NativeMethodInfoPtr_EulerYXZ_Public_Static_RigidTransform_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671105);
			RigidTransform.NativeMethodInfoPtr_EulerYZX_Public_Static_RigidTransform_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671106);
			RigidTransform.NativeMethodInfoPtr_EulerZXY_Public_Static_RigidTransform_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671107);
			RigidTransform.NativeMethodInfoPtr_EulerZYX_Public_Static_RigidTransform_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671108);
			RigidTransform.NativeMethodInfoPtr_EulerXYZ_Public_Static_RigidTransform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671109);
			RigidTransform.NativeMethodInfoPtr_EulerXZY_Public_Static_RigidTransform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671110);
			RigidTransform.NativeMethodInfoPtr_EulerYXZ_Public_Static_RigidTransform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671111);
			RigidTransform.NativeMethodInfoPtr_EulerYZX_Public_Static_RigidTransform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671112);
			RigidTransform.NativeMethodInfoPtr_EulerZXY_Public_Static_RigidTransform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671113);
			RigidTransform.NativeMethodInfoPtr_EulerZYX_Public_Static_RigidTransform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671114);
			RigidTransform.NativeMethodInfoPtr_Euler_Public_Static_RigidTransform_float3_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671115);
			RigidTransform.NativeMethodInfoPtr_Euler_Public_Static_RigidTransform_Single_Single_Single_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671116);
			RigidTransform.NativeMethodInfoPtr_RotateX_Public_Static_RigidTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671117);
			RigidTransform.NativeMethodInfoPtr_RotateY_Public_Static_RigidTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671118);
			RigidTransform.NativeMethodInfoPtr_RotateZ_Public_Static_RigidTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671119);
			RigidTransform.NativeMethodInfoPtr_Translate_Public_Static_RigidTransform_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671120);
			RigidTransform.NativeMethodInfoPtr_Equals_Public_Boolean_RigidTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671121);
			RigidTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671122);
			RigidTransform.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671123);
			RigidTransform.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671124);
			RigidTransform.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, 100671125);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000A38C4 File Offset: 0x000A1AC4
		[CallerCount(0)]
		public unsafe RigidTransform(quaternion rotation, float3 translation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr__ctor_Public_Void_quaternion_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000A3904 File Offset: 0x000A1B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641248, XrefRangeEnd = 641249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RigidTransform(float3x3 rotation, float3 translation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr__ctor_Public_Void_float3x3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000A3944 File Offset: 0x000A1B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641249, XrefRangeEnd = 641250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RigidTransform(float4x4 transform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000A3978 File Offset: 0x000A1B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641250, XrefRangeEnd = 641260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform AxisAngle(float3 axis, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_AxisAngle_Public_Static_RigidTransform_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x000A39C4 File Offset: 0x000A1BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641260, XrefRangeEnd = 641263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerXYZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerXYZ_Public_Static_RigidTransform_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000A3A04 File Offset: 0x000A1C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641263, XrefRangeEnd = 641266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerXZY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerXZY_Public_Static_RigidTransform_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000A3A44 File Offset: 0x000A1C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641266, XrefRangeEnd = 641269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerYXZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerYXZ_Public_Static_RigidTransform_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000A3A84 File Offset: 0x000A1C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641269, XrefRangeEnd = 641272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerYZX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerYZX_Public_Static_RigidTransform_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000A3AC4 File Offset: 0x000A1CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641272, XrefRangeEnd = 641275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerZXY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerZXY_Public_Static_RigidTransform_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x000A3B04 File Offset: 0x000A1D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641275, XrefRangeEnd = 641278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerZYX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerZYX_Public_Static_RigidTransform_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x000A3B44 File Offset: 0x000A1D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641278, XrefRangeEnd = 641281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerXYZ(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerXYZ_Public_Static_RigidTransform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000A3BA0 File Offset: 0x000A1DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641281, XrefRangeEnd = 641284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerXZY(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerXZY_Public_Static_RigidTransform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x000A3BFC File Offset: 0x000A1DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641284, XrefRangeEnd = 641287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerYXZ(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerYXZ_Public_Static_RigidTransform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x000A3C58 File Offset: 0x000A1E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641287, XrefRangeEnd = 641290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerYZX(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerYZX_Public_Static_RigidTransform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x000A3CB4 File Offset: 0x000A1EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641290, XrefRangeEnd = 641293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerZXY(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerZXY_Public_Static_RigidTransform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000A3D10 File Offset: 0x000A1F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641293, XrefRangeEnd = 641296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform EulerZYX(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_EulerZYX_Public_Static_RigidTransform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x000A3D6C File Offset: 0x000A1F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641296, XrefRangeEnd = 641322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_Euler_Public_Static_RigidTransform_float3_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000A3DB8 File Offset: 0x000A1FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641322, XrefRangeEnd = 641323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_Euler_Public_Static_RigidTransform_Single_Single_Single_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x000A3E20 File Offset: 0x000A2020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641323, XrefRangeEnd = 641333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform RotateX(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_RotateX_Public_Static_RigidTransform_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000A3E60 File Offset: 0x000A2060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641333, XrefRangeEnd = 641343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform RotateY(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_RotateY_Public_Static_RigidTransform_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000A3EA0 File Offset: 0x000A20A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641343, XrefRangeEnd = 641353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform RotateZ(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_RotateZ_Public_Static_RigidTransform_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x000A3EE0 File Offset: 0x000A20E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641353, XrefRangeEnd = 641355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RigidTransform Translate(float3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_Translate_Public_Static_RigidTransform_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000A3F20 File Offset: 0x000A2120
		[CallerCount(0)]
		public unsafe bool Equals(RigidTransform x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_Equals_Public_Boolean_RigidTransform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000A3F60 File Offset: 0x000A2160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641355, XrefRangeEnd = 641358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x000A3FA4 File Offset: 0x000A21A4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x000A3FD4 File Offset: 0x000A21D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641358, XrefRangeEnd = 641393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000A4000 File Offset: 0x000A2200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641393, XrefRangeEnd = 641436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidTransform.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x000028ED File Offset: 0x00000AED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RigidTransform>.NativeClassPtr, ref this));
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000A4050 File Offset: 0x000A2250
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x000028FF File Offset: 0x00000AFF
		public unsafe static RigidTransform identity
		{
			get
			{
				RigidTransform rigidTransform;
				IL2CPP.il2cpp_field_static_get_value(RigidTransform.NativeFieldInfoPtr_identity, (void*)(&rigidTransform));
				return rigidTransform;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RigidTransform.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeFieldInfoPtr_rot;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_quaternion_float3_0;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x3_float3_0;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x4_0;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr_AxisAngle_Public_Static_RigidTransform_float3_Single_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_RigidTransform_float3_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_RigidTransform_float3_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_RigidTransform_float3_0;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_RigidTransform_float3_0;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_RigidTransform_float3_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_RigidTransform_float3_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_RigidTransform_Single_Single_Single_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_RigidTransform_Single_Single_Single_0;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_RigidTransform_Single_Single_Single_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_RigidTransform_Single_Single_Single_0;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_RigidTransform_Single_Single_Single_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_RigidTransform_Single_Single_Single_0;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_RigidTransform_float3_RotationOrder_0;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_RigidTransform_Single_Single_Single_RotationOrder_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_RotateX_Public_Static_RigidTransform_Single_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_RotateY_Public_Static_RigidTransform_Single_0;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_RotateZ_Public_Static_RigidTransform_Single_0;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Static_RigidTransform_float3_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_RigidTransform_0;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0;

		// Token: 0x04001FFF RID: 8191
		[FieldOffset(0)]
		public quaternion rot;

		// Token: 0x04002000 RID: 8192
		[FieldOffset(16)]
		public float3 pos;
	}
}
