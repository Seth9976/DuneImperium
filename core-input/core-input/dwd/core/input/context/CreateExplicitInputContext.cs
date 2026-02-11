using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI;

namespace dwd.core.input.context
{
	// Token: 0x02000075 RID: 117
	public sealed class CreateExplicitInputContext : CreateInputContext
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x00014B3C File Offset: 0x00012D3C
		// Note: this type is marked as 'beforefieldinit'.
		static CreateExplicitInputContext()
		{
			Il2CppClassPointerStore<CreateExplicitInputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "CreateExplicitInputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateExplicitInputContext>.NativeClassPtr);
			CreateExplicitInputContext.NativeFieldInfoPtr_explicitAvailableSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateExplicitInputContext>.NativeClassPtr, "explicitAvailableSelectables");
			CreateExplicitInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateExplicitInputContext>.NativeClassPtr, 100663796);
			CreateExplicitInputContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateExplicitInputContext>.NativeClassPtr, 100663797);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00014BA8 File Offset: 0x00012DA8
		public unsafe override IEnumerable<Selectable> availableSelectables
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateExplicitInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00014BE8 File Offset: 0x00012DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122732, XrefRangeEnd = 1122737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateExplicitInputContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateExplicitInputContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateExplicitInputContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00004945 File Offset: 0x00002B45
		public CreateExplicitInputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00014C24 File Offset: 0x00012E24
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0000494E File Offset: 0x00002B4E
		public unsafe Il2CppReferenceArray<Selectable> explicitAvailableSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateExplicitInputContext.NativeFieldInfoPtr_explicitAvailableSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateExplicitInputContext.NativeFieldInfoPtr_explicitAvailableSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_explicitAvailableSelectables;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
