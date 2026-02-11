using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Drawing
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	[StructLayout(2)]
	public struct PointF
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002CB0 File Offset: 0x00000EB0
		// Note: this type is marked as 'beforefieldinit'.
		static PointF()
		{
			Il2CppClassPointerStore<PointF>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Drawing.dll", "System.Drawing", "PointF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointF>.NativeClassPtr);
			PointF.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointF>.NativeClassPtr, "x");
			PointF.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointF>.NativeClassPtr, "y");
			PointF.NativeMethodInfoPtr_get_X_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointF>.NativeClassPtr, 100663325);
			PointF.NativeMethodInfoPtr_get_Y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointF>.NativeClassPtr, 100663326);
			PointF.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PointF_PointF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointF>.NativeClassPtr, 100663327);
			PointF.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointF>.NativeClassPtr, 100663328);
			PointF.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PointF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointF>.NativeClassPtr, 100663329);
			PointF.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointF>.NativeClassPtr, 100663330);
			PointF.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointF>.NativeClassPtr, 100663331);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002D94 File Offset: 0x00000F94
		public unsafe float X
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointF.NativeMethodInfoPtr_get_X_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public unsafe float Y
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointF.NativeMethodInfoPtr_get_Y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002DF4 File Offset: 0x00000FF4
		[CallerCount(0)]
		public unsafe static bool operator ==(PointF left, PointF right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointF.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PointF_PointF_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002E40 File Offset: 0x00001040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227136, XrefRangeEnd = 1227139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointF.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002E84 File Offset: 0x00001084
		[CallerCount(0)]
		public unsafe bool Equals(PointF other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointF.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PointF_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002EC4 File Offset: 0x000010C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227139, XrefRangeEnd = 1227144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointF.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002EF4 File Offset: 0x000010F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227144, XrefRangeEnd = 1227163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointF.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002131 File Offset: 0x00000331
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointF>.NativeClassPtr, ref this));
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_X_Public_get_Single_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_Y_Public_get_Single_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PointF_PointF_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PointF_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000DF RID: 223
		[FieldOffset(0)]
		public float x;

		// Token: 0x040000E0 RID: 224
		[FieldOffset(4)]
		public float y;
	}
}
