using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.keyedlookup
{
	// Token: 0x0200012A RID: 298
	[Serializable]
	public class KeyedSerializedLookup<T> : Object where T : class
	{
		// Token: 0x06000D44 RID: 3396 RVA: 0x00047648 File Offset: 0x00045848
		// Note: this type is marked as 'beforefieldinit'.
		static KeyedSerializedLookup()
		{
			Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.keyedlookup", "KeyedSerializedLookup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr);
			KeyedSerializedLookup<T>.NativeMethodInfoPtr_get_Entries_Protected_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Entry_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, 100665220);
			KeyedSerializedLookup<T>.NativeMethodInfoPtr_TryGet_Public_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, 100665221);
			KeyedSerializedLookup<T>.NativeMethodInfoPtr_Get_Public_Virtual_New_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, 100665222);
			KeyedSerializedLookup<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, 100665223);
			KeyedSerializedLookup<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, 100665224);
			KeyedSerializedLookup<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, 100665225);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0004772C File Offset: 0x0004592C
		public unsafe virtual Il2CppReferenceArray<KeyedSerializedLookup<T>.Entry<T>> Entries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedSerializedLookup<T>.NativeMethodInfoPtr_get_Entries_Protected_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Entry_1_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyedSerializedLookup<T>.Entry<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00047778 File Offset: 0x00045978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510717, RefRangeEnd = 510719, XrefRangeStart = 510717, XrefRangeEnd = 510717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGet(string key, out T entryValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref entryValue;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.NativeMethodInfoPtr_TryGet_Public_Boolean_String_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				entryValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00047814 File Offset: 0x00045A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510719, XrefRangeEnd = 510721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedSerializedLookup<T>.NativeMethodInfoPtr_Get_Public_Virtual_New_T_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0004786C File Offset: 0x00045A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510737, RefRangeEnd = 510738, XrefRangeStart = 510721, XrefRangeEnd = 510737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000478AC File Offset: 0x00045AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510738, XrefRangeEnd = 510739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000478EC File Offset: 0x00045AEC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedSerializedLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000086FE File Offset: 0x000068FE
		public KeyedSerializedLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Protected_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Entry_1_T_T_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_String_byref_T_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_T_String_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200035A RID: 858
		[Serializable]
		public class Entry<TEntry> : Object
		{
			// Token: 0x06002868 RID: 10344 RVA: 0x000A17F0 File Offset: 0x0009F9F0
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, "Entry`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr);
				KeyedSerializedLookup<T>.Entry<TEntry>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr, "value");
				KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr, 100665226);
				KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr_get_Value_Public_get_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr, 100665227);
				KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr_set_Value_Protected_set_Void_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr, 100665228);
				KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr, 100665229);
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06002869 RID: 10345 RVA: 0x000A18CC File Offset: 0x0009FACC
			public unsafe virtual string Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x0600286A RID: 10346 RVA: 0x000A1910 File Offset: 0x0009FB10
			// (set) Token: 0x0600286B RID: 10347 RVA: 0x000A194C File Offset: 0x0009FB4C
			public unsafe TEntry Value
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr_get_Value_Public_get_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						IntPtr intPtr;
						if (!typeof(TEntry).IsValueType)
						{
							TEntry tentry = value;
							intPtr = ((tentry is string) ? IL2CPP.ManagedStringToIl2Cpp(tentry as string) : IL2CPP.Il2CppObjectBaseToPtr(tentry as Il2CppObjectBase));
						}
						else
						{
							intPtr = ref value;
						}
						ptr2 = intPtr;
						IntPtr intPtr3;
						IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr_set_Value_Protected_set_Void_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
						Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					}
				}
			}

			// Token: 0x0600286C RID: 10348 RVA: 0x000A19C4 File Offset: 0x0009FBC4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedSerializedLookup<T>.Entry<TEntry>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.Entry<TEntry>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600286D RID: 10349 RVA: 0x00014DED File Offset: 0x00012FED
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x0600286E RID: 10350 RVA: 0x000A1A00 File Offset: 0x0009FC00
			// (set) Token: 0x0600286F RID: 10351 RVA: 0x000A1A28 File Offset: 0x0009FC28
			public unsafe TEntry value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedSerializedLookup<T>.Entry<TEntry>.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedSerializedLookup<T>.Entry<TEntry>.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(TEntry);
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

			// Token: 0x04001950 RID: 6480
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001951 RID: 6481
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x04001952 RID: 6482
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_TEntry_0;

			// Token: 0x04001953 RID: 6483
			private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_TEntry_0;

			// Token: 0x04001954 RID: 6484
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x0200035B RID: 859
		[ObfuscatedName("boardgames.keyedlookup.KeyedSerializedLookup`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002870 RID: 10352 RVA: 0x000A1AD0 File Offset: 0x0009FCD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KeyedSerializedLookup<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyedSerializedLookup<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedSerializedLookup<T>.__c>.NativeClassPtr);
				KeyedSerializedLookup<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedSerializedLookup<T>.__c>.NativeClassPtr, "<>9");
				KeyedSerializedLookup<T>.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedSerializedLookup<T>.__c>.NativeClassPtr, "<>9__5_0");
				KeyedSerializedLookup<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>.__c>.NativeClassPtr, 100665231);
				KeyedSerializedLookup<T>.__c.NativeMethodInfoPtr__GetEnumerator_b__5_0_Internal_T_Entry_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedSerializedLookup<T>.__c>.NativeClassPtr, 100665232);
			}

			// Token: 0x06002871 RID: 10353 RVA: 0x000A1B88 File Offset: 0x0009FD88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedSerializedLookup<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002872 RID: 10354 RVA: 0x000A1BC4 File Offset: 0x0009FDC4
			[CallerCount(0)]
			public unsafe T _GetEnumerator_b__5_0(KeyedSerializedLookup<T>.Entry<T> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedSerializedLookup<T>.__c.NativeMethodInfoPtr__GetEnumerator_b__5_0_Internal_T_Entry_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002873 RID: 10355 RVA: 0x00014DF6 File Offset: 0x00012FF6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06002874 RID: 10356 RVA: 0x000A1C10 File Offset: 0x0009FE10
			// (set) Token: 0x06002875 RID: 10357 RVA: 0x00014DFF File Offset: 0x00012FFF
			public unsafe static KeyedSerializedLookup<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeyedSerializedLookup<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyedSerializedLookup<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeyedSerializedLookup<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06002876 RID: 10358 RVA: 0x000A1C38 File Offset: 0x0009FE38
			// (set) Token: 0x06002877 RID: 10359 RVA: 0x00014E11 File Offset: 0x00013011
			public unsafe static Func<KeyedSerializedLookup<T>.Entry<T>, T> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeyedSerializedLookup<T>.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyedSerializedLookup<T>.Entry<T>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeyedSerializedLookup<T>.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001955 RID: 6485
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001956 RID: 6486
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001957 RID: 6487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001958 RID: 6488
			private static readonly IntPtr NativeMethodInfoPtr__GetEnumerator_b__5_0_Internal_T_Entry_1_T_T_0;
		}
	}
}
