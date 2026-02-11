using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000489 RID: 1161
	[Serializable]
	public class TextInfo : Object
	{
		// Token: 0x0600472F RID: 18223 RVA: 0x0014C4B8 File Offset: 0x0014A6B8
		// Note: this type is marked as 'beforefieldinit'.
		static TextInfo()
		{
			Il2CppClassPointerStore<TextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInfo>.NativeClassPtr);
			TextInfo.NativeFieldInfoPtr_m_listSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_listSeparator");
			TextInfo.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_isReadOnly");
			TextInfo.NativeFieldInfoPtr_m_cultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_cultureName");
			TextInfo.NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_cultureData");
			TextInfo.NativeFieldInfoPtr_m_textInfoName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_textInfoName");
			TextInfo.NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_IsAsciiCasingSameAsInvariant");
			TextInfo.NativeFieldInfoPtr_s_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "s_Invariant");
			TextInfo.NativeFieldInfoPtr_customCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "customCultureName");
			TextInfo.NativeFieldInfoPtr_m_nDataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_nDataItem");
			TextInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_useUserOverride");
			TextInfo.NativeFieldInfoPtr_m_win32LangID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_win32LangID");
			TextInfo.NativeFieldInfoPtr_wordSeparatorMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "wordSeparatorMask");
			TextInfo.NativeMethodInfoPtr_get_Invariant_Internal_Static_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673732);
			TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673733);
			TextInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673734);
			TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673735);
			TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673736);
			TextInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673737);
			TextInfo.NativeMethodInfoPtr_get_CultureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673738);
			TextInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673739);
			TextInfo.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673740);
			TextInfo.NativeMethodInfoPtr_get_ListSeparator_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673741);
			TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673742);
			TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673743);
			TextInfo.NativeMethodInfoPtr_ToLowerAsciiInvariant_Private_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673744);
			TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673745);
			TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673746);
			TextInfo.NativeMethodInfoPtr_ToUpperAsciiInvariant_Internal_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673747);
			TextInfo.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673748);
			TextInfo.NativeMethodInfoPtr_get_IsAsciiCasingSameAsInvariant_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673749);
			TextInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673750);
			TextInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673751);
			TextInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673752);
			TextInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673753);
			TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673754);
			TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673755);
			TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673756);
			TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673757);
			TextInfo.NativeMethodInfoPtr_ToUpperAsciiInvariant_Internal_Void_ReadOnlySpan_1_Char_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673758);
			TextInfo.NativeMethodInfoPtr_ChangeCase_Internal_Void_ReadOnlySpan_1_Char_Span_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673759);
			TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100673760);
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x0014C81C File Offset: 0x0014AA1C
		public unsafe static TextInfo Invariant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1411192, RefRangeEnd = 1411193, XrefRangeStart = 1411176, XrefRangeEnd = 1411192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_get_Invariant_Internal_Static_get_TextInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0014C850 File Offset: 0x0014AA50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411198, RefRangeEnd = 1411200, XrefRangeStart = 1411193, XrefRangeEnd = 1411198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo(CultureData cultureData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0014C89C File Offset: 0x0014AA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411200, XrefRangeEnd = 1411202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0014C8E4 File Offset: 0x0014AAE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411217, RefRangeEnd = 1411219, XrefRangeStart = 1411202, XrefRangeEnd = 1411217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0014C918 File Offset: 0x0014AB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411219, XrefRangeEnd = 1411220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0014C960 File Offset: 0x0014AB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411220, XrefRangeEnd = 1411225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06004736 RID: 18230 RVA: 0x0014C9A8 File Offset: 0x0014ABA8
		public unsafe string CultureName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_get_CultureName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0014C9E0 File Offset: 0x0014ABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411225, XrefRangeEnd = 1411228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x0014CA2C File Offset: 0x0014AC2C
		[CallerCount(0)]
		public unsafe void SetReadOnlyState(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x0014CA6C File Offset: 0x0014AC6C
		public unsafe virtual string ListSeparator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411228, XrefRangeEnd = 1411229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_get_ListSeparator_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x0014CAB0 File Offset: 0x0014ACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411229, XrefRangeEnd = 1411230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToLower(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x0014CB04 File Offset: 0x0014AD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411230, XrefRangeEnd = 1411235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToLower(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0014CB58 File Offset: 0x0014AD58
		[CallerCount(0)]
		public unsafe static char ToLowerAsciiInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToLowerAsciiInvariant_Private_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x0014CB98 File Offset: 0x0014AD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411235, XrefRangeEnd = 1411236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToUpper(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x0014CBEC File Offset: 0x0014ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411236, XrefRangeEnd = 1411241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToUpper(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0014CC40 File Offset: 0x0014AE40
		[CallerCount(0)]
		public unsafe static char ToUpperAsciiInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToUpperAsciiInvariant_Internal_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0014CC80 File Offset: 0x0014AE80
		[CallerCount(0)]
		public unsafe static bool IsAscii(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x0014CCC0 File Offset: 0x0014AEC0
		public unsafe bool IsAsciiCasingSameAsInvariant
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1411256, RefRangeEnd = 1411258, XrefRangeStart = 1411241, XrefRangeEnd = 1411256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_get_IsAsciiCasingSameAsInvariant_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x0014CCFC File Offset: 0x0014AEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411258, XrefRangeEnd = 1411262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x0014CD54 File Offset: 0x0014AF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x0014CD9C File Offset: 0x0014AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411262, XrefRangeEnd = 1411266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x0014CDE0 File Offset: 0x0014AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x0014CE24 File Offset: 0x0014B024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411266, XrefRangeEnd = 1411271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpperInternal(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x0014CE6C File Offset: 0x0014B06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411271, XrefRangeEnd = 1411276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLowerInternal(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x0014CEB4 File Offset: 0x0014B0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411276, XrefRangeEnd = 1411278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ToUpperInternal(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x0014CF00 File Offset: 0x0014B100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411278, XrefRangeEnd = 1411280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ToLowerInternal(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x0014CF4C File Offset: 0x0014B14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411280, XrefRangeEnd = 1411281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToUpperAsciiInvariant_Internal_Void_ReadOnlySpan_1_Char_Span_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x0014CFAC File Offset: 0x0014B1AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411292, RefRangeEnd = 1411293, XrefRangeStart = 1411281, XrefRangeEnd = 1411292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toUpper;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ChangeCase_Internal_Void_ReadOnlySpan_1_Char_Span_1_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x0014D018 File Offset: 0x0014B218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411293, XrefRangeEnd = 1411296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x00019E26 File Offset: 0x00018026
		public TextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x0014D054 File Offset: 0x0014B254
		// (set) Token: 0x0600474F RID: 18255 RVA: 0x00019E2F File Offset: 0x0001802F
		public unsafe string m_listSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_listSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_listSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06004750 RID: 18256 RVA: 0x0014D07C File Offset: 0x0014B27C
		// (set) Token: 0x06004751 RID: 18257 RVA: 0x00019E4E File Offset: 0x0001804E
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x0014D0A4 File Offset: 0x0014B2A4
		// (set) Token: 0x06004753 RID: 18259 RVA: 0x00019E69 File Offset: 0x00018069
		public unsafe string m_cultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x0014D0CC File Offset: 0x0014B2CC
		// (set) Token: 0x06004755 RID: 18261 RVA: 0x00019E88 File Offset: 0x00018088
		public unsafe CultureData m_cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06004756 RID: 18262 RVA: 0x0014D0FC File Offset: 0x0014B2FC
		// (set) Token: 0x06004757 RID: 18263 RVA: 0x00019EA7 File Offset: 0x000180A7
		public unsafe string m_textInfoName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_textInfoName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_textInfoName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x0014D124 File Offset: 0x0014B324
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x00019EC6 File Offset: 0x000180C6
		public Nullable<bool> m_IsAsciiCasingSameAsInvariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x0014D154 File Offset: 0x0014B354
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x00019EF4 File Offset: 0x000180F4
		public unsafe static TextInfo s_Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInfo.NativeFieldInfoPtr_s_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInfo.NativeFieldInfoPtr_s_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x0014D17C File Offset: 0x0014B37C
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x00019F06 File Offset: 0x00018106
		public unsafe string customCultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_customCultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_customCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x0014D1A4 File Offset: 0x0014B3A4
		// (set) Token: 0x0600475F RID: 18271 RVA: 0x00019F25 File Offset: 0x00018125
		public unsafe int m_nDataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_nDataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_nDataItem)) = value;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x0014D1CC File Offset: 0x0014B3CC
		// (set) Token: 0x06004761 RID: 18273 RVA: 0x00019F40 File Offset: 0x00018140
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x0014D1F4 File Offset: 0x0014B3F4
		// (set) Token: 0x06004763 RID: 18275 RVA: 0x00019F5B File Offset: 0x0001815B
		public unsafe int m_win32LangID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_win32LangID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_win32LangID)) = value;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x0014D21C File Offset: 0x0014B41C
		// (set) Token: 0x06004765 RID: 18277 RVA: 0x00019F76 File Offset: 0x00018176
		public unsafe static int wordSeparatorMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextInfo.NativeFieldInfoPtr_wordSeparatorMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInfo.NativeFieldInfoPtr_wordSeparatorMask, (void*)(&value));
			}
		}

		// Token: 0x04003AB0 RID: 15024
		private static readonly IntPtr NativeFieldInfoPtr_m_listSeparator;

		// Token: 0x04003AB1 RID: 15025
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x04003AB2 RID: 15026
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureName;

		// Token: 0x04003AB3 RID: 15027
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureData;

		// Token: 0x04003AB4 RID: 15028
		private static readonly IntPtr NativeFieldInfoPtr_m_textInfoName;

		// Token: 0x04003AB5 RID: 15029
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant;

		// Token: 0x04003AB6 RID: 15030
		private static readonly IntPtr NativeFieldInfoPtr_s_Invariant;

		// Token: 0x04003AB7 RID: 15031
		private static readonly IntPtr NativeFieldInfoPtr_customCultureName;

		// Token: 0x04003AB8 RID: 15032
		private static readonly IntPtr NativeFieldInfoPtr_m_nDataItem;

		// Token: 0x04003AB9 RID: 15033
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x04003ABA RID: 15034
		private static readonly IntPtr NativeFieldInfoPtr_m_win32LangID;

		// Token: 0x04003ABB RID: 15035
		private static readonly IntPtr NativeFieldInfoPtr_wordSeparatorMask;

		// Token: 0x04003ABC RID: 15036
		private static readonly IntPtr NativeMethodInfoPtr_get_Invariant_Internal_Static_get_TextInfo_0;

		// Token: 0x04003ABD RID: 15037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0;

		// Token: 0x04003ABE RID: 15038
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04003ABF RID: 15039
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_0;

		// Token: 0x04003AC0 RID: 15040
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x04003AC1 RID: 15041
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x04003AC2 RID: 15042
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Public_get_String_0;

		// Token: 0x04003AC3 RID: 15043
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003AC4 RID: 15044
		private static readonly IntPtr NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0;

		// Token: 0x04003AC5 RID: 15045
		private static readonly IntPtr NativeMethodInfoPtr_get_ListSeparator_Public_Virtual_New_get_String_0;

		// Token: 0x04003AC6 RID: 15046
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Virtual_New_Char_Char_0;

		// Token: 0x04003AC7 RID: 15047
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Virtual_New_String_String_0;

		// Token: 0x04003AC8 RID: 15048
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerAsciiInvariant_Private_Static_Char_Char_0;

		// Token: 0x04003AC9 RID: 15049
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Virtual_New_Char_Char_0;

		// Token: 0x04003ACA RID: 15050
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Virtual_New_String_String_0;

		// Token: 0x04003ACB RID: 15051
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperAsciiInvariant_Internal_Static_Char_Char_0;

		// Token: 0x04003ACC RID: 15052
		private static readonly IntPtr NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0;

		// Token: 0x04003ACD RID: 15053
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAsciiCasingSameAsInvariant_Private_get_Boolean_0;

		// Token: 0x04003ACE RID: 15054
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003ACF RID: 15055
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003AD0 RID: 15056
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003AD1 RID: 15057
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04003AD2 RID: 15058
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInternal_Private_String_String_0;

		// Token: 0x04003AD3 RID: 15059
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInternal_Private_String_String_0;

		// Token: 0x04003AD4 RID: 15060
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInternal_Private_Char_Char_0;

		// Token: 0x04003AD5 RID: 15061
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInternal_Private_Char_Char_0;

		// Token: 0x04003AD6 RID: 15062
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperAsciiInvariant_Internal_Void_ReadOnlySpan_1_Char_Span_1_Char_0;

		// Token: 0x04003AD7 RID: 15063
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCase_Internal_Void_ReadOnlySpan_1_Char_Span_1_Char_Boolean_0;

		// Token: 0x04003AD8 RID: 15064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
