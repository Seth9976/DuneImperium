using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000056 RID: 86
public static class QuaternionUtil : global::Il2CppSystem.Object
{
	// Token: 0x06000656 RID: 1622 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
	// Note: this type is marked as 'beforefieldinit'.
	static QuaternionUtil()
	{
		Il2CppClassPointerStore<QuaternionUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "QuaternionUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuaternionUtil>.NativeClassPtr);
		QuaternionUtil.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionUtil>.NativeClassPtr, 100664262);
		QuaternionUtil.NativeMethodInfoPtr_QuaternionFromMatrix_Public_Static_Quaternion_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionUtil>.NativeClassPtr, 100664263);
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x0002D508 File Offset: 0x0002B708
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859552, RefRangeEnd = 859554, XrefRangeStart = 859548, XrefRangeEnd = 859552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Approximately(this Quaternion q, Quaternion other)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref q;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionUtil.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x0002D554 File Offset: 0x0002B754
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859554, XrefRangeEnd = 859582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion QuaternionFromMatrix(Matrix4x4 m)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionUtil.NativeMethodInfoPtr_QuaternionFromMatrix_Public_Static_Quaternion_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00004154 File Offset: 0x00002354
	public QuaternionUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040004C6 RID: 1222
	private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Quaternion_Quaternion_0;

	// Token: 0x040004C7 RID: 1223
	private static readonly IntPtr NativeMethodInfoPtr_QuaternionFromMatrix_Public_Static_Quaternion_Matrix4x4_0;
}
