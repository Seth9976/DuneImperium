using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	public class UnityEventString : UnityEvent<string>
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00002CDA File Offset: 0x00000EDA
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventString()
		{
			Il2CppClassPointerStore<UnityEventString>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventString>.NativeClassPtr);
			UnityEventString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventString>.NativeClassPtr, 100663500);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000BB2C File Offset: 0x00009D2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1120121, RefRangeEnd = 1120124, XrefRangeStart = 1120118, XrefRangeEnd = 1120121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002D13 File Offset: 0x00000F13
		public UnityEventString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
