using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000019 RID: 25
	public static class CollectionExtensions : Object
	{
		// Token: 0x060001BB RID: 443 RVA: 0x0000AD50 File Offset: 0x00008F50
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionExtensions()
		{
			Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "CollectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr);
			CollectionExtensions.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_List_1_TSource_List_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100663543);
			CollectionExtensions.NativeMethodInfoPtr_SetValue_Public_Static_Void_List_1_NameValueHeaderValue_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100663544);
			CollectionExtensions.NativeMethodInfoPtr_ToString_Public_Static_String_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100663545);
			CollectionExtensions.NativeMethodInfoPtr_ToStringBuilder_Public_Static_Void_List_1_T_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100663546);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1173045, RefRangeEnd = 1173053, XrefRangeStart = 1173043, XrefRangeEnd = 1173045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SequenceEqual<TSource>(this List<TSource> first, List<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_List_1_TSource_List_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000AE24 File Offset: 0x00009024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173053, XrefRangeEnd = 1173065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValue(this List<NameValueHeaderValue> parameters, string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.NativeMethodInfoPtr_SetValue_Public_Static_Void_List_1_NameValueHeaderValue_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000AE80 File Offset: 0x00009080
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173076, RefRangeEnd = 1173080, XrefRangeStart = 1173065, XrefRangeEnd = 1173076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString<T>(this List<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_ToString_Public_Static_String_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000AEBC File Offset: 0x000090BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173089, RefRangeEnd = 1173093, XrefRangeStart = 1173080, XrefRangeEnd = 1173089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToStringBuilder<T>(this List<T> list, StringBuilder sb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_ToStringBuilder_Public_Static_Void_List_1_T_StringBuilder_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002B89 File Offset: 0x00000D89
		public CollectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_List_1_TSource_List_1_TSource_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Static_Void_List_1_NameValueHeaderValue_String_String_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_List_1_T_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_ToStringBuilder_Public_Static_Void_List_1_T_StringBuilder_0;

		// Token: 0x02000048 RID: 72
		private sealed class MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_List_1_TSource_List_1_TSource_0<TSource>
		{
			// Token: 0x0400032B RID: 811
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_List_1_TSource_List_1_TSource_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000049 RID: 73
		private sealed class MethodInfoStoreGeneric_ToString_Public_Static_String_List_1_T_0<T>
		{
			// Token: 0x0400032C RID: 812
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_ToString_Public_Static_String_List_1_T_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004A RID: 74
		private sealed class MethodInfoStoreGeneric_ToStringBuilder_Public_Static_Void_List_1_T_StringBuilder_0<T>
		{
			// Token: 0x0400032D RID: 813
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_ToStringBuilder_Public_Static_Void_List_1_T_StringBuilder_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
