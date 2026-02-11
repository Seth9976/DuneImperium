using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.components
{
	// Token: 0x0200022E RID: 558
	public class ActionComponent : Object
	{
		// Token: 0x06001743 RID: 5955 RVA: 0x00076AE0 File Offset: 0x00074CE0
		// Note: this type is marked as 'beforefieldinit'.
		static ActionComponent()
		{
			Il2CppClassPointerStore<ActionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.components", "ActionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionComponent>.NativeClassPtr);
			ActionComponent.NativeFieldInfoPtr_SortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionComponent>.NativeClassPtr, "SortOrder");
			ActionComponent.NativeMethodInfoPtr_Do_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionComponent>.NativeClassPtr, 100668584);
			ActionComponent.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionComponent>.NativeClassPtr, 100668585);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00076B4C File Offset: 0x00074D4C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Do(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionComponent.NativeMethodInfoPtr_Do_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00076BA8 File Offset: 0x00074DA8
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionComponent(int sortOrder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sortOrder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionComponent.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0000B207 File Offset: 0x00009407
		public ActionComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x00076BF0 File Offset: 0x00074DF0
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x0000B210 File Offset: 0x00009410
		public unsafe int SortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionComponent.NativeFieldInfoPtr_SortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionComponent.NativeFieldInfoPtr_SortOrder)) = value;
			}
		}

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeFieldInfoPtr_SortOrder;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_Do_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;
	}
}
