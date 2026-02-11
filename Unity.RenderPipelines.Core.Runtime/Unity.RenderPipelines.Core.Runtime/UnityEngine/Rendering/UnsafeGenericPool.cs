using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200004E RID: 78
	public static class UnsafeGenericPool<T> : Object where T : new()
	{
		// Token: 0x060005C2 RID: 1474 RVA: 0x00022EE8 File Offset: 0x000210E8
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeGenericPool()
		{
			Il2CppClassPointerStore<UnsafeGenericPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "UnsafeGenericPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeGenericPool<T>>.NativeClassPtr);
			UnsafeGenericPool<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeGenericPool<T>>.NativeClassPtr, "s_Pool");
			UnsafeGenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeGenericPool<T>>.NativeClassPtr, 100664030);
			UnsafeGenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeGenericPool<T>>.NativeClassPtr, 100664031);
			UnsafeGenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeGenericPool<T>>.NativeClassPtr, 100664032);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00022FA4 File Offset: 0x000211A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960345, XrefRangeEnd = 960355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeGenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00022FD4 File Offset: 0x000211D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960355, XrefRangeEnd = 960365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeGenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return new ObjectPool<T>.PooledObject(intPtr3);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00023050 File Offset: 0x00021250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960365, XrefRangeEnd = 960377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeGenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000045A8 File Offset: 0x000027A8
		public UnsafeGenericPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000230BC File Offset: 0x000212BC
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000045B1 File Offset: 0x000027B1
		public unsafe static ObjectPool<T> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnsafeGenericPool<T>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnsafeGenericPool<T>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_T_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_T_0;
	}
}
