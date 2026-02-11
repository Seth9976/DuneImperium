using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000293 RID: 659
	public class BaseStyleMatcher : Object
	{
		// Token: 0x060030F2 RID: 12530 RVA: 0x000CF9A8 File Offset: 0x000CDBA8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseStyleMatcher()
		{
			Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "BaseStyleMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr);
			BaseStyleMatcher.NativeFieldInfoPtr_s_CustomIdentRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, "s_CustomIdentRegex");
			BaseStyleMatcher.NativeFieldInfoPtr_m_ContextStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, "m_ContextStack");
			BaseStyleMatcher.NativeFieldInfoPtr_m_CurrentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, "m_CurrentContext");
			BaseStyleMatcher.NativeMethodInfoPtr_MatchKeyword_Protected_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670390);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchNumber_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670391);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchInteger_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670392);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchLength_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670393);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchPercentage_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670394);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchColor_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670395);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchResource_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670396);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchUrl_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670397);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchTime_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670398);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchAngle_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670399);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchCustomIdent_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670400);
			BaseStyleMatcher.NativeMethodInfoPtr_get_valueCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670401);
			BaseStyleMatcher.NativeMethodInfoPtr_get_isCurrentVariable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670402);
			BaseStyleMatcher.NativeMethodInfoPtr_get_isCurrentComma_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670403);
			BaseStyleMatcher.NativeMethodInfoPtr_get_hasCurrent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670404);
			BaseStyleMatcher.NativeMethodInfoPtr_get_currentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670405);
			BaseStyleMatcher.NativeMethodInfoPtr_set_currentIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670406);
			BaseStyleMatcher.NativeMethodInfoPtr_get_matchedVariableCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670407);
			BaseStyleMatcher.NativeMethodInfoPtr_set_matchedVariableCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670408);
			BaseStyleMatcher.NativeMethodInfoPtr_Initialize_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670409);
			BaseStyleMatcher.NativeMethodInfoPtr_MoveNext_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670410);
			BaseStyleMatcher.NativeMethodInfoPtr_SaveContext_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670411);
			BaseStyleMatcher.NativeMethodInfoPtr_RestoreContext_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670412);
			BaseStyleMatcher.NativeMethodInfoPtr_DropContext_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670413);
			BaseStyleMatcher.NativeMethodInfoPtr_Match_Protected_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670414);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchExpression_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670415);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchExpressionWithMultiplier_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670416);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchGroup_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670417);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchCombinator_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670418);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchOr_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670419);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchOrOr_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670420);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchAndAnd_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670421);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchMany_Private_Int32_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670422);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchManyByOrder_Private_Int32_Expression_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670423);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchJuxtaposition_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670424);
			BaseStyleMatcher.NativeMethodInfoPtr_MatchDataType_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670425);
			BaseStyleMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100670426);
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x000CFCF8 File Offset: 0x000CDEF8
		[CallerCount(0)]
		public unsafe virtual bool MatchKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchKeyword_Protected_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x000CFD50 File Offset: 0x000CDF50
		[CallerCount(0)]
		public unsafe virtual bool MatchNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchNumber_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000CFD98 File Offset: 0x000CDF98
		[CallerCount(0)]
		public unsafe virtual bool MatchInteger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchInteger_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
		[CallerCount(0)]
		public unsafe virtual bool MatchLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchLength_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000CFE28 File Offset: 0x000CE028
		[CallerCount(0)]
		public unsafe virtual bool MatchPercentage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchPercentage_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000CFE70 File Offset: 0x000CE070
		[CallerCount(0)]
		public unsafe virtual bool MatchColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchColor_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x000CFEB8 File Offset: 0x000CE0B8
		[CallerCount(0)]
		public unsafe virtual bool MatchResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchResource_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000CFF00 File Offset: 0x000CE100
		[CallerCount(0)]
		public unsafe virtual bool MatchUrl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchUrl_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000CFF48 File Offset: 0x000CE148
		[CallerCount(0)]
		public unsafe virtual bool MatchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchTime_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000CFF90 File Offset: 0x000CE190
		[CallerCount(0)]
		public unsafe virtual bool MatchAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchAngle_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000CFFD8 File Offset: 0x000CE1D8
		[CallerCount(0)]
		public unsafe virtual bool MatchCustomIdent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_MatchCustomIdent_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x000D0020 File Offset: 0x000CE220
		public unsafe virtual int valueCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_get_valueCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x000D0068 File Offset: 0x000CE268
		public unsafe virtual bool isCurrentVariable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_get_isCurrentVariable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x000D00B0 File Offset: 0x000CE2B0
		public unsafe virtual bool isCurrentComma
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStyleMatcher.NativeMethodInfoPtr_get_isCurrentComma_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x000D00F8 File Offset: 0x000CE2F8
		public unsafe bool hasCurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_get_hasCurrent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x000D0134 File Offset: 0x000CE334
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x000D0170 File Offset: 0x000CE370
		public unsafe int currentIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_get_currentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_set_currentIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000D01B0 File Offset: 0x000CE3B0
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x000D01EC File Offset: 0x000CE3EC
		public unsafe int matchedVariableCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_get_matchedVariableCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_set_matchedVariableCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x000D022C File Offset: 0x000CE42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358676, XrefRangeEnd = 358680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_Initialize_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x000D0260 File Offset: 0x000CE460
		[CallerCount(0)]
		public unsafe void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MoveNext_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x000D0294 File Offset: 0x000CE494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358680, XrefRangeEnd = 358694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_SaveContext_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x000D02C8 File Offset: 0x000CE4C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358697, RefRangeEnd = 358699, XrefRangeStart = 358694, XrefRangeEnd = 358697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_RestoreContext_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x000D02FC File Offset: 0x000CE4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358699, XrefRangeEnd = 358703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_DropContext_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x000D0330 File Offset: 0x000CE530
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 358711, RefRangeEnd = 358719, XrefRangeStart = 358703, XrefRangeEnd = 358711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_Match_Protected_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000D0380 File Offset: 0x000CE580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358724, RefRangeEnd = 358726, XrefRangeStart = 358719, XrefRangeEnd = 358724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchExpression_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x000D03D0 File Offset: 0x000CE5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358726, XrefRangeEnd = 358728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchExpressionWithMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchExpressionWithMultiplier_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x000D0420 File Offset: 0x000CE620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358728, XrefRangeEnd = 358737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchGroup_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x000D0470 File Offset: 0x000CE670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358768, RefRangeEnd = 358769, XrefRangeStart = 358737, XrefRangeEnd = 358768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchCombinator_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x000D04C0 File Offset: 0x000CE6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358769, XrefRangeEnd = 358775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchOr_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x000D0510 File Offset: 0x000CE710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358775, XrefRangeEnd = 358776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchOrOr_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x000D0560 File Offset: 0x000CE760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358776, XrefRangeEnd = 358777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchAndAnd_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x000D05B0 File Offset: 0x000CE7B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 358789, RefRangeEnd = 358793, XrefRangeStart = 358777, XrefRangeEnd = 358789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchMany_Private_Int32_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x000D0600 File Offset: 0x000CE800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358801, RefRangeEnd = 358802, XrefRangeStart = 358793, XrefRangeEnd = 358801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchManyByOrder(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, int* matchOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = matchOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchManyByOrder_Private_Int32_Expression_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000D065C File Offset: 0x000CE85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358802, XrefRangeEnd = 358804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchJuxtaposition_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000D06AC File Offset: 0x000CE8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358804, RefRangeEnd = 358805, XrefRangeStart = 358804, XrefRangeEnd = 358804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr_MatchDataType_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000D06FC File Offset: 0x000CE8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358805, XrefRangeEnd = 358813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseStyleMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0001403C File Offset: 0x0001223C
		public BaseStyleMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x000D0738 File Offset: 0x000CE938
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x00014045 File Offset: 0x00012245
		public unsafe static Regex s_CustomIdentRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseStyleMatcher.NativeFieldInfoPtr_s_CustomIdentRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseStyleMatcher.NativeFieldInfoPtr_s_CustomIdentRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x000D0760 File Offset: 0x000CE960
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x00014057 File Offset: 0x00012257
		public unsafe Stack<BaseStyleMatcher.MatchContext> m_ContextStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_ContextStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<BaseStyleMatcher.MatchContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_ContextStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x000D0790 File Offset: 0x000CE990
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x00014076 File Offset: 0x00012276
		public unsafe BaseStyleMatcher.MatchContext m_CurrentContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_CurrentContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_CurrentContext)) = value;
			}
		}

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeFieldInfoPtr_s_CustomIdentRegex;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeFieldInfoPtr_m_ContextStack;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentContext;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeMethodInfoPtr_MatchKeyword_Protected_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr_MatchNumber_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeMethodInfoPtr_MatchInteger_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeMethodInfoPtr_MatchPercentage_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeMethodInfoPtr_MatchColor_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeMethodInfoPtr_MatchResource_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeMethodInfoPtr_MatchUrl_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeMethodInfoPtr_MatchTime_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeMethodInfoPtr_MatchAngle_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeMethodInfoPtr_MatchCustomIdent_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeMethodInfoPtr_get_valueCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentVariable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentComma_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeMethodInfoPtr_get_hasCurrent_Public_get_Boolean_0;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeMethodInfoPtr_get_currentIndex_Public_get_Int32_0;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeMethodInfoPtr_set_currentIndex_Public_set_Void_Int32_0;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeMethodInfoPtr_get_matchedVariableCount_Public_get_Int32_0;

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeMethodInfoPtr_set_matchedVariableCount_Public_set_Void_Int32_0;

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_0;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Void_0;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeMethodInfoPtr_SaveContext_Public_Void_0;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeMethodInfoPtr_RestoreContext_Public_Void_0;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeMethodInfoPtr_DropContext_Public_Void_0;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeMethodInfoPtr_Match_Protected_Boolean_Expression_0;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeMethodInfoPtr_MatchExpression_Private_Boolean_Expression_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeMethodInfoPtr_MatchExpressionWithMultiplier_Private_Boolean_Expression_0;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr_MatchGroup_Private_Boolean_Expression_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeMethodInfoPtr_MatchCombinator_Private_Boolean_Expression_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr_MatchOr_Private_Boolean_Expression_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_MatchOrOr_Private_Boolean_Expression_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_MatchAndAnd_Private_Boolean_Expression_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_MatchMany_Private_Int32_Expression_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_MatchManyByOrder_Private_Int32_Expression_ptr_Int32_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_MatchJuxtaposition_Private_Boolean_Expression_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_MatchDataType_Private_Boolean_Expression_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000569 RID: 1385
		[StructLayout(2)]
		public struct MatchContext
		{
			// Token: 0x0600424C RID: 16972 RVA: 0x001044C4 File Offset: 0x001026C4
			// Note: this type is marked as 'beforefieldinit'.
			static MatchContext()
			{
				Il2CppClassPointerStore<BaseStyleMatcher.MatchContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, "MatchContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseStyleMatcher.MatchContext>.NativeClassPtr);
				BaseStyleMatcher.MatchContext.NativeFieldInfoPtr_valueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher.MatchContext>.NativeClassPtr, "valueIndex");
				BaseStyleMatcher.MatchContext.NativeFieldInfoPtr_matchedVariableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher.MatchContext>.NativeClassPtr, "matchedVariableCount");
			}

			// Token: 0x0600424D RID: 16973 RVA: 0x0001C536 File Offset: 0x0001A736
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BaseStyleMatcher.MatchContext>.NativeClassPtr, ref this));
			}

			// Token: 0x04002E7D RID: 11901
			private static readonly IntPtr NativeFieldInfoPtr_valueIndex;

			// Token: 0x04002E7E RID: 11902
			private static readonly IntPtr NativeFieldInfoPtr_matchedVariableCount;

			// Token: 0x04002E7F RID: 11903
			[FieldOffset(0)]
			public int valueIndex;

			// Token: 0x04002E80 RID: 11904
			[FieldOffset(4)]
			public int matchedVariableCount;
		}
	}
}
