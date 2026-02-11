using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A7 RID: 423
	public sealed class ExecutionContextSwitcher : ValueType
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x000A5294 File Offset: 0x000A3494
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionContextSwitcher()
		{
			Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ExecutionContextSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr);
			ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerEC");
			ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerECBelongsToScope");
			ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "hecsw");
			ExecutionContextSwitcher.NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "thread");
			ExecutionContextSwitcher.NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100668026);
			ExecutionContextSwitcher.NativeMethodInfoPtr_Undo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100668027);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000A533C File Offset: 0x000A353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353513, XrefRangeEnd = 1353514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UndoNoThrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContextSwitcher.NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000A5380 File Offset: 0x000A3580
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1353521, RefRangeEnd = 1353532, XrefRangeStart = 1353514, XrefRangeEnd = 1353521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContextSwitcher.NativeMethodInfoPtr_Undo_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00008D05 File Offset: 0x00006F05
		public ExecutionContextSwitcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00008D0E File Offset: 0x00006F0E
		public ExecutionContextSwitcher()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr))
		{
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000A53B8 File Offset: 0x000A35B8
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x00008D20 File Offset: 0x00006F20
		public ExecutionContext.Reader outerEC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC);
				return new ExecutionContext.Reader(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000A53E8 File Offset: 0x000A35E8
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x00008D4E File Offset: 0x00006F4E
		public unsafe bool outerECBelongsToScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope)) = value;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000A5410 File Offset: 0x000A3610
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x00008D69 File Offset: 0x00006F69
		public unsafe Object hecsw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000A5440 File Offset: 0x000A3640
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x00008D88 File Offset: 0x00006F88
		public unsafe Thread thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeFieldInfoPtr_outerEC;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeFieldInfoPtr_outerECBelongsToScope;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeFieldInfoPtr_hecsw;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeFieldInfoPtr_thread;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Internal_Void_0;
	}
}
