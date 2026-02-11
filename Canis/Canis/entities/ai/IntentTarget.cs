using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities.ai
{
	// Token: 0x0200010A RID: 266
	public class IntentTarget : Object
	{
		// Token: 0x06000C10 RID: 3088 RVA: 0x0004D46C File Offset: 0x0004B66C
		// Note: this type is marked as 'beforefieldinit'.
		static IntentTarget()
		{
			Il2CppClassPointerStore<IntentTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "IntentTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntentTarget>.NativeClassPtr);
			IntentTarget.NativeFieldInfoPtr_intentFitness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentTarget>.NativeClassPtr, "intentFitness");
			IntentTarget.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentTarget>.NativeClassPtr, "target");
			IntentTarget.NativeMethodInfoPtr__ctor_Public_Void_IntentFitness_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntentTarget>.NativeClassPtr, 100665909);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntentTarget(IntentFitness intentFitness, EntityID target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntentTarget>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intentFitness);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntentTarget.NativeMethodInfoPtr__ctor_Public_Void_IntentFitness_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0000647C File Offset: 0x0000467C
		public IntentTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0004D538 File Offset: 0x0004B738
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00006485 File Offset: 0x00004685
		public unsafe IntentFitness intentFitness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentTarget.NativeFieldInfoPtr_intentFitness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntentFitness>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentTarget.NativeFieldInfoPtr_intentFitness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0004D568 File Offset: 0x0004B768
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x000064A4 File Offset: 0x000046A4
		public unsafe EntityID target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentTarget.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentTarget.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_intentFitness;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntentFitness_EntityID_0;
	}
}
