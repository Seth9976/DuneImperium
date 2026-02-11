using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D1 RID: 209
	public class JPath : Object
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00069C34 File Offset: 0x00067E34
		// Note: this type is marked as 'beforefieldinit'.
		static JPath()
		{
			Il2CppClassPointerStore<JPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "JPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JPath>.NativeClassPtr);
			JPath.NativeFieldInfoPtr_FloatCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JPath>.NativeClassPtr, "FloatCharacters");
			JPath.NativeFieldInfoPtr__expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JPath>.NativeClassPtr, "_expression");
			JPath.NativeFieldInfoPtr__Filters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JPath>.NativeClassPtr, "<Filters>k__BackingField");
			JPath.NativeFieldInfoPtr__currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JPath>.NativeClassPtr, "_currentIndex");
			JPath.NativeMethodInfoPtr_get_Filters_Public_get_List_1_PathFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666938);
			JPath.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666939);
			JPath.NativeMethodInfoPtr_ParseMain_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666940);
			JPath.NativeMethodInfoPtr_ParsePath_Private_Boolean_List_1_PathFilter_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666941);
			JPath.NativeMethodInfoPtr_CreatePathFilter_Private_Static_PathFilter_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666942);
			JPath.NativeMethodInfoPtr_ParseIndexer_Private_PathFilter_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666943);
			JPath.NativeMethodInfoPtr_ParseArrayIndexer_Private_PathFilter_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666944);
			JPath.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666945);
			JPath.NativeMethodInfoPtr_ParseQuery_Private_PathFilter_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666946);
			JPath.NativeMethodInfoPtr_TryParseExpression_Private_Boolean_byref_List_1_PathFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666947);
			JPath.NativeMethodInfoPtr_CreateUnexpectedCharacterException_Private_JsonException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666948);
			JPath.NativeMethodInfoPtr_ParseSide_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666949);
			JPath.NativeMethodInfoPtr_ParseExpression_Private_QueryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666950);
			JPath.NativeMethodInfoPtr_TryParseValue_Private_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666951);
			JPath.NativeMethodInfoPtr_ReadQuotedString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666952);
			JPath.NativeMethodInfoPtr_ReadRegexString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666953);
			JPath.NativeMethodInfoPtr_Match_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666954);
			JPath.NativeMethodInfoPtr_ParseOperator_Private_QueryOperator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666955);
			JPath.NativeMethodInfoPtr_ParseQuotedField_Private_PathFilter_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666956);
			JPath.NativeMethodInfoPtr_EnsureLength_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666957);
			JPath.NativeMethodInfoPtr_Evaluate_Internal_IEnumerable_1_JToken_JToken_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666958);
			JPath.NativeMethodInfoPtr_Evaluate_Internal_Static_IEnumerable_1_JToken_List_1_PathFilter_JToken_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPath>.NativeClassPtr, 100666959);
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00069E6C File Offset: 0x0006806C
		public unsafe List<PathFilter> Filters
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_get_Filters_Public_get_List_1_PathFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PathFilter>>(intPtr3) : null;
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00069EAC File Offset: 0x000680AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 762807, RefRangeEnd = 762809, XrefRangeStart = 762794, XrefRangeEnd = 762807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JPath(string expression)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JPath>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00069EF8 File Offset: 0x000680F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 762816, RefRangeEnd = 762817, XrefRangeStart = 762809, XrefRangeEnd = 762816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseMain_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00069F2C File Offset: 0x0006812C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 762865, RefRangeEnd = 762866, XrefRangeStart = 762817, XrefRangeEnd = 762865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPartStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref query;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParsePath_Private_Boolean_List_1_PathFilter_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00069F98 File Offset: 0x00068198
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 762873, RefRangeEnd = 762877, XrefRangeStart = 762866, XrefRangeEnd = 762873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathFilter CreatePathFilter(string member, bool scan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_CreatePathFilter_Private_Static_PathFilter_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathFilter>(intPtr3) : null;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00069FEC File Offset: 0x000681EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 762884, RefRangeEnd = 762886, XrefRangeStart = 762877, XrefRangeEnd = 762884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFilter ParseIndexer(char indexerOpenChar, bool scan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexerOpenChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseIndexer_Private_PathFilter_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathFilter>(intPtr3) : null;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0006A048 File Offset: 0x00068248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 762946, RefRangeEnd = 762947, XrefRangeStart = 762886, XrefRangeEnd = 762946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFilter ParseArrayIndexer(char indexerCloseChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexerCloseChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseArrayIndexer_Private_PathFilter_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0006A094 File Offset: 0x00068294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762947, XrefRangeEnd = 762949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EatWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0006A0C8 File Offset: 0x000682C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762949, XrefRangeEnd = 762965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFilter ParseQuery(char indexerCloseChar, bool scan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexerCloseChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseQuery_Private_PathFilter_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathFilter>(intPtr3) : null;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0006A124 File Offset: 0x00068324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 762972, RefRangeEnd = 762973, XrefRangeStart = 762965, XrefRangeEnd = 762972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryParseExpression(out List<PathFilter> expressionPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_TryParseExpression_Private_Boolean_byref_List_1_PathFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				expressionPath = ((intPtr4 == 0) ? null : new List<PathFilter>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0006A184 File Offset: 0x00068384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762973, XrefRangeEnd = 762985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonException CreateUnexpectedCharacterException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_CreateUnexpectedCharacterException_Private_JsonException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonException>(intPtr3) : null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0006A1C4 File Offset: 0x000683C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 762997, RefRangeEnd = 762999, XrefRangeStart = 762985, XrefRangeEnd = 762997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseSide_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0006A204 File Offset: 0x00068404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763036, RefRangeEnd = 763037, XrefRangeStart = 762999, XrefRangeEnd = 763036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueryExpression ParseExpression()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseExpression_Private_QueryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QueryExpression>(intPtr3) : null;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0006A244 File Offset: 0x00068444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763088, RefRangeEnd = 763089, XrefRangeStart = 763037, XrefRangeEnd = 763088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryParseValue(out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_TryParseValue_Private_Boolean_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new Object(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0006A2A4 File Offset: 0x000684A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763104, RefRangeEnd = 763105, XrefRangeStart = 763089, XrefRangeEnd = 763104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadQuotedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ReadQuotedString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0006A2DC File Offset: 0x000684DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763122, RefRangeEnd = 763123, XrefRangeStart = 763105, XrefRangeEnd = 763122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadRegexString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ReadRegexString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0006A314 File Offset: 0x00068514
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 763126, RefRangeEnd = 763131, XrefRangeStart = 763123, XrefRangeEnd = 763126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_Match_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0006A364 File Offset: 0x00068564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763181, RefRangeEnd = 763182, XrefRangeStart = 763131, XrefRangeEnd = 763181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueryOperator ParseOperator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseOperator_Private_QueryOperator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0006A3A0 File Offset: 0x000685A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763182, XrefRangeEnd = 763207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFilter ParseQuotedField(char indexerCloseChar, bool scan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexerCloseChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_ParseQuotedField_Private_PathFilter_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathFilter>(intPtr3) : null;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0006A3FC File Offset: 0x000685FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 763207, RefRangeEnd = 763209, XrefRangeStart = 763207, XrefRangeEnd = 763207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLength(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_EnsureLength_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0006A440 File Offset: 0x00068640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 763213, RefRangeEnd = 763215, XrefRangeStart = 763209, XrefRangeEnd = 763213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_Evaluate_Internal_IEnumerable_1_JToken_JToken_JToken_JsonSelectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0006A4B4 File Offset: 0x000686B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 763234, RefRangeEnd = 763236, XrefRangeStart = 763215, XrefRangeEnd = 763234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPath.NativeMethodInfoPtr_Evaluate_Internal_Static_IEnumerable_1_JToken_List_1_PathFilter_JToken_JToken_JsonSelectSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00007E75 File Offset: 0x00006075
		public JPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0006A530 File Offset: 0x00068730
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x00007E7E File Offset: 0x0000607E
		public unsafe static Il2CppStructArray<char> FloatCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JPath.NativeFieldInfoPtr_FloatCharacters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JPath.NativeFieldInfoPtr_FloatCharacters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0006A558 File Offset: 0x00068758
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x00007E90 File Offset: 0x00006090
		public unsafe string _expression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPath.NativeFieldInfoPtr__expression);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPath.NativeFieldInfoPtr__expression), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0006A580 File Offset: 0x00068780
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x00007EAF File Offset: 0x000060AF
		public unsafe List<PathFilter> _Filters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPath.NativeFieldInfoPtr__Filters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPath.NativeFieldInfoPtr__Filters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x0006A5B0 File Offset: 0x000687B0
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x00007ECE File Offset: 0x000060CE
		public unsafe int _currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPath.NativeFieldInfoPtr__currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPath.NativeFieldInfoPtr__currentIndex)) = value;
			}
		}

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeFieldInfoPtr_FloatCharacters;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeFieldInfoPtr__expression;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeFieldInfoPtr__Filters_k__BackingField;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeFieldInfoPtr__currentIndex;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_get_Filters_Public_get_List_1_PathFilter_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_ParseMain_Private_Void_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_ParsePath_Private_Boolean_List_1_PathFilter_Int32_Boolean_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_CreatePathFilter_Private_Static_PathFilter_String_Boolean_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_ParseIndexer_Private_PathFilter_Char_Boolean_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayIndexer_Private_PathFilter_Char_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_ParseQuery_Private_PathFilter_Char_Boolean_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExpression_Private_Boolean_byref_List_1_PathFilter_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnexpectedCharacterException_Private_JsonException_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_ParseSide_Private_Object_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_ParseExpression_Private_QueryExpression_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Private_Boolean_byref_Object_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_ReadQuotedString_Private_String_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_ReadRegexString_Private_String_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_Match_Private_Boolean_String_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_ParseOperator_Private_QueryOperator_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_ParseQuotedField_Private_PathFilter_Char_Boolean_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLength_Private_Void_String_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Internal_IEnumerable_1_JToken_JToken_JToken_JsonSelectSettings_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Internal_Static_IEnumerable_1_JToken_List_1_PathFilter_JToken_JToken_JsonSelectSettings_0;
	}
}
