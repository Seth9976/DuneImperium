using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000222 RID: 546
	public class ObjectListPool<T> : Object
	{
		// Token: 0x06002912 RID: 10514 RVA: 0x000B3E88 File Offset: 0x000B2088
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListPool()
		{
			Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ObjectListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr);
			ObjectListPool<T>.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr, "pool");
			ObjectListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr, 100669470);
			ObjectListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr, 100669471);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000B3F30 File Offset: 0x000B2130
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346143, RefRangeEnd = 346146, XrefRangeStart = 346136, XrefRangeEnd = 346143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000B3F64 File Offset: 0x000B2164
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346162, RefRangeEnd = 346165, XrefRangeStart = 346146, XrefRangeEnd = 346162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<T> elements)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00010948 File Offset: 0x0000EB48
		public ObjectListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x000B3F9C File Offset: 0x000B219C
		// (set) Token: 0x06002917 RID: 10519 RVA: 0x00010951 File Offset: 0x0000EB51
		public unsafe static ObjectPool<List<T>> pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectListPool<T>.NativeFieldInfoPtr_pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectListPool<T>.NativeFieldInfoPtr_pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeFieldInfoPtr_pool;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;

		// Token: 0x0200052C RID: 1324
		[ObfuscatedName("UnityEngine.UIElements.ObjectListPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004088 RID: 16520 RVA: 0x000FFF20 File Offset: 0x000FE120
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectListPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListPool<T>.__c>.NativeClassPtr);
				ObjectListPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListPool<T>.__c>.NativeClassPtr, "<>9");
				ObjectListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListPool<T>.__c>.NativeClassPtr, 100669474);
				ObjectListPool<T>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListPool<T>.__c>.NativeClassPtr, 100669475);
			}

			// Token: 0x06004089 RID: 16521 RVA: 0x000FFFC4 File Offset: 0x000FE1C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600408A RID: 16522 RVA: 0x00100000 File Offset: 0x000FE200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346133, XrefRangeEnd = 346136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<T> __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListPool<T>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}

			// Token: 0x0600408B RID: 16523 RVA: 0x0001B2C2 File Offset: 0x000194C2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001353 RID: 4947
			// (get) Token: 0x0600408C RID: 16524 RVA: 0x00100040 File Offset: 0x000FE240
			// (set) Token: 0x0600408D RID: 16525 RVA: 0x0001B2CB File Offset: 0x000194CB
			public unsafe static ObjectListPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectListPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectListPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D6B RID: 11627
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D6C RID: 11628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D6D RID: 11629
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_List_1_T_0;
		}
	}
}
