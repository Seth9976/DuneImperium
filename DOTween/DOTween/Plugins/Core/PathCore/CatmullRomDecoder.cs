using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000042 RID: 66
	public class CatmullRomDecoder : ABSPathDecoder
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x00018240 File Offset: 0x00016440
		// Note: this type is marked as 'beforefieldinit'.
		static CatmullRomDecoder()
		{
			Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "CatmullRomDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr);
			CatmullRomDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664118);
			CatmullRomDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664119);
			CatmullRomDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664120);
			CatmullRomDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664121);
			CatmullRomDecoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664122);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000182D4 File Offset: 0x000164D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132844, XrefRangeEnd = 1132860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinalizePath(Path p, Il2CppStructArray<Vector3> wps, bool isClosedPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosedPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CatmullRomDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00018344 File Offset: 0x00016544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132860, XrefRangeEnd = 1132866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetPoint(float perc, Il2CppStructArray<Vector3> wps, Path p, Il2CppStructArray<ControlPoint> controlPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CatmullRomDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000183D0 File Offset: 0x000165D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132880, RefRangeEnd = 1132881, XrefRangeStart = 1132866, XrefRangeEnd = 1132880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeToLengthTables(Path p, int subdivisions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatmullRomDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00018420 File Offset: 0x00016620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132896, RefRangeEnd = 1132897, XrefRangeStart = 1132881, XrefRangeEnd = 1132896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaypointsLengths(Path p, int subdivisions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatmullRomDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00018470 File Offset: 0x00016670
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CatmullRomDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatmullRomDecoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00003261 File Offset: 0x00001461
		public CatmullRomDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
