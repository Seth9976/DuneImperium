using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A9 RID: 425
	[StructLayout(2)]
	public struct TransformOrigin
	{
		// Token: 0x060022AF RID: 8879 RVA: 0x0009BB5C File Offset: 0x00099D5C
		// Note: this type is marked as 'beforefieldinit'.
		static TransformOrigin()
		{
			Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransformOrigin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr);
			TransformOrigin.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, "m_X");
			TransformOrigin.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, "m_Y");
			TransformOrigin.NativeFieldInfoPtr_m_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, "m_Z");
			TransformOrigin.NativeMethodInfoPtr__ctor_Public_Void_Length_Length_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668426);
			TransformOrigin.NativeMethodInfoPtr_Initial_Public_Static_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668427);
			TransformOrigin.NativeMethodInfoPtr_get_x_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668428);
			TransformOrigin.NativeMethodInfoPtr_set_x_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668429);
			TransformOrigin.NativeMethodInfoPtr_get_y_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668430);
			TransformOrigin.NativeMethodInfoPtr_set_y_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668431);
			TransformOrigin.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668432);
			TransformOrigin.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransformOrigin_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668433);
			TransformOrigin.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransformOrigin_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668434);
			TransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668435);
			TransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668436);
			TransformOrigin.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668437);
			TransformOrigin.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, 100668438);
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0009BCCC File Offset: 0x00099ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335980, RefRangeEnd = 335981, XrefRangeStart = 335980, XrefRangeEnd = 335980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformOrigin(Length x, Length y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr__ctor_Public_Void_Length_Length_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0009BD1C File Offset: 0x00099F1C
		[CallerCount(0)]
		public unsafe static TransformOrigin Initial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_Initial_Public_Static_TransformOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0009BD4C File Offset: 0x00099F4C
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0009BD7C File Offset: 0x00099F7C
		public unsafe Length x
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_get_x_Public_get_Length_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_set_x_Public_set_Void_Length_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x0009BDB0 File Offset: 0x00099FB0
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x0009BDE0 File Offset: 0x00099FE0
		public unsafe Length y
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_get_y_Public_get_Length_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_set_y_Public_set_Void_Length_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x0009BE14 File Offset: 0x0009A014
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0000E4CA File Offset: 0x0000C6CA
		public unsafe float z
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_get_z_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Z = value;
			}
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0009BE44 File Offset: 0x0009A044
		[CallerCount(0)]
		public unsafe static bool operator ==(TransformOrigin lhs, TransformOrigin rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransformOrigin_TransformOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0009BE90 File Offset: 0x0009A090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335981, RefRangeEnd = 335983, XrefRangeStart = 335981, XrefRangeEnd = 335981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TransformOrigin lhs, TransformOrigin rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransformOrigin_TransformOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0009BEDC File Offset: 0x0009A0DC
		[CallerCount(0)]
		public unsafe bool Equals(TransformOrigin other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransformOrigin_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0009BF1C File Offset: 0x0009A11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335983, XrefRangeEnd = 335986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0009BF60 File Offset: 0x0009A160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335989, RefRangeEnd = 335991, XrefRangeStart = 335986, XrefRangeEnd = 335989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0009BF90 File Offset: 0x0009A190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335991, XrefRangeEnd = 336012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformOrigin.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformOrigin>.NativeClassPtr, ref this));
		}

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeFieldInfoPtr_m_Z;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Length_Length_Single_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_Initial_Public_Static_TransformOrigin_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Length_0;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Length_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Length_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Length_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransformOrigin_TransformOrigin_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransformOrigin_TransformOrigin_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransformOrigin_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400188B RID: 6283
		[FieldOffset(0)]
		public Length m_X;

		// Token: 0x0400188C RID: 6284
		[FieldOffset(8)]
		public Length m_Y;

		// Token: 0x0400188D RID: 6285
		[FieldOffset(16)]
		public float m_Z;
	}
}
