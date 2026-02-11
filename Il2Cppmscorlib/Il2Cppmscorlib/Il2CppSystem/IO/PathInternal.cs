using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000527 RID: 1319
	public static class PathInternal : Object
	{
		// Token: 0x0600505D RID: 20573 RVA: 0x00176090 File Offset: 0x00174290
		// Note: this type is marked as 'beforefieldinit'.
		static PathInternal()
		{
			Il2CppClassPointerStore<PathInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PathInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathInternal>.NativeClassPtr);
			PathInternal.NativeFieldInfoPtr_s_isCaseSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, "s_isCaseSensitive");
			PathInternal.NativeMethodInfoPtr_IsValidDriveChar_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675442);
			PathInternal.NativeMethodInfoPtr_EndsWithPeriodOrSpace_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675443);
			PathInternal.NativeMethodInfoPtr_EnsureExtendedPrefixIfNeeded_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675444);
			PathInternal.NativeMethodInfoPtr_EnsureExtendedPrefix_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675445);
			PathInternal.NativeMethodInfoPtr_IsDevice_Internal_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675446);
			PathInternal.NativeMethodInfoPtr_IsDeviceUNC_Internal_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675447);
			PathInternal.NativeMethodInfoPtr_IsExtended_Internal_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675448);
			PathInternal.NativeMethodInfoPtr_GetRootLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675449);
			PathInternal.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675450);
			PathInternal.NativeMethodInfoPtr_IsEffectivelyEmpty_Internal_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675451);
			PathInternal.NativeMethodInfoPtr_EndsInDirectorySeparator_Internal_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675452);
			PathInternal.NativeMethodInfoPtr_StartsWithDirectorySeparator_Internal_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675453);
			PathInternal.NativeMethodInfoPtr_TrimEndingDirectorySeparator_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675454);
			PathInternal.NativeMethodInfoPtr_TrimEndingDirectorySeparator_Internal_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675455);
			PathInternal.NativeMethodInfoPtr_IsRoot_Internal_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675456);
			PathInternal.NativeMethodInfoPtr_GetCommonPathLength_Internal_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675457);
			PathInternal.NativeMethodInfoPtr_EqualStartingCharacterCount_Internal_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675458);
			PathInternal.NativeMethodInfoPtr_AreRootsEqual_Internal_Static_Boolean_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675459);
			PathInternal.NativeMethodInfoPtr_get_IsCaseSensitive_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675460);
			PathInternal.NativeMethodInfoPtr_GetIsCaseSensitive_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675461);
			PathInternal.NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100675462);
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00176278 File Offset: 0x00174478
		[CallerCount(0)]
		public unsafe static bool IsValidDriveChar(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsValidDriveChar_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x001762B8 File Offset: 0x001744B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427751, RefRangeEnd = 1427752, XrefRangeStart = 1427749, XrefRangeEnd = 1427751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWithPeriodOrSpace(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_EndsWithPeriodOrSpace_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x001762FC File Offset: 0x001744FC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1427760, RefRangeEnd = 1427771, XrefRangeStart = 1427752, XrefRangeEnd = 1427760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnsureExtendedPrefixIfNeeded(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_EnsureExtendedPrefixIfNeeded_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x00176338 File Offset: 0x00174538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1427789, RefRangeEnd = 1427793, XrefRangeStart = 1427771, XrefRangeEnd = 1427789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnsureExtendedPrefix(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_EnsureExtendedPrefix_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00176374 File Offset: 0x00174574
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1427798, RefRangeEnd = 1427802, XrefRangeStart = 1427793, XrefRangeEnd = 1427798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDevice(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsDevice_Internal_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x001763BC File Offset: 0x001745BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427802, XrefRangeEnd = 1427809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDeviceUNC(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsDeviceUNC_Internal_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x00176404 File Offset: 0x00174604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427809, XrefRangeEnd = 1427810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsExtended(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsExtended_Internal_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x0017644C File Offset: 0x0017464C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1427829, RefRangeEnd = 1427836, XrefRangeStart = 1427810, XrefRangeEnd = 1427829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRootLength(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_GetRootLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x00176494 File Offset: 0x00174694
		[CallerCount(0)]
		public unsafe static bool IsDirectorySeparator(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x001764D4 File Offset: 0x001746D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427840, RefRangeEnd = 1427841, XrefRangeStart = 1427836, XrefRangeEnd = 1427840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEffectivelyEmpty(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsEffectivelyEmpty_Internal_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x0017651C File Offset: 0x0017471C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1427843, RefRangeEnd = 1427846, XrefRangeStart = 1427841, XrefRangeEnd = 1427843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_EndsInDirectorySeparator_Internal_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x00176564 File Offset: 0x00174764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427848, RefRangeEnd = 1427849, XrefRangeStart = 1427846, XrefRangeEnd = 1427848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_StartsWithDirectorySeparator_Internal_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x001765AC File Offset: 0x001747AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1427870, RefRangeEnd = 1427874, XrefRangeStart = 1427849, XrefRangeEnd = 1427870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimEndingDirectorySeparator(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_TrimEndingDirectorySeparator_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x001765E8 File Offset: 0x001747E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1427894, RefRangeEnd = 1427897, XrefRangeStart = 1427874, XrefRangeEnd = 1427894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_TrimEndingDirectorySeparator_Internal_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x0017662C File Offset: 0x0017482C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1427902, RefRangeEnd = 1427906, XrefRangeStart = 1427897, XrefRangeEnd = 1427902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRoot(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsRoot_Internal_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00176674 File Offset: 0x00174874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427928, RefRangeEnd = 1427929, XrefRangeStart = 1427906, XrefRangeEnd = 1427928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCommonPathLength(string first, string second, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_GetCommonPathLength_Internal_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x001766D8 File Offset: 0x001748D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427929, XrefRangeEnd = 1427938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EqualStartingCharacterCount(string first, string second, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_EqualStartingCharacterCount_Internal_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x0017673C File Offset: 0x0017493C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427951, RefRangeEnd = 1427952, XrefRangeStart = 1427938, XrefRangeEnd = 1427951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreRootsEqual(string first, string second, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_AreRootsEqual_Internal_Static_Boolean_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x001767A0 File Offset: 0x001749A0
		public unsafe static bool IsCaseSensitive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427952, XrefRangeEnd = 1427956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_get_IsCaseSensitive_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x001767D0 File Offset: 0x001749D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427956, XrefRangeEnd = 1427980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsCaseSensitive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_GetIsCaseSensitive_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x00176800 File Offset: 0x00174A00
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPartiallyQualified(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x0001CBCB File Offset: 0x0001ADCB
		public PathInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x00176844 File Offset: 0x00174A44
		// (set) Token: 0x06005075 RID: 20597 RVA: 0x0001CBD4 File Offset: 0x0001ADD4
		public unsafe static bool s_isCaseSensitive
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PathInternal.NativeFieldInfoPtr_s_isCaseSensitive, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathInternal.NativeFieldInfoPtr_s_isCaseSensitive, (void*)(&value));
			}
		}

		// Token: 0x04004193 RID: 16787
		private static readonly IntPtr NativeFieldInfoPtr_s_isCaseSensitive;

		// Token: 0x04004194 RID: 16788
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDriveChar_Internal_Static_Boolean_Char_0;

		// Token: 0x04004195 RID: 16789
		private static readonly IntPtr NativeMethodInfoPtr_EndsWithPeriodOrSpace_Internal_Static_Boolean_String_0;

		// Token: 0x04004196 RID: 16790
		private static readonly IntPtr NativeMethodInfoPtr_EnsureExtendedPrefixIfNeeded_Internal_Static_String_String_0;

		// Token: 0x04004197 RID: 16791
		private static readonly IntPtr NativeMethodInfoPtr_EnsureExtendedPrefix_Internal_Static_String_String_0;

		// Token: 0x04004198 RID: 16792
		private static readonly IntPtr NativeMethodInfoPtr_IsDevice_Internal_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x04004199 RID: 16793
		private static readonly IntPtr NativeMethodInfoPtr_IsDeviceUNC_Internal_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x0400419A RID: 16794
		private static readonly IntPtr NativeMethodInfoPtr_IsExtended_Internal_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x0400419B RID: 16795
		private static readonly IntPtr NativeMethodInfoPtr_GetRootLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0;

		// Token: 0x0400419C RID: 16796
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0;

		// Token: 0x0400419D RID: 16797
		private static readonly IntPtr NativeMethodInfoPtr_IsEffectivelyEmpty_Internal_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x0400419E RID: 16798
		private static readonly IntPtr NativeMethodInfoPtr_EndsInDirectorySeparator_Internal_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x0400419F RID: 16799
		private static readonly IntPtr NativeMethodInfoPtr_StartsWithDirectorySeparator_Internal_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x040041A0 RID: 16800
		private static readonly IntPtr NativeMethodInfoPtr_TrimEndingDirectorySeparator_Internal_Static_String_String_0;

		// Token: 0x040041A1 RID: 16801
		private static readonly IntPtr NativeMethodInfoPtr_TrimEndingDirectorySeparator_Internal_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x040041A2 RID: 16802
		private static readonly IntPtr NativeMethodInfoPtr_IsRoot_Internal_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x040041A3 RID: 16803
		private static readonly IntPtr NativeMethodInfoPtr_GetCommonPathLength_Internal_Static_Int32_String_String_Boolean_0;

		// Token: 0x040041A4 RID: 16804
		private static readonly IntPtr NativeMethodInfoPtr_EqualStartingCharacterCount_Internal_Static_Int32_String_String_Boolean_0;

		// Token: 0x040041A5 RID: 16805
		private static readonly IntPtr NativeMethodInfoPtr_AreRootsEqual_Internal_Static_Boolean_String_String_StringComparison_0;

		// Token: 0x040041A6 RID: 16806
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCaseSensitive_Internal_Static_get_Boolean_0;

		// Token: 0x040041A7 RID: 16807
		private static readonly IntPtr NativeMethodInfoPtr_GetIsCaseSensitive_Private_Static_Boolean_0;

		// Token: 0x040041A8 RID: 16808
		private static readonly IntPtr NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0;
	}
}
