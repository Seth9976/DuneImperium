using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000162 RID: 354
	public sealed class SerializeReference : Attribute
	{
		// Token: 0x06001A07 RID: 6663 RVA: 0x0000A0D8 File Offset: 0x000082D8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializeReference()
		{
			Il2CppClassPointerStore<SerializeReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SerializeReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeReference>.NativeClassPtr);
			SerializeReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReference>.NativeClassPtr, 100666919);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0007A538 File Offset: 0x00078738
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializeReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializeReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0000A111 File Offset: 0x00008311
		public SerializeReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
