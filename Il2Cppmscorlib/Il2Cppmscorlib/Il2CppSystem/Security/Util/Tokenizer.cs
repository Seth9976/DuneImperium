using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x02000226 RID: 550
	public sealed class Tokenizer : Object
	{
		// Token: 0x06002473 RID: 9331 RVA: 0x000CB5C8 File Offset: 0x000C97C8
		// Note: this type is marked as 'beforefieldinit'.
		static Tokenizer()
		{
			Il2CppClassPointerStore<Tokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "Tokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr);
			Tokenizer.NativeFieldInfoPtr_LineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "LineNo");
			Tokenizer.NativeFieldInfoPtr__inProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inProcessingTag");
			Tokenizer.NativeFieldInfoPtr__inBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inBytes");
			Tokenizer.NativeFieldInfoPtr__inChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inChars");
			Tokenizer.NativeFieldInfoPtr__inString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inString");
			Tokenizer.NativeFieldInfoPtr__inIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inIndex");
			Tokenizer.NativeFieldInfoPtr__inSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSize");
			Tokenizer.NativeFieldInfoPtr__inSavedCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSavedCharacter");
			Tokenizer.NativeFieldInfoPtr__inTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenSource");
			Tokenizer.NativeFieldInfoPtr__inTokenReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenReader");
			Tokenizer.NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_maker");
			Tokenizer.NativeFieldInfoPtr__searchStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_searchStrings");
			Tokenizer.NativeFieldInfoPtr__replaceStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_replaceStrings");
			Tokenizer.NativeFieldInfoPtr__inNestedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedIndex");
			Tokenizer.NativeFieldInfoPtr__inNestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedSize");
			Tokenizer.NativeFieldInfoPtr__inNestedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedString");
			Tokenizer.NativeMethodInfoPtr_BasicInitialization_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669442);
			Tokenizer.NativeMethodInfoPtr_Recycle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669443);
			Tokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669444);
			Tokenizer.NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669445);
			Tokenizer.NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669446);
			Tokenizer.NativeMethodInfoPtr_GetStringToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669447);
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x000CB7B0 File Offset: 0x000C99B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370402, XrefRangeEnd = 1370407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BasicInitialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_BasicInitialization_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x000CB7E4 File Offset: 0x000C99E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370407, XrefRangeEnd = 1370411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_Recycle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x000CB818 File Offset: 0x000C9A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370411, XrefRangeEnd = 1370418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tokenizer(string input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x000CB864 File Offset: 0x000C9A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370424, RefRangeEnd = 1370425, XrefRangeStart = 1370418, XrefRangeEnd = 1370424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFormat(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x000CB8A8 File Offset: 0x000C9AA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1370450, RefRangeEnd = 1370453, XrefRangeStart = 1370425, XrefRangeEnd = 1370450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endAfterKet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x000CB908 File Offset: 0x000C9B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370453, XrefRangeEnd = 1370455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_GetStringToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0000B9FF File Offset: 0x00009BFF
		public Tokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x000CB940 File Offset: 0x000C9B40
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0000BA08 File Offset: 0x00009C08
		public unsafe int LineNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr_LineNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr_LineNo)) = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x000CB968 File Offset: 0x000C9B68
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x0000BA23 File Offset: 0x00009C23
		public unsafe int _inProcessingTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inProcessingTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inProcessingTag)) = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x000CB990 File Offset: 0x000C9B90
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x0000BA3E File Offset: 0x00009C3E
		public unsafe Il2CppStructArray<byte> _inBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x000CB9C0 File Offset: 0x000C9BC0
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0000BA5D File Offset: 0x00009C5D
		public unsafe Il2CppStructArray<char> _inChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x000CB9F0 File Offset: 0x000C9BF0
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x0000BA7C File Offset: 0x00009C7C
		public unsafe string _inString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x000CBA18 File Offset: 0x000C9C18
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x0000BA9B File Offset: 0x00009C9B
		public unsafe int _inIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inIndex)) = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000CBA40 File Offset: 0x000C9C40
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x0000BAB6 File Offset: 0x00009CB6
		public unsafe int _inSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSize)) = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000CBA68 File Offset: 0x000C9C68
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x0000BAD1 File Offset: 0x00009CD1
		public unsafe int _inSavedCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSavedCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSavedCharacter)) = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x000CBA90 File Offset: 0x000C9C90
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x0000BAEC File Offset: 0x00009CEC
		public unsafe Tokenizer.TokenSource _inTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenSource)) = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x000CBAB8 File Offset: 0x000C9CB8
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x0000BB07 File Offset: 0x00009D07
		public unsafe Tokenizer.ITokenReader _inTokenReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.ITokenReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x000CBAE8 File Offset: 0x000C9CE8
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x0000BB26 File Offset: 0x00009D26
		public unsafe Tokenizer.StringMaker _maker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__maker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__maker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000CBB18 File Offset: 0x000C9D18
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0000BB45 File Offset: 0x00009D45
		public unsafe Il2CppStringArray _searchStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__searchStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__searchStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x000CBB48 File Offset: 0x000C9D48
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0000BB64 File Offset: 0x00009D64
		public unsafe Il2CppStringArray _replaceStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__replaceStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__replaceStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x000CBB78 File Offset: 0x000C9D78
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0000BB83 File Offset: 0x00009D83
		public unsafe int _inNestedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedIndex)) = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x000CBBA0 File Offset: 0x000C9DA0
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0000BB9E File Offset: 0x00009D9E
		public unsafe int _inNestedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedSize)) = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000CBBC8 File Offset: 0x000C9DC8
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0000BBB9 File Offset: 0x00009DB9
		public unsafe string _inNestedString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeFieldInfoPtr_LineNo;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeFieldInfoPtr__inProcessingTag;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeFieldInfoPtr__inBytes;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeFieldInfoPtr__inChars;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeFieldInfoPtr__inString;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeFieldInfoPtr__inIndex;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeFieldInfoPtr__inSize;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeFieldInfoPtr__inSavedCharacter;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeFieldInfoPtr__inTokenSource;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeFieldInfoPtr__inTokenReader;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeFieldInfoPtr__maker;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeFieldInfoPtr__searchStrings;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeFieldInfoPtr__replaceStrings;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeFieldInfoPtr__inNestedIndex;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr__inNestedSize;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr__inNestedString;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr_BasicInitialization_Internal_Void_0;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr_Recycle_Public_Void_0;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_GetStringToken_Private_String_0;

		// Token: 0x0200065B RID: 1627
		public enum TokenSource
		{
			// Token: 0x040049E5 RID: 18917
			UnicodeByteArray,
			// Token: 0x040049E6 RID: 18918
			UTF8ByteArray,
			// Token: 0x040049E7 RID: 18919
			ASCIIByteArray,
			// Token: 0x040049E8 RID: 18920
			CharArray,
			// Token: 0x040049E9 RID: 18921
			String,
			// Token: 0x040049EA RID: 18922
			NestedStrings,
			// Token: 0x040049EB RID: 18923
			Other
		}

		// Token: 0x0200065C RID: 1628
		[Serializable]
		public sealed class StringMaker : Object
		{
			// Token: 0x06005A59 RID: 23129 RVA: 0x0019D1B4 File Offset: 0x0019B3B4
			// Note: this type is marked as 'beforefieldinit'.
			static StringMaker()
			{
				Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StringMaker");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr);
				Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "aStrings");
				Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "cStringsMax");
				Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "cStringsUsed");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outStringBuilder");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outChars");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outIndex");
				Tokenizer.StringMaker.NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100669448);
				Tokenizer.StringMaker.NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100669449);
				Tokenizer.StringMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100669450);
				Tokenizer.StringMaker.NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100669451);
				Tokenizer.StringMaker.NativeMethodInfoPtr_MakeString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100669452);
			}

			// Token: 0x06005A5A RID: 23130 RVA: 0x0019D2BC File Offset: 0x0019B4BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1370379, RefRangeEnd = 1370380, XrefRangeStart = 1370378, XrefRangeEnd = 1370379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint HashString(string str)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A5B RID: 23131 RVA: 0x0019D300 File Offset: 0x0019B500
			[CallerCount(0)]
			public unsafe static uint HashCharArray(Il2CppStructArray<char> a, int l)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A5C RID: 23132 RVA: 0x0019D350 File Offset: 0x0019B550
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1370389, RefRangeEnd = 1370390, XrefRangeStart = 1370380, XrefRangeEnd = 1370389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringMaker()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A5D RID: 23133 RVA: 0x0019D38C File Offset: 0x0019B58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370390, XrefRangeEnd = 1370391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CompareStringAndChars(string str, Il2CppStructArray<char> a, int l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A5E RID: 23134 RVA: 0x0019D3FC File Offset: 0x0019B5FC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1370399, RefRangeEnd = 1370402, XrefRangeStart = 1370391, XrefRangeEnd = 1370399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string MakeString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_MakeString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005A5F RID: 23135 RVA: 0x00020667 File Offset: 0x0001E867
			public StringMaker(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001710 RID: 5904
			// (get) Token: 0x06005A60 RID: 23136 RVA: 0x0019D434 File Offset: 0x0019B634
			// (set) Token: 0x06005A61 RID: 23137 RVA: 0x00020670 File Offset: 0x0001E870
			public unsafe Il2CppStringArray aStrings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001711 RID: 5905
			// (get) Token: 0x06005A62 RID: 23138 RVA: 0x0019D464 File Offset: 0x0019B664
			// (set) Token: 0x06005A63 RID: 23139 RVA: 0x0002068F File Offset: 0x0001E88F
			public unsafe uint cStringsMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax)) = value;
				}
			}

			// Token: 0x17001712 RID: 5906
			// (get) Token: 0x06005A64 RID: 23140 RVA: 0x0019D48C File Offset: 0x0019B68C
			// (set) Token: 0x06005A65 RID: 23141 RVA: 0x000206AA File Offset: 0x0001E8AA
			public unsafe uint cStringsUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed)) = value;
				}
			}

			// Token: 0x17001713 RID: 5907
			// (get) Token: 0x06005A66 RID: 23142 RVA: 0x0019D4B4 File Offset: 0x0019B6B4
			// (set) Token: 0x06005A67 RID: 23143 RVA: 0x000206C5 File Offset: 0x0001E8C5
			public unsafe StringBuilder _outStringBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001714 RID: 5908
			// (get) Token: 0x06005A68 RID: 23144 RVA: 0x0019D4E4 File Offset: 0x0019B6E4
			// (set) Token: 0x06005A69 RID: 23145 RVA: 0x000206E4 File Offset: 0x0001E8E4
			public unsafe Il2CppStructArray<char> _outChars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outChars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outChars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001715 RID: 5909
			// (get) Token: 0x06005A6A RID: 23146 RVA: 0x0019D514 File Offset: 0x0019B714
			// (set) Token: 0x06005A6B RID: 23147 RVA: 0x00020703 File Offset: 0x0001E903
			public unsafe int _outIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex)) = value;
				}
			}

			// Token: 0x040049EC RID: 18924
			private static readonly IntPtr NativeFieldInfoPtr_aStrings;

			// Token: 0x040049ED RID: 18925
			private static readonly IntPtr NativeFieldInfoPtr_cStringsMax;

			// Token: 0x040049EE RID: 18926
			private static readonly IntPtr NativeFieldInfoPtr_cStringsUsed;

			// Token: 0x040049EF RID: 18927
			private static readonly IntPtr NativeFieldInfoPtr__outStringBuilder;

			// Token: 0x040049F0 RID: 18928
			private static readonly IntPtr NativeFieldInfoPtr__outChars;

			// Token: 0x040049F1 RID: 18929
			private static readonly IntPtr NativeFieldInfoPtr__outIndex;

			// Token: 0x040049F2 RID: 18930
			private static readonly IntPtr NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0;

			// Token: 0x040049F3 RID: 18931
			private static readonly IntPtr NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x040049F4 RID: 18932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040049F5 RID: 18933
			private static readonly IntPtr NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x040049F6 RID: 18934
			private static readonly IntPtr NativeMethodInfoPtr_MakeString_Public_String_0;
		}

		// Token: 0x0200065D RID: 1629
		public class ITokenReader : Il2CppObjectBase
		{
			// Token: 0x06005A6C RID: 23148 RVA: 0x0002071E File Offset: 0x0001E91E
			// Note: this type is marked as 'beforefieldinit'.
			static ITokenReader()
			{
				Il2CppClassPointerStore<Tokenizer.ITokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "ITokenReader");
				Tokenizer.ITokenReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.ITokenReader>.NativeClassPtr, 100669453);
			}

			// Token: 0x06005A6D RID: 23149 RVA: 0x0019D53C File Offset: 0x0019B73C
			[CallerCount(0)]
			public unsafe virtual int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tokenizer.ITokenReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A6E RID: 23150 RVA: 0x00020748 File Offset: 0x0001E948
			public ITokenReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040049F7 RID: 18935
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0;
		}

		// Token: 0x0200065E RID: 1630
		public class StreamTokenReader : Object
		{
			// Token: 0x06005A6F RID: 23151 RVA: 0x0019D584 File Offset: 0x0019B784
			// Note: this type is marked as 'beforefieldinit'.
			static StreamTokenReader()
			{
				Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StreamTokenReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr);
				Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, "_in");
				Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, "_numCharRead");
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100669454);
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100669455);
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100669456);
			}

			// Token: 0x06005A70 RID: 23152 RVA: 0x0019D614 File Offset: 0x0019B814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StreamTokenReader(StreamReader input)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StreamTokenReader.NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A71 RID: 23153 RVA: 0x0019D660 File Offset: 0x0019B860
			[CallerCount(0)]
			public unsafe virtual int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tokenizer.StreamTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001718 RID: 5912
			// (get) Token: 0x06005A72 RID: 23154 RVA: 0x0019D6A8 File Offset: 0x0019B8A8
			public unsafe int NumCharEncountered
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StreamTokenReader.NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A73 RID: 23155 RVA: 0x00020751 File Offset: 0x0001E951
			public StreamTokenReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001716 RID: 5910
			// (get) Token: 0x06005A74 RID: 23156 RVA: 0x0019D6E4 File Offset: 0x0019B8E4
			// (set) Token: 0x06005A75 RID: 23157 RVA: 0x0002075A File Offset: 0x0001E95A
			public unsafe StreamReader _in
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001717 RID: 5911
			// (get) Token: 0x06005A76 RID: 23158 RVA: 0x0019D714 File Offset: 0x0019B914
			// (set) Token: 0x06005A77 RID: 23159 RVA: 0x00020779 File Offset: 0x0001E979
			public unsafe int _numCharRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead)) = value;
				}
			}

			// Token: 0x040049F8 RID: 18936
			private static readonly IntPtr NativeFieldInfoPtr__in;

			// Token: 0x040049F9 RID: 18937
			private static readonly IntPtr NativeFieldInfoPtr__numCharRead;

			// Token: 0x040049FA RID: 18938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0;

			// Token: 0x040049FB RID: 18939
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

			// Token: 0x040049FC RID: 18940
			private static readonly IntPtr NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0;
		}
	}
}
