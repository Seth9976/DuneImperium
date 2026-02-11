using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	[StructLayout(2)]
	public struct quaternion
	{
		// Token: 0x06001ED1 RID: 7889 RVA: 0x000A073C File Offset: 0x0009E93C
		// Note: this type is marked as 'beforefieldinit'.
		static quaternion()
		{
			Il2CppClassPointerStore<quaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "quaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<quaternion>.NativeClassPtr);
			quaternion.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<quaternion>.NativeClassPtr, "value");
			quaternion.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<quaternion>.NativeClassPtr, "identity");
			quaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670958);
			quaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670959);
			quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670960);
			quaternion.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670961);
			quaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_quaternion_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670962);
			quaternion.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670963);
			quaternion.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670964);
			quaternion.NativeMethodInfoPtr_AxisAngle_Public_Static_quaternion_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670965);
			quaternion.NativeMethodInfoPtr_EulerXYZ_Public_Static_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670966);
			quaternion.NativeMethodInfoPtr_EulerXZY_Public_Static_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670967);
			quaternion.NativeMethodInfoPtr_EulerYXZ_Public_Static_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670968);
			quaternion.NativeMethodInfoPtr_EulerYZX_Public_Static_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670969);
			quaternion.NativeMethodInfoPtr_EulerZXY_Public_Static_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670970);
			quaternion.NativeMethodInfoPtr_EulerZYX_Public_Static_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670971);
			quaternion.NativeMethodInfoPtr_EulerXYZ_Public_Static_quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670972);
			quaternion.NativeMethodInfoPtr_EulerXZY_Public_Static_quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670973);
			quaternion.NativeMethodInfoPtr_EulerYXZ_Public_Static_quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670974);
			quaternion.NativeMethodInfoPtr_EulerYZX_Public_Static_quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670975);
			quaternion.NativeMethodInfoPtr_EulerZXY_Public_Static_quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670976);
			quaternion.NativeMethodInfoPtr_EulerZYX_Public_Static_quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670977);
			quaternion.NativeMethodInfoPtr_Euler_Public_Static_quaternion_float3_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670978);
			quaternion.NativeMethodInfoPtr_Euler_Public_Static_quaternion_Single_Single_Single_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670979);
			quaternion.NativeMethodInfoPtr_RotateX_Public_Static_quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670980);
			quaternion.NativeMethodInfoPtr_RotateY_Public_Static_quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670981);
			quaternion.NativeMethodInfoPtr_RotateZ_Public_Static_quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670982);
			quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_quaternion_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670983);
			quaternion.NativeMethodInfoPtr_LookRotationSafe_Public_Static_quaternion_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670984);
			quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670985);
			quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670986);
			quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670987);
			quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670988);
			quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternion>.NativeClassPtr, 100670989);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000A0A14 File Offset: 0x0009EC14
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Quaternion(quaternion q)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x000A0A54 File Offset: 0x0009EC54
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator quaternion(Quaternion q)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000A0A94 File Offset: 0x0009EC94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe quaternion(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000A0AF0 File Offset: 0x0009ECF0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe quaternion(float4 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr__ctor_Public_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000A0B24 File Offset: 0x0009ED24
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator quaternion(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_quaternion_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000A0B64 File Offset: 0x0009ED64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 640189, RefRangeEnd = 640194, XrefRangeStart = 640188, XrefRangeEnd = 640189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe quaternion(float3x3 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000A0B98 File Offset: 0x0009ED98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 640195, RefRangeEnd = 640198, XrefRangeStart = 640194, XrefRangeEnd = 640195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe quaternion(float4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000A0BCC File Offset: 0x0009EDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640198, XrefRangeEnd = 640206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion AxisAngle(float3 axis, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_AxisAngle_Public_Static_quaternion_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000A0C18 File Offset: 0x0009EE18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 640207, RefRangeEnd = 640213, XrefRangeStart = 640206, XrefRangeEnd = 640207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerXYZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerXYZ_Public_Static_quaternion_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000A0C58 File Offset: 0x0009EE58
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 640214, RefRangeEnd = 640220, XrefRangeStart = 640213, XrefRangeEnd = 640214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerXZY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerXZY_Public_Static_quaternion_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000A0C98 File Offset: 0x0009EE98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 640221, RefRangeEnd = 640227, XrefRangeStart = 640220, XrefRangeEnd = 640221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerYXZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerYXZ_Public_Static_quaternion_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000A0CD8 File Offset: 0x0009EED8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 640228, RefRangeEnd = 640234, XrefRangeStart = 640227, XrefRangeEnd = 640228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerYZX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerYZX_Public_Static_quaternion_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000A0D18 File Offset: 0x0009EF18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 640235, RefRangeEnd = 640241, XrefRangeStart = 640234, XrefRangeEnd = 640235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerZXY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerZXY_Public_Static_quaternion_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000A0D58 File Offset: 0x0009EF58
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 640242, RefRangeEnd = 640248, XrefRangeStart = 640241, XrefRangeEnd = 640242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerZYX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerZYX_Public_Static_quaternion_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000A0D98 File Offset: 0x0009EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640248, XrefRangeEnd = 640249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerXYZ(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerXYZ_Public_Static_quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000A0DF4 File Offset: 0x0009EFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640249, XrefRangeEnd = 640250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerXZY(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerXZY_Public_Static_quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000A0E50 File Offset: 0x0009F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640250, XrefRangeEnd = 640251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerYXZ(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerYXZ_Public_Static_quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000A0EAC File Offset: 0x0009F0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640251, XrefRangeEnd = 640252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerYZX(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerYZX_Public_Static_quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x000A0F08 File Offset: 0x0009F108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640252, XrefRangeEnd = 640253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerZXY(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerZXY_Public_Static_quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000A0F64 File Offset: 0x0009F164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640253, XrefRangeEnd = 640254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion EulerZYX(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_EulerZYX_Public_Static_quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000A0FC0 File Offset: 0x0009F1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640254, XrefRangeEnd = 640268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_Euler_Public_Static_quaternion_float3_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000A100C File Offset: 0x0009F20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640268, XrefRangeEnd = 640282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_Euler_Public_Static_quaternion_Single_Single_Single_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000A1074 File Offset: 0x0009F274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640282, XrefRangeEnd = 640290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion RotateX(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_RotateX_Public_Static_quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000A10B4 File Offset: 0x0009F2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640290, XrefRangeEnd = 640298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion RotateY(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_RotateY_Public_Static_quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000A10F4 File Offset: 0x0009F2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640298, XrefRangeEnd = 640306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion RotateZ(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_RotateZ_Public_Static_quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000A1134 File Offset: 0x0009F334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640306, XrefRangeEnd = 640308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion LookRotation(float3 forward, float3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_quaternion_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000A1180 File Offset: 0x0009F380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640308, XrefRangeEnd = 640315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static quaternion LookRotationSafe(float3 forward, float3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_LookRotationSafe_Public_Static_quaternion_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000A11CC File Offset: 0x0009F3CC
		[CallerCount(0)]
		public unsafe bool Equals(quaternion x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000A120C File Offset: 0x0009F40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640315, XrefRangeEnd = 640318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000A1250 File Offset: 0x0009F450
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000A1280 File Offset: 0x0009F480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640318, XrefRangeEnd = 640341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000A12AC File Offset: 0x0009F4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640341, XrefRangeEnd = 640371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x0000282E File Offset: 0x00000A2E
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<quaternion>.NativeClassPtr, ref this));
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000A12FC File Offset: 0x0009F4FC
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00002840 File Offset: 0x00000A40
		public unsafe static quaternion identity
		{
			get
			{
				quaternion quaternion;
				IL2CPP.il2cpp_field_static_get_value(quaternion.NativeFieldInfoPtr_identity, (void*)(&quaternion));
				return quaternion;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(quaternion.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_quaternion_0;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_quaternion_Quaternion_0;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_quaternion_float4_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x3_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x4_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_AxisAngle_Public_Static_quaternion_float3_Single_0;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_quaternion_float3_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_quaternion_float3_0;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_quaternion_float3_0;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_quaternion_float3_0;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_quaternion_float3_0;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_quaternion_float3_0;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_quaternion_Single_Single_Single_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_quaternion_Single_Single_Single_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_quaternion_Single_Single_Single_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_quaternion_Single_Single_Single_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_quaternion_Single_Single_Single_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_quaternion_Single_Single_Single_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_quaternion_float3_RotationOrder_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_quaternion_Single_Single_Single_RotationOrder_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_RotateX_Public_Static_quaternion_Single_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_RotateY_Public_Static_quaternion_Single_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_RotateZ_Public_Static_quaternion_Single_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_quaternion_float3_float3_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_LookRotationSafe_Public_Static_quaternion_float3_float3_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_quaternion_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001F72 RID: 8050
		[FieldOffset(0)]
		public float4 value;
	}
}
