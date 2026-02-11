using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Mime
{
	// Token: 0x02000249 RID: 585
	public static class MailBnfHelper : Object
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x000B352C File Offset: 0x000B172C
		// Note: this type is marked as 'beforefieldinit'.
		static MailBnfHelper()
		{
			Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mime", "MailBnfHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr);
			MailBnfHelper.NativeFieldInfoPtr_Atext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Atext");
			MailBnfHelper.NativeFieldInfoPtr_Qtext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Qtext");
			MailBnfHelper.NativeFieldInfoPtr_Dtext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Dtext");
			MailBnfHelper.NativeFieldInfoPtr_Ftext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Ftext");
			MailBnfHelper.NativeFieldInfoPtr_Ttext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Ttext");
			MailBnfHelper.NativeFieldInfoPtr_Ctext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Ctext");
			MailBnfHelper.NativeFieldInfoPtr_Ascii7bitMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Ascii7bitMaxValue");
			MailBnfHelper.NativeFieldInfoPtr_Quote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Quote");
			MailBnfHelper.NativeFieldInfoPtr_Space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Space");
			MailBnfHelper.NativeFieldInfoPtr_Tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Tab");
			MailBnfHelper.NativeFieldInfoPtr_CR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "CR");
			MailBnfHelper.NativeFieldInfoPtr_LF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "LF");
			MailBnfHelper.NativeFieldInfoPtr_StartComment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "StartComment");
			MailBnfHelper.NativeFieldInfoPtr_EndComment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "EndComment");
			MailBnfHelper.NativeFieldInfoPtr_Backslash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Backslash");
			MailBnfHelper.NativeFieldInfoPtr_At = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "At");
			MailBnfHelper.NativeFieldInfoPtr_EndAngleBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "EndAngleBracket");
			MailBnfHelper.NativeFieldInfoPtr_StartAngleBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "StartAngleBracket");
			MailBnfHelper.NativeFieldInfoPtr_StartSquareBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "StartSquareBracket");
			MailBnfHelper.NativeFieldInfoPtr_EndSquareBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "EndSquareBracket");
			MailBnfHelper.NativeFieldInfoPtr_Comma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Comma");
			MailBnfHelper.NativeFieldInfoPtr_Dot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "Dot");
			MailBnfHelper.NativeFieldInfoPtr_s_colonSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "s_colonSeparator");
			MailBnfHelper.NativeFieldInfoPtr_s_months = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, "s_months");
			MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInAtoms_Private_Static_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, 100669137);
			MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInQuotedStrings_Private_Static_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, 100669138);
			MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInDomainLiterals_Private_Static_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, 100669139);
			MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInHeaderNames_Private_Static_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, 100669140);
			MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInTokens_Private_Static_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, 100669141);
			MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInComments_Private_Static_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, 100669142);
			MailBnfHelper.NativeMethodInfoPtr_IsAllowedWhiteSpace_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailBnfHelper>.NativeClassPtr, 100669143);
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000B37C8 File Offset: 0x000B19C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490746, XrefRangeEnd = 490749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> CreateCharactersAllowedInAtoms()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInAtoms_Private_Static_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000B37FC File Offset: 0x000B19FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490749, XrefRangeEnd = 490752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> CreateCharactersAllowedInQuotedStrings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInQuotedStrings_Private_Static_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000B3830 File Offset: 0x000B1A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490752, XrefRangeEnd = 490755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> CreateCharactersAllowedInDomainLiterals()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInDomainLiterals_Private_Static_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000B3864 File Offset: 0x000B1A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490755, XrefRangeEnd = 490758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> CreateCharactersAllowedInHeaderNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInHeaderNames_Private_Static_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000B3898 File Offset: 0x000B1A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490758, XrefRangeEnd = 490761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> CreateCharactersAllowedInTokens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInTokens_Private_Static_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000B38CC File Offset: 0x000B1ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490761, XrefRangeEnd = 490764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> CreateCharactersAllowedInComments()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailBnfHelper.NativeMethodInfoPtr_CreateCharactersAllowedInComments_Private_Static_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000B3900 File Offset: 0x000B1B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490764, XrefRangeEnd = 490774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAllowedWhiteSpace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailBnfHelper.NativeMethodInfoPtr_IsAllowedWhiteSpace_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		public MailBnfHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000B3940 File Offset: 0x000B1B40
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x00010DD9 File Offset: 0x0000EFD9
		public unsafe static Il2CppStructArray<bool> Atext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Atext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Atext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x000B3968 File Offset: 0x000B1B68
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x00010DEB File Offset: 0x0000EFEB
		public unsafe static Il2CppStructArray<bool> Qtext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Qtext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Qtext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x000B3990 File Offset: 0x000B1B90
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x00010DFD File Offset: 0x0000EFFD
		public unsafe static Il2CppStructArray<bool> Dtext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Dtext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Dtext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000B39B8 File Offset: 0x000B1BB8
		// (set) Token: 0x0600272B RID: 10027 RVA: 0x00010E0F File Offset: 0x0000F00F
		public unsafe static Il2CppStructArray<bool> Ftext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Ftext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Ftext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x000B39E0 File Offset: 0x000B1BE0
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x00010E21 File Offset: 0x0000F021
		public unsafe static Il2CppStructArray<bool> Ttext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Ttext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Ttext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000B3A08 File Offset: 0x000B1C08
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x00010E33 File Offset: 0x0000F033
		public unsafe static Il2CppStructArray<bool> Ctext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Ctext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Ctext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000B3A30 File Offset: 0x000B1C30
		// (set) Token: 0x06002731 RID: 10033 RVA: 0x00010E45 File Offset: 0x0000F045
		public unsafe static int Ascii7bitMaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Ascii7bitMaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Ascii7bitMaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000B3A4C File Offset: 0x000B1C4C
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x00010E53 File Offset: 0x0000F053
		public unsafe static char Quote
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Quote, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Quote, (void*)(&value));
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000B3A68 File Offset: 0x000B1C68
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00010E61 File Offset: 0x0000F061
		public unsafe static char Space
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Space, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Space, (void*)(&value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000B3A84 File Offset: 0x000B1C84
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x00010E6F File Offset: 0x0000F06F
		public unsafe static char Tab
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Tab, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Tab, (void*)(&value));
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000B3AA0 File Offset: 0x000B1CA0
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x00010E7D File Offset: 0x0000F07D
		public unsafe static char CR
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_CR, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_CR, (void*)(&value));
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000B3ABC File Offset: 0x000B1CBC
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x00010E8B File Offset: 0x0000F08B
		public unsafe static char LF
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_LF, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_LF, (void*)(&value));
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x000B3AD8 File Offset: 0x000B1CD8
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x00010E99 File Offset: 0x0000F099
		public unsafe static char StartComment
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_StartComment, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_StartComment, (void*)(&value));
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000B3AF4 File Offset: 0x000B1CF4
		// (set) Token: 0x0600273F RID: 10047 RVA: 0x00010EA7 File Offset: 0x0000F0A7
		public unsafe static char EndComment
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_EndComment, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_EndComment, (void*)(&value));
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000B3B10 File Offset: 0x000B1D10
		// (set) Token: 0x06002741 RID: 10049 RVA: 0x00010EB5 File Offset: 0x0000F0B5
		public unsafe static char Backslash
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Backslash, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Backslash, (void*)(&value));
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000B3B2C File Offset: 0x000B1D2C
		// (set) Token: 0x06002743 RID: 10051 RVA: 0x00010EC3 File Offset: 0x0000F0C3
		public unsafe static char At
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_At, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_At, (void*)(&value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x000B3B48 File Offset: 0x000B1D48
		// (set) Token: 0x06002745 RID: 10053 RVA: 0x00010ED1 File Offset: 0x0000F0D1
		public unsafe static char EndAngleBracket
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_EndAngleBracket, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_EndAngleBracket, (void*)(&value));
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x000B3B64 File Offset: 0x000B1D64
		// (set) Token: 0x06002747 RID: 10055 RVA: 0x00010EDF File Offset: 0x0000F0DF
		public unsafe static char StartAngleBracket
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_StartAngleBracket, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_StartAngleBracket, (void*)(&value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x000B3B80 File Offset: 0x000B1D80
		// (set) Token: 0x06002749 RID: 10057 RVA: 0x00010EED File Offset: 0x0000F0ED
		public unsafe static char StartSquareBracket
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_StartSquareBracket, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_StartSquareBracket, (void*)(&value));
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000B3B9C File Offset: 0x000B1D9C
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x00010EFB File Offset: 0x0000F0FB
		public unsafe static char EndSquareBracket
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_EndSquareBracket, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_EndSquareBracket, (void*)(&value));
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000B3BB8 File Offset: 0x000B1DB8
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x00010F09 File Offset: 0x0000F109
		public unsafe static char Comma
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Comma, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Comma, (void*)(&value));
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000B3BD4 File Offset: 0x000B1DD4
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x00010F17 File Offset: 0x0000F117
		public unsafe static char Dot
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_Dot, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_Dot, (void*)(&value));
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000B3BF0 File Offset: 0x000B1DF0
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x00010F25 File Offset: 0x0000F125
		public unsafe static Il2CppStructArray<char> s_colonSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_s_colonSeparator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_s_colonSeparator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000B3C18 File Offset: 0x000B1E18
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x00010F37 File Offset: 0x0000F137
		public unsafe static Il2CppStringArray s_months
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailBnfHelper.NativeFieldInfoPtr_s_months, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailBnfHelper.NativeFieldInfoPtr_s_months, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeFieldInfoPtr_Atext;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeFieldInfoPtr_Qtext;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeFieldInfoPtr_Dtext;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeFieldInfoPtr_Ftext;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeFieldInfoPtr_Ttext;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeFieldInfoPtr_Ctext;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeFieldInfoPtr_Ascii7bitMaxValue;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeFieldInfoPtr_Quote;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeFieldInfoPtr_Space;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeFieldInfoPtr_Tab;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeFieldInfoPtr_CR;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeFieldInfoPtr_LF;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeFieldInfoPtr_StartComment;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeFieldInfoPtr_EndComment;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeFieldInfoPtr_Backslash;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeFieldInfoPtr_At;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeFieldInfoPtr_EndAngleBracket;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr_StartAngleBracket;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr_StartSquareBracket;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeFieldInfoPtr_EndSquareBracket;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_Comma;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeFieldInfoPtr_Dot;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeFieldInfoPtr_s_colonSeparator;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr_s_months;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_CreateCharactersAllowedInAtoms_Private_Static_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_CreateCharactersAllowedInQuotedStrings_Private_Static_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_CreateCharactersAllowedInDomainLiterals_Private_Static_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr_CreateCharactersAllowedInHeaderNames_Private_Static_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr_CreateCharactersAllowedInTokens_Private_Static_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeMethodInfoPtr_CreateCharactersAllowedInComments_Private_Static_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr_IsAllowedWhiteSpace_Internal_Static_Boolean_Char_0;
	}
}
