using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace coreactionlog.actionlog
{
	// Token: 0x02000007 RID: 7
	public class ActionLogEntryMoveHandler : MonoBehaviour
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00003040 File Offset: 0x00001240
		// Note: this type is marked as 'beforefieldinit'.
		static ActionLogEntryMoveHandler()
		{
			Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-actionlog.dll", "coreactionlog.actionlog", "ActionLogEntryMoveHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr);
			ActionLogEntryMoveHandler.NativeFieldInfoPtr_actionLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr, "actionLog");
			ActionLogEntryMoveHandler.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr, "selectable");
			ActionLogEntryMoveHandler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr, 100663311);
			ActionLogEntryMoveHandler.NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr, 100663312);
			ActionLogEntryMoveHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000030D4 File Offset: 0x000012D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259564, XrefRangeEnd = 1259571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogEntryMoveHandler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003108 File Offset: 0x00001308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259571, XrefRangeEnd = 1259583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogEntryMoveHandler.NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000314C File Offset: 0x0000134C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionLogEntryMoveHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionLogEntryMoveHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogEntryMoveHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000216C File Offset: 0x0000036C
		public ActionLogEntryMoveHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003188 File Offset: 0x00001388
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002175 File Offset: 0x00000375
		public unsafe AttributeActionLog actionLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntryMoveHandler.NativeFieldInfoPtr_actionLog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeActionLog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntryMoveHandler.NativeFieldInfoPtr_actionLog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000031B8 File Offset: 0x000013B8
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002194 File Offset: 0x00000394
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntryMoveHandler.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntryMoveHandler.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_actionLog;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
