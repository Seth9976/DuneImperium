using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000490 RID: 1168
	public static class EncodingTable : Object
	{
		// Token: 0x0600482F RID: 18479 RVA: 0x00150A84 File Offset: 0x0014EC84
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingTable()
		{
			Il2CppClassPointerStore<EncodingTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "EncodingTable");
			EncodingTable.NativeFieldInfoPtr_encodingDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "encodingDataPtr");
			EncodingTable.NativeFieldInfoPtr_codePageDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "codePageDataPtr");
			EncodingTable.NativeFieldInfoPtr_lastEncodingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "lastEncodingItem");
			EncodingTable.NativeFieldInfoPtr_hashByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByName");
			EncodingTable.NativeFieldInfoPtr_hashByCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByCodePage");
			EncodingTable.NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673880);
			EncodingTable.NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673881);
			EncodingTable.NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673882);
			EncodingTable.NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673884);
			EncodingTable.NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673885);
			EncodingTable.NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673886);
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x00150B88 File Offset: 0x0014ED88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411938, XrefRangeEnd = 1411942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumEncodingItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x00150BB8 File Offset: 0x0014EDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411942, XrefRangeEnd = 1411943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalEncodingDataItem ENC(string name, ushort cp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InternalEncodingDataItem(intPtr);
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x00150C04 File Offset: 0x0014EE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411943, XrefRangeEnd = 1411944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fcp;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(names);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InternalCodePageDataItem(intPtr);
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x00150C6C File Offset: 0x0014EE6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411960, RefRangeEnd = 1411961, XrefRangeStart = 1411944, XrefRangeEnd = 1411960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int internalGetCodePageFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x00150CB0 File Offset: 0x0014EEB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411987, RefRangeEnd = 1411988, XrefRangeStart = 1411961, XrefRangeEnd = 1411987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCodePageFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x00150CF4 File Offset: 0x0014EEF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1412021, RefRangeEnd = 1412023, XrefRangeStart = 1411988, XrefRangeEnd = 1412021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CodePageDataItem GetCodePageDataItem(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CodePageDataItem>(intPtr3) : null;
			}
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x0001A3A3 File Offset: 0x000185A3
		public EncodingTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x00150D34 File Offset: 0x0014EF34
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x0001A3AC File Offset: 0x000185AC
		public unsafe static Il2CppReferenceArray<InternalEncodingDataItem> encodingDataPtr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_encodingDataPtr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalEncodingDataItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_encodingDataPtr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x00150D5C File Offset: 0x0014EF5C
		// (set) Token: 0x0600483A RID: 18490 RVA: 0x0001A3BE File Offset: 0x000185BE
		public unsafe static Il2CppReferenceArray<InternalCodePageDataItem> codePageDataPtr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_codePageDataPtr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalCodePageDataItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_codePageDataPtr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x00150D84 File Offset: 0x0014EF84
		// (set) Token: 0x0600483C RID: 18492 RVA: 0x0001A3D0 File Offset: 0x000185D0
		public unsafe static int lastEncodingItem
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_lastEncodingItem, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_lastEncodingItem, (void*)(&value));
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x00150DA0 File Offset: 0x0014EFA0
		// (set) Token: 0x0600483E RID: 18494 RVA: 0x0001A3DE File Offset: 0x000185DE
		public unsafe static Dictionary<string, int> hashByName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_hashByName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_hashByName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x00150DC8 File Offset: 0x0014EFC8
		// (set) Token: 0x06004840 RID: 18496 RVA: 0x0001A3F0 File Offset: 0x000185F0
		public unsafe static Dictionary<int, CodePageDataItem> hashByCodePage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_hashByCodePage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CodePageDataItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_hashByCodePage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B71 RID: 15217
		private static readonly IntPtr NativeFieldInfoPtr_encodingDataPtr;

		// Token: 0x04003B72 RID: 15218
		private static readonly IntPtr NativeFieldInfoPtr_codePageDataPtr;

		// Token: 0x04003B73 RID: 15219
		private static readonly IntPtr NativeFieldInfoPtr_lastEncodingItem;

		// Token: 0x04003B74 RID: 15220
		private static readonly IntPtr NativeFieldInfoPtr_hashByName;

		// Token: 0x04003B75 RID: 15221
		private static readonly IntPtr NativeFieldInfoPtr_hashByCodePage;

		// Token: 0x04003B76 RID: 15222
		private static readonly IntPtr NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0;

		// Token: 0x04003B77 RID: 15223
		private static readonly IntPtr NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0;

		// Token: 0x04003B78 RID: 15224
		private static readonly IntPtr NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0;

		// Token: 0x04003B79 RID: 15225
		private static readonly IntPtr NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0;

		// Token: 0x04003B7A RID: 15226
		private static readonly IntPtr NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0;

		// Token: 0x04003B7B RID: 15227
		private static readonly IntPtr NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0;
	}
}
