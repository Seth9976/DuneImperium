using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.conditions
{
	// Token: 0x020000AF RID: 175
	public class UnityEventConditions<T, U, V> : MonoBehaviour where U : Condition<T> where V : UnityEvent<T>
	{
		// Token: 0x060007E2 RID: 2018 RVA: 0x00020A34 File Offset: 0x0001EC34
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventConditions()
		{
			Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.conditions", "UnityEventConditions`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr);
			UnityEventConditions<T, U, V>.NativeFieldInfoPtr_matchAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr, "matchAll");
			UnityEventConditions<T, U, V>.NativeFieldInfoPtr_matchAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr, "matchAny");
			UnityEventConditions<T, U, V>.NativeFieldInfoPtr_onSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr, "onSuccess");
			UnityEventConditions<T, U, V>.NativeFieldInfoPtr_onFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr, "onFail");
			UnityEventConditions<T, U, V>.NativeMethodInfoPtr_CheckConditions_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr, 100664266);
			UnityEventConditions<T, U, V>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr, 100664267);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00020B3C File Offset: 0x0001ED3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126848, RefRangeEnd = 1126849, XrefRangeStart = 1126845, XrefRangeEnd = 1126848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConditions(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnityEventConditions<T, U, V>.NativeMethodInfoPtr_CheckConditions_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventConditions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventConditions<T, U, V>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventConditions<T, U, V>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00006251 File Offset: 0x00004451
		public UnityEventConditions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00020BF0 File Offset: 0x0001EDF0
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x0000625A File Offset: 0x0000445A
		public unsafe Il2CppArrayBase<U> matchAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_matchAll);
				return Il2CppArrayBase<U>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_matchAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00020C18 File Offset: 0x0001EE18
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00006279 File Offset: 0x00004479
		public unsafe Il2CppArrayBase<U> matchAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_matchAny);
				return Il2CppArrayBase<U>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_matchAny), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00020C40 File Offset: 0x0001EE40
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00020C68 File Offset: 0x0001EE68
		public unsafe V onSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_onSuccess);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_onSuccess);
				Type typeFromHandle = typeof(V);
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00020D10 File Offset: 0x0001EF10
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00020D38 File Offset: 0x0001EF38
		public unsafe V onFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_onFail);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventConditions<T, U, V>.NativeFieldInfoPtr_onFail);
				Type typeFromHandle = typeof(V);
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

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_matchAll;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_matchAny;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr_onSuccess;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr_onFail;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Void_T_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
