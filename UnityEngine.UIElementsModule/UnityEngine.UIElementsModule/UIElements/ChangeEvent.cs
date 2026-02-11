using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C5 RID: 197
	public class ChangeEvent<T> : EventBase<ChangeEvent<T>>
	{
		// Token: 0x060011B2 RID: 4530 RVA: 0x0005ABC4 File Offset: 0x00058DC4
		// Note: this type is marked as 'beforefieldinit'.
		static ChangeEvent()
		{
			Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ChangeEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ChangeEvent<T>.NativeFieldInfoPtr__previousValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, "<previousValue>k__BackingField");
			ChangeEvent<T>.NativeFieldInfoPtr__newValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, "<newValue>k__BackingField");
			ChangeEvent<T>.NativeMethodInfoPtr_get_previousValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665799);
			ChangeEvent<T>.NativeMethodInfoPtr_set_previousValue_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665800);
			ChangeEvent<T>.NativeMethodInfoPtr_get_newValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665801);
			ChangeEvent<T>.NativeMethodInfoPtr_set_newValue_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665802);
			ChangeEvent<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665803);
			ChangeEvent<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665804);
			ChangeEvent<T>.NativeMethodInfoPtr_GetPooled_Public_Static_ChangeEvent_1_T_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665805);
			ChangeEvent<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, 100665806);
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0005ACF0 File Offset: 0x00058EF0
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0005AD2C File Offset: 0x00058F2C
		public unsafe T previousValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 311955, RefRangeEnd = 311956, XrefRangeStart = 311955, XrefRangeEnd = 311955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.NativeMethodInfoPtr_get_previousValue_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.NativeMethodInfoPtr_set_previousValue_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0005ADA4 File Offset: 0x00058FA4
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x0005ADE0 File Offset: 0x00058FE0
		public unsafe T newValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.NativeMethodInfoPtr_get_newValue_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.NativeMethodInfoPtr_set_newValue_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0005AE58 File Offset: 0x00059058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311956, XrefRangeEnd = 311957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChangeEvent<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0005AE94 File Offset: 0x00059094
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0005AEC8 File Offset: 0x000590C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311964, RefRangeEnd = 311967, XrefRangeStart = 311957, XrefRangeEnd = 311964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChangeEvent<T> GetPooled(T previousValue, T newValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = previousValue;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref previousValue;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = newValue;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.NativeMethodInfoPtr_GetPooled_Public_Static_ChangeEvent_1_T_T_T_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ChangeEvent<T>>(intPtr5) : null;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0005AF8C File Offset: 0x0005918C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311970, RefRangeEnd = 311971, XrefRangeStart = 311967, XrefRangeEnd = 311970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangeEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00008E65 File Offset: 0x00007065
		public ChangeEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0005AFC8 File Offset: 0x000591C8
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0005AFF0 File Offset: 0x000591F0
		public unsafe T _previousValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeEvent<T>.NativeFieldInfoPtr__previousValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeEvent<T>.NativeFieldInfoPtr__previousValue_k__BackingField);
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0005B098 File Offset: 0x00059298
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0005B0C0 File Offset: 0x000592C0
		public unsafe T _newValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeEvent<T>.NativeFieldInfoPtr__newValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeEvent<T>.NativeFieldInfoPtr__newValue_k__BackingField);
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

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr__previousValue_k__BackingField;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr__newValue_k__BackingField;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_get_previousValue_Public_get_T_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_set_previousValue_Protected_set_Void_T_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_get_newValue_Public_get_T_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_set_newValue_Protected_set_Void_T_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_ChangeEvent_1_T_T_T_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F3 RID: 1011
		[ObfuscatedName("UnityEngine.UIElements.ChangeEvent`1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AA5 RID: 15013 RVA: 0x000ED33C File Offset: 0x000EB53C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChangeEvent<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeEvent<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeEvent<T>.__c>.NativeClassPtr);
				ChangeEvent<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeEvent<T>.__c>.NativeClassPtr, "<>9");
				ChangeEvent<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>.__c>.NativeClassPtr, 100665808);
				ChangeEvent<T>.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ChangeEvent_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEvent<T>.__c>.NativeClassPtr, 100665809);
			}

			// Token: 0x06003AA6 RID: 15014 RVA: 0x000ED3E0 File Offset: 0x000EB5E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeEvent<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AA7 RID: 15015 RVA: 0x000ED41C File Offset: 0x000EB61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311952, XrefRangeEnd = 311955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeEvent<T> __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEvent<T>.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ChangeEvent_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChangeEvent<T>>(intPtr3) : null;
			}

			// Token: 0x06003AA8 RID: 15016 RVA: 0x00018C43 File Offset: 0x00016E43
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011F8 RID: 4600
			// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x000ED45C File Offset: 0x000EB65C
			// (set) Token: 0x06003AAA RID: 15018 RVA: 0x00018C4C File Offset: 0x00016E4C
			public unsafe static ChangeEvent<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChangeEvent<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangeEvent<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChangeEvent<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400296C RID: 10604
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400296D RID: 10605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400296E RID: 10606
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_ChangeEvent_1_T_0;
		}
	}
}
