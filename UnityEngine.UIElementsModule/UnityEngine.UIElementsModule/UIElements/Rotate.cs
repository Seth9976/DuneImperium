using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000193 RID: 403
	[StructLayout(2)]
	public struct Rotate
	{
		// Token: 0x06002163 RID: 8547 RVA: 0x00096BE0 File Offset: 0x00094DE0
		// Note: this type is marked as 'beforefieldinit'.
		static Rotate()
		{
			Il2CppClassPointerStore<Rotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Rotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotate>.NativeClassPtr);
			Rotate.NativeFieldInfoPtr_m_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotate>.NativeClassPtr, "m_Angle");
			Rotate.NativeFieldInfoPtr_m_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotate>.NativeClassPtr, "m_Axis");
			Rotate.NativeFieldInfoPtr_m_IsNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotate>.NativeClassPtr, "m_IsNone");
			Rotate.NativeMethodInfoPtr__ctor_Public_Void_Angle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668216);
			Rotate.NativeMethodInfoPtr_Initial_Internal_Static_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668217);
			Rotate.NativeMethodInfoPtr_None_Public_Static_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668218);
			Rotate.NativeMethodInfoPtr_get_angle_Public_get_Angle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668219);
			Rotate.NativeMethodInfoPtr_set_angle_Public_set_Void_Angle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668220);
			Rotate.NativeMethodInfoPtr_get_axis_Internal_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668221);
			Rotate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rotate_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668222);
			Rotate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rotate_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668223);
			Rotate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668224);
			Rotate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668225);
			Rotate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668226);
			Rotate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668227);
			Rotate.NativeMethodInfoPtr_ToQuaternion_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100668228);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00096D50 File Offset: 0x00094F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334490, XrefRangeEnd = 334492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotate(Angle angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr__ctor_Public_Void_Angle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00096D84 File Offset: 0x00094F84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334495, RefRangeEnd = 334499, XrefRangeStart = 334492, XrefRangeEnd = 334495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rotate Initial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_Initial_Internal_Static_Rotate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00096DB4 File Offset: 0x00094FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334502, RefRangeEnd = 334504, XrefRangeStart = 334499, XrefRangeEnd = 334502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rotate None()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_None_Public_Static_Rotate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x00096DE4 File Offset: 0x00094FE4
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x00096E14 File Offset: 0x00095014
		public unsafe Angle angle
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_get_angle_Public_get_Angle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_set_angle_Public_set_Void_Angle_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x00096E48 File Offset: 0x00095048
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x0000E086 File Offset: 0x0000C286
		public unsafe Vector3 axis
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_get_axis_Internal_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Axis = value;
			}
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00096E78 File Offset: 0x00095078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334505, RefRangeEnd = 334506, XrefRangeStart = 334504, XrefRangeEnd = 334505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Rotate lhs, Rotate rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rotate_Rotate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00096EC4 File Offset: 0x000950C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334507, RefRangeEnd = 334509, XrefRangeStart = 334506, XrefRangeEnd = 334507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Rotate lhs, Rotate rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rotate_Rotate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00096F10 File Offset: 0x00095110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334510, RefRangeEnd = 334511, XrefRangeStart = 334509, XrefRangeEnd = 334510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Rotate other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rotate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00096F50 File Offset: 0x00095150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334511, XrefRangeEnd = 334515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00096F94 File Offset: 0x00095194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334523, RefRangeEnd = 334525, XrefRangeStart = 334515, XrefRangeEnd = 334523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00096FC4 File Offset: 0x000951C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334525, XrefRangeEnd = 334530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00096FF0 File Offset: 0x000951F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334532, RefRangeEnd = 334534, XrefRangeStart = 334530, XrefRangeEnd = 334532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion ToQuaternion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_ToQuaternion_Internal_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0000E074 File Offset: 0x0000C274
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Rotate>.NativeClassPtr, ref this));
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0000E08F File Offset: 0x0000C28F
		public bool IsNone()
		{
			return this.m_IsNone;
		}

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeFieldInfoPtr_m_Angle;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeFieldInfoPtr_m_Axis;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeFieldInfoPtr_m_IsNone;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Angle_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_Initial_Internal_Static_Rotate_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_None_Public_Static_Rotate_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_get_angle_Public_get_Angle_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_set_angle_Public_set_Void_Angle_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_get_axis_Internal_get_Vector3_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rotate_Rotate_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rotate_Rotate_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rotate_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_ToQuaternion_Internal_Quaternion_0;

		// Token: 0x04001777 RID: 6007
		[FieldOffset(0)]
		public Angle m_Angle;

		// Token: 0x04001778 RID: 6008
		[FieldOffset(8)]
		public Vector3 m_Axis;

		// Token: 0x04001779 RID: 6009
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool m_IsNone;
	}
}
