using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F7 RID: 247
	[StructLayout(2)]
	public struct Color32
	{
		// Token: 0x06001373 RID: 4979 RVA: 0x000615EC File Offset: 0x0005F7EC
		// Note: this type is marked as 'beforefieldinit'.
		static Color32()
		{
			Il2CppClassPointerStore<Color32>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Color32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color32>.NativeClassPtr);
			Color32.NativeFieldInfoPtr_rgba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "rgba");
			Color32.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "r");
			Color32.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "g");
			Color32.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "b");
			Color32.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "a");
			Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100666045);
			Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100666046);
			Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100666047);
			Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100666048);
			Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100666049);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x000616E4 File Offset: 0x0005F8E4
		[CallerCount(0)]
		public unsafe Color32(byte r, byte g, byte b, byte a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00061740 File Offset: 0x0005F940
		[CallerCount(104)]
		[CachedScanResults(RefRangeStart = 658110, RefRangeEnd = 658214, XrefRangeStart = 658102, XrefRangeEnd = 658110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Color32(Color c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00061780 File Offset: 0x0005F980
		[CallerCount(0)]
		public unsafe static implicit operator Color(Color32 c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000617C0 File Offset: 0x0005F9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658214, XrefRangeEnd = 658215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000617EC File Offset: 0x0005F9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658215, XrefRangeEnd = 658247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00008025 File Offset: 0x00006225
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color32>.NativeClassPtr, ref this));
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0006183C File Offset: 0x0005FA3C
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000618C0 File Offset: 0x0005FAC0
		public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
		{
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x17000411 RID: 1041
		public byte this[int index]
		{
			get
			{
				byte b;
				switch (index)
				{
				case 0:
					b = this.r;
					break;
				case 1:
					b = this.g;
					break;
				case 2:
					b = this.b;
					break;
				case 3:
					b = this.a;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
				}
				return b;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.r = value;
					break;
				case 1:
					this.g = value;
					break;
				case 2:
					this.b = value;
					break;
				case 3:
					this.a = value;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
				}
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00061A14 File Offset: 0x0005FC14
		public bool InternalEquals(Color32 other)
		{
			return this.rgba == other.rgba;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00061A34 File Offset: 0x0005FC34
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_rgba;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001283 RID: 4739
		[FieldOffset(0)]
		public int rgba;

		// Token: 0x04001284 RID: 4740
		[FieldOffset(0)]
		public byte r;

		// Token: 0x04001285 RID: 4741
		[FieldOffset(1)]
		public byte g;

		// Token: 0x04001286 RID: 4742
		[FieldOffset(2)]
		public byte b;

		// Token: 0x04001287 RID: 4743
		[FieldOffset(3)]
		public byte a;
	}
}
