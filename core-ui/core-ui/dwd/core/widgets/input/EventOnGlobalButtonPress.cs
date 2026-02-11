using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace dwd.core.widgets.input
{
	// Token: 0x0200000D RID: 13
	public class EventOnGlobalButtonPress : MonoBehaviour
	{
		// Token: 0x0600007F RID: 127 RVA: 0x000046A8 File Offset: 0x000028A8
		// Note: this type is marked as 'beforefieldinit'.
		static EventOnGlobalButtonPress()
		{
			Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.widgets.input", "EventOnGlobalButtonPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr);
			EventOnGlobalButtonPress.NativeFieldInfoPtr_ActionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, "ActionName");
			EventOnGlobalButtonPress.NativeFieldInfoPtr_OnPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, "OnPress");
			EventOnGlobalButtonPress.NativeFieldInfoPtr_innerCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, "innerCoroutine");
			EventOnGlobalButtonPress.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, 100663374);
			EventOnGlobalButtonPress.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, 100663375);
			EventOnGlobalButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, 100663376);
			EventOnGlobalButtonPress.NativeMethodInfoPtr__OnEnable_b__4_0_Private_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, 100663377);
			EventOnGlobalButtonPress.NativeMethodInfoPtr__OnEnable_b__4_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004778 File Offset: 0x00002978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254135, XrefRangeEnd = 1254143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnGlobalButtonPress.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000047AC File Offset: 0x000029AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254143, XrefRangeEnd = 1254144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnGlobalButtonPress.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000047E0 File Offset: 0x000029E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254144, XrefRangeEnd = 1254149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventOnGlobalButtonPress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnGlobalButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000481C File Offset: 0x00002A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254149, XrefRangeEnd = 1254166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command _OnEnable_b__4_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnGlobalButtonPress.NativeMethodInfoPtr__OnEnable_b__4_0_Private_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000485C File Offset: 0x00002A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254166, XrefRangeEnd = 1254178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__4_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnGlobalButtonPress.NativeMethodInfoPtr__OnEnable_b__4_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002357 File Offset: 0x00000557
		public EventOnGlobalButtonPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002360 File Offset: 0x00000560
		public unsafe string ActionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnGlobalButtonPress.NativeFieldInfoPtr_ActionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnGlobalButtonPress.NativeFieldInfoPtr_ActionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000048B8 File Offset: 0x00002AB8
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000237F File Offset: 0x0000057F
		public unsafe EventOnGlobalButtonPress.PressEvent OnPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnGlobalButtonPress.NativeFieldInfoPtr_OnPress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventOnGlobalButtonPress.PressEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnGlobalButtonPress.NativeFieldInfoPtr_OnPress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000048E8 File Offset: 0x00002AE8
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000239E File Offset: 0x0000059E
		public unsafe InterruptableCommand innerCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnGlobalButtonPress.NativeFieldInfoPtr_innerCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnGlobalButtonPress.NativeFieldInfoPtr_innerCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_ActionName;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_OnPress;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_innerCoroutine;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__4_0_Private_Command_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__4_1_Private_Void_0;

		// Token: 0x02000025 RID: 37
		[Serializable]
		public class PressEvent : UnityEvent<BaseEventData>
		{
			// Token: 0x06000170 RID: 368 RVA: 0x00002ADD File Offset: 0x00000CDD
			// Note: this type is marked as 'beforefieldinit'.
			static PressEvent()
			{
				Il2CppClassPointerStore<EventOnGlobalButtonPress.PressEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventOnGlobalButtonPress>.NativeClassPtr, "PressEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventOnGlobalButtonPress.PressEvent>.NativeClassPtr);
				EventOnGlobalButtonPress.PressEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnGlobalButtonPress.PressEvent>.NativeClassPtr, 100663379);
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00007388 File Offset: 0x00005588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254132, XrefRangeEnd = 1254135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PressEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventOnGlobalButtonPress.PressEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnGlobalButtonPress.PressEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000172 RID: 370 RVA: 0x00002B11 File Offset: 0x00000D11
			public PressEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040000DE RID: 222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
