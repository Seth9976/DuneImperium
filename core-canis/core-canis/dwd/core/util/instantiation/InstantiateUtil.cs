using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.util.instantiation
{
	// Token: 0x0200009C RID: 156
	public static class InstantiateUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003BFAC File Offset: 0x0003A1AC
		// Note: this type is marked as 'beforefieldinit'.
		static InstantiateUtil()
		{
			Il2CppClassPointerStore<InstantiateUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util.instantiation", "InstantiateUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstantiateUtil>.NativeClassPtr);
			InstantiateUtil.NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiateUtil>.NativeClassPtr, 100664773);
			InstantiateUtil.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiateUtil>.NativeClassPtr, 100664774);
			InstantiateUtil.NativeMethodInfoPtr_InstantiateInterface_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiateUtil>.NativeClassPtr, 100664775);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0003C018 File Offset: 0x0003A218
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 862946, RefRangeEnd = 862950, XrefRangeStart = 862935, XrefRangeEnd = 862946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject Instantiate(this GameObject prototype, Transform parent = null, bool zeroTransform = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiateUtil.NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0003C07C File Offset: 0x0003A27C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 862960, RefRangeEnd = 862963, XrefRangeStart = 862950, XrefRangeEnd = 862960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(this T prototype, Transform parent = null, bool zeroTransform = true) where T : Component
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = prototype;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prototype;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroTransform;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InstantiateUtil.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0003C110 File Offset: 0x0003A310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862963, XrefRangeEnd = 862982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T InstantiateInterface<T>(this T prototype, Transform parent = null, bool zeroTransform = true) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = prototype;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prototype;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroTransform;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InstantiateUtil.MethodInfoStoreGeneric_InstantiateInterface_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00005D00 File Offset: 0x00003F00
		public InstantiateUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Transform_Boolean_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateInterface_Public_Static_T_T_Transform_Boolean_0;

		// Token: 0x02000290 RID: 656
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>
		{
			// Token: 0x0400160C RID: 5644
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InstantiateUtil.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<InstantiateUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000291 RID: 657
		private sealed class MethodInfoStoreGeneric_InstantiateInterface_Public_Static_T_T_Transform_Boolean_0<T>
		{
			// Token: 0x0400160D RID: 5645
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InstantiateUtil.NativeMethodInfoPtr_InstantiateInterface_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<InstantiateUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
