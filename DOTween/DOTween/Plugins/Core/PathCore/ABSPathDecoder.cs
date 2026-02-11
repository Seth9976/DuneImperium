using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000041 RID: 65
	public class ABSPathDecoder : global::Il2CppSystem.Object
	{
		// Token: 0x060003CD RID: 973 RVA: 0x0001809C File Offset: 0x0001629C
		// Note: this type is marked as 'beforefieldinit'.
		static ABSPathDecoder()
		{
			Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "ABSPathDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr);
			ABSPathDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Abstract_Virtual_New_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr, 100664115);
			ABSPathDecoder.NativeMethodInfoPtr_GetPoint_Internal_Abstract_Virtual_New_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr, 100664116);
			ABSPathDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr, 100664117);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00018108 File Offset: 0x00016308
		[CallerCount(0)]
		public unsafe virtual void FinalizePath(Path p, Il2CppStructArray<Vector3> wps, bool isClosedPath)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSPathDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Abstract_Virtual_New_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00018178 File Offset: 0x00016378
		[CallerCount(0)]
		public unsafe virtual Vector3 GetPoint(float perc, Il2CppStructArray<Vector3> wps, Path p, Il2CppStructArray<ControlPoint> controlPoints)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSPathDecoder.NativeMethodInfoPtr_GetPoint_Internal_Abstract_Virtual_New_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00018204 File Offset: 0x00016404
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ABSPathDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ABSPathDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003258 File Offset: 0x00001458
		public ABSPathDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Abstract_Virtual_New_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Abstract_Virtual_New_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
