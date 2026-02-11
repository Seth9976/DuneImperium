using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace ImaginationOverflow.UniversalDeepLink.Storage
{
	// Token: 0x02000005 RID: 5
	public static class Json : Object
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002E28 File Offset: 0x00001028
		// Note: this type is marked as 'beforefieldinit'.
		static Json()
		{
			Il2CppClassPointerStore<Json>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLink.Storage", "Json");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json>.NativeClassPtr);
			Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100663307);
			Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100663308);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002E80 File Offset: 0x00001080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240452, XrefRangeEnd = 1240453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Deserialize(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002EC4 File Offset: 0x000010C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Serialize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020E7 File Offset: 0x000002E7
		public Json(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

		// Token: 0x0200001A RID: 26
		public sealed class Parser : Object
		{
			// Token: 0x06000138 RID: 312 RVA: 0x00006C84 File Offset: 0x00004E84
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<Json.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr);
				Json.Parser.NativeFieldInfoPtr_WORD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "WORD_BREAK");
				Json.Parser.NativeFieldInfoPtr_HEX_DIGIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "HEX_DIGIT");
				Json.Parser.NativeFieldInfoPtr_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "json");
				Json.Parser.NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663309);
				Json.Parser.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663310);
				Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663311);
				Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663312);
				Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663313);
				Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663314);
				Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663315);
				Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663316);
				Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663317);
				Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663318);
				Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663319);
				Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663320);
				Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663321);
				Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663322);
				Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663323);
				Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663324);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00006E2C File Offset: 0x0000502C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240081, XrefRangeEnd = 1240086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsWordBreak(char c)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00006E6C File Offset: 0x0000506C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240089, RefRangeEnd = 1240090, XrefRangeStart = 1240086, XrefRangeEnd = 1240089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsHexDigit(char c)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00006EAC File Offset: 0x000050AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240090, XrefRangeEnd = 1240096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Parser(string jsonString)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00006EF8 File Offset: 0x000050F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240113, RefRangeEnd = 1240114, XrefRangeStart = 1240096, XrefRangeEnd = 1240113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Object Parse(string jsonString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00006F3C File Offset: 0x0000513C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240114, XrefRangeEnd = 1240117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00006F70 File Offset: 0x00005170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240117, XrefRangeEnd = 1240132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, Object> ParseObject()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00006FB0 File Offset: 0x000051B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240132, XrefRangeEnd = 1240144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<Object> ParseArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00006FF0 File Offset: 0x000051F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240144, XrefRangeEnd = 1240146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00007030 File Offset: 0x00005230
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1240162, RefRangeEnd = 1240167, XrefRangeStart = 1240146, XrefRangeEnd = 1240162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseByToken(Json.Parser.TOKEN token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000142 RID: 322 RVA: 0x0000707C File Offset: 0x0000527C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1240197, RefRangeEnd = 1240199, XrefRangeStart = 1240167, XrefRangeEnd = 1240197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ParseString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000143 RID: 323 RVA: 0x000070B4 File Offset: 0x000052B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240199, XrefRangeEnd = 1240212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseNumber()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06000144 RID: 324 RVA: 0x000070F4 File Offset: 0x000052F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240212, XrefRangeEnd = 1240220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EatWhitespace()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000145 RID: 325 RVA: 0x00007128 File Offset: 0x00005328
			public unsafe char PeekChar
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1240225, RefRangeEnd = 1240226, XrefRangeStart = 1240220, XrefRangeEnd = 1240225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00007164 File Offset: 0x00005364
			public unsafe char NextChar
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1240231, RefRangeEnd = 1240234, XrefRangeStart = 1240226, XrefRangeEnd = 1240231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000147 RID: 327 RVA: 0x000071A0 File Offset: 0x000053A0
			public unsafe string NextWord
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1240256, RefRangeEnd = 1240257, XrefRangeStart = 1240234, XrefRangeEnd = 1240256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000148 RID: 328 RVA: 0x000071D8 File Offset: 0x000053D8
			public unsafe Json.Parser.TOKEN NextToken
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 1240269, RefRangeEnd = 1240280, XrefRangeStart = 1240257, XrefRangeEnd = 1240269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00002716 File Offset: 0x00000916
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x0600014A RID: 330 RVA: 0x00007214 File Offset: 0x00005414
			// (set) Token: 0x0600014B RID: 331 RVA: 0x0000271F File Offset: 0x0000091F
			public unsafe static string WORD_BREAK
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Json.Parser.NativeFieldInfoPtr_WORD_BREAK, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Json.Parser.NativeFieldInfoPtr_WORD_BREAK, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600014C RID: 332 RVA: 0x00007234 File Offset: 0x00005434
			// (set) Token: 0x0600014D RID: 333 RVA: 0x00002731 File Offset: 0x00000931
			public unsafe static string HEX_DIGIT
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Json.Parser.NativeFieldInfoPtr_HEX_DIGIT, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Json.Parser.NativeFieldInfoPtr_HEX_DIGIT, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600014E RID: 334 RVA: 0x00007254 File Offset: 0x00005454
			// (set) Token: 0x0600014F RID: 335 RVA: 0x00002743 File Offset: 0x00000943
			public unsafe StringReader json
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Parser.NativeFieldInfoPtr_json);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Parser.NativeFieldInfoPtr_json), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D4 RID: 212
			private static readonly IntPtr NativeFieldInfoPtr_WORD_BREAK;

			// Token: 0x040000D5 RID: 213
			private static readonly IntPtr NativeFieldInfoPtr_HEX_DIGIT;

			// Token: 0x040000D6 RID: 214
			private static readonly IntPtr NativeFieldInfoPtr_json;

			// Token: 0x040000D7 RID: 215
			private static readonly IntPtr NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0;

			// Token: 0x040000D8 RID: 216
			private static readonly IntPtr NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0;

			// Token: 0x040000D9 RID: 217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

			// Token: 0x040000DA RID: 218
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_String_0;

			// Token: 0x040000DB RID: 219
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040000DC RID: 220
			private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0;

			// Token: 0x040000DD RID: 221
			private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0;

			// Token: 0x040000DE RID: 222
			private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Private_Object_0;

			// Token: 0x040000DF RID: 223
			private static readonly IntPtr NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0;

			// Token: 0x040000E0 RID: 224
			private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_String_0;

			// Token: 0x040000E1 RID: 225
			private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Object_0;

			// Token: 0x040000E2 RID: 226
			private static readonly IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

			// Token: 0x040000E3 RID: 227
			private static readonly IntPtr NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0;

			// Token: 0x040000E4 RID: 228
			private static readonly IntPtr NativeMethodInfoPtr_get_NextChar_Private_get_Char_0;

			// Token: 0x040000E5 RID: 229
			private static readonly IntPtr NativeMethodInfoPtr_get_NextWord_Private_get_String_0;

			// Token: 0x040000E6 RID: 230
			private static readonly IntPtr NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0;

			// Token: 0x02000024 RID: 36
			public enum TOKEN
			{
				// Token: 0x04000112 RID: 274
				NONE,
				// Token: 0x04000113 RID: 275
				CURLY_OPEN,
				// Token: 0x04000114 RID: 276
				CURLY_CLOSE,
				// Token: 0x04000115 RID: 277
				SQUARED_OPEN,
				// Token: 0x04000116 RID: 278
				SQUARED_CLOSE,
				// Token: 0x04000117 RID: 279
				COLON,
				// Token: 0x04000118 RID: 280
				COMMA,
				// Token: 0x04000119 RID: 281
				STRING,
				// Token: 0x0400011A RID: 282
				NUMBER,
				// Token: 0x0400011B RID: 283
				TRUE,
				// Token: 0x0400011C RID: 284
				FALSE,
				// Token: 0x0400011D RID: 285
				NULL
			}
		}

		// Token: 0x0200001B RID: 27
		public sealed class Serializer : Object
		{
			// Token: 0x06000150 RID: 336 RVA: 0x00007284 File Offset: 0x00005484
			// Note: this type is marked as 'beforefieldinit'.
			static Serializer()
			{
				Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Serializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr);
				Json.Serializer.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, "builder");
				Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663325);
				Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663326);
				Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663327);
				Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663328);
				Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663329);
				Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663330);
				Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663331);
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00007350 File Offset: 0x00005550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240280, XrefRangeEnd = 1240286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Serializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000152 RID: 338 RVA: 0x0000738C File Offset: 0x0000558C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240286, XrefRangeEnd = 1240297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Serialize(Object obj)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000153 RID: 339 RVA: 0x000073C8 File Offset: 0x000055C8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1240328, RefRangeEnd = 1240332, XrefRangeStart = 1240297, XrefRangeEnd = 1240328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000154 RID: 340 RVA: 0x0000740C File Offset: 0x0000560C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240360, RefRangeEnd = 1240361, XrefRangeStart = 1240332, XrefRangeEnd = 1240360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeObject(IDictionary obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000155 RID: 341 RVA: 0x00007450 File Offset: 0x00005650
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240375, RefRangeEnd = 1240376, XrefRangeStart = 1240361, XrefRangeEnd = 1240375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeArray(IList anArray)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(anArray);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000156 RID: 342 RVA: 0x00007494 File Offset: 0x00005694
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1240421, RefRangeEnd = 1240425, XrefRangeStart = 1240376, XrefRangeEnd = 1240421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeString(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000157 RID: 343 RVA: 0x000074D8 File Offset: 0x000056D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240451, RefRangeEnd = 1240452, XrefRangeStart = 1240425, XrefRangeEnd = 1240451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeOther(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00002762 File Offset: 0x00000962
			public Serializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000159 RID: 345 RVA: 0x0000751C File Offset: 0x0000571C
			// (set) Token: 0x0600015A RID: 346 RVA: 0x0000276B File Offset: 0x0000096B
			public unsafe StringBuilder builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Serializer.NativeFieldInfoPtr_builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Serializer.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeFieldInfoPtr_builder;

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

			// Token: 0x040000EA RID: 234
			private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0;

			// Token: 0x040000EB RID: 235
			private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0;

			// Token: 0x040000EC RID: 236
			private static readonly IntPtr NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0;

			// Token: 0x040000ED RID: 237
			private static readonly IntPtr NativeMethodInfoPtr_SerializeString_Private_Void_String_0;

			// Token: 0x040000EE RID: 238
			private static readonly IntPtr NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0;
		}
	}
}
