using System;
using Canis.messages.effect;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.game.messages.effect
{
	// Token: 0x020000B8 RID: 184
	public class FXUnitMessage : EffectMessage
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x00015CAC File Offset: 0x00013EAC
		// Note: this type is marked as 'beforefieldinit'.
		static FXUnitMessage()
		{
			Il2CppClassPointerStore<FXUnitMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.effect", "FXUnitMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXUnitMessage>.NativeClassPtr);
			FXUnitMessage.NativeFieldInfoPtr_LocationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnitMessage>.NativeClassPtr, "LocationID");
			FXUnitMessage.NativeFieldInfoPtr_FX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnitMessage>.NativeClassPtr, "FX");
			FXUnitMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnitMessage>.NativeClassPtr, 100663667);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00015D18 File Offset: 0x00013F18
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXUnitMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXUnitMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnitMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00005C43 File Offset: 0x00003E43
		public FXUnitMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00015D54 File Offset: 0x00013F54
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00005C4C File Offset: 0x00003E4C
		public unsafe EntityID LocationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnitMessage.NativeFieldInfoPtr_LocationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnitMessage.NativeFieldInfoPtr_LocationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00015D84 File Offset: 0x00013F84
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00005C6B File Offset: 0x00003E6B
		public unsafe string FX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnitMessage.NativeFieldInfoPtr_FX);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnitMessage.NativeFieldInfoPtr_FX), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_LocationID;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_FX;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
