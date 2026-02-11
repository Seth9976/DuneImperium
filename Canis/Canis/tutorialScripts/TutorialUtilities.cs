using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.tutorialScripts
{
	// Token: 0x02000040 RID: 64
	public static class TutorialUtilities : Object
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x0002A018 File Offset: 0x00028218
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialUtilities()
		{
			Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "TutorialUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr);
			TutorialUtilities.NativeMethodInfoPtr_BuildDialog_Public_Static_T_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664164);
			TutorialUtilities.NativeMethodInfoPtr_BuildVisualHighlight_Public_Static_T_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664165);
			TutorialUtilities.NativeMethodInfoPtr_BuildVisualHighlight_Public_Static_T_Int32_String_byref_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664166);
			TutorialUtilities.NativeMethodInfoPtr_BuildHint_Public_Static_T_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664167);
			TutorialUtilities.NativeMethodInfoPtr_BuildHint_Public_Static_T_Int32_byref_T_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664168);
			TutorialUtilities.NativeMethodInfoPtr_InvokeTutorialEvent_Public_Static_T_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664169);
			TutorialUtilities.NativeMethodInfoPtr_CheckForPrerequisite_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664170);
			TutorialUtilities.NativeMethodInfoPtr_CheckForFTT_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664171);
			TutorialUtilities.NativeMethodInfoPtr_AcknowledgeFTT_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664172);
			TutorialUtilities.NativeMethodInfoPtr_Build_Public_Static_T_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100664173);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0002A110 File Offset: 0x00028310
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 552985, RefRangeEnd = 552990, XrefRangeStart = 552956, XrefRangeEnd = 552985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T BuildDialog<T>(int id, string dialogType, string text, bool blocking) where T : TutorialAction, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_BuildDialog_Public_Static_T_Int32_String_String_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0002A17C File Offset: 0x0002837C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 552999, RefRangeEnd = 553004, XrefRangeStart = 552990, XrefRangeEnd = 552999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T BuildVisualHighlight<T>(int id, string identifier, string scriptType = "VisualHighlight") where T : TutorialAction, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scriptType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_BuildVisualHighlight_Public_Static_T_Int32_String_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0002A1DC File Offset: 0x000283DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 553018, RefRangeEnd = 553022, XrefRangeStart = 553004, XrefRangeEnd = 553018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T BuildVisualHighlight<T>(int id, string identifier, out T hide, string scriptType = "VisualHighlight") where T : TutorialAction, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref hide;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scriptType);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_BuildVisualHighlight_Public_Static_T_Int32_String_byref_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				hide = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0002A28C File Offset: 0x0002848C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 553037, RefRangeEnd = 553040, XrefRangeStart = 553022, XrefRangeEnd = 553037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T BuildHint<T>(int id, [Optional] Il2CppStringArray vfxTags) where T : TutorialAction, new()
		{
			if (vfxTags == null)
			{
				vfxTags = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_BuildHint_Public_Static_T_Int32_Il2CppStringArray_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0002A2E8 File Offset: 0x000284E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 553046, RefRangeEnd = 553047, XrefRangeStart = 553040, XrefRangeEnd = 553046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T BuildHint<T>(int id, out T hide, [Optional] Il2CppStringArray vfxTags) where T : TutorialAction, new()
		{
			if (vfxTags == null)
			{
				vfxTags = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref hide;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_BuildHint_Public_Static_T_Int32_byref_T_Il2CppStringArray_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				hide = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0002A390 File Offset: 0x00028590
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 553052, RefRangeEnd = 553055, XrefRangeStart = 553047, XrefRangeEnd = 553052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T InvokeTutorialEvent<T>(int id, string eventName) where T : TutorialAction, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_InvokeTutorialEvent_Public_Static_T_Int32_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0002A3DC File Offset: 0x000285DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 553069, RefRangeEnd = 553070, XrefRangeStart = 553055, XrefRangeEnd = 553069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CheckForPrerequisite<T>(string prerequisite) where T : TutorialAction, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prerequisite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_CheckForPrerequisite_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0002A41C File Offset: 0x0002861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553070, XrefRangeEnd = 553084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CheckForFTT<T>(string identifier) where T : TutorialAction, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_CheckForFTT_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0002A45C File Offset: 0x0002865C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553084, XrefRangeEnd = 553100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T AcknowledgeFTT<T>(string identifier) where T : TutorialAction, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_AcknowledgeFTT_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0002A49C File Offset: 0x0002869C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 553118, RefRangeEnd = 553126, XrefRangeStart = 553100, XrefRangeEnd = 553118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Build<T>(int id, string scriptType) where T : TutorialAction, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scriptType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.MethodInfoStoreGeneric_Build_Public_Static_T_Int32_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003C90 File Offset: 0x00001E90
		public static T BuildHint<T>(int id, params string[] vfxTags) where T : TutorialAction, new()
		{
			return TutorialUtilities.BuildHint(id, new Il2CppStringArray(vfxTags));
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003C9E File Offset: 0x00001E9E
		public static T BuildHint<T>(int id, out T hide, params string[] vfxTags) where T : TutorialAction, new()
		{
			return TutorialUtilities.BuildHint(id, out hide, new Il2CppStringArray(vfxTags));
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00003CAD File Offset: 0x00001EAD
		public TutorialUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_BuildDialog_Public_Static_T_Int32_String_String_Boolean_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_BuildVisualHighlight_Public_Static_T_Int32_String_String_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_BuildVisualHighlight_Public_Static_T_Int32_String_byref_T_String_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_BuildHint_Public_Static_T_Int32_Il2CppStringArray_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_BuildHint_Public_Static_T_Int32_byref_T_Il2CppStringArray_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTutorialEvent_Public_Static_T_Int32_String_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_CheckForPrerequisite_Public_Static_T_String_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_CheckForFTT_Public_Static_T_String_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_AcknowledgeFTT_Public_Static_T_String_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Static_T_Int32_String_0;

		// Token: 0x02000290 RID: 656
		private sealed class MethodInfoStoreGeneric_BuildDialog_Public_Static_T_Int32_String_String_Boolean_0<T>
		{
			// Token: 0x040011C9 RID: 4553
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_BuildDialog_Public_Static_T_Int32_String_String_Boolean_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000291 RID: 657
		private sealed class MethodInfoStoreGeneric_BuildVisualHighlight_Public_Static_T_Int32_String_String_0<T>
		{
			// Token: 0x040011CA RID: 4554
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_BuildVisualHighlight_Public_Static_T_Int32_String_String_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000292 RID: 658
		private sealed class MethodInfoStoreGeneric_BuildVisualHighlight_Public_Static_T_Int32_String_byref_T_String_0<T>
		{
			// Token: 0x040011CB RID: 4555
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_BuildVisualHighlight_Public_Static_T_Int32_String_byref_T_String_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000293 RID: 659
		private sealed class MethodInfoStoreGeneric_BuildHint_Public_Static_T_Int32_Il2CppStringArray_0<T>
		{
			// Token: 0x040011CC RID: 4556
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_BuildHint_Public_Static_T_Int32_Il2CppStringArray_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000294 RID: 660
		private sealed class MethodInfoStoreGeneric_BuildHint_Public_Static_T_Int32_byref_T_Il2CppStringArray_0<T>
		{
			// Token: 0x040011CD RID: 4557
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_BuildHint_Public_Static_T_Int32_byref_T_Il2CppStringArray_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000295 RID: 661
		private sealed class MethodInfoStoreGeneric_InvokeTutorialEvent_Public_Static_T_Int32_String_0<T>
		{
			// Token: 0x040011CE RID: 4558
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_InvokeTutorialEvent_Public_Static_T_Int32_String_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000296 RID: 662
		private sealed class MethodInfoStoreGeneric_CheckForPrerequisite_Public_Static_T_String_0<T>
		{
			// Token: 0x040011CF RID: 4559
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_CheckForPrerequisite_Public_Static_T_String_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000297 RID: 663
		private sealed class MethodInfoStoreGeneric_CheckForFTT_Public_Static_T_String_0<T>
		{
			// Token: 0x040011D0 RID: 4560
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_CheckForFTT_Public_Static_T_String_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000298 RID: 664
		private sealed class MethodInfoStoreGeneric_AcknowledgeFTT_Public_Static_T_String_0<T>
		{
			// Token: 0x040011D1 RID: 4561
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_AcknowledgeFTT_Public_Static_T_String_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000299 RID: 665
		private sealed class MethodInfoStoreGeneric_Build_Public_Static_T_Int32_String_0<T>
		{
			// Token: 0x040011D2 RID: 4562
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialUtilities.NativeMethodInfoPtr_Build_Public_Static_T_Int32_String_0, Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
