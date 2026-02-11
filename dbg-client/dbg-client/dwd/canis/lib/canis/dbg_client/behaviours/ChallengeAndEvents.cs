using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace dwd.canis.lib.canis.dbg_client.behaviours
{
	// Token: 0x02000064 RID: 100
	[Serializable]
	public sealed class ChallengeAndEvents : ValueType
	{
		// Token: 0x060003BD RID: 957 RVA: 0x00029640 File Offset: 0x00027840
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeAndEvents()
		{
			Il2CppClassPointerStore<ChallengeAndEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.behaviours", "ChallengeAndEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeAndEvents>.NativeClassPtr);
			ChallengeAndEvents.NativeFieldInfoPtr_challengeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeAndEvents>.NativeClassPtr, "challengeName");
			ChallengeAndEvents.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeAndEvents>.NativeClassPtr, "events");
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00003A2E File Offset: 0x00001C2E
		public ChallengeAndEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003A37 File Offset: 0x00001C37
		public ChallengeAndEvents()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeAndEvents>.NativeClassPtr))
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00029698 File Offset: 0x00027898
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003A49 File Offset: 0x00001C49
		public unsafe string challengeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeAndEvents.NativeFieldInfoPtr_challengeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeAndEvents.NativeFieldInfoPtr_challengeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000296C0 File Offset: 0x000278C0
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003A68 File Offset: 0x00001C68
		public unsafe UnityEvent events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeAndEvents.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeAndEvents.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_challengeName;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_events;
	}
}
