using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000078 RID: 120
	public static class MathFuncs : Object
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x00033AD8 File Offset: 0x00031CD8
		// Note: this type is marked as 'beforefieldinit'.
		static MathFuncs()
		{
			Il2CppClassPointerStore<MathFuncs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "MathFuncs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathFuncs>.NativeClassPtr);
			MathFuncs.NativeMethodInfoPtr_GetRect_Public_Static_Polygon_DwdVector2_AngleRadians_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathFuncs>.NativeClassPtr, 100664651);
			MathFuncs.NativeMethodInfoPtr_InSightOf_Public_Static_Boolean_DwdVector2_DwdVector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathFuncs>.NativeClassPtr, 100664652);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00033B30 File Offset: 0x00031D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556332, XrefRangeEnd = 556356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Polygon GetRect(DwdVector2 position, AngleRadians direction, int length, int width)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathFuncs.NativeMethodInfoPtr_GetRect_Public_Static_Polygon_DwdVector2_AngleRadians_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Polygon(intPtr);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00033B94 File Offset: 0x00031D94
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InSightOf(DwdVector2 pos1, DwdVector2 pos2, int direction, int angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathFuncs.NativeMethodInfoPtr_InSightOf_Public_Static_Boolean_DwdVector2_DwdVector2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000049AA File Offset: 0x00002BAA
		public MathFuncs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Polygon_DwdVector2_AngleRadians_Int32_Int32_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_InSightOf_Public_Static_Boolean_DwdVector2_DwdVector2_Int32_Int32_0;
	}
}
