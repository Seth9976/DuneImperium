using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	[StructLayout(2)]
	public struct Random
	{
		// Token: 0x06001F23 RID: 7971 RVA: 0x000A20E8 File Offset: 0x000A02E8
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "state");
			Random.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671031);
			Random.NativeMethodInfoPtr_CreateFromIndex_Public_Static_Random_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671032);
			Random.NativeMethodInfoPtr_WangHash_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671033);
			Random.NativeMethodInfoPtr_InitState_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671034);
			Random.NativeMethodInfoPtr_NextBool_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671035);
			Random.NativeMethodInfoPtr_NextBool2_Public_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671036);
			Random.NativeMethodInfoPtr_NextBool3_Public_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671037);
			Random.NativeMethodInfoPtr_NextBool4_Public_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671038);
			Random.NativeMethodInfoPtr_NextInt_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671039);
			Random.NativeMethodInfoPtr_NextInt2_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671040);
			Random.NativeMethodInfoPtr_NextInt3_Public_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671041);
			Random.NativeMethodInfoPtr_NextInt4_Public_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671042);
			Random.NativeMethodInfoPtr_NextInt_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671043);
			Random.NativeMethodInfoPtr_NextInt2_Public_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671044);
			Random.NativeMethodInfoPtr_NextInt3_Public_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671045);
			Random.NativeMethodInfoPtr_NextInt4_Public_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671046);
			Random.NativeMethodInfoPtr_NextInt_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671047);
			Random.NativeMethodInfoPtr_NextInt2_Public_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671048);
			Random.NativeMethodInfoPtr_NextInt3_Public_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671049);
			Random.NativeMethodInfoPtr_NextInt4_Public_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671050);
			Random.NativeMethodInfoPtr_NextUInt_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671051);
			Random.NativeMethodInfoPtr_NextUInt2_Public_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671052);
			Random.NativeMethodInfoPtr_NextUInt3_Public_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671053);
			Random.NativeMethodInfoPtr_NextUInt4_Public_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671054);
			Random.NativeMethodInfoPtr_NextUInt_Public_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671055);
			Random.NativeMethodInfoPtr_NextUInt2_Public_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671056);
			Random.NativeMethodInfoPtr_NextUInt3_Public_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671057);
			Random.NativeMethodInfoPtr_NextUInt4_Public_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671058);
			Random.NativeMethodInfoPtr_NextUInt_Public_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671059);
			Random.NativeMethodInfoPtr_NextUInt2_Public_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671060);
			Random.NativeMethodInfoPtr_NextUInt3_Public_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671061);
			Random.NativeMethodInfoPtr_NextUInt4_Public_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671062);
			Random.NativeMethodInfoPtr_NextFloat_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671063);
			Random.NativeMethodInfoPtr_NextFloat2_Public_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671064);
			Random.NativeMethodInfoPtr_NextFloat3_Public_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671065);
			Random.NativeMethodInfoPtr_NextFloat4_Public_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671066);
			Random.NativeMethodInfoPtr_NextFloat_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671067);
			Random.NativeMethodInfoPtr_NextFloat2_Public_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671068);
			Random.NativeMethodInfoPtr_NextFloat3_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671069);
			Random.NativeMethodInfoPtr_NextFloat4_Public_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671070);
			Random.NativeMethodInfoPtr_NextFloat_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671071);
			Random.NativeMethodInfoPtr_NextFloat2_Public_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671072);
			Random.NativeMethodInfoPtr_NextFloat3_Public_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671073);
			Random.NativeMethodInfoPtr_NextFloat4_Public_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671074);
			Random.NativeMethodInfoPtr_NextDouble_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671075);
			Random.NativeMethodInfoPtr_NextDouble2_Public_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671076);
			Random.NativeMethodInfoPtr_NextDouble3_Public_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671077);
			Random.NativeMethodInfoPtr_NextDouble4_Public_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671078);
			Random.NativeMethodInfoPtr_NextDouble_Public_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671079);
			Random.NativeMethodInfoPtr_NextDouble2_Public_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671080);
			Random.NativeMethodInfoPtr_NextDouble3_Public_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671081);
			Random.NativeMethodInfoPtr_NextDouble4_Public_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671082);
			Random.NativeMethodInfoPtr_NextDouble_Public_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671083);
			Random.NativeMethodInfoPtr_NextDouble2_Public_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671084);
			Random.NativeMethodInfoPtr_NextDouble3_Public_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671085);
			Random.NativeMethodInfoPtr_NextDouble4_Public_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671086);
			Random.NativeMethodInfoPtr_NextFloat2Direction_Public_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671087);
			Random.NativeMethodInfoPtr_NextDouble2Direction_Public_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671088);
			Random.NativeMethodInfoPtr_NextFloat3Direction_Public_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671089);
			Random.NativeMethodInfoPtr_NextDouble3Direction_Public_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671090);
			Random.NativeMethodInfoPtr_NextQuaternionRotation_Public_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671091);
			Random.NativeMethodInfoPtr_NextState_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671092);
			Random.NativeMethodInfoPtr_CheckInitState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671093);
			Random.NativeMethodInfoPtr_CheckIndexForHash_Private_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671094);
			Random.NativeMethodInfoPtr_CheckState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671095);
			Random.NativeMethodInfoPtr_CheckNextIntMax_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671096);
			Random.NativeMethodInfoPtr_CheckNextIntMinMax_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671097);
			Random.NativeMethodInfoPtr_CheckNextUIntMinMax_Private_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100671098);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000A267C File Offset: 0x000A087C
		[CallerCount(0)]
		public unsafe Random(uint seed)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000A26B0 File Offset: 0x000A08B0
		[CallerCount(0)]
		public unsafe static Random CreateFromIndex(uint index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_CreateFromIndex_Public_Static_Random_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000A26F0 File Offset: 0x000A08F0
		[CallerCount(0)]
		public unsafe static uint WangHash(uint n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_WangHash_Internal_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000A2730 File Offset: 0x000A0930
		[CallerCount(0)]
		public unsafe void InitState(uint seed = 1851936439U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_InitState_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000A2764 File Offset: 0x000A0964
		[CallerCount(0)]
		public unsafe bool NextBool()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextBool_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000A2794 File Offset: 0x000A0994
		[CallerCount(0)]
		public unsafe bool2 NextBool2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextBool2_Public_bool2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000A27C4 File Offset: 0x000A09C4
		[CallerCount(0)]
		public unsafe bool3 NextBool3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextBool3_Public_bool3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000A27F4 File Offset: 0x000A09F4
		[CallerCount(0)]
		public unsafe bool4 NextBool4()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextBool4_Public_bool4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000A2824 File Offset: 0x000A0A24
		[CallerCount(0)]
		public unsafe int NextInt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000A2854 File Offset: 0x000A0A54
		[CallerCount(0)]
		public unsafe int2 NextInt2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt2_Public_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000A2884 File Offset: 0x000A0A84
		[CallerCount(0)]
		public unsafe int3 NextInt3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt3_Public_int3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x000A28B4 File Offset: 0x000A0AB4
		[CallerCount(0)]
		public unsafe int4 NextInt4()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt4_Public_int4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000A28E4 File Offset: 0x000A0AE4
		[CallerCount(0)]
		public unsafe int NextInt(int max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt_Public_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000A2924 File Offset: 0x000A0B24
		[CallerCount(0)]
		public unsafe int2 NextInt2(int2 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt2_Public_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x000A2964 File Offset: 0x000A0B64
		[CallerCount(0)]
		public unsafe int3 NextInt3(int3 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt3_Public_int3_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000A29A4 File Offset: 0x000A0BA4
		[CallerCount(0)]
		public unsafe int4 NextInt4(int4 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt4_Public_int4_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x000A29E4 File Offset: 0x000A0BE4
		[CallerCount(0)]
		public unsafe int NextInt(int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt_Public_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x000A2A30 File Offset: 0x000A0C30
		[CallerCount(0)]
		public unsafe int2 NextInt2(int2 min, int2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt2_Public_int2_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x000A2A7C File Offset: 0x000A0C7C
		[CallerCount(0)]
		public unsafe int3 NextInt3(int3 min, int3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt3_Public_int3_int3_int3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x000A2AC8 File Offset: 0x000A0CC8
		[CallerCount(0)]
		public unsafe int4 NextInt4(int4 min, int4 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextInt4_Public_int4_int4_int4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x000A2B14 File Offset: 0x000A0D14
		[CallerCount(0)]
		public unsafe uint NextUInt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x000A2B44 File Offset: 0x000A0D44
		[CallerCount(0)]
		public unsafe uint2 NextUInt2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt2_Public_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x000A2B74 File Offset: 0x000A0D74
		[CallerCount(0)]
		public unsafe uint3 NextUInt3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt3_Public_uint3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000A2BA4 File Offset: 0x000A0DA4
		[CallerCount(0)]
		public unsafe uint4 NextUInt4()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt4_Public_uint4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000A2BD4 File Offset: 0x000A0DD4
		[CallerCount(0)]
		public unsafe uint NextUInt(uint max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt_Public_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x000A2C14 File Offset: 0x000A0E14
		[CallerCount(0)]
		public unsafe uint2 NextUInt2(uint2 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt2_Public_uint2_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x000A2C54 File Offset: 0x000A0E54
		[CallerCount(0)]
		public unsafe uint3 NextUInt3(uint3 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt3_Public_uint3_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x000A2C94 File Offset: 0x000A0E94
		[CallerCount(0)]
		public unsafe uint4 NextUInt4(uint4 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt4_Public_uint4_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x000A2CD4 File Offset: 0x000A0ED4
		[CallerCount(0)]
		public unsafe uint NextUInt(uint min, uint max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt_Public_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x000A2D20 File Offset: 0x000A0F20
		[CallerCount(0)]
		public unsafe uint2 NextUInt2(uint2 min, uint2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt2_Public_uint2_uint2_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x000A2D6C File Offset: 0x000A0F6C
		[CallerCount(0)]
		public unsafe uint3 NextUInt3(uint3 min, uint3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt3_Public_uint3_uint3_uint3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x000A2DB8 File Offset: 0x000A0FB8
		[CallerCount(0)]
		public unsafe uint4 NextUInt4(uint4 min, uint4 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextUInt4_Public_uint4_uint4_uint4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x000A2E04 File Offset: 0x000A1004
		[CallerCount(0)]
		public unsafe float NextFloat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x000A2E34 File Offset: 0x000A1034
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 641188, RefRangeEnd = 641191, XrefRangeStart = 641188, XrefRangeEnd = 641188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2 NextFloat2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat2_Public_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x000A2E64 File Offset: 0x000A1064
		[CallerCount(0)]
		public unsafe float3 NextFloat3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat3_Public_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x000A2E94 File Offset: 0x000A1094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 641191, RefRangeEnd = 641193, XrefRangeStart = 641191, XrefRangeEnd = 641191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4 NextFloat4()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat4_Public_float4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x000A2EC4 File Offset: 0x000A10C4
		[CallerCount(0)]
		public unsafe float NextFloat(float max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat_Public_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x000A2F04 File Offset: 0x000A1104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641193, XrefRangeEnd = 641194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2 NextFloat2(float2 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat2_Public_float2_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000A2F44 File Offset: 0x000A1144
		[CallerCount(0)]
		public unsafe float3 NextFloat3(float3 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat3_Public_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x000A2F84 File Offset: 0x000A1184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641194, XrefRangeEnd = 641195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4 NextFloat4(float4 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat4_Public_float4_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x000A2FC4 File Offset: 0x000A11C4
		[CallerCount(0)]
		public unsafe float NextFloat(float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat_Public_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x000A3010 File Offset: 0x000A1210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641195, XrefRangeEnd = 641196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2 NextFloat2(float2 min, float2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat2_Public_float2_float2_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x000A305C File Offset: 0x000A125C
		[CallerCount(0)]
		public unsafe float3 NextFloat3(float3 min, float3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat3_Public_float3_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x000A30A8 File Offset: 0x000A12A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641196, XrefRangeEnd = 641197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4 NextFloat4(float4 min, float4 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat4_Public_float4_float4_float4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000A30F4 File Offset: 0x000A12F4
		[CallerCount(0)]
		public unsafe double NextDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000A3124 File Offset: 0x000A1324
		[CallerCount(0)]
		public unsafe double2 NextDouble2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble2_Public_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000A3154 File Offset: 0x000A1354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 641197, RefRangeEnd = 641199, XrefRangeStart = 641197, XrefRangeEnd = 641197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3 NextDouble3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble3_Public_double3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x000A3184 File Offset: 0x000A1384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 641199, RefRangeEnd = 641201, XrefRangeStart = 641199, XrefRangeEnd = 641199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4 NextDouble4()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble4_Public_double4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x000A31B4 File Offset: 0x000A13B4
		[CallerCount(0)]
		public unsafe double NextDouble(double max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble_Public_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x000A31F4 File Offset: 0x000A13F4
		[CallerCount(0)]
		public unsafe double2 NextDouble2(double2 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble2_Public_double2_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x000A3234 File Offset: 0x000A1434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641201, XrefRangeEnd = 641202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3 NextDouble3(double3 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble3_Public_double3_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000A3274 File Offset: 0x000A1474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641202, XrefRangeEnd = 641203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4 NextDouble4(double4 max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble4_Public_double4_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000A32B4 File Offset: 0x000A14B4
		[CallerCount(0)]
		public unsafe double NextDouble(double min, double max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble_Public_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000A3300 File Offset: 0x000A1500
		[CallerCount(0)]
		public unsafe double2 NextDouble2(double2 min, double2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble2_Public_double2_double2_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000A334C File Offset: 0x000A154C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641203, XrefRangeEnd = 641204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3 NextDouble3(double3 min, double3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble3_Public_double3_double3_double3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x000A3398 File Offset: 0x000A1598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641204, XrefRangeEnd = 641205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4 NextDouble4(double4 min, double4 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble4_Public_double4_double4_double4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x000A33E4 File Offset: 0x000A15E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641205, XrefRangeEnd = 641213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2 NextFloat2Direction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat2Direction_Public_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000A3414 File Offset: 0x000A1614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641213, XrefRangeEnd = 641221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2 NextDouble2Direction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble2Direction_Public_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000A3444 File Offset: 0x000A1644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641221, XrefRangeEnd = 641231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3 NextFloat3Direction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextFloat3Direction_Public_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x000A3474 File Offset: 0x000A1674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641231, XrefRangeEnd = 641244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3 NextDouble3Direction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextDouble3Direction_Public_double3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000A34A4 File Offset: 0x000A16A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641244, XrefRangeEnd = 641248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe quaternion NextQuaternionRotation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextQuaternionRotation_Public_quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000A34D4 File Offset: 0x000A16D4
		[CallerCount(0)]
		public unsafe uint NextState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_NextState_Private_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000A3504 File Offset: 0x000A1704
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInitState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_CheckInitState_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000A352C File Offset: 0x000A172C
		[CallerCount(0)]
		public unsafe static void CheckIndexForHash(uint index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_CheckIndexForHash_Private_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x000A3560 File Offset: 0x000A1760
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_CheckState_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x000A3588 File Offset: 0x000A1788
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNextIntMax(int max)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_CheckNextIntMax_Private_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000A35BC File Offset: 0x000A17BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNextIntMinMax(int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_CheckNextIntMinMax_Private_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000A35FC File Offset: 0x000A17FC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNextUIntMinMax(uint min, uint max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_CheckNextUIntMinMax_Private_Void_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000028DB File Offset: 0x00000ADB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Random>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromIndex_Public_Static_Random_UInt32_0;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeMethodInfoPtr_WangHash_Internal_Static_UInt32_UInt32_0;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeMethodInfoPtr_InitState_Public_Void_UInt32_0;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeMethodInfoPtr_NextBool_Public_Boolean_0;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeMethodInfoPtr_NextBool2_Public_bool2_0;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeMethodInfoPtr_NextBool3_Public_bool3_0;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeMethodInfoPtr_NextBool4_Public_bool4_0;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeMethodInfoPtr_NextInt_Public_Int32_0;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeMethodInfoPtr_NextInt2_Public_int2_0;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeMethodInfoPtr_NextInt3_Public_int3_0;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeMethodInfoPtr_NextInt4_Public_int4_0;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeMethodInfoPtr_NextInt_Public_Int32_Int32_0;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeMethodInfoPtr_NextInt2_Public_int2_int2_0;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeMethodInfoPtr_NextInt3_Public_int3_int3_0;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeMethodInfoPtr_NextInt4_Public_int4_int4_0;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeMethodInfoPtr_NextInt_Public_Int32_Int32_Int32_0;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeMethodInfoPtr_NextInt2_Public_int2_int2_int2_0;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeMethodInfoPtr_NextInt3_Public_int3_int3_int3_0;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeMethodInfoPtr_NextInt4_Public_int4_int4_int4_0;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt_Public_UInt32_0;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt2_Public_uint2_0;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt3_Public_uint3_0;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt4_Public_uint4_0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt_Public_UInt32_UInt32_0;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt2_Public_uint2_uint2_0;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt3_Public_uint3_uint3_0;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt4_Public_uint4_uint4_0;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt_Public_UInt32_UInt32_UInt32_0;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt2_Public_uint2_uint2_uint2_0;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt3_Public_uint3_uint3_uint3_0;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeMethodInfoPtr_NextUInt4_Public_uint4_uint4_uint4_0;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat_Public_Single_0;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat2_Public_float2_0;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat3_Public_float3_0;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat4_Public_float4_0;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat_Public_Single_Single_0;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat2_Public_float2_float2_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat3_Public_float3_float3_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat4_Public_float4_float4_0;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat_Public_Single_Single_Single_0;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat2_Public_float2_float2_float2_0;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat3_Public_float3_float3_float3_0;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat4_Public_float4_float4_float4_0;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble_Public_Double_0;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble2_Public_double2_0;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble3_Public_double3_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble4_Public_double4_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble_Public_Double_Double_0;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble2_Public_double2_double2_0;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble3_Public_double3_double3_0;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble4_Public_double4_double4_0;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble_Public_Double_Double_Double_0;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble2_Public_double2_double2_double2_0;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble3_Public_double3_double3_double3_0;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble4_Public_double4_double4_double4_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat2Direction_Public_float2_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble2Direction_Public_double2_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_NextFloat3Direction_Public_float3_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble3Direction_Public_double3_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_NextQuaternionRotation_Public_quaternion_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeMethodInfoPtr_NextState_Private_UInt32_0;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr_CheckInitState_Private_Void_0;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeMethodInfoPtr_CheckIndexForHash_Private_Static_Void_UInt32_0;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeMethodInfoPtr_CheckState_Private_Void_0;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeMethodInfoPtr_CheckNextIntMax_Private_Void_Int32_0;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeMethodInfoPtr_CheckNextIntMinMax_Private_Void_Int32_Int32_0;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeMethodInfoPtr_CheckNextUIntMinMax_Private_Void_UInt32_UInt32_0;

		// Token: 0x04001FE0 RID: 8160
		[FieldOffset(0)]
		public uint state;
	}
}
