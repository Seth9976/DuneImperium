using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000167 RID: 359
	public class ByteMatcher : Object
	{
		// Token: 0x0600189F RID: 6303 RVA: 0x0009A324 File Offset: 0x00098524
		// Note: this type is marked as 'beforefieldinit'.
		static ByteMatcher()
		{
			Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ByteMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr);
			ByteMatcher.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, "map");
			ByteMatcher.NativeFieldInfoPtr_starts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, "starts");
			ByteMatcher.NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667563);
			ByteMatcher.NativeMethodInfoPtr_Sort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667564);
			ByteMatcher.NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667565);
			ByteMatcher.NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667566);
			ByteMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667567);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0009A3E0 File Offset: 0x000985E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349463, RefRangeEnd = 1349465, XrefRangeStart = 1349454, XrefRangeEnd = 1349463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMapping(TermInfoStrings key, Il2CppStructArray<byte> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0009A430 File Offset: 0x00098630
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_Sort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0009A464 File Offset: 0x00098664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349465, XrefRangeEnd = 1349468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0009A4B0 File Offset: 0x000986B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349486, RefRangeEnd = 1349487, XrefRangeStart = 1349468, XrefRangeEnd = 1349486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoStrings Match(Il2CppStructArray<char> buffer, int offset, int length, out int used)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &used;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0009A528 File Offset: 0x00098728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349487, XrefRangeEnd = 1349496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public ByteMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x0009A564 File Offset: 0x00098764
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x00007DF9 File Offset: 0x00005FF9
		public unsafe Hashtable map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0009A594 File Offset: 0x00098794
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00007E18 File Offset: 0x00006018
		public unsafe Hashtable starts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_starts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_starts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_starts;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
