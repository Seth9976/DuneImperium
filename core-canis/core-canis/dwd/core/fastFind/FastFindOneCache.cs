using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace dwd.core.fastFind
{
	// Token: 0x020001A7 RID: 423
	public static class FastFindOneCache : global::Il2CppSystem.Object
	{
		// Token: 0x0600180C RID: 6156 RVA: 0x000741E4 File Offset: 0x000723E4
		// Note: this type is marked as 'beforefieldinit'.
		static FastFindOneCache()
		{
			Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.fastFind", "FastFindOneCache");
			FastFindOneCache.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, "cache");
			FastFindOneCache.NativeFieldInfoPtr_componentCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, "componentCache");
			FastFindOneCache.NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100667142);
			FastFindOneCache.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100667143);
			FastFindOneCache.NativeMethodInfoPtr_longFind_Private_Static_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100667144);
			FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100667145);
			FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100667146);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00074298 File Offset: 0x00072498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880044, XrefRangeEnd = 880057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastFindOneCache.NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000742D8 File Offset: 0x000724D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880057, XrefRangeEnd = 880067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastFindOneCache.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00074300 File Offset: 0x00072500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880103, RefRangeEnd = 880104, XrefRangeStart = 880067, XrefRangeEnd = 880103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool longFind(Type t, out Component result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastFindOneCache.NativeMethodInfoPtr_longFind_Private_Static_Boolean_Type_byref_Component_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Component(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00074364 File Offset: 0x00072564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880104, XrefRangeEnd = 880109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Find<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastFindOneCache.MethodInfoStoreGeneric_Find_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00074394 File Offset: 0x00072594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880141, RefRangeEnd = 880142, XrefRangeStart = 880109, XrefRangeEnd = 880141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Find<T>(out T result) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FastFindOneCache.MethodInfoStoreGeneric_Find_Public_Static_Boolean_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0000A8F9 File Offset: 0x00008AF9
		public FastFindOneCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x00074414 File Offset: 0x00072614
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0000A902 File Offset: 0x00008B02
		public unsafe static Dictionary<Type, Component> cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastFindOneCache.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Component>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastFindOneCache.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x0007443C File Offset: 0x0007263C
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0000A914 File Offset: 0x00008B14
		public unsafe static List<Component> componentCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastFindOneCache.NativeFieldInfoPtr_componentCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Component>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastFindOneCache.NativeFieldInfoPtr_componentCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_componentCache;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_longFind_Private_Static_Boolean_Type_byref_Component_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_T_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0;

		// Token: 0x02000351 RID: 849
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_T_0<T>
		{
			// Token: 0x04001A8D RID: 6797
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_T_0, Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000352 RID: 850
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_Boolean_byref_T_0<T>
		{
			// Token: 0x04001A8E RID: 6798
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
