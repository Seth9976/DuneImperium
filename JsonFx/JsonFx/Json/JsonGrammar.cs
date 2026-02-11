using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JsonFx.Json
{
	// Token: 0x02000026 RID: 38
	public static class JsonGrammar : Object
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000A688 File Offset: 0x00008888
		// Note: this type is marked as 'beforefieldinit'.
		static JsonGrammar()
		{
			Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Json", "JsonGrammar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr);
			JsonGrammar.NativeFieldInfoPtr_KeywordUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "KeywordUndefined");
			JsonGrammar.NativeFieldInfoPtr_KeywordNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "KeywordNull");
			JsonGrammar.NativeFieldInfoPtr_KeywordFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "KeywordFalse");
			JsonGrammar.NativeFieldInfoPtr_KeywordTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "KeywordTrue");
			JsonGrammar.NativeFieldInfoPtr_KeywordNaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "KeywordNaN");
			JsonGrammar.NativeFieldInfoPtr_KeywordInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "KeywordInfinity");
			JsonGrammar.NativeFieldInfoPtr_OperatorArrayBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorArrayBegin");
			JsonGrammar.NativeFieldInfoPtr_OperatorArrayEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorArrayEnd");
			JsonGrammar.NativeFieldInfoPtr_OperatorObjectBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorObjectBegin");
			JsonGrammar.NativeFieldInfoPtr_OperatorObjectEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorObjectEnd");
			JsonGrammar.NativeFieldInfoPtr_OperatorValueDelim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorValueDelim");
			JsonGrammar.NativeFieldInfoPtr_OperatorPairDelim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorPairDelim");
			JsonGrammar.NativeFieldInfoPtr_OperatorStringDelim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorStringDelim");
			JsonGrammar.NativeFieldInfoPtr_OperatorStringDelimAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorStringDelimAlt");
			JsonGrammar.NativeFieldInfoPtr_OperatorCharEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorCharEscape");
			JsonGrammar.NativeFieldInfoPtr_OperatorUnaryMinus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorUnaryMinus");
			JsonGrammar.NativeFieldInfoPtr_OperatorUnaryPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorUnaryPlus");
			JsonGrammar.NativeFieldInfoPtr_OperatorDecimalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorDecimalPoint");
			JsonGrammar.NativeFieldInfoPtr_OperatorCommentBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorCommentBegin");
			JsonGrammar.NativeFieldInfoPtr_OperatorCommentEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorCommentEnd");
			JsonGrammar.NativeFieldInfoPtr_OperatorCommentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonGrammar>.NativeClassPtr, "OperatorCommentLine");
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002B6C File Offset: 0x00000D6C
		public JsonGrammar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000A85C File Offset: 0x00008A5C
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002B75 File Offset: 0x00000D75
		public unsafe static string KeywordUndefined
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_KeywordUndefined, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_KeywordUndefined, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000A87C File Offset: 0x00008A7C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002B87 File Offset: 0x00000D87
		public unsafe static string KeywordNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_KeywordNull, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_KeywordNull, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000A89C File Offset: 0x00008A9C
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002B99 File Offset: 0x00000D99
		public unsafe static string KeywordFalse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_KeywordFalse, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_KeywordFalse, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000A8BC File Offset: 0x00008ABC
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002BAB File Offset: 0x00000DAB
		public unsafe static string KeywordTrue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_KeywordTrue, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_KeywordTrue, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000A8DC File Offset: 0x00008ADC
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002BBD File Offset: 0x00000DBD
		public unsafe static string KeywordNaN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_KeywordNaN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_KeywordNaN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000A8FC File Offset: 0x00008AFC
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002BCF File Offset: 0x00000DCF
		public unsafe static string KeywordInfinity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_KeywordInfinity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_KeywordInfinity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A91C File Offset: 0x00008B1C
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002BE1 File Offset: 0x00000DE1
		public unsafe static char OperatorArrayBegin
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorArrayBegin, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorArrayBegin, (void*)(&value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000A938 File Offset: 0x00008B38
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002BEF File Offset: 0x00000DEF
		public unsafe static char OperatorArrayEnd
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorArrayEnd, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorArrayEnd, (void*)(&value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000A954 File Offset: 0x00008B54
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002BFD File Offset: 0x00000DFD
		public unsafe static char OperatorObjectBegin
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorObjectBegin, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorObjectBegin, (void*)(&value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000A970 File Offset: 0x00008B70
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002C0B File Offset: 0x00000E0B
		public unsafe static char OperatorObjectEnd
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorObjectEnd, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorObjectEnd, (void*)(&value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000A98C File Offset: 0x00008B8C
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002C19 File Offset: 0x00000E19
		public unsafe static char OperatorValueDelim
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorValueDelim, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorValueDelim, (void*)(&value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002C27 File Offset: 0x00000E27
		public unsafe static char OperatorPairDelim
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorPairDelim, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorPairDelim, (void*)(&value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002C35 File Offset: 0x00000E35
		public unsafe static char OperatorStringDelim
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorStringDelim, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorStringDelim, (void*)(&value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002C43 File Offset: 0x00000E43
		public unsafe static char OperatorStringDelimAlt
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorStringDelimAlt, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorStringDelimAlt, (void*)(&value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000A9FC File Offset: 0x00008BFC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002C51 File Offset: 0x00000E51
		public unsafe static char OperatorCharEscape
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorCharEscape, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorCharEscape, (void*)(&value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000AA18 File Offset: 0x00008C18
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002C5F File Offset: 0x00000E5F
		public unsafe static char OperatorUnaryMinus
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorUnaryMinus, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorUnaryMinus, (void*)(&value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000AA34 File Offset: 0x00008C34
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002C6D File Offset: 0x00000E6D
		public unsafe static char OperatorUnaryPlus
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorUnaryPlus, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorUnaryPlus, (void*)(&value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000AA50 File Offset: 0x00008C50
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002C7B File Offset: 0x00000E7B
		public unsafe static char OperatorDecimalPoint
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorDecimalPoint, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorDecimalPoint, (void*)(&value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000AA6C File Offset: 0x00008C6C
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002C89 File Offset: 0x00000E89
		public unsafe static string OperatorCommentBegin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorCommentBegin, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorCommentBegin, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000AA8C File Offset: 0x00008C8C
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002C9B File Offset: 0x00000E9B
		public unsafe static string OperatorCommentEnd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorCommentEnd, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorCommentEnd, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000AAAC File Offset: 0x00008CAC
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002CAD File Offset: 0x00000EAD
		public unsafe static string OperatorCommentLine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonGrammar.NativeFieldInfoPtr_OperatorCommentLine, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonGrammar.NativeFieldInfoPtr_OperatorCommentLine, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_KeywordUndefined;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_KeywordNull;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_KeywordFalse;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_KeywordTrue;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_KeywordNaN;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_KeywordInfinity;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_OperatorArrayBegin;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_OperatorArrayEnd;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_OperatorObjectBegin;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_OperatorObjectEnd;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_OperatorValueDelim;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_OperatorPairDelim;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_OperatorStringDelim;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_OperatorStringDelimAlt;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_OperatorCharEscape;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_OperatorUnaryMinus;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_OperatorUnaryPlus;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_OperatorDecimalPoint;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_OperatorCommentBegin;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_OperatorCommentEnd;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_OperatorCommentLine;
	}
}
