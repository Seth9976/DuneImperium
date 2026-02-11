using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000179 RID: 377
	[StructLayout(2)]
	public struct Spacing
	{
		// Token: 0x06001BF4 RID: 7156 RVA: 0x0007F70C File Offset: 0x0007D90C
		// Note: this type is marked as 'beforefieldinit'.
		static Spacing()
		{
			Il2CppClassPointerStore<Spacing>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Spacing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spacing>.NativeClassPtr);
			Spacing.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spacing>.NativeClassPtr, "left");
			Spacing.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spacing>.NativeClassPtr, "top");
			Spacing.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spacing>.NativeClassPtr, "right");
			Spacing.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spacing>.NativeClassPtr, "bottom");
			Spacing.NativeMethodInfoPtr_get_horizontal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spacing>.NativeClassPtr, 100667352);
			Spacing.NativeMethodInfoPtr_get_vertical_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spacing>.NativeClassPtr, 100667353);
			Spacing.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spacing>.NativeClassPtr, 100667354);
			Spacing.NativeMethodInfoPtr_op_Subtraction_Public_Static_Rect_Rect_Spacing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spacing>.NativeClassPtr, 100667355);
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0007F7DC File Offset: 0x0007D9DC
		public unsafe float horizontal
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spacing.NativeMethodInfoPtr_get_horizontal_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x0007F80C File Offset: 0x0007DA0C
		public unsafe float vertical
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spacing.NativeMethodInfoPtr_get_vertical_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0007F83C File Offset: 0x0007DA3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spacing(float left, float top, float right, float bottom)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spacing.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0007F898 File Offset: 0x0007DA98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323508, RefRangeEnd = 323511, XrefRangeStart = 323508, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect operator -(Rect r, Spacing a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spacing.NativeMethodInfoPtr_op_Subtraction_Public_Static_Rect_Rect_Spacing_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0000CA24 File Offset: 0x0000AC24
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spacing>.NativeClassPtr, ref this));
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0007F8E4 File Offset: 0x0007DAE4
		public static Rect operator +(Rect r, Spacing a)
		{
			r.x -= a.left;
			r.y -= a.top;
			r.width += a.horizontal;
			r.height += a.vertical;
			return r;
		}

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Single_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Single_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Rect_Rect_Spacing_0;

		// Token: 0x04001353 RID: 4947
		[FieldOffset(0)]
		public float left;

		// Token: 0x04001354 RID: 4948
		[FieldOffset(4)]
		public float top;

		// Token: 0x04001355 RID: 4949
		[FieldOffset(8)]
		public float right;

		// Token: 0x04001356 RID: 4950
		[FieldOffset(12)]
		public float bottom;
	}
}
