using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using JsonFx.Model;

namespace JsonFx.Serialization
{
	// Token: 0x02000011 RID: 17
	public sealed class Token : ValueType
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000061CC File Offset: 0x000043CC
		// Note: this type is marked as 'beforefieldinit'.
		static Token()
		{
			Il2CppClassPointerStore<Token>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "Token");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Token>.NativeClassPtr);
			Token.NativeFieldInfoPtr_FullDateTimeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "FullDateTimeFormat");
			Token.NativeFieldInfoPtr_TokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "TokenType");
			Token.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "Name");
			Token.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "Value");
			Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663369);
			Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663370);
			Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663371);
			Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663372);
			Token.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663373);
			Token.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663374);
			Token.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663375);
			Token.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663376);
			Token.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Token_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663377);
			Token.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Token_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663378);
			Token.NativeMethodInfoPtr_ValueAsString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663379);
			Token.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100663380);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000633C File Offset: 0x0000453C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189816, XrefRangeEnd = 1189820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token(ModelTokenType tokenType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Token>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokenType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006388 File Offset: 0x00004588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189820, XrefRangeEnd = 1189824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token(ModelTokenType tokenType, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Token>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000063E8 File Offset: 0x000045E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189824, XrefRangeEnd = 1189826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token(ModelTokenType tokenType, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Token>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006448 File Offset: 0x00004648
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 366005, RefRangeEnd = 366010, XrefRangeStart = 366005, XrefRangeEnd = 366010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token(ModelTokenType tokenType, string name, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Token>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000064B8 File Offset: 0x000046B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189826, XrefRangeEnd = 1189848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000064F4 File Offset: 0x000046F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189848, XrefRangeEnd = 1189852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006548 File Offset: 0x00004748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189852, XrefRangeEnd = 1189853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Token that)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(that));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Token_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000065A0 File Offset: 0x000047A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189853, XrefRangeEnd = 1189854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000065E4 File Offset: 0x000047E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189854, XrefRangeEnd = 1189855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Token a, Token b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Token_Token_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006644 File Offset: 0x00004844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189855, XrefRangeEnd = 1189856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Token a, Token b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Token_Token_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000066A4 File Offset: 0x000048A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189857, RefRangeEnd = 1189859, XrefRangeStart = 1189856, XrefRangeEnd = 1189857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ValueAsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_ValueAsString_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000066E0 File Offset: 0x000048E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1189892, RefRangeEnd = 1189898, XrefRangeStart = 1189859, XrefRangeEnd = 1189892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002435 File Offset: 0x00000635
		public Token(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000243E File Offset: 0x0000063E
		public Token()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Token>.NativeClassPtr))
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000671C File Offset: 0x0000491C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002450 File Offset: 0x00000650
		public unsafe static string FullDateTimeFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Token.NativeFieldInfoPtr_FullDateTimeFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Token.NativeFieldInfoPtr_FullDateTimeFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000673C File Offset: 0x0000493C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002462 File Offset: 0x00000662
		public unsafe ModelTokenType TokenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_TokenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_TokenType)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00006764 File Offset: 0x00004964
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000247D File Offset: 0x0000067D
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000678C File Offset: 0x0000498C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe Object Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_FullDateTimeFormat;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_TokenType;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_Object_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelTokenType_String_Object_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Token_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Token_Token_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Token_Token_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_ValueAsString_Public_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_0;
	}
}
