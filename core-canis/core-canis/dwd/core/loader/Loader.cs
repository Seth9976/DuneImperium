using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace dwd.core.loader
{
	// Token: 0x0200017E RID: 382
	public class Loader : MonoBehaviour
	{
		// Token: 0x060015B9 RID: 5561 RVA: 0x0006B020 File Offset: 0x00069220
		// Note: this type is marked as 'beforefieldinit'.
		static Loader()
		{
			Il2CppClassPointerStore<Loader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "Loader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader>.NativeClassPtr);
			Loader.NativeFieldInfoPtr_loaderStrategies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader>.NativeClassPtr, "loaderStrategies");
			Loader.NativeFieldInfoPtr_strategyLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader>.NativeClassPtr, "strategyLookup");
			Loader.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<Instance>k__BackingField");
			Loader.NativeFieldInfoPtr_DefaultLoadStrategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader>.NativeClassPtr, "DefaultLoadStrategyName");
			Loader.NativeMethodInfoPtr_get_Instance_Private_Static_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666582);
			Loader.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666583);
			Loader.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666584);
			Loader.NativeMethodInfoPtr_assertSerializedStrategyIsValid_Private_Void_SerializedLoaderStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666585);
			Loader.NativeMethodInfoPtr_SetDefaultLoaderStrategy_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666586);
			Loader.NativeMethodInfoPtr_guaranteeDefaultInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666587);
			Loader.NativeMethodInfoPtr_Load_Public_Static_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666588);
			Loader.NativeMethodInfoPtr_LoadAndInstantiate_Public_Static_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666589);
			Loader.NativeMethodInfoPtr_LoadWith_Public_Static_T_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666590);
			Loader.NativeMethodInfoPtr_LoadAndInstantiateWith_Public_Static_T_String_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666591);
			Loader.NativeMethodInfoPtr_LoadScene_Public_Static_Task_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666592);
			Loader.NativeMethodInfoPtr_LoadSceneWith_Public_Static_Task_String_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666593);
			Loader.NativeMethodInfoPtr_LoadSprite_Public_Static_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666594);
			Loader.NativeMethodInfoPtr_LoadSpriteWith_Public_Static_Sprite_String_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666595);
			Loader.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_T_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666596);
			Loader.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Static_Task_1_T_String_Transform_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666597);
			Loader.NativeMethodInfoPtr_LoadSpriteAsync_Public_Static_Task_1_Sprite_String_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666598);
			Loader.NativeMethodInfoPtr_LoadAsyncWith_Public_Static_Task_1_T_String_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666599);
			Loader.NativeMethodInfoPtr_LoadAndInstantiateAsyncWith_Public_Static_Task_1_T_String_String_Transform_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666600);
			Loader.NativeMethodInfoPtr_LoadSpriteAsyncWith_Public_Static_Task_1_Sprite_String_String_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666601);
			Loader.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666602);
			Loader.NativeMethodInfoPtr_LoadSceneAsyncWith_Public_Static_Task_1_AsyncOperation_String_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666603);
			Loader.NativeMethodInfoPtr_loadAsync_Private_Static_Task_1_T_String_String_Object_LoaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666604);
			Loader.NativeMethodInfoPtr_loadAndInstantiateAsync_Private_Static_Task_1_T_String_String_Transform_Boolean_LoaderMode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666605);
			Loader.NativeMethodInfoPtr_loadSpriteAsync_Private_Static_Task_1_Sprite_String_String_String_Object_LoaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666606);
			Loader.NativeMethodInfoPtr_getAsync_Private_Static_Task_1_T_String_String_LoaderMode_Func_2_AssetLoader_T_Func_2_AssetLoader_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666607);
			Loader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100666608);
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0006B2BC File Offset: 0x000694BC
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0006B2F0 File Offset: 0x000694F0
		public unsafe static Loader Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877456, XrefRangeEnd = 877458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_get_Instance_Private_Static_get_Loader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877458, XrefRangeEnd = 877462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Loader_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0006B328 File Offset: 0x00069528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877462, XrefRangeEnd = 877527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0006B35C File Offset: 0x0006955C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877537, RefRangeEnd = 877538, XrefRangeStart = 877527, XrefRangeEnd = 877537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void assertSerializedStrategyIsValid(Loader.SerializedLoaderStrategy serializedLoaderStrategy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedLoaderStrategy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_assertSerializedStrategyIsValid_Private_Void_SerializedLoaderStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0006B3A0 File Offset: 0x000695A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877538, XrefRangeEnd = 877560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultLoaderStrategy(string strategyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strategyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_SetDefaultLoaderStrategy_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0006B3D8 File Offset: 0x000695D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 877579, RefRangeEnd = 877583, XrefRangeStart = 877560, XrefRangeEnd = 877579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void guaranteeDefaultInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_guaranteeDefaultInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0006B400 File Offset: 0x00069600
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 877598, RefRangeEnd = 877602, XrefRangeStart = 877583, XrefRangeEnd = 877598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Load<T>(string asset, global::Il2CppSystem.Object context = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_Load_Public_Static_T_String_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0006B450 File Offset: 0x00069650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877602, XrefRangeEnd = 877618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T LoadAndInstantiate<T>(string asset, Transform parent = null, bool worldPositionStays = false, global::Il2CppSystem.Object context = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_LoadAndInstantiate_Public_Static_T_String_Transform_Boolean_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0006B4C0 File Offset: 0x000696C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877618, XrefRangeEnd = 877630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T LoadWith<T>(string asset, string strategyName, global::Il2CppSystem.Object context = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_LoadWith_Public_Static_T_String_String_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0006B524 File Offset: 0x00069724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877630, XrefRangeEnd = 877643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T LoadAndInstantiateWith<T>(string asset, string strategyName, Transform parent = null, bool worldPositionStays = false, global::Il2CppSystem.Object context = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_LoadAndInstantiateWith_Public_Static_T_String_String_Transform_Boolean_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0006B5A8 File Offset: 0x000697A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877643, XrefRangeEnd = 877646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task LoadScene(string scene, LoadSceneMode mode, bool preserveInMemory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveInMemory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadScene_Public_Static_Task_String_LoadSceneMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0006B608 File Offset: 0x00069808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877658, RefRangeEnd = 877659, XrefRangeStart = 877646, XrefRangeEnd = 877658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task LoadSceneWith(string scene, string strategyName, LoadSceneMode mode, bool preserveInMemory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveInMemory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadSceneWith_Public_Static_Task_String_String_LoadSceneMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0006B67C File Offset: 0x0006987C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 877666, RefRangeEnd = 877688, XrefRangeStart = 877659, XrefRangeEnd = 877666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite LoadSprite(string asset, string crop = null, global::Il2CppSystem.Object context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadSprite_Public_Static_Sprite_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0006B6E4 File Offset: 0x000698E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877688, XrefRangeEnd = 877693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite LoadSpriteWith(string asset, string strategyName, string crop = null, global::Il2CppSystem.Object context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadSpriteWith_Public_Static_Sprite_String_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0006B760 File Offset: 0x00069960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877702, RefRangeEnd = 877703, XrefRangeStart = 877693, XrefRangeEnd = 877702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> LoadAsync<T>(string asset, global::Il2CppSystem.Object context = null, bool forceAsync = false) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_LoadAsync_Public_Static_Task_1_T_String_Object_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0006B7C4 File Offset: 0x000699C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877703, XrefRangeEnd = 877713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> LoadAndInstantiateAsync<T>(string asset, Transform parent = null, bool worldPositionStays = false, bool forceAsync = false, global::Il2CppSystem.Object context = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAsync;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Static_Task_1_T_String_Transform_Boolean_Boolean_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0006B84C File Offset: 0x00069A4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 877729, RefRangeEnd = 877735, XrefRangeStart = 877713, XrefRangeEnd = 877729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Sprite> LoadSpriteAsync(string asset, string crop = null, global::Il2CppSystem.Object context = null, bool forceAsync = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadSpriteAsync_Public_Static_Task_1_Sprite_String_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0006B8C4 File Offset: 0x00069AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877745, RefRangeEnd = 877746, XrefRangeStart = 877735, XrefRangeEnd = 877745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> LoadAsyncWith<T>(string asset, string strategyName, global::Il2CppSystem.Object context = null, bool forceAsync = false) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_LoadAsyncWith_Public_Static_Task_1_T_String_String_Object_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0006B93C File Offset: 0x00069B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877757, RefRangeEnd = 877758, XrefRangeStart = 877746, XrefRangeEnd = 877757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> LoadAndInstantiateAsyncWith<T>(string asset, string strategyName, Transform parent = null, bool worldPositionStays = false, bool forceAsync = false, global::Il2CppSystem.Object context = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAsync;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_LoadAndInstantiateAsyncWith_Public_Static_Task_1_T_String_String_Transform_Boolean_Boolean_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0006B9D4 File Offset: 0x00069BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877758, XrefRangeEnd = 877775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Sprite> LoadSpriteAsyncWith(string asset, string strategyName, string crop = null, global::Il2CppSystem.Object context = null, bool forceAsync = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadSpriteAsyncWith_Public_Static_Task_1_Sprite_String_String_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0006BA5C File Offset: 0x00069C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877775, XrefRangeEnd = 877789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<AsyncOperation> LoadSceneAsync(string scene, LoadSceneMode mode, bool preserveInMemory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveInMemory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AsyncOperation>>(intPtr3) : null;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0006BABC File Offset: 0x00069CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877789, XrefRangeEnd = 877804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<AsyncOperation> LoadSceneAsyncWith(string scene, string strategyName, LoadSceneMode mode, bool preserveInMemory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveInMemory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadSceneAsyncWith_Public_Static_Task_1_AsyncOperation_String_String_LoadSceneMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AsyncOperation>>(intPtr3) : null;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0006BB30 File Offset: 0x00069D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877814, RefRangeEnd = 877815, XrefRangeStart = 877804, XrefRangeEnd = 877814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> loadAsync<T>(string asset, string strategyName, global::Il2CppSystem.Object context, LoaderMode mode) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_loadAsync_Private_Static_Task_1_T_String_String_Object_LoaderMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0006BBA8 File Offset: 0x00069DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877826, RefRangeEnd = 877827, XrefRangeStart = 877815, XrefRangeEnd = 877826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> loadAndInstantiateAsync<T>(string asset, string strategyName, Transform parent, bool worldPositionStays, LoaderMode mode, global::Il2CppSystem.Object context = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_loadAndInstantiateAsync_Private_Static_Task_1_T_String_String_Transform_Boolean_LoaderMode_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0006BC40 File Offset: 0x00069E40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 877844, RefRangeEnd = 877847, XrefRangeStart = 877827, XrefRangeEnd = 877844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Sprite> loadSpriteAsync(string asset, string strategyName, string crop, global::Il2CppSystem.Object context, LoaderMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_loadSpriteAsync_Private_Static_Task_1_Sprite_String_String_String_Object_LoaderMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0006BCC8 File Offset: 0x00069EC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 877858, RefRangeEnd = 877861, XrefRangeStart = 877847, XrefRangeEnd = 877858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> getAsync<T>(string asset, string strategyName, LoaderMode mode, Func<AssetLoader, T> getSync, Func<AssetLoader, Task<T>> getAsync) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSync);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getAsync);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_getAsync_Private_Static_Task_1_T_String_String_LoaderMode_Func_2_AssetLoader_T_Func_2_AssetLoader_Task_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0006BD54 File Offset: 0x00069F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877861, XrefRangeEnd = 877873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Loader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000098A9 File Offset: 0x00007AA9
		public Loader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0006BD90 File Offset: 0x00069F90
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x000098B2 File Offset: 0x00007AB2
		public unsafe Il2CppReferenceArray<Loader.SerializedLoaderStrategy> loaderStrategies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.NativeFieldInfoPtr_loaderStrategies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Loader.SerializedLoaderStrategy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.NativeFieldInfoPtr_loaderStrategies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0006BDC0 File Offset: 0x00069FC0
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x000098D1 File Offset: 0x00007AD1
		public unsafe Dictionary<string, LoaderStrategy> strategyLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.NativeFieldInfoPtr_strategyLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LoaderStrategy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.NativeFieldInfoPtr_strategyLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x0006BDF0 File Offset: 0x00069FF0
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x000098F0 File Offset: 0x00007AF0
		public unsafe static Loader _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Loader.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Loader.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x0006BE18 File Offset: 0x0006A018
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x00009902 File Offset: 0x00007B02
		public unsafe static string DefaultLoadStrategyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Loader.NativeFieldInfoPtr_DefaultLoadStrategyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Loader.NativeFieldInfoPtr_DefaultLoadStrategyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeFieldInfoPtr_loaderStrategies;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeFieldInfoPtr_strategyLookup;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLoadStrategyName;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Private_Static_get_Loader_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Loader_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_assertSerializedStrategyIsValid_Private_Void_SerializedLoaderStrategy_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultLoaderStrategy_Public_Static_Void_String_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_guaranteeDefaultInstance_Private_Static_Void_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_Object_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiate_Public_Static_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_LoadWith_Public_Static_T_String_String_Object_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateWith_Public_Static_T_String_String_Transform_Boolean_Object_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Task_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneWith_Public_Static_Task_String_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_LoadSprite_Public_Static_Sprite_String_String_Object_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpriteWith_Public_Static_Sprite_String_String_String_Object_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_T_String_Object_Boolean_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Static_Task_1_T_String_Transform_Boolean_Boolean_Object_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpriteAsync_Public_Static_Task_1_Sprite_String_String_Object_Boolean_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsyncWith_Public_Static_Task_1_T_String_String_Object_Boolean_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateAsyncWith_Public_Static_Task_1_T_String_String_Transform_Boolean_Boolean_Object_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpriteAsyncWith_Public_Static_Task_1_Sprite_String_String_String_Object_Boolean_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncWith_Public_Static_Task_1_AsyncOperation_String_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_loadAsync_Private_Static_Task_1_T_String_String_Object_LoaderMode_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_loadAndInstantiateAsync_Private_Static_Task_1_T_String_String_Transform_Boolean_LoaderMode_Object_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_loadSpriteAsync_Private_Static_Task_1_Sprite_String_String_String_Object_LoaderMode_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_getAsync_Private_Static_Task_1_T_String_String_LoaderMode_Func_2_AssetLoader_T_Func_2_AssetLoader_Task_1_T_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002FF RID: 767
		[Serializable]
		public class SerializedLoaderStrategy : global::Il2CppSystem.Object
		{
			// Token: 0x0600232F RID: 9007 RVA: 0x0009ACE0 File Offset: 0x00098EE0
			// Note: this type is marked as 'beforefieldinit'.
			static SerializedLoaderStrategy()
			{
				Il2CppClassPointerStore<Loader.SerializedLoaderStrategy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "SerializedLoaderStrategy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader.SerializedLoaderStrategy>.NativeClassPtr);
				Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_lookupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.SerializedLoaderStrategy>.NativeClassPtr, "lookupName");
				Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_isDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.SerializedLoaderStrategy>.NativeClassPtr, "isDefault");
				Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_strategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.SerializedLoaderStrategy>.NativeClassPtr, "strategy");
				Loader.SerializedLoaderStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.SerializedLoaderStrategy>.NativeClassPtr, 100666609);
			}

			// Token: 0x06002330 RID: 9008 RVA: 0x0009AD5C File Offset: 0x00098F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877008, XrefRangeEnd = 877012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedLoaderStrategy()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader.SerializedLoaderStrategy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.SerializedLoaderStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002331 RID: 9009 RVA: 0x0000F505 File Offset: 0x0000D705
			public SerializedLoaderStrategy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x06002332 RID: 9010 RVA: 0x0009AD98 File Offset: 0x00098F98
			// (set) Token: 0x06002333 RID: 9011 RVA: 0x0000F50E File Offset: 0x0000D70E
			public unsafe string lookupName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_lookupName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_lookupName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009A9 RID: 2473
			// (get) Token: 0x06002334 RID: 9012 RVA: 0x0009ADC0 File Offset: 0x00098FC0
			// (set) Token: 0x06002335 RID: 9013 RVA: 0x0000F52D File Offset: 0x0000D72D
			public unsafe bool isDefault
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_isDefault);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_isDefault)) = value;
				}
			}

			// Token: 0x170009AA RID: 2474
			// (get) Token: 0x06002336 RID: 9014 RVA: 0x0009ADE8 File Offset: 0x00098FE8
			// (set) Token: 0x06002337 RID: 9015 RVA: 0x0000F548 File Offset: 0x0000D748
			public unsafe LoaderStrategy strategy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_strategy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoaderStrategy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.SerializedLoaderStrategy.NativeFieldInfoPtr_strategy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001831 RID: 6193
			private static readonly IntPtr NativeFieldInfoPtr_lookupName;

			// Token: 0x04001832 RID: 6194
			private static readonly IntPtr NativeFieldInfoPtr_isDefault;

			// Token: 0x04001833 RID: 6195
			private static readonly IntPtr NativeFieldInfoPtr_strategy;

			// Token: 0x04001834 RID: 6196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000300 RID: 768
		[ObfuscatedName("dwd.core.loader.Loader+<>c__DisplayClass28_0`1")]
		public sealed class __c__DisplayClass28_0<T> : global::Il2CppSystem.Object where T : global::UnityEngine.Object
		{
			// Token: 0x06002338 RID: 9016 RVA: 0x0009AE18 File Offset: 0x00099018
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<>c__DisplayClass28_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr);
				Loader.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr, "asset");
				Loader.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr, "context");
				Loader.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr, 100666610);
				Loader.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__loadAsync_b__0_Internal_T_AssetLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr, 100666611);
				Loader.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__loadAsync_b__1_Internal_Task_1_T_AssetLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr, 100666612);
			}

			// Token: 0x06002339 RID: 9017 RVA: 0x0009AEE4 File Offset: 0x000990E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader.__c__DisplayClass28_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600233A RID: 9018 RVA: 0x0009AF20 File Offset: 0x00099120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877012, XrefRangeEnd = 877014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _loadAsync_b__0(AssetLoader assetLoader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetLoader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__loadAsync_b__0_Internal_T_AssetLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600233B RID: 9019 RVA: 0x0009AF6C File Offset: 0x0009916C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877014, XrefRangeEnd = 877025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<T> _loadAsync_b__1(AssetLoader assetLoader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetLoader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__loadAsync_b__1_Internal_Task_1_T_AssetLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600233C RID: 9020 RVA: 0x0000F567 File Offset: 0x0000D767
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009AB RID: 2475
			// (get) Token: 0x0600233D RID: 9021 RVA: 0x0009AFBC File Offset: 0x000991BC
			// (set) Token: 0x0600233E RID: 9022 RVA: 0x0000F570 File Offset: 0x0000D770
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009AC RID: 2476
			// (get) Token: 0x0600233F RID: 9023 RVA: 0x0009AFE4 File Offset: 0x000991E4
			// (set) Token: 0x06002340 RID: 9024 RVA: 0x0000F58F File Offset: 0x0000D78F
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001835 RID: 6197
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001836 RID: 6198
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001837 RID: 6199
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001838 RID: 6200
			private static readonly IntPtr NativeMethodInfoPtr__loadAsync_b__0_Internal_T_AssetLoader_0;

			// Token: 0x04001839 RID: 6201
			private static readonly IntPtr NativeMethodInfoPtr__loadAsync_b__1_Internal_Task_1_T_AssetLoader_0;
		}

		// Token: 0x02000301 RID: 769
		[ObfuscatedName("dwd.core.loader.Loader+<>c__DisplayClass29_0`1")]
		public sealed class __c__DisplayClass29_0<T> : global::Il2CppSystem.Object where T : global::UnityEngine.Object
		{
			// Token: 0x06002341 RID: 9025 RVA: 0x0009B014 File Offset: 0x00099214
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<>c__DisplayClass29_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr);
				Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr, "asset");
				Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr, "parent");
				Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr, "worldPositionStays");
				Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr, "context");
				Loader.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr, 100666613);
				Loader.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__loadAndInstantiateAsync_b__0_Internal_T_AssetLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr, 100666614);
				Loader.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__loadAndInstantiateAsync_b__1_Internal_Task_1_T_AssetLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr, 100666615);
			}

			// Token: 0x06002342 RID: 9026 RVA: 0x0009B108 File Offset: 0x00099308
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader.__c__DisplayClass29_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002343 RID: 9027 RVA: 0x0009B144 File Offset: 0x00099344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877025, XrefRangeEnd = 877026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _loadAndInstantiateAsync_b__0(AssetLoader assetLoader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetLoader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__loadAndInstantiateAsync_b__0_Internal_T_AssetLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002344 RID: 9028 RVA: 0x0009B190 File Offset: 0x00099390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877026, XrefRangeEnd = 877027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<T> _loadAndInstantiateAsync_b__1(AssetLoader assetLoader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetLoader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__loadAndInstantiateAsync_b__1_Internal_Task_1_T_AssetLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06002345 RID: 9029 RVA: 0x0000F5AE File Offset: 0x0000D7AE
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009AD RID: 2477
			// (get) Token: 0x06002346 RID: 9030 RVA: 0x0009B1E0 File Offset: 0x000993E0
			// (set) Token: 0x06002347 RID: 9031 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009AE RID: 2478
			// (get) Token: 0x06002348 RID: 9032 RVA: 0x0009B208 File Offset: 0x00099408
			// (set) Token: 0x06002349 RID: 9033 RVA: 0x0000F5D6 File Offset: 0x0000D7D6
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x0600234A RID: 9034 RVA: 0x0009B238 File Offset: 0x00099438
			// (set) Token: 0x0600234B RID: 9035 RVA: 0x0000F5F5 File Offset: 0x0000D7F5
			public unsafe bool worldPositionStays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_worldPositionStays);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
				}
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x0600234C RID: 9036 RVA: 0x0009B260 File Offset: 0x00099460
			// (set) Token: 0x0600234D RID: 9037 RVA: 0x0000F610 File Offset: 0x0000D810
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400183A RID: 6202
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x0400183B RID: 6203
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x0400183C RID: 6204
			private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

			// Token: 0x0400183D RID: 6205
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400183E RID: 6206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400183F RID: 6207
			private static readonly IntPtr NativeMethodInfoPtr__loadAndInstantiateAsync_b__0_Internal_T_AssetLoader_0;

			// Token: 0x04001840 RID: 6208
			private static readonly IntPtr NativeMethodInfoPtr__loadAndInstantiateAsync_b__1_Internal_Task_1_T_AssetLoader_0;
		}

		// Token: 0x02000302 RID: 770
		[ObfuscatedName("dwd.core.loader.Loader+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600234E RID: 9038 RVA: 0x0009B290 File Offset: 0x00099490
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr);
				Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr, "asset");
				Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_crop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr, "crop");
				Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr, "context");
				Loader.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr, 100666616);
				Loader.__c__DisplayClass30_0.NativeMethodInfoPtr__loadSpriteAsync_b__0_Internal_Sprite_AssetLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr, 100666617);
				Loader.__c__DisplayClass30_0.NativeMethodInfoPtr__loadSpriteAsync_b__1_Internal_Task_1_Sprite_AssetLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr, 100666618);
			}

			// Token: 0x0600234F RID: 9039 RVA: 0x0009B334 File Offset: 0x00099534
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002350 RID: 9040 RVA: 0x0009B370 File Offset: 0x00099570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877027, XrefRangeEnd = 877028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _loadSpriteAsync_b__0(AssetLoader assetLoader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetLoader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass30_0.NativeMethodInfoPtr__loadSpriteAsync_b__0_Internal_Sprite_AssetLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
			}

			// Token: 0x06002351 RID: 9041 RVA: 0x0009B3C0 File Offset: 0x000995C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877028, XrefRangeEnd = 877045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<Sprite> _loadSpriteAsync_b__1(AssetLoader assetLoader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetLoader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.__c__DisplayClass30_0.NativeMethodInfoPtr__loadSpriteAsync_b__1_Internal_Task_1_Sprite_AssetLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
				}
			}

			// Token: 0x06002352 RID: 9042 RVA: 0x0000F62F File Offset: 0x0000D82F
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009B1 RID: 2481
			// (get) Token: 0x06002353 RID: 9043 RVA: 0x0009B410 File Offset: 0x00099610
			// (set) Token: 0x06002354 RID: 9044 RVA: 0x0000F638 File Offset: 0x0000D838
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x06002355 RID: 9045 RVA: 0x0009B438 File Offset: 0x00099638
			// (set) Token: 0x06002356 RID: 9046 RVA: 0x0000F657 File Offset: 0x0000D857
			public unsafe string crop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_crop);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_crop), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x06002357 RID: 9047 RVA: 0x0009B460 File Offset: 0x00099660
			// (set) Token: 0x06002358 RID: 9048 RVA: 0x0000F676 File Offset: 0x0000D876
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader.__c__DisplayClass30_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001841 RID: 6209
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001842 RID: 6210
			private static readonly IntPtr NativeFieldInfoPtr_crop;

			// Token: 0x04001843 RID: 6211
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001844 RID: 6212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001845 RID: 6213
			private static readonly IntPtr NativeMethodInfoPtr__loadSpriteAsync_b__0_Internal_Sprite_AssetLoader_0;

			// Token: 0x04001846 RID: 6214
			private static readonly IntPtr NativeMethodInfoPtr__loadSpriteAsync_b__1_Internal_Task_1_Sprite_AssetLoader_0;
		}

		// Token: 0x02000303 RID: 771
		[ObfuscatedName("dwd.core.loader.Loader+<LoadAndInstantiateAsync>d__21`1")]
		public sealed class _LoadAndInstantiateAsync_d__21<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x06002359 RID: 9049 RVA: 0x0009B490 File Offset: 0x00099690
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndInstantiateAsync_d__21()
			{
				Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadAndInstantiateAsync>d__21`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr);
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "<>1__state");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "<>t__builder");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "asset");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "parent");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "worldPositionStays");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_forceAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "forceAsync");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "context");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, "<>u__1");
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, 100666619);
				Loader._LoadAndInstantiateAsync_d__21<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr, 100666620);
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x0009B5C0 File Offset: 0x000997C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877045, XrefRangeEnd = 877061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAndInstantiateAsync_d__21<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600235B RID: 9051 RVA: 0x0009B5F8 File Offset: 0x000997F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAndInstantiateAsync_d__21<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600235C RID: 9052 RVA: 0x0000F695 File Offset: 0x0000D895
			public _LoadAndInstantiateAsync_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600235D RID: 9053 RVA: 0x0000F69E File Offset: 0x0000D89E
			public _LoadAndInstantiateAsync_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsync_d__21<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x0600235E RID: 9054 RVA: 0x0009B640 File Offset: 0x00099840
			// (set) Token: 0x0600235F RID: 9055 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x06002360 RID: 9056 RVA: 0x0009B668 File Offset: 0x00099868
			// (set) Token: 0x06002361 RID: 9057 RVA: 0x0000F6CB File Offset: 0x0000D8CB
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009B6 RID: 2486
			// (get) Token: 0x06002362 RID: 9058 RVA: 0x0009B698 File Offset: 0x00099898
			// (set) Token: 0x06002363 RID: 9059 RVA: 0x0000F6F9 File Offset: 0x0000D8F9
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009B7 RID: 2487
			// (get) Token: 0x06002364 RID: 9060 RVA: 0x0009B6C0 File Offset: 0x000998C0
			// (set) Token: 0x06002365 RID: 9061 RVA: 0x0000F718 File Offset: 0x0000D918
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B8 RID: 2488
			// (get) Token: 0x06002366 RID: 9062 RVA: 0x0009B6F0 File Offset: 0x000998F0
			// (set) Token: 0x06002367 RID: 9063 RVA: 0x0000F737 File Offset: 0x0000D937
			public unsafe bool worldPositionStays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_worldPositionStays);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
				}
			}

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x06002368 RID: 9064 RVA: 0x0009B718 File Offset: 0x00099918
			// (set) Token: 0x06002369 RID: 9065 RVA: 0x0000F752 File Offset: 0x0000D952
			public unsafe bool forceAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_forceAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_forceAsync)) = value;
				}
			}

			// Token: 0x170009BA RID: 2490
			// (get) Token: 0x0600236A RID: 9066 RVA: 0x0009B740 File Offset: 0x00099940
			// (set) Token: 0x0600236B RID: 9067 RVA: 0x0000F76D File Offset: 0x0000D96D
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BB RID: 2491
			// (get) Token: 0x0600236C RID: 9068 RVA: 0x0009B770 File Offset: 0x00099970
			// (set) Token: 0x0600236D RID: 9069 RVA: 0x0000F78C File Offset: 0x0000D98C
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsync_d__21<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001847 RID: 6215
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001848 RID: 6216
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001849 RID: 6217
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x0400184A RID: 6218
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x0400184B RID: 6219
			private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

			// Token: 0x0400184C RID: 6220
			private static readonly IntPtr NativeFieldInfoPtr_forceAsync;

			// Token: 0x0400184D RID: 6221
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400184E RID: 6222
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400184F RID: 6223
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001850 RID: 6224
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000304 RID: 772
		[ObfuscatedName("dwd.core.loader.Loader+<LoadAndInstantiateAsyncWith>d__24`1")]
		public sealed class _LoadAndInstantiateAsyncWith_d__24<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x0600236E RID: 9070 RVA: 0x0009B7A0 File Offset: 0x000999A0
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndInstantiateAsyncWith_d__24()
			{
				Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadAndInstantiateAsyncWith>d__24`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr);
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "<>1__state");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "<>t__builder");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_forceAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "forceAsync");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "asset");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "strategyName");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "parent");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "worldPositionStays");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "context");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, "<>u__1");
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, 100666621);
				Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr, 100666622);
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x0009B8E4 File Offset: 0x00099AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877061, XrefRangeEnd = 877075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002370 RID: 9072 RVA: 0x0009B91C File Offset: 0x00099B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002371 RID: 9073 RVA: 0x0000F7BA File Offset: 0x0000D9BA
			public _LoadAndInstantiateAsyncWith_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002372 RID: 9074 RVA: 0x0000F7C3 File Offset: 0x0000D9C3
			public _LoadAndInstantiateAsyncWith_d__24()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadAndInstantiateAsyncWith_d__24<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009BC RID: 2492
			// (get) Token: 0x06002373 RID: 9075 RVA: 0x0009B964 File Offset: 0x00099B64
			// (set) Token: 0x06002374 RID: 9076 RVA: 0x0000F7D5 File Offset: 0x0000D9D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x06002375 RID: 9077 RVA: 0x0009B98C File Offset: 0x00099B8C
			// (set) Token: 0x06002376 RID: 9078 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x06002377 RID: 9079 RVA: 0x0009B9BC File Offset: 0x00099BBC
			// (set) Token: 0x06002378 RID: 9080 RVA: 0x0000F81E File Offset: 0x0000DA1E
			public unsafe bool forceAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_forceAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_forceAsync)) = value;
				}
			}

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x06002379 RID: 9081 RVA: 0x0009B9E4 File Offset: 0x00099BE4
			// (set) Token: 0x0600237A RID: 9082 RVA: 0x0000F839 File Offset: 0x0000DA39
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x0600237B RID: 9083 RVA: 0x0009BA0C File Offset: 0x00099C0C
			// (set) Token: 0x0600237C RID: 9084 RVA: 0x0000F858 File Offset: 0x0000DA58
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009C1 RID: 2497
			// (get) Token: 0x0600237D RID: 9085 RVA: 0x0009BA34 File Offset: 0x00099C34
			// (set) Token: 0x0600237E RID: 9086 RVA: 0x0000F877 File Offset: 0x0000DA77
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C2 RID: 2498
			// (get) Token: 0x0600237F RID: 9087 RVA: 0x0009BA64 File Offset: 0x00099C64
			// (set) Token: 0x06002380 RID: 9088 RVA: 0x0000F896 File Offset: 0x0000DA96
			public unsafe bool worldPositionStays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_worldPositionStays);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
				}
			}

			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x06002381 RID: 9089 RVA: 0x0009BA8C File Offset: 0x00099C8C
			// (set) Token: 0x06002382 RID: 9090 RVA: 0x0000F8B1 File Offset: 0x0000DAB1
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C4 RID: 2500
			// (get) Token: 0x06002383 RID: 9091 RVA: 0x0009BABC File Offset: 0x00099CBC
			// (set) Token: 0x06002384 RID: 9092 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAndInstantiateAsyncWith_d__24<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001851 RID: 6225
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001852 RID: 6226
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001853 RID: 6227
			private static readonly IntPtr NativeFieldInfoPtr_forceAsync;

			// Token: 0x04001854 RID: 6228
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001855 RID: 6229
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x04001856 RID: 6230
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04001857 RID: 6231
			private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

			// Token: 0x04001858 RID: 6232
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001859 RID: 6233
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400185A RID: 6234
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400185B RID: 6235
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000305 RID: 773
		[ObfuscatedName("dwd.core.loader.Loader+<LoadAsync>d__20`1")]
		public sealed class _LoadAsync_d__20<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x06002385 RID: 9093 RVA: 0x0009BAEC File Offset: 0x00099CEC
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__20()
			{
				Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadAsync>d__20`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr);
				Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, "<>1__state");
				Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, "<>t__builder");
				Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, "asset");
				Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, "context");
				Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_forceAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, "forceAsync");
				Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, "<>u__1");
				Loader._LoadAsync_d__20<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, 100666623);
				Loader._LoadAsync_d__20<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr, 100666624);
			}

			// Token: 0x06002386 RID: 9094 RVA: 0x0009BBF4 File Offset: 0x00099DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877075, XrefRangeEnd = 877091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAsync_d__20<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002387 RID: 9095 RVA: 0x0009BC2C File Offset: 0x00099E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAsync_d__20<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002388 RID: 9096 RVA: 0x0000F8FE File Offset: 0x0000DAFE
			public _LoadAsync_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002389 RID: 9097 RVA: 0x0000F907 File Offset: 0x0000DB07
			public _LoadAsync_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadAsync_d__20<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x0600238A RID: 9098 RVA: 0x0009BC74 File Offset: 0x00099E74
			// (set) Token: 0x0600238B RID: 9099 RVA: 0x0000F919 File Offset: 0x0000DB19
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x0600238C RID: 9100 RVA: 0x0009BC9C File Offset: 0x00099E9C
			// (set) Token: 0x0600238D RID: 9101 RVA: 0x0000F934 File Offset: 0x0000DB34
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x0600238E RID: 9102 RVA: 0x0009BCCC File Offset: 0x00099ECC
			// (set) Token: 0x0600238F RID: 9103 RVA: 0x0000F962 File Offset: 0x0000DB62
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x06002390 RID: 9104 RVA: 0x0009BCF4 File Offset: 0x00099EF4
			// (set) Token: 0x06002391 RID: 9105 RVA: 0x0000F981 File Offset: 0x0000DB81
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x06002392 RID: 9106 RVA: 0x0009BD24 File Offset: 0x00099F24
			// (set) Token: 0x06002393 RID: 9107 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
			public unsafe bool forceAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_forceAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr_forceAsync)) = value;
				}
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x06002394 RID: 9108 RVA: 0x0009BD4C File Offset: 0x00099F4C
			// (set) Token: 0x06002395 RID: 9109 RVA: 0x0000F9BB File Offset: 0x0000DBBB
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsync_d__20<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400185C RID: 6236
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400185D RID: 6237
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400185E RID: 6238
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x0400185F RID: 6239
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001860 RID: 6240
			private static readonly IntPtr NativeFieldInfoPtr_forceAsync;

			// Token: 0x04001861 RID: 6241
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001862 RID: 6242
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001863 RID: 6243
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000306 RID: 774
		[ObfuscatedName("dwd.core.loader.Loader+<LoadAsyncWith>d__23`1")]
		public sealed class _LoadAsyncWith_d__23<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x06002396 RID: 9110 RVA: 0x0009BD7C File Offset: 0x00099F7C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsyncWith_d__23()
			{
				Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadAsyncWith>d__23`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr);
				Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, "<>1__state");
				Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, "<>t__builder");
				Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_forceAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, "forceAsync");
				Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, "asset");
				Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, "strategyName");
				Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, "context");
				Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, "<>u__1");
				Loader._LoadAsyncWith_d__23<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, 100666625);
				Loader._LoadAsyncWith_d__23<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr, 100666626);
			}

			// Token: 0x06002397 RID: 9111 RVA: 0x0009BE98 File Offset: 0x0009A098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877091, XrefRangeEnd = 877105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAsyncWith_d__23<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002398 RID: 9112 RVA: 0x0009BED0 File Offset: 0x0009A0D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadAsyncWith_d__23<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002399 RID: 9113 RVA: 0x0000F9E9 File Offset: 0x0000DBE9
			public _LoadAsyncWith_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600239A RID: 9114 RVA: 0x0000F9F2 File Offset: 0x0000DBF2
			public _LoadAsyncWith_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadAsyncWith_d__23<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009CB RID: 2507
			// (get) Token: 0x0600239B RID: 9115 RVA: 0x0009BF18 File Offset: 0x0009A118
			// (set) Token: 0x0600239C RID: 9116 RVA: 0x0000FA04 File Offset: 0x0000DC04
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009CC RID: 2508
			// (get) Token: 0x0600239D RID: 9117 RVA: 0x0009BF40 File Offset: 0x0009A140
			// (set) Token: 0x0600239E RID: 9118 RVA: 0x0000FA1F File Offset: 0x0000DC1F
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009CD RID: 2509
			// (get) Token: 0x0600239F RID: 9119 RVA: 0x0009BF70 File Offset: 0x0009A170
			// (set) Token: 0x060023A0 RID: 9120 RVA: 0x0000FA4D File Offset: 0x0000DC4D
			public unsafe bool forceAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_forceAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_forceAsync)) = value;
				}
			}

			// Token: 0x170009CE RID: 2510
			// (get) Token: 0x060023A1 RID: 9121 RVA: 0x0009BF98 File Offset: 0x0009A198
			// (set) Token: 0x060023A2 RID: 9122 RVA: 0x0000FA68 File Offset: 0x0000DC68
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009CF RID: 2511
			// (get) Token: 0x060023A3 RID: 9123 RVA: 0x0009BFC0 File Offset: 0x0009A1C0
			// (set) Token: 0x060023A4 RID: 9124 RVA: 0x0000FA87 File Offset: 0x0000DC87
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009D0 RID: 2512
			// (get) Token: 0x060023A5 RID: 9125 RVA: 0x0009BFE8 File Offset: 0x0009A1E8
			// (set) Token: 0x060023A6 RID: 9126 RVA: 0x0000FAA6 File Offset: 0x0000DCA6
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D1 RID: 2513
			// (get) Token: 0x060023A7 RID: 9127 RVA: 0x0009C018 File Offset: 0x0009A218
			// (set) Token: 0x060023A8 RID: 9128 RVA: 0x0000FAC5 File Offset: 0x0000DCC5
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadAsyncWith_d__23<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001864 RID: 6244
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001865 RID: 6245
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001866 RID: 6246
			private static readonly IntPtr NativeFieldInfoPtr_forceAsync;

			// Token: 0x04001867 RID: 6247
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001868 RID: 6248
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x04001869 RID: 6249
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400186A RID: 6250
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400186B RID: 6251
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400186C RID: 6252
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000307 RID: 775
		[ObfuscatedName("dwd.core.loader.Loader+<LoadSceneAsync>d__26")]
		public sealed class _LoadSceneAsync_d__26 : ValueType
		{
			// Token: 0x060023A9 RID: 9129 RVA: 0x0009C048 File Offset: 0x0009A248
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSceneAsync_d__26()
			{
				Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadSceneAsync>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr);
				Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, "<>1__state");
				Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, "<>t__builder");
				Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, "scene");
				Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, "mode");
				Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_preserveInMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, "preserveInMemory");
				Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, "<>u__1");
				Loader._LoadSceneAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, 100666627);
				Loader._LoadSceneAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr, 100666628);
			}

			// Token: 0x060023AA RID: 9130 RVA: 0x0009C114 File Offset: 0x0009A314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877105, XrefRangeEnd = 877139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSceneAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023AB RID: 9131 RVA: 0x0009C14C File Offset: 0x0009A34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877139, XrefRangeEnd = 877145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSceneAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023AC RID: 9132 RVA: 0x0000FAF3 File Offset: 0x0000DCF3
			public _LoadSceneAsync_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023AD RID: 9133 RVA: 0x0000FAFC File Offset: 0x0000DCFC
			public _LoadSceneAsync_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadSceneAsync_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x170009D2 RID: 2514
			// (get) Token: 0x060023AE RID: 9134 RVA: 0x0009C194 File Offset: 0x0009A394
			// (set) Token: 0x060023AF RID: 9135 RVA: 0x0000FB0E File Offset: 0x0000DD0E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0009C1BC File Offset: 0x0009A3BC
			// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0000FB29 File Offset: 0x0000DD29
			public AsyncTaskMethodBuilder<AsyncOperation> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AsyncOperation>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncOperation>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncOperation>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009D4 RID: 2516
			// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0009C1EC File Offset: 0x0009A3EC
			// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0000FB57 File Offset: 0x0000DD57
			public unsafe string scene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_scene);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_scene), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009D5 RID: 2517
			// (get) Token: 0x060023B4 RID: 9140 RVA: 0x0009C214 File Offset: 0x0009A414
			// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0000FB76 File Offset: 0x0000DD76
			public unsafe LoadSceneMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x170009D6 RID: 2518
			// (get) Token: 0x060023B6 RID: 9142 RVA: 0x0009C23C File Offset: 0x0009A43C
			// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0000FB91 File Offset: 0x0000DD91
			public unsafe bool preserveInMemory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_preserveInMemory);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr_preserveInMemory)) = value;
				}
			}

			// Token: 0x170009D7 RID: 2519
			// (get) Token: 0x060023B8 RID: 9144 RVA: 0x0009C264 File Offset: 0x0009A464
			// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0000FBAC File Offset: 0x0000DDAC
			public TaskAwaiter<AsyncOperation> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<AsyncOperation>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<AsyncOperation>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsync_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<AsyncOperation>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400186D RID: 6253
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400186E RID: 6254
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400186F RID: 6255
			private static readonly IntPtr NativeFieldInfoPtr_scene;

			// Token: 0x04001870 RID: 6256
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04001871 RID: 6257
			private static readonly IntPtr NativeFieldInfoPtr_preserveInMemory;

			// Token: 0x04001872 RID: 6258
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001873 RID: 6259
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001874 RID: 6260
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000308 RID: 776
		[ObfuscatedName("dwd.core.loader.Loader+<LoadSceneAsyncWith>d__27")]
		public sealed class _LoadSceneAsyncWith_d__27 : ValueType
		{
			// Token: 0x060023BA RID: 9146 RVA: 0x0009C294 File Offset: 0x0009A494
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSceneAsyncWith_d__27()
			{
				Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadSceneAsyncWith>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr);
				Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, "<>1__state");
				Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, "<>t__builder");
				Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, "strategyName");
				Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, "scene");
				Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, "mode");
				Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_preserveInMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, "preserveInMemory");
				Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, "<>u__1");
				Loader._LoadSceneAsyncWith_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, 100666629);
				Loader._LoadSceneAsyncWith_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr, 100666630);
			}

			// Token: 0x060023BB RID: 9147 RVA: 0x0009C374 File Offset: 0x0009A574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877145, XrefRangeEnd = 877194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSceneAsyncWith_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023BC RID: 9148 RVA: 0x0009C3AC File Offset: 0x0009A5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877194, XrefRangeEnd = 877200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSceneAsyncWith_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023BD RID: 9149 RVA: 0x0000FBDA File Offset: 0x0000DDDA
			public _LoadSceneAsyncWith_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023BE RID: 9150 RVA: 0x0000FBE3 File Offset: 0x0000DDE3
			public _LoadSceneAsyncWith_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadSceneAsyncWith_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x170009D8 RID: 2520
			// (get) Token: 0x060023BF RID: 9151 RVA: 0x0009C3F4 File Offset: 0x0009A5F4
			// (set) Token: 0x060023C0 RID: 9152 RVA: 0x0000FBF5 File Offset: 0x0000DDF5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009D9 RID: 2521
			// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0009C41C File Offset: 0x0009A61C
			// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0000FC10 File Offset: 0x0000DE10
			public AsyncTaskMethodBuilder<AsyncOperation> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AsyncOperation>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncOperation>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncOperation>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0009C44C File Offset: 0x0009A64C
			// (set) Token: 0x060023C4 RID: 9156 RVA: 0x0000FC3E File Offset: 0x0000DE3E
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x060023C5 RID: 9157 RVA: 0x0009C474 File Offset: 0x0009A674
			// (set) Token: 0x060023C6 RID: 9158 RVA: 0x0000FC5D File Offset: 0x0000DE5D
			public unsafe string scene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_scene);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_scene), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009DC RID: 2524
			// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0009C49C File Offset: 0x0009A69C
			// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0000FC7C File Offset: 0x0000DE7C
			public unsafe LoadSceneMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x170009DD RID: 2525
			// (get) Token: 0x060023C9 RID: 9161 RVA: 0x0009C4C4 File Offset: 0x0009A6C4
			// (set) Token: 0x060023CA RID: 9162 RVA: 0x0000FC97 File Offset: 0x0000DE97
			public unsafe bool preserveInMemory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_preserveInMemory);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr_preserveInMemory)) = value;
				}
			}

			// Token: 0x170009DE RID: 2526
			// (get) Token: 0x060023CB RID: 9163 RVA: 0x0009C4EC File Offset: 0x0009A6EC
			// (set) Token: 0x060023CC RID: 9164 RVA: 0x0000FCB2 File Offset: 0x0000DEB2
			public TaskAwaiter<AsyncOperation> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<AsyncOperation>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<AsyncOperation>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSceneAsyncWith_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<AsyncOperation>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001875 RID: 6261
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001876 RID: 6262
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001877 RID: 6263
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x04001878 RID: 6264
			private static readonly IntPtr NativeFieldInfoPtr_scene;

			// Token: 0x04001879 RID: 6265
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x0400187A RID: 6266
			private static readonly IntPtr NativeFieldInfoPtr_preserveInMemory;

			// Token: 0x0400187B RID: 6267
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400187C RID: 6268
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400187D RID: 6269
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000309 RID: 777
		[ObfuscatedName("dwd.core.loader.Loader+<LoadSpriteAsync>d__22")]
		public sealed class _LoadSpriteAsync_d__22 : ValueType
		{
			// Token: 0x060023CD RID: 9165 RVA: 0x0009C51C File Offset: 0x0009A71C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSpriteAsync_d__22()
			{
				Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadSpriteAsync>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr);
				Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, "<>1__state");
				Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, "<>t__builder");
				Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, "asset");
				Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_crop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, "crop");
				Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, "context");
				Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_forceAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, "forceAsync");
				Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, "<>u__1");
				Loader._LoadSpriteAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, 100666631);
				Loader._LoadSpriteAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr, 100666632);
			}

			// Token: 0x060023CE RID: 9166 RVA: 0x0009C5FC File Offset: 0x0009A7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877200, XrefRangeEnd = 877236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSpriteAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023CF RID: 9167 RVA: 0x0009C634 File Offset: 0x0009A834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877236, XrefRangeEnd = 877242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSpriteAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023D0 RID: 9168 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
			public _LoadSpriteAsync_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023D1 RID: 9169 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
			public _LoadSpriteAsync_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadSpriteAsync_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x170009DF RID: 2527
			// (get) Token: 0x060023D2 RID: 9170 RVA: 0x0009C67C File Offset: 0x0009A87C
			// (set) Token: 0x060023D3 RID: 9171 RVA: 0x0000FCFB File Offset: 0x0000DEFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009E0 RID: 2528
			// (get) Token: 0x060023D4 RID: 9172 RVA: 0x0009C6A4 File Offset: 0x0009A8A4
			// (set) Token: 0x060023D5 RID: 9173 RVA: 0x0000FD16 File Offset: 0x0000DF16
			public AsyncTaskMethodBuilder<Sprite> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009E1 RID: 2529
			// (get) Token: 0x060023D6 RID: 9174 RVA: 0x0009C6D4 File Offset: 0x0009A8D4
			// (set) Token: 0x060023D7 RID: 9175 RVA: 0x0000FD44 File Offset: 0x0000DF44
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009E2 RID: 2530
			// (get) Token: 0x060023D8 RID: 9176 RVA: 0x0009C6FC File Offset: 0x0009A8FC
			// (set) Token: 0x060023D9 RID: 9177 RVA: 0x0000FD63 File Offset: 0x0000DF63
			public unsafe string crop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_crop);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_crop), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009E3 RID: 2531
			// (get) Token: 0x060023DA RID: 9178 RVA: 0x0009C724 File Offset: 0x0009A924
			// (set) Token: 0x060023DB RID: 9179 RVA: 0x0000FD82 File Offset: 0x0000DF82
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E4 RID: 2532
			// (get) Token: 0x060023DC RID: 9180 RVA: 0x0009C754 File Offset: 0x0009A954
			// (set) Token: 0x060023DD RID: 9181 RVA: 0x0000FDA1 File Offset: 0x0000DFA1
			public unsafe bool forceAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_forceAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr_forceAsync)) = value;
				}
			}

			// Token: 0x170009E5 RID: 2533
			// (get) Token: 0x060023DE RID: 9182 RVA: 0x0009C77C File Offset: 0x0009A97C
			// (set) Token: 0x060023DF RID: 9183 RVA: 0x0000FDBC File Offset: 0x0000DFBC
			public TaskAwaiter<Sprite> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsync_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400187E RID: 6270
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400187F RID: 6271
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001880 RID: 6272
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001881 RID: 6273
			private static readonly IntPtr NativeFieldInfoPtr_crop;

			// Token: 0x04001882 RID: 6274
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001883 RID: 6275
			private static readonly IntPtr NativeFieldInfoPtr_forceAsync;

			// Token: 0x04001884 RID: 6276
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001885 RID: 6277
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001886 RID: 6278
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200030A RID: 778
		[ObfuscatedName("dwd.core.loader.Loader+<LoadSpriteAsyncWith>d__25")]
		public sealed class _LoadSpriteAsyncWith_d__25 : ValueType
		{
			// Token: 0x060023E0 RID: 9184 RVA: 0x0009C7AC File Offset: 0x0009A9AC
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSpriteAsyncWith_d__25()
			{
				Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<LoadSpriteAsyncWith>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr);
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "<>1__state");
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "<>t__builder");
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_forceAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "forceAsync");
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "asset");
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "strategyName");
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_crop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "crop");
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "context");
				Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, "<>u__1");
				Loader._LoadSpriteAsyncWith_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, 100666633);
				Loader._LoadSpriteAsyncWith_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr, 100666634);
			}

			// Token: 0x060023E1 RID: 9185 RVA: 0x0009C8A0 File Offset: 0x0009AAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877242, XrefRangeEnd = 877260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSpriteAsyncWith_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023E2 RID: 9186 RVA: 0x0009C8D8 File Offset: 0x0009AAD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877260, XrefRangeEnd = 877266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._LoadSpriteAsyncWith_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023E3 RID: 9187 RVA: 0x0000FDEA File Offset: 0x0000DFEA
			public _LoadSpriteAsyncWith_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023E4 RID: 9188 RVA: 0x0000FDF3 File Offset: 0x0000DFF3
			public _LoadSpriteAsyncWith_d__25()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._LoadSpriteAsyncWith_d__25>.NativeClassPtr))
			{
			}

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x060023E5 RID: 9189 RVA: 0x0009C920 File Offset: 0x0009AB20
			// (set) Token: 0x060023E6 RID: 9190 RVA: 0x0000FE05 File Offset: 0x0000E005
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0009C948 File Offset: 0x0009AB48
			// (set) Token: 0x060023E8 RID: 9192 RVA: 0x0000FE20 File Offset: 0x0000E020
			public AsyncTaskMethodBuilder<Sprite> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x060023E9 RID: 9193 RVA: 0x0009C978 File Offset: 0x0009AB78
			// (set) Token: 0x060023EA RID: 9194 RVA: 0x0000FE4E File Offset: 0x0000E04E
			public unsafe bool forceAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_forceAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_forceAsync)) = value;
				}
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x060023EB RID: 9195 RVA: 0x0009C9A0 File Offset: 0x0009ABA0
			// (set) Token: 0x060023EC RID: 9196 RVA: 0x0000FE69 File Offset: 0x0000E069
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x060023ED RID: 9197 RVA: 0x0009C9C8 File Offset: 0x0009ABC8
			// (set) Token: 0x060023EE RID: 9198 RVA: 0x0000FE88 File Offset: 0x0000E088
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009EB RID: 2539
			// (get) Token: 0x060023EF RID: 9199 RVA: 0x0009C9F0 File Offset: 0x0009ABF0
			// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0000FEA7 File Offset: 0x0000E0A7
			public unsafe string crop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_crop);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_crop), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009EC RID: 2540
			// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0009CA18 File Offset: 0x0009AC18
			// (set) Token: 0x060023F2 RID: 9202 RVA: 0x0000FEC6 File Offset: 0x0000E0C6
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009ED RID: 2541
			// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0009CA48 File Offset: 0x0009AC48
			// (set) Token: 0x060023F4 RID: 9204 RVA: 0x0000FEE5 File Offset: 0x0000E0E5
			public TaskAwaiter<Sprite> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._LoadSpriteAsyncWith_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001887 RID: 6279
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001888 RID: 6280
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001889 RID: 6281
			private static readonly IntPtr NativeFieldInfoPtr_forceAsync;

			// Token: 0x0400188A RID: 6282
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x0400188B RID: 6283
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x0400188C RID: 6284
			private static readonly IntPtr NativeFieldInfoPtr_crop;

			// Token: 0x0400188D RID: 6285
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400188E RID: 6286
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400188F RID: 6287
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001890 RID: 6288
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200030B RID: 779
		[ObfuscatedName("dwd.core.loader.Loader+<getAsync>d__31`1")]
		public sealed class _getAsync_d__31<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x060023F5 RID: 9205 RVA: 0x0009CA78 File Offset: 0x0009AC78
			// Note: this type is marked as 'beforefieldinit'.
			static _getAsync_d__31()
			{
				Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<getAsync>d__31`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr);
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "<>1__state");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "<>t__builder");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "strategyName");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "asset");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "mode");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr_getSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "getSync");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr_getAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "getAsync");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "<>7__wrap1");
				Loader._getAsync_d__31<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, "<>u__1");
				Loader._getAsync_d__31<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, 100666635);
				Loader._getAsync_d__31<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr, 100666636);
			}

			// Token: 0x060023F6 RID: 9206 RVA: 0x0009CBBC File Offset: 0x0009ADBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877266, XrefRangeEnd = 877334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._getAsync_d__31<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023F7 RID: 9207 RVA: 0x0009CBF4 File Offset: 0x0009ADF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877334, XrefRangeEnd = 877339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._getAsync_d__31<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023F8 RID: 9208 RVA: 0x0000FF13 File Offset: 0x0000E113
			public _getAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023F9 RID: 9209 RVA: 0x0000FF1C File Offset: 0x0000E11C
			public _getAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._getAsync_d__31<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009EE RID: 2542
			// (get) Token: 0x060023FA RID: 9210 RVA: 0x0009CC3C File Offset: 0x0009AE3C
			// (set) Token: 0x060023FB RID: 9211 RVA: 0x0000FF2E File Offset: 0x0000E12E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009EF RID: 2543
			// (get) Token: 0x060023FC RID: 9212 RVA: 0x0009CC64 File Offset: 0x0009AE64
			// (set) Token: 0x060023FD RID: 9213 RVA: 0x0000FF49 File Offset: 0x0000E149
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009F0 RID: 2544
			// (get) Token: 0x060023FE RID: 9214 RVA: 0x0009CC94 File Offset: 0x0009AE94
			// (set) Token: 0x060023FF RID: 9215 RVA: 0x0000FF77 File Offset: 0x0000E177
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009F1 RID: 2545
			// (get) Token: 0x06002400 RID: 9216 RVA: 0x0009CCBC File Offset: 0x0009AEBC
			// (set) Token: 0x06002401 RID: 9217 RVA: 0x0000FF96 File Offset: 0x0000E196
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009F2 RID: 2546
			// (get) Token: 0x06002402 RID: 9218 RVA: 0x0009CCE4 File Offset: 0x0009AEE4
			// (set) Token: 0x06002403 RID: 9219 RVA: 0x0000FFB5 File Offset: 0x0000E1B5
			public unsafe LoaderMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x170009F3 RID: 2547
			// (get) Token: 0x06002404 RID: 9220 RVA: 0x0009CD0C File Offset: 0x0009AF0C
			// (set) Token: 0x06002405 RID: 9221 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
			public unsafe Func<AssetLoader, T> getSync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_getSync);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AssetLoader, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_getSync), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x06002406 RID: 9222 RVA: 0x0009CD3C File Offset: 0x0009AF3C
			// (set) Token: 0x06002407 RID: 9223 RVA: 0x0000FFEF File Offset: 0x0000E1EF
			public unsafe Func<AssetLoader, Task<T>> getAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_getAsync);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AssetLoader, Task<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr_getAsync), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x06002408 RID: 9224 RVA: 0x0009CD6C File Offset: 0x0009AF6C
			// (set) Token: 0x06002409 RID: 9225 RVA: 0x0001000E File Offset: 0x0000E20E
			public List<AssetLoader>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___7__wrap1);
					return new List<AssetLoader>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AssetLoader>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AssetLoader>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x0600240A RID: 9226 RVA: 0x0009CD9C File Offset: 0x0009AF9C
			// (set) Token: 0x0600240B RID: 9227 RVA: 0x0001003C File Offset: 0x0000E23C
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._getAsync_d__31<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001891 RID: 6289
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001892 RID: 6290
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001893 RID: 6291
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x04001894 RID: 6292
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001895 RID: 6293
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04001896 RID: 6294
			private static readonly IntPtr NativeFieldInfoPtr_getSync;

			// Token: 0x04001897 RID: 6295
			private static readonly IntPtr NativeFieldInfoPtr_getAsync;

			// Token: 0x04001898 RID: 6296
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001899 RID: 6297
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400189A RID: 6298
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400189B RID: 6299
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200030C RID: 780
		[ObfuscatedName("dwd.core.loader.Loader+<loadAndInstantiateAsync>d__29`1")]
		public sealed class _loadAndInstantiateAsync_d__29<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x0600240C RID: 9228 RVA: 0x0009CDCC File Offset: 0x0009AFCC
			// Note: this type is marked as 'beforefieldinit'.
			static _loadAndInstantiateAsync_d__29()
			{
				Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<loadAndInstantiateAsync>d__29`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr);
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "<>1__state");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "<>t__builder");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "asset");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "parent");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "worldPositionStays");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "context");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "strategyName");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "mode");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, "<>u__1");
				Loader._loadAndInstantiateAsync_d__29<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, 100666637);
				Loader._loadAndInstantiateAsync_d__29<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr, 100666638);
			}

			// Token: 0x0600240D RID: 9229 RVA: 0x0009CF10 File Offset: 0x0009B110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877339, XrefRangeEnd = 877373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._loadAndInstantiateAsync_d__29<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600240E RID: 9230 RVA: 0x0009CF48 File Offset: 0x0009B148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877373, XrefRangeEnd = 877378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._loadAndInstantiateAsync_d__29<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600240F RID: 9231 RVA: 0x0001006A File Offset: 0x0000E26A
			public _loadAndInstantiateAsync_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002410 RID: 9232 RVA: 0x00010073 File Offset: 0x0000E273
			public _loadAndInstantiateAsync_d__29()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._loadAndInstantiateAsync_d__29<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x06002411 RID: 9233 RVA: 0x0009CF90 File Offset: 0x0009B190
			// (set) Token: 0x06002412 RID: 9234 RVA: 0x00010085 File Offset: 0x0000E285
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x06002413 RID: 9235 RVA: 0x0009CFB8 File Offset: 0x0009B1B8
			// (set) Token: 0x06002414 RID: 9236 RVA: 0x000100A0 File Offset: 0x0000E2A0
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x06002415 RID: 9237 RVA: 0x0009CFE8 File Offset: 0x0009B1E8
			// (set) Token: 0x06002416 RID: 9238 RVA: 0x000100CE File Offset: 0x0000E2CE
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x06002417 RID: 9239 RVA: 0x0009D010 File Offset: 0x0009B210
			// (set) Token: 0x06002418 RID: 9240 RVA: 0x000100ED File Offset: 0x0000E2ED
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06002419 RID: 9241 RVA: 0x0009D040 File Offset: 0x0009B240
			// (set) Token: 0x0600241A RID: 9242 RVA: 0x0001010C File Offset: 0x0000E30C
			public unsafe bool worldPositionStays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_worldPositionStays);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
				}
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x0600241B RID: 9243 RVA: 0x0009D068 File Offset: 0x0009B268
			// (set) Token: 0x0600241C RID: 9244 RVA: 0x00010127 File Offset: 0x0000E327
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x0600241D RID: 9245 RVA: 0x0009D098 File Offset: 0x0009B298
			// (set) Token: 0x0600241E RID: 9246 RVA: 0x00010146 File Offset: 0x0000E346
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009FE RID: 2558
			// (get) Token: 0x0600241F RID: 9247 RVA: 0x0009D0C0 File Offset: 0x0009B2C0
			// (set) Token: 0x06002420 RID: 9248 RVA: 0x00010165 File Offset: 0x0000E365
			public unsafe LoaderMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x170009FF RID: 2559
			// (get) Token: 0x06002421 RID: 9249 RVA: 0x0009D0E8 File Offset: 0x0009B2E8
			// (set) Token: 0x06002422 RID: 9250 RVA: 0x00010180 File Offset: 0x0000E380
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAndInstantiateAsync_d__29<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400189C RID: 6300
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400189D RID: 6301
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400189E RID: 6302
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x0400189F RID: 6303
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x040018A0 RID: 6304
			private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

			// Token: 0x040018A1 RID: 6305
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040018A2 RID: 6306
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x040018A3 RID: 6307
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x040018A4 RID: 6308
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040018A5 RID: 6309
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018A6 RID: 6310
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200030D RID: 781
		[ObfuscatedName("dwd.core.loader.Loader+<loadAsync>d__28`1")]
		public sealed class _loadAsync_d__28<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x06002423 RID: 9251 RVA: 0x0009D118 File Offset: 0x0009B318
			// Note: this type is marked as 'beforefieldinit'.
			static _loadAsync_d__28()
			{
				Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<loadAsync>d__28`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr);
				Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, "<>1__state");
				Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, "<>t__builder");
				Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, "asset");
				Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, "context");
				Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, "strategyName");
				Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, "mode");
				Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, "<>u__1");
				Loader._loadAsync_d__28<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, 100666639);
				Loader._loadAsync_d__28<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr, 100666640);
			}

			// Token: 0x06002424 RID: 9252 RVA: 0x0009D234 File Offset: 0x0009B434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877378, XrefRangeEnd = 877411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._loadAsync_d__28<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002425 RID: 9253 RVA: 0x0009D26C File Offset: 0x0009B46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._loadAsync_d__28<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002426 RID: 9254 RVA: 0x000101AE File Offset: 0x0000E3AE
			public _loadAsync_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002427 RID: 9255 RVA: 0x000101B7 File Offset: 0x0000E3B7
			public _loadAsync_d__28()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._loadAsync_d__28<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A00 RID: 2560
			// (get) Token: 0x06002428 RID: 9256 RVA: 0x0009D2B4 File Offset: 0x0009B4B4
			// (set) Token: 0x06002429 RID: 9257 RVA: 0x000101C9 File Offset: 0x0000E3C9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A01 RID: 2561
			// (get) Token: 0x0600242A RID: 9258 RVA: 0x0009D2DC File Offset: 0x0009B4DC
			// (set) Token: 0x0600242B RID: 9259 RVA: 0x000101E4 File Offset: 0x0000E3E4
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x0600242C RID: 9260 RVA: 0x0009D30C File Offset: 0x0009B50C
			// (set) Token: 0x0600242D RID: 9261 RVA: 0x00010212 File Offset: 0x0000E412
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x0600242E RID: 9262 RVA: 0x0009D334 File Offset: 0x0009B534
			// (set) Token: 0x0600242F RID: 9263 RVA: 0x00010231 File Offset: 0x0000E431
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x06002430 RID: 9264 RVA: 0x0009D364 File Offset: 0x0009B564
			// (set) Token: 0x06002431 RID: 9265 RVA: 0x00010250 File Offset: 0x0000E450
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x06002432 RID: 9266 RVA: 0x0009D38C File Offset: 0x0009B58C
			// (set) Token: 0x06002433 RID: 9267 RVA: 0x0001026F File Offset: 0x0000E46F
			public unsafe LoaderMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x06002434 RID: 9268 RVA: 0x0009D3B4 File Offset: 0x0009B5B4
			// (set) Token: 0x06002435 RID: 9269 RVA: 0x0001028A File Offset: 0x0000E48A
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadAsync_d__28<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040018A7 RID: 6311
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018A8 RID: 6312
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040018A9 RID: 6313
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x040018AA RID: 6314
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040018AB RID: 6315
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x040018AC RID: 6316
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x040018AD RID: 6317
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040018AE RID: 6318
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018AF RID: 6319
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200030E RID: 782
		[ObfuscatedName("dwd.core.loader.Loader+<loadSpriteAsync>d__30")]
		public sealed class _loadSpriteAsync_d__30 : ValueType
		{
			// Token: 0x06002436 RID: 9270 RVA: 0x0009D3E4 File Offset: 0x0009B5E4
			// Note: this type is marked as 'beforefieldinit'.
			static _loadSpriteAsync_d__30()
			{
				Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Loader>.NativeClassPtr, "<loadSpriteAsync>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr);
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "<>1__state");
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "<>t__builder");
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "asset");
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_crop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "crop");
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "context");
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "strategyName");
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "mode");
				Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, "<>u__1");
				Loader._loadSpriteAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, 100666641);
				Loader._loadSpriteAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr, 100666642);
			}

			// Token: 0x06002437 RID: 9271 RVA: 0x0009D4D8 File Offset: 0x0009B6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877411, XrefRangeEnd = 877450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._loadSpriteAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002438 RID: 9272 RVA: 0x0009D510 File Offset: 0x0009B710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877450, XrefRangeEnd = 877456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader._loadSpriteAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002439 RID: 9273 RVA: 0x000102B8 File Offset: 0x0000E4B8
			public _loadSpriteAsync_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600243A RID: 9274 RVA: 0x000102C1 File Offset: 0x0000E4C1
			public _loadSpriteAsync_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader._loadSpriteAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x0600243B RID: 9275 RVA: 0x0009D558 File Offset: 0x0009B758
			// (set) Token: 0x0600243C RID: 9276 RVA: 0x000102D3 File Offset: 0x0000E4D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x0600243D RID: 9277 RVA: 0x0009D580 File Offset: 0x0009B780
			// (set) Token: 0x0600243E RID: 9278 RVA: 0x000102EE File Offset: 0x0000E4EE
			public AsyncTaskMethodBuilder<Sprite> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x0600243F RID: 9279 RVA: 0x0009D5B0 File Offset: 0x0009B7B0
			// (set) Token: 0x06002440 RID: 9280 RVA: 0x0001031C File Offset: 0x0000E51C
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06002441 RID: 9281 RVA: 0x0009D5D8 File Offset: 0x0009B7D8
			// (set) Token: 0x06002442 RID: 9282 RVA: 0x0001033B File Offset: 0x0000E53B
			public unsafe string crop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_crop);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_crop), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x06002443 RID: 9283 RVA: 0x0009D600 File Offset: 0x0009B800
			// (set) Token: 0x06002444 RID: 9284 RVA: 0x0001035A File Offset: 0x0000E55A
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x06002445 RID: 9285 RVA: 0x0009D630 File Offset: 0x0009B830
			// (set) Token: 0x06002446 RID: 9286 RVA: 0x00010379 File Offset: 0x0000E579
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06002447 RID: 9287 RVA: 0x0009D658 File Offset: 0x0009B858
			// (set) Token: 0x06002448 RID: 9288 RVA: 0x00010398 File Offset: 0x0000E598
			public unsafe LoaderMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x06002449 RID: 9289 RVA: 0x0009D680 File Offset: 0x0009B880
			// (set) Token: 0x0600244A RID: 9290 RVA: 0x000103B3 File Offset: 0x0000E5B3
			public TaskAwaiter<Sprite> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loader._loadSpriteAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040018B0 RID: 6320
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018B1 RID: 6321
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040018B2 RID: 6322
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x040018B3 RID: 6323
			private static readonly IntPtr NativeFieldInfoPtr_crop;

			// Token: 0x040018B4 RID: 6324
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040018B5 RID: 6325
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x040018B6 RID: 6326
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x040018B7 RID: 6327
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040018B8 RID: 6328
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018B9 RID: 6329
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200030F RID: 783
		private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_Object_0<T>
		{
			// Token: 0x040018BA RID: 6330
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_Load_Public_Static_T_String_Object_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000310 RID: 784
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiate_Public_Static_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x040018BB RID: 6331
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_LoadAndInstantiate_Public_Static_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000311 RID: 785
		private sealed class MethodInfoStoreGeneric_LoadWith_Public_Static_T_String_String_Object_0<T>
		{
			// Token: 0x040018BC RID: 6332
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_LoadWith_Public_Static_T_String_String_Object_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000312 RID: 786
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateWith_Public_Static_T_String_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x040018BD RID: 6333
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_LoadAndInstantiateWith_Public_Static_T_String_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000313 RID: 787
		private sealed class MethodInfoStoreGeneric_LoadAsync_Public_Static_Task_1_T_String_Object_Boolean_0<T>
		{
			// Token: 0x040018BE RID: 6334
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_T_String_Object_Boolean_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000314 RID: 788
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Static_Task_1_T_String_Transform_Boolean_Boolean_Object_0<T>
		{
			// Token: 0x040018BF RID: 6335
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Static_Task_1_T_String_Transform_Boolean_Boolean_Object_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000315 RID: 789
		private sealed class MethodInfoStoreGeneric_LoadAsyncWith_Public_Static_Task_1_T_String_String_Object_Boolean_0<T>
		{
			// Token: 0x040018C0 RID: 6336
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_LoadAsyncWith_Public_Static_Task_1_T_String_String_Object_Boolean_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000316 RID: 790
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateAsyncWith_Public_Static_Task_1_T_String_String_Transform_Boolean_Boolean_Object_0<T>
		{
			// Token: 0x040018C1 RID: 6337
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_LoadAndInstantiateAsyncWith_Public_Static_Task_1_T_String_String_Transform_Boolean_Boolean_Object_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000317 RID: 791
		private sealed class MethodInfoStoreGeneric_loadAsync_Private_Static_Task_1_T_String_String_Object_LoaderMode_0<T>
		{
			// Token: 0x040018C2 RID: 6338
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_loadAsync_Private_Static_Task_1_T_String_String_Object_LoaderMode_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000318 RID: 792
		private sealed class MethodInfoStoreGeneric_loadAndInstantiateAsync_Private_Static_Task_1_T_String_String_Transform_Boolean_LoaderMode_Object_0<T>
		{
			// Token: 0x040018C3 RID: 6339
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_loadAndInstantiateAsync_Private_Static_Task_1_T_String_String_Transform_Boolean_LoaderMode_Object_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000319 RID: 793
		private sealed class MethodInfoStoreGeneric_getAsync_Private_Static_Task_1_T_String_String_LoaderMode_Func_2_AssetLoader_T_Func_2_AssetLoader_Task_1_T_0<T>
		{
			// Token: 0x040018C4 RID: 6340
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_getAsync_Private_Static_Task_1_T_String_String_LoaderMode_Func_2_AssetLoader_T_Func_2_AssetLoader_Task_1_T_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
