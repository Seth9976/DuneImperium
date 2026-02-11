using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000D2 RID: 210
	public class EnvironmentCameraPosition : MonoBehaviour
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x00032E7C File Offset: 0x0003107C
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentCameraPosition()
		{
			Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "EnvironmentCameraPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr);
			EnvironmentCameraPosition.NativeFieldInfoPtr_lookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, "lookAt");
			EnvironmentCameraPosition.NativeFieldInfoPtr_CanDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, "CanDrag");
			EnvironmentCameraPosition.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, "transitionDuration");
			EnvironmentCameraPosition.NativeFieldInfoPtr_fieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, "fieldOfView");
			EnvironmentCameraPosition.NativeFieldInfoPtr_positionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, "positionID");
			EnvironmentCameraPosition.NativeFieldInfoPtr_canTransitionToEnvironment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, "canTransitionToEnvironment");
			EnvironmentCameraPosition.NativeFieldInfoPtr_revertOnMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, "revertOnMovement");
			EnvironmentCameraPosition.NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, 100665023);
			EnvironmentCameraPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr, 100665024);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00032F60 File Offset: 0x00031160
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraPosition.NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00032F98 File Offset: 0x00031198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994166, XrefRangeEnd = 994170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentCameraPosition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00006D7F File Offset: 0x00004F7F
		public EnvironmentCameraPosition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00032FD4 File Offset: 0x000311D4
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00006D88 File Offset: 0x00004F88
		public unsafe Transform lookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_lookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_lookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00033004 File Offset: 0x00031204
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00006DA7 File Offset: 0x00004FA7
		public unsafe bool CanDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_CanDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_CanDrag)) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0003302C File Offset: 0x0003122C
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00006DC2 File Offset: 0x00004FC2
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00033054 File Offset: 0x00031254
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x00006DDD File Offset: 0x00004FDD
		public unsafe float fieldOfView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_fieldOfView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_fieldOfView)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0003307C File Offset: 0x0003127C
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00006DF8 File Offset: 0x00004FF8
		public unsafe string positionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_positionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_positionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000330A4 File Offset: 0x000312A4
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00006E17 File Offset: 0x00005017
		public unsafe bool canTransitionToEnvironment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_canTransitionToEnvironment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_canTransitionToEnvironment)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x000330CC File Offset: 0x000312CC
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00006E32 File Offset: 0x00005032
		public unsafe bool revertOnMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_revertOnMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraPosition.NativeFieldInfoPtr_revertOnMovement)) = value;
			}
		}

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_lookAt;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_CanDrag;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_fieldOfView;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_positionID;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_canTransitionToEnvironment;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr_revertOnMovement;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
