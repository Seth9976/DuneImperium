using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000078 RID: 120
	[Serializable]
	public class Match : Group
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x00039194 File Offset: 0x00037394
		// Note: this type is marked as 'beforefieldinit'.
		static Match()
		{
			Il2CppClassPointerStore<Match>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Match");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match>.NativeClassPtr);
			Match.NativeFieldInfoPtr__groupcoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_groupcoll");
			Match.NativeFieldInfoPtr__regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_regex");
			Match.NativeFieldInfoPtr__textbeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textbeg");
			Match.NativeFieldInfoPtr__textpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textpos");
			Match.NativeFieldInfoPtr__textend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textend");
			Match.NativeFieldInfoPtr__textstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textstart");
			Match.NativeFieldInfoPtr__matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_matches");
			Match.NativeFieldInfoPtr__matchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_matchcount");
			Match.NativeFieldInfoPtr__balancing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_balancing");
			Match.NativeFieldInfoPtr__Empty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<Empty>k__BackingField");
			Match.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664526);
			Match.NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664527);
			Match.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664528);
			Match.NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664529);
			Match.NativeMethodInfoPtr_NextMatch_Public_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664530);
			Match.NativeMethodInfoPtr_GroupToStringImpl_Internal_Virtual_New_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664531);
			Match.NativeMethodInfoPtr_LastGroupToStringImpl_Internal_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664532);
			Match.NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664533);
			Match.NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664534);
			Match.NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664535);
			Match.NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664536);
			Match.NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664537);
			Match.NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664538);
			Match.NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664539);
			Match.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664541);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000393B8 File Offset: 0x000375B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 437757, RefRangeEnd = 437759, XrefRangeStart = 437736, XrefRangeEnd = 437757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref begpos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00039450 File Offset: 0x00037650
		public unsafe static Match Empty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437759, XrefRangeEnd = 437763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00039484 File Offset: 0x00037684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437763, XrefRangeEnd = 437766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textbeg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textstart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00039510 File Offset: 0x00037710
		public unsafe virtual GroupCollection Groups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437766, XrefRangeEnd = 437773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003955C File Offset: 0x0003775C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 437774, RefRangeEnd = 437776, XrefRangeStart = 437773, XrefRangeEnd = 437774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match NextMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_NextMatch_Public_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0003959C File Offset: 0x0003779C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437776, XrefRangeEnd = 437782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GroupToStringImpl_Internal_Virtual_New_ReadOnlySpan_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000395EC File Offset: 0x000377EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 437782, RefRangeEnd = 437786, XrefRangeStart = 437782, XrefRangeEnd = 437782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan<char> LastGroupToStringImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_LastGroupToStringImpl_Internal_ReadOnlySpan_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<char>(intPtr);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00039624 File Offset: 0x00037824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437786, XrefRangeEnd = 437793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddMatch(int cap, int start, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0003968C File Offset: 0x0003788C
		[CallerCount(0)]
		public unsafe virtual void BalanceMatch(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000396D8 File Offset: 0x000378D8
		[CallerCount(0)]
		public unsafe virtual void RemoveMatch(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00039724 File Offset: 0x00037924
		[CallerCount(0)]
		public unsafe virtual bool IsMatched(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00039778 File Offset: 0x00037978
		[CallerCount(0)]
		public unsafe virtual int MatchIndex(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000397CC File Offset: 0x000379CC
		[CallerCount(0)]
		public unsafe virtual int MatchLength(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00039820 File Offset: 0x00037A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437793, XrefRangeEnd = 437795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Tidy(int textpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref textpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0003986C File Offset: 0x00037A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437795, XrefRangeEnd = 437798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000045DF File Offset: 0x000027DF
		public Match(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000398A8 File Offset: 0x00037AA8
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x000045E8 File Offset: 0x000027E8
		public unsafe GroupCollection _groupcoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__groupcoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__groupcoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000398D8 File Offset: 0x00037AD8
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00004607 File Offset: 0x00002807
		public unsafe Regex _regex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__regex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__regex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00039908 File Offset: 0x00037B08
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00004626 File Offset: 0x00002826
		public unsafe int _textbeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textbeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textbeg)) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00039930 File Offset: 0x00037B30
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00004641 File Offset: 0x00002841
		public unsafe int _textpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textpos)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00039958 File Offset: 0x00037B58
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x0000465C File Offset: 0x0000285C
		public unsafe int _textend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textend)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00039980 File Offset: 0x00037B80
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00004677 File Offset: 0x00002877
		public unsafe int _textstart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textstart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textstart)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000399A8 File Offset: 0x00037BA8
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00004692 File Offset: 0x00002892
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> _matches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000399D8 File Offset: 0x00037BD8
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x000046B1 File Offset: 0x000028B1
		public unsafe Il2CppStructArray<int> _matchcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchcount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchcount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00039A08 File Offset: 0x00037C08
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x000046D0 File Offset: 0x000028D0
		public unsafe bool _balancing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__balancing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__balancing)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00039A30 File Offset: 0x00037C30
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x000046EB File Offset: 0x000028EB
		public unsafe static Match _Empty_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Match.NativeFieldInfoPtr__Empty_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Match.NativeFieldInfoPtr__Empty_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeFieldInfoPtr__groupcoll;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr__regex;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr__textbeg;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr__textpos;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr__textend;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr__textstart;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr__matches;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr__matchcount;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr__balancing;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr__Empty_k__BackingField;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_NextMatch_Public_Match_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_GroupToStringImpl_Internal_Virtual_New_ReadOnlySpan_1_Char_Int32_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_LastGroupToStringImpl_Internal_ReadOnlySpan_1_Char_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
