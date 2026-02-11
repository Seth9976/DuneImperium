using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000029 RID: 41
	[StructLayout(2)]
	public struct Token
	{
		// Token: 0x06000295 RID: 661 RVA: 0x0000ED00 File Offset: 0x0000CF00
		// Note: this type is marked as 'beforefieldinit'.
		static Token()
		{
			Il2CppClassPointerStore<Token>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "Token");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Token>.NativeClassPtr);
			Token.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "Empty");
			Token.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "type");
			Token.NativeFieldInfoPtr__StartPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "<StartPosition>k__BackingField");
			Token.NativeFieldInfoPtr__EndPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "<EndPosition>k__BackingField");
			Token.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663711);
			Token.NativeMethodInfoPtr_get_StartPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663712);
			Token.NativeMethodInfoPtr_set_StartPosition_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663713);
			Token.NativeMethodInfoPtr_get_EndPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663714);
			Token.NativeMethodInfoPtr_set_EndPosition_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663715);
			Token.NativeMethodInfoPtr_get_Kind_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663716);
			Token.NativeMethodInfoPtr_op_Implicit_Public_Static_Type_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663717);
			Token.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663718);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000EE20 File Offset: 0x0000D020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174620, RefRangeEnd = 1174621, XrefRangeStart = 1174617, XrefRangeEnd = 1174620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token(Token.Type type, int startPosition, int endPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000EE70 File Offset: 0x0000D070
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		public unsafe int StartPosition
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_get_StartPosition_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_set_StartPosition_Private_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0000EF04 File Offset: 0x0000D104
		public unsafe int EndPosition
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_get_EndPosition_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_set_EndPosition_Private_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000EF38 File Offset: 0x0000D138
		public unsafe Token.Type Kind
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_get_Kind_Public_get_Type_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000EF68 File Offset: 0x0000D168
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Token.Type(Token token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_op_Implicit_Public_Static_Type_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174621, XrefRangeEnd = 1174624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002F61 File Offset: 0x00001161
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00002F73 File Offset: 0x00001173
		public unsafe static Token Empty
		{
			get
			{
				Token token;
				IL2CPP.il2cpp_field_static_get_value(Token.NativeFieldInfoPtr_Empty, (void*)(&token));
				return token;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Token.NativeFieldInfoPtr_Empty, (void*)(&value));
			}
		}

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr__StartPosition_k__BackingField;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr__EndPosition_k__BackingField;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_Int32_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_get_StartPosition_Public_get_Int32_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_set_StartPosition_Private_set_Void_Int32_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_EndPosition_Public_get_Int32_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_set_EndPosition_Private_set_Void_Int32_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_Type_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Type_Token_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001EF RID: 495
		[FieldOffset(0)]
		public readonly Token.Type type;

		// Token: 0x040001F0 RID: 496
		[FieldOffset(4)]
		public int _StartPosition_k__BackingField;

		// Token: 0x040001F1 RID: 497
		[FieldOffset(8)]
		public int _EndPosition_k__BackingField;

		// Token: 0x0200005A RID: 90
		public enum Type
		{
			// Token: 0x04000362 RID: 866
			Error,
			// Token: 0x04000363 RID: 867
			End,
			// Token: 0x04000364 RID: 868
			Token,
			// Token: 0x04000365 RID: 869
			QuotedString,
			// Token: 0x04000366 RID: 870
			SeparatorEqual,
			// Token: 0x04000367 RID: 871
			SeparatorSemicolon,
			// Token: 0x04000368 RID: 872
			SeparatorSlash,
			// Token: 0x04000369 RID: 873
			SeparatorDash,
			// Token: 0x0400036A RID: 874
			SeparatorComma,
			// Token: 0x0400036B RID: 875
			OpenParens
		}
	}
}
