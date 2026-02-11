using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.messages.effect
{
	// Token: 0x02000042 RID: 66
	public class AIDelayEffect : EffectMessage
	{
		// Token: 0x0600023A RID: 570 RVA: 0x0000B970 File Offset: 0x00009B70
		// Note: this type is marked as 'beforefieldinit'.
		static AIDelayEffect()
		{
			Il2CppClassPointerStore<AIDelayEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "AIDelayEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIDelayEffect>.NativeClassPtr);
			AIDelayEffect.NativeFieldInfoPtr_DelayMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIDelayEffect>.NativeClassPtr, "DelayMagnitude");
			AIDelayEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIDelayEffect>.NativeClassPtr, 100663407);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIDelayEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIDelayEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIDelayEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003807 File Offset: 0x00001A07
		public AIDelayEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000BA04 File Offset: 0x00009C04
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00003810 File Offset: 0x00001A10
		public unsafe float DelayMagnitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIDelayEffect.NativeFieldInfoPtr_DelayMagnitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIDelayEffect.NativeFieldInfoPtr_DelayMagnitude)) = value;
			}
		}

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_DelayMagnitude;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
