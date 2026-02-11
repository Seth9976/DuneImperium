using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200002F RID: 47
	public static class Parser : Object
	{
		// Token: 0x060002FD RID: 765 RVA: 0x000030B5 File Offset: 0x000012B5
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000030DA File Offset: 0x000012DA
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200005C RID: 92
		public static class Token : Object
		{
			// Token: 0x060004DE RID: 1246 RVA: 0x0001718C File Offset: 0x0001538C
			// Note: this type is marked as 'beforefieldinit'.
			static Token()
			{
				Il2CppClassPointerStore<Parser.Token>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "Token");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.Token>.NativeClassPtr);
				Parser.Token.NativeMethodInfoPtr_Check_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.Token>.NativeClassPtr, 100663786);
				Parser.Token.NativeMethodInfoPtr_TryCheck_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.Token>.NativeClassPtr, 100663787);
			}

			// Token: 0x060004DF RID: 1247 RVA: 0x000171E0 File Offset: 0x000153E0
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1175346, RefRangeEnd = 1175354, XrefRangeStart = 1175341, XrefRangeEnd = 1175346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Check(string s)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.Token.NativeMethodInfoPtr_Check_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x00017218 File Offset: 0x00015418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175354, XrefRangeEnd = 1175358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryCheck(string s)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.Token.NativeMethodInfoPtr_TryCheck_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x00004117 File Offset: 0x00002317
			public Token(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000370 RID: 880
			private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Static_Void_String_0;

			// Token: 0x04000371 RID: 881
			private static readonly IntPtr NativeMethodInfoPtr_TryCheck_Public_Static_Boolean_String_0;
		}

		// Token: 0x0200005D RID: 93
		public static class DateTime : Object
		{
			// Token: 0x060004E2 RID: 1250 RVA: 0x0001725C File Offset: 0x0001545C
			// Note: this type is marked as 'beforefieldinit'.
			static DateTime()
			{
				Il2CppClassPointerStore<Parser.DateTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "DateTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.DateTime>.NativeClassPtr);
				Parser.DateTime.NativeFieldInfoPtr_ToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.DateTime>.NativeClassPtr, "ToString");
				Parser.DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.DateTime>.NativeClassPtr, 100663788);
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x000172B0 File Offset: 0x000154B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175370, XrefRangeEnd = 1175388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out DateTimeOffset result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x00004120 File Offset: 0x00002320
			public DateTime(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00017300 File Offset: 0x00015500
			// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004129 File Offset: 0x00002329
			public new unsafe static Func<Object, string> ToString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Parser.DateTime.NativeFieldInfoPtr_ToString, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Parser.DateTime.NativeFieldInfoPtr_ToString, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000372 RID: 882
			private static readonly IntPtr NativeFieldInfoPtr_ToString;

			// Token: 0x04000373 RID: 883
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTimeOffset_0;

			// Token: 0x02000066 RID: 102
			[ObfuscatedName("System.Net.Http.Headers.Parser+DateTime+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06000500 RID: 1280 RVA: 0x00017614 File Offset: 0x00015814
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<Parser.DateTime.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser.DateTime>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.DateTime.__c>.NativeClassPtr);
					Parser.DateTime.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.DateTime.__c>.NativeClassPtr, "<>9");
					Parser.DateTime.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.DateTime.__c>.NativeClassPtr, 100663791);
					Parser.DateTime.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.DateTime.__c>.NativeClassPtr, 100663792);
				}

				// Token: 0x06000501 RID: 1281 RVA: 0x0001767C File Offset: 0x0001587C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser.DateTime.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.DateTime.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000502 RID: 1282 RVA: 0x000176B8 File Offset: 0x000158B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175358, XrefRangeEnd = 1175370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string __cctor_b__2_0(Object l)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.DateTime.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06000503 RID: 1283 RVA: 0x000042EC File Offset: 0x000024EC
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000178 RID: 376
				// (get) Token: 0x06000504 RID: 1284 RVA: 0x00017700 File Offset: 0x00015900
				// (set) Token: 0x06000505 RID: 1285 RVA: 0x000042F5 File Offset: 0x000024F5
				public unsafe static Parser.DateTime.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Parser.DateTime.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser.DateTime.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Parser.DateTime.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400037C RID: 892
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400037D RID: 893
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400037E RID: 894
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__2_0_Internal_String_Object_0;
			}
		}

		// Token: 0x0200005E RID: 94
		public static class EmailAddress : Object
		{
			// Token: 0x060004E7 RID: 1255 RVA: 0x0000413B File Offset: 0x0000233B
			// Note: this type is marked as 'beforefieldinit'.
			static EmailAddress()
			{
				Il2CppClassPointerStore<Parser.EmailAddress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "EmailAddress");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.EmailAddress>.NativeClassPtr);
				Parser.EmailAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.EmailAddress>.NativeClassPtr, 100663793);
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x00017328 File Offset: 0x00015528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175388, XrefRangeEnd = 1175395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out string result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Parser.EmailAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				result = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x0000416F File Offset: 0x0000236F
			public EmailAddress(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000374 RID: 884
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_String_0;
		}

		// Token: 0x0200005F RID: 95
		public static class Host : Object
		{
			// Token: 0x060004EA RID: 1258 RVA: 0x00004178 File Offset: 0x00002378
			// Note: this type is marked as 'beforefieldinit'.
			static Host()
			{
				Il2CppClassPointerStore<Parser.Host>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "Host");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.Host>.NativeClassPtr);
				Parser.Host.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.Host>.NativeClassPtr, 100663794);
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x00017384 File Offset: 0x00015584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175395, XrefRangeEnd = 1175405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out string result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Parser.Host.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				result = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x000041AC File Offset: 0x000023AC
			public Host(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000375 RID: 885
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_String_0;
		}

		// Token: 0x02000060 RID: 96
		public static class Int : Object
		{
			// Token: 0x060004ED RID: 1261 RVA: 0x000041B5 File Offset: 0x000023B5
			// Note: this type is marked as 'beforefieldinit'.
			static Int()
			{
				Il2CppClassPointerStore<Parser.Int>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "Int");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.Int>.NativeClassPtr);
				Parser.Int.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.Int>.NativeClassPtr, 100663795);
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x000173E0 File Offset: 0x000155E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175405, XrefRangeEnd = 1175410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out int result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.Int.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x000041E9 File Offset: 0x000023E9
			public Int(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000376 RID: 886
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int32_0;
		}

		// Token: 0x02000061 RID: 97
		public static class Long : Object
		{
			// Token: 0x060004F0 RID: 1264 RVA: 0x000041F2 File Offset: 0x000023F2
			// Note: this type is marked as 'beforefieldinit'.
			static Long()
			{
				Il2CppClassPointerStore<Parser.Long>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "Long");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.Long>.NativeClassPtr);
				Parser.Long.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.Long>.NativeClassPtr, 100663796);
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x00017430 File Offset: 0x00015630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175410, XrefRangeEnd = 1175415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out long result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.Long.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x00004226 File Offset: 0x00002426
			public Long(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000377 RID: 887
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int64_0;
		}

		// Token: 0x02000062 RID: 98
		public static class MD5 : Object
		{
			// Token: 0x060004F3 RID: 1267 RVA: 0x00017480 File Offset: 0x00015680
			// Note: this type is marked as 'beforefieldinit'.
			static MD5()
			{
				Il2CppClassPointerStore<Parser.MD5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "MD5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.MD5>.NativeClassPtr);
				Parser.MD5.NativeFieldInfoPtr_ToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.MD5>.NativeClassPtr, "ToString");
				Parser.MD5.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.MD5>.NativeClassPtr, 100663797);
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x000174D4 File Offset: 0x000156D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175424, XrefRangeEnd = 1175431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out Il2CppStructArray<byte> result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Parser.MD5.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				result = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060004F5 RID: 1269 RVA: 0x0000422F File Offset: 0x0000242F
			public MD5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00017538 File Offset: 0x00015738
			// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00004238 File Offset: 0x00002438
			public new unsafe static Func<Object, string> ToString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Parser.MD5.NativeFieldInfoPtr_ToString, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Parser.MD5.NativeFieldInfoPtr_ToString, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000378 RID: 888
			private static readonly IntPtr NativeFieldInfoPtr_ToString;

			// Token: 0x04000379 RID: 889
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_0;

			// Token: 0x02000067 RID: 103
			[ObfuscatedName("System.Net.Http.Headers.Parser+MD5+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06000506 RID: 1286 RVA: 0x00017728 File Offset: 0x00015928
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<Parser.MD5.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser.MD5>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.MD5.__c>.NativeClassPtr);
					Parser.MD5.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.MD5.__c>.NativeClassPtr, "<>9");
					Parser.MD5.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.MD5.__c>.NativeClassPtr, 100663800);
					Parser.MD5.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.MD5.__c>.NativeClassPtr, 100663801);
				}

				// Token: 0x06000507 RID: 1287 RVA: 0x00017790 File Offset: 0x00015990
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser.MD5.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.MD5.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000508 RID: 1288 RVA: 0x000177CC File Offset: 0x000159CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175415, XrefRangeEnd = 1175424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string __cctor_b__2_0(Object l)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.MD5.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06000509 RID: 1289 RVA: 0x00004307 File Offset: 0x00002507
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000179 RID: 377
				// (get) Token: 0x0600050A RID: 1290 RVA: 0x00017814 File Offset: 0x00015A14
				// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004310 File Offset: 0x00002510
				public unsafe static Parser.MD5.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Parser.MD5.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser.MD5.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Parser.MD5.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400037F RID: 895
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04000380 RID: 896
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000381 RID: 897
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__2_0_Internal_String_Object_0;
			}
		}

		// Token: 0x02000063 RID: 99
		public static class TimeSpanSeconds : Object
		{
			// Token: 0x060004F8 RID: 1272 RVA: 0x0000424A File Offset: 0x0000244A
			// Note: this type is marked as 'beforefieldinit'.
			static TimeSpanSeconds()
			{
				Il2CppClassPointerStore<Parser.TimeSpanSeconds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "TimeSpanSeconds");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.TimeSpanSeconds>.NativeClassPtr);
				Parser.TimeSpanSeconds.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.TimeSpanSeconds>.NativeClassPtr, 100663802);
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x00017560 File Offset: 0x00015760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175431, XrefRangeEnd = 1175440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out TimeSpan result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.TimeSpanSeconds.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x0000427E File Offset: 0x0000247E
			public TimeSpanSeconds(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400037A RID: 890
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TimeSpan_0;
		}

		// Token: 0x02000064 RID: 100
		public static class Uri : Object
		{
			// Token: 0x060004FB RID: 1275 RVA: 0x00004287 File Offset: 0x00002487
			// Note: this type is marked as 'beforefieldinit'.
			static Uri()
			{
				Il2CppClassPointerStore<Parser.Uri>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "Uri");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.Uri>.NativeClassPtr);
				Parser.Uri.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.Uri>.NativeClassPtr, 100663803);
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x000175B0 File Offset: 0x000157B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175440, XrefRangeEnd = 1175444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryParse(string input, out Il2CppSystem.Uri result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Parser.Uri.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				result = ((intPtr4 == 0) ? null : new Il2CppSystem.Uri(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x000042BB File Offset: 0x000024BB
			public Uri(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400037B RID: 891
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Uri_0;
		}
	}
}
