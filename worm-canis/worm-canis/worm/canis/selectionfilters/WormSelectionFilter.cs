using System;
using Canis;
using Canis.attributes;
using Canis.json.events;
using Canis.selectionfilters;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.selectionfilters
{
	// Token: 0x02000010 RID: 16
	public class WormSelectionFilter : SelectionFilter
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0006DD0C File Offset: 0x0006BF0C
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectionFilter()
		{
			Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.selectionfilters", "WormSelectionFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr);
			WormSelectionFilter.NativeFieldInfoPtr_round = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, "round");
			WormSelectionFilter.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, "turn");
			WormSelectionFilter.NativeFieldInfoPtr_prompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, "prompts");
			WormSelectionFilter.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, "match");
			WormSelectionFilter.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, "isValid");
			WormSelectionFilter.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, "attrs");
			WormSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_String_Func_1_Boolean_GetAttrsFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, 100663738);
			WormSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_List_1_String_Func_1_Boolean_GetAttrsFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, 100663739);
			WormSelectionFilter.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, 100663740);
			WormSelectionFilter.NativeMethodInfoPtr_GetAttributes_Public_Virtual_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr, 100663741);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0006DE04 File Offset: 0x0006C004
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 31077, RefRangeEnd = 31095, XrefRangeStart = 31057, XrefRangeEnd = 31077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter(Match m, int round, int turn, string prompt, Func<bool> isValid, GetAttrsFunc attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref round;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isValid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_String_Func_1_Boolean_GetAttrsFunc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0006DEA4 File Offset: 0x0006C0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31095, XrefRangeEnd = 31107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter(Match m, int round, int turn, List<string> prompts, Func<bool> isValid, GetAttrsFunc attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectionFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref round;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompts);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isValid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionFilter.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_List_1_String_Func_1_Boolean_GetAttrsFunc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0006DF44 File Offset: 0x0006C144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31107, XrefRangeEnd = 31142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValid(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionFilter.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_NetworkMessageEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0006DF9C File Offset: 0x0006C19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31142, XrefRangeEnd = 31143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<IAttribute> GetAttributes(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionFilter.NativeMethodInfoPtr_GetAttributes_Public_Virtual_IEnumerable_1_IAttribute_NetworkMessageEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002338 File Offset: 0x00000538
		public WormSelectionFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0006DFF8 File Offset: 0x0006C1F8
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002341 File Offset: 0x00000541
		public unsafe int round
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_round);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_round)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0006E020 File Offset: 0x0006C220
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000235C File Offset: 0x0000055C
		public unsafe int turn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_turn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_turn)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0006E048 File Offset: 0x0006C248
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002377 File Offset: 0x00000577
		public unsafe List<string> prompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_prompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_prompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0006E078 File Offset: 0x0006C278
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002396 File Offset: 0x00000596
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0006E0A8 File Offset: 0x0006C2A8
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000023B5 File Offset: 0x000005B5
		public unsafe Func<bool> isValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_isValid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_isValid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0006E0D8 File Offset: 0x0006C2D8
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000023D4 File Offset: 0x000005D4
		public unsafe GetAttrsFunc attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_attrs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetAttrsFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionFilter.NativeFieldInfoPtr_attrs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_round;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_turn;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_prompts;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_isValid;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_String_Func_1_Boolean_GetAttrsFunc_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_List_1_String_Func_1_Boolean_GetAttrsFunc_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_NetworkMessageEvent_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
	}
}
