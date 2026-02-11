using System;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.events
{
	// Token: 0x020000B7 RID: 183
	[Serializable]
	public class SerializedRunEventBatch : SerializedAction
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x0003BC3C File Offset: 0x00039E3C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunEventBatch()
		{
			Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "SerializedRunEventBatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr);
			SerializedRunEventBatch.NativeFieldInfoPtr_SerializedEventContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr, "SerializedEventContext");
			SerializedRunEventBatch.NativeFieldInfoPtr_SerializedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr, "SerializedActions");
			SerializedRunEventBatch.NativeFieldInfoPtr_ExecutionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr, "ExecutionIndex");
			SerializedRunEventBatch.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr, 100665045);
			SerializedRunEventBatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr, 100665046);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0003BCD0 File Offset: 0x00039ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunEventBatch.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0003BD2C File Offset: 0x00039F2C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunEventBatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunEventBatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunEventBatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0000559A File Offset: 0x0000379A
		public SerializedRunEventBatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x0003BD68 File Offset: 0x00039F68
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x000055A3 File Offset: 0x000037A3
		public unsafe SerializedContext SerializedEventContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunEventBatch.NativeFieldInfoPtr_SerializedEventContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunEventBatch.NativeFieldInfoPtr_SerializedEventContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0003BD98 File Offset: 0x00039F98
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x000055C2 File Offset: 0x000037C2
		public unsafe Il2CppReferenceArray<SerializedAction> SerializedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunEventBatch.NativeFieldInfoPtr_SerializedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunEventBatch.NativeFieldInfoPtr_SerializedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0003BDC8 File Offset: 0x00039FC8
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x000055E1 File Offset: 0x000037E1
		public unsafe int ExecutionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunEventBatch.NativeFieldInfoPtr_ExecutionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunEventBatch.NativeFieldInfoPtr_ExecutionIndex)) = value;
			}
		}

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_SerializedEventContext;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_SerializedActions;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_ExecutionIndex;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
