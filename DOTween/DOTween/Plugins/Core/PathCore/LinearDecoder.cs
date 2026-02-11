using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000043 RID: 67
	public class LinearDecoder : ABSPathDecoder
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x000184AC File Offset: 0x000166AC
		// Note: this type is marked as 'beforefieldinit'.
		static LinearDecoder()
		{
			Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "LinearDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr);
			LinearDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr, 100664123);
			LinearDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr, 100664124);
			LinearDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr, 100664125);
			LinearDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr, 100664126);
			LinearDecoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr, 100664127);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00018540 File Offset: 0x00016740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132897, XrefRangeEnd = 1132900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinearDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000185B0 File Offset: 0x000167B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132900, XrefRangeEnd = 1132907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinearDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0001863C File Offset: 0x0001683C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132921, RefRangeEnd = 1132922, XrefRangeStart = 1132907, XrefRangeEnd = 1132921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0001868C File Offset: 0x0001688C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000186DC File Offset: 0x000168DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinearDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinearDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearDecoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000326A File Offset: 0x0000146A
		public LinearDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
