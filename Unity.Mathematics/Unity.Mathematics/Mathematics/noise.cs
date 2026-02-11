using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200003A RID: 58
	public static class noise : Object
	{
		// Token: 0x06001EF5 RID: 7925 RVA: 0x000A1318 File Offset: 0x0009F518
		// Note: this type is marked as 'beforefieldinit'.
		static noise()
		{
			Il2CppClassPointerStore<noise>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "noise");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<noise>.NativeClassPtr);
			noise.NativeMethodInfoPtr_cellular_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670991);
			noise.NativeMethodInfoPtr_cellular2x2_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670992);
			noise.NativeMethodInfoPtr_cellular2x2x2_Public_Static_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670993);
			noise.NativeMethodInfoPtr_cellular_Public_Static_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670994);
			noise.NativeMethodInfoPtr_cnoise_Public_Static_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670995);
			noise.NativeMethodInfoPtr_pnoise_Public_Static_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670996);
			noise.NativeMethodInfoPtr_cnoise_Public_Static_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670997);
			noise.NativeMethodInfoPtr_pnoise_Public_Static_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670998);
			noise.NativeMethodInfoPtr_cnoise_Public_Static_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100670999);
			noise.NativeMethodInfoPtr_pnoise_Public_Static_Single_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671000);
			noise.NativeMethodInfoPtr_mod289_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671001);
			noise.NativeMethodInfoPtr_mod289_Private_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671002);
			noise.NativeMethodInfoPtr_mod289_Private_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671003);
			noise.NativeMethodInfoPtr_mod289_Private_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671004);
			noise.NativeMethodInfoPtr_mod7_Private_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671005);
			noise.NativeMethodInfoPtr_mod7_Private_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671006);
			noise.NativeMethodInfoPtr_permute_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671007);
			noise.NativeMethodInfoPtr_permute_Private_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671008);
			noise.NativeMethodInfoPtr_permute_Private_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671009);
			noise.NativeMethodInfoPtr_taylorInvSqrt_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671010);
			noise.NativeMethodInfoPtr_taylorInvSqrt_Private_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671011);
			noise.NativeMethodInfoPtr_fade_Private_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671012);
			noise.NativeMethodInfoPtr_fade_Private_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671013);
			noise.NativeMethodInfoPtr_fade_Private_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671014);
			noise.NativeMethodInfoPtr_grad4_Private_Static_float4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671015);
			noise.NativeMethodInfoPtr_rgrad2_Private_Static_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671016);
			noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671017);
			noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671018);
			noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671019);
			noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671020);
			noise.NativeMethodInfoPtr_psrdnoise_Public_Static_float3_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671021);
			noise.NativeMethodInfoPtr_psrdnoise_Public_Static_float3_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671022);
			noise.NativeMethodInfoPtr_psrnoise_Public_Static_Single_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671023);
			noise.NativeMethodInfoPtr_psrnoise_Public_Static_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671024);
			noise.NativeMethodInfoPtr_srdnoise_Public_Static_float3_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671025);
			noise.NativeMethodInfoPtr_srdnoise_Public_Static_float3_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671026);
			noise.NativeMethodInfoPtr_srnoise_Public_Static_Single_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671027);
			noise.NativeMethodInfoPtr_srnoise_Public_Static_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<noise>.NativeClassPtr, 100671028);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000A1640 File Offset: 0x0009F840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640371, XrefRangeEnd = 640397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 cellular(float2 P)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_cellular_Public_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000A1680 File Offset: 0x0009F880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640397, XrefRangeEnd = 640411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 cellular2x2(float2 P)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_cellular2x2_Public_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000A16C0 File Offset: 0x0009F8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640411, XrefRangeEnd = 640435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 cellular2x2x2(float3 P)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_cellular2x2x2_Public_Static_float2_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000A1700 File Offset: 0x0009F900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640435, XrefRangeEnd = 640511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 cellular(float3 P)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_cellular_Public_Static_float2_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000A1740 File Offset: 0x0009F940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640511, XrefRangeEnd = 640518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float cnoise(float2 P)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_cnoise_Public_Static_Single_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000A1780 File Offset: 0x0009F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640518, XrefRangeEnd = 640529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float pnoise(float2 P, float2 rep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_pnoise_Public_Static_Single_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000A17CC File Offset: 0x0009F9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640529, XrefRangeEnd = 640558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float cnoise(float3 P)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_cnoise_Public_Static_Single_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000A180C File Offset: 0x0009FA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640558, XrefRangeEnd = 640593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float pnoise(float3 P, float3 rep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_pnoise_Public_Static_Single_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000A1858 File Offset: 0x0009FA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640593, XrefRangeEnd = 640748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float cnoise(float4 P)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_cnoise_Public_Static_Single_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000A1898 File Offset: 0x0009FA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640748, XrefRangeEnd = 640913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float pnoise(float4 P, float4 rep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref P;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_pnoise_Public_Static_Single_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000A18E4 File Offset: 0x0009FAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640913, XrefRangeEnd = 640917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float mod289(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_mod289_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000A1924 File Offset: 0x0009FB24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 640918, RefRangeEnd = 640921, XrefRangeStart = 640917, XrefRangeEnd = 640918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 mod289(float2 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_mod289_Private_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x000A1964 File Offset: 0x0009FB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640921, XrefRangeEnd = 640922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 mod289(float3 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_mod289_Private_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000A19A4 File Offset: 0x0009FBA4
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 640923, RefRangeEnd = 640972, XrefRangeStart = 640922, XrefRangeEnd = 640923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 mod289(float4 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_mod289_Private_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x000A19E4 File Offset: 0x0009FBE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 640973, RefRangeEnd = 640979, XrefRangeStart = 640972, XrefRangeEnd = 640973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 mod7(float3 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_mod7_Private_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x000A1A24 File Offset: 0x0009FC24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 640980, RefRangeEnd = 640984, XrefRangeStart = 640979, XrefRangeEnd = 640980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 mod7(float4 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_mod7_Private_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x000A1A64 File Offset: 0x0009FC64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 640988, RefRangeEnd = 640990, XrefRangeStart = 640984, XrefRangeEnd = 640988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float permute(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_permute_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x000A1AA4 File Offset: 0x0009FCA4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 640991, RefRangeEnd = 641010, XrefRangeStart = 640990, XrefRangeEnd = 640991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 permute(float3 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_permute_Private_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x000A1AE4 File Offset: 0x0009FCE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 641011, RefRangeEnd = 641014, XrefRangeStart = 641010, XrefRangeEnd = 641011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 permute(float4 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_permute_Private_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x000A1B24 File Offset: 0x0009FD24
		[CallerCount(0)]
		public unsafe static float taylorInvSqrt(float r)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_taylorInvSqrt_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x000A1B64 File Offset: 0x0009FD64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 641014, RefRangeEnd = 641022, XrefRangeStart = 641014, XrefRangeEnd = 641014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 taylorInvSqrt(float4 r)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_taylorInvSqrt_Private_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x000A1BA4 File Offset: 0x0009FDA4
		[CallerCount(0)]
		public unsafe static float2 fade(float2 t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_fade_Private_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x000A1BE4 File Offset: 0x0009FDE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 641022, RefRangeEnd = 641024, XrefRangeStart = 641022, XrefRangeEnd = 641022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 fade(float3 t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_fade_Private_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x000A1C24 File Offset: 0x0009FE24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 641024, RefRangeEnd = 641026, XrefRangeStart = 641024, XrefRangeEnd = 641024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 fade(float4 t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_fade_Private_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x000A1C64 File Offset: 0x0009FE64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 641031, RefRangeEnd = 641036, XrefRangeStart = 641026, XrefRangeEnd = 641031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 grad4(float j, float4 ip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_grad4_Private_Static_float4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x000A1CB0 File Offset: 0x0009FEB0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 641053, RefRangeEnd = 641065, XrefRangeStart = 641036, XrefRangeEnd = 641053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 rgrad2(float2 p, float rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_rgrad2_Private_Static_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x000A1CFC File Offset: 0x0009FEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641065, XrefRangeEnd = 641072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float snoise(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000A1D3C File Offset: 0x0009FF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641072, XrefRangeEnd = 641089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float snoise(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x000A1D7C File Offset: 0x0009FF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641089, XrefRangeEnd = 641106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float snoise(float3 v, out float3 gradient)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &gradient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float3_byref_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000A1DC8 File Offset: 0x0009FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641106, XrefRangeEnd = 641140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float snoise(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_snoise_Public_Static_Single_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000A1E08 File Offset: 0x000A0008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641152, RefRangeEnd = 641153, XrefRangeStart = 641140, XrefRangeEnd = 641152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 psrdnoise(float2 pos, float2 per, float rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref per;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_psrdnoise_Public_Static_float3_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000A1E64 File Offset: 0x000A0064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641153, XrefRangeEnd = 641154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 psrdnoise(float2 pos, float2 per)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref per;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_psrdnoise_Public_Static_float3_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000A1EB0 File Offset: 0x000A00B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641166, RefRangeEnd = 641167, XrefRangeStart = 641154, XrefRangeEnd = 641166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float psrnoise(float2 pos, float2 per, float rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref per;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_psrnoise_Public_Static_Single_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000A1F0C File Offset: 0x000A010C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641167, XrefRangeEnd = 641168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float psrnoise(float2 pos, float2 per)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref per;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_psrnoise_Public_Static_Single_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000A1F58 File Offset: 0x000A0158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641176, RefRangeEnd = 641177, XrefRangeStart = 641168, XrefRangeEnd = 641176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 srdnoise(float2 pos, float rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_srdnoise_Public_Static_float3_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000A1FA4 File Offset: 0x000A01A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641177, XrefRangeEnd = 641178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 srdnoise(float2 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_srdnoise_Public_Static_float3_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x000A1FE4 File Offset: 0x000A01E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641186, RefRangeEnd = 641187, XrefRangeStart = 641178, XrefRangeEnd = 641186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float srnoise(float2 pos, float rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_srnoise_Public_Static_Single_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000A2030 File Offset: 0x000A0230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641187, XrefRangeEnd = 641188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float srnoise(float2 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(noise.NativeMethodInfoPtr_srnoise_Public_Static_Single_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0000284E File Offset: 0x00000A4E
		public noise(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr_cellular_Public_Static_float2_float2_0;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr_cellular2x2_Public_Static_float2_float2_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr_cellular2x2x2_Public_Static_float2_float3_0;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeMethodInfoPtr_cellular_Public_Static_float2_float3_0;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr_cnoise_Public_Static_Single_float2_0;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr_pnoise_Public_Static_Single_float2_float2_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeMethodInfoPtr_cnoise_Public_Static_Single_float3_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr_pnoise_Public_Static_Single_float3_float3_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_cnoise_Public_Static_Single_float4_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_pnoise_Public_Static_Single_float4_float4_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_mod289_Private_Static_Single_Single_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_mod289_Private_Static_float2_float2_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_mod289_Private_Static_float3_float3_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_mod289_Private_Static_float4_float4_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_mod7_Private_Static_float3_float3_0;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr_mod7_Private_Static_float4_float4_0;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeMethodInfoPtr_permute_Private_Static_Single_Single_0;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeMethodInfoPtr_permute_Private_Static_float3_float3_0;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeMethodInfoPtr_permute_Private_Static_float4_float4_0;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeMethodInfoPtr_taylorInvSqrt_Private_Static_Single_Single_0;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr_taylorInvSqrt_Private_Static_float4_float4_0;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeMethodInfoPtr_fade_Private_Static_float2_float2_0;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr_fade_Private_Static_float3_float3_0;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr_fade_Private_Static_float4_float4_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr_grad4_Private_Static_float4_Single_float4_0;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr_rgrad2_Private_Static_float2_float2_Single_0;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_snoise_Public_Static_Single_float2_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr_snoise_Public_Static_Single_float3_0;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr_snoise_Public_Static_Single_float3_byref_float3_0;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeMethodInfoPtr_snoise_Public_Static_Single_float4_0;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeMethodInfoPtr_psrdnoise_Public_Static_float3_float2_float2_Single_0;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeMethodInfoPtr_psrdnoise_Public_Static_float3_float2_float2_0;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeMethodInfoPtr_psrnoise_Public_Static_Single_float2_float2_Single_0;

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeMethodInfoPtr_psrnoise_Public_Static_Single_float2_float2_0;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeMethodInfoPtr_srdnoise_Public_Static_float3_float2_Single_0;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeMethodInfoPtr_srdnoise_Public_Static_float3_float2_0;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeMethodInfoPtr_srnoise_Public_Static_Single_float2_Single_0;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeMethodInfoPtr_srnoise_Public_Static_Single_float2_0;
	}
}
