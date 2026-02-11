using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017E RID: 382
	public sealed class ComputedTransitionProperty : ValueType
	{
		// Token: 0x06001CD7 RID: 7383 RVA: 0x00083BE4 File Offset: 0x00081DE4
		// Note: this type is marked as 'beforefieldinit'.
		static ComputedTransitionProperty()
		{
			Il2CppClassPointerStore<ComputedTransitionProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ComputedTransitionProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputedTransitionProperty>.NativeClassPtr);
			ComputedTransitionProperty.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionProperty>.NativeClassPtr, "id");
			ComputedTransitionProperty.NativeFieldInfoPtr_durationMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionProperty>.NativeClassPtr, "durationMs");
			ComputedTransitionProperty.NativeFieldInfoPtr_delayMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionProperty>.NativeClassPtr, "delayMs");
			ComputedTransitionProperty.NativeFieldInfoPtr_easingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionProperty>.NativeClassPtr, "easingCurve");
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0000CD07 File Offset: 0x0000AF07
		public ComputedTransitionProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0000CD10 File Offset: 0x0000AF10
		public ComputedTransitionProperty()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputedTransitionProperty>.NativeClassPtr))
		{
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00083C64 File Offset: 0x00081E64
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0000CD22 File Offset: 0x0000AF22
		public unsafe UnityEngine.UIElements.StyleSheets.StylePropertyId id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00083C8C File Offset: 0x00081E8C
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0000CD3D File Offset: 0x0000AF3D
		public unsafe int durationMs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_durationMs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_durationMs)) = value;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00083CB4 File Offset: 0x00081EB4
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0000CD58 File Offset: 0x0000AF58
		public unsafe int delayMs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_delayMs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_delayMs)) = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00083CDC File Offset: 0x00081EDC
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0000CD73 File Offset: 0x0000AF73
		public unsafe Func<float, float> easingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_easingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedTransitionProperty.NativeFieldInfoPtr_easingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeFieldInfoPtr_durationMs;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeFieldInfoPtr_delayMs;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeFieldInfoPtr_easingCurve;
	}
}
