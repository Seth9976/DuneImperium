using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using Utils.enums;

namespace Utils
{
	// Token: 0x0200002F RID: 47
	public static class EnumUtil : Object
	{
		// Token: 0x060001CF RID: 463 RVA: 0x0000B5E0 File Offset: 0x000097E0
		// Note: this type is marked as 'beforefieldinit'.
		static EnumUtil()
		{
			Il2CppClassPointerStore<EnumUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "EnumUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr);
			EnumUtil.NativeFieldInfoPtr_enumCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, "enumCache");
			EnumUtil.NativeFieldInfoPtr_locPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, "locPrefix");
			EnumUtil.NativeMethodInfoPtr_getEnumData_Private_Static_EnumData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663561);
			EnumUtil.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663562);
			EnumUtil.NativeMethodInfoPtr_ParseOrDefault_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663563);
			EnumUtil.NativeMethodInfoPtr_ParseOrDefault_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663564);
			EnumUtil.NativeMethodInfoPtr_Parse_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663565);
			EnumUtil.NativeMethodInfoPtr_TryFromInt_Public_Static_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663566);
			EnumUtil.NativeMethodInfoPtr_FromInt_Public_Static_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663567);
			EnumUtil.NativeMethodInfoPtr_FromIntOrDefault_Public_Static_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663568);
			EnumUtil.NativeMethodInfoPtr_Names_Public_Static_ReadOnlyCollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663569);
			EnumUtil.NativeMethodInfoPtr_Values_Public_Static_ReadOnlyCollection_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663570);
			EnumUtil.NativeMethodInfoPtr_IntValues_Public_Static_ReadOnlyCollection_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663571);
			EnumUtil.NativeMethodInfoPtr_IntValue_Public_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663572);
			EnumUtil.NativeMethodInfoPtr_GetName_Public_Static_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663573);
			EnumUtil.NativeMethodInfoPtr_GetName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663574);
			EnumUtil.NativeMethodInfoPtr_LocalizeValue_Public_Static_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663575);
			EnumUtil.NativeMethodInfoPtr_GetLocalizationKey_Public_Static_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663576);
			EnumUtil.NativeMethodInfoPtr_GetAllFlagsValue_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtil>.NativeClassPtr, 100663577);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000B78C File Offset: 0x0000998C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1181374, RefRangeEnd = 1181382, XrefRangeStart = 1181352, XrefRangeEnd = 1181374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnumData<T> getEnumData<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_getEnumData_Private_Static_EnumData_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumData<T>>(intPtr3) : null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181382, XrefRangeEnd = 1181389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse<T>(string s, out T parsed) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
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
				intPtr2 = ref parsed;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				parsed = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000B850 File Offset: 0x00009A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181389, XrefRangeEnd = 1181400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ParseOrDefault<T>(string s) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_ParseOrDefault_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000B890 File Offset: 0x00009A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181400, XrefRangeEnd = 1181411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ParseOrDefault<T>(string s, T defaultValue) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_ParseOrDefault_Public_Static_T_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000B918 File Offset: 0x00009B18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181422, RefRangeEnd = 1181424, XrefRangeStart = 1181411, XrefRangeEnd = 1181422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Parse<T>(string s) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_Parse_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000B958 File Offset: 0x00009B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181424, XrefRangeEnd = 1181438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFromInt<T>(int i, out T result) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
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
				intPtr2 = ref result;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_TryFromInt_Public_Static_Boolean_Int32_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1181448, RefRangeEnd = 1181452, XrefRangeStart = 1181438, XrefRangeEnd = 1181448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FromInt<T>(int i) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_FromInt_Public_Static_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000BA20 File Offset: 0x00009C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181452, XrefRangeEnd = 1181463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FromIntOrDefault<T>(int i, T defaultValue) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_FromIntOrDefault_Public_Static_T_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181463, XrefRangeEnd = 1181467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<string> Names<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_Names_Public_Static_ReadOnlyCollection_1_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<string>>(intPtr3) : null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1181472, RefRangeEnd = 1181492, XrefRangeStart = 1181467, XrefRangeEnd = 1181472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<T> Values<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_Values_Public_Static_ReadOnlyCollection_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000BB0C File Offset: 0x00009D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181497, RefRangeEnd = 1181499, XrefRangeStart = 1181492, XrefRangeEnd = 1181497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<int> IntValues<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_IntValues_Public_Static_ReadOnlyCollection_1_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<int>>(intPtr3) : null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000BB40 File Offset: 0x00009D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181510, RefRangeEnd = 1181512, XrefRangeStart = 1181499, XrefRangeEnd = 1181510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IntValue<T>(T value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_IntValue_Public_Static_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181525, RefRangeEnd = 1181527, XrefRangeStart = 1181512, XrefRangeEnd = 1181525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName<T>(T value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_GetName_Public_Static_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000BC2C File Offset: 0x00009E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181527, XrefRangeEnd = 1181538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName<T>(int value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_GetName_Public_Static_String_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000BC64 File Offset: 0x00009E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181538, XrefRangeEnd = 1181548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LocalizeValue<T>(T value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_LocalizeValue_Public_Static_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181548, XrefRangeEnd = 1181587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizationKey<T>(T value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_GetLocalizationKey_Public_Static_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000BD4C File Offset: 0x00009F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181587, XrefRangeEnd = 1181608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllFlagsValue<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtil.MethodInfoStoreGeneric_GetAllFlagsValue_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000028C5 File Offset: 0x00000AC5
		public EnumUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000BD7C File Offset: 0x00009F7C
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x000028CE File Offset: 0x00000ACE
		public unsafe static ConcurrentDictionary<Type, Object> enumCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumUtil.NativeFieldInfoPtr_enumCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumUtil.NativeFieldInfoPtr_enumCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x000028E0 File Offset: 0x00000AE0
		public unsafe static ConcurrentDictionary<Type, string> locPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumUtil.NativeFieldInfoPtr_locPrefix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumUtil.NativeFieldInfoPtr_locPrefix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_enumCache;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_locPrefix;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_getEnumData_Private_Static_EnumData_1_T_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_T_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_ParseOrDefault_Public_Static_T_String_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_ParseOrDefault_Public_Static_T_String_T_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_T_String_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_TryFromInt_Public_Static_Boolean_Int32_byref_T_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_FromInt_Public_Static_T_Int32_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_FromIntOrDefault_Public_Static_T_Int32_T_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_Names_Public_Static_ReadOnlyCollection_1_String_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_Values_Public_Static_ReadOnlyCollection_1_T_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_IntValues_Public_Static_ReadOnlyCollection_1_Int32_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_IntValue_Public_Static_Int32_T_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_T_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_Int32_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_LocalizeValue_Public_Static_String_T_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizationKey_Public_Static_String_T_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFlagsValue_Public_Static_Int32_0;

		// Token: 0x0200004A RID: 74
		private sealed class MethodInfoStoreGeneric_getEnumData_Private_Static_EnumData_1_T_0<T>
		{
			// Token: 0x040001DE RID: 478
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_getEnumData_Private_Static_EnumData_1_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004B RID: 75
		private sealed class MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_byref_T_0<T>
		{
			// Token: 0x040001DF RID: 479
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004C RID: 76
		private sealed class MethodInfoStoreGeneric_ParseOrDefault_Public_Static_T_String_0<T>
		{
			// Token: 0x040001E0 RID: 480
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_ParseOrDefault_Public_Static_T_String_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004D RID: 77
		private sealed class MethodInfoStoreGeneric_ParseOrDefault_Public_Static_T_String_T_0<T>
		{
			// Token: 0x040001E1 RID: 481
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_ParseOrDefault_Public_Static_T_String_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004E RID: 78
		private sealed class MethodInfoStoreGeneric_Parse_Public_Static_T_String_0<T>
		{
			// Token: 0x040001E2 RID: 482
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_Parse_Public_Static_T_String_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004F RID: 79
		private sealed class MethodInfoStoreGeneric_TryFromInt_Public_Static_Boolean_Int32_byref_T_0<T>
		{
			// Token: 0x040001E3 RID: 483
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_TryFromInt_Public_Static_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000050 RID: 80
		private sealed class MethodInfoStoreGeneric_FromInt_Public_Static_T_Int32_0<T>
		{
			// Token: 0x040001E4 RID: 484
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_FromInt_Public_Static_T_Int32_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000051 RID: 81
		private sealed class MethodInfoStoreGeneric_FromIntOrDefault_Public_Static_T_Int32_T_0<T>
		{
			// Token: 0x040001E5 RID: 485
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_FromIntOrDefault_Public_Static_T_Int32_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000052 RID: 82
		private sealed class MethodInfoStoreGeneric_Names_Public_Static_ReadOnlyCollection_1_String_0<T>
		{
			// Token: 0x040001E6 RID: 486
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_Names_Public_Static_ReadOnlyCollection_1_String_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000053 RID: 83
		private sealed class MethodInfoStoreGeneric_Values_Public_Static_ReadOnlyCollection_1_T_0<T>
		{
			// Token: 0x040001E7 RID: 487
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_Values_Public_Static_ReadOnlyCollection_1_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000054 RID: 84
		private sealed class MethodInfoStoreGeneric_IntValues_Public_Static_ReadOnlyCollection_1_Int32_0<T>
		{
			// Token: 0x040001E8 RID: 488
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_IntValues_Public_Static_ReadOnlyCollection_1_Int32_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000055 RID: 85
		private sealed class MethodInfoStoreGeneric_IntValue_Public_Static_Int32_T_0<T>
		{
			// Token: 0x040001E9 RID: 489
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_IntValue_Public_Static_Int32_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000056 RID: 86
		private sealed class MethodInfoStoreGeneric_GetName_Public_Static_String_T_0<T>
		{
			// Token: 0x040001EA RID: 490
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_GetName_Public_Static_String_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000057 RID: 87
		private sealed class MethodInfoStoreGeneric_GetName_Public_Static_String_Int32_0<T>
		{
			// Token: 0x040001EB RID: 491
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_GetName_Public_Static_String_Int32_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000058 RID: 88
		private sealed class MethodInfoStoreGeneric_LocalizeValue_Public_Static_String_T_0<T>
		{
			// Token: 0x040001EC RID: 492
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_LocalizeValue_Public_Static_String_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000059 RID: 89
		private sealed class MethodInfoStoreGeneric_GetLocalizationKey_Public_Static_String_T_0<T>
		{
			// Token: 0x040001ED RID: 493
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_GetLocalizationKey_Public_Static_String_T_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005A RID: 90
		private sealed class MethodInfoStoreGeneric_GetAllFlagsValue_Public_Static_Int32_0<T>
		{
			// Token: 0x040001EE RID: 494
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtil.NativeMethodInfoPtr_GetAllFlagsValue_Public_Static_Int32_0, Il2CppClassPointerStore<EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
