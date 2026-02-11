using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000161 RID: 353
	public sealed class SerializeField : Attribute
	{
		// Token: 0x06001A04 RID: 6660 RVA: 0x0000A096 File Offset: 0x00008296
		// Note: this type is marked as 'beforefieldinit'.
		static SerializeField()
		{
			Il2CppClassPointerStore<SerializeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SerializeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeField>.NativeClassPtr);
			SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeField>.NativeClassPtr, 100666918);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0007A4FC File Offset: 0x000786FC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializeField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0000A0CF File Offset: 0x000082CF
		public SerializeField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
