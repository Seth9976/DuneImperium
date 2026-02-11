using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace boardgames.camera
{
	// Token: 0x02000156 RID: 342
	public class BaseCameraManager : MonoBehaviour
	{
		// Token: 0x06001161 RID: 4449 RVA: 0x000464F0 File Offset: 0x000446F0
		// Note: this type is marked as 'beforefieldinit'.
		static BaseCameraManager()
		{
			Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.camera", "BaseCameraManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr);
			BaseCameraManager.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665845);
			BaseCameraManager.NativeMethodInfoPtr_HandleDrag_Public_Abstract_Virtual_New_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665846);
			BaseCameraManager.NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Abstract_Virtual_New_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665847);
			BaseCameraManager.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665848);
			BaseCameraManager.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665849);
			BaseCameraManager.NativeMethodInfoPtr_EndDrag_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665850);
			BaseCameraManager.NativeMethodInfoPtr_HandleScroll_Public_Abstract_Virtual_New_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665851);
			BaseCameraManager.NativeMethodInfoPtr_BlocksHover_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665852);
			BaseCameraManager.NativeMethodInfoPtr_LoadPosition_Public_Abstract_Virtual_New_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665853);
			BaseCameraManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr, 100665854);
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x000465E8 File Offset: 0x000447E8
		public unsafe virtual int Priority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00046630 File Offset: 0x00044830
		[CallerCount(0)]
		public unsafe virtual bool HandleDrag(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_HandleDrag_Public_Abstract_Virtual_New_Boolean_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00046688 File Offset: 0x00044888
		[CallerCount(0)]
		public unsafe virtual bool HandleEnvironmentDrag(Transform trans)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Abstract_Virtual_New_Boolean_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x000466E0 File Offset: 0x000448E0
		[CallerCount(0)]
		public unsafe virtual void StartDrag(Vector2 pressPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0004672C File Offset: 0x0004492C
		[CallerCount(0)]
		public unsafe virtual void OnDrag(Vector2 pressPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00046778 File Offset: 0x00044978
		[CallerCount(0)]
		public unsafe virtual void EndDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_EndDrag_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000467B4 File Offset: 0x000449B4
		[CallerCount(0)]
		public unsafe virtual bool HandleScroll(float scrollDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_HandleScroll_Public_Abstract_Virtual_New_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00046808 File Offset: 0x00044A08
		[CallerCount(0)]
		public unsafe virtual bool BlocksHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_BlocksHover_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00046850 File Offset: 0x00044A50
		[CallerCount(0)]
		public unsafe virtual IEnumerator LoadPosition(string positionTag = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(positionTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCameraManager.NativeMethodInfoPtr_LoadPosition_Public_Abstract_Virtual_New_IEnumerator_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000468AC File Offset: 0x00044AAC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseCameraManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCameraManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCameraManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0000A227 File Offset: 0x00008427
		public BaseCameraManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_HandleDrag_Public_Abstract_Virtual_New_Boolean_UnitView_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Abstract_Virtual_New_Boolean_Transform_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_Vector2_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_Vector2_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_HandleScroll_Public_Abstract_Virtual_New_Boolean_Single_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_BlocksHover_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_LoadPosition_Public_Abstract_Virtual_New_IEnumerator_String_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
