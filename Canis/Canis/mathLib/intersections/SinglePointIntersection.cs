using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000089 RID: 137
	[StructLayout(2)]
	public struct SinglePointIntersection
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x00036A9C File Offset: 0x00034C9C
		// Note: this type is marked as 'beforefieldinit'.
		static SinglePointIntersection()
		{
			Il2CppClassPointerStore<SinglePointIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "SinglePointIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SinglePointIntersection>.NativeClassPtr);
			SinglePointIntersection.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePointIntersection>.NativeClassPtr, "Point");
			SinglePointIntersection.NativeMethodInfoPtr__ctor_Public_Void_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePointIntersection>.NativeClassPtr, 100664776);
			SinglePointIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePointIntersection>.NativeClassPtr, 100664777);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00036B08 File Offset: 0x00034D08
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SinglePointIntersection([In] ref DwdVector2Floating point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinglePointIntersection.NativeMethodInfoPtr__ctor_Public_Void_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00036B3C File Offset: 0x00034D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557192, XrefRangeEnd = 557198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinglePointIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SinglePointIntersection>.NativeClassPtr, ref this));
		}

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_Point;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_DwdVector2Floating_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000500 RID: 1280
		[FieldOffset(0)]
		public readonly DwdVector2Floating Point;
	}
}
