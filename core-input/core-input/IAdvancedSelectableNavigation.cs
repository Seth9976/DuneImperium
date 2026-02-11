using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000007 RID: 7
public class IAdvancedSelectableNavigation : Il2CppObjectBase
{
	// Token: 0x06000022 RID: 34 RVA: 0x000077E8 File Offset: 0x000059E8
	// Note: this type is marked as 'beforefieldinit'.
	static IAdvancedSelectableNavigation()
	{
		Il2CppClassPointerStore<IAdvancedSelectableNavigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "", "IAdvancedSelectableNavigation");
		IAdvancedSelectableNavigation.NativeMethodInfoPtr_get_AllowSelectionWhenNoninteractable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAdvancedSelectableNavigation>.NativeClassPtr, 100663308);
		IAdvancedSelectableNavigation.NativeMethodInfoPtr_get_SourceSelectionCenter_Public_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAdvancedSelectableNavigation>.NativeClassPtr, 100663309);
		IAdvancedSelectableNavigation.NativeMethodInfoPtr_GetNavDataByDirection_Public_Abstract_Virtual_New_DirectionalNavigationData_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAdvancedSelectableNavigation>.NativeClassPtr, 100663310);
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000023 RID: 35 RVA: 0x0000784C File Offset: 0x00005A4C
	public unsafe virtual bool AllowSelectionWhenNoninteractable
	{
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAdvancedSelectableNavigation.NativeMethodInfoPtr_get_AllowSelectionWhenNoninteractable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000024 RID: 36 RVA: 0x00007894 File Offset: 0x00005A94
	public unsafe virtual Transform SourceSelectionCenter
	{
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAdvancedSelectableNavigation.NativeMethodInfoPtr_get_SourceSelectionCenter_Public_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000078E0 File Offset: 0x00005AE0
	[CallerCount(0)]
	public unsafe virtual DirectionalNavigationData GetNavDataByDirection(MoveDirection navDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref navDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAdvancedSelectableNavigation.NativeMethodInfoPtr_GetNavDataByDirection_Public_Abstract_Virtual_New_DirectionalNavigationData_MoveDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr3) : null;
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002164 File Offset: 0x00000364
	public IAdvancedSelectableNavigation(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_get_AllowSelectionWhenNoninteractable_Public_Virtual_New_get_Boolean_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr_get_SourceSelectionCenter_Public_Virtual_New_get_Transform_0;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr_GetNavDataByDirection_Public_Abstract_Virtual_New_DirectionalNavigationData_MoveDirection_0;
}
