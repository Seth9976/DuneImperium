using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.canis.dbg_client.switchboard
{
	// Token: 0x0200006A RID: 106
	public class EventsForSwitchboardState : MonoBehaviour
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00029F74 File Offset: 0x00028174
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForSwitchboardState()
		{
			Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.switchboard", "EventsForSwitchboardState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr);
			EventsForSwitchboardState.NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr, "feature");
			EventsForSwitchboardState.NativeFieldInfoPtr_onLoadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr, "onLoadStart");
			EventsForSwitchboardState.NativeFieldInfoPtr_onEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr, "onEnabled");
			EventsForSwitchboardState.NativeFieldInfoPtr_onDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr, "onDisabled");
			EventsForSwitchboardState.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr, 100663904);
			EventsForSwitchboardState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr, 100663905);
			EventsForSwitchboardState.NativeMethodInfoPtr__Start_b__4_0_Private_Void_GetSwitchboardFeatureCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr, 100663906);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0002A030 File Offset: 0x00028230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500180, XrefRangeEnd = 500195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSwitchboardState.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0002A070 File Offset: 0x00028270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500195, XrefRangeEnd = 500212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForSwitchboardState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForSwitchboardState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSwitchboardState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0002A0AC File Offset: 0x000282AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500212, XrefRangeEnd = 500215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__4_0(GetSwitchboardFeatureCommand command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSwitchboardState.NativeMethodInfoPtr__Start_b__4_0_Private_Void_GetSwitchboardFeatureCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003C01 File Offset: 0x00001E01
		public EventsForSwitchboardState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0002A0F0 File Offset: 0x000282F0
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00003C0A File Offset: 0x00001E0A
		public unsafe string feature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_feature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_feature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0002A118 File Offset: 0x00028318
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003C29 File Offset: 0x00001E29
		public unsafe UnityEvent onLoadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_onLoadStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_onLoadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0002A148 File Offset: 0x00028348
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003C48 File Offset: 0x00001E48
		public unsafe UnityEvent onEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_onEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_onEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0002A178 File Offset: 0x00028378
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003C67 File Offset: 0x00001E67
		public unsafe UnityEvent onDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_onDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSwitchboardState.NativeFieldInfoPtr_onDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_feature;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_onLoadStart;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_onEnabled;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_onDisabled;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_0_Private_Void_GetSwitchboardFeatureCommand_0;
	}
}
