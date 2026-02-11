using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200008B RID: 139
	public sealed class RegexTree : Object
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x00044300 File Offset: 0x00042500
		// Note: this type is marked as 'beforefieldinit'.
		static RegexTree()
		{
			Il2CppClassPointerStore<RegexTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexTree>.NativeClassPtr);
			RegexTree.NativeFieldInfoPtr_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "Root");
			RegexTree.NativeFieldInfoPtr_Caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "Caps");
			RegexTree.NativeFieldInfoPtr_CapNumList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "CapNumList");
			RegexTree.NativeFieldInfoPtr_CapTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "CapTop");
			RegexTree.NativeFieldInfoPtr_CapNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "CapNames");
			RegexTree.NativeFieldInfoPtr_CapsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "CapsList");
			RegexTree.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "Options");
			RegexTree.NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, 100664890);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000443D0 File Offset: 0x000425D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442385, XrefRangeEnd = 442391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexTree(RegexNode root, Hashtable caps, Il2CppStructArray<int> capNumList, int capTop, Hashtable capNames, Il2CppStringArray capsList, RegexOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexTree>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capNumList);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capTop;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capNames);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capsList);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexTree.NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0000598D File Offset: 0x00003B8D
		public RegexTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00044484 File Offset: 0x00042684
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00005996 File Offset: 0x00003B96
		public unsafe RegexNode Root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_Root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_Root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000444B4 File Offset: 0x000426B4
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x000059B5 File Offset: 0x00003BB5
		public unsafe Hashtable Caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_Caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_Caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000444E4 File Offset: 0x000426E4
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x000059D4 File Offset: 0x00003BD4
		public unsafe Il2CppStructArray<int> CapNumList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapNumList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapNumList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00044514 File Offset: 0x00042714
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000059F3 File Offset: 0x00003BF3
		public unsafe int CapTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapTop)) = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0004453C File Offset: 0x0004273C
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00005A0E File Offset: 0x00003C0E
		public unsafe Hashtable CapNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0004456C File Offset: 0x0004276C
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00005A2D File Offset: 0x00003C2D
		public unsafe Il2CppStringArray CapsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_CapsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0004459C File Offset: 0x0004279C
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00005A4C File Offset: 0x00003C4C
		public unsafe RegexOptions Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_Options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr_Options)) = value;
			}
		}

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_Root;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeFieldInfoPtr_Caps;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_CapNumList;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeFieldInfoPtr_CapTop;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeFieldInfoPtr_CapNames;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeFieldInfoPtr_CapsList;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0;
	}
}
