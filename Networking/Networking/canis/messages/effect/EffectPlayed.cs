using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.effect
{
	// Token: 0x02000045 RID: 69
	public class EffectPlayed : GameMessage
	{
		// Token: 0x0600024F RID: 591 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		// Note: this type is marked as 'beforefieldinit'.
		static EffectPlayed()
		{
			Il2CppClassPointerStore<EffectPlayed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "EffectPlayed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPlayed>.NativeClassPtr);
			EffectPlayed.NativeFieldInfoPtr_EffectMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPlayed>.NativeClassPtr, "EffectMessage");
			EffectPlayed.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPlayed>.NativeClassPtr, 100663412);
			EffectPlayed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPlayed>.NativeClassPtr, 100663413);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000BD44 File Offset: 0x00009F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193736, XrefRangeEnd = 1193739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectPlayed.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000BD88 File Offset: 0x00009F88
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectPlayed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPlayed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPlayed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000038B5 File Offset: 0x00001AB5
		public EffectPlayed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000BDC4 File Offset: 0x00009FC4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000038BE File Offset: 0x00001ABE
		public unsafe EffectMessage EffectMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPlayed.NativeFieldInfoPtr_EffectMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPlayed.NativeFieldInfoPtr_EffectMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_EffectMessage;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
