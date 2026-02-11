using System;
using dbgclient;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class WormHandManager : MonoBehaviour
{
	// Token: 0x0600009A RID: 154 RVA: 0x0001A8CC File Offset: 0x00018ACC
	// Note: this type is marked as 'beforefieldinit'.
	static WormHandManager()
	{
		Il2CppClassPointerStore<WormHandManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormHandManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr);
		WormHandManager.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, "animator");
		WormHandManager.NativeFieldInfoPtr_hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, "hand");
		WormHandManager.NativeFieldInfoPtr_HiddenHandParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, "HiddenHandParam");
		WormHandManager.NativeFieldInfoPtr_StrongParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, "StrongParam");
		WormHandManager.NativeMethodInfoPtr_Event_SetHide_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, 100663395);
		WormHandManager.NativeMethodInfoPtr_Event_DisableHints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, 100663396);
		WormHandManager.NativeMethodInfoPtr_Event_SetHandSpacing_Public_Void_AnimationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, 100663397);
		WormHandManager.NativeMethodInfoPtr_Event_SetHandWidth_Public_Void_AnimationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, 100663398);
		WormHandManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr, 100663399);
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0001A9B0 File Offset: 0x00018BB0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 687489, RefRangeEnd = 687491, XrefRangeStart = 687474, XrefRangeEnd = 687489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_SetHide(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandManager.NativeMethodInfoPtr_Event_SetHide_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0001A9F0 File Offset: 0x00018BF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687491, XrefRangeEnd = 687500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_DisableHints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandManager.NativeMethodInfoPtr_Event_DisableHints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0001AA24 File Offset: 0x00018C24
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_SetHandSpacing(AnimationEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandManager.NativeMethodInfoPtr_Event_SetHandSpacing_Public_Void_AnimationEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0001AA68 File Offset: 0x00018C68
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_SetHandWidth(AnimationEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandManager.NativeMethodInfoPtr_Event_SetHandWidth_Public_Void_AnimationEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0001AAAC File Offset: 0x00018CAC
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormHandManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHandManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002508 File Offset: 0x00000708
	public WormHandManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x0001AAE8 File Offset: 0x00018CE8
	// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002511 File Offset: 0x00000711
	public unsafe Animator animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandManager.NativeFieldInfoPtr_animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandManager.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x0001AB18 File Offset: 0x00018D18
	// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002530 File Offset: 0x00000730
	public unsafe DBGFanView hand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandManager.NativeFieldInfoPtr_hand);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGFanView>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandManager.NativeFieldInfoPtr_hand), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x0001AB48 File Offset: 0x00018D48
	// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000254F File Offset: 0x0000074F
	public unsafe static int HiddenHandParam
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(WormHandManager.NativeFieldInfoPtr_HiddenHandParam, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WormHandManager.NativeFieldInfoPtr_HiddenHandParam, (void*)(&value));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x0001AB64 File Offset: 0x00018D64
	// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000255D File Offset: 0x0000075D
	public unsafe static int StrongParam
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(WormHandManager.NativeFieldInfoPtr_StrongParam, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WormHandManager.NativeFieldInfoPtr_StrongParam, (void*)(&value));
		}
	}

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeFieldInfoPtr_animator;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeFieldInfoPtr_hand;

	// Token: 0x0400005C RID: 92
	private static readonly IntPtr NativeFieldInfoPtr_HiddenHandParam;

	// Token: 0x0400005D RID: 93
	private static readonly IntPtr NativeFieldInfoPtr_StrongParam;

	// Token: 0x0400005E RID: 94
	private static readonly IntPtr NativeMethodInfoPtr_Event_SetHide_Public_Void_Boolean_0;

	// Token: 0x0400005F RID: 95
	private static readonly IntPtr NativeMethodInfoPtr_Event_DisableHints_Public_Void_0;

	// Token: 0x04000060 RID: 96
	private static readonly IntPtr NativeMethodInfoPtr_Event_SetHandSpacing_Public_Void_AnimationEvent_0;

	// Token: 0x04000061 RID: 97
	private static readonly IntPtr NativeMethodInfoPtr_Event_SetHandWidth_Public_Void_AnimationEvent_0;

	// Token: 0x04000062 RID: 98
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
