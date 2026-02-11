using System;
using Canis.attributes;
using Canis.gameLogs;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x02000274 RID: 628
	public class ActionLogData : VersionedDataComponent
	{
		// Token: 0x06001D62 RID: 7522 RVA: 0x0007F328 File Offset: 0x0007D528
		// Note: this type is marked as 'beforefieldinit'.
		static ActionLogData()
		{
			Il2CppClassPointerStore<ActionLogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "ActionLogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionLogData>.NativeClassPtr);
			ActionLogData.NativeFieldInfoPtr_ActonLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionLogData>.NativeClassPtr, "ActonLogs");
			ActionLogData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogData>.NativeClassPtr, 100668121);
			ActionLogData.NativeMethodInfoPtr_AddLog_Public_Void_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogData>.NativeClassPtr, 100668122);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x0007F394 File Offset: 0x0007D594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536956, XrefRangeEnd = 536977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionLogData(IAttribute<List<SerializedGameLog>> actionLogAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionLogData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionLogAttribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x0007F3E0 File Offset: 0x0007D5E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536985, RefRangeEnd = 536986, XrefRangeStart = 536977, XrefRangeEnd = 536985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLog(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogData.NativeMethodInfoPtr_AddLog_Public_Void_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0000F995 File Offset: 0x0000DB95
		public ActionLogData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x0007F424 File Offset: 0x0007D624
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0000F99E File Offset: 0x0000DB9E
		public unsafe List<SerializedGameLog> ActonLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogData.NativeFieldInfoPtr_ActonLogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedGameLog>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogData.NativeFieldInfoPtr_ActonLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr_ActonLogs;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_SerializedGameLog_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr_AddLog_Public_Void_SerializedGameLog_0;
	}
}
