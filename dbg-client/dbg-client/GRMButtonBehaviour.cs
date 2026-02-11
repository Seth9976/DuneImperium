using System;
using dwd.canis.dbg_client.switchboard;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class GRMButtonBehaviour : MonoBehaviour
{
	// Token: 0x0600001B RID: 27 RVA: 0x0001D940 File Offset: 0x0001BB40
	// Note: this type is marked as 'beforefieldinit'.
	static GRMButtonBehaviour()
	{
		Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "GRMButtonBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr);
		GRMButtonBehaviour.NativeFieldInfoPtr_GRMButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr, "GRMButton");
		GRMButtonBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr, 100663307);
		GRMButtonBehaviour.NativeMethodInfoPtr_CheckGRMButtonEnabled_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr, 100663308);
		GRMButtonBehaviour.NativeMethodInfoPtr_Event_GoToGRM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr, 100663309);
		GRMButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr, 100663310);
		GRMButtonBehaviour.NativeMethodInfoPtr__CheckGRMButtonEnabled_b__2_0_Private_Void_GetSwitchboardFeatureCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr, 100663311);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494322, XrefRangeEnd = 494349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GRMButtonBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0001DA1C File Offset: 0x0001BC1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494349, XrefRangeEnd = 494375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CheckGRMButtonEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GRMButtonBehaviour.NativeMethodInfoPtr_CheckGRMButtonEnabled_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0001DA5C File Offset: 0x0001BC5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494375, XrefRangeEnd = 494401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_GoToGRM()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GRMButtonBehaviour.NativeMethodInfoPtr_Event_GoToGRM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0001DA90 File Offset: 0x0001BC90
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494401, XrefRangeEnd = 494409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GRMButtonBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GRMButtonBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GRMButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0001DACC File Offset: 0x0001BCCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494720, XrefRangeEnd = 494722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _CheckGRMButtonEnabled_b__2_0(GetSwitchboardFeatureCommand command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GRMButtonBehaviour.NativeMethodInfoPtr__CheckGRMButtonEnabled_b__2_0_Private_Void_GetSwitchboardFeatureCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000020E7 File Offset: 0x000002E7
	public GRMButtonBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000022 RID: 34 RVA: 0x0001DB10 File Offset: 0x0001BD10
	// (set) Token: 0x06000023 RID: 35 RVA: 0x000020F0 File Offset: 0x000002F0
	public unsafe GameObject GRMButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GRMButtonBehaviour.NativeFieldInfoPtr_GRMButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GRMButtonBehaviour.NativeFieldInfoPtr_GRMButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeFieldInfoPtr_GRMButton;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_CheckGRMButtonEnabled_Private_IEnumerator_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_Event_GoToGRM_Public_Void_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr__CheckGRMButtonEnabled_b__2_0_Private_Void_GetSwitchboardFeatureCommand_0;
}
