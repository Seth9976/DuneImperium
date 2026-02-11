using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Google.Apis.Util
{
	// Token: 0x0200000F RID: 15
	public static class Utilities : Object
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00005928 File Offset: 0x00003B28
		// Note: this type is marked as 'beforefieldinit'.
		static Utilities()
		{
			Il2CppClassPointerStore<Utilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "Utilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utilities>.NativeClassPtr);
			Utilities.NativeMethodInfoPtr_GetLibraryVersion_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663347);
			Utilities.NativeMethodInfoPtr_ThrowIfNull_Public_Static_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663348);
			Utilities.NativeMethodInfoPtr_ThrowIfNullOrEmpty_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663349);
			Utilities.NativeMethodInfoPtr_IsNullOrEmpty_Internal_Static_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663350);
			Utilities.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663351);
			Utilities.NativeMethodInfoPtr_GetStringValue_Internal_Static_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663352);
			Utilities.NativeMethodInfoPtr_GetEnumStringValue_Public_Static_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663353);
			Utilities.NativeMethodInfoPtr_ConvertToString_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663354);
			Utilities.NativeMethodInfoPtr_ConvertToRFC3339_Internal_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663355);
			Utilities.NativeMethodInfoPtr_GetDateTimeFromString_Public_Static_Nullable_1_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663356);
			Utilities.NativeMethodInfoPtr_GetStringFromDateTime_Public_Static_String_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100663357);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005A34 File Offset: 0x00003C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210061, XrefRangeEnd = 1210076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLibraryVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_GetLibraryVersion_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005A60 File Offset: 0x00003C60
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1210076, RefRangeEnd = 1210106, XrefRangeStart = 1210076, XrefRangeEnd = 1210076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ThrowIfNull<T>(this T obj, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Utilities.MethodInfoStoreGeneric_ThrowIfNull_Public_Static_T_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005AE8 File Offset: 0x00003CE8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1210107, RefRangeEnd = 1210116, XrefRangeStart = 1210106, XrefRangeEnd = 1210107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ThrowIfNullOrEmpty(this string str, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_ThrowIfNullOrEmpty_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005B38 File Offset: 0x00003D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210117, RefRangeEnd = 1210118, XrefRangeStart = 1210116, XrefRangeEnd = 1210117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty<T>(this IEnumerable<T> coll)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.MethodInfoStoreGeneric_IsNullOrEmpty_Internal_Static_Boolean_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005B7C File Offset: 0x00003D7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1210126, RefRangeEnd = 1210130, XrefRangeStart = 1210118, XrefRangeEnd = 1210126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttribute<T>(this MemberInfo info) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005BBC File Offset: 0x00003DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210140, RefRangeEnd = 1210141, XrefRangeStart = 1210130, XrefRangeEnd = 1210140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringValue(this Enum value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_GetStringValue_Internal_Static_String_Enum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210140, RefRangeEnd = 1210141, XrefRangeStart = 1210140, XrefRangeEnd = 1210141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnumStringValue(Enum value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_GetEnumStringValue_Public_Static_String_Enum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005C2C File Offset: 0x00003E2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1210155, RefRangeEnd = 1210159, XrefRangeStart = 1210141, XrefRangeEnd = 1210155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConvertToString(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_ConvertToString_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005C68 File Offset: 0x00003E68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1210175, RefRangeEnd = 1210178, XrefRangeStart = 1210159, XrefRangeEnd = 1210175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConvertToRFC3339(DateTime date)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_ConvertToRFC3339_Internal_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210178, XrefRangeEnd = 1210185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<DateTime> GetDateTimeFromString(string raw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(raw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_GetDateTimeFromString_Public_Static_Nullable_1_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTime>(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005CDC File Offset: 0x00003EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210185, XrefRangeEnd = 1210190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringFromDateTime(Nullable<DateTime> date)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(date));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_GetStringFromDateTime_Public_Static_String_Nullable_1_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000226C File Offset: 0x0000046C
		public Utilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetLibraryVersion_Public_Static_String_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfNull_Public_Static_T_T_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfNullOrEmpty_Public_Static_String_String_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Internal_Static_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Internal_Static_String_Enum_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumStringValue_Public_Static_String_Enum_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToString_Public_Static_String_Object_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToRFC3339_Internal_Static_String_DateTime_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeFromString_Public_Static_Nullable_1_DateTime_String_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_GetStringFromDateTime_Public_Static_String_Nullable_1_DateTime_0;

		// Token: 0x02000043 RID: 67
		private sealed class MethodInfoStoreGeneric_ThrowIfNull_Public_Static_T_T_String_0<T>
		{
			// Token: 0x040001D3 RID: 467
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utilities.NativeMethodInfoPtr_ThrowIfNull_Public_Static_T_T_String_0, Il2CppClassPointerStore<Utilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000044 RID: 68
		private sealed class MethodInfoStoreGeneric_IsNullOrEmpty_Internal_Static_Boolean_IEnumerable_1_T_0<T>
		{
			// Token: 0x040001D4 RID: 468
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utilities.NativeMethodInfoPtr_IsNullOrEmpty_Internal_Static_Boolean_IEnumerable_1_T_0, Il2CppClassPointerStore<Utilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000045 RID: 69
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_0<T>
		{
			// Token: 0x040001D5 RID: 469
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utilities.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0, Il2CppClassPointerStore<Utilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
