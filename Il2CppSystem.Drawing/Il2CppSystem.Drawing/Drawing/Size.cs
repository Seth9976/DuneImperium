using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Drawing
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	[StructLayout(2)]
	public struct Size
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003560 File Offset: 0x00001760
		// Note: this type is marked as 'beforefieldinit'.
		static Size()
		{
			Il2CppClassPointerStore<Size>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Drawing.dll", "System.Drawing", "Size");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Size>.NativeClassPtr);
			Size.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Size>.NativeClassPtr, "width");
			Size.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Size>.NativeClassPtr, "height");
			Size.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Size_Size_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Size>.NativeClassPtr, 100663350);
			Size.NativeMethodInfoPtr_get_Width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Size>.NativeClassPtr, 100663351);
			Size.NativeMethodInfoPtr_get_Height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Size>.NativeClassPtr, 100663352);
			Size.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Size>.NativeClassPtr, 100663353);
			Size.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Size_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Size>.NativeClassPtr, 100663354);
			Size.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Size>.NativeClassPtr, 100663355);
			Size.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Size>.NativeClassPtr, 100663356);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003644 File Offset: 0x00001844
		[CallerCount(0)]
		public unsafe static bool operator ==(Size sz1, Size sz2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sz1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sz2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Size.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Size_Size_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003690 File Offset: 0x00001890
		public unsafe int Width
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Size.NativeMethodInfoPtr_get_Width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000036C0 File Offset: 0x000018C0
		public unsafe int Height
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Size.NativeMethodInfoPtr_get_Height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000036F0 File Offset: 0x000018F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227233, XrefRangeEnd = 1227236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Size.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003734 File Offset: 0x00001934
		[CallerCount(0)]
		public unsafe bool Equals(Size other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Size.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Size_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003774 File Offset: 0x00001974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227236, XrefRangeEnd = 1227239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Size.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000037A4 File Offset: 0x000019A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227239, XrefRangeEnd = 1227262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Size.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002167 File Offset: 0x00000367
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Size>.NativeClassPtr, ref this));
		}

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Size_Size_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Int32_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Int32_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Size_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400010C RID: 268
		[FieldOffset(0)]
		public int width;

		// Token: 0x0400010D RID: 269
		[FieldOffset(4)]
		public int height;
	}
}
