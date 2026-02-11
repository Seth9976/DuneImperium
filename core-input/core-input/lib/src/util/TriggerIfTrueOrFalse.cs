using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace lib.src.util
{
	// Token: 0x02000012 RID: 18
	public class TriggerIfTrueOrFalse : MonoBehaviour
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00008BF8 File Offset: 0x00006DF8
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerIfTrueOrFalse()
		{
			Il2CppClassPointerStore<TriggerIfTrueOrFalse>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "lib.src.util", "TriggerIfTrueOrFalse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerIfTrueOrFalse>.NativeClassPtr);
			TriggerIfTrueOrFalse.NativeFieldInfoPtr_whenTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerIfTrueOrFalse>.NativeClassPtr, "whenTrue");
			TriggerIfTrueOrFalse.NativeFieldInfoPtr_onTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerIfTrueOrFalse>.NativeClassPtr, "onTrigger");
			TriggerIfTrueOrFalse.NativeMethodInfoPtr_Event_AttemptTrigger_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerIfTrueOrFalse>.NativeClassPtr, 100663368);
			TriggerIfTrueOrFalse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerIfTrueOrFalse>.NativeClassPtr, 100663369);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00008C78 File Offset: 0x00006E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119308, XrefRangeEnd = 1119309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AttemptTrigger(bool attemptValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attemptValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerIfTrueOrFalse.NativeMethodInfoPtr_Event_AttemptTrigger_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119309, XrefRangeEnd = 1119315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggerIfTrueOrFalse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerIfTrueOrFalse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerIfTrueOrFalse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002327 File Offset: 0x00000527
		public TriggerIfTrueOrFalse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00008CF4 File Offset: 0x00006EF4
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002330 File Offset: 0x00000530
		public unsafe bool whenTrue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerIfTrueOrFalse.NativeFieldInfoPtr_whenTrue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerIfTrueOrFalse.NativeFieldInfoPtr_whenTrue)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00008D1C File Offset: 0x00006F1C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000234B File Offset: 0x0000054B
		public unsafe UnityEvent onTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerIfTrueOrFalse.NativeFieldInfoPtr_onTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerIfTrueOrFalse.NativeFieldInfoPtr_onTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_whenTrue;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_onTrigger;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Event_AttemptTrigger_Public_Void_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
