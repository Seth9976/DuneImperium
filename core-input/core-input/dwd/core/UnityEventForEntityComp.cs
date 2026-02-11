using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public class UnityEventForEntityComp : UnityEvent<EntityComponent>
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00002DA0 File Offset: 0x00000FA0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventForEntityComp()
		{
			Il2CppClassPointerStore<UnityEventForEntityComp>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventForEntityComp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventForEntityComp>.NativeClassPtr);
			UnityEventForEntityComp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventForEntityComp>.NativeClassPtr, 100663503);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120131, XrefRangeEnd = 1120134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventForEntityComp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventForEntityComp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventForEntityComp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002DD9 File Offset: 0x00000FD9
		public UnityEventForEntityComp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
