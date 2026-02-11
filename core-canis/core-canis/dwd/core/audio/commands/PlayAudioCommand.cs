using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.audio.commands
{
	// Token: 0x02000211 RID: 529
	public class PlayAudioCommand : Command
	{
		// Token: 0x06001D04 RID: 7428 RVA: 0x00086B14 File Offset: 0x00084D14
		// Note: this type is marked as 'beforefieldinit'.
		static PlayAudioCommand()
		{
			Il2CppClassPointerStore<PlayAudioCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.audio.commands", "PlayAudioCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAudioCommand>.NativeClassPtr);
			PlayAudioCommand.NativeFieldInfoPtr__AudioObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioCommand>.NativeClassPtr, "<AudioObject>k__BackingField");
			PlayAudioCommand.NativeMethodInfoPtr_get_AudioObject_Public_get_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioCommand>.NativeClassPtr, 100667977);
			PlayAudioCommand.NativeMethodInfoPtr_set_AudioObject_Protected_set_Void_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioCommand>.NativeClassPtr, 100667978);
			PlayAudioCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioCommand>.NativeClassPtr, 100667979);
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00086B94 File Offset: 0x00084D94
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x00086BD4 File Offset: 0x00084DD4
		public unsafe AudioObject AudioObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioCommand.NativeMethodInfoPtr_get_AudioObject_Public_get_AudioObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioCommand.NativeMethodInfoPtr_set_AudioObject_Protected_set_Void_AudioObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00086C18 File Offset: 0x00084E18
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayAudioCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAudioCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0000C62F File Offset: 0x0000A82F
		public PlayAudioCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00086C54 File Offset: 0x00084E54
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0000C638 File Offset: 0x0000A838
		public unsafe AudioObject _AudioObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioCommand.NativeFieldInfoPtr__AudioObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioCommand.NativeFieldInfoPtr__AudioObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr__AudioObject_k__BackingField;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_get_AudioObject_Public_get_AudioObject_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_set_AudioObject_Protected_set_Void_AudioObject_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
