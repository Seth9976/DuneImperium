using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public sealed class ExitGUIException : Exception
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x00003F55 File Offset: 0x00002155
		// Note: this type is marked as 'beforefieldinit'.
		static ExitGUIException()
		{
			Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ExitGUIException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr);
			ExitGUIException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr, 100663613);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00011290 File Offset: 0x0000F490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187717, RefRangeEnd = 1187718, XrefRangeStart = 1187705, XrefRangeEnd = 1187717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitGUIException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitGUIException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00003F8E File Offset: 0x0000218E
		public ExitGUIException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
