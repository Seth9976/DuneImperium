using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000020 RID: 32
	public class ILayoutElement : Il2CppObjectBase
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x00017960 File Offset: 0x00015B60
		// Note: this type is marked as 'beforefieldinit'.
		static ILayoutElement()
		{
			Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ILayoutElement");
			ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663983);
			ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663984);
			ILayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663985);
			ILayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663986);
			ILayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663987);
			ILayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663988);
			ILayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663989);
			ILayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663990);
			ILayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663991);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00017A3C File Offset: 0x00015C3C
		[CallerCount(0)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00017A78 File Offset: 0x00015C78
		[CallerCount(0)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00017AB4 File Offset: 0x00015CB4
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00017AFC File Offset: 0x00015CFC
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00017B44 File Offset: 0x00015D44
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00017B8C File Offset: 0x00015D8C
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00017BD4 File Offset: 0x00015DD4
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00017C1C File Offset: 0x00015E1C
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00017C64 File Offset: 0x00015E64
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000037BA File Offset: 0x000019BA
		public ILayoutElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
