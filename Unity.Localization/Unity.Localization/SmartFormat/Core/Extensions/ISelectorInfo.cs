using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Core.Extensions
{
	// Token: 0x0200008C RID: 140
	public class ISelectorInfo : Il2CppObjectBase
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x000233BC File Offset: 0x000215BC
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectorInfo()
		{
			Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Extensions", "ISelectorInfo");
			ISelectorInfo.NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664535);
			ISelectorInfo.NativeMethodInfoPtr_get_SelectorText_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664536);
			ISelectorInfo.NativeMethodInfoPtr_get_SelectorIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664537);
			ISelectorInfo.NativeMethodInfoPtr_get_SelectorOperator_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664538);
			ISelectorInfo.NativeMethodInfoPtr_get_Result_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664539);
			ISelectorInfo.NativeMethodInfoPtr_set_Result_Public_Abstract_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664540);
			ISelectorInfo.NativeMethodInfoPtr_get_Placeholder_Public_Abstract_Virtual_New_get_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664541);
			ISelectorInfo.NativeMethodInfoPtr_get_FormatDetails_Public_Abstract_Virtual_New_get_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectorInfo>.NativeClassPtr, 100664542);
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00023484 File Offset: 0x00021684
		public unsafe virtual Object CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000234D0 File Offset: 0x000216D0
		public unsafe virtual string SelectorText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_get_SelectorText_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00023514 File Offset: 0x00021714
		public unsafe virtual int SelectorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_get_SelectorIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0002355C File Offset: 0x0002175C
		public unsafe virtual string SelectorOperator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_get_SelectorOperator_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x000235A0 File Offset: 0x000217A0
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x000235EC File Offset: 0x000217EC
		public unsafe virtual Object Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_get_Result_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_set_Result_Public_Abstract_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0002363C File Offset: 0x0002183C
		public unsafe virtual Placeholder Placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_get_Placeholder_Public_Abstract_Virtual_New_get_Placeholder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr3) : null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00023688 File Offset: 0x00021888
		public unsafe virtual FormatDetails FormatDetails
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectorInfo.NativeMethodInfoPtr_get_FormatDetails_Public_Abstract_Virtual_New_get_FormatDetails_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatDetails>(intPtr3) : null;
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000049BF File Offset: 0x00002BBF
		public ISelectorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectorText_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectorIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectorOperator_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Public_Abstract_Virtual_New_set_Void_Object_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_get_Placeholder_Public_Abstract_Virtual_New_get_Placeholder_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatDetails_Public_Abstract_Virtual_New_get_FormatDetails_0;
	}
}
