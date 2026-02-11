using System;
using dwd.core.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000025 RID: 37
public class RayCastTester : MonoBehaviour
{
	// Token: 0x0600012D RID: 301 RVA: 0x00014470 File Offset: 0x00012670
	// Note: this type is marked as 'beforefieldinit'.
	static RayCastTester()
	{
		Il2CppClassPointerStore<RayCastTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "RayCastTester");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayCastTester>.NativeClassPtr);
		RayCastTester.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastTester>.NativeClassPtr, "input");
		RayCastTester.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayCastTester>.NativeClassPtr, 100663525);
		RayCastTester.NativeMethodInfoPtr_onPressed_Private_Void_PressEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayCastTester>.NativeClassPtr, 100663526);
		RayCastTester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayCastTester>.NativeClassPtr, 100663527);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x000144F0 File Offset: 0x000126F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983356, XrefRangeEnd = 983370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayCastTester.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00014524 File Offset: 0x00012724
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983370, XrefRangeEnd = 983404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onPressed(PressEndedEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayCastTester.NativeMethodInfoPtr_onPressed_Private_Void_PressEndedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00014568 File Offset: 0x00012768
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RayCastTester()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RayCastTester>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayCastTester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000131 RID: 305 RVA: 0x000028B3 File Offset: 0x00000AB3
	public RayCastTester(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000132 RID: 306 RVA: 0x000145A4 File Offset: 0x000127A4
	// (set) Token: 0x06000133 RID: 307 RVA: 0x000028BC File Offset: 0x00000ABC
	public unsafe InputManager input
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayCastTester.NativeFieldInfoPtr_input);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayCastTester.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000BF RID: 191
	private static readonly IntPtr NativeFieldInfoPtr_input;

	// Token: 0x040000C0 RID: 192
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040000C1 RID: 193
	private static readonly IntPtr NativeMethodInfoPtr_onPressed_Private_Void_PressEndedEvent_0;

	// Token: 0x040000C2 RID: 194
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
