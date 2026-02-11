using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using JsonFx.Serialization;

namespace JsonFx.Model
{
	// Token: 0x02000020 RID: 32
	public static class ModelGrammar : Object
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00009140 File Offset: 0x00007340
		// Note: this type is marked as 'beforefieldinit'.
		static ModelGrammar()
		{
			Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Model", "ModelGrammar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr);
			ModelGrammar.NativeFieldInfoPtr_TokenNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenNone");
			ModelGrammar.NativeFieldInfoPtr_TokenArrayEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenArrayEnd");
			ModelGrammar.NativeFieldInfoPtr_TokenObjectEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenObjectEnd");
			ModelGrammar.NativeFieldInfoPtr_TokenNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenNull");
			ModelGrammar.NativeFieldInfoPtr_TokenFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenFalse");
			ModelGrammar.NativeFieldInfoPtr_TokenTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenTrue");
			ModelGrammar.NativeFieldInfoPtr_TokenArrayBeginUnnamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenArrayBeginUnnamed");
			ModelGrammar.NativeFieldInfoPtr_TokenObjectBeginUnnamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenObjectBeginUnnamed");
			ModelGrammar.NativeFieldInfoPtr_TokenNaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenNaN");
			ModelGrammar.NativeFieldInfoPtr_TokenPositiveInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenPositiveInfinity");
			ModelGrammar.NativeFieldInfoPtr_TokenNegativeInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, "TokenNegativeInfinity");
			ModelGrammar.NativeMethodInfoPtr_TokenArrayBegin_Public_Static_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, 100663454);
			ModelGrammar.NativeMethodInfoPtr_TokenObjectBegin_Public_Static_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, 100663455);
			ModelGrammar.NativeMethodInfoPtr_TokenProperty_Public_Static_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, 100663456);
			ModelGrammar.NativeMethodInfoPtr_TokenProperty_Public_Static_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, 100663457);
			ModelGrammar.NativeMethodInfoPtr_TokenPrimitive_Public_Static_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelGrammar>.NativeClassPtr, 100663458);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000092B0 File Offset: 0x000074B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191267, XrefRangeEnd = 1191269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token TokenArrayBegin(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelGrammar.NativeMethodInfoPtr_TokenArrayBegin_Public_Static_Token_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Token(intPtr);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000092EC File Offset: 0x000074EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1191271, RefRangeEnd = 1191273, XrefRangeStart = 1191269, XrefRangeEnd = 1191271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token TokenObjectBegin(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelGrammar.NativeMethodInfoPtr_TokenObjectBegin_Public_Static_Token_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Token(intPtr);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00009328 File Offset: 0x00007528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191273, XrefRangeEnd = 1191276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token TokenProperty(Object localName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelGrammar.NativeMethodInfoPtr_TokenProperty_Public_Static_Token_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Token(intPtr);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009364 File Offset: 0x00007564
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1191278, RefRangeEnd = 1191284, XrefRangeStart = 1191276, XrefRangeEnd = 1191278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token TokenProperty(string localName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelGrammar.NativeMethodInfoPtr_TokenProperty_Public_Static_Token_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Token(intPtr);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000093A0 File Offset: 0x000075A0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1191288, RefRangeEnd = 1191302, XrefRangeStart = 1191284, XrefRangeEnd = 1191288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token TokenPrimitive(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelGrammar.NativeMethodInfoPtr_TokenPrimitive_Public_Static_Token_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Token(intPtr);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000029BF File Offset: 0x00000BBF
		public ModelGrammar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000093DC File Offset: 0x000075DC
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000029C8 File Offset: 0x00000BC8
		public unsafe static Token TokenNone
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenNone, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenNone, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00009418 File Offset: 0x00007618
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000029DF File Offset: 0x00000BDF
		public unsafe static Token TokenArrayEnd
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenArrayEnd, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenArrayEnd, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00009454 File Offset: 0x00007654
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000029F6 File Offset: 0x00000BF6
		public unsafe static Token TokenObjectEnd
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenObjectEnd, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenObjectEnd, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00009490 File Offset: 0x00007690
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002A0D File Offset: 0x00000C0D
		public unsafe static Token TokenNull
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenNull, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenNull, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000094CC File Offset: 0x000076CC
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002A24 File Offset: 0x00000C24
		public unsafe static Token TokenFalse
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenFalse, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenFalse, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00009508 File Offset: 0x00007708
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002A3B File Offset: 0x00000C3B
		public unsafe static Token TokenTrue
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenTrue, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenTrue, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00009544 File Offset: 0x00007744
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002A52 File Offset: 0x00000C52
		public unsafe static Token TokenArrayBeginUnnamed
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenArrayBeginUnnamed, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenArrayBeginUnnamed, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00009580 File Offset: 0x00007780
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002A69 File Offset: 0x00000C69
		public unsafe static Token TokenObjectBeginUnnamed
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenObjectBeginUnnamed, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenObjectBeginUnnamed, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000095BC File Offset: 0x000077BC
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002A80 File Offset: 0x00000C80
		public unsafe static Token TokenNaN
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenNaN, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenNaN, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000095F8 File Offset: 0x000077F8
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002A97 File Offset: 0x00000C97
		public unsafe static Token TokenPositiveInfinity
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenPositiveInfinity, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenPositiveInfinity, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00009634 File Offset: 0x00007834
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002AAE File Offset: 0x00000CAE
		public unsafe static Token TokenNegativeInfinity
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ModelGrammar.NativeFieldInfoPtr_TokenNegativeInfinity, intPtr);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelGrammar.NativeFieldInfoPtr_TokenNegativeInfinity, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_TokenNone;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_TokenArrayEnd;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_TokenObjectEnd;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_TokenNull;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_TokenFalse;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_TokenTrue;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_TokenArrayBeginUnnamed;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_TokenObjectBeginUnnamed;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_TokenNaN;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_TokenPositiveInfinity;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_TokenNegativeInfinity;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_TokenArrayBegin_Public_Static_Token_String_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_TokenObjectBegin_Public_Static_Token_String_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_TokenProperty_Public_Static_Token_Object_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_TokenProperty_Public_Static_Token_String_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_TokenPrimitive_Public_Static_Token_Object_0;
	}
}
