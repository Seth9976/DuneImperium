using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.targetpickers
{
	// Token: 0x02000121 RID: 289
	public class SelectedCustomChoice : TargetPicker<int>
	{
		// Token: 0x06000D4D RID: 3405 RVA: 0x000525A0 File Offset: 0x000507A0
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedCustomChoice()
		{
			Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "SelectedCustomChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr);
			SelectedCustomChoice.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr, "buttons");
			SelectedCustomChoice.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr, "source");
			SelectedCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr, 100666286);
			SelectedCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_Il2CppReferenceArray_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr, 100666287);
			SelectedCustomChoice.NativeMethodInfoPtr_WithSource_Public_SelectedCustomChoice_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr, 100666288);
			SelectedCustomChoice.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr, 100666289);
			SelectedCustomChoice.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr, 100666290);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0005265C File Offset: 0x0005085C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 576373, RefRangeEnd = 576376, XrefRangeStart = 576364, XrefRangeEnd = 576373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedCustomChoice(Match m, [Optional] Il2CppReferenceArray<LocalizableText> buttons)
		{
			if (buttons == null)
			{
				buttons = new Il2CppReferenceArray<LocalizableText>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000526C8 File Offset: 0x000508C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576376, XrefRangeEnd = 576385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedCustomChoice(Match m, bool waitForResponse, [Optional] Il2CppReferenceArray<LocalizableText> buttons)
		{
			if (buttons == null)
			{
				buttons = new Il2CppReferenceArray<LocalizableText>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedCustomChoice>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_Il2CppReferenceArray_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00052740 File Offset: 0x00050940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedCustomChoice WithSource(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedCustomChoice.NativeMethodInfoPtr_WithSource_Public_SelectedCustomChoice_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedCustomChoice>(intPtr3) : null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00052790 File Offset: 0x00050990
		public unsafe override ResponseParser<int> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576385, XrefRangeEnd = 576389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedCustomChoice.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000527DC File Offset: 0x000509DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576389, XrefRangeEnd = 576418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedCustomChoice.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00006C5E File Offset: 0x00004E5E
		public SelectedCustomChoice(Match m, params LocalizableText[] buttons)
			: this(m, new Il2CppReferenceArray<LocalizableText>(buttons))
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00006C6D File Offset: 0x00004E6D
		public SelectedCustomChoice(Match m, bool waitForResponse, params LocalizableText[] buttons)
			: this(m, waitForResponse, new Il2CppReferenceArray<LocalizableText>(buttons))
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00006C7D File Offset: 0x00004E7D
		public SelectedCustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00052828 File Offset: 0x00050A28
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x00006C86 File Offset: 0x00004E86
		public unsafe Il2CppReferenceArray<LocalizableText> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedCustomChoice.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedCustomChoice.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00052858 File Offset: 0x00050A58
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x00006CA5 File Offset: 0x00004EA5
		public unsafe EntityID source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedCustomChoice.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedCustomChoice.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_LocalizableText_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_Il2CppReferenceArray_1_LocalizableText_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_WithSource_Public_SelectedCustomChoice_EntityID_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;
	}
}
