using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Requests.Parameters
{
	// Token: 0x02000015 RID: 21
	public class ParameterCollection : List<KeyValuePair<string, string>>
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00007018 File Offset: 0x00005218
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterCollection()
		{
			Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Requests.Parameters", "ParameterCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr);
			ParameterCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663403);
			ParameterCollection.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663404);
			ParameterCollection.NativeMethodInfoPtr_Add_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663405);
			ParameterCollection.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663406);
			ParameterCollection.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663407);
			ParameterCollection.NativeMethodInfoPtr_GetFirstMatch_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663408);
			ParameterCollection.NativeMethodInfoPtr_GetAllMatches_Public_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663409);
			ParameterCollection.NativeMethodInfoPtr_get_Item_Public_get_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663410);
			ParameterCollection.NativeMethodInfoPtr_FromQueryString_Public_Static_ParameterCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663411);
			ParameterCollection.NativeMethodInfoPtr_FromDictionary_Public_Static_ParameterCollection_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, 100663412);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00007110 File Offset: 0x00005310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210682, XrefRangeEnd = 1210688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000714C File Offset: 0x0000534C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210688, XrefRangeEnd = 1210694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterCollection(IEnumerable<KeyValuePair<string, string>> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00007198 File Offset: 0x00005398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1210700, RefRangeEnd = 1210703, XrefRangeStart = 1210694, XrefRangeEnd = 1210700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_Add_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000071EC File Offset: 0x000053EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210707, RefRangeEnd = 1210708, XrefRangeStart = 1210703, XrefRangeEnd = 1210707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000723C File Offset: 0x0000543C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1210732, RefRangeEnd = 1210734, XrefRangeStart = 1210708, XrefRangeEnd = 1210732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(string key, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000072A4 File Offset: 0x000054A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210734, XrefRangeEnd = 1210735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFirstMatch(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_GetFirstMatch_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000072EC File Offset: 0x000054EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210735, XrefRangeEnd = 1210742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<string> GetAllMatches(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_GetAllMatches_Public_IEnumerable_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700003F RID: 63
		public unsafe IEnumerable<string> this[string key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_get_Item_Public_get_IEnumerable_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000738C File Offset: 0x0000558C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210742, XrefRangeEnd = 1210765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParameterCollection FromQueryString(string qs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_FromQueryString_Public_Static_ParameterCollection_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000073D0 File Offset: 0x000055D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210813, RefRangeEnd = 1210814, XrefRangeStart = 1210765, XrefRangeEnd = 1210813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParameterCollection FromDictionary(IDictionary<string, Object> dictionary)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection.NativeMethodInfoPtr_FromDictionary_Public_Static_ParameterCollection_IDictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000024B2 File Offset: 0x000006B2
		public ParameterCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstMatch_Public_String_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMatches_Public_IEnumerable_1_String_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IEnumerable_1_String_String_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_FromQueryString_Public_Static_ParameterCollection_String_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_FromDictionary_Public_Static_ParameterCollection_IDictionary_2_String_Object_0;

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("Google.Apis.Requests.Parameters.ParameterCollection+<GetAllMatches>d__6")]
		public sealed class _GetAllMatches_d__6 : Object
		{
			// Token: 0x060002CF RID: 719 RVA: 0x0000E384 File Offset: 0x0000C584
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAllMatches_d__6()
			{
				Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterCollection>.NativeClassPtr, "<GetAllMatches>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr);
				ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, "<>1__state");
				ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, "<>2__current");
				ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, "<>l__initialThreadId");
				ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, "key");
				ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___3__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, "<>3__key");
				ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, "<>4__this");
				ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, "<>7__wrap1");
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663413);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663414);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663415);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663416);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663417);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663418);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663419);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663420);
				ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr, 100663421);
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAllMatches_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterCollection._GetAllMatches_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000E538 File Offset: 0x0000C738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210638, XrefRangeEnd = 1210643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x0000E56C File Offset: 0x0000C76C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210643, XrefRangeEnd = 1210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210665, XrefRangeEnd = 1210668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000E5DC File Offset: 0x0000C7DC
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x0000E614 File Offset: 0x0000C814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210668, XrefRangeEnd = 1210673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000E648 File Offset: 0x0000C848
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x0000E688 File Offset: 0x0000C888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210673, XrefRangeEnd = 1210682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterCollection._GetAllMatches_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x00003257 File Offset: 0x00001457
			public _GetAllMatches_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002DA RID: 730 RVA: 0x0000E708 File Offset: 0x0000C908
			// (set) Token: 0x060002DB RID: 731 RVA: 0x00003260 File Offset: 0x00001460
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002DC RID: 732 RVA: 0x0000E730 File Offset: 0x0000C930
			// (set) Token: 0x060002DD RID: 733 RVA: 0x0000327B File Offset: 0x0000147B
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002DE RID: 734 RVA: 0x0000E758 File Offset: 0x0000C958
			// (set) Token: 0x060002DF RID: 735 RVA: 0x0000329A File Offset: 0x0000149A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000E780 File Offset: 0x0000C980
			// (set) Token: 0x060002E1 RID: 737 RVA: 0x000032B5 File Offset: 0x000014B5
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
			// (set) Token: 0x060002E3 RID: 739 RVA: 0x000032D4 File Offset: 0x000014D4
			public unsafe string __3__key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___3__key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___3__key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000E7D0 File Offset: 0x0000C9D0
			// (set) Token: 0x060002E5 RID: 741 RVA: 0x000032F3 File Offset: 0x000014F3
			public unsafe ParameterCollection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000E800 File Offset: 0x0000CA00
			// (set) Token: 0x060002E7 RID: 743 RVA: 0x00003312 File Offset: 0x00001512
			public List<KeyValuePair<string, string>>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___7__wrap1);
					return new List<KeyValuePair<string, string>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<KeyValuePair<string, string>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterCollection._GetAllMatches_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<KeyValuePair<string, string>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeFieldInfoPtr___3__key;

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
