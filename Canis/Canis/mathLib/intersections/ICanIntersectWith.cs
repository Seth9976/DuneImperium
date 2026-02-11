using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000080 RID: 128
	public class ICanIntersectWith<TGeometry> : Il2CppObjectBase
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x00035FD8 File Offset: 0x000341D8
		// Note: this type is marked as 'beforefieldinit'.
		static ICanIntersectWith()
		{
			Il2CppClassPointerStore<ICanIntersectWith<TGeometry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "ICanIntersectWith`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGeometry>.NativeClassPtr)) })).TypeHandle.value);
			ICanIntersectWith<TGeometry>.NativeMethodInfoPtr_Intersects_Public_Abstract_Virtual_New_Boolean_byref_TGeometry_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanIntersectWith<TGeometry>>.NativeClassPtr, 100664744);
			ICanIntersectWith<TGeometry>.NativeMethodInfoPtr_Intersection_Public_Abstract_Virtual_New_IIntersection_byref_TGeometry_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanIntersectWith<TGeometry>>.NativeClassPtr, 100664745);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00036064 File Offset: 0x00034264
		[CallerCount(0)]
		public unsafe virtual bool Intersects([In] ref TGeometry geometry, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(geometry);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanIntersectWith<TGeometry>.NativeMethodInfoPtr_Intersects_Public_Abstract_Virtual_New_Boolean_byref_TGeometry_IntersectionDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			geometry = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TGeometry>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000360E4 File Offset: 0x000342E4
		[CallerCount(0)]
		public unsafe virtual IIntersection Intersection([In] ref TGeometry geometry, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(geometry);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanIntersectWith<TGeometry>.NativeMethodInfoPtr_Intersection_Public_Abstract_Virtual_New_IIntersection_byref_TGeometry_IntersectionDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			geometry = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TGeometry>(intPtr4, false, false));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr5) : null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00004AC6 File Offset: 0x00002CC6
		public ICanIntersectWith(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Abstract_Virtual_New_Boolean_byref_TGeometry_IntersectionDimension_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_Abstract_Virtual_New_IIntersection_byref_TGeometry_IntersectionDimension_0;
	}
}
