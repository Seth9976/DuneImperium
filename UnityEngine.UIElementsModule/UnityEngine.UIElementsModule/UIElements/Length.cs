using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000192 RID: 402
	[Serializable]
	[StructLayout(2)]
	public struct Length
	{
		// Token: 0x0600214C RID: 8524 RVA: 0x000965F0 File Offset: 0x000947F0
		// Note: this type is marked as 'beforefieldinit'.
		static Length()
		{
			Il2CppClassPointerStore<Length>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Length");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Length>.NativeClassPtr);
			Length.NativeFieldInfoPtr_k_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Length>.NativeClassPtr, "k_MaxValue");
			Length.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Length>.NativeClassPtr, "m_Value");
			Length.NativeFieldInfoPtr_m_Unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Length>.NativeClassPtr, "m_Unit");
			Length.NativeMethodInfoPtr_Percent_Public_Static_Length_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668198);
			Length.NativeMethodInfoPtr_Auto_Public_Static_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668199);
			Length.NativeMethodInfoPtr_None_Public_Static_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668200);
			Length.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668201);
			Length.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668202);
			Length.NativeMethodInfoPtr_get_unit_Public_get_LengthUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668203);
			Length.NativeMethodInfoPtr_IsAuto_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668204);
			Length.NativeMethodInfoPtr_IsNone_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668205);
			Length.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668206);
			Length.NativeMethodInfoPtr__ctor_Public_Void_Single_LengthUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668207);
			Length.NativeMethodInfoPtr__ctor_Private_Void_Single_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668208);
			Length.NativeMethodInfoPtr_op_Implicit_Public_Static_Length_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668209);
			Length.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Length_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668210);
			Length.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Length_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668211);
			Length.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668212);
			Length.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668213);
			Length.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668214);
			Length.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100668215);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x000967C4 File Offset: 0x000949C4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 334279, RefRangeEnd = 334291, XrefRangeStart = 334279, XrefRangeEnd = 334279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Length Percent(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_Percent_Public_Static_Length_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00096804 File Offset: 0x00094A04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 334291, RefRangeEnd = 334298, XrefRangeStart = 334291, XrefRangeEnd = 334291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Length Auto()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_Auto_Public_Static_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00096834 File Offset: 0x00094A34
		[CallerCount(0)]
		public unsafe static Length None()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_None_Public_Static_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x00096864 File Offset: 0x00094A64
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x00096894 File Offset: 0x00094A94
		public unsafe float value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_get_value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x000968C8 File Offset: 0x00094AC8
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x0000E06B File Offset: 0x0000C26B
		public unsafe LengthUnit unit
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_get_unit_Public_get_LengthUnit_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Unit = (Length.Unit)value;
			}
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000968F8 File Offset: 0x00094AF8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 334298, RefRangeEnd = 334315, XrefRangeStart = 334298, XrefRangeEnd = 334298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAuto()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_IsAuto_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00096928 File Offset: 0x00094B28
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 334315, RefRangeEnd = 334333, XrefRangeStart = 334315, XrefRangeEnd = 334315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_IsNone_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00096958 File Offset: 0x00094B58
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 334333, RefRangeEnd = 334355, XrefRangeStart = 334333, XrefRangeEnd = 334333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Length(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0009698C File Offset: 0x00094B8C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 334355, RefRangeEnd = 334371, XrefRangeStart = 334355, XrefRangeEnd = 334355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Length(float value, LengthUnit unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr__ctor_Public_Void_Single_LengthUnit_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000969CC File Offset: 0x00094BCC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 334355, RefRangeEnd = 334371, XrefRangeStart = 334355, XrefRangeEnd = 334371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Length(float value, Length.Unit unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr__ctor_Private_Void_Single_Unit_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00096A0C File Offset: 0x00094C0C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 334371, RefRangeEnd = 334408, XrefRangeStart = 334371, XrefRangeEnd = 334371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Length(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_op_Implicit_Public_Static_Length_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00096A4C File Offset: 0x00094C4C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 323546, RefRangeEnd = 323585, XrefRangeStart = 323546, XrefRangeEnd = 323585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Length lhs, Length rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Length_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00096A98 File Offset: 0x00094C98
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 334408, RefRangeEnd = 334463, XrefRangeStart = 334408, XrefRangeEnd = 334408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Length lhs, Length rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Length_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00096AE4 File Offset: 0x00094CE4
		[CallerCount(0)]
		public unsafe bool Equals(Length other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Length_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00096B24 File Offset: 0x00094D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334463, XrefRangeEnd = 334466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00096B68 File Offset: 0x00094D68
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 323589, RefRangeEnd = 323599, XrefRangeStart = 323589, XrefRangeEnd = 323599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00096B98 File Offset: 0x00094D98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334486, RefRangeEnd = 334490, XrefRangeStart = 334466, XrefRangeEnd = 334486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0000E04B File Offset: 0x0000C24B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Length>.NativeClassPtr, ref this));
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x00096BC4 File Offset: 0x00094DC4
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x0000E05D File Offset: 0x0000C25D
		public unsafe static float k_MaxValue
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Length.NativeFieldInfoPtr_k_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Length.NativeFieldInfoPtr_k_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxValue;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeFieldInfoPtr_m_Unit;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_Percent_Public_Static_Length_Single_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_Auto_Public_Static_Length_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_None_Public_Static_Length_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_get_unit_Public_get_LengthUnit_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_IsAuto_Public_Boolean_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_IsNone_Public_Boolean_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_LengthUnit_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Single_Unit_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Length_Single_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Length_Length_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Length_Length_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Length_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001765 RID: 5989
		[FieldOffset(0)]
		public float m_Value;

		// Token: 0x04001766 RID: 5990
		[FieldOffset(4)]
		public Length.Unit m_Unit;

		// Token: 0x020004BD RID: 1213
		public enum Unit
		{
			// Token: 0x04002BCC RID: 11212
			Pixel,
			// Token: 0x04002BCD RID: 11213
			Percent,
			// Token: 0x04002BCE RID: 11214
			Auto,
			// Token: 0x04002BCF RID: 11215
			None
		}
	}
}
