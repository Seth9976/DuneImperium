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
	// Token: 0x02000007 RID: 7
	public static class FastFindOneCache : global::Il2CppSystem.Object
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002860 File Offset: 0x00000A60
		// Note: this type is marked as 'beforefieldinit'.
		static FastFindOneCache()
		{
			Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-finder.dll", "dwd.core.fastFind", "FastFindOneCache");
			FastFindOneCache.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, "cache");
			FastFindOneCache.NativeFieldInfoPtr_componentCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, "componentCache");
			FastFindOneCache.NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100663311);
			FastFindOneCache.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100663312);
			FastFindOneCache.NativeMethodInfoPtr_longFind_Private_Static_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100663313);
			FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100663314);
			FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr, 100663315);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002914 File Offset: 0x00000B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274940, XrefRangeEnd = 1274973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000020 RID: 32 RVA: 0x00002954 File Offset: 0x00000B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1274983, RefRangeEnd = 1274985, XrefRangeStart = 1274973, XrefRangeEnd = 1274983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastFindOneCache.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000297C File Offset: 0x00000B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275021, RefRangeEnd = 1275022, XrefRangeStart = 1274985, XrefRangeEnd = 1275021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000022 RID: 34 RVA: 0x000029E0 File Offset: 0x00000BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275022, XrefRangeEnd = 1275027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Find<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastFindOneCache.MethodInfoStoreGeneric_Find_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002A10 File Offset: 0x00000C10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1275059, RefRangeEnd = 1275066, XrefRangeStart = 1275027, XrefRangeEnd = 1275059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000024 RID: 36 RVA: 0x00002102 File Offset: 0x00000302
		public FastFindOneCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002A90 File Offset: 0x00000C90
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000210B File Offset: 0x0000030B
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002AB8 File Offset: 0x00000CB8
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000211D File Offset: 0x0000031D
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

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_componentCache;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_longFind_Private_Static_Boolean_Type_byref_Component_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_T_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0;

		// Token: 0x02000010 RID: 16
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_T_0<T>
		{
			// Token: 0x04000025 RID: 37
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_T_0, Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000011 RID: 17
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_Boolean_byref_T_0<T>
		{
			// Token: 0x04000026 RID: 38
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FastFindOneCache.NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<FastFindOneCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
