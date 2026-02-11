using System;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001B7 RID: 439
	public class EventsForBoolPref : VersionedView<ISetting<bool>>
	{
		// Token: 0x060013CC RID: 5068 RVA: 0x0005DA78 File Offset: 0x0005BC78
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForBoolPref()
		{
			Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "EventsForBoolPref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr);
			EventsForBoolPref.NativeFieldInfoPtr_prefName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr, "prefName");
			EventsForBoolPref.NativeFieldInfoPtr_onValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr, "onValue");
			EventsForBoolPref.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr, 100666218);
			EventsForBoolPref.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr, 100666219);
			EventsForBoolPref.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr, 100666220);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0005DB0C File Offset: 0x0005BD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519762, XrefRangeEnd = 519775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForBoolPref.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0005DB48 File Offset: 0x0005BD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519775, XrefRangeEnd = 519782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForBoolPref.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0005DB84 File Offset: 0x0005BD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519782, XrefRangeEnd = 519795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForBoolPref()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForBoolPref>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForBoolPref.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0000B4B6 File Offset: 0x000096B6
		public EventsForBoolPref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0005DBC0 File Offset: 0x0005BDC0
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0000B4BF File Offset: 0x000096BF
		public unsafe string prefName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolPref.NativeFieldInfoPtr_prefName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolPref.NativeFieldInfoPtr_prefName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0005DBE8 File Offset: 0x0005BDE8
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0000B4DE File Offset: 0x000096DE
		public unsafe UnityEvent<bool> onValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolPref.NativeFieldInfoPtr_onValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolPref.NativeFieldInfoPtr_onValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_prefName;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeFieldInfoPtr_onValue;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
