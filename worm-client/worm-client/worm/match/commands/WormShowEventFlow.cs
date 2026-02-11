using System;
using dwd.core.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace worm.match.commands
{
	// Token: 0x02000241 RID: 577
	public class WormShowEventFlow : Command
	{
		// Token: 0x060018CE RID: 6350 RVA: 0x0006382C File Offset: 0x00061A2C
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowEventFlow()
		{
			Il2CppClassPointerStore<WormShowEventFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormShowEventFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEventFlow>.NativeClassPtr);
			WormShowEventFlow.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventFlow>.NativeClassPtr, "eventData");
			WormShowEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventFlow>.NativeClassPtr, 100666798);
			WormShowEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventFlow>.NativeClassPtr, 100666799);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00063898 File Offset: 0x00061A98
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowEventFlow(DataComposition eventData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEventFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000638E4 File Offset: 0x00061AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719255, XrefRangeEnd = 719279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0000E9E0 File Offset: 0x0000CBE0
		public WormShowEventFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00063930 File Offset: 0x00061B30
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0000E9E9 File Offset: 0x0000CBE9
		public unsafe DataComposition eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventFlow.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventFlow.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;
	}
}
