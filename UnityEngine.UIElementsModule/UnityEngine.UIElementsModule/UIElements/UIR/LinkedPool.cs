using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200025A RID: 602
	public class LinkedPool<T> : Object where T : LinkedPoolItem<T>
	{
		// Token: 0x06002C5B RID: 11355 RVA: 0x000BF1EC File Offset: 0x000BD3EC
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedPool()
		{
			Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "LinkedPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr);
			LinkedPool<T>.NativeFieldInfoPtr_m_CreateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_CreateFunc");
			LinkedPool<T>.NativeFieldInfoPtr_m_ResetAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_ResetAction");
			LinkedPool<T>.NativeFieldInfoPtr_m_Limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_Limit");
			LinkedPool<T>.NativeFieldInfoPtr_m_PoolFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_PoolFirst");
			LinkedPool<T>.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "<Count>k__BackingField");
			LinkedPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, 100669855);
			LinkedPool<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, 100669856);
			LinkedPool<T>.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, 100669857);
			LinkedPool<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, 100669858);
			LinkedPool<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, 100669859);
			LinkedPool<T>.NativeMethodInfoPtr_Return_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, 100669860);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000BF334 File Offset: 0x000BD534
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 350298, RefRangeEnd = 350308, XrefRangeStart = 350289, XrefRangeEnd = 350298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedPool(Func<T> createFunc, Action<T> resetAction, int limit = 10000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(createFunc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resetAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref limit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x000BF3A0 File Offset: 0x000BD5A0
		// (set) Token: 0x06002C5E RID: 11358 RVA: 0x000BF3DC File Offset: 0x000BD5DC
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedPool<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedPool<T>.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000BF41C File Offset: 0x000BD61C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350308, RefRangeEnd = 350310, XrefRangeStart = 350308, XrefRangeEnd = 350308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedPool<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x000BF450 File Offset: 0x000BD650
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 350310, RefRangeEnd = 350321, XrefRangeStart = 350310, XrefRangeEnd = 350310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedPool<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000BF48C File Offset: 0x000BD68C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 350323, RefRangeEnd = 350330, XrefRangeStart = 350321, XrefRangeEnd = 350323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Return(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedPool<T>.NativeMethodInfoPtr_Return_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00012052 File Offset: 0x00010252
		public LinkedPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x000BF504 File Offset: 0x000BD704
		// (set) Token: 0x06002C64 RID: 11364 RVA: 0x0001205B File Offset: 0x0001025B
		public unsafe Func<T> m_CreateFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_CreateFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_CreateFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000BF534 File Offset: 0x000BD734
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x0001207A File Offset: 0x0001027A
		public unsafe Action<T> m_ResetAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_ResetAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_ResetAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x000BF564 File Offset: 0x000BD764
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x00012099 File Offset: 0x00010299
		public unsafe int m_Limit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_Limit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_Limit)) = value;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x000BF58C File Offset: 0x000BD78C
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x000BF5B4 File Offset: 0x000BD7B4
		public unsafe T m_PoolFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_PoolFirst);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_PoolFirst);
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

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x000BF65C File Offset: 0x000BD85C
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x000120B4 File Offset: 0x000102B4
		public unsafe int _Count_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr__Count_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr__Count_k__BackingField)) = value;
			}
		}

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateFunc;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetAction;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeFieldInfoPtr_m_Limit;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeFieldInfoPtr_m_PoolFirst;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeFieldInfoPtr__Count_k__BackingField;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Int32_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_0;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Void_T_0;
	}
}
