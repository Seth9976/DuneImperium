using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000294 RID: 660
	public class StylePropertyValueMatcher : BaseStyleMatcher
	{
		// Token: 0x0600311F RID: 12575 RVA: 0x000D07B8 File Offset: 0x000CE9B8
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyValueMatcher()
		{
			Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyValueMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr);
			StylePropertyValueMatcher.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, "m_Values");
			StylePropertyValueMatcher.NativeMethodInfoPtr_get_current_Private_get_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670428);
			StylePropertyValueMatcher.NativeMethodInfoPtr_get_valueCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670429);
			StylePropertyValueMatcher.NativeMethodInfoPtr_get_isCurrentVariable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670430);
			StylePropertyValueMatcher.NativeMethodInfoPtr_get_isCurrentComma_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670431);
			StylePropertyValueMatcher.NativeMethodInfoPtr_Match_Public_MatchResult_Expression_List_1_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670432);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchKeyword_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670433);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchNumber_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670434);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchInteger_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670435);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchLength_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670436);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchPercentage_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670437);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchColor_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670438);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchResource_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670439);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchUrl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670440);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchTime_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670441);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchCustomIdent_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670442);
			StylePropertyValueMatcher.NativeMethodInfoPtr_MatchAngle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670443);
			StylePropertyValueMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100670444);
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x000D0950 File Offset: 0x000CEB50
		public unsafe StylePropertyValue current
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 358817, RefRangeEnd = 358819, XrefRangeStart = 358813, XrefRangeEnd = 358817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyValueMatcher.NativeMethodInfoPtr_get_current_Private_get_StylePropertyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StylePropertyValue(intPtr);
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x000D0988 File Offset: 0x000CEB88
		public unsafe override int valueCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358819, XrefRangeEnd = 358820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_get_valueCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x000D09D0 File Offset: 0x000CEBD0
		public unsafe override bool isCurrentVariable
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_get_isCurrentVariable_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x000D0A18 File Offset: 0x000CEC18
		public unsafe override bool isCurrentComma
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358820, XrefRangeEnd = 358821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_get_isCurrentComma_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000D0A60 File Offset: 0x000CEC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358846, RefRangeEnd = 358847, XrefRangeStart = 358821, XrefRangeEnd = 358846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, List<StylePropertyValue> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyValueMatcher.NativeMethodInfoPtr_Match_Public_MatchResult_Expression_List_1_StylePropertyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new MatchResult(intPtr);
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000D0ABC File Offset: 0x000CECBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358847, XrefRangeEnd = 358853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchKeyword_Protected_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000D0B14 File Offset: 0x000CED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358853, XrefRangeEnd = 358858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchNumber_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x000D0B5C File Offset: 0x000CED5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchInteger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchInteger_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x000D0BA4 File Offset: 0x000CEDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358858, XrefRangeEnd = 358864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchLength_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x000D0BEC File Offset: 0x000CEDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358864, XrefRangeEnd = 358870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchPercentage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchPercentage_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x000D0C34 File Offset: 0x000CEE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358870, XrefRangeEnd = 358888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchColor_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000D0C7C File Offset: 0x000CEE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358888, XrefRangeEnd = 358893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchResource_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x000D0CC4 File Offset: 0x000CEEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358893, XrefRangeEnd = 358898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchUrl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchUrl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x000D0D0C File Offset: 0x000CEF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358898, XrefRangeEnd = 358903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchTime_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x000D0D54 File Offset: 0x000CEF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358903, XrefRangeEnd = 358909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchCustomIdent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchCustomIdent_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x000D0D9C File Offset: 0x000CEF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358909, XrefRangeEnd = 358915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyValueMatcher.NativeMethodInfoPtr_MatchAngle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x000D0DE4 File Offset: 0x000CEFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358926, RefRangeEnd = 358927, XrefRangeStart = 358915, XrefRangeEnd = 358926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyValueMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyValueMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x00014091 File Offset: 0x00012291
		public StylePropertyValueMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x000D0E20 File Offset: 0x000CF020
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x0001409A File Offset: 0x0001229A
		public unsafe List<StylePropertyValue> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValueMatcher.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValueMatcher.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Private_get_StylePropertyValue_0;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_get_valueCount_Public_Virtual_get_Int32_0;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentVariable_Public_Virtual_get_Boolean_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentComma_Public_Virtual_get_Boolean_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_MatchResult_Expression_List_1_StylePropertyValue_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeMethodInfoPtr_MatchKeyword_Protected_Virtual_Boolean_String_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeMethodInfoPtr_MatchNumber_Protected_Virtual_Boolean_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeMethodInfoPtr_MatchInteger_Protected_Virtual_Boolean_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Protected_Virtual_Boolean_0;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeMethodInfoPtr_MatchPercentage_Protected_Virtual_Boolean_0;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeMethodInfoPtr_MatchColor_Protected_Virtual_Boolean_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeMethodInfoPtr_MatchResource_Protected_Virtual_Boolean_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_MatchUrl_Protected_Virtual_Boolean_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_MatchTime_Protected_Virtual_Boolean_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_MatchCustomIdent_Protected_Virtual_Boolean_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_MatchAngle_Protected_Virtual_Boolean_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
