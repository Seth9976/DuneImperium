using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace dwd.core.loader
{
	// Token: 0x02000181 RID: 385
	public class ResourcesLoadSource : ScriptableObject
	{
		// Token: 0x060015E5 RID: 5605 RVA: 0x0006BF40 File Offset: 0x0006A140
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesLoadSource()
		{
			Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "ResourcesLoadSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr);
			ResourcesLoadSource.NativeMethodInfoPtr_LoadSync_Public_Virtual_Final_New_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666644);
			ResourcesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666645);
			ResourcesLoadSource.NativeMethodInfoPtr_LoadSprite_Public_Virtual_Final_New_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666646);
			ResourcesLoadSource.NativeMethodInfoPtr_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666647);
			ResourcesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666648);
			ResourcesLoadSource.NativeMethodInfoPtr_LoadSpriteAsync_Public_Virtual_Final_New_Task_1_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666649);
			ResourcesLoadSource.NativeMethodInfoPtr_instantiate_Private_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666650);
			ResourcesLoadSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, 100666651);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0006C010 File Offset: 0x0006A210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877922, XrefRangeEnd = 877930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T LoadSync<T>(string asset, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.MethodInfoStoreGeneric_LoadSync_Public_Virtual_Final_New_T_String_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0006C06C File Offset: 0x0006A26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877930, XrefRangeEnd = 877949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T LoadAndInstantiateSync<T>(string asset, Transform parent, bool worldPositionStays, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.MethodInfoStoreGeneric_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0006C0EC File Offset: 0x0006A2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877949, XrefRangeEnd = 877958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Sprite LoadSprite(string asset, string crop, global::Il2CppSystem.Object context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.NativeMethodInfoPtr_LoadSprite_Public_Virtual_Final_New_Sprite_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0006C160 File Offset: 0x0006A360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 877966, RefRangeEnd = 877967, XrefRangeStart = 877958, XrefRangeEnd = 877966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<T> LoadAsync<T>(string asset, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.MethodInfoStoreGeneric_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0006C1C4 File Offset: 0x0006A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877967, XrefRangeEnd = 877978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<T> LoadAndInstantiateAsync<T>(string asset, Transform parent, bool worldPositionStays, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0006C248 File Offset: 0x0006A448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877978, XrefRangeEnd = 878002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Sprite> LoadSpriteAsync(string asset, string crop, global::Il2CppSystem.Object context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.NativeMethodInfoPtr_LoadSpriteAsync_Public_Virtual_Final_New_Task_1_Sprite_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0006C2BC File Offset: 0x0006A4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878011, RefRangeEnd = 878012, XrefRangeStart = 878002, XrefRangeEnd = 878011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T instantiate<T>(T loadedAsset, Transform parent, bool worldPositionStays) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = loadedAsset;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref loadedAsset;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.MethodInfoStoreGeneric_instantiate_Private_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0006C350 File Offset: 0x0006A550
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourcesLoadSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x0000995B File Offset: 0x00007B5B
		public ResourcesLoadSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_LoadSync_Public_Virtual_Final_New_T_String_Object_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_LoadSprite_Public_Virtual_Final_New_Sprite_String_String_Object_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpriteAsync_Public_Virtual_Final_New_Task_1_Sprite_String_String_Object_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_instantiate_Private_Static_T_T_Transform_Boolean_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031A RID: 794
		[ObfuscatedName("dwd.core.loader.ResourcesLoadSource+<LoadAndInstantiateAsync>d__4`1")]
		public sealed class _LoadAndInstantiateAsync_d__4<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x06002456 RID: 9302 RVA: 0x0009DA4C File Offset: 0x0009BC4C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndInstantiateAsync_d__4()
			{
				Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, "<LoadAndInstantiateAsync>d__4`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr);
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "<>1__state");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "<>t__builder");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "<>4__this");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "asset");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "context");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "parent");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "worldPositionStays");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, "<>u__1");
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, 100666652);
				ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr, 100666653);
			}

			// Token: 0x06002457 RID: 9303 RVA: 0x0009DB7C File Offset: 0x0009BD7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877873, XrefRangeEnd = 877889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002458 RID: 9304 RVA: 0x0009DBB4 File Offset: 0x0009BDB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877889, XrefRangeEnd = 877894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002459 RID: 9305 RVA: 0x000103E1 File Offset: 0x0000E5E1
			public _LoadAndInstantiateAsync_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600245A RID: 9306 RVA: 0x000103EA File Offset: 0x0000E5EA
			public _LoadAndInstantiateAsync_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x0600245B RID: 9307 RVA: 0x0009DBFC File Offset: 0x0009BDFC
			// (set) Token: 0x0600245C RID: 9308 RVA: 0x000103FC File Offset: 0x0000E5FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x0600245D RID: 9309 RVA: 0x0009DC24 File Offset: 0x0009BE24
			// (set) Token: 0x0600245E RID: 9310 RVA: 0x00010417 File Offset: 0x0000E617
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x0600245F RID: 9311 RVA: 0x0009DC54 File Offset: 0x0009BE54
			// (set) Token: 0x06002460 RID: 9312 RVA: 0x00010445 File Offset: 0x0000E645
			public unsafe ResourcesLoadSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourcesLoadSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x06002461 RID: 9313 RVA: 0x0009DC84 File Offset: 0x0009BE84
			// (set) Token: 0x06002462 RID: 9314 RVA: 0x00010464 File Offset: 0x0000E664
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x06002463 RID: 9315 RVA: 0x0009DCAC File Offset: 0x0009BEAC
			// (set) Token: 0x06002464 RID: 9316 RVA: 0x00010483 File Offset: 0x0000E683
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x06002465 RID: 9317 RVA: 0x0009DCDC File Offset: 0x0009BEDC
			// (set) Token: 0x06002466 RID: 9318 RVA: 0x000104A2 File Offset: 0x0000E6A2
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06002467 RID: 9319 RVA: 0x0009DD0C File Offset: 0x0009BF0C
			// (set) Token: 0x06002468 RID: 9320 RVA: 0x000104C1 File Offset: 0x0000E6C1
			public unsafe bool worldPositionStays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_worldPositionStays);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
				}
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x06002469 RID: 9321 RVA: 0x0009DD34 File Offset: 0x0009BF34
			// (set) Token: 0x0600246A RID: 9322 RVA: 0x000104DC File Offset: 0x0000E6DC
			public TaskAwaiter<T> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAndInstantiateAsync_d__4<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040018C5 RID: 6341
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018C6 RID: 6342
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040018C7 RID: 6343
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018C8 RID: 6344
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x040018C9 RID: 6345
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040018CA RID: 6346
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x040018CB RID: 6347
			private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

			// Token: 0x040018CC RID: 6348
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040018CD RID: 6349
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018CE RID: 6350
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200031B RID: 795
		[ObfuscatedName("dwd.core.loader.ResourcesLoadSource+<LoadAsync>d__3`1")]
		public sealed class _LoadAsync_d__3<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x0600246B RID: 9323 RVA: 0x0009DD64 File Offset: 0x0009BF64
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__3()
			{
				Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr, "<LoadAsync>d__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr);
				ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr, "<>1__state");
				ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr, "<>t__builder");
				ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr, "asset");
				ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr, "<>u__1");
				ResourcesLoadSource._LoadAsync_d__3<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr, 100666654);
				ResourcesLoadSource._LoadAsync_d__3<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr, 100666655);
			}

			// Token: 0x0600246C RID: 9324 RVA: 0x0009DE44 File Offset: 0x0009C044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877894, XrefRangeEnd = 877917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource._LoadAsync_d__3<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600246D RID: 9325 RVA: 0x0009DE7C File Offset: 0x0009C07C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 877917, XrefRangeEnd = 877922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesLoadSource._LoadAsync_d__3<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600246E RID: 9326 RVA: 0x0001050A File Offset: 0x0000E70A
			public _LoadAsync_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600246F RID: 9327 RVA: 0x00010513 File Offset: 0x0000E713
			public _LoadAsync_d__3()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcesLoadSource._LoadAsync_d__3<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x06002470 RID: 9328 RVA: 0x0009DEC4 File Offset: 0x0009C0C4
			// (set) Token: 0x06002471 RID: 9329 RVA: 0x00010525 File Offset: 0x0000E725
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x06002472 RID: 9330 RVA: 0x0009DEEC File Offset: 0x0009C0EC
			// (set) Token: 0x06002473 RID: 9331 RVA: 0x00010540 File Offset: 0x0000E740
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x06002474 RID: 9332 RVA: 0x0009DF1C File Offset: 0x0009C11C
			// (set) Token: 0x06002475 RID: 9333 RVA: 0x0001056E File Offset: 0x0000E76E
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x06002476 RID: 9334 RVA: 0x0009DF44 File Offset: 0x0009C144
			// (set) Token: 0x06002477 RID: 9335 RVA: 0x0001058D File Offset: 0x0000E78D
			public unsafe global::Il2CppSystem.Object __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___u__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourcesLoadSource._LoadAsync_d__3<T>.NativeFieldInfoPtr___u__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018CF RID: 6351
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018D0 RID: 6352
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040018D1 RID: 6353
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x040018D2 RID: 6354
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040018D3 RID: 6355
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018D4 RID: 6356
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200031C RID: 796
		private sealed class MethodInfoStoreGeneric_LoadSync_Public_Virtual_Final_New_T_String_Object_0<T>
		{
			// Token: 0x040018D5 RID: 6357
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourcesLoadSource.NativeMethodInfoPtr_LoadSync_Public_Virtual_Final_New_T_String_Object_0, Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031D RID: 797
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x040018D6 RID: 6358
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourcesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031E RID: 798
		private sealed class MethodInfoStoreGeneric_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0<T>
		{
			// Token: 0x040018D7 RID: 6359
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourcesLoadSource.NativeMethodInfoPtr_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0, Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031F RID: 799
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x040018D8 RID: 6360
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourcesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000320 RID: 800
		private sealed class MethodInfoStoreGeneric_instantiate_Private_Static_T_T_Transform_Boolean_0<T>
		{
			// Token: 0x040018D9 RID: 6361
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourcesLoadSource.NativeMethodInfoPtr_instantiate_Private_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<ResourcesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
