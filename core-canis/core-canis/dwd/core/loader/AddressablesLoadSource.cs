using System;
using dwd.core.loader.caching;
using dwd.core.loader.loaders;
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
	// Token: 0x02000178 RID: 376
	public class AddressablesLoadSource : ScriptableObject
	{
		// Token: 0x06001589 RID: 5513 RVA: 0x0006A04C File Offset: 0x0006824C
		// Note: this type is marked as 'beforefieldinit'.
		static AddressablesLoadSource()
		{
			Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "AddressablesLoadSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr);
			AddressablesLoadSource.NativeFieldInfoPtr_componentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, "componentType");
			AddressablesLoadSource.NativeMethodInfoPtr_LoadSync_Public_Virtual_Final_New_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666541);
			AddressablesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666542);
			AddressablesLoadSource.NativeMethodInfoPtr_LoadSprite_Public_Virtual_Final_New_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666543);
			AddressablesLoadSource.NativeMethodInfoPtr_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666544);
			AddressablesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666545);
			AddressablesLoadSource.NativeMethodInfoPtr_LoadSpriteAsync_Public_Virtual_Final_New_Task_1_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666546);
			AddressablesLoadSource.NativeMethodInfoPtr_getReferenceTracker_Private_Static_IReferenceTracker_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666547);
			AddressablesLoadSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, 100666548);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0006A130 File Offset: 0x00068330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876580, XrefRangeEnd = 876618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.MethodInfoStoreGeneric_LoadSync_Public_Virtual_Final_New_T_String_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0006A18C File Offset: 0x0006838C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876618, XrefRangeEnd = 876632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.MethodInfoStoreGeneric_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0006A20C File Offset: 0x0006840C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876632, XrefRangeEnd = 876672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.NativeMethodInfoPtr_LoadSprite_Public_Virtual_Final_New_Sprite_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0006A280 File Offset: 0x00068480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876672, XrefRangeEnd = 876681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.MethodInfoStoreGeneric_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0006A2E4 File Offset: 0x000684E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876681, XrefRangeEnd = 876691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0006A368 File Offset: 0x00068568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876691, XrefRangeEnd = 876707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.NativeMethodInfoPtr_LoadSpriteAsync_Public_Virtual_Final_New_Task_1_Sprite_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0006A3DC File Offset: 0x000685DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 876738, RefRangeEnd = 876750, XrefRangeStart = 876707, XrefRangeEnd = 876738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IReferenceTracker getReferenceTracker(string asset, global::Il2CppSystem.Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.NativeMethodInfoPtr_getReferenceTracker_Private_Static_IReferenceTracker_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr3) : null;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0006A434 File Offset: 0x00068634
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddressablesLoadSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00009808 File Offset: 0x00007A08
		public AddressablesLoadSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0006A470 File Offset: 0x00068670
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00009811 File Offset: 0x00007A11
		public unsafe static Type componentType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressablesLoadSource.NativeFieldInfoPtr_componentType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressablesLoadSource.NativeFieldInfoPtr_componentType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeFieldInfoPtr_componentType;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_LoadSync_Public_Virtual_Final_New_T_String_Object_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_LoadSprite_Public_Virtual_Final_New_Sprite_String_String_Object_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpriteAsync_Public_Virtual_Final_New_Task_1_Sprite_String_String_Object_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_getReferenceTracker_Private_Static_IReferenceTracker_String_Object_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002ED RID: 749
		[ObfuscatedName("dwd.core.loader.AddressablesLoadSource+<LoadAndInstantiateAsync>d__5`1")]
		public sealed class _LoadAndInstantiateAsync_d__5<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x060022A7 RID: 8871 RVA: 0x00099674 File Offset: 0x00097874
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndInstantiateAsync_d__5()
			{
				Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, "<LoadAndInstantiateAsync>d__5`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr);
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "<>1__state");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "<>t__builder");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "asset");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "context");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "parent");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "worldPositionStays");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr__loader_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "<loader>5__2");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, "<>u__1");
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, 100666550);
				AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr, 100666551);
			}

			// Token: 0x060022A8 RID: 8872 RVA: 0x000997A4 File Offset: 0x000979A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876351, XrefRangeEnd = 876392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022A9 RID: 8873 RVA: 0x000997DC File Offset: 0x000979DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876392, XrefRangeEnd = 876397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022AA RID: 8874 RVA: 0x0000EE6A File Offset: 0x0000D06A
			public _LoadAndInstantiateAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022AB RID: 8875 RVA: 0x0000EE73 File Offset: 0x0000D073
			public _LoadAndInstantiateAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x060022AC RID: 8876 RVA: 0x00099824 File Offset: 0x00097A24
			// (set) Token: 0x060022AD RID: 8877 RVA: 0x0000EE85 File Offset: 0x0000D085
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x060022AE RID: 8878 RVA: 0x0009984C File Offset: 0x00097A4C
			// (set) Token: 0x060022AF RID: 8879 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x060022B0 RID: 8880 RVA: 0x0009987C File Offset: 0x00097A7C
			// (set) Token: 0x060022B1 RID: 8881 RVA: 0x0000EECE File Offset: 0x0000D0CE
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000998A4 File Offset: 0x00097AA4
			// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0000EEED File Offset: 0x0000D0ED
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x060022B4 RID: 8884 RVA: 0x000998D4 File Offset: 0x00097AD4
			// (set) Token: 0x060022B5 RID: 8885 RVA: 0x0000EF0C File Offset: 0x0000D10C
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x060022B6 RID: 8886 RVA: 0x00099904 File Offset: 0x00097B04
			// (set) Token: 0x060022B7 RID: 8887 RVA: 0x0000EF2B File Offset: 0x0000D12B
			public unsafe bool worldPositionStays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_worldPositionStays);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
				}
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0009992C File Offset: 0x00097B2C
			// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0000EF46 File Offset: 0x0000D146
			public unsafe PrefabLoader<T> _loader_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr__loader_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLoader<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr__loader_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x060022BA RID: 8890 RVA: 0x0009995C File Offset: 0x00097B5C
			// (set) Token: 0x060022BB RID: 8891 RVA: 0x0000EF65 File Offset: 0x0000D165
			public unsafe global::Il2CppSystem.Object __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___u__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAndInstantiateAsync_d__5<T>.NativeFieldInfoPtr___u__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017EA RID: 6122
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017EB RID: 6123
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040017EC RID: 6124
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x040017ED RID: 6125
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040017EE RID: 6126
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x040017EF RID: 6127
			private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

			// Token: 0x040017F0 RID: 6128
			private static readonly IntPtr NativeFieldInfoPtr__loader_5__2;

			// Token: 0x040017F1 RID: 6129
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040017F2 RID: 6130
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017F3 RID: 6131
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002EE RID: 750
		[ObfuscatedName("dwd.core.loader.AddressablesLoadSource+<LoadAsync>d__4`1")]
		public sealed class _LoadAsync_d__4<T> : ValueType where T : global::UnityEngine.Object
		{
			// Token: 0x060022BC RID: 8892 RVA: 0x0009998C File Offset: 0x00097B8C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__4()
			{
				Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, "<LoadAsync>d__4`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr);
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "<>1__state");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "<>t__builder");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "asset");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "context");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loadedAsset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "<loadedAsset>5__2");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loader_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "<loader>5__3");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "<>u__1");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loader_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, "<loader>5__4");
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, 100666552);
				AddressablesLoadSource._LoadAsync_d__4<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr, 100666553);
			}

			// Token: 0x060022BD RID: 8893 RVA: 0x00099ABC File Offset: 0x00097CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876397, XrefRangeEnd = 876483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource._LoadAsync_d__4<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022BE RID: 8894 RVA: 0x00099AF4 File Offset: 0x00097CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876483, XrefRangeEnd = 876488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource._LoadAsync_d__4<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022BF RID: 8895 RVA: 0x0000EF84 File Offset: 0x0000D184
			public _LoadAsync_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022C0 RID: 8896 RVA: 0x0000EF8D File Offset: 0x0000D18D
			public _LoadAsync_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesLoadSource._LoadAsync_d__4<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x060022C1 RID: 8897 RVA: 0x00099B3C File Offset: 0x00097D3C
			// (set) Token: 0x060022C2 RID: 8898 RVA: 0x0000EF9F File Offset: 0x0000D19F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00099B64 File Offset: 0x00097D64
			// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0000EFBA File Offset: 0x0000D1BA
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000983 RID: 2435
			// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00099B94 File Offset: 0x00097D94
			// (set) Token: 0x060022C6 RID: 8902 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000984 RID: 2436
			// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00099BBC File Offset: 0x00097DBC
			// (set) Token: 0x060022C8 RID: 8904 RVA: 0x0000F007 File Offset: 0x0000D207
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000985 RID: 2437
			// (get) Token: 0x060022C9 RID: 8905 RVA: 0x00099BEC File Offset: 0x00097DEC
			// (set) Token: 0x060022CA RID: 8906 RVA: 0x00099C14 File Offset: 0x00097E14
			public unsafe T _loadedAsset_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loadedAsset_5__2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loadedAsset_5__2);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000986 RID: 2438
			// (get) Token: 0x060022CB RID: 8907 RVA: 0x00099CBC File Offset: 0x00097EBC
			// (set) Token: 0x060022CC RID: 8908 RVA: 0x0000F026 File Offset: 0x0000D226
			public unsafe BundleLoader<GameObject> _loader_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loader_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BundleLoader<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loader_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x060022CD RID: 8909 RVA: 0x00099CEC File Offset: 0x00097EEC
			// (set) Token: 0x060022CE RID: 8910 RVA: 0x0000F045 File Offset: 0x0000D245
			public unsafe global::Il2CppSystem.Object __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___u__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr___u__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000988 RID: 2440
			// (get) Token: 0x060022CF RID: 8911 RVA: 0x00099D1C File Offset: 0x00097F1C
			// (set) Token: 0x060022D0 RID: 8912 RVA: 0x0000F064 File Offset: 0x0000D264
			public unsafe BundleLoader<T> _loader_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loader_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BundleLoader<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadAsync_d__4<T>.NativeFieldInfoPtr__loader_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017F4 RID: 6132
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017F5 RID: 6133
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040017F6 RID: 6134
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x040017F7 RID: 6135
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040017F8 RID: 6136
			private static readonly IntPtr NativeFieldInfoPtr__loadedAsset_5__2;

			// Token: 0x040017F9 RID: 6137
			private static readonly IntPtr NativeFieldInfoPtr__loader_5__3;

			// Token: 0x040017FA RID: 6138
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040017FB RID: 6139
			private static readonly IntPtr NativeFieldInfoPtr__loader_5__4;

			// Token: 0x040017FC RID: 6140
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017FD RID: 6141
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002EF RID: 751
		[ObfuscatedName("dwd.core.loader.AddressablesLoadSource+<LoadSpriteAsync>d__6")]
		public sealed class _LoadSpriteAsync_d__6 : ValueType
		{
			// Token: 0x060022D1 RID: 8913 RVA: 0x00099D4C File Offset: 0x00097F4C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSpriteAsync_d__6()
			{
				Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr, "<LoadSpriteAsync>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr);
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "<>1__state");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "<>t__builder");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "asset");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_crop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "crop");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "context");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__assetName_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "<assetName>5__2");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__cropLoader_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "<cropLoader>5__3");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__spriteThanCropLoader_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "<spriteThanCropLoader>5__4");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "<>u__1");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__spriteAtlasLoader_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, "<spriteAtlasLoader>5__5");
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, 100666554);
				AddressablesLoadSource._LoadSpriteAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr, 100666555);
			}

			// Token: 0x060022D2 RID: 8914 RVA: 0x00099E68 File Offset: 0x00098068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876488, XrefRangeEnd = 876574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022D3 RID: 8915 RVA: 0x00099EA0 File Offset: 0x000980A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876574, XrefRangeEnd = 876580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022D4 RID: 8916 RVA: 0x0000F083 File Offset: 0x0000D283
			public _LoadSpriteAsync_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022D5 RID: 8917 RVA: 0x0000F08C File Offset: 0x0000D28C
			public _LoadSpriteAsync_d__6()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesLoadSource._LoadSpriteAsync_d__6>.NativeClassPtr))
			{
			}

			// Token: 0x17000989 RID: 2441
			// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00099EE8 File Offset: 0x000980E8
			// (set) Token: 0x060022D7 RID: 8919 RVA: 0x0000F09E File Offset: 0x0000D29E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x060022D8 RID: 8920 RVA: 0x00099F10 File Offset: 0x00098110
			// (set) Token: 0x060022D9 RID: 8921 RVA: 0x0000F0B9 File Offset: 0x0000D2B9
			public AsyncTaskMethodBuilder<Sprite> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700098B RID: 2443
			// (get) Token: 0x060022DA RID: 8922 RVA: 0x00099F40 File Offset: 0x00098140
			// (set) Token: 0x060022DB RID: 8923 RVA: 0x0000F0E7 File Offset: 0x0000D2E7
			public unsafe string asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_asset);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_asset), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700098C RID: 2444
			// (get) Token: 0x060022DC RID: 8924 RVA: 0x00099F68 File Offset: 0x00098168
			// (set) Token: 0x060022DD RID: 8925 RVA: 0x0000F106 File Offset: 0x0000D306
			public unsafe string crop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_crop);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_crop), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700098D RID: 2445
			// (get) Token: 0x060022DE RID: 8926 RVA: 0x00099F90 File Offset: 0x00098190
			// (set) Token: 0x060022DF RID: 8927 RVA: 0x0000F125 File Offset: 0x0000D325
			public unsafe global::Il2CppSystem.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098E RID: 2446
			// (get) Token: 0x060022E0 RID: 8928 RVA: 0x00099FC0 File Offset: 0x000981C0
			// (set) Token: 0x060022E1 RID: 8929 RVA: 0x0000F144 File Offset: 0x0000D344
			public unsafe string _assetName_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__assetName_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__assetName_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700098F RID: 2447
			// (get) Token: 0x060022E2 RID: 8930 RVA: 0x00099FE8 File Offset: 0x000981E8
			// (set) Token: 0x060022E3 RID: 8931 RVA: 0x0000F163 File Offset: 0x0000D363
			public unsafe SingleSpriteBundleLoader _cropLoader_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__cropLoader_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__cropLoader_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000990 RID: 2448
			// (get) Token: 0x060022E4 RID: 8932 RVA: 0x0009A018 File Offset: 0x00098218
			// (set) Token: 0x060022E5 RID: 8933 RVA: 0x0000F182 File Offset: 0x0000D382
			public unsafe SpriteBundleLoader _spriteThanCropLoader_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__spriteThanCropLoader_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__spriteThanCropLoader_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000991 RID: 2449
			// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0009A048 File Offset: 0x00098248
			// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0000F1A1 File Offset: 0x0000D3A1
			public unsafe global::Il2CppSystem.Object __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___u__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr___u__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000992 RID: 2450
			// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0009A078 File Offset: 0x00098278
			// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0000F1C0 File Offset: 0x0000D3C0
			public unsafe SpriteAtlasLoader _spriteAtlasLoader_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__spriteAtlasLoader_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesLoadSource._LoadSpriteAsync_d__6.NativeFieldInfoPtr__spriteAtlasLoader_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017FE RID: 6142
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017FF RID: 6143
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001800 RID: 6144
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04001801 RID: 6145
			private static readonly IntPtr NativeFieldInfoPtr_crop;

			// Token: 0x04001802 RID: 6146
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001803 RID: 6147
			private static readonly IntPtr NativeFieldInfoPtr__assetName_5__2;

			// Token: 0x04001804 RID: 6148
			private static readonly IntPtr NativeFieldInfoPtr__cropLoader_5__3;

			// Token: 0x04001805 RID: 6149
			private static readonly IntPtr NativeFieldInfoPtr__spriteThanCropLoader_5__4;

			// Token: 0x04001806 RID: 6150
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001807 RID: 6151
			private static readonly IntPtr NativeFieldInfoPtr__spriteAtlasLoader_5__5;

			// Token: 0x04001808 RID: 6152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001809 RID: 6153
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002F0 RID: 752
		private sealed class MethodInfoStoreGeneric_LoadSync_Public_Virtual_Final_New_T_String_Object_0<T>
		{
			// Token: 0x0400180A RID: 6154
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesLoadSource.NativeMethodInfoPtr_LoadSync_Public_Virtual_Final_New_T_String_Object_0, Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002F1 RID: 753
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x0400180B RID: 6155
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Virtual_Final_New_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002F2 RID: 754
		private sealed class MethodInfoStoreGeneric_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0<T>
		{
			// Token: 0x0400180C RID: 6156
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesLoadSource.NativeMethodInfoPtr_LoadAsync_Public_Virtual_Final_New_Task_1_T_String_Object_0, Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002F3 RID: 755
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x0400180D RID: 6157
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesLoadSource.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Virtual_Final_New_Task_1_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<AddressablesLoadSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
