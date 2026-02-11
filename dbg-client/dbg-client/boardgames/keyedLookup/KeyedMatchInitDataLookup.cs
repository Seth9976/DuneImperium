using System;
using boardgames.keyedlookup;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.keyedLookup
{
	// Token: 0x02000128 RID: 296
	[Serializable]
	public class KeyedMatchInitDataLookup<T> : KeyedSerializedLookup<T> where T : MatchInitData
	{
		// Token: 0x06000D38 RID: 3384 RVA: 0x000473B4 File Offset: 0x000455B4
		// Note: this type is marked as 'beforefieldinit'.
		static KeyedMatchInitDataLookup()
		{
			Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.keyedLookup", "KeyedMatchInitDataLookup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr);
			KeyedMatchInitDataLookup<T>.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr, "entries");
			KeyedMatchInitDataLookup<T>.NativeMethodInfoPtr_get_Entries_Protected_Virtual_get_Il2CppReferenceArray_1_Entry_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr, 100665209);
			KeyedMatchInitDataLookup<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr, 100665210);
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0004745C File Offset: 0x0004565C
		public unsafe override Il2CppReferenceArray<KeyedSerializedLookup<T>.Entry<T>> Entries
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedMatchInitDataLookup<T>.NativeMethodInfoPtr_get_Entries_Protected_Virtual_get_Il2CppReferenceArray_1_Entry_1_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyedSerializedLookup<T>.Entry<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x000474A8 File Offset: 0x000456A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510685, XrefRangeEnd = 510704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedMatchInitDataLookup(IEnumerable<T> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedMatchInitDataLookup<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000086AE File Offset: 0x000068AE
		public KeyedMatchInitDataLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x000474F4 File Offset: 0x000456F4
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x000086B7 File Offset: 0x000068B7
		public unsafe Il2CppReferenceArray<KeyedMatchInitDataLookup<T>.MatchInitDataEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedMatchInitDataLookup<T>.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyedMatchInitDataLookup<T>.MatchInitDataEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedMatchInitDataLookup<T>.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Protected_Virtual_get_Il2CppReferenceArray_1_Entry_1_T_T_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x02000357 RID: 855
		[Serializable]
		public class MatchInitDataEntry : KeyedSerializedLookup<T>.Entry<T>
		{
			// Token: 0x06002856 RID: 10326 RVA: 0x000A13BC File Offset: 0x0009F5BC
			// Note: this type is marked as 'beforefieldinit'.
			static MatchInitDataEntry()
			{
				Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.MatchInitDataEntry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr, "MatchInitDataEntry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.MatchInitDataEntry>.NativeClassPtr);
				KeyedMatchInitDataLookup<T>.MatchInitDataEntry.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.MatchInitDataEntry>.NativeClassPtr, 100665211);
				KeyedMatchInitDataLookup<T>.MatchInitDataEntry.NativeMethodInfoPtr_get_Key_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.MatchInitDataEntry>.NativeClassPtr, 100665212);
			}

			// Token: 0x06002857 RID: 10327 RVA: 0x000A144C File Offset: 0x0009F64C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 510681, RefRangeEnd = 510682, XrefRangeStart = 510678, XrefRangeEnd = 510681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchInitDataEntry(T data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.MatchInitDataEntry>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = data;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref data;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(KeyedMatchInitDataLookup<T>.MatchInitDataEntry.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06002858 RID: 10328 RVA: 0x000A14D0 File Offset: 0x0009F6D0
			public unsafe override string Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedMatchInitDataLookup<T>.MatchInitDataEntry.NativeMethodInfoPtr_get_Key_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002859 RID: 10329 RVA: 0x00014D8F File Offset: 0x00012F8F
			public MatchInitDataEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001947 RID: 6471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x04001948 RID: 6472
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_String_0;
		}

		// Token: 0x02000358 RID: 856
		[ObfuscatedName("boardgames.keyedLookup.KeyedMatchInitDataLookup`1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600285A RID: 10330 RVA: 0x000A1514 File Offset: 0x0009F714
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.__c>.NativeClassPtr);
				KeyedMatchInitDataLookup<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.__c>.NativeClassPtr, "<>9");
				KeyedMatchInitDataLookup<T>.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.__c>.NativeClassPtr, "<>9__4_0");
				KeyedMatchInitDataLookup<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.__c>.NativeClassPtr, 100665214);
				KeyedMatchInitDataLookup<T>.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_MatchInitDataEntry_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.__c>.NativeClassPtr, 100665215);
			}

			// Token: 0x0600285B RID: 10331 RVA: 0x000A15CC File Offset: 0x0009F7CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedMatchInitDataLookup<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedMatchInitDataLookup<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600285C RID: 10332 RVA: 0x000A1608 File Offset: 0x0009F808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510682, XrefRangeEnd = 510685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyedMatchInitDataLookup<T>.MatchInitDataEntry __ctor_b__4_0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(KeyedMatchInitDataLookup<T>.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_MatchInitDataEntry_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<KeyedMatchInitDataLookup<T>.MatchInitDataEntry>(intPtr4) : null;
				}
			}

			// Token: 0x0600285D RID: 10333 RVA: 0x00014D98 File Offset: 0x00012F98
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x0600285E RID: 10334 RVA: 0x000A1690 File Offset: 0x0009F890
			// (set) Token: 0x0600285F RID: 10335 RVA: 0x00014DA1 File Offset: 0x00012FA1
			public unsafe static KeyedMatchInitDataLookup<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeyedMatchInitDataLookup<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyedMatchInitDataLookup<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeyedMatchInitDataLookup<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x06002860 RID: 10336 RVA: 0x000A16B8 File Offset: 0x0009F8B8
			// (set) Token: 0x06002861 RID: 10337 RVA: 0x00014DB3 File Offset: 0x00012FB3
			public unsafe static Func<T, KeyedMatchInitDataLookup<T>.MatchInitDataEntry> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeyedMatchInitDataLookup<T>.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, KeyedMatchInitDataLookup<T>.MatchInitDataEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeyedMatchInitDataLookup<T>.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001949 RID: 6473
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400194A RID: 6474
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400194B RID: 6475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400194C RID: 6476
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Internal_MatchInitDataEntry_T_T_0;
		}
	}
}
