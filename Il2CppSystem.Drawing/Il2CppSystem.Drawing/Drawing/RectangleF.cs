using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Drawing
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	[StructLayout(2)]
	public struct RectangleF
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003240 File Offset: 0x00001440
		// Note: this type is marked as 'beforefieldinit'.
		static RectangleF()
		{
			Il2CppClassPointerStore<RectangleF>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Drawing.dll", "System.Drawing", "RectangleF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangleF>.NativeClassPtr);
			RectangleF.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, "x");
			RectangleF.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, "y");
			RectangleF.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, "width");
			RectangleF.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, "height");
			RectangleF.NativeMethodInfoPtr_get_X_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663341);
			RectangleF.NativeMethodInfoPtr_get_Y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663342);
			RectangleF.NativeMethodInfoPtr_get_Width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663343);
			RectangleF.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663344);
			RectangleF.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663345);
			RectangleF.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectangleF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663346);
			RectangleF.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RectangleF_RectangleF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663347);
			RectangleF.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663348);
			RectangleF.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, 100663349);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003374 File Offset: 0x00001574
		public unsafe float X
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_get_X_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000033A4 File Offset: 0x000015A4
		public unsafe float Y
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_get_Y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000033D4 File Offset: 0x000015D4
		public unsafe float Width
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_get_Width_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003404 File Offset: 0x00001604
		public unsafe float Height
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_get_Height_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003434 File Offset: 0x00001634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227196, XrefRangeEnd = 1227199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003478 File Offset: 0x00001678
		[CallerCount(0)]
		public unsafe bool Equals(RectangleF other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectangleF_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000034B8 File Offset: 0x000016B8
		[CallerCount(0)]
		public unsafe static bool operator ==(RectangleF left, RectangleF right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RectangleF_RectangleF_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003504 File Offset: 0x00001704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227199, XrefRangeEnd = 1227206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003534 File Offset: 0x00001734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227206, XrefRangeEnd = 1227233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangleF.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002155 File Offset: 0x00000355
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectangleF>.NativeClassPtr, ref this));
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_X_Public_get_Single_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_Y_Public_get_Single_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Single_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectangleF_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RectangleF_RectangleF_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000FF RID: 255
		[FieldOffset(0)]
		public float x;

		// Token: 0x04000100 RID: 256
		[FieldOffset(4)]
		public float y;

		// Token: 0x04000101 RID: 257
		[FieldOffset(8)]
		public float width;

		// Token: 0x04000102 RID: 258
		[FieldOffset(12)]
		public float height;
	}
}
