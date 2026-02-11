using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A6 RID: 422
	public static class StyleValueExtensions : Object
	{
		// Token: 0x06002296 RID: 8854 RVA: 0x0009B4C8 File Offset: 0x000996C8
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueExtensions()
		{
			Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr);
			StyleValueExtensions.NativeMethodInfoPtr_DebugString_Internal_Static_String_IStyleValue_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668407);
			StyleValueExtensions.NativeMethodInfoPtr_ToYogaValue_Internal_Static_YogaValue_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668408);
			StyleValueExtensions.NativeMethodInfoPtr_ToLength_Internal_Static_Length_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668409);
			StyleValueExtensions.NativeMethodInfoPtr_ToRotate_Internal_Static_Rotate_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668410);
			StyleValueExtensions.NativeMethodInfoPtr_ToScale_Internal_Static_Scale_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668411);
			StyleValueExtensions.NativeMethodInfoPtr_ToTranslate_Internal_Static_Translate_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668412);
			StyleValueExtensions.NativeMethodInfoPtr_ToLength_Internal_Static_Length_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668413);
			StyleValueExtensions.NativeMethodInfoPtr_CopyFrom_Internal_Static_Void_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100668414);
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0009B598 File Offset: 0x00099798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335852, RefRangeEnd = 335854, XrefRangeStart = 335838, XrefRangeEnd = 335852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DebugString<T>(this IStyleValue<T> styleValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(styleValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.MethodInfoStoreGeneric_DebugString_Internal_Static_String_IStyleValue_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0009B5D4 File Offset: 0x000997D4
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 335867, RefRangeEnd = 335905, XrefRangeStart = 335854, XrefRangeEnd = 335867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Yoga.YogaValue ToYogaValue(this Length length)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.NativeMethodInfoPtr_ToYogaValue_Internal_Static_YogaValue_Length_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0009B614 File Offset: 0x00099814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335905, XrefRangeEnd = 335909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Length ToLength(this StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.NativeMethodInfoPtr_ToLength_Internal_Static_Length_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0009B654 File Offset: 0x00099854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335909, XrefRangeEnd = 335925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rotate ToRotate(this StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.NativeMethodInfoPtr_ToRotate_Internal_Static_Rotate_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0009B694 File Offset: 0x00099894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335925, XrefRangeEnd = 335930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scale ToScale(this StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.NativeMethodInfoPtr_ToScale_Internal_Static_Scale_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x0009B6D4 File Offset: 0x000998D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335930, XrefRangeEnd = 335943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Translate ToTranslate(this StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.NativeMethodInfoPtr_ToTranslate_Internal_Static_Translate_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0009B714 File Offset: 0x00099914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335947, RefRangeEnd = 335949, XrefRangeStart = 335943, XrefRangeEnd = 335947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Length ToLength(this StyleLength styleLength)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref styleLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.NativeMethodInfoPtr_ToLength_Internal_Static_Length_StyleLength_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0009B754 File Offset: 0x00099954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335965, RefRangeEnd = 335966, XrefRangeStart = 335949, XrefRangeEnd = 335965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFrom<T>(this List<T> list, List<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.MethodInfoStoreGeneric_CopyFrom_Internal_Static_Void_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0000E48B File Offset: 0x0000C68B
		public StyleValueExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_DebugString_Internal_Static_String_IStyleValue_1_T_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_ToYogaValue_Internal_Static_YogaValue_Length_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_ToLength_Internal_Static_Length_StyleKeyword_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_ToRotate_Internal_Static_Rotate_StyleKeyword_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_ToScale_Internal_Static_Scale_StyleKeyword_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_ToTranslate_Internal_Static_Translate_StyleKeyword_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_ToLength_Internal_Static_Length_StyleLength_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Internal_Static_Void_List_1_T_List_1_T_0;

		// Token: 0x020004BF RID: 1215
		private sealed class MethodInfoStoreGeneric_DebugString_Internal_Static_String_IStyleValue_1_T_0<T>
		{
			// Token: 0x04002BD9 RID: 11225
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StyleValueExtensions.NativeMethodInfoPtr_DebugString_Internal_Static_String_IStyleValue_1_T_0, Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004C0 RID: 1216
		private sealed class MethodInfoStoreGeneric_CopyFrom_Internal_Static_Void_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04002BDA RID: 11226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StyleValueExtensions.NativeMethodInfoPtr_CopyFrom_Internal_Static_Void_List_1_T_List_1_T_0, Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
