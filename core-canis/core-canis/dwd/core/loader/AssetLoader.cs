using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace dwd.core.loader
{
	// Token: 0x02000179 RID: 377
	public sealed class AssetLoader : ScriptableObject
	{
		// Token: 0x06001595 RID: 5525 RVA: 0x0006A498 File Offset: 0x00068698
		// Note: this type is marked as 'beforefieldinit'.
		static AssetLoader()
		{
			Il2CppClassPointerStore<AssetLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "AssetLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr);
			AssetLoader.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "mode");
			AssetLoader.NativeFieldInfoPtr_loadSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "loadSource");
			AssetLoader.NativeFieldInfoPtr_assetNameFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "assetNameFormatter");
			AssetLoader.NativeMethodInfoPtr_Load_Internal_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666556);
			AssetLoader.NativeMethodInfoPtr_LoadAndInstantiate_Internal_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666557);
			AssetLoader.NativeMethodInfoPtr_LoadSprite_Internal_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666558);
			AssetLoader.NativeMethodInfoPtr_LoadAsync_Internal_Task_1_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666559);
			AssetLoader.NativeMethodInfoPtr_LoadAndInstantiateAsync_Internal_Task_1_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666560);
			AssetLoader.NativeMethodInfoPtr_LoadSpriteAsync_Internal_Task_1_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666561);
			AssetLoader.NativeMethodInfoPtr_assertConfiguration_Private_Void_LoaderMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666562);
			AssetLoader.NativeMethodInfoPtr_getFormattedAssetName_Private_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666563);
			AssetLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666564);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0006A5B8 File Offset: 0x000687B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876879, RefRangeEnd = 876880, XrefRangeStart = 876858, XrefRangeEnd = 876879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Load<T>(string asset, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_Load_Internal_T_String_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0006A614 File Offset: 0x00068814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876901, RefRangeEnd = 876902, XrefRangeStart = 876880, XrefRangeEnd = 876901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadAndInstantiate<T>(string asset, Transform parent, bool worldPositionStays, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_LoadAndInstantiate_Internal_T_String_Transform_Boolean_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0006A694 File Offset: 0x00068894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876924, RefRangeEnd = 876925, XrefRangeStart = 876902, XrefRangeEnd = 876924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite LoadSprite(string asset, string crop, global::Il2CppSystem.Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr_LoadSprite_Internal_Sprite_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0006A708 File Offset: 0x00068908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876935, RefRangeEnd = 876936, XrefRangeStart = 876925, XrefRangeEnd = 876935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<T> LoadAsync<T>(string asset, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_LoadAsync_Internal_Task_1_T_String_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0006A76C File Offset: 0x0006896C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876947, RefRangeEnd = 876948, XrefRangeStart = 876936, XrefRangeEnd = 876947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<T> LoadAndInstantiateAsync<T>(string asset, Transform parent, bool worldPositionStays, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_LoadAndInstantiateAsync_Internal_Task_1_T_String_Transform_Boolean_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0006A7F0 File Offset: 0x000689F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876948, XrefRangeEnd = 876965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Sprite> LoadSpriteAsync(string asset, string crop, global::Il2CppSystem.Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr_LoadSpriteAsync_Internal_Task_1_Sprite_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0006A864 File Offset: 0x00068A64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 876969, RefRangeEnd = 876975, XrefRangeStart = 876965, XrefRangeEnd = 876969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void assertConfiguration(LoaderMode validMode, Type validLoaderType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref validMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validLoaderType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr_assertConfiguration_Private_Void_LoaderMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0006A8B4 File Offset: 0x00068AB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 876980, RefRangeEnd = 876985, XrefRangeStart = 876975, XrefRangeEnd = 876980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getFormattedAssetName(string asset, Type assetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr_getFormattedAssetName_Private_String_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0006A910 File Offset: 0x00068B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876985, XrefRangeEnd = 876986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00009823 File Offset: 0x00007A23
		public AssetLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0006A94C File Offset: 0x00068B4C
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0000982C File Offset: 0x00007A2C
		public unsafe LoaderMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0006A974 File Offset: 0x00068B74
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x00009847 File Offset: 0x00007A47
		public unsafe ScriptableObject loadSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_loadSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_loadSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x0006A9A4 File Offset: 0x00068BA4
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00009866 File Offset: 0x00007A66
		public unsafe AssetNameFormatter assetNameFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_assetNameFormatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetNameFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_assetNameFormatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr_loadSource;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeFieldInfoPtr_assetNameFormatter;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_T_String_Object_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiate_Internal_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_LoadSprite_Internal_Sprite_String_String_Object_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Internal_Task_1_T_String_Object_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateAsync_Internal_Task_1_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpriteAsync_Internal_Task_1_Sprite_String_String_Object_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_assertConfiguration_Private_Void_LoaderMode_Type_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_getFormattedAssetName_Private_String_String_Type_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F4 RID: 756
		[ObfuscatedName("dwd.core.loader.AssetLoader+<LoadAndInstantiateAsync>d__7`1")]
		public sealed class _LoadAndInstantiateAsync_d__7<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x060022EE RID: 8942 RVA: 0x0009A1F8 File Offset: 0x000983F8
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndInstantiateAsync_d__7()
			{
				Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "<LoadAndInstantiateAsync>d__7`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr);
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "<>1__state");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "<>t__builder");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "<>4__this");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "asset");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "parent");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "worldPositionStays");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "context");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, "<>u__1");
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, 100666565);
				AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr, 100666566);
			}

			// Token: 0x060022EF RID: 8943 RVA: 0x0009A328 File Offset: 0x00098528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876750, XrefRangeEnd = 876780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022F0 RID: 8944 RVA: 0x0009A360 File Offset: 0x00098560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876780, XrefRangeEnd = 876785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022F1 RID: 8945 RVA: 0x0000F1DF File Offset: 0x0000D3DF
			public _LoadAndInstantiateAsync_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022F2 RID: 8946 RVA: 0x0000F1E8 File Offset: 0x0000D3E8
			public _LoadAndInstantiateAsync_d__7()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLoader._LoadAndInstantiateAsync_d__7<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000993 RID: 2451
			// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0009A3A8 File Offset: 0x000985A8
			// (set) Token: 0x060022F4 RID: 8948 RVA: 0x0000F1FA File Offset: 0x0000D3FA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000994 RID: 2452
			// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0009A3D0 File Offset: 0x000985D0
			// (set) Token: 0x060022F6 RID: 8950 RVA: 0x0000F215 File Offset: 0x0000D415
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000995 RID: 2453
			// (get) Token: 0x060022F7 RID: 8951 RVA: 0x0009A400 File Offset: 0x00098600
			// (set) Token: 0x060022F8 RID: 8952 RVA: 0x0000F243 File Offset: 0x0000D443
			public unsafe AssetLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000996 RID: 2454
			// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0009A430 File Offset: 0x00098630
			// (set) Token: 0x060022FA RID: 8954 RVA: 0x0000F262 File Offset: 0x0000D462
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x060022FB RID: 8955 RVA: 0x0009A458 File Offset: 0x00098658
			// (set) Token: 0x060022FC RID: 8956 RVA: 0x0000F281 File Offset: 0x0000D481
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x060022FD RID: 8957 RVA: 0x0009A488 File Offset: 0x00098688
			// (set) Token: 0x060022FE RID: 8958 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
			public unsafe bool worldPositionStays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_worldPositionStays);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
				}
			}

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x060022FF RID: 8959 RVA: 0x0009A4B0 File Offset: 0x000986B0
			// (set) Token: 0x06002300 RID: 8960 RVA: 0x0000F2BB File Offset: 0x0000D4BB
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099A RID: 2458
			// (get) Token: 0x06002301 RID: 8961 RVA: 0x0009A4E0 File Offset: 0x000986E0
			// (set) Token: 0x06002302 RID: 8962 RVA: 0x0000F2DA File Offset: 0x0000D4DA
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAndInstantiateAsync_d__7<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400180E RID: 6158
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400180F RID: 6159
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001810 RID: 6160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001811 RID: 6161
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001812 RID: 6162
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04001813 RID: 6163
			private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

			// Token: 0x04001814 RID: 6164
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001815 RID: 6165
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001816 RID: 6166
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001817 RID: 6167
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002F5 RID: 757
		[ObfuscatedName("dwd.core.loader.AssetLoader+<LoadAsync>d__6`1")]
		public sealed class _LoadAsync_d__6<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x06002303 RID: 8963 RVA: 0x0009A510 File Offset: 0x00098710
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__6()
			{
				Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "<LoadAsync>d__6`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr);
				AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, "<>1__state");
				AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, "<>t__builder");
				AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, "<>4__this");
				AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, "asset");
				AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, "context");
				AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, "<>u__1");
				AssetLoader._LoadAsync_d__6<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, 100666567);
				AssetLoader._LoadAsync_d__6<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr, 100666568);
			}

			// Token: 0x06002304 RID: 8964 RVA: 0x0009A618 File Offset: 0x00098818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876785, XrefRangeEnd = 876812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader._LoadAsync_d__6<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002305 RID: 8965 RVA: 0x0009A650 File Offset: 0x00098850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876812, XrefRangeEnd = 876817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader._LoadAsync_d__6<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002306 RID: 8966 RVA: 0x0000F308 File Offset: 0x0000D508
			public _LoadAsync_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002307 RID: 8967 RVA: 0x0000F311 File Offset: 0x0000D511
			public _LoadAsync_d__6()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLoader._LoadAsync_d__6<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700099B RID: 2459
			// (get) Token: 0x06002308 RID: 8968 RVA: 0x0009A698 File Offset: 0x00098898
			// (set) Token: 0x06002309 RID: 8969 RVA: 0x0000F323 File Offset: 0x0000D523
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700099C RID: 2460
			// (get) Token: 0x0600230A RID: 8970 RVA: 0x0009A6C0 File Offset: 0x000988C0
			// (set) Token: 0x0600230B RID: 8971 RVA: 0x0000F33E File Offset: 0x0000D53E
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700099D RID: 2461
			// (get) Token: 0x0600230C RID: 8972 RVA: 0x0009A6F0 File Offset: 0x000988F0
			// (set) Token: 0x0600230D RID: 8973 RVA: 0x0000F36C File Offset: 0x0000D56C
			public unsafe AssetLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099E RID: 2462
			// (get) Token: 0x0600230E RID: 8974 RVA: 0x0009A720 File Offset: 0x00098920
			// (set) Token: 0x0600230F RID: 8975 RVA: 0x0000F38B File Offset: 0x0000D58B
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x06002310 RID: 8976 RVA: 0x0009A748 File Offset: 0x00098948
			// (set) Token: 0x06002311 RID: 8977 RVA: 0x0000F3AA File Offset: 0x0000D5AA
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x06002312 RID: 8978 RVA: 0x0009A778 File Offset: 0x00098978
			// (set) Token: 0x06002313 RID: 8979 RVA: 0x0000F3C9 File Offset: 0x0000D5C9
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadAsync_d__6<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001818 RID: 6168
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001819 RID: 6169
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400181A RID: 6170
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400181B RID: 6171
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x0400181C RID: 6172
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400181D RID: 6173
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400181E RID: 6174
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400181F RID: 6175
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002F6 RID: 758
		[ObfuscatedName("dwd.core.loader.AssetLoader+<LoadSpriteAsync>d__8")]
		public sealed class _LoadSpriteAsync_d__8 : ValueType
		{
			// Token: 0x06002314 RID: 8980 RVA: 0x0009A7A8 File Offset: 0x000989A8
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSpriteAsync_d__8()
			{
				Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "<LoadSpriteAsync>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr);
				AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, "<>1__state");
				AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, "<>t__builder");
				AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, "<>4__this");
				AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, "asset");
				AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_crop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, "crop");
				AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, "context");
				AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, "<>u__1");
				AssetLoader._LoadSpriteAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, 100666569);
				AssetLoader._LoadSpriteAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr, 100666570);
			}

			// Token: 0x06002315 RID: 8981 RVA: 0x0009A888 File Offset: 0x00098A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876817, XrefRangeEnd = 876852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader._LoadSpriteAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002316 RID: 8982 RVA: 0x0009A8C0 File Offset: 0x00098AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876852, XrefRangeEnd = 876858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetLoader._LoadSpriteAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002317 RID: 8983 RVA: 0x0000F3F7 File Offset: 0x0000D5F7
			public _LoadSpriteAsync_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x0000F400 File Offset: 0x0000D600
			public _LoadSpriteAsync_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLoader._LoadSpriteAsync_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x170009A1 RID: 2465
			// (get) Token: 0x06002319 RID: 8985 RVA: 0x0009A908 File Offset: 0x00098B08
			// (set) Token: 0x0600231A RID: 8986 RVA: 0x0000F412 File Offset: 0x0000D612
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009A2 RID: 2466
			// (get) Token: 0x0600231B RID: 8987 RVA: 0x0009A930 File Offset: 0x00098B30
			// (set) Token: 0x0600231C RID: 8988 RVA: 0x0000F42D File Offset: 0x0000D62D
			public AsyncTaskMethodBuilder<Sprite> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009A3 RID: 2467
			// (get) Token: 0x0600231D RID: 8989 RVA: 0x0009A960 File Offset: 0x00098B60
			// (set) Token: 0x0600231E RID: 8990 RVA: 0x0000F45B File Offset: 0x0000D65B
			public unsafe AssetLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x0600231F RID: 8991 RVA: 0x0009A990 File Offset: 0x00098B90
			// (set) Token: 0x06002320 RID: 8992 RVA: 0x0000F47A File Offset: 0x0000D67A
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x06002321 RID: 8993 RVA: 0x0009A9B8 File Offset: 0x00098BB8
			// (set) Token: 0x06002322 RID: 8994 RVA: 0x0000F499 File Offset: 0x0000D699
			public unsafe string crop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_crop);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_crop), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009A6 RID: 2470
			// (get) Token: 0x06002323 RID: 8995 RVA: 0x0009A9E0 File Offset: 0x00098BE0
			// (set) Token: 0x06002324 RID: 8996 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A7 RID: 2471
			// (get) Token: 0x06002325 RID: 8997 RVA: 0x0009AA10 File Offset: 0x00098C10
			// (set) Token: 0x06002326 RID: 8998 RVA: 0x0000F4D7 File Offset: 0x0000D6D7
			public TaskAwaiter<Sprite> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetLoader._LoadSpriteAsync_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001820 RID: 6176
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001821 RID: 6177
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001822 RID: 6178
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001823 RID: 6179
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001824 RID: 6180
			private static readonly IntPtr NativeFieldInfoPtr_crop;

			// Token: 0x04001825 RID: 6181
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001826 RID: 6182
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001827 RID: 6183
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001828 RID: 6184
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002F7 RID: 759
		private sealed class MethodInfoStoreGeneric_Load_Internal_T_String_Object_0<T>
		{
			// Token: 0x04001829 RID: 6185
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_Load_Internal_T_String_Object_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002F8 RID: 760
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiate_Internal_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x0400182A RID: 6186
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_LoadAndInstantiate_Internal_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002F9 RID: 761
		private sealed class MethodInfoStoreGeneric_LoadAsync_Internal_Task_1_T_String_Object_0<T>
		{
			// Token: 0x0400182B RID: 6187
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_LoadAsync_Internal_Task_1_T_String_Object_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002FA RID: 762
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateAsync_Internal_Task_1_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x0400182C RID: 6188
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_LoadAndInstantiateAsync_Internal_Task_1_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
