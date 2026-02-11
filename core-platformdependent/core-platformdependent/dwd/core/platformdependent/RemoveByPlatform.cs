using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x02000029 RID: 41
	public class RemoveByPlatform : MonoBehaviour
	{
		// Token: 0x06000159 RID: 345 RVA: 0x000070F4 File Offset: 0x000052F4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveByPlatform()
		{
			Il2CppClassPointerStore<RemoveByPlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "RemoveByPlatform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveByPlatform>.NativeClassPtr);
			RemoveByPlatform.NativeFieldInfoPtr_removeFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveByPlatform>.NativeClassPtr, "removeFrom");
			RemoveByPlatform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveByPlatform>.NativeClassPtr, 100663455);
			RemoveByPlatform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveByPlatform>.NativeClassPtr, 100663456);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007160 File Offset: 0x00005360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239857, XrefRangeEnd = 1239873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveByPlatform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007194 File Offset: 0x00005394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239873, XrefRangeEnd = 1239881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveByPlatform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveByPlatform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveByPlatform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002A11 File Offset: 0x00000C11
		public RemoveByPlatform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000071D0 File Offset: 0x000053D0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002A1A File Offset: 0x00000C1A
		public unsafe List<RuntimePlatform> removeFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveByPlatform.NativeFieldInfoPtr_removeFrom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveByPlatform.NativeFieldInfoPtr_removeFrom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_removeFrom;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
