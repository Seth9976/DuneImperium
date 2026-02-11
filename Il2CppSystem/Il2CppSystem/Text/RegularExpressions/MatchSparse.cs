using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000079 RID: 121
	public class MatchSparse : Match
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x00039A58 File Offset: 0x00037C58
		// Note: this type is marked as 'beforefieldinit'.
		static MatchSparse()
		{
			Il2CppClassPointerStore<MatchSparse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchSparse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr);
			MatchSparse.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, "_caps");
			MatchSparse.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, 100664542);
			MatchSparse.NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, 100664543);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00039AC4 File Offset: 0x00037CC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437803, RefRangeEnd = 437804, XrefRangeStart = 437798, XrefRangeEnd = 437803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref begpos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchSparse.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00039B6C File Offset: 0x00037D6C
		public unsafe override GroupCollection Groups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437804, XrefRangeEnd = 437811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchSparse.NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000046FD File Offset: 0x000028FD
		public MatchSparse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00039BB8 File Offset: 0x00037DB8
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00004706 File Offset: 0x00002906
		public new unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSparse.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSparse.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0;
	}
}
