using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x0200004F RID: 79
	public static class ListPool<T> : Object
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x000230E4 File Offset: 0x000212E4
		// Note: this type is marked as 'beforefieldinit'.
		static ListPool()
		{
			Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr);
			ListPool<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "s_Pool");
			ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100664034);
			ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_List_1_T_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100664035);
			ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100664036);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000231A0 File Offset: 0x000213A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 960321, RefRangeEnd = 960323, XrefRangeStart = 960321, XrefRangeEnd = 960323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000231D4 File Offset: 0x000213D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 960330, RefRangeEnd = 960335, XrefRangeStart = 960330, XrefRangeEnd = 960335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectPool<List<T>>.PooledObject Get(out List<T> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_List_1_T_byref_List_1_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new List<T>(intPtr4));
				return new ObjectPool<List<T>>.PooledObject(intPtr2);
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00023224 File Offset: 0x00021424
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 960343, RefRangeEnd = 960345, XrefRangeStart = 960343, XrefRangeEnd = 960345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<T> toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000045C3 File Offset: 0x000027C3
		public ListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0002325C File Offset: 0x0002145C
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x000045CC File Offset: 0x000027CC
		public unsafe static ObjectPool<List<T>> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListPool<T>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListPool<T>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_List_1_T_byref_List_1_T_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;

		// Token: 0x02000180 RID: 384
		[ObfuscatedName("UnityEngine.Rendering.ListPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600163C RID: 5692 RVA: 0x000605F0 File Offset: 0x0005E7F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ListPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPool<T>.__c>.NativeClassPtr);
				ListPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>.__c>.NativeClassPtr, "<>9");
				ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>.__c>.NativeClassPtr, 100664039);
				ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>.__c>.NativeClassPtr, 100664040);
			}

			// Token: 0x0600163D RID: 5693 RVA: 0x00060694 File Offset: 0x0005E894
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600163E RID: 5694 RVA: 0x000606D0 File Offset: 0x0005E8D0
			[CallerCount(0)]
			public unsafe void __cctor_b__4_0(List<T> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600163F RID: 5695 RVA: 0x0000B335 File Offset: 0x00009535
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x06001640 RID: 5696 RVA: 0x00060714 File Offset: 0x0005E914
			// (set) Token: 0x06001641 RID: 5697 RVA: 0x0000B33E File Offset: 0x0000953E
			public unsafe static ListPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001036 RID: 4150
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001037 RID: 4151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001038 RID: 4152
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_List_1_T_0;
		}
	}
}
