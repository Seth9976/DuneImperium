using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000146 RID: 326
	public sealed class NoAllocHelpers : Object
	{
		// Token: 0x060018FC RID: 6396 RVA: 0x000758BC File Offset: 0x00073ABC
		// Note: this type is marked as 'beforefieldinit'.
		static NoAllocHelpers()
		{
			Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "NoAllocHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr);
			NoAllocHelpers.NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100666741);
			NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100666742);
			NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100666743);
			NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100666744);
			NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100666745);
			NoAllocHelpers.NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100666746);
			NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100666747);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00075978 File Offset: 0x00073B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666858, XrefRangeEnd = 666861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeList<T>(List<T> list, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ResizeList_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000759BC File Offset: 0x00073BBC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 666867, RefRangeEnd = 666886, XrefRangeStart = 666861, XrefRangeEnd = 666867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureListElemCount<T>(List<T> list, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00075A00 File Offset: 0x00073C00
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 666887, RefRangeEnd = 666927, XrefRangeStart = 666886, XrefRangeEnd = 666887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SafeLength(Array values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00075A44 File Offset: 0x00073C44
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 666928, RefRangeEnd = 666951, XrefRangeStart = 666927, XrefRangeEnd = 666928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SafeLength<T>(List<T> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00075A88 File Offset: 0x00073C88
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 666954, RefRangeEnd = 666981, XrefRangeStart = 666951, XrefRangeEnd = 666954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ExtractArrayFromListT<T>(List<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00075AC4 File Offset: 0x00073CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 666983, RefRangeEnd = 666985, XrefRangeStart = 666981, XrefRangeEnd = 666983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ResizeList(Object list, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00075B08 File Offset: 0x00073D08
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 666987, RefRangeEnd = 667011, XrefRangeStart = 666985, XrefRangeEnd = 666987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array ExtractArrayFromList(Object list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00009C18 File Offset: 0x00007E18
		public NoAllocHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0;

		// Token: 0x02000753 RID: 1875
		private sealed class MethodInfoStoreGeneric_ResizeList_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04002C6B RID: 11371
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000754 RID: 1876
		private sealed class MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04002C6C RID: 11372
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000755 RID: 1877
		private sealed class MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>
		{
			// Token: 0x04002C6D RID: 11373
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000756 RID: 1878
		private sealed class MethodInfoStoreGeneric_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>
		{
			// Token: 0x04002C6E RID: 11374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
