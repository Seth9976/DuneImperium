using System;
using Canis.messages.effect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200001E RID: 30
public class AnimationDelayEffect : EffectMessage
{
	// Token: 0x060002EA RID: 746 RVA: 0x0001DB3C File Offset: 0x0001BD3C
	// Note: this type is marked as 'beforefieldinit'.
	static AnimationDelayEffect()
	{
		Il2CppClassPointerStore<AnimationDelayEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AnimationDelayEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationDelayEffect>.NativeClassPtr);
		AnimationDelayEffect.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationDelayEffect>.NativeClassPtr, "Duration");
		AnimationDelayEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationDelayEffect>.NativeClassPtr, 100663677);
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0001DB94 File Offset: 0x0001BD94
	[CallerCount(220)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationDelayEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationDelayEffect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationDelayEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00003484 File Offset: 0x00001684
	public AnimationDelayEffect(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060002ED RID: 749 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
	// (set) Token: 0x060002EE RID: 750 RVA: 0x0000348D File Offset: 0x0000168D
	public unsafe int Duration
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationDelayEffect.NativeFieldInfoPtr_Duration);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationDelayEffect.NativeFieldInfoPtr_Duration)) = value;
		}
	}

	// Token: 0x04000215 RID: 533
	private static readonly IntPtr NativeFieldInfoPtr_Duration;

	// Token: 0x04000216 RID: 534
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
