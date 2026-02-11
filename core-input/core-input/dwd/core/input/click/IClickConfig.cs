using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.input.click
{
	// Token: 0x020000AB RID: 171
	public class IClickConfig : Il2CppObjectBase
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
		// Note: this type is marked as 'beforefieldinit'.
		static IClickConfig()
		{
			Il2CppClassPointerStore<IClickConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "IClickConfig");
			IClickConfig.NativeMethodInfoPtr_get_ClickSlop_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickConfig>.NativeClassPtr, 100664247);
			IClickConfig.NativeMethodInfoPtr_get_ClickTimeout_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickConfig>.NativeClassPtr, 100664248);
			IClickConfig.NativeMethodInfoPtr_get_ClickConsecutiveSlop_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickConfig>.NativeClassPtr, 100664249);
			IClickConfig.NativeMethodInfoPtr_get_ClickConsecutiveTimeout_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickConfig>.NativeClassPtr, 100664250);
			IClickConfig.NativeMethodInfoPtr_get_LongPressTimeout_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickConfig>.NativeClassPtr, 100664251);
			IClickConfig.NativeMethodInfoPtr_get_LongPressSlop_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickConfig>.NativeClassPtr, 100664252);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0001FF44 File Offset: 0x0001E144
		public unsafe virtual float ClickSlop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickConfig.NativeMethodInfoPtr_get_ClickSlop_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0001FF8C File Offset: 0x0001E18C
		public unsafe virtual float ClickTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickConfig.NativeMethodInfoPtr_get_ClickTimeout_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		public unsafe virtual float ClickConsecutiveSlop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickConfig.NativeMethodInfoPtr_get_ClickConsecutiveSlop_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0002001C File Offset: 0x0001E21C
		public unsafe virtual float ClickConsecutiveTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickConfig.NativeMethodInfoPtr_get_ClickConsecutiveTimeout_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00020064 File Offset: 0x0001E264
		public unsafe virtual float LongPressTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickConfig.NativeMethodInfoPtr_get_LongPressTimeout_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x000200AC File Offset: 0x0001E2AC
		public unsafe virtual float LongPressSlop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickConfig.NativeMethodInfoPtr_get_LongPressSlop_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00006061 File Offset: 0x00004261
		public IClickConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_get_ClickSlop_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_get_ClickTimeout_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_get_ClickConsecutiveSlop_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_get_ClickConsecutiveTimeout_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_get_LongPressTimeout_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_get_LongPressSlop_Public_Abstract_Virtual_New_get_Single_0;
	}
}
