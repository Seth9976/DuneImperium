using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ui
{
	// Token: 0x020002A2 RID: 674
	public class SettingsButtonBehaviour : MonoBehaviour
	{
		// Token: 0x06002010 RID: 8208 RVA: 0x000887B0 File Offset: 0x000869B0
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsButtonBehaviour()
		{
			Il2CppClassPointerStore<SettingsButtonBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.ui", "SettingsButtonBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsButtonBehaviour>.NativeClassPtr);
			SettingsButtonBehaviour.NativeFieldInfoPtr_showing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsButtonBehaviour>.NativeClassPtr, "showing");
			SettingsButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsButtonBehaviour>.NativeClassPtr, 100668625);
			SettingsButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsButtonBehaviour>.NativeClassPtr, 100668626);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0008881C File Offset: 0x00086A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541890, XrefRangeEnd = 541896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00088850 File Offset: 0x00086A50
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsButtonBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsButtonBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00010D6B File Offset: 0x0000EF6B
		public SettingsButtonBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x0008888C File Offset: 0x00086A8C
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x00010D74 File Offset: 0x0000EF74
		public unsafe Command showing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsButtonBehaviour.NativeFieldInfoPtr_showing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsButtonBehaviour.NativeFieldInfoPtr_showing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_showing;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_Event_Show_Public_Void_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
