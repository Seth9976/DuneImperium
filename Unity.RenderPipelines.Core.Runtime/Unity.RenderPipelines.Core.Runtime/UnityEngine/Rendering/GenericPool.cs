using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200004D RID: 77
	public static class GenericPool<T> : Object where T : new()
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x00022CEC File Offset: 0x00020EEC
		// Note: this type is marked as 'beforefieldinit'.
		static GenericPool()
		{
			Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GenericPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr);
			GenericPool<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, "s_Pool");
			GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100664026);
			GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100664027);
			GenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100664028);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00022DA8 File Offset: 0x00020FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 960321, RefRangeEnd = 960323, XrefRangeStart = 960313, XrefRangeEnd = 960321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00022DD8 File Offset: 0x00020FD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 960330, RefRangeEnd = 960335, XrefRangeStart = 960323, XrefRangeEnd = 960330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectPool<T>.PooledObject Get(out T value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return new ObjectPool<T>.PooledObject(intPtr3);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00022E54 File Offset: 0x00021054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 960343, RefRangeEnd = 960345, XrefRangeStart = 960335, XrefRangeEnd = 960343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(T toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = toRelease;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref toRelease;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000458D File Offset: 0x0000278D
		public GenericPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00022EC0 File Offset: 0x000210C0
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00004596 File Offset: 0x00002796
		public unsafe static ObjectPool<T> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericPool<T>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericPool<T>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_T_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_T_0;
	}
}
