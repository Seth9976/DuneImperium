using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match.selection
{
	// Token: 0x0200013D RID: 317
	public class ISingleIntegerChoice : Il2CppObjectBase
	{
		// Token: 0x060011A7 RID: 4519 RVA: 0x00059FC4 File Offset: 0x000581C4
		// Note: this type is marked as 'beforefieldinit'.
		static ISingleIntegerChoice()
		{
			Il2CppClassPointerStore<ISingleIntegerChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ISingleIntegerChoice");
			ISingleIntegerChoice.NativeMethodInfoPtr_get_SelectedNumber_Public_Abstract_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISingleIntegerChoice>.NativeClassPtr, 100665882);
			ISingleIntegerChoice.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISingleIntegerChoice>.NativeClassPtr, 100665883);
			ISingleIntegerChoice.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISingleIntegerChoice>.NativeClassPtr, 100665884);
			ISingleIntegerChoice.NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISingleIntegerChoice>.NativeClassPtr, 100665885);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x0005A03C File Offset: 0x0005823C
		public unsafe virtual Nullable<int> SelectedNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISingleIntegerChoice.NativeMethodInfoPtr_get_SelectedNumber_Public_Abstract_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0005A080 File Offset: 0x00058280
		[CallerCount(0)]
		public unsafe virtual void Select(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISingleIntegerChoice.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0005A0CC File Offset: 0x000582CC
		[CallerCount(0)]
		public unsafe virtual void Unselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISingleIntegerChoice.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0005A108 File Offset: 0x00058308
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISingleIntegerChoice.NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000081AF File Offset: 0x000063AF
		public ISingleIntegerChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNumber_Public_Abstract_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_Int32_0;
	}
}
