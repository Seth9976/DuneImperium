using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.targetpickers
{
	// Token: 0x0200011D RID: 285
	public class ArchetypeCustomChoice : TargetPicker<int>
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x0005164C File Offset: 0x0004F84C
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeCustomChoice()
		{
			Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "ArchetypeCustomChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr);
			ArchetypeCustomChoice.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, "buttons");
			ArchetypeCustomChoice.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, "source");
			ArchetypeCustomChoice.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, "forced");
			ArchetypeCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, 100666255);
			ArchetypeCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_List_1_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, 100666256);
			ArchetypeCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_List_1_SerializableAttributes_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, 100666257);
			ArchetypeCustomChoice.NativeMethodInfoPtr_WithSource_Public_ArchetypeCustomChoice_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, 100666258);
			ArchetypeCustomChoice.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, 100666259);
			ArchetypeCustomChoice.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr, 100666260);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00051730 File Offset: 0x0004F930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 576035, RefRangeEnd = 576037, XrefRangeStart = 576026, XrefRangeEnd = 576035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoice(Match m, List<SerializableAttributes> buttons)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00051790 File Offset: 0x0004F990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576037, XrefRangeEnd = 576046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoice(Match m, bool forced, List<SerializableAttributes> buttons)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_List_1_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x000517FC File Offset: 0x0004F9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576046, XrefRangeEnd = 576055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoice(Match m, bool forced, List<SerializableAttributes> buttons, bool waitForResponse)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_List_1_SerializableAttributes_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00051878 File Offset: 0x0004FA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576055, XrefRangeEnd = 576056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoice WithSource(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoice.NativeMethodInfoPtr_WithSource_Public_ArchetypeCustomChoice_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoice>(intPtr3) : null;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x000518C8 File Offset: 0x0004FAC8
		public unsafe override ResponseParser<int> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576056, XrefRangeEnd = 576060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoice.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00051914 File Offset: 0x0004FB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576060, XrefRangeEnd = 576092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoice.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000069DB File Offset: 0x00004BDB
		public ArchetypeCustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00051960 File Offset: 0x0004FB60
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x000069E4 File Offset: 0x00004BE4
		public unsafe List<SerializableAttributes> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoice.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializableAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoice.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00051990 File Offset: 0x0004FB90
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00006A03 File Offset: 0x00004C03
		public unsafe EntityID source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoice.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoice.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000519C0 File Offset: 0x0004FBC0
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00006A22 File Offset: 0x00004C22
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoice.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoice.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_SerializableAttributes_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_List_1_SerializableAttributes_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_List_1_SerializableAttributes_Boolean_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_WithSource_Public_ArchetypeCustomChoice_EntityID_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;
	}
}
