using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000040 RID: 64
	public static class AotHelper : Object
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x0002F4CC File Offset: 0x0002D6CC
		// Note: this type is marked as 'beforefieldinit'.
		static AotHelper()
		{
			Il2CppClassPointerStore<AotHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "AotHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AotHelper>.NativeClassPtr);
			AotHelper.NativeFieldInfoPtr_s_alwaysFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, "s_alwaysFalse");
			AotHelper.NativeMethodInfoPtr_Ensure_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, 100664525);
			AotHelper.NativeMethodInfoPtr_EnsureType_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, 100664526);
			AotHelper.NativeMethodInfoPtr_EnsureList_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, 100664527);
			AotHelper.NativeMethodInfoPtr_EnsureDictionary_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, 100664528);
			AotHelper.NativeMethodInfoPtr_IsFalse_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, 100664529);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0002F574 File Offset: 0x0002D774
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738964, RefRangeEnd = 738967, XrefRangeStart = 738957, XrefRangeEnd = 738964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Ensure(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.NativeMethodInfoPtr_Ensure_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0002F5AC File Offset: 0x0002D7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738967, XrefRangeEnd = 738985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureType<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.MethodInfoStoreGeneric_EnsureType_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0002F5D4 File Offset: 0x0002D7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureList<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.MethodInfoStoreGeneric_EnsureList_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0002F5FC File Offset: 0x0002D7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureDictionary<TKey, TValue>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.MethodInfoStoreGeneric_EnsureDictionary_Public_Static_Void_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0002F624 File Offset: 0x0002D824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738985, XrefRangeEnd = 738989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFalse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.NativeMethodInfoPtr_IsFalse_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00003D94 File Offset: 0x00001F94
		public AotHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0002F654 File Offset: 0x0002D854
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00003D9D File Offset: 0x00001F9D
		public unsafe static bool s_alwaysFalse
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AotHelper.NativeFieldInfoPtr_s_alwaysFalse, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AotHelper.NativeFieldInfoPtr_s_alwaysFalse, (void*)(&value));
			}
		}

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_s_alwaysFalse;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_Ensure_Public_Static_Void_Action_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_EnsureType_Public_Static_Void_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_EnsureList_Public_Static_Void_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDictionary_Public_Static_Void_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_IsFalse_Public_Static_Boolean_0;

		// Token: 0x02000166 RID: 358
		[ObfuscatedName("Newtonsoft.Json.Utilities.AotHelper+<>c__1`1")]
		[Serializable]
		public sealed class __c__1<T> : Object where T : new()
		{
			// Token: 0x06001BEF RID: 7151 RVA: 0x00084A6C File Offset: 0x00082C6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__1()
			{
				Il2CppClassPointerStore<AotHelper.__c__1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, "<>c__1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AotHelper.__c__1<T>>.NativeClassPtr);
				AotHelper.__c__1<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotHelper.__c__1<T>>.NativeClassPtr, "<>9");
				AotHelper.__c__1<T>.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotHelper.__c__1<T>>.NativeClassPtr, "<>9__1_0");
				AotHelper.__c__1<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper.__c__1<T>>.NativeClassPtr, 100664532);
				AotHelper.__c__1<T>.NativeMethodInfoPtr__EnsureType_b__1_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper.__c__1<T>>.NativeClassPtr, 100664533);
			}

			// Token: 0x06001BF0 RID: 7152 RVA: 0x00084B24 File Offset: 0x00082D24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AotHelper.__c__1<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.__c__1<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF1 RID: 7153 RVA: 0x00084B60 File Offset: 0x00082D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738937, XrefRangeEnd = 738938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnsureType_b__1_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.__c__1<T>.NativeMethodInfoPtr__EnsureType_b__1_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF2 RID: 7154 RVA: 0x0000DC3A File Offset: 0x0000BE3A
			public __c__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00084B94 File Offset: 0x00082D94
			// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0000DC43 File Offset: 0x0000BE43
			public unsafe static AotHelper.__c__1<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AotHelper.__c__1<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AotHelper.__c__1<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AotHelper.__c__1<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x00084BBC File Offset: 0x00082DBC
			// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0000DC55 File Offset: 0x0000BE55
			public unsafe static Action __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AotHelper.__c__1<T>.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AotHelper.__c__1<T>.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014D7 RID: 5335
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014D8 RID: 5336
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040014D9 RID: 5337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014DA RID: 5338
			private static readonly IntPtr NativeMethodInfoPtr__EnsureType_b__1_0_Internal_Void_0;
		}

		// Token: 0x02000167 RID: 359
		[ObfuscatedName("Newtonsoft.Json.Utilities.AotHelper+<>c__2`1")]
		[Serializable]
		public sealed class __c__2<T> : Object
		{
			// Token: 0x06001BF7 RID: 7159 RVA: 0x00084BE4 File Offset: 0x00082DE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__2()
			{
				Il2CppClassPointerStore<AotHelper.__c__2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, "<>c__2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AotHelper.__c__2<T>>.NativeClassPtr);
				AotHelper.__c__2<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotHelper.__c__2<T>>.NativeClassPtr, "<>9");
				AotHelper.__c__2<T>.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotHelper.__c__2<T>>.NativeClassPtr, "<>9__2_0");
				AotHelper.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper.__c__2<T>>.NativeClassPtr, 100664535);
				AotHelper.__c__2<T>.NativeMethodInfoPtr__EnsureList_b__2_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper.__c__2<T>>.NativeClassPtr, 100664536);
			}

			// Token: 0x06001BF8 RID: 7160 RVA: 0x00084C9C File Offset: 0x00082E9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AotHelper.__c__2<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF9 RID: 7161 RVA: 0x00084CD8 File Offset: 0x00082ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738938, XrefRangeEnd = 738946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnsureList_b__2_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.__c__2<T>.NativeMethodInfoPtr__EnsureList_b__2_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BFA RID: 7162 RVA: 0x0000DC67 File Offset: 0x0000BE67
			public __c__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x06001BFB RID: 7163 RVA: 0x00084D0C File Offset: 0x00082F0C
			// (set) Token: 0x06001BFC RID: 7164 RVA: 0x0000DC70 File Offset: 0x0000BE70
			public unsafe static AotHelper.__c__2<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AotHelper.__c__2<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AotHelper.__c__2<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AotHelper.__c__2<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E7 RID: 2023
			// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00084D34 File Offset: 0x00082F34
			// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0000DC82 File Offset: 0x0000BE82
			public unsafe static Action __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AotHelper.__c__2<T>.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AotHelper.__c__2<T>.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014DB RID: 5339
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014DC RID: 5340
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040014DD RID: 5341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014DE RID: 5342
			private static readonly IntPtr NativeMethodInfoPtr__EnsureList_b__2_0_Internal_Void_0;
		}

		// Token: 0x02000168 RID: 360
		[ObfuscatedName("Newtonsoft.Json.Utilities.AotHelper+<>c__3`2")]
		[Serializable]
		public sealed class __c__3<TKey, TValue> : Object
		{
			// Token: 0x06001BFF RID: 7167 RVA: 0x00084D5C File Offset: 0x00082F5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<AotHelper.__c__3<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AotHelper>.NativeClassPtr, "<>c__3`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AotHelper.__c__3<TKey, TValue>>.NativeClassPtr);
				AotHelper.__c__3<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotHelper.__c__3<TKey, TValue>>.NativeClassPtr, "<>9");
				AotHelper.__c__3<TKey, TValue>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotHelper.__c__3<TKey, TValue>>.NativeClassPtr, "<>9__3_0");
				AotHelper.__c__3<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper.__c__3<TKey, TValue>>.NativeClassPtr, 100664538);
				AotHelper.__c__3<TKey, TValue>.NativeMethodInfoPtr__EnsureDictionary_b__3_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AotHelper.__c__3<TKey, TValue>>.NativeClassPtr, 100664539);
			}

			// Token: 0x06001C00 RID: 7168 RVA: 0x00084E24 File Offset: 0x00083024
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AotHelper.__c__3<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.__c__3<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C01 RID: 7169 RVA: 0x00084E60 File Offset: 0x00083060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738946, XrefRangeEnd = 738957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnsureDictionary_b__3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AotHelper.__c__3<TKey, TValue>.NativeMethodInfoPtr__EnsureDictionary_b__3_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C02 RID: 7170 RVA: 0x0000DC94 File Offset: 0x0000BE94
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E8 RID: 2024
			// (get) Token: 0x06001C03 RID: 7171 RVA: 0x00084E94 File Offset: 0x00083094
			// (set) Token: 0x06001C04 RID: 7172 RVA: 0x0000DC9D File Offset: 0x0000BE9D
			public unsafe static AotHelper.__c__3<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AotHelper.__c__3<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AotHelper.__c__3<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AotHelper.__c__3<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E9 RID: 2025
			// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00084EBC File Offset: 0x000830BC
			// (set) Token: 0x06001C06 RID: 7174 RVA: 0x0000DCAF File Offset: 0x0000BEAF
			public unsafe static Action __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AotHelper.__c__3<TKey, TValue>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AotHelper.__c__3<TKey, TValue>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014DF RID: 5343
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014E0 RID: 5344
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040014E1 RID: 5345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014E2 RID: 5346
			private static readonly IntPtr NativeMethodInfoPtr__EnsureDictionary_b__3_0_Internal_Void_0;
		}

		// Token: 0x02000169 RID: 361
		private sealed class MethodInfoStoreGeneric_EnsureType_Public_Static_Void_0<T>
		{
			// Token: 0x040014E3 RID: 5347
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AotHelper.NativeMethodInfoPtr_EnsureType_Public_Static_Void_0, Il2CppClassPointerStore<AotHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200016A RID: 362
		private sealed class MethodInfoStoreGeneric_EnsureList_Public_Static_Void_0<T>
		{
			// Token: 0x040014E4 RID: 5348
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AotHelper.NativeMethodInfoPtr_EnsureList_Public_Static_Void_0, Il2CppClassPointerStore<AotHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200016B RID: 363
		private sealed class MethodInfoStoreGeneric_EnsureDictionary_Public_Static_Void_0<TKey, TValue>
		{
			// Token: 0x040014E5 RID: 5349
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AotHelper.NativeMethodInfoPtr_EnsureDictionary_Public_Static_Void_0, Il2CppClassPointerStore<AotHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
