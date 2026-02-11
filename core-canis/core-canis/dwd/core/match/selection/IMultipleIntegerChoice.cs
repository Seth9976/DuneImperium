using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x0200013B RID: 315
	public class IMultipleIntegerChoice : Il2CppObjectBase
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x00059CDC File Offset: 0x00057EDC
		// Note: this type is marked as 'beforefieldinit'.
		static IMultipleIntegerChoice()
		{
			Il2CppClassPointerStore<IMultipleIntegerChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IMultipleIntegerChoice");
			IMultipleIntegerChoice.NativeMethodInfoPtr_get_SelectedNumbers_Public_Abstract_Virtual_New_get_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMultipleIntegerChoice>.NativeClassPtr, 100665875);
			IMultipleIntegerChoice.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMultipleIntegerChoice>.NativeClassPtr, 100665876);
			IMultipleIntegerChoice.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMultipleIntegerChoice>.NativeClassPtr, 100665877);
			IMultipleIntegerChoice.NativeMethodInfoPtr_get_MaxToSelect_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMultipleIntegerChoice>.NativeClassPtr, 100665878);
			IMultipleIntegerChoice.NativeMethodInfoPtr_get_MinToSelect_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMultipleIntegerChoice>.NativeClassPtr, 100665879);
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x00059D68 File Offset: 0x00057F68
		public unsafe virtual IList<int> SelectedNumbers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMultipleIntegerChoice.NativeMethodInfoPtr_get_SelectedNumbers_Public_Abstract_Virtual_New_get_IList_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00059DB4 File Offset: 0x00057FB4
		[CallerCount(0)]
		public unsafe virtual void Select(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMultipleIntegerChoice.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00059E00 File Offset: 0x00058000
		[CallerCount(0)]
		public unsafe virtual void Unselect(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMultipleIntegerChoice.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00059E4C File Offset: 0x0005804C
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMultipleIntegerChoice.NativeMethodInfoPtr_get_MaxToSelect_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00059E94 File Offset: 0x00058094
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMultipleIntegerChoice.NativeMethodInfoPtr_get_MinToSelect_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0000819D File Offset: 0x0000639D
		public IMultipleIntegerChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNumbers_Public_Abstract_Virtual_New_get_IList_1_Int32_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
