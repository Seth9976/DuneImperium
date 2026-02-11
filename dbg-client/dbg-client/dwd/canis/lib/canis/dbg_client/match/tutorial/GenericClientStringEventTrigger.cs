using System;
using dwd.core.eventTriggers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.match.tutorial
{
	// Token: 0x02000054 RID: 84
	public class GenericClientStringEventTrigger : MonoBehaviour
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00027E7C File Offset: 0x0002607C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericClientStringEventTrigger()
		{
			Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.match.tutorial", "GenericClientStringEventTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr);
			GenericClientStringEventTrigger.NativeFieldInfoPtr_triggerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, "triggerName");
			GenericClientStringEventTrigger.NativeFieldInfoPtr_triggerMoreThanOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, "triggerMoreThanOnce");
			GenericClientStringEventTrigger.NativeFieldInfoPtr_isTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, "isTutorial");
			GenericClientStringEventTrigger.NativeFieldInfoPtr_clientEventResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, "clientEventResponder");
			GenericClientStringEventTrigger.NativeFieldInfoPtr_fired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, "fired");
			GenericClientStringEventTrigger.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, 100663813);
			GenericClientStringEventTrigger.NativeMethodInfoPtr_Event_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, 100663814);
			GenericClientStringEventTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr, 100663815);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00027F4C File Offset: 0x0002614C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499642, XrefRangeEnd = 499654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericClientStringEventTrigger.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00027F80 File Offset: 0x00026180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499654, XrefRangeEnd = 499664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericClientStringEventTrigger.NativeMethodInfoPtr_Event_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00027FB4 File Offset: 0x000261B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499664, XrefRangeEnd = 499668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericClientStringEventTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericClientStringEventTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericClientStringEventTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000036C2 File Offset: 0x000018C2
		public GenericClientStringEventTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00027FF0 File Offset: 0x000261F0
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000036CB File Offset: 0x000018CB
		public unsafe string triggerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_triggerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_triggerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00028018 File Offset: 0x00026218
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000036EA File Offset: 0x000018EA
		public unsafe bool triggerMoreThanOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_triggerMoreThanOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_triggerMoreThanOnce)) = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00028040 File Offset: 0x00026240
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003705 File Offset: 0x00001905
		public unsafe bool isTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_isTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_isTutorial)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00028068 File Offset: 0x00026268
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003720 File Offset: 0x00001920
		public unsafe ClientEventResponder clientEventResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_clientEventResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_clientEventResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00028098 File Offset: 0x00026298
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000373F File Offset: 0x0000193F
		public unsafe bool fired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_fired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericClientStringEventTrigger.NativeFieldInfoPtr_fired)) = value;
			}
		}

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_triggerName;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_triggerMoreThanOnce;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_isTutorial;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_clientEventResponder;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_fired;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_Event_Trigger_Public_Void_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
