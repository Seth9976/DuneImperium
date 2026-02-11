using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000278 RID: 632
	public static class LightmapperUtils : Object
	{
		// Token: 0x06002B27 RID: 11047 RVA: 0x000AF048 File Offset: 0x000AD248
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapperUtils()
		{
			Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightmapperUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668601);
			LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668602);
			LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668603);
			LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668604);
			LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668605);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668606);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668607);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668608);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668609);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668610);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668611);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000AF154 File Offset: 0x000AD354
		[CallerCount(0)]
		public unsafe static LightMode Extract(LightmapBakeType baketype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baketype;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000AF194 File Offset: 0x000AD394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685967, XrefRangeEnd = 685971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor ExtractIndirect(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000AF1D8 File Offset: 0x000AD3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685971, XrefRangeEnd = 685974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ExtractInnerCone(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000AF21C File Offset: 0x000AD41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685974, XrefRangeEnd = 685978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ExtractColorTemperature(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000AF260 File Offset: 0x000AD460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685978, XrefRangeEnd = 685981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cct;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000AF2A0 File Offset: 0x000AD4A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686005, RefRangeEnd = 686007, XrefRangeStart = 685981, XrefRangeEnd = 686005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DirectionalLight dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000AF2E4 File Offset: 0x000AD4E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 686032, RefRangeEnd = 686035, XrefRangeStart = 686007, XrefRangeEnd = 686032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref PointLight point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000AF328 File Offset: 0x000AD528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686064, RefRangeEnd = 686066, XrefRangeStart = 686035, XrefRangeEnd = 686064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref SpotLight spot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000AF36C File Offset: 0x000AD56C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686091, RefRangeEnd = 686092, XrefRangeStart = 686066, XrefRangeEnd = 686091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref RectangleLight rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000AF3B0 File Offset: 0x000AD5B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 686032, RefRangeEnd = 686035, XrefRangeStart = 686032, XrefRangeEnd = 686035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DiscLight disc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &disc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000AF3F4 File Offset: 0x000AD5F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 686108, RefRangeEnd = 686113, XrefRangeStart = 686092, XrefRangeEnd = 686108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, out Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00010DF7 File Offset: 0x0000EFF7
		public LightmapperUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0;
	}
}
