using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x02000032 RID: 50
	[Serializable]
	public class UnityEventEntityListSelection : UnityEvent<IEntityListSelection>
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00002E24 File Offset: 0x00001024
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventEntityListSelection()
		{
			Il2CppClassPointerStore<UnityEventEntityListSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventEntityListSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventEntityListSelection>.NativeClassPtr);
			UnityEventEntityListSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventEntityListSelection>.NativeClassPtr, 100663505);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000BC58 File Offset: 0x00009E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120137, XrefRangeEnd = 1120140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventEntityListSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventEntityListSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventEntityListSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002E5D File Offset: 0x0000105D
		public UnityEventEntityListSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
