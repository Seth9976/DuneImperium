using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000045 RID: 69
	public class UnityMouseProvider : global::Il2CppSystem.Object
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x0001F168 File Offset: 0x0001D368
		// Note: this type is marked as 'beforefieldinit'.
		static UnityMouseProvider()
		{
			Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnityMouseProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr);
			UnityMouseProvider.NativeFieldInfoPtr_mouseXAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "mouseXAxis");
			UnityMouseProvider.NativeFieldInfoPtr_mouseYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "mouseYAxis");
			UnityMouseProvider.NativeFieldInfoPtr_lastButtonPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "lastButtonPressed");
			UnityMouseProvider.NativeFieldInfoPtr_buttonPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "buttonPressed");
			UnityMouseProvider.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "lastPosition");
			UnityMouseProvider.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "position");
			UnityMouseProvider.NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "delta");
			UnityMouseProvider.NativeFieldInfoPtr_scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "scroll");
			UnityMouseProvider.NativeFieldInfoPtr_maxSafeMouseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, "maxSafeMouseButton");
			UnityMouseProvider.NativeMethodInfoPtr_Setup_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664182);
			UnityMouseProvider.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664183);
			UnityMouseProvider.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664184);
			UnityMouseProvider.NativeMethodInfoPtr_SafeGetMouseButton_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664185);
			UnityMouseProvider.NativeMethodInfoPtr_ClearState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664186);
			UnityMouseProvider.NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664187);
			UnityMouseProvider.NativeMethodInfoPtr_GetDeltaX_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664188);
			UnityMouseProvider.NativeMethodInfoPtr_GetDeltaY_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664189);
			UnityMouseProvider.NativeMethodInfoPtr_GetDeltaScroll_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664190);
			UnityMouseProvider.NativeMethodInfoPtr_GetButtonIsPressed_Public_Virtual_Final_New_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664191);
			UnityMouseProvider.NativeMethodInfoPtr_GetButtonWasPressed_Public_Virtual_Final_New_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664192);
			UnityMouseProvider.NativeMethodInfoPtr_GetButtonWasReleased_Public_Virtual_Final_New_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664193);
			UnityMouseProvider.NativeMethodInfoPtr_HasMousePresent_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664194);
			UnityMouseProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr, 100664195);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001F364 File Offset: 0x0001D564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783991, XrefRangeEnd = 783992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_Setup_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001F398 File Offset: 0x0001D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783992, XrefRangeEnd = 784013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001F400 File Offset: 0x0001D600
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 784018, RefRangeEnd = 784025, XrefRangeStart = 784013, XrefRangeEnd = 784018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SafeGetMouseButton(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_SafeGetMouseButton_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001F440 File Offset: 0x0001D640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 784035, RefRangeEnd = 784038, XrefRangeStart = 784025, XrefRangeEnd = 784035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_ClearState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001F474 File Offset: 0x0001D674
		[CallerCount(0)]
		public unsafe virtual Vector2 GetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetDeltaX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_GetDeltaX_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001F4EC File Offset: 0x0001D6EC
		[CallerCount(0)]
		public unsafe virtual float GetDeltaY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_GetDeltaY_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001F528 File Offset: 0x0001D728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784038, XrefRangeEnd = 784043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetDeltaScroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_GetDeltaScroll_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001F564 File Offset: 0x0001D764
		[CallerCount(0)]
		public unsafe virtual bool GetButtonIsPressed(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_GetButtonIsPressed_Public_Virtual_Final_New_Boolean_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001F5B0 File Offset: 0x0001D7B0
		[CallerCount(0)]
		public unsafe virtual bool GetButtonWasPressed(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_GetButtonWasPressed_Public_Virtual_Final_New_Boolean_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001F5FC File Offset: 0x0001D7FC
		[CallerCount(0)]
		public unsafe virtual bool GetButtonWasReleased(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_GetButtonWasReleased_Public_Virtual_Final_New_Boolean_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001F648 File Offset: 0x0001D848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasMousePresent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr_HasMousePresent_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001F684 File Offset: 0x0001D884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784043, XrefRangeEnd = 784051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityMouseProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityMouseProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityMouseProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00004678 File Offset: 0x00002878
		public UnityMouseProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0001F6C0 File Offset: 0x0001D8C0
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00004681 File Offset: 0x00002881
		public unsafe static string mouseXAxis
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityMouseProvider.NativeFieldInfoPtr_mouseXAxis, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityMouseProvider.NativeFieldInfoPtr_mouseXAxis, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00004693 File Offset: 0x00002893
		public unsafe static string mouseYAxis
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityMouseProvider.NativeFieldInfoPtr_mouseYAxis, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityMouseProvider.NativeFieldInfoPtr_mouseYAxis, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0001F700 File Offset: 0x0001D900
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x000046A5 File Offset: 0x000028A5
		public unsafe Il2CppStructArray<bool> lastButtonPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_lastButtonPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_lastButtonPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0001F730 File Offset: 0x0001D930
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x000046C4 File Offset: 0x000028C4
		public unsafe Il2CppStructArray<bool> buttonPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_buttonPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_buttonPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001F760 File Offset: 0x0001D960
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x000046E3 File Offset: 0x000028E3
		public unsafe Vector2 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0001F788 File Offset: 0x0001D988
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x000046FE File Offset: 0x000028FE
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001F7B0 File Offset: 0x0001D9B0
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00004719 File Offset: 0x00002919
		public unsafe Vector2 delta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_delta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_delta)) = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00004734 File Offset: 0x00002934
		public unsafe Vector2 scroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_scroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityMouseProvider.NativeFieldInfoPtr_scroll)) = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0001F800 File Offset: 0x0001DA00
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0000474F File Offset: 0x0000294F
		public unsafe static int maxSafeMouseButton
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnityMouseProvider.NativeFieldInfoPtr_maxSafeMouseButton, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityMouseProvider.NativeFieldInfoPtr_maxSafeMouseButton, (void*)(&value));
			}
		}

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_mouseXAxis;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_mouseYAxis;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_lastButtonPressed;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_buttonPressed;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_delta;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_scroll;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_maxSafeMouseButton;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Final_New_Void_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_SafeGetMouseButton_Private_Static_Boolean_Int32_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Private_Void_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_GetDeltaX_Public_Virtual_Final_New_Single_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_GetDeltaY_Public_Virtual_Final_New_Single_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_GetDeltaScroll_Public_Virtual_Final_New_Single_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonIsPressed_Public_Virtual_Final_New_Boolean_Mouse_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonWasPressed_Public_Virtual_Final_New_Boolean_Mouse_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonWasReleased_Public_Virtual_Final_New_Boolean_Mouse_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_HasMousePresent_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
