using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004B RID: 75
	public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute
	{
		// Token: 0x06000286 RID: 646 RVA: 0x000034DA File Offset: 0x000016DA
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsDeferredConvertListToArray()
		{
			Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsDeferredConvertListToArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr);
			NativeContainerSupportsDeferredConvertListToArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr, 100663519);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001CF80 File Offset: 0x0001B180
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsDeferredConvertListToArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsDeferredConvertListToArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00003513 File Offset: 0x00001713
		public NativeContainerSupportsDeferredConvertListToArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
