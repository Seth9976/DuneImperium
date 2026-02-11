using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule.selectOnActivation
{
	// Token: 0x02000092 RID: 146
	public class OnActivationSelector : UIBehaviour
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		// Note: this type is marked as 'beforefieldinit'.
		static OnActivationSelector()
		{
			Il2CppClassPointerStore<OnActivationSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.selectOnActivation", "OnActivationSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnActivationSelector>.NativeClassPtr);
			OnActivationSelector.NativeFieldInfoPtr_initialSelectionStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnActivationSelector>.NativeClassPtr, "initialSelectionStrategy");
			OnActivationSelector.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnActivationSelector>.NativeClassPtr, 100664067);
			OnActivationSelector.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnActivationSelector>.NativeClassPtr, 100664068);
			OnActivationSelector.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnActivationSelector>.NativeClassPtr, 100664069);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0001AA38 File Offset: 0x00018C38
		public unsafe virtual string StrategyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnActivationSelector.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001AA70 File Offset: 0x00018C70
		[CallerCount(0)]
		public unsafe virtual GameObject GetSelection(GameObject lastSelectionOnDeactivation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastSelectionOnDeactivation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnActivationSelector.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_GameObject_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001AACC File Offset: 0x00018CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnActivationSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnActivationSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnActivationSelector.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000563E File Offset: 0x0000383E
		public OnActivationSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0001AB08 File Offset: 0x00018D08
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00005647 File Offset: 0x00003847
		public unsafe string initialSelectionStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnActivationSelector.NativeFieldInfoPtr_initialSelectionStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnActivationSelector.NativeFieldInfoPtr_initialSelectionStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_initialSelectionStrategy;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_GameObject_GameObject_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
