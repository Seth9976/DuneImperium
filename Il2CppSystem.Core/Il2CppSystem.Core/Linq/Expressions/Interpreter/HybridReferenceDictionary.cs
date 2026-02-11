using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000108 RID: 264
	public class HybridReferenceDictionary<TKey, TValue> : Object where TKey : class
	{
		// Token: 0x06000FD1 RID: 4049 RVA: 0x00053398 File Offset: 0x00051598
		// Note: this type is marked as 'beforefieldinit'.
		static HybridReferenceDictionary()
		{
			Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "HybridReferenceDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr);
			HybridReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr__keysAndValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, "_keysAndValues");
			HybridReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr__dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, "_dict");
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666240);
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666241);
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666242);
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666243);
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumeratorWorker_Private_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666244);
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666245);
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666246);
			HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100666247);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000534E0 File Offset: 0x000516E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1026972, RefRangeEnd = 1026978, XrefRangeStart = 1026970, XrefRangeEnd = 1026972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TValue).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref value;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000535B4 File Offset: 0x000517B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1026979, RefRangeEnd = 1026981, XrefRangeStart = 1026978, XrefRangeEnd = 1026979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0005362C File Offset: 0x0005182C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1026982, RefRangeEnd = 1026984, XrefRangeStart = 1026981, XrefRangeEnd = 1026982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsKey(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000536B0 File Offset: 0x000518B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1026988, RefRangeEnd = 1026989, XrefRangeStart = 1026984, XrefRangeEnd = 1026988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000536F0 File Offset: 0x000518F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026989, XrefRangeEnd = 1026993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumeratorWorker_Private_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x170004E8 RID: 1256
		public unsafe TValue this[TKey key]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1026995, RefRangeEnd = 1026999, XrefRangeStart = 1026993, XrefRangeEnd = 1026995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1027016, RefRangeEnd = 1027021, XrefRangeStart = 1026999, XrefRangeEnd = 1027016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00053870 File Offset: 0x00051A70
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HybridReferenceDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00006F22 File Offset: 0x00005122
		public HybridReferenceDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x000538AC File Offset: 0x00051AAC
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00006F2B File Offset: 0x0000512B
		public unsafe Il2CppReferenceArray<KeyValuePair<TKey, TValue>> _keysAndValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr__keysAndValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr__keysAndValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x000538DC File Offset: 0x00051ADC
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00006F4A File Offset: 0x0000514A
		public unsafe Dictionary<TKey, TValue> _dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr__dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr__dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr__keysAndValues;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr__dict;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_TKey_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorWorker_Private_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_TValue_TKey_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_TKey_TValue_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032C RID: 812
		[ObfuscatedName("System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2+<GetEnumeratorWorker>d__7")]
		public sealed class _GetEnumeratorWorker_d__7 : Object
		{
			// Token: 0x06001B35 RID: 6965 RVA: 0x000815E4 File Offset: 0x0007F7E4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumeratorWorker_d__7()
			{
				Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>>.NativeClassPtr, "<GetEnumeratorWorker>d__7"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr);
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, "<>1__state");
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, "<>2__current");
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, "<>4__this");
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, "<i>5__2");
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, 100666248);
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, 100666249);
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, 100666250);
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, 100666251);
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, 100666252);
				HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr, 100666253);
			}

			// Token: 0x06001B36 RID: 6966 RVA: 0x00081724 File Offset: 0x0007F924
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumeratorWorker_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B37 RID: 6967 RVA: 0x0008176C File Offset: 0x0007F96C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B38 RID: 6968 RVA: 0x000817A0 File Offset: 0x0007F9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026968, XrefRangeEnd = 1026970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x06001B39 RID: 6969 RVA: 0x000817DC File Offset: 0x0007F9DC
			public unsafe KeyValuePair<TKey, TValue> prop_KeyValuePair_2_TKey_TValue_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06001B3A RID: 6970 RVA: 0x00081814 File Offset: 0x0007FA14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00081848 File Offset: 0x0007FA48
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B3C RID: 6972 RVA: 0x0000A5CF File Offset: 0x000087CF
			public _GetEnumeratorWorker_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00081888 File Offset: 0x0007FA88
			// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0000A5D8 File Offset: 0x000087D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000818B0 File Offset: 0x0007FAB0
			// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000A5F3 File Offset: 0x000087F3
			public KeyValuePair<TKey, TValue> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x06001B41 RID: 6977 RVA: 0x000818E0 File Offset: 0x0007FAE0
			// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0000A621 File Offset: 0x00008821
			public unsafe HybridReferenceDictionary<TKey, TValue> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HybridReferenceDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00081910 File Offset: 0x0007FB10
			// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0000A640 File Offset: 0x00008840
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridReferenceDictionary<TKey, TValue>._GetEnumeratorWorker_d__7.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04001265 RID: 4709
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001266 RID: 4710
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001267 RID: 4711
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001268 RID: 4712
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04001269 RID: 4713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400126A RID: 4714
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400126B RID: 4715
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400126C RID: 4716
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x0400126D RID: 4717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400126E RID: 4718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
