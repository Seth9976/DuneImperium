using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using ImaginationOverflow.UniversalDeepLinking;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class DeeplinkingExample : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x000029A0 File Offset: 0x00000BA0
	// Note: this type is marked as 'beforefieldinit'.
	static DeeplinkingExample()
	{
		Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "", "DeeplinkingExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr);
		DeeplinkingExample.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, "Panel");
		DeeplinkingExample.NativeFieldInfoPtr_Reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, "Reference");
		DeeplinkingExample.NativeFieldInfoPtr_InstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, "InstructionText");
		DeeplinkingExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, 100663297);
		DeeplinkingExample.NativeMethodInfoPtr_SetupUi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, 100663298);
		DeeplinkingExample.NativeMethodInfoPtr_Instance_LinkActivated_Private_Void_LinkActivation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, 100663299);
		DeeplinkingExample.NativeMethodInfoPtr_UpdateContentSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, 100663300);
		DeeplinkingExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr, 100663301);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002A70 File Offset: 0x00000C70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239982, XrefRangeEnd = 1240013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeeplinkingExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002AA4 File Offset: 0x00000CA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240013, XrefRangeEnd = 1240015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupUi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeeplinkingExample.NativeMethodInfoPtr_SetupUi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240015, XrefRangeEnd = 1240046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Instance_LinkActivated(LinkActivation s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeeplinkingExample.NativeMethodInfoPtr_Instance_LinkActivated_Private_Void_LinkActivation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002B1C File Offset: 0x00000D1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240046, XrefRangeEnd = 1240053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateContentSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeeplinkingExample.NativeMethodInfoPtr_UpdateContentSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002B50 File Offset: 0x00000D50
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeeplinkingExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeeplinkingExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeeplinkingExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	public DeeplinkingExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000008 RID: 8 RVA: 0x00002B8C File Offset: 0x00000D8C
	// (set) Token: 0x06000009 RID: 9 RVA: 0x00002059 File Offset: 0x00000259
	public unsafe GameObject Panel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeeplinkingExample.NativeFieldInfoPtr_Panel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeeplinkingExample.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002BBC File Offset: 0x00000DBC
	// (set) Token: 0x0600000B RID: 11 RVA: 0x00002078 File Offset: 0x00000278
	public unsafe GameObject Reference
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeeplinkingExample.NativeFieldInfoPtr_Reference);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeeplinkingExample.NativeFieldInfoPtr_Reference), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000C RID: 12 RVA: 0x00002BEC File Offset: 0x00000DEC
	// (set) Token: 0x0600000D RID: 13 RVA: 0x00002097 File Offset: 0x00000297
	public unsafe GameObject InstructionText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeeplinkingExample.NativeFieldInfoPtr_InstructionText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeeplinkingExample.NativeFieldInfoPtr_InstructionText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr_Panel;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeFieldInfoPtr_Reference;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeFieldInfoPtr_InstructionText;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_SetupUi_Private_Void_0;

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_Instance_LinkActivated_Private_Void_LinkActivation_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_UpdateContentSize_Private_Void_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
