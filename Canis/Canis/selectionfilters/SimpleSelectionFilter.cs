using System;
using Canis.attributes;
using Canis.context;
using Canis.context.propertiesphrases;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.selectionfilters
{
	// Token: 0x0200005B RID: 91
	public class SimpleSelectionFilter : SelectionFilter
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x0002D998 File Offset: 0x0002BB98
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleSelectionFilter()
		{
			Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "SimpleSelectionFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr);
			SimpleSelectionFilter.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "match");
			SimpleSelectionFilter.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "isValid");
			SimpleSelectionFilter.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "attrs");
			SimpleSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_GetAttrsFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664355);
			SimpleSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_String_Func_1_Boolean_GetAttrsFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664356);
			SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664357);
			SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664358);
			SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_NetworkMessageEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664359);
			SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_3_Match_NetworkMessageEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664360);
			SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664361);
			SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664362);
			SimpleSelectionFilter.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664363);
			SimpleSelectionFilter.NativeMethodInfoPtr_GetAttributes_Public_Virtual_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, 100664364);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0002DACC File Offset: 0x0002BCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554494, XrefRangeEnd = 554502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter(Match m, GetAttrsFunc attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_GetAttrsFunc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0002DB2C File Offset: 0x0002BD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554502, XrefRangeEnd = 554520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter(Match m, int turn, string prompt, Func<bool> isValid, GetAttrsFunc attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isValid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_String_Func_1_Boolean_GetAttrsFunc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0002DBC0 File Offset: 0x0002BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554520, XrefRangeEnd = 554533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter With(Func<bool> validityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validityCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0002DC10 File Offset: 0x0002BE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554533, XrefRangeEnd = 554547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter With(Func<Match, bool> validityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validityCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0002DC60 File Offset: 0x0002BE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554547, XrefRangeEnd = 554560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter With(Func<NetworkMessageEvent, bool> validityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validityCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_NetworkMessageEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554560, XrefRangeEnd = 554574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter With(Func<Match, NetworkMessageEvent, bool> validityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validityCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_3_Match_NetworkMessageEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002DD00 File Offset: 0x0002BF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554574, XrefRangeEnd = 554599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter With(PropertiesPhrase validityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validityCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0002DD50 File Offset: 0x0002BF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554599, XrefRangeEnd = 554620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleSelectionFilter With(Func<Context, bool> validityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validityCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0002DDA0 File Offset: 0x0002BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554620, XrefRangeEnd = 554621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValid(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleSelectionFilter.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_NetworkMessageEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554621, XrefRangeEnd = 554622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<IAttribute> GetAttributes(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleSelectionFilter.NativeMethodInfoPtr_GetAttributes_Public_Virtual_IEnumerable_1_IAttribute_NetworkMessageEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00004525 File Offset: 0x00002725
		public SimpleSelectionFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0002DE54 File Offset: 0x0002C054
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x0000452E File Offset: 0x0000272E
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0002DE84 File Offset: 0x0002C084
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000454D File Offset: 0x0000274D
		public unsafe Func<NetworkMessageEvent, bool> isValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.NativeFieldInfoPtr_isValid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.NativeFieldInfoPtr_isValid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000456C File Offset: 0x0000276C
		public unsafe GetAttrsFunc attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.NativeFieldInfoPtr_attrs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetAttrsFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.NativeFieldInfoPtr_attrs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr_isValid;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_GetAttrsFunc_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_String_Func_1_Boolean_GetAttrsFunc_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_1_Boolean_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_Match_Boolean_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_NetworkMessageEvent_Boolean_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_3_Match_NetworkMessageEvent_Boolean_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_PropertiesPhrase_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_SimpleSelectionFilter_Func_2_Context_Boolean_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_NetworkMessageEvent_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_IEnumerable_1_IAttribute_NetworkMessageEvent_0;

		// Token: 0x020002AB RID: 683
		[ObfuscatedName("Canis.selectionfilters.SimpleSelectionFilter+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06001D08 RID: 7432 RVA: 0x00089264 File Offset: 0x00087464
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr);
				SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_oldIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr, "oldIsValid");
				SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_validityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr, "validityCheck");
				SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_evalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr, "evalContext");
				SimpleSelectionFilter.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr, 100664365);
				SimpleSelectionFilter.__c__DisplayClass10_0.NativeMethodInfoPtr__With_b__0_Internal_Context_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr, 100664366);
				SimpleSelectionFilter.__c__DisplayClass10_0.NativeMethodInfoPtr__With_b__1_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr, 100664367);
			}

			// Token: 0x06001D09 RID: 7433 RVA: 0x0008931C File Offset: 0x0008751C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D0A RID: 7434 RVA: 0x00089358 File Offset: 0x00087558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554456, XrefRangeEnd = 554464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Context _With_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass10_0.NativeMethodInfoPtr__With_b__0_Internal_Context_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
				}
			}

			// Token: 0x06001D0B RID: 7435 RVA: 0x000893A8 File Offset: 0x000875A8
			[CallerCount(0)]
			public unsafe bool _With_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass10_0.NativeMethodInfoPtr__With_b__1_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D0C RID: 7436 RVA: 0x0000DE4E File Offset: 0x0000C04E
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x06001D0D RID: 7437 RVA: 0x000893F8 File Offset: 0x000875F8
			// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0000DE57 File Offset: 0x0000C057
			public unsafe SimpleSelectionFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00089428 File Offset: 0x00087628
			// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0000DE76 File Offset: 0x0000C076
			public unsafe Func<NetworkMessageEvent, bool> oldIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_oldIsValid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_oldIsValid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00089458 File Offset: 0x00087658
			// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0000DE95 File Offset: 0x0000C095
			public unsafe Func<Context, bool> validityCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_validityCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_validityCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00089488 File Offset: 0x00087688
			// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
			public unsafe Func<NetworkMessageEvent, Context> evalContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_evalContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, Context>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass10_0.NativeFieldInfoPtr_evalContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400127D RID: 4733
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400127E RID: 4734
			private static readonly IntPtr NativeFieldInfoPtr_oldIsValid;

			// Token: 0x0400127F RID: 4735
			private static readonly IntPtr NativeFieldInfoPtr_validityCheck;

			// Token: 0x04001280 RID: 4736
			private static readonly IntPtr NativeFieldInfoPtr_evalContext;

			// Token: 0x04001281 RID: 4737
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001282 RID: 4738
			private static readonly IntPtr NativeMethodInfoPtr__With_b__0_Internal_Context_NetworkMessageEvent_0;

			// Token: 0x04001283 RID: 4739
			private static readonly IntPtr NativeMethodInfoPtr__With_b__1_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002AC RID: 684
		[ObfuscatedName("Canis.selectionfilters.SimpleSelectionFilter+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001D15 RID: 7445 RVA: 0x000894B8 File Offset: 0x000876B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr);
				SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr, "turn");
				SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr, "prompt");
				SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr, "isValid");
				SimpleSelectionFilter.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr, 100664368);
				SimpleSelectionFilter.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr, 100664369);
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x0008955C File Offset: 0x0008775C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D17 RID: 7447 RVA: 0x00089598 File Offset: 0x00087798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554464, XrefRangeEnd = 554494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D18 RID: 7448 RVA: 0x0000DED3 File Offset: 0x0000C0D3
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x06001D19 RID: 7449 RVA: 0x000895E8 File Offset: 0x000877E8
			// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0000DEDC File Offset: 0x0000C0DC
			public unsafe SimpleSelectionFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00089618 File Offset: 0x00087818
			// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0000DEFB File Offset: 0x0000C0FB
			public unsafe int turn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_turn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_turn)) = value;
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00089640 File Offset: 0x00087840
			// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0000DF16 File Offset: 0x0000C116
			public unsafe string prompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_prompt);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_prompt), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00089668 File Offset: 0x00087868
			// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000DF35 File Offset: 0x0000C135
			public unsafe Func<bool> isValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_isValid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass4_0.NativeFieldInfoPtr_isValid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001284 RID: 4740
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001285 RID: 4741
			private static readonly IntPtr NativeFieldInfoPtr_turn;

			// Token: 0x04001286 RID: 4742
			private static readonly IntPtr NativeFieldInfoPtr_prompt;

			// Token: 0x04001287 RID: 4743
			private static readonly IntPtr NativeFieldInfoPtr_isValid;

			// Token: 0x04001288 RID: 4744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001289 RID: 4745
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002AD RID: 685
		[ObfuscatedName("Canis.selectionfilters.SimpleSelectionFilter+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001D21 RID: 7457 RVA: 0x00089698 File Offset: 0x00087898
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass5_0>.NativeClassPtr);
				SimpleSelectionFilter.__c__DisplayClass5_0.NativeFieldInfoPtr_oldIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass5_0>.NativeClassPtr, "oldIsValid");
				SimpleSelectionFilter.__c__DisplayClass5_0.NativeFieldInfoPtr_validityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass5_0>.NativeClassPtr, "validityCheck");
				SimpleSelectionFilter.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass5_0>.NativeClassPtr, 100664370);
				SimpleSelectionFilter.__c__DisplayClass5_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass5_0>.NativeClassPtr, 100664371);
			}

			// Token: 0x06001D22 RID: 7458 RVA: 0x00089714 File Offset: 0x00087914
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D23 RID: 7459 RVA: 0x00089750 File Offset: 0x00087950
			[CallerCount(0)]
			public unsafe bool _With_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass5_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D24 RID: 7460 RVA: 0x0000DF54 File Offset: 0x0000C154
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000897A0 File Offset: 0x000879A0
			// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000DF5D File Offset: 0x0000C15D
			public unsafe Func<NetworkMessageEvent, bool> oldIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass5_0.NativeFieldInfoPtr_oldIsValid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass5_0.NativeFieldInfoPtr_oldIsValid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000897D0 File Offset: 0x000879D0
			// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000DF7C File Offset: 0x0000C17C
			public unsafe Func<bool> validityCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass5_0.NativeFieldInfoPtr_validityCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass5_0.NativeFieldInfoPtr_validityCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400128A RID: 4746
			private static readonly IntPtr NativeFieldInfoPtr_oldIsValid;

			// Token: 0x0400128B RID: 4747
			private static readonly IntPtr NativeFieldInfoPtr_validityCheck;

			// Token: 0x0400128C RID: 4748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400128D RID: 4749
			private static readonly IntPtr NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002AE RID: 686
		[ObfuscatedName("Canis.selectionfilters.SimpleSelectionFilter+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06001D29 RID: 7465 RVA: 0x00089800 File Offset: 0x00087A00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr);
				SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr_oldIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr, "oldIsValid");
				SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr_validityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr, "validityCheck");
				SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				SimpleSelectionFilter.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr, 100664372);
				SimpleSelectionFilter.__c__DisplayClass6_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr, 100664373);
			}

			// Token: 0x06001D2A RID: 7466 RVA: 0x00089890 File Offset: 0x00087A90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D2B RID: 7467 RVA: 0x000898CC File Offset: 0x00087ACC
			[CallerCount(0)]
			public unsafe bool _With_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass6_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D2C RID: 7468 RVA: 0x0000DF9B File Offset: 0x0000C19B
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0008991C File Offset: 0x00087B1C
			// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000DFA4 File Offset: 0x0000C1A4
			public unsafe Func<NetworkMessageEvent, bool> oldIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr_oldIsValid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr_oldIsValid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0008994C File Offset: 0x00087B4C
			// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000DFC3 File Offset: 0x0000C1C3
			public unsafe Func<Match, bool> validityCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr_validityCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Match, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr_validityCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0008997C File Offset: 0x00087B7C
			// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000DFE2 File Offset: 0x0000C1E2
			public unsafe SimpleSelectionFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400128E RID: 4750
			private static readonly IntPtr NativeFieldInfoPtr_oldIsValid;

			// Token: 0x0400128F RID: 4751
			private static readonly IntPtr NativeFieldInfoPtr_validityCheck;

			// Token: 0x04001290 RID: 4752
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001291 RID: 4753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001292 RID: 4754
			private static readonly IntPtr NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002AF RID: 687
		[ObfuscatedName("Canis.selectionfilters.SimpleSelectionFilter+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06001D33 RID: 7475 RVA: 0x000899AC File Offset: 0x00087BAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass7_0>.NativeClassPtr);
				SimpleSelectionFilter.__c__DisplayClass7_0.NativeFieldInfoPtr_oldIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass7_0>.NativeClassPtr, "oldIsValid");
				SimpleSelectionFilter.__c__DisplayClass7_0.NativeFieldInfoPtr_validityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass7_0>.NativeClassPtr, "validityCheck");
				SimpleSelectionFilter.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass7_0>.NativeClassPtr, 100664374);
				SimpleSelectionFilter.__c__DisplayClass7_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass7_0>.NativeClassPtr, 100664375);
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x00089A28 File Offset: 0x00087C28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D35 RID: 7477 RVA: 0x00089A64 File Offset: 0x00087C64
			[CallerCount(0)]
			public unsafe bool _With_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass7_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D36 RID: 7478 RVA: 0x0000E001 File Offset: 0x0000C201
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00089AB4 File Offset: 0x00087CB4
			// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000E00A File Offset: 0x0000C20A
			public unsafe Func<NetworkMessageEvent, bool> oldIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass7_0.NativeFieldInfoPtr_oldIsValid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass7_0.NativeFieldInfoPtr_oldIsValid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00089AE4 File Offset: 0x00087CE4
			// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0000E029 File Offset: 0x0000C229
			public unsafe Func<NetworkMessageEvent, bool> validityCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass7_0.NativeFieldInfoPtr_validityCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass7_0.NativeFieldInfoPtr_validityCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001293 RID: 4755
			private static readonly IntPtr NativeFieldInfoPtr_oldIsValid;

			// Token: 0x04001294 RID: 4756
			private static readonly IntPtr NativeFieldInfoPtr_validityCheck;

			// Token: 0x04001295 RID: 4757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001296 RID: 4758
			private static readonly IntPtr NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B0 RID: 688
		[ObfuscatedName("Canis.selectionfilters.SimpleSelectionFilter+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06001D3B RID: 7483 RVA: 0x00089B14 File Offset: 0x00087D14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleSelectionFilter>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr);
				SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr_oldIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr, "oldIsValid");
				SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr_validityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr, "validityCheck");
				SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				SimpleSelectionFilter.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr, 100664376);
				SimpleSelectionFilter.__c__DisplayClass8_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr, 100664377);
			}

			// Token: 0x06001D3C RID: 7484 RVA: 0x00089BA4 File Offset: 0x00087DA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSelectionFilter.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D3D RID: 7485 RVA: 0x00089BE0 File Offset: 0x00087DE0
			[CallerCount(0)]
			public unsafe bool _With_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSelectionFilter.__c__DisplayClass8_0.NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D3E RID: 7486 RVA: 0x0000E048 File Offset: 0x0000C248
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00089C30 File Offset: 0x00087E30
			// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0000E051 File Offset: 0x0000C251
			public unsafe Func<NetworkMessageEvent, bool> oldIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr_oldIsValid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr_oldIsValid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00089C60 File Offset: 0x00087E60
			// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000E070 File Offset: 0x0000C270
			public unsafe Func<Match, NetworkMessageEvent, bool> validityCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr_validityCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Match, NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr_validityCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00089C90 File Offset: 0x00087E90
			// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0000E08F File Offset: 0x0000C28F
			public unsafe SimpleSelectionFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleSelectionFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleSelectionFilter.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001297 RID: 4759
			private static readonly IntPtr NativeFieldInfoPtr_oldIsValid;

			// Token: 0x04001298 RID: 4760
			private static readonly IntPtr NativeFieldInfoPtr_validityCheck;

			// Token: 0x04001299 RID: 4761
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400129A RID: 4762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400129B RID: 4763
			private static readonly IntPtr NativeMethodInfoPtr__With_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}
	}
}
