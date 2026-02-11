using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200006E RID: 110
	public class SingletonMonoBehavior<TComponent> : MonoBehaviour where TComponent : MonoBehaviour
	{
		// Token: 0x06000A24 RID: 2596 RVA: 0x0002C11C File Offset: 0x0002A31C
		// Note: this type is marked as 'beforefieldinit'.
		static SingletonMonoBehavior()
		{
			Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "SingletonMonoBehavior`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr);
			SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, "instance");
			SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_hasInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, "hasInstance");
			SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_instanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, "instanceId");
			SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, "lockObject");
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664665);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_EnforceSingleton_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664666);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_IsTheSingleton_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664667);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_IsNotTheSingleton_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664668);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_FindInstances_Private_Static_Il2CppArrayBase_1_TComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664669);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_FindFirstInstance_Private_Static_TComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664670);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664671);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664672);
			SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, 100664673);
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0002C28C File Offset: 0x0002A48C
		public unsafe static TComponent Instance
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 790515, RefRangeEnd = 790556, XrefRangeStart = 790461, XrefRangeEnd = 790515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TComponent>(intPtr, false, true);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002C2BC File Offset: 0x0002A4BC
		public unsafe bool EnforceSingleton
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 790566, RefRangeEnd = 790568, XrefRangeStart = 790556, XrefRangeEnd = 790566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_EnforceSingleton_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		public unsafe bool IsTheSingleton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790568, XrefRangeEnd = 790579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_IsTheSingleton_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0002C334 File Offset: 0x0002A534
		public unsafe bool IsNotTheSingleton
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 790590, RefRangeEnd = 790597, XrefRangeStart = 790579, XrefRangeEnd = 790590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_get_IsNotTheSingleton_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002C370 File Offset: 0x0002A570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 790625, RefRangeEnd = 790628, XrefRangeStart = 790597, XrefRangeEnd = 790625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<TComponent> FindInstances()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_FindInstances_Private_Static_Il2CppArrayBase_1_TComponent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<TComponent>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0002C39C File Offset: 0x0002A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790628, XrefRangeEnd = 790633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TComponent FindFirstInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_FindFirstInstance_Private_Static_TComponent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TComponent>(intPtr, false, true);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790633, XrefRangeEnd = 790680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002C408 File Offset: 0x0002A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790680, XrefRangeEnd = 790694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0002C444 File Offset: 0x0002A644
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingletonMonoBehavior()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public SingletonMonoBehavior(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002C480 File Offset: 0x0002A680
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0002C4A4 File Offset: 0x0002A6A4
		public unsafe static TComponent instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<TComponent>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_instance = SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_instance;
				ref TComponent ptr2;
				if (!typeof(TComponent).IsValueType)
				{
					TComponent tcomponent = value;
					if (!(tcomponent is string))
					{
						ref TComponent ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(tcomponent as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(tcomponent as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_instance, (void*)(&ptr2));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0002C50C File Offset: 0x0002A70C
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00005DF9 File Offset: 0x00003FF9
		public unsafe static bool hasInstance
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_hasInstance, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_hasInstance, (void*)(&value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002C528 File Offset: 0x0002A728
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00005E07 File Offset: 0x00004007
		public unsafe static int instanceId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_instanceId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_instanceId, (void*)(&value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0002C544 File Offset: 0x0002A744
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00005E15 File Offset: 0x00004015
		public unsafe static global::Il2CppSystem.Object lockObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_lockObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SingletonMonoBehavior<TComponent>.NativeFieldInfoPtr_lockObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_hasInstance;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_instanceId;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_lockObject;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TComponent_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_get_EnforceSingleton_Protected_get_Boolean_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTheSingleton_Protected_get_Boolean_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotTheSingleton_Protected_get_Boolean_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_FindInstances_Private_Static_Il2CppArrayBase_1_TComponent_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstInstance_Private_Static_TComponent_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200021F RID: 543
		[ObfuscatedName("InControl.SingletonMonoBehavior`1+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060011BE RID: 4542 RVA: 0x00045AA4 File Offset: 0x00043CA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr);
				SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr, "<>9");
				SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr, "<>9__12_0");
				SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr, "<>9__14_0");
				SingletonMonoBehavior<TComponent>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr, 100664676);
				SingletonMonoBehavior<TComponent>.__c.NativeMethodInfoPtr__FindInstances_b__12_0_Internal_Int32_TComponent_TComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr, 100664677);
				SingletonMonoBehavior<TComponent>.__c.NativeMethodInfoPtr__Awake_b__14_0_Internal_Boolean_TComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr, 100664678);
			}

			// Token: 0x060011BF RID: 4543 RVA: 0x00045B84 File Offset: 0x00043D84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingletonMonoBehavior<TComponent>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011C0 RID: 4544 RVA: 0x00045BC0 File Offset: 0x00043DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790452, XrefRangeEnd = 790457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _FindInstances_b__12_0(TComponent a, TComponent b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TComponent).IsValueType)
					{
						TComponent tcomponent = a;
						intPtr = ((tcomponent is string) ? IL2CPP.ManagedStringToIl2Cpp(tcomponent as string) : IL2CPP.Il2CppObjectBaseToPtr(tcomponent as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref a;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TComponent).IsValueType)
				{
					TComponent tcomponent2 = b;
					intPtr2 = ((tcomponent2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tcomponent2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tcomponent2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref b;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.__c.NativeMethodInfoPtr__FindInstances_b__12_0_Internal_Int32_TComponent_TComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060011C1 RID: 4545 RVA: 0x00045C8C File Offset: 0x00043E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790457, XrefRangeEnd = 790461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__14_0(TComponent o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TComponent).IsValueType)
					{
						TComponent tcomponent = o;
						intPtr = ((tcomponent is string) ? IL2CPP.ManagedStringToIl2Cpp(tcomponent as string) : IL2CPP.Il2CppObjectBaseToPtr(tcomponent as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehavior<TComponent>.__c.NativeMethodInfoPtr__Awake_b__14_0_Internal_Boolean_TComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060011C2 RID: 4546 RVA: 0x00007235 File Offset: 0x00005435
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00045D10 File Offset: 0x00043F10
			// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0000723E File Offset: 0x0000543E
			public unsafe static SingletonMonoBehavior<TComponent>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingletonMonoBehavior<TComponent>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00045D38 File Offset: 0x00043F38
			// (set) Token: 0x060011C6 RID: 4550 RVA: 0x00007250 File Offset: 0x00005450
			public unsafe static Comparison<TComponent> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00045D60 File Offset: 0x00043F60
			// (set) Token: 0x060011C8 RID: 4552 RVA: 0x00007262 File Offset: 0x00005462
			public unsafe static Func<TComponent, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SingletonMonoBehavior<TComponent>.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DF5 RID: 3573
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DF6 RID: 3574
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04000DF7 RID: 3575
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04000DF8 RID: 3576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DF9 RID: 3577
			private static readonly IntPtr NativeMethodInfoPtr__FindInstances_b__12_0_Internal_Int32_TComponent_TComponent_0;

			// Token: 0x04000DFA RID: 3578
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__14_0_Internal_Boolean_TComponent_0;
		}
	}
}
