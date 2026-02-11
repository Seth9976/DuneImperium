using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.input
{
	// Token: 0x02000132 RID: 306
	public class Disabler<T> : Object where T : class
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x000485C8 File Offset: 0x000467C8
		// Note: this type is marked as 'beforefieldinit'.
		static Disabler()
		{
			Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "Disabler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr);
			Disabler<T>.NativeFieldInfoPtr_disablers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, "disablers");
			Disabler<T>.NativeFieldInfoPtr_warnOnMissingUnregister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, "warnOnMissingUnregister");
			Disabler<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665256);
			Disabler<T>.NativeMethodInfoPtr_IsNull_Private_Static_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665257);
			Disabler<T>.NativeMethodInfoPtr_IsDisabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665258);
			Disabler<T>.NativeMethodInfoPtr_ContainsDisabler_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665259);
			Disabler<T>.NativeMethodInfoPtr_RegisterDisabler_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665260);
			Disabler<T>.NativeMethodInfoPtr_UnregisterDisabler_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665261);
			Disabler<T>.NativeMethodInfoPtr_TryRegisterDisabler_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665262);
			Disabler<T>.NativeMethodInfoPtr_TryUnregisterDisabler_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, 100665263);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000486FC File Offset: 0x000468FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 510853, RefRangeEnd = 510858, XrefRangeStart = 510848, XrefRangeEnd = 510853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Disabler(bool warnOnMissingUnregister = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref warnOnMissingUnregister;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00048744 File Offset: 0x00046944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510858, XrefRangeEnd = 510862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNull(T disabler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = disabler;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref disabler;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr_IsNull_Private_Static_Boolean_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000487BC File Offset: 0x000469BC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 510862, RefRangeEnd = 510872, XrefRangeStart = 510862, XrefRangeEnd = 510862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr_IsDisabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000487F8 File Offset: 0x000469F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510872, XrefRangeEnd = 510874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsDisabler(T disabler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = disabler;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref disabler;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr_ContainsDisabler_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0004887C File Offset: 0x00046A7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 510897, RefRangeEnd = 510902, XrefRangeStart = 510874, XrefRangeEnd = 510897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDisabler(T disabler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = disabler;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref disabler;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr_RegisterDisabler_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x000488F4 File Offset: 0x00046AF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 510923, RefRangeEnd = 510926, XrefRangeStart = 510902, XrefRangeEnd = 510923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDisabler(T disabler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = disabler;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref disabler;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr_UnregisterDisabler_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0004896C File Offset: 0x00046B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510937, RefRangeEnd = 510938, XrefRangeStart = 510926, XrefRangeEnd = 510937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRegisterDisabler(T disabler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = disabler;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref disabler;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr_TryRegisterDisabler_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x000489E4 File Offset: 0x00046BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510938, XrefRangeEnd = 510948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUnregisterDisabler(T disabler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = disabler;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref disabler;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Disabler<T>.NativeMethodInfoPtr_TryUnregisterDisabler_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0000891A File Offset: 0x00006B1A
		public Disabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00048A5C File Offset: 0x00046C5C
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00008923 File Offset: 0x00006B23
		public unsafe List<T> disablers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disabler<T>.NativeFieldInfoPtr_disablers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disabler<T>.NativeFieldInfoPtr_disablers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00048A8C File Offset: 0x00046C8C
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00008942 File Offset: 0x00006B42
		public unsafe bool warnOnMissingUnregister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disabler<T>.NativeFieldInfoPtr_warnOnMissingUnregister);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disabler<T>.NativeFieldInfoPtr_warnOnMissingUnregister)) = value;
			}
		}

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_disablers;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr_warnOnMissingUnregister;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Private_Static_Boolean_T_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_IsDisabled_Public_Boolean_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_ContainsDisabler_Public_Boolean_T_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDisabler_Public_Void_T_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDisabler_Public_Void_T_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterDisabler_Public_Void_T_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_TryUnregisterDisabler_Public_Void_T_0;

		// Token: 0x0200035C RID: 860
		[ObfuscatedName("boardgames.input.Disabler`1+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002878 RID: 10360 RVA: 0x000A1C60 File Offset: 0x0009FE60
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<Disabler<T>.__O>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Disabler<T>>.NativeClassPtr, "<>O"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Disabler<T>.__O>.NativeClassPtr);
				Disabler<T>.__O.NativeFieldInfoPtr__0___IsNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disabler<T>.__O>.NativeClassPtr, "<0>__IsNull");
			}

			// Token: 0x06002879 RID: 10361 RVA: 0x00014E23 File Offset: 0x00013023
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x0600287A RID: 10362 RVA: 0x000A1CDC File Offset: 0x0009FEDC
			// (set) Token: 0x0600287B RID: 10363 RVA: 0x00014E2C File Offset: 0x0001302C
			public unsafe static Predicate<T> _0___IsNull
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Disabler<T>.__O.NativeFieldInfoPtr__0___IsNull, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Disabler<T>.__O.NativeFieldInfoPtr__0___IsNull, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001959 RID: 6489
			private static readonly IntPtr NativeFieldInfoPtr__0___IsNull;
		}
	}
}
