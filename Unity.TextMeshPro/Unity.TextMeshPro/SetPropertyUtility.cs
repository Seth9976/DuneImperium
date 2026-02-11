using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000041 RID: 65
	public static class SetPropertyUtility : global::Il2CppSystem.Object
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00023AB0 File Offset: 0x00021CB0
		// Note: this type is marked as 'beforefieldinit'.
		static SetPropertyUtility()
		{
			Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "SetPropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr);
			SetPropertyUtility.NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664194);
			SetPropertyUtility.NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664195);
			SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664196);
			SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664197);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00023B30 File Offset: 0x00021D30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1043755, RefRangeEnd = 1043760, XrefRangeStart = 1043755, XrefRangeEnd = 1043755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetColor(ref Color currentValue, Color newValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00023B7C File Offset: 0x00021D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043760, XrefRangeEnd = 1043772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEquatableStruct<T>(ref T currentValue, T newValue)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00023C20 File Offset: 0x00021E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043779, RefRangeEnd = 1043780, XrefRangeStart = 1043772, XrefRangeEnd = 1043779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetStruct<T>(ref T currentValue, T newValue) where T : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00023CC4 File Offset: 0x00021EC4
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1043782, RefRangeEnd = 1043814, XrefRangeStart = 1043780, XrefRangeEnd = 1043782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000059A9 File Offset: 0x00003BA9
		public SetPropertyUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x0200009C RID: 156
		private sealed class MethodInfoStoreGeneric_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C43 RID: 3139
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009D RID: 157
		private sealed class MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C44 RID: 3140
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009E RID: 158
		private sealed class MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C45 RID: 3141
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
