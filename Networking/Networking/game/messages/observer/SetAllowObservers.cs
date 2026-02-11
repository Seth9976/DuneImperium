using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.game.messages.observer
{
	// Token: 0x020000B6 RID: 182
	public class SetAllowObservers : NetworkMessageEvent
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x00015BB4 File Offset: 0x00013DB4
		// Note: this type is marked as 'beforefieldinit'.
		static SetAllowObservers()
		{
			Il2CppClassPointerStore<SetAllowObservers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.observer", "SetAllowObservers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAllowObservers>.NativeClassPtr);
			SetAllowObservers.NativeFieldInfoPtr_AllowObservers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAllowObservers>.NativeClassPtr, "AllowObservers");
			SetAllowObservers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAllowObservers>.NativeClassPtr, 100663665);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00015C0C File Offset: 0x00013E0C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAllowObservers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAllowObservers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAllowObservers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00005BDD File Offset: 0x00003DDD
		public SetAllowObservers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00015C48 File Offset: 0x00013E48
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00005BE6 File Offset: 0x00003DE6
		public unsafe bool AllowObservers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAllowObservers.NativeFieldInfoPtr_AllowObservers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAllowObservers.NativeFieldInfoPtr_AllowObservers)) = value;
			}
		}

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_AllowObservers;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
