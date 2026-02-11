using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.ui.ugui.collections
{
	// Token: 0x0200001B RID: 27
	public class IPaginatedDisplay : Il2CppObjectBase
	{
		// Token: 0x06000123 RID: 291 RVA: 0x000066B8 File Offset: 0x000048B8
		// Note: this type is marked as 'beforefieldinit'.
		static IPaginatedDisplay()
		{
			Il2CppClassPointerStore<IPaginatedDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui.ugui.collections", "IPaginatedDisplay");
			IPaginatedDisplay.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaginatedDisplay>.NativeClassPtr, 100663441);
			IPaginatedDisplay.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaginatedDisplay>.NativeClassPtr, 100663442);
			IPaginatedDisplay.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaginatedDisplay>.NativeClassPtr, 100663443);
			IPaginatedDisplay.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaginatedDisplay>.NativeClassPtr, 100663444);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00006730 File Offset: 0x00004930
		public unsafe virtual bool CanDecrementDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPaginatedDisplay.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006778 File Offset: 0x00004978
		public unsafe virtual bool CanIncrementDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPaginatedDisplay.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000067C0 File Offset: 0x000049C0
		[CallerCount(0)]
		public unsafe virtual void Event_DecrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPaginatedDisplay.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000067FC File Offset: 0x000049FC
		[CallerCount(0)]
		public unsafe virtual void Event_IncrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPaginatedDisplay.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002871 File Offset: 0x00000A71
		public IPaginatedDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementDisplay_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDisplay_Public_Abstract_Virtual_New_Void_0;
	}
}
