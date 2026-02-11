using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x02000229 RID: 553
	public sealed class TokenizerStream : Object
	{
		// Token: 0x060024A9 RID: 9385 RVA: 0x000CBE00 File Offset: 0x000CA000
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerStream()
		{
			Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr);
			TokenizerStream.NativeFieldInfoPtr_m_countTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_countTokens");
			TokenizerStream.NativeFieldInfoPtr_m_headTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_headTokens");
			TokenizerStream.NativeFieldInfoPtr_m_lastTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_lastTokens");
			TokenizerStream.NativeFieldInfoPtr_m_currentTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_currentTokens");
			TokenizerStream.NativeFieldInfoPtr_m_indexTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_indexTokens");
			TokenizerStream.NativeFieldInfoPtr_m_headStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_headStrings");
			TokenizerStream.NativeFieldInfoPtr_m_currentStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_currentStrings");
			TokenizerStream.NativeFieldInfoPtr_m_indexStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_indexStrings");
			TokenizerStream.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669459);
			TokenizerStream.NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669460);
			TokenizerStream.NativeMethodInfoPtr_AddString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669461);
			TokenizerStream.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669462);
			TokenizerStream.NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669463);
			TokenizerStream.NativeMethodInfoPtr_GetNextToken_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669464);
			TokenizerStream.NativeMethodInfoPtr_GetNextString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669465);
			TokenizerStream.NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669466);
			TokenizerStream.NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669467);
			TokenizerStream.NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669468);
			TokenizerStream.NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100669469);
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000CBFAC File Offset: 0x000CA1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370465, XrefRangeEnd = 1370487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000CBFE8 File Offset: 0x000CA1E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1370497, RefRangeEnd = 1370499, XrefRangeStart = 1370487, XrefRangeEnd = 1370497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToken(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000CC028 File Offset: 0x000CA228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370512, RefRangeEnd = 1370513, XrefRangeStart = 1370499, XrefRangeEnd = 1370512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_AddString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000CC06C File Offset: 0x000CA26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370513, XrefRangeEnd = 1370516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000CC0A0 File Offset: 0x000CA2A0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1370518, RefRangeEnd = 1370536, XrefRangeStart = 1370516, XrefRangeEnd = 1370518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetNextFullToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000CC0DC File Offset: 0x000CA2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370536, XrefRangeEnd = 1370537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetNextToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextToken_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000CC118 File Offset: 0x000CA318
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1370538, RefRangeEnd = 1370557, XrefRangeStart = 1370537, XrefRangeEnd = 1370538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNextString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000CC150 File Offset: 0x000CA350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370557, XrefRangeEnd = 1370558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowAwayNextString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000CC184 File Offset: 0x000CA384
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1370558, RefRangeEnd = 1370567, XrefRangeStart = 1370558, XrefRangeEnd = 1370558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TagLastToken(short tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000CC1C4 File Offset: 0x000CA3C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTokenCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000CC200 File Offset: 0x000CA400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370572, RefRangeEnd = 1370573, XrefRangeStart = 1370567, XrefRangeEnd = 1370572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToPosition(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0000BC66 File Offset: 0x00009E66
		public TokenizerStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000CC240 File Offset: 0x000CA440
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0000BC6F File Offset: 0x00009E6F
		public unsafe int m_countTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_countTokens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_countTokens)) = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000CC268 File Offset: 0x000CA468
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x0000BC8A File Offset: 0x00009E8A
		public unsafe TokenizerShortBlock m_headTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000CC298 File Offset: 0x000CA498
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0000BCA9 File Offset: 0x00009EA9
		public unsafe TokenizerShortBlock m_lastTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_lastTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_lastTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000CC2C8 File Offset: 0x000CA4C8
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		public unsafe TokenizerShortBlock m_currentTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000CC2F8 File Offset: 0x000CA4F8
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0000BCE7 File Offset: 0x00009EE7
		public unsafe int m_indexTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexTokens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexTokens)) = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x000CC320 File Offset: 0x000CA520
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x0000BD02 File Offset: 0x00009F02
		public unsafe TokenizerStringBlock m_headStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000CC350 File Offset: 0x000CA550
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0000BD21 File Offset: 0x00009F21
		public unsafe TokenizerStringBlock m_currentStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000CC380 File Offset: 0x000CA580
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0000BD40 File Offset: 0x00009F40
		public unsafe int m_indexStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexStrings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexStrings)) = value;
			}
		}

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeFieldInfoPtr_m_countTokens;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeFieldInfoPtr_m_headTokens;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeFieldInfoPtr_m_lastTokens;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeFieldInfoPtr_m_currentTokens;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeFieldInfoPtr_m_indexTokens;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeFieldInfoPtr_m_headStrings;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeFieldInfoPtr_m_currentStrings;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeFieldInfoPtr_m_indexStrings;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Internal_Void_String_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_GetNextToken_Internal_Int16_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_GetNextString_Internal_String_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0;
	}
}
