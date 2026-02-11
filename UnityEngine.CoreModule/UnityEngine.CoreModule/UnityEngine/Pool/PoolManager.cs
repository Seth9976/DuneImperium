using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Pool
{
	// Token: 0x020001D6 RID: 470
	public static class PoolManager : Object
	{
		// Token: 0x06002138 RID: 8504 RVA: 0x000926D8 File Offset: 0x000908D8
		// Note: this type is marked as 'beforefieldinit'.
		static PoolManager()
		{
			Il2CppClassPointerStore<PoolManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "PoolManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager>.NativeClassPtr);
			PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "s_WeakPoolReferences");
			PoolManager.NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100667773);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00092730 File Offset: 0x00090930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680931, RefRangeEnd = 680932, XrefRangeStart = 680905, XrefRangeEnd = 680931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(IPool pool)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0000CB63 File Offset: 0x0000AD63
		public PoolManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00092768 File Offset: 0x00090968
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		public unsafe static List<WeakReference<IPool>> s_WeakPoolReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference<IPool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00092790 File Offset: 0x00090990
		public static void Reset()
		{
			for (int i = PoolManager.s_WeakPoolReferences.Count - 1; i >= 0; i--)
			{
				IPool pool;
				bool flag = PoolManager.s_WeakPoolReferences[i].TryGetTarget(out pool);
				if (flag)
				{
					pool.Clear();
				}
				else
				{
					PoolManager.s_WeakPoolReferences.RemoveAt(i);
				}
			}
		}

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeFieldInfoPtr_s_WeakPoolReferences;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0;
	}
}
