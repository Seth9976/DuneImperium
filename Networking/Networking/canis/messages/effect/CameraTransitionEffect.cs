using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.effect
{
	// Token: 0x02000043 RID: 67
	public class CameraTransitionEffect : EffectMessage
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0000BA2C File Offset: 0x00009C2C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraTransitionEffect()
		{
			Il2CppClassPointerStore<CameraTransitionEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "CameraTransitionEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraTransitionEffect>.NativeClassPtr);
			CameraTransitionEffect.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTransitionEffect>.NativeClassPtr, "PlayerID");
			CameraTransitionEffect.NativeFieldInfoPtr_CameraID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTransitionEffect>.NativeClassPtr, "CameraID");
			CameraTransitionEffect.NativeFieldInfoPtr_DelayAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTransitionEffect>.NativeClassPtr, "DelayAfter");
			CameraTransitionEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTransitionEffect>.NativeClassPtr, 100663408);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BAAC File Offset: 0x00009CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193735, XrefRangeEnd = 1193736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraTransitionEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraTransitionEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraTransitionEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000382B File Offset: 0x00001A2B
		public CameraTransitionEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000BAE8 File Offset: 0x00009CE8
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00003834 File Offset: 0x00001A34
		public unsafe AccountID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraTransitionEffect.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraTransitionEffect.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000BB18 File Offset: 0x00009D18
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00003853 File Offset: 0x00001A53
		public unsafe string CameraID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraTransitionEffect.NativeFieldInfoPtr_CameraID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraTransitionEffect.NativeFieldInfoPtr_CameraID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000BB40 File Offset: 0x00009D40
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00003872 File Offset: 0x00001A72
		public unsafe float DelayAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraTransitionEffect.NativeFieldInfoPtr_DelayAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraTransitionEffect.NativeFieldInfoPtr_DelayAfter)) = value;
			}
		}

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_CameraID;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_DelayAfter;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
