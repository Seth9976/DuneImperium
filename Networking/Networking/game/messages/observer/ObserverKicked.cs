using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.game.messages.observer
{
	// Token: 0x020000B3 RID: 179
	public class ObserverKicked : NetworkMessageEvent
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x00005B2C File Offset: 0x00003D2C
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverKicked()
		{
			Il2CppClassPointerStore<ObserverKicked>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.observer", "ObserverKicked");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverKicked>.NativeClassPtr);
			ObserverKicked.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverKicked>.NativeClassPtr, 100663662);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000159AC File Offset: 0x00013BAC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverKicked()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverKicked>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverKicked.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00005B65 File Offset: 0x00003D65
		public ObserverKicked(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
