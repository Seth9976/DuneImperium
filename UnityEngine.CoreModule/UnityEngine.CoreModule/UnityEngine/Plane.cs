using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000083 RID: 131
	[StructLayout(2)]
	public struct Plane
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x0002C964 File Offset: 0x0002AB64
		// Note: this type is marked as 'beforefieldinit'.
		static Plane()
		{
			Il2CppClassPointerStore<Plane>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Plane");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plane>.NativeClassPtr);
			Plane.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "size");
			Plane.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "m_Normal");
			Plane.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "m_Distance");
			Plane.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664137);
			Plane.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664138);
			Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664139);
			Plane.NativeMethodInfoPtr_SetNormalAndPosition_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664140);
			Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664141);
			Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664142);
			Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664143);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00004ADF File Offset: 0x00002CDF
		public unsafe Vector3 normal
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 648521, RefRangeEnd = 648525, XrefRangeStart = 648521, XrefRangeEnd = 648525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00004AE9 File Offset: 0x00002CE9
		public unsafe float distance
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 644431, RefRangeEnd = 644456, XrefRangeStart = 644431, XrefRangeEnd = 644456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0002CABC File Offset: 0x0002ACBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648625, XrefRangeEnd = 648626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(Vector3 inNormal, Vector3 inPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inNormal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inNormal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_SetNormalAndPosition_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0002CB3C File Offset: 0x0002AD3C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 648628, RefRangeEnd = 648642, XrefRangeStart = 648626, XrefRangeEnd = 648628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Ray ray, out float enter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &enter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0002CB88 File Offset: 0x0002AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648642, XrefRangeEnd = 648643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0002CBB4 File Offset: 0x0002ADB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648643, XrefRangeEnd = 648668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00004ABF File Offset: 0x00002CBF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Plane>.NativeClassPtr, ref this));
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0002CC04 File Offset: 0x0002AE04
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00004AD1 File Offset: 0x00002CD1
		public unsafe static int size
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Plane.NativeFieldInfoPtr_size, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Plane.NativeFieldInfoPtr_size, (void*)(&value));
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00004AF3 File Offset: 0x00002CF3
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
		{
			this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.m_Distance = -Vector3.Dot(this.m_Normal, a);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00004B27 File Offset: 0x00002D27
		public void Flip()
		{
			this.m_Normal = -this.m_Normal;
			this.m_Distance = -this.m_Distance;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0002CC20 File Offset: 0x0002AE20
		public Plane flipped
		{
			get
			{
				return new Plane(-this.m_Normal, -this.m_Distance);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00004B48 File Offset: 0x00002D48
		public void Translate(Vector3 translation)
		{
			this.m_Distance += Vector3.Dot(this.m_Normal, translation);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0002CC4C File Offset: 0x0002AE4C
		public static Plane Translate(Plane plane, Vector3 translation)
		{
			return new Plane(plane.m_Normal, plane.m_Distance += Vector3.Dot(plane.m_Normal, translation));
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0002CC84 File Offset: 0x0002AE84
		public Vector3 ClosestPointOnPlane(Vector3 point)
		{
			float num = Vector3.Dot(this.m_Normal, point) + this.m_Distance;
			return point - this.m_Normal * num;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0002CCBC File Offset: 0x0002AEBC
		public float GetDistanceToPoint(Vector3 point)
		{
			return Vector3.Dot(this.m_Normal, point) + this.m_Distance;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		public bool GetSide(Vector3 point)
		{
			return Vector3.Dot(this.m_Normal, point) + this.m_Distance > 0f;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0002CD10 File Offset: 0x0002AF10
		public bool SameSide(Vector3 inPt0, Vector3 inPt1)
		{
			float distanceToPoint = this.GetDistanceToPoint(inPt0);
			float distanceToPoint2 = this.GetDistanceToPoint(inPt1);
			return (distanceToPoint > 0f && distanceToPoint2 > 0f) || (distanceToPoint <= 0f && distanceToPoint2 <= 0f);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalAndPosition_Public_Void_Vector3_Vector3_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040005C7 RID: 1479
		[FieldOffset(0)]
		public Vector3 m_Normal;

		// Token: 0x040005C8 RID: 1480
		[FieldOffset(12)]
		public float m_Distance;
	}
}
