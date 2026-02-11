using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000087 RID: 135
	[StructLayout(2)]
	public struct RayIntersection
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x0003687C File Offset: 0x00034A7C
		// Note: this type is marked as 'beforefieldinit'.
		static RayIntersection()
		{
			Il2CppClassPointerStore<RayIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "RayIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayIntersection>.NativeClassPtr);
			RayIntersection.NativeFieldInfoPtr_Ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayIntersection>.NativeClassPtr, "Ray");
			RayIntersection.NativeMethodInfoPtr__ctor_Public_Void_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayIntersection>.NativeClassPtr, 100664771);
			RayIntersection.NativeMethodInfoPtr_LimitedToDimension_Public_Static_IIntersection_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayIntersection>.NativeClassPtr, 100664772);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000368E8 File Offset: 0x00034AE8
		[CallerCount(0)]
		public unsafe RayIntersection(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayIntersection.NativeMethodInfoPtr__ctor_Public_Void_Ray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0003691C File Offset: 0x00034B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557163, XrefRangeEnd = 557168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IIntersection LimitedToDimension(Ray ray, IntersectionDimension dim)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayIntersection.NativeMethodInfoPtr_LimitedToDimension_Public_Static_IIntersection_Ray_IntersectionDimension_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00004B9F File Offset: 0x00002D9F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayIntersection>.NativeClassPtr, ref this));
		}

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_Ray;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_LimitedToDimension_Public_Static_IIntersection_Ray_IntersectionDimension_0;

		// Token: 0x040004F7 RID: 1271
		[FieldOffset(0)]
		public readonly Ray Ray;
	}
}
