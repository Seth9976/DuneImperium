using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x0200010B RID: 267
	[StructLayout(2)]
	public struct Vec3
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x0005FFB4 File Offset: 0x0005E1B4
		// Note: this type is marked as 'beforefieldinit'.
		static Vec3()
		{
			Il2CppClassPointerStore<Vec3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "Vec3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vec3>.NativeClassPtr);
			Vec3.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3>.NativeClassPtr, "Zero");
			Vec3.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3>.NativeClassPtr, "X");
			Vec3.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3>.NativeClassPtr, "Y");
			Vec3.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3>.NativeClassPtr, "Z");
			Vec3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665891);
			Vec3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665892);
			Vec3.NativeMethodInfoPtr_Sub_Public_Static_Void_byref_Vec3_byref_Vec3_byref_Vec3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665893);
			Vec3.NativeMethodInfoPtr_Neg_Public_Static_Void_byref_Vec3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665894);
			Vec3.NativeMethodInfoPtr_Dot_Public_Static_Void_byref_Vec3_byref_Vec3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665895);
			Vec3.NativeMethodInfoPtr_Normalize_Public_Static_Void_byref_Vec3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665896);
			Vec3.NativeMethodInfoPtr_LongAxis_Public_Static_Int32_byref_Vec3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665897);
			Vec3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3>.NativeClassPtr, 100665898);
		}

		// Token: 0x1700083F RID: 2111
		public unsafe float this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00060154 File Offset: 0x0005E354
		[CallerCount(0)]
		public unsafe static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_Sub_Public_Static_Void_byref_Vec3_byref_Vec3_byref_Vec3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000601A4 File Offset: 0x0005E3A4
		[CallerCount(0)]
		public unsafe static void Neg(ref Vec3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_Neg_Public_Static_Void_byref_Vec3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000601D8 File Offset: 0x0005E3D8
		[CallerCount(0)]
		public unsafe static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &u;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_Dot_Public_Static_Void_byref_Vec3_byref_Vec3_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00060228 File Offset: 0x0005E428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623293, XrefRangeEnd = 623298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Normalize(ref Vec3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_Normalize_Public_Static_Void_byref_Vec3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0006025C File Offset: 0x0005E45C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 623306, RefRangeEnd = 623308, XrefRangeStart = 623298, XrefRangeEnd = 623306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LongAxis(ref Vec3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_LongAxis_Public_Static_Int32_byref_Vec3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0006029C File Offset: 0x0005E49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623308, XrefRangeEnd = 623318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0000CF37 File Offset: 0x0000B137
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vec3>.NativeClassPtr, ref this));
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x000602C8 File Offset: 0x0005E4C8
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x0000CF49 File Offset: 0x0000B149
		public unsafe static Vec3 Zero
		{
			get
			{
				Vec3 vec;
				IL2CPP.il2cpp_field_static_get_value(Vec3.NativeFieldInfoPtr_Zero, (void*)(&vec));
				return vec;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vec3.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr_Z;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_Sub_Public_Static_Void_byref_Vec3_byref_Vec3_byref_Vec3_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_Neg_Public_Static_Void_byref_Vec3_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Void_byref_Vec3_byref_Vec3_byref_Single_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Void_byref_Vec3_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_LongAxis_Public_Static_Int32_byref_Vec3_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400104B RID: 4171
		[FieldOffset(0)]
		public float X;

		// Token: 0x0400104C RID: 4172
		[FieldOffset(4)]
		public float Y;

		// Token: 0x0400104D RID: 4173
		[FieldOffset(8)]
		public float Z;
	}
}
