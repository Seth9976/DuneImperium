using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.audio.components
{
	// Token: 0x02000212 RID: 530
	public class AnimationPlaySound : MonoBehaviour
	{
		// Token: 0x06001D0B RID: 7435 RVA: 0x00086C84 File Offset: 0x00084E84
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlaySound()
		{
			Il2CppClassPointerStore<AnimationPlaySound>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.audio.components", "AnimationPlaySound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlaySound>.NativeClassPtr);
			AnimationPlaySound.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlaySound>.NativeClassPtr, "location");
			AnimationPlaySound.NativeMethodInfoPtr_PlaySound_Public_AudioObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlaySound>.NativeClassPtr, 100667980);
			AnimationPlaySound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlaySound>.NativeClassPtr, 100667981);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00086CF0 File Offset: 0x00084EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886149, XrefRangeEnd = 886151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioObject PlaySound(string sound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlaySound.NativeMethodInfoPtr_PlaySound_Public_AudioObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00086D40 File Offset: 0x00084F40
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPlaySound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationPlaySound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlaySound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0000C657 File Offset: 0x0000A857
		public AnimationPlaySound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00086D7C File Offset: 0x00084F7C
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0000C660 File Offset: 0x0000A860
		public unsafe PlayAudioLocation location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlaySound.NativeFieldInfoPtr_location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlaySound.NativeFieldInfoPtr_location)) = value;
			}
		}

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_AudioObject_String_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
