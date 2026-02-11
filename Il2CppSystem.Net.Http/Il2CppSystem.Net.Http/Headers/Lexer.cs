using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200002A RID: 42
	public class Lexer : Object
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x0000EFF0 File Offset: 0x0000D1F0
		// Note: this type is marked as 'beforefieldinit'.
		static Lexer()
		{
			Il2CppClassPointerStore<Lexer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "Lexer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lexer>.NativeClassPtr);
			Lexer.NativeFieldInfoPtr_token_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "token_chars");
			Lexer.NativeFieldInfoPtr_last_token_char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "last_token_char");
			Lexer.NativeFieldInfoPtr_dt_formats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "dt_formats");
			Lexer.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "s");
			Lexer.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "pos");
			Lexer.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663720);
			Lexer.NativeMethodInfoPtr_get_Position_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663721);
			Lexer.NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663722);
			Lexer.NativeMethodInfoPtr_GetStringValue_Public_String_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663723);
			Lexer.NativeMethodInfoPtr_GetStringValue_Public_String_Token_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663724);
			Lexer.NativeMethodInfoPtr_GetQuotedStringValue_Public_String_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663725);
			Lexer.NativeMethodInfoPtr_GetRemainingStringValue_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663726);
			Lexer.NativeMethodInfoPtr_IsStarStringValue_Public_Boolean_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663727);
			Lexer.NativeMethodInfoPtr_TryGetNumericValue_Public_Boolean_Token_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663728);
			Lexer.NativeMethodInfoPtr_TryGetNumericValue_Public_Boolean_Token_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663729);
			Lexer.NativeMethodInfoPtr_TryGetTimeSpanValue_Public_Nullable_1_TimeSpan_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663730);
			Lexer.NativeMethodInfoPtr_TryGetDateValue_Public_Boolean_Token_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663731);
			Lexer.NativeMethodInfoPtr_TryGetDateValue_Public_Static_Boolean_String_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663732);
			Lexer.NativeMethodInfoPtr_TryGetDoubleValue_Public_Boolean_Token_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663733);
			Lexer.NativeMethodInfoPtr_IsValidToken_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663734);
			Lexer.NativeMethodInfoPtr_IsValidCharacter_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663735);
			Lexer.NativeMethodInfoPtr_EatChar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663736);
			Lexer.NativeMethodInfoPtr_PeekChar_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663737);
			Lexer.NativeMethodInfoPtr_ScanCommentOptional_Public_Boolean_byref_String_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663738);
			Lexer.NativeMethodInfoPtr_Scan_Public_Token_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100663739);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000F214 File Offset: 0x0000D414
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lexer(string stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lexer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000F260 File Offset: 0x0000D460
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000F29C File Offset: 0x0000D49C
		public unsafe int Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_get_Position_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1174629, RefRangeEnd = 1174637, XrefRangeStart = 1174624, XrefRangeEnd = 1174629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringValue(Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_GetStringValue_Public_String_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000F320 File Offset: 0x0000D520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174642, RefRangeEnd = 1174644, XrefRangeStart = 1174637, XrefRangeEnd = 1174642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringValue(Token start, Token end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_GetStringValue_Public_String_Token_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000F374 File Offset: 0x0000D574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174644, XrefRangeEnd = 1174649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQuotedStringValue(Token start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_GetQuotedStringValue_Public_String_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		[CallerCount(0)]
		public unsafe string GetRemainingStringValue(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_GetRemainingStringValue_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000F3FC File Offset: 0x0000D5FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174653, RefRangeEnd = 1174655, XrefRangeStart = 1174649, XrefRangeEnd = 1174653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStarStringValue(Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_IsStarStringValue_Public_Boolean_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000F448 File Offset: 0x0000D648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174664, RefRangeEnd = 1174665, XrefRangeStart = 1174655, XrefRangeEnd = 1174664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetNumericValue(Token token, out int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_TryGetNumericValue_Public_Boolean_Token_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1174674, RefRangeEnd = 1174677, XrefRangeStart = 1174665, XrefRangeEnd = 1174674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetNumericValue(Token token, out long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_TryGetNumericValue_Public_Boolean_Token_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1174688, RefRangeEnd = 1174691, XrefRangeStart = 1174677, XrefRangeEnd = 1174688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<TimeSpan> TryGetTimeSpanValue(Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_TryGetTimeSpanValue_Public_Nullable_1_TimeSpan_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000F53C File Offset: 0x0000D73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174706, RefRangeEnd = 1174707, XrefRangeStart = 1174691, XrefRangeEnd = 1174706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetDateValue(Token token, out DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_TryGetDateValue_Public_Boolean_Token_byref_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000F594 File Offset: 0x0000D794
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1174719, RefRangeEnd = 1174722, XrefRangeStart = 1174707, XrefRangeEnd = 1174719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDateValue(string text, out DateTimeOffset value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_TryGetDateValue_Public_Static_Boolean_String_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174731, RefRangeEnd = 1174732, XrefRangeStart = 1174722, XrefRangeEnd = 1174731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetDoubleValue(Token token, out double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_TryGetDoubleValue_Public_Boolean_Token_byref_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000F63C File Offset: 0x0000D83C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1174744, RefRangeEnd = 1174749, XrefRangeStart = 1174732, XrefRangeEnd = 1174744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidToken(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_IsValidToken_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000F680 File Offset: 0x0000D880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174749, XrefRangeEnd = 1174753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidCharacter(char input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_IsValidCharacter_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174753, RefRangeEnd = 1174755, XrefRangeStart = 1174753, XrefRangeEnd = 1174753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EatChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_EatChar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174756, RefRangeEnd = 1174758, XrefRangeStart = 1174755, XrefRangeEnd = 1174756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PeekChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_PeekChar_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000F730 File Offset: 0x0000D930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174764, RefRangeEnd = 1174765, XrefRangeStart = 1174758, XrefRangeEnd = 1174764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ScanCommentOptional(out string value, out Token readToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &readToken;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ScanCommentOptional_Public_Boolean_byref_String_byref_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000F794 File Offset: 0x0000D994
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 1174768, RefRangeEnd = 1174851, XrefRangeStart = 1174765, XrefRangeEnd = 1174768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token Scan(bool recognizeDash = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recognizeDash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_Scan_Public_Token_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002F81 File Offset: 0x00001181
		public Lexer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00002F8A File Offset: 0x0000118A
		public unsafe static Il2CppStructArray<bool> token_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lexer.NativeFieldInfoPtr_token_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lexer.NativeFieldInfoPtr_token_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000F808 File Offset: 0x0000DA08
		// (set) Token: 0x060002BA RID: 698 RVA: 0x00002F9C File Offset: 0x0000119C
		public unsafe static int last_token_char
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Lexer.NativeFieldInfoPtr_last_token_char, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lexer.NativeFieldInfoPtr_last_token_char, (void*)(&value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000F824 File Offset: 0x0000DA24
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00002FAA File Offset: 0x000011AA
		public unsafe static Il2CppStringArray dt_formats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lexer.NativeFieldInfoPtr_dt_formats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lexer.NativeFieldInfoPtr_dt_formats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000F84C File Offset: 0x0000DA4C
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002FBC File Offset: 0x000011BC
		public unsafe string s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_s);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_s), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000F874 File Offset: 0x0000DA74
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00002FDB File Offset: 0x000011DB
		public unsafe int pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_token_chars;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_last_token_char;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_dt_formats;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_s;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Int32_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Public_String_Token_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Public_String_Token_Token_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_GetQuotedStringValue_Public_String_Token_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_GetRemainingStringValue_Public_String_Int32_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_IsStarStringValue_Public_Boolean_Token_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNumericValue_Public_Boolean_Token_byref_Int32_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNumericValue_Public_Boolean_Token_byref_Int64_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTimeSpanValue_Public_Nullable_1_TimeSpan_Token_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDateValue_Public_Boolean_Token_byref_DateTimeOffset_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDateValue_Public_Static_Boolean_String_byref_DateTimeOffset_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDoubleValue_Public_Boolean_Token_byref_Double_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_IsValidToken_Public_Static_Boolean_String_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCharacter_Public_Static_Boolean_Char_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_EatChar_Public_Void_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_PeekChar_Public_Int32_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_ScanCommentOptional_Public_Boolean_byref_String_byref_Token_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Public_Token_Boolean_0;
	}
}
