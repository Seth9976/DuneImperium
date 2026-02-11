using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000D7 RID: 215
	public static class SpaceFillingCurves : Object
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x0004F7E0 File Offset: 0x0004D9E0
		// Note: this type is marked as 'beforefieldinit'.
		static SpaceFillingCurves()
		{
			Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "SpaceFillingCurves");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr);
			SpaceFillingCurves.NativeMethodInfoPtr_Part1By1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665422);
			SpaceFillingCurves.NativeMethodInfoPtr_Compact1By1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665423);
			SpaceFillingCurves.NativeMethodInfoPtr_EncodeMorton2D_Public_Static_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665424);
			SpaceFillingCurves.NativeMethodInfoPtr_DecodeMorton2D_Public_Static_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665425);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0004F860 File Offset: 0x0004DA60
		[CallerCount(0)]
		public unsafe static uint Part1By1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceFillingCurves.NativeMethodInfoPtr_Part1By1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0004F8A0 File Offset: 0x0004DAA0
		[CallerCount(0)]
		public unsafe static uint Compact1By1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceFillingCurves.NativeMethodInfoPtr_Compact1By1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0004F8E0 File Offset: 0x0004DAE0
		[CallerCount(0)]
		public unsafe static uint EncodeMorton2D(uint2 coord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref coord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceFillingCurves.NativeMethodInfoPtr_EncodeMorton2D_Public_Static_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0004F920 File Offset: 0x0004DB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617553, RefRangeEnd = 617554, XrefRangeStart = 617553, XrefRangeEnd = 617553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint2 DecodeMorton2D(uint code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceFillingCurves.NativeMethodInfoPtr_DecodeMorton2D_Public_Static_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00009F23 File Offset: 0x00008123
		public SpaceFillingCurves(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_Part1By1_Private_Static_UInt32_UInt32_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_Compact1By1_Private_Static_UInt32_UInt32_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_EncodeMorton2D_Public_Static_UInt32_uint2_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_DecodeMorton2D_Public_Static_uint2_UInt32_0;
	}
}
