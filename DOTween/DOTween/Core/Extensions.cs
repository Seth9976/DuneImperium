using System;
using DG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace DG.Tweening.Core
{
	// Token: 0x0200004C RID: 76
	public static class Extensions : Object
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x0001ACAC File Offset: 0x00018EAC
		// Note: this type is marked as 'beforefieldinit'.
		static Extensions()
		{
			Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "Extensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
			Extensions.NativeMethodInfoPtr_SetSpecialStartupMode_Internal_Static_T_T_SpecialStartupMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664227);
			Extensions.NativeMethodInfoPtr_NoFrom_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664228);
			Extensions.NativeMethodInfoPtr_Blendable_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664229);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001AD18 File Offset: 0x00018F18
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1133581, RefRangeEnd = 1133595, XrefRangeStart = 1133581, XrefRangeEnd = 1133581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_SetSpecialStartupMode_Internal_Static_T_T_SpecialStartupMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001AD9C File Offset: 0x00018F9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1133595, RefRangeEnd = 1133599, XrefRangeStart = 1133595, XrefRangeEnd = 1133595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_NoFrom_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001ADE0 File Offset: 0x00018FE0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1133599, RefRangeEnd = 1133608, XrefRangeStart = 1133599, XrefRangeEnd = 1133599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Blendable_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000388B File Offset: 0x00001A8B
		public Extensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialStartupMode_Internal_Static_T_T_SpecialStartupMode_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_NoFrom_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_Blendable_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x020000ED RID: 237
		private sealed class MethodInfoStoreGeneric_SetSpecialStartupMode_Internal_Static_T_T_SpecialStartupMode_0<T>
		{
			// Token: 0x04000645 RID: 1605
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_SetSpecialStartupMode_Internal_Static_T_T_SpecialStartupMode_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000EE RID: 238
		private sealed class MethodInfoStoreGeneric_NoFrom_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000646 RID: 1606
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_NoFrom_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000EF RID: 239
		private sealed class MethodInfoStoreGeneric_Blendable_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000647 RID: 1607
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Blendable_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
