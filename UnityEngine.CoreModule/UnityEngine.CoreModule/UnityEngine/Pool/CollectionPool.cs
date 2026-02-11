using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x020001D0 RID: 464
	public class CollectionPool<TCollection, TItem> : Object where TCollection : class, new()
	{
		// Token: 0x06002100 RID: 8448 RVA: 0x00091984 File Offset: 0x0008FB84
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionPool()
		{
			Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "CollectionPool`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr);
			CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "s_Pool");
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667747);
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667748);
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667749);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00091A54 File Offset: 0x0008FC54
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 680468, RefRangeEnd = 680518, XrefRangeStart = 680460, XrefRangeEnd = 680468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TCollection Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00091A84 File Offset: 0x0008FC84
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 680525, RefRangeEnd = 680545, XrefRangeStart = 680518, XrefRangeEnd = 680525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PooledObject<TCollection> Get(out TCollection value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(TCollection).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(TCollection).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TCollection>(intPtr5, false, false));
				}
				return new PooledObject<TCollection>(intPtr3);
			}
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00091B00 File Offset: 0x0008FD00
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 680582, RefRangeEnd = 680634, XrefRangeStart = 680545, XrefRangeEnd = 680582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(TCollection toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TCollection).IsValueType)
				{
					TCollection tcollection = toRelease;
					intPtr = ((tcollection is string) ? IL2CPP.ManagedStringToIl2Cpp(tcollection as string) : IL2CPP.Il2CppObjectBaseToPtr(tcollection as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref toRelease;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		public CollectionPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x00091B6C File Offset: 0x0008FD6C
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x0000C9CD File Offset: 0x0000ABCD
		public unsafe static ObjectPool<TCollection> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<TCollection>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_TCollection_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0;

		// Token: 0x02000919 RID: 2329
		[ObfuscatedName("UnityEngine.Pool.CollectionPool`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003B2F RID: 15151 RVA: 0x000BDDFC File Offset: 0x000BBFFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr);
				CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, "<>9");
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100667752);
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100667753);
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100667754);
			}

			// Token: 0x06003B30 RID: 15152 RVA: 0x000BDEC4 File Offset: 0x000BC0C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B31 RID: 15153 RVA: 0x000BDF00 File Offset: 0x000BC100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TCollection __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
			}

			// Token: 0x06003B32 RID: 15154 RVA: 0x000BDF3C File Offset: 0x000BC13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680457, XrefRangeEnd = 680460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__5_1(TCollection l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TCollection).IsValueType)
					{
						TCollection tcollection = l;
						intPtr = ((tcollection is string) ? IL2CPP.ManagedStringToIl2Cpp(tcollection as string) : IL2CPP.Il2CppObjectBaseToPtr(tcollection as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref l;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06003B33 RID: 15155 RVA: 0x000162E6 File Offset: 0x000144E6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x06003B34 RID: 15156 RVA: 0x000BDFB4 File Offset: 0x000BC1B4
			// (set) Token: 0x06003B35 RID: 15157 RVA: 0x000162EF File Offset: 0x000144EF
			public unsafe static CollectionPool<TCollection, TItem>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionPool<TCollection, TItem>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CFB RID: 11515
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002CFC RID: 11516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002CFD RID: 11517
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0;

			// Token: 0x04002CFE RID: 11518
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0;
		}
	}
}
