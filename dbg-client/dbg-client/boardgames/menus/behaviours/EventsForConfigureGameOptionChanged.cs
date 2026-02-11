using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001B8 RID: 440
	public class EventsForConfigureGameOptionChanged : VersionedView<IConfigureGameOptions.Option>
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x0005DC18 File Offset: 0x0005BE18
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForConfigureGameOptionChanged()
		{
			Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "EventsForConfigureGameOptionChanged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr);
			EventsForConfigureGameOptionChanged.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr, "optionName");
			EventsForConfigureGameOptionChanged.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr, "onChanged");
			EventsForConfigureGameOptionChanged.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr, 100666221);
			EventsForConfigureGameOptionChanged.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr, 100666222);
			EventsForConfigureGameOptionChanged.NativeMethodInfoPtr_Event_SetOption_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr, 100666223);
			EventsForConfigureGameOptionChanged.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr, 100666224);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0005DCC0 File Offset: 0x0005BEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519795, XrefRangeEnd = 519811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForConfigureGameOptionChanged.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0005DCFC File Offset: 0x0005BEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519811, XrefRangeEnd = 519815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForConfigureGameOptionChanged.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005DD38 File Offset: 0x0005BF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519815, XrefRangeEnd = 519817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetOption(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForConfigureGameOptionChanged.NativeMethodInfoPtr_Event_SetOption_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0005DD78 File Offset: 0x0005BF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519817, XrefRangeEnd = 519830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForConfigureGameOptionChanged()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForConfigureGameOptionChanged>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForConfigureGameOptionChanged.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0000B4FD File Offset: 0x000096FD
		public EventsForConfigureGameOptionChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0005DDB4 File Offset: 0x0005BFB4
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x0000B506 File Offset: 0x00009706
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForConfigureGameOptionChanged.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForConfigureGameOptionChanged.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0005DDDC File Offset: 0x0005BFDC
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x0000B525 File Offset: 0x00009725
		public unsafe UnityEvent<int> onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForConfigureGameOptionChanged.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForConfigureGameOptionChanged.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetOption_Public_Void_Int32_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
