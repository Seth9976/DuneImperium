using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009B RID: 155
	public class ColorGamutUtility : Object
	{
		// Token: 0x060009BF RID: 2495 RVA: 0x0003576C File Offset: 0x0003396C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGamutUtility()
		{
			Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorGamutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr);
			ColorGamutUtility.NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664397);
			ColorGamutUtility.NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664398);
			ColorGamutUtility.NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664399);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000357D8 File Offset: 0x000339D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 650133, RefRangeEnd = 650136, XrefRangeStart = 650131, XrefRangeEnd = 650133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorPrimaries GetColorPrimaries(ColorGamut gamut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gamut;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00035818 File Offset: 0x00033A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 650138, RefRangeEnd = 650139, XrefRangeStart = 650136, XrefRangeEnd = 650138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WhitePoint GetWhitePoint(ColorGamut gamut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gamut;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00035858 File Offset: 0x00033A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 650141, RefRangeEnd = 650142, XrefRangeStart = 650139, XrefRangeEnd = 650141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransferFunction GetTransferFunction(ColorGamut gamut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gamut;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00005B13 File Offset: 0x00003D13
		public ColorGamutUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0;
	}
}
