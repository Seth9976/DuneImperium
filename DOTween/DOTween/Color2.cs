using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000004 RID: 4
	[StructLayout(2)]
	public struct Color2
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00005330 File Offset: 0x00003530
		// Note: this type is marked as 'beforefieldinit'.
		static Color2()
		{
			Il2CppClassPointerStore<Color2>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "Color2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color2>.NativeClassPtr);
			Color2.NativeFieldInfoPtr_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color2>.NativeClassPtr, "ca");
			Color2.NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color2>.NativeClassPtr, "cb");
			Color2.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color2>.NativeClassPtr, 100663297);
			Color2.NativeMethodInfoPtr_op_Addition_Public_Static_Color2_Color2_Color2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color2>.NativeClassPtr, 100663298);
			Color2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Color2_Color2_Color2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color2>.NativeClassPtr, 100663299);
			Color2.NativeMethodInfoPtr_op_Multiply_Public_Static_Color2_Color2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color2>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000053D8 File Offset: 0x000035D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599697, RefRangeEnd = 599699, XrefRangeStart = 599697, XrefRangeEnd = 599699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color2(Color ca, Color cb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ca;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color2.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00005418 File Offset: 0x00003618
		[CallerCount(0)]
		public unsafe static Color2 operator +(Color2 c1, Color2 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color2.NativeMethodInfoPtr_op_Addition_Public_Static_Color2_Color2_Color2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00005464 File Offset: 0x00003664
		[CallerCount(0)]
		public unsafe static Color2 operator -(Color2 c1, Color2 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Color2_Color2_Color2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000054B0 File Offset: 0x000036B0
		[CallerCount(0)]
		public unsafe static Color2 operator *(Color2 c1, float f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color2.NativeMethodInfoPtr_op_Multiply_Public_Static_Color2_Color2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color2>.NativeClassPtr, ref this));
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_ca;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_cb;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Color2_Color2_Color2_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Color2_Color2_Color2_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color2_Color2_Single_0;

		// Token: 0x04000012 RID: 18
		[FieldOffset(0)]
		public Color ca;

		// Token: 0x04000013 RID: 19
		[FieldOffset(16)]
		public Color cb;
	}
}
