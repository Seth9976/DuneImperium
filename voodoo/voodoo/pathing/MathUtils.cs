using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace voodoo.pathing
{
	// Token: 0x02000031 RID: 49
	public class MathUtils : global::Il2CppSystem.Object
	{
		// Token: 0x060001FA RID: 506 RVA: 0x0000F2F8 File Offset: 0x0000D4F8
		// Note: this type is marked as 'beforefieldinit'.
		static MathUtils()
		{
			Il2CppClassPointerStore<MathUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing", "MathUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathUtils>.NativeClassPtr);
			MathUtils.NativeMethodInfoPtr_QuaternionBezier_Public_Static_Quaternion_Quaternion_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663509);
			MathUtils.NativeMethodInfoPtr_QuaternionNormalize_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663510);
			MathUtils.NativeMethodInfoPtr_Vector3Bezier_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663511);
			MathUtils.NativeMethodInfoPtr_FloatBezier_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663512);
			MathUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663513);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000F38C File Offset: 0x0000D58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107833, RefRangeEnd = 1107834, XrefRangeStart = 1107813, XrefRangeEnd = 1107833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion QuaternionBezier(Quaternion p, Quaternion prevP, Quaternion nextP, Quaternion nextNextP, float stepPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextNextP;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_QuaternionBezier_Public_Static_Quaternion_Quaternion_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000F404 File Offset: 0x0000D604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107834, XrefRangeEnd = 1107837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion QuaternionNormalize(Quaternion q)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_QuaternionNormalize_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000F444 File Offset: 0x0000D644
		[CallerCount(0)]
		public unsafe static Vector3 Vector3Bezier(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_Vector3Bezier_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000F4BC File Offset: 0x0000D6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107837, RefRangeEnd = 1107838, XrefRangeStart = 1107837, XrefRangeEnd = 1107837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float FloatBezier(float p0, float p1, float p2, float p3, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_FloatBezier_Public_Static_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000F534 File Offset: 0x0000D734
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MathUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MathUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000317A File Offset: 0x0000137A
		public MathUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_QuaternionBezier_Public_Static_Quaternion_Quaternion_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_QuaternionNormalize_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_Vector3Bezier_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_FloatBezier_Public_Static_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
