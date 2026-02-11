using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Utils
{
	// Token: 0x02000033 RID: 51
	public static class NullableUtil : Object
	{
		// Token: 0x06000229 RID: 553 RVA: 0x0000D774 File Offset: 0x0000B974
		// Note: this type is marked as 'beforefieldinit'.
		static NullableUtil()
		{
			Il2CppClassPointerStore<NullableUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "NullableUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableUtil>.NativeClassPtr);
			NullableUtil.NativeMethodInfoPtr_Optionally_Public_Static_IEnumerable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil>.NativeClassPtr, 100663820);
			NullableUtil.NativeMethodInfoPtr_Optionally_Public_Static_IEnumerable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil>.NativeClassPtr, 100663821);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1183769, RefRangeEnd = 1183770, XrefRangeStart = 1183765, XrefRangeEnd = 1183769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Optionally<T>(this Nullable<T> nullable) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nullable));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil.MethodInfoStoreGeneric_Optionally_Public_Static_IEnumerable_1_T_Nullable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000D818 File Offset: 0x0000BA18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43475, RefRangeEnd = 43477, XrefRangeStart = 43475, XrefRangeEnd = 43477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Optionally<T>(this T nullable) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = nullable;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref nullable;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NullableUtil.MethodInfoStoreGeneric_Optionally_Public_Static_IEnumerable_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr4) : null;
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002991 File Offset: 0x00000B91
		public NullableUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_Optionally_Public_Static_IEnumerable_1_T_Nullable_1_T_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_Optionally_Public_Static_IEnumerable_1_T_T_0;

		// Token: 0x020000AE RID: 174
		[ObfuscatedName("Utils.NullableUtil+<Optionally>d__0`1")]
		public sealed class _Optionally_d__0<T> : Object where T : new()
		{
			// Token: 0x0600055A RID: 1370 RVA: 0x00018CBC File Offset: 0x00016EBC
			// Note: this type is marked as 'beforefieldinit'.
			static _Optionally_d__0()
			{
				Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableUtil>.NativeClassPtr, "<Optionally>d__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr);
				NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, "<>1__state");
				NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, "<>2__current");
				NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, "<>l__initialThreadId");
				NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr_nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, "nullable");
				NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___3__nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, "<>3__nullable");
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663822);
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663823);
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663824);
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663825);
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663826);
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663827);
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663828);
				NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr, 100663829);
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00018E28 File Offset: 0x00017028
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 937091, RefRangeEnd = 937095, XrefRangeStart = 937091, XrefRangeEnd = 937095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Optionally_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableUtil._Optionally_d__0<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600055C RID: 1372 RVA: 0x00018E70 File Offset: 0x00017070
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x00018EA4 File Offset: 0x000170A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183744, XrefRangeEnd = 1183745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x00018EE0 File Offset: 0x000170E0
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x00018F1C File Offset: 0x0001711C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x00018F50 File Offset: 0x00017150
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x00018F90 File Offset: 0x00017190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183745, XrefRangeEnd = 1183751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x00018FD0 File Offset: 0x000171D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183751, XrefRangeEnd = 1183757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x00004154 File Offset: 0x00002354
			public _Optionally_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x00019010 File Offset: 0x00017210
			// (set) Token: 0x06000565 RID: 1381 RVA: 0x0000415D File Offset: 0x0000235D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x06000566 RID: 1382 RVA: 0x00019038 File Offset: 0x00017238
			// (set) Token: 0x06000567 RID: 1383 RVA: 0x00019060 File Offset: 0x00017260
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___2__current);
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

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x00019108 File Offset: 0x00017308
			// (set) Token: 0x06000569 RID: 1385 RVA: 0x00004178 File Offset: 0x00002378
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x00019130 File Offset: 0x00017330
			// (set) Token: 0x0600056B RID: 1387 RVA: 0x00004193 File Offset: 0x00002393
			public Nullable<T> nullable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr_nullable);
					return new Nullable<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr_nullable), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x0600056C RID: 1388 RVA: 0x00019160 File Offset: 0x00017360
			// (set) Token: 0x0600056D RID: 1389 RVA: 0x000041C1 File Offset: 0x000023C1
			public Nullable<T> __3__nullable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___3__nullable);
					return new Nullable<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__0<T>.NativeFieldInfoPtr___3__nullable), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000384 RID: 900
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000385 RID: 901
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000386 RID: 902
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000387 RID: 903
			private static readonly IntPtr NativeFieldInfoPtr_nullable;

			// Token: 0x04000388 RID: 904
			private static readonly IntPtr NativeFieldInfoPtr___3__nullable;

			// Token: 0x04000389 RID: 905
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400038A RID: 906
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400038B RID: 907
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400038C RID: 908
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x0400038D RID: 909
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400038E RID: 910
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400038F RID: 911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04000390 RID: 912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020000AF RID: 175
		[ObfuscatedName("Utils.NullableUtil+<Optionally>d__1`1")]
		public sealed class _Optionally_d__1<T> : Object where T : class
		{
			// Token: 0x0600056E RID: 1390 RVA: 0x00019190 File Offset: 0x00017390
			// Note: this type is marked as 'beforefieldinit'.
			static _Optionally_d__1()
			{
				Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableUtil>.NativeClassPtr, "<Optionally>d__1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr);
				NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, "<>1__state");
				NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, "<>2__current");
				NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, "<>l__initialThreadId");
				NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr_nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, "nullable");
				NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___3__nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, "<>3__nullable");
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663830);
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663831);
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663832);
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663833);
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663834);
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663835);
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663836);
				NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr, 100663837);
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x000192FC File Offset: 0x000174FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Optionally_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableUtil._Optionally_d__1<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00019344 File Offset: 0x00017544
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x00019378 File Offset: 0x00017578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183757, XrefRangeEnd = 1183758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000572 RID: 1394 RVA: 0x000193B4 File Offset: 0x000175B4
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x000193F0 File Offset: 0x000175F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x00019424 File Offset: 0x00017624
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x00019464 File Offset: 0x00017664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x000194A4 File Offset: 0x000176A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183758, XrefRangeEnd = 1183765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableUtil._Optionally_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x000041EF File Offset: 0x000023EF
			public _Optionally_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000578 RID: 1400 RVA: 0x000194E4 File Offset: 0x000176E4
			// (set) Token: 0x06000579 RID: 1401 RVA: 0x000041F8 File Offset: 0x000023F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001950C File Offset: 0x0001770C
			// (set) Token: 0x0600057B RID: 1403 RVA: 0x00019534 File Offset: 0x00017734
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___2__current);
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

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x0600057C RID: 1404 RVA: 0x000195DC File Offset: 0x000177DC
			// (set) Token: 0x0600057D RID: 1405 RVA: 0x00004213 File Offset: 0x00002413
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x0600057E RID: 1406 RVA: 0x00019604 File Offset: 0x00017804
			// (set) Token: 0x0600057F RID: 1407 RVA: 0x0001962C File Offset: 0x0001782C
			public unsafe T nullable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr_nullable);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr_nullable);
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

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000580 RID: 1408 RVA: 0x000196D4 File Offset: 0x000178D4
			// (set) Token: 0x06000581 RID: 1409 RVA: 0x000196FC File Offset: 0x000178FC
			public unsafe T __3__nullable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___3__nullable);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableUtil._Optionally_d__1<T>.NativeFieldInfoPtr___3__nullable);
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

			// Token: 0x04000391 RID: 913
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000392 RID: 914
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000393 RID: 915
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000394 RID: 916
			private static readonly IntPtr NativeFieldInfoPtr_nullable;

			// Token: 0x04000395 RID: 917
			private static readonly IntPtr NativeFieldInfoPtr___3__nullable;

			// Token: 0x04000396 RID: 918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000397 RID: 919
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000398 RID: 920
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000399 RID: 921
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x0400039A RID: 922
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400039B RID: 923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400039C RID: 924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x0400039D RID: 925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020000B0 RID: 176
		private sealed class MethodInfoStoreGeneric_Optionally_Public_Static_IEnumerable_1_T_Nullable_1_T_0<T>
		{
			// Token: 0x0400039E RID: 926
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NullableUtil.NativeMethodInfoPtr_Optionally_Public_Static_IEnumerable_1_T_Nullable_1_T_0, Il2CppClassPointerStore<NullableUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B1 RID: 177
		private sealed class MethodInfoStoreGeneric_Optionally_Public_Static_IEnumerable_1_T_T_0<T>
		{
			// Token: 0x0400039F RID: 927
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NullableUtil.NativeMethodInfoPtr_Optionally_Public_Static_IEnumerable_1_T_T_0, Il2CppClassPointerStore<NullableUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
