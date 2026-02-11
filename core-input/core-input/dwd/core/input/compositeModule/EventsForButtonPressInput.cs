using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000086 RID: 134
	public class EventsForButtonPressInput : MonoBehaviour
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00019614 File Offset: 0x00017814
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForButtonPressInput()
		{
			Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "EventsForButtonPressInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr);
			EventsForButtonPressInput.NativeFieldInfoPtr_inputID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, "inputID");
			EventsForButtonPressInput.NativeFieldInfoPtr_mustBeSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, "mustBeSelected");
			EventsForButtonPressInput.NativeFieldInfoPtr_wasSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, "wasSelected");
			EventsForButtonPressInput.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, "selectable");
			EventsForButtonPressInput.NativeFieldInfoPtr_inputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, "inputDetector");
			EventsForButtonPressInput.NativeFieldInfoPtr_onInputPressedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, "onInputPressedChange");
			EventsForButtonPressInput.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, 100664019);
			EventsForButtonPressInput.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, 100664020);
			EventsForButtonPressInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr, 100664021);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000196F8 File Offset: 0x000178F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124890, XrefRangeEnd = 1124909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForButtonPressInput.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001972C File Offset: 0x0001792C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124909, XrefRangeEnd = 1124928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForButtonPressInput.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00019760 File Offset: 0x00017960
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForButtonPressInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForButtonPressInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForButtonPressInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00005344 File Offset: 0x00003544
		public EventsForButtonPressInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001979C File Offset: 0x0001799C
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0000534D File Offset: 0x0000354D
		public unsafe string inputID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_inputID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_inputID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000197C4 File Offset: 0x000179C4
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x0000536C File Offset: 0x0000356C
		public unsafe bool mustBeSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_mustBeSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_mustBeSelected)) = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x000197EC File Offset: 0x000179EC
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00005387 File Offset: 0x00003587
		public unsafe bool wasSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_wasSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_wasSelected)) = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00019814 File Offset: 0x00017A14
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x000053A2 File Offset: 0x000035A2
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00019844 File Offset: 0x00017A44
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x000053C1 File Offset: 0x000035C1
		public unsafe InputDetector inputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_inputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_inputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00019874 File Offset: 0x00017A74
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x000053E0 File Offset: 0x000035E0
		public unsafe UnityEventBool onInputPressedChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_onInputPressedChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForButtonPressInput.NativeFieldInfoPtr_onInputPressedChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_inputID;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_mustBeSelected;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_wasSelected;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_inputDetector;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_onInputPressedChange;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
