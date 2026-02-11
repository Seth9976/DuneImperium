using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000028 RID: 40
	public static class ResourceManagerConfig : Object
	{
		// Token: 0x06000217 RID: 535 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManagerConfig()
		{
			Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "ResourceManagerConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr);
			ResourceManagerConfig.NativeMethodInfoPtr_ExtractKeyAndSubKey_Public_Static_Boolean_Object_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663652);
			ResourceManagerConfig.NativeMethodInfoPtr_IsPathRemote_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663653);
			ResourceManagerConfig.NativeMethodInfoPtr_StripQueryParameters_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663654);
			ResourceManagerConfig.NativeMethodInfoPtr_ShouldPathUseWebRequest_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663655);
			ResourceManagerConfig.NativeMethodInfoPtr_PlatformCanLoadLocallyFromUrlPath_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663656);
			ResourceManagerConfig.NativeMethodInfoPtr_CreateArrayResult_Public_Static_Array_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663657);
			ResourceManagerConfig.NativeMethodInfoPtr_CreateArrayResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663658);
			ResourceManagerConfig.NativeMethodInfoPtr_CreateListResult_Public_Static_IList_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663659);
			ResourceManagerConfig.NativeMethodInfoPtr_CreateListResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663660);
			ResourceManagerConfig.NativeMethodInfoPtr_IsInstance_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr, 100663661);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1139043, RefRangeEnd = 1139045, XrefRangeStart = 1139032, XrefRangeEnd = 1139043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExtractKeyAndSubKey(Object keyObj, out string mainKey, out string subKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyObj);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.NativeMethodInfoPtr_ExtractKeyAndSubKey_Public_Static_Boolean_Object_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			mainKey = IL2CPP.Il2CppStringToManaged(intPtr);
			subKey = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000D23C File Offset: 0x0000B43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139046, RefRangeEnd = 1139047, XrefRangeStart = 1139045, XrefRangeEnd = 1139046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPathRemote(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.NativeMethodInfoPtr_IsPathRemote_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000D280 File Offset: 0x0000B480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139049, RefRangeEnd = 1139050, XrefRangeStart = 1139047, XrefRangeEnd = 1139049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripQueryParameters(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.NativeMethodInfoPtr_StripQueryParameters_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000D2BC File Offset: 0x0000B4BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1139069, RefRangeEnd = 1139073, XrefRangeStart = 1139050, XrefRangeEnd = 1139069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldPathUseWebRequest(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.NativeMethodInfoPtr_ShouldPathUseWebRequest_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000D300 File Offset: 0x0000B500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139073, XrefRangeEnd = 1139092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlatformCanLoadLocallyFromUrlPath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.NativeMethodInfoPtr_PlatformCanLoadLocallyFromUrlPath_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000D330 File Offset: 0x0000B530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1139102, RefRangeEnd = 1139106, XrefRangeStart = 1139092, XrefRangeEnd = 1139102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateArrayResult(Type type, Il2CppReferenceArray<Object> allAssets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allAssets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.NativeMethodInfoPtr_CreateArrayResult_Public_Static_Array_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000D388 File Offset: 0x0000B588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139106, XrefRangeEnd = 1139115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TObject CreateArrayResult<TObject>(Il2CppReferenceArray<Object> allAssets) where TObject : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allAssets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.MethodInfoStoreGeneric_CreateArrayResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1139129, RefRangeEnd = 1139133, XrefRangeStart = 1139115, XrefRangeEnd = 1139129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList CreateListResult(Type type, Il2CppReferenceArray<Object> allAssets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allAssets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.NativeMethodInfoPtr_CreateListResult_Public_Static_IList_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000D420 File Offset: 0x0000B620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139133, XrefRangeEnd = 1139143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TObject CreateListResult<TObject>(Il2CppReferenceArray<Object> allAssets)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allAssets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.MethodInfoStoreGeneric_CreateListResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000D460 File Offset: 0x0000B660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139143, XrefRangeEnd = 1139151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInstance<T1, T2>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerConfig.MethodInfoStoreGeneric_IsInstance_Public_Static_Boolean_0<T1, T2>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002D8D File Offset: 0x00000F8D
		public ResourceManagerConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_ExtractKeyAndSubKey_Public_Static_Boolean_Object_byref_String_byref_String_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_IsPathRemote_Public_Static_Boolean_String_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_StripQueryParameters_Public_Static_String_String_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_ShouldPathUseWebRequest_Public_Static_Boolean_String_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_PlatformCanLoadLocallyFromUrlPath_Private_Static_Boolean_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_CreateArrayResult_Public_Static_Array_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_CreateArrayResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_CreateListResult_Public_Static_IList_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_CreateListResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_IsInstance_Public_Static_Boolean_0;

		// Token: 0x0200007C RID: 124
		private sealed class MethodInfoStoreGeneric_CreateArrayResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0<TObject>
		{
			// Token: 0x0400046D RID: 1133
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManagerConfig.NativeMethodInfoPtr_CreateArrayResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007D RID: 125
		private sealed class MethodInfoStoreGeneric_CreateListResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0<TObject>
		{
			// Token: 0x0400046E RID: 1134
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManagerConfig.NativeMethodInfoPtr_CreateListResult_Public_Static_TObject_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007E RID: 126
		private sealed class MethodInfoStoreGeneric_IsInstance_Public_Static_Boolean_0<T1, T2>
		{
			// Token: 0x0400046F RID: 1135
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManagerConfig.NativeMethodInfoPtr_IsInstance_Public_Static_Boolean_0, Il2CppClassPointerStore<ResourceManagerConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}
	}
}
