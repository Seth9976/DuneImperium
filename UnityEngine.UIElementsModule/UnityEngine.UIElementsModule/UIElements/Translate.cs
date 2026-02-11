using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AA RID: 426
	[StructLayout(2)]
	public struct Translate
	{
		// Token: 0x060022BF RID: 8895 RVA: 0x0009BFBC File Offset: 0x0009A1BC
		// Note: this type is marked as 'beforefieldinit'.
		static Translate()
		{
			Il2CppClassPointerStore<Translate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Translate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Translate>.NativeClassPtr);
			Translate.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Translate>.NativeClassPtr, "m_X");
			Translate.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Translate>.NativeClassPtr, "m_Y");
			Translate.NativeFieldInfoPtr_m_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Translate>.NativeClassPtr, "m_Z");
			Translate.NativeFieldInfoPtr_m_isNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Translate>.NativeClassPtr, "m_isNone");
			Translate.NativeMethodInfoPtr__ctor_Public_Void_Length_Length_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668439);
			Translate.NativeMethodInfoPtr_None_Public_Static_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668440);
			Translate.NativeMethodInfoPtr_get_x_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668441);
			Translate.NativeMethodInfoPtr_set_x_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668442);
			Translate.NativeMethodInfoPtr_get_y_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668443);
			Translate.NativeMethodInfoPtr_set_y_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668444);
			Translate.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668445);
			Translate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Translate_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668446);
			Translate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Translate_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668447);
			Translate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668448);
			Translate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668449);
			Translate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668450);
			Translate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Translate>.NativeClassPtr, 100668451);
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0009C140 File Offset: 0x0009A340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336012, RefRangeEnd = 336014, XrefRangeStart = 336012, XrefRangeEnd = 336012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Translate(Length x, Length y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr__ctor_Public_Void_Length_Length_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0009C190 File Offset: 0x0009A390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336014, RefRangeEnd = 336015, XrefRangeStart = 336014, XrefRangeEnd = 336014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Translate None()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_None_Public_Static_Translate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x0009C1C0 File Offset: 0x0009A3C0
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x0009C1F0 File Offset: 0x0009A3F0
		public unsafe Length x
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_get_x_Public_get_Length_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_set_x_Public_set_Void_Length_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0009C224 File Offset: 0x0009A424
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x0009C254 File Offset: 0x0009A454
		public unsafe Length y
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_get_y_Public_get_Length_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_set_y_Public_set_Void_Length_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0009C288 File Offset: 0x0009A488
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x0000E4E5 File Offset: 0x0000C6E5
		public unsafe float z
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_get_z_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Z = value;
			}
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0009C2B8 File Offset: 0x0009A4B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 336015, RefRangeEnd = 336022, XrefRangeStart = 336015, XrefRangeEnd = 336015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Translate lhs, Translate rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Translate_Translate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x0009C304 File Offset: 0x0009A504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336023, RefRangeEnd = 336025, XrefRangeStart = 336022, XrefRangeEnd = 336023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Translate lhs, Translate rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Translate_Translate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0009C350 File Offset: 0x0009A550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336025, XrefRangeEnd = 336026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Translate other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Translate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0009C390 File Offset: 0x0009A590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336026, XrefRangeEnd = 336030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0009C3D4 File Offset: 0x0009A5D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335989, RefRangeEnd = 335991, XrefRangeStart = 335989, XrefRangeEnd = 335991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0009C404 File Offset: 0x0009A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336030, XrefRangeEnd = 336051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Translate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0000E4D3 File Offset: 0x0000C6D3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Translate>.NativeClassPtr, ref this));
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0000E4EE File Offset: 0x0000C6EE
		public bool IsNone()
		{
			return this.m_isNone;
		}

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeFieldInfoPtr_m_Z;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeFieldInfoPtr_m_isNone;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Length_Length_Single_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_None_Public_Static_Translate_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Length_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Length_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Length_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Length_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Translate_Translate_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Translate_Translate_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Translate_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400189F RID: 6303
		[FieldOffset(0)]
		public Length m_X;

		// Token: 0x040018A0 RID: 6304
		[FieldOffset(8)]
		public Length m_Y;

		// Token: 0x040018A1 RID: 6305
		[FieldOffset(16)]
		public float m_Z;

		// Token: 0x040018A2 RID: 6306
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool m_isNone;
	}
}
