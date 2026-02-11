using System;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000E8 RID: 232
	public class ITriggeredAbility : Il2CppObjectBase
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x00045708 File Offset: 0x00043908
		// Note: this type is marked as 'beforefieldinit'.
		static ITriggeredAbility()
		{
			Il2CppClassPointerStore<ITriggeredAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "ITriggeredAbility");
			ITriggeredAbility.NativeMethodInfoPtr_get_TriggerCostTiming_Public_Abstract_Virtual_New_get_TriggerCostTimings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredAbility>.NativeClassPtr, 100665486);
			ITriggeredAbility.NativeMethodInfoPtr_get_EventNames_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredAbility>.NativeClassPtr, 100665487);
			ITriggeredAbility.NativeMethodInfoPtr_IsValidFor_Public_Abstract_Virtual_New_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredAbility>.NativeClassPtr, 100665488);
			ITriggeredAbility.NativeMethodInfoPtr_get_TriggerOutOfPlay_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredAbility>.NativeClassPtr, 100665489);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00045780 File Offset: 0x00043980
		public unsafe virtual TriggerCostTimings TriggerCostTiming
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredAbility.NativeMethodInfoPtr_get_TriggerCostTiming_Public_Abstract_Virtual_New_get_TriggerCostTimings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x000457C8 File Offset: 0x000439C8
		public unsafe virtual Il2CppStringArray EventNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredAbility.NativeMethodInfoPtr_get_EventNames_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00045814 File Offset: 0x00043A14
		[CallerCount(0)]
		public unsafe virtual IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredAbility.NativeMethodInfoPtr_IsValidFor_Public_Abstract_Virtual_New_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00045870 File Offset: 0x00043A70
		public unsafe virtual bool TriggerOutOfPlay
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredAbility.NativeMethodInfoPtr_get_TriggerOutOfPlay_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00005D33 File Offset: 0x00003F33
		public ITriggeredAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggerCostTiming_Public_Abstract_Virtual_New_get_TriggerCostTimings_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_EventNames_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Abstract_Virtual_New_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggerOutOfPlay_Public_Virtual_New_get_Boolean_0;
	}
}
