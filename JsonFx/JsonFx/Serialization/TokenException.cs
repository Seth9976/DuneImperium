using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace JsonFx.Serialization
{
	// Token: 0x0200000F RID: 15
	public class TokenException : SerializationException
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00005D64 File Offset: 0x00003F64
		// Note: this type is marked as 'beforefieldinit'.
		static TokenException()
		{
			Il2CppClassPointerStore<TokenException>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "TokenException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenException>.NativeClassPtr);
			TokenException.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenException>.NativeClassPtr, "token");
			TokenException.NativeMethodInfoPtr__ctor_Public_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenException>.NativeClassPtr, 100663360);
			TokenException.NativeMethodInfoPtr__ctor_Public_Void_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenException>.NativeClassPtr, 100663361);
			TokenException.NativeMethodInfoPtr__ctor_Public_Void_Token_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenException>.NativeClassPtr, 100663362);
			TokenException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenException>.NativeClassPtr, 100663363);
			TokenException.NativeMethodInfoPtr_get_Token_Public_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenException>.NativeClassPtr, 100663364);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005E0C File Offset: 0x0000400C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189802, XrefRangeEnd = 1189804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenException(Token token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenException.NativeMethodInfoPtr__ctor_Public_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005E5C File Offset: 0x0000405C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1189806, RefRangeEnd = 1189812, XrefRangeStart = 1189804, XrefRangeEnd = 1189806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenException(Token token, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenException.NativeMethodInfoPtr__ctor_Public_Void_Token_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005EC0 File Offset: 0x000040C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189812, XrefRangeEnd = 1189814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenException(Token token, string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenException.NativeMethodInfoPtr__ctor_Public_Void_Token_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005F34 File Offset: 0x00004134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005F98 File Offset: 0x00004198
		public unsafe Token Token
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenException.NativeMethodInfoPtr_get_Token_Public_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Token(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000023F5 File Offset: 0x000005F5
		public TokenException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005FD0 File Offset: 0x000041D0
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000023FE File Offset: 0x000005FE
		public Token token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenException.NativeFieldInfoPtr_token);
				return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenException.NativeFieldInfoPtr_token), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_token;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_String_Exception_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_Token_0;
	}
}
