using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000088 RID: 136
	public sealed class RegexReplacement : Object
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x00042FAC File Offset: 0x000411AC
		// Note: this type is marked as 'beforefieldinit'.
		static RegexReplacement()
		{
			Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexReplacement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr);
			RegexReplacement.NativeFieldInfoPtr_Specials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "Specials");
			RegexReplacement.NativeFieldInfoPtr_LeftPortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "LeftPortion");
			RegexReplacement.NativeFieldInfoPtr_RightPortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "RightPortion");
			RegexReplacement.NativeFieldInfoPtr_LastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "LastGroup");
			RegexReplacement.NativeFieldInfoPtr_WholeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "WholeString");
			RegexReplacement.NativeFieldInfoPtr__strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "_strings");
			RegexReplacement.NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "_rules");
			RegexReplacement.NativeFieldInfoPtr__Pattern_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "<Pattern>k__BackingField");
			RegexReplacement.NativeMethodInfoPtr__ctor_Public_Void_String_RegexNode_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664857);
			RegexReplacement.NativeMethodInfoPtr_GetOrCreate_Public_Static_RegexReplacement_WeakReference_1_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664858);
			RegexReplacement.NativeMethodInfoPtr_get_Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664859);
			RegexReplacement.NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664860);
			RegexReplacement.NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664861);
			RegexReplacement.NativeMethodInfoPtr_Replace_Public_String_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664862);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000430F4 File Offset: 0x000412F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442106, RefRangeEnd = 442107, XrefRangeStart = 442042, XrefRangeEnd = 442106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rep);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(concat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_caps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr__ctor_Public_Void_String_RegexNode_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00043164 File Offset: 0x00041364
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442118, RefRangeEnd = 442122, XrefRangeStart = 442107, XrefRangeEnd = 442118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_GetOrCreate_Public_Static_RegexReplacement_WeakReference_1_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexReplacement>(intPtr3) : null;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000431FC File Offset: 0x000413FC
		public unsafe string Pattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_get_Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00043234 File Offset: 0x00041434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442122, XrefRangeEnd = 442140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplacementImpl(StringBuilder sb, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00043288 File Offset: 0x00041488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442140, XrefRangeEnd = 442161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplacementImplRTL(List<string> al, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(al);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000432DC File Offset: 0x000414DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442232, RefRangeEnd = 442236, XrefRangeStart = 442161, XrefRangeEnd = 442232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(Regex regex, string input, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_Replace_Public_String_Regex_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000056C3 File Offset: 0x000038C3
		public RegexReplacement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00043354 File Offset: 0x00041554
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x000056CC File Offset: 0x000038CC
		public unsafe static int Specials
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexReplacement.NativeFieldInfoPtr_Specials, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexReplacement.NativeFieldInfoPtr_Specials, (void*)(&value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00043370 File Offset: 0x00041570
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x000056DA File Offset: 0x000038DA
		public unsafe static int LeftPortion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexReplacement.NativeFieldInfoPtr_LeftPortion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexReplacement.NativeFieldInfoPtr_LeftPortion, (void*)(&value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0004338C File Offset: 0x0004158C
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x000056E8 File Offset: 0x000038E8
		public unsafe static int RightPortion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexReplacement.NativeFieldInfoPtr_RightPortion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexReplacement.NativeFieldInfoPtr_RightPortion, (void*)(&value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x000433A8 File Offset: 0x000415A8
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x000056F6 File Offset: 0x000038F6
		public unsafe static int LastGroup
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexReplacement.NativeFieldInfoPtr_LastGroup, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexReplacement.NativeFieldInfoPtr_LastGroup, (void*)(&value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000433C4 File Offset: 0x000415C4
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00005704 File Offset: 0x00003904
		public unsafe static int WholeString
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexReplacement.NativeFieldInfoPtr_WholeString, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexReplacement.NativeFieldInfoPtr_WholeString, (void*)(&value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000433E0 File Offset: 0x000415E0
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00005712 File Offset: 0x00003912
		public unsafe List<string> _strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00043410 File Offset: 0x00041610
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00005731 File Offset: 0x00003931
		public unsafe List<int> _rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00043440 File Offset: 0x00041640
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00005750 File Offset: 0x00003950
		public unsafe string _Pattern_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__Pattern_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__Pattern_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_Specials;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_LeftPortion;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_RightPortion;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_LastGroup;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_WholeString;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr__strings;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr__rules;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr__Pattern_k__BackingField;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RegexNode_Hashtable_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_RegexReplacement_WeakReference_1_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Public_get_String_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_Regex_String_Int32_Int32_0;
	}
}
