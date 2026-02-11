using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000086 RID: 134
	public sealed class PolygonalIntersection : ValueType
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x0003679C File Offset: 0x0003499C
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonalIntersection()
		{
			Il2CppClassPointerStore<PolygonalIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "PolygonalIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonalIntersection>.NativeClassPtr);
			PolygonalIntersection.NativeFieldInfoPtr_Polygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalIntersection>.NativeClassPtr, "Polygon");
			PolygonalIntersection.NativeMethodInfoPtr__ctor_Public_Void_Polygon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalIntersection>.NativeClassPtr, 100664770);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000367F4 File Offset: 0x000349F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolygonalIntersection(Polygon polygon)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonalIntersection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(polygon));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalIntersection.NativeMethodInfoPtr__ctor_Public_Void_Polygon_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00004B56 File Offset: 0x00002D56
		public PolygonalIntersection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00004B5F File Offset: 0x00002D5F
		public PolygonalIntersection()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonalIntersection>.NativeClassPtr))
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0003684C File Offset: 0x00034A4C
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00004B71 File Offset: 0x00002D71
		public Polygon Polygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalIntersection.NativeFieldInfoPtr_Polygon);
				return new Polygon(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Polygon>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalIntersection.NativeFieldInfoPtr_Polygon), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Polygon>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_Polygon;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Polygon_0;
	}
}
