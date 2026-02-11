using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.camera
{
	// Token: 0x020002A1 RID: 673
	public class IVirtualCameraController : Il2CppObjectBase
	{
		// Token: 0x06002002 RID: 8194 RVA: 0x00088304 File Offset: 0x00086504
		// Note: this type is marked as 'beforefieldinit'.
		static IVirtualCameraController()
		{
			Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.camera", "IVirtualCameraController");
			IVirtualCameraController.NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668613);
			IVirtualCameraController.NativeMethodInfoPtr_get_CanTransition_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668614);
			IVirtualCameraController.NativeMethodInfoPtr_get_isTransitioning_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668615);
			IVirtualCameraController.NativeMethodInfoPtr_Interruptible_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668616);
			IVirtualCameraController.NativeMethodInfoPtr_LookupFlavors_Public_Abstract_Virtual_New_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668617);
			IVirtualCameraController.NativeMethodInfoPtr_GetCurrentPos_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668618);
			IVirtualCameraController.NativeMethodInfoPtr_GetCurrentZoom_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668619);
			IVirtualCameraController.NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668620);
			IVirtualCameraController.NativeMethodInfoPtr_Zoom_Public_Abstract_Virtual_New_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668621);
			IVirtualCameraController.NativeMethodInfoPtr_SetShake_Public_Virtual_New_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668622);
			IVirtualCameraController.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Void_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668623);
			IVirtualCameraController.NativeMethodInfoPtr_EndTransition_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualCameraController>.NativeClassPtr, 100668624);
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0008841C File Offset: 0x0008661C
		public unsafe virtual bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00088464 File Offset: 0x00086664
		public unsafe virtual bool CanTransition
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_get_CanTransition_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x000884AC File Offset: 0x000866AC
		public unsafe virtual bool isTransitioning
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_get_isTransitioning_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000884F4 File Offset: 0x000866F4
		[CallerCount(0)]
		public unsafe virtual bool Interruptible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_Interruptible_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0008853C File Offset: 0x0008673C
		[CallerCount(0)]
		public unsafe virtual HashSet<string> LookupFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_LookupFlavors_Public_Abstract_Virtual_New_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00088588 File Offset: 0x00086788
		[CallerCount(0)]
		public unsafe virtual Vector3 GetCurrentPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_GetCurrentPos_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000885D0 File Offset: 0x000867D0
		[CallerCount(0)]
		public unsafe virtual float GetCurrentZoom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_GetCurrentZoom_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00088618 File Offset: 0x00086818
		[CallerCount(0)]
		public unsafe virtual bool Move(Vector3 deltaChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaChange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Boolean_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0008866C File Offset: 0x0008686C
		[CallerCount(0)]
		public unsafe virtual bool Zoom(float direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_Zoom_Public_Abstract_Virtual_New_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000886C0 File Offset: 0x000868C0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetShake(float amplitude, float frequency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amplitude;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_SetShake_Public_Virtual_New_Boolean_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00088724 File Offset: 0x00086924
		[CallerCount(0)]
		public unsafe virtual void StartTransition(IVirtualCameraController previousVCC)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousVCC);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Void_IVirtualCameraController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00088774 File Offset: 0x00086974
		[CallerCount(0)]
		public unsafe virtual void EndTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualCameraController.NativeMethodInfoPtr_EndTransition_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00010D62 File Offset: 0x0000EF62
		public IVirtualCameraController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransition_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_get_isTransitioning_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_Interruptible_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_LookupFlavors_Public_Abstract_Virtual_New_HashSet_1_String_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPos_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentZoom_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Boolean_Vector3_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_Zoom_Public_Abstract_Virtual_New_Boolean_Single_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_SetShake_Public_Virtual_New_Boolean_Single_Single_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Void_IVirtualCameraController_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_EndTransition_Public_Abstract_Virtual_New_Void_0;
	}
}
