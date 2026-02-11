using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002A6 RID: 678
	public class LeaderboardHelpButtonBehaviour : MonoBehaviour
	{
		// Token: 0x06002043 RID: 8259 RVA: 0x0008922C File Offset: 0x0008742C
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardHelpButtonBehaviour()
		{
			Il2CppClassPointerStore<LeaderboardHelpButtonBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "LeaderboardHelpButtonBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardHelpButtonBehaviour>.NativeClassPtr);
			LeaderboardHelpButtonBehaviour.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardHelpButtonBehaviour>.NativeClassPtr, "running");
			LeaderboardHelpButtonBehaviour.NativeFieldInfoPtr_helpLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardHelpButtonBehaviour>.NativeClassPtr, "helpLocKey");
			LeaderboardHelpButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardHelpButtonBehaviour>.NativeClassPtr, 100668656);
			LeaderboardHelpButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardHelpButtonBehaviour>.NativeClassPtr, 100668657);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000892AC File Offset: 0x000874AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542205, XrefRangeEnd = 542225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardHelpButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000892E0 File Offset: 0x000874E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542225, XrefRangeEnd = 542230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardHelpButtonBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardHelpButtonBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardHelpButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00010ECF File Offset: 0x0000F0CF
		public LeaderboardHelpButtonBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0008931C File Offset: 0x0008751C
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		public unsafe Command running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardHelpButtonBehaviour.NativeFieldInfoPtr_running);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardHelpButtonBehaviour.NativeFieldInfoPtr_running), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0008934C File Offset: 0x0008754C
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x00010EF7 File Offset: 0x0000F0F7
		public unsafe string helpLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardHelpButtonBehaviour.NativeFieldInfoPtr_helpLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardHelpButtonBehaviour.NativeFieldInfoPtr_helpLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr_helpLocKey;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_Event_Show_Public_Void_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
